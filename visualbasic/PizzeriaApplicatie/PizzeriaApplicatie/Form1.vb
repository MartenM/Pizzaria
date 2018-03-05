Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Form1
    Dim tijd As Integer = 120
    Dim database As DrlDatabase
    Dim huidige_row As Integer
    Dim huidige_id As Integer

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
        Me.Invoke(
            Sub()
                Label_StatusUpdate.Text = ""
            End Sub
        )
    End Sub

    Private Sub Label_UpdateIn_Click(sender As Object, e As EventArgs) Handles Label_UpdateIn.Click
        tijd = 0
    End Sub

    ' Functie die word uitgevoerd wanneer Form1 (Mainform) opend.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hier zorgen we er voor dat het database object present is en dat alle gegevens er in worden geladen.
        database = New DrlDatabase
        database.adres = My.Settings.db_adres
        database.username = My.Settings.db_username
        database.wachtwoord = My.Settings.db_wachtwoord
        database.database = My.Settings.db_database

        Label_StatusUpdate.Text = ""
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
        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            connection.Close()
            DGV_Main.Rows.Remove(DGV_Main.Rows(huidige_row))
            setStatusLabel("Bestelling succesvol gesloten.", Color.Green)
        End Try
    End Sub

    Private Sub BT_Cancel_Click(sender As Object, e As EventArgs) Handles BT_Cancel.Click
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET status='CANCELLED' WHERE id = " + huidige_id.ToString()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            connection.Close()
            DGV_Main.Rows.Remove(DGV_Main.Rows(huidige_row))
            setStatusLabel("Bestelling succesvol gecancelled.", Color.Green)
        End Try
    End Sub

    Private Sub BT_Opslaan_Click(sender As Object, e As EventArgs) Handles BT_Opslaan.Click
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET adres=?, bestelling=? WHERE id = " + huidige_id.ToString()
            command.Parameters.AddWithValue("@adres", TB_Adres.Text)
            command.Parameters.AddWithValue("@bestelling", TB_Bestelling.Text)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            connection.Close()
            setStatusLabel("Bestelling succesvol geüpdated", Color.Green)
        End Try


    End Sub

    Private Sub BT_OpenBestellingen_Click(sender As Object, e As EventArgs) Handles BT_OpenBestellingen.Click
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
        TB_Bestelling.Text = DGV_Main(1, e.RowIndex).Value
        TB_Adres.Text = DGV_Main(3, e.RowIndex).Value
    End Sub
End Class
