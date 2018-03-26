Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Form1
    Dim tijd As Integer = 120
    Dim database As DrlDatabase
    Dim huidige_row As Integer
    Dim huidige_id As Integer

    Dim modus As Mode = Nothing

    Public Sub updateDataGridView(ByVal query As String)
        label_tijd.Text = "Updaten van bestellingen... "

        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()

            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataset As New DataSet

            adapter.Fill(dataset)

            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub setStatusLabel(ByVal message As String, ByVal color As Color)
        Label_StatusUpdate.Text = message
        Label_StatusUpdate.ForeColor = color

        Dim thread As New Thread(AddressOf resetStatusLabel)
        thread.Start()
    End Sub

    Private Sub resetStatusLabel()
        Thread.Sleep(2000)
        If Me.IsDisposed Then
            Return
        End If
        Me.Invoke(
            Sub()
                Label_StatusUpdate.Text = ""
            End Sub
        )
    End Sub

    Private Sub resetView()
        Panel_BestellingOpties.Visible = False
        Panel_UpdateStatus.Visible = False
        UpdateTimer.Stop()
        DGV_Main.DataSource = Nothing
    End Sub

    Private Sub Label_UpdateIn_Click(sender As Object, e As EventArgs) Handles Label_UpdateIn.Click
        tijd = 0
    End Sub

    ' Functie die word uitgevoerd wanneer Form1 (Mainform) opend.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hier zorgen we er voor dat het database object present is en dat alle gegevens er in worden geladen.
        database = New DrlDatabase
        Label_StatusUpdate.Text = ""
    End Sub

    Private Sub laadDatabaseOpties()
        database.adres = My.Settings.db_adres
        database.username = My.Settings.db_username
        database.wachtwoord = My.Settings.db_wachtwoord
        database.database = My.Settings.db_database
    End Sub

    ' Functie die word uitgevoerd wanneer de timer 1000ms is verstreken.
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        If (tijd = 0) Then
            tijd = 120
            updateDataGridView("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant  where status = 'OPEN' ORDER BY datum ASC")
        Else
            tijd -= 1
            label_tijd.Text = tijd

            If tijd > 10 Then
                label_tijd.ForeColor = Color.Black
            Else
                label_tijd.ForeColor = Color.Orange
            End If
        End If
    End Sub

    Private Sub BT_Afhandelen_Click(sender As Object, e As EventArgs) Handles BT_Afhandelen.Click
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET status='GESLOTEN' WHERE id = " + huidige_id.ToString()
            command.ExecuteNonQuery()
            setStatusLabel("Bestelling succesvol afgehandelt", Color.Green)
        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BT_Cancel_Click(sender As Object, e As EventArgs) Handles BT_Cancel.Click
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET status='CANCELLED' WHERE id = " + huidige_id.ToString()
            command.ExecuteNonQuery()

            setStatusLabel("Bestelling succesvol gecancelled", Color.Green)
        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BT_Opslaan_Click(sender As Object, e As EventArgs) Handles BT_Opslaan.Click
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET adres=@adres, bestelling=@bestelling WHERE id = " + huidige_id.ToString()
            command.Parameters.AddWithValue("@adres", TB_Adres.Text)
            command.Parameters.AddWithValue("@bestelling", TB_Bestelling.Text)
            command.ExecuteNonQuery()
            setStatusLabel("Bestelling succesvol geüpdated", Color.Green)
        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try


    End Sub

    Private Sub BT_OpenBestellingen_Click(sender As Object, e As EventArgs) Handles BT_OpenBestellingen.Click
        modus = Mode.Bestellingen

        resetView()
        Panel_UpdateStatus.Visible = True
        UpdateTimer.Start()

        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()

            Dim adapter As New MySqlDataAdapter("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant  where status = 'OPEN' ORDER BY datum ASC", connection)
            Dim dataset As New DataSet

            adapter.Fill(dataset)

            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            connection.Close()
            setStatusLabel("Open bestellingen geladen.", Color.Black)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Main.RowHeaderMouseClick
        huidige_row = e.RowIndex
        huidige_id = DGV_Main(0, e.RowIndex).Value

        If modus = Mode.Bestellingen Then
            TB_Bestelling.Text = DGV_Main(1, e.RowIndex).Value
            TB_Adres.Text = DGV_Main(3, e.RowIndex).Value
            If (DGV_Main(2, e.RowIndex).Value) Then
                Label_Afhalen.Text = "JA"
            Else
                Label_Afhalen.Text = "NEE"
            End If

            Panel_BestellingOpties.Visible = True
        End If
    End Sub

    Private Sub OptiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptiesToolStripMenuItem.Click
        Dim dialog As New DatabaseOpties()
        dialog.ShowDialog()

        If (dialog.DialogResult = DialogResult.OK) Then
            My.Settings.db_adres = dialog.TB_Adres.Text
            My.Settings.db_username = dialog.TB_Gebruikersnaam.Text
            My.Settings.db_wachtwoord = dialog.TB_Wachtwoord.Text
            My.Settings.db_database = dialog.TB_Database.Text
            My.Settings.Save()
            laadDatabaseOpties()
        End If
    End Sub

    Private Sub BT_ZoekBestelling_Click(sender As Object, e As EventArgs) Handles BT_ZoekBestelling.Click
        resetView()
        modus = Mode.Bestellingen

        resetView()
        Dim dialog As New ZoekBestellingDialog()
        dialog.ShowDialog()

        If dialog.DialogResult <> DialogResult.OK Then
            Return
        End If

        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()

            Dim command As MySqlCommand

            If dialog.TB_BestellingID.Text <> "" Then
                command = New MySqlCommand("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant WHERE bestellingen.id=@bestellingid ORDER BY datum ASC", connection)
                command.Parameters.AddWithValue("@bestellingid", Integer.Parse(dialog.TB_BestellingID.Text))
            ElseIf dialog.TB_KlantID.Text <> "" Then
                command = New MySqlCommand("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant WHERE klanten.id=@klantid ORDER BY datum ASC", connection)
                command.Parameters.AddWithValue("@klantid", Integer.Parse(dialog.TB_KlantID.Text))
            Else
                command = New MySqlCommand("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant WHERE bestelling LIKE @bestelling AND adres LIKE @adres AND status LIKE @status ORDER BY datum ASC", connection)
                command.Parameters.AddWithValue("@bestelling", "%" + dialog.TB_Bestelling.Text + "%")
                command.Parameters.AddWithValue("@adres", "%" + dialog.TB_Adres.Text + "%")
                command.Parameters.AddWithValue("@status", "%" + dialog.CB_Status.SelectedItem + "%")
            End If

            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = command

            Dim dataset As New DataSet

            adapter.Fill(dataset)

            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            connection.Close()
            setStatusLabel("Bestellingen geladen", Color.Black)
        End Try
    End Sub

    Private Sub BT_ZoekKlant_Click(sender As Object, e As EventArgs) Handles BT_ZoekKlant.Click
        modus = Mode.Klanten

        resetView()
        Dim dialog As New ZoekKlantDialog()
        dialog.ShowDialog()

        If dialog.DialogResult <> DialogResult.OK Then
            Return
        End If

        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()

            Dim command As MySqlCommand

            If dialog.TB_ID.Text = "" Then
                command = New MySqlCommand("SELECT id, voornaam, achternaam, registratie, email, spaarpunten, actief, banned FROM klanten WHERE voornaam LIKE @voornaam AND achternaam LIKE @achternaam AND email LIKE @email", connection)
                command.Parameters.AddWithValue("@voornaam", "%" + dialog.TB_Voornaam.Text + "%")
                command.Parameters.AddWithValue("@achternaam", "%" + dialog.TB_Achternaam.Text + "%")
                command.Parameters.AddWithValue("@email", "%" + dialog.TB_Email.Text + "%")
            Else
                command = New MySqlCommand("SELECT id, voornaam, achternaam, registratie, email, spaarpunten, actief, banned FROM klanten WHERE id=@id", connection)
                command.Parameters.AddWithValue("@id", Integer.Parse(dialog.TB_ID.Text))
            End If

            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = command

            Dim dataset As New DataSet

            adapter.Fill(dataset)

            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            connection.Close()
            setStatusLabel("Klanten geladen", Color.Black)
        End Try

    End Sub
End Class
