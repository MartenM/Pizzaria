' Imports die in dit project worden gebruikt.
Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class Form1
    ' Public variablen.
    ' Deze variablen worden door het hele Form gebruikt om verschillende dingen bij te houden.
    Dim tijd As Integer = 120
    Dim huidige_row As Integer
    Dim huidige_id As Integer

    ' DrlDataBase is een Classe die de benodigde informatie over de database bezit.
    ' Dit is handig zodat we niet continue dit opnieuw hoeven in te voeren.
    Dim database As DrlDatabase

    ' Modes geeft aan in welke modus de datagrid zich bevindt.
    ' Dit kan tot verschillende acties lijden. Immers je wilt niet dat het klanten dialog openspringt als je een pizza selecteerd.
    Dim modus As Mode = Nothing

    ' Dit is een methode die de datagridview update. Het argument voor deze methode is een MySql query.
    ' Deze methode zorgt er dus voor dat we niet 300x de zelfde code hoeven te schrijven, we volgen dus het DRY methode.
    Public Sub updateDataGridView(ByVal query As String)
        ' Met deze code zorgen we er voor dat de label verandert van text.
        label_tijd.Text = "Updaten van bestellingen... "

        ' Hier maken we een nieuwe connectie met de database.
        ' We maken hierbij gebruik van de DrlDatabase classe.
        Dim connection As MySqlConnection = database.grabConnection()

        ' Omdat niet altijd alles even goed gaat met DataBase connecties gebruiken we hier een Try Catch blok om errors op te vangen.
        Try
            ' Hier openen we de connectie met de database.
            connection.Open()

            ' Met een DataAdapter kunnen we informatie uit de database halen.
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataset As New DataSet

            ' Hier vullen we 
            adapter.Fill(dataset)

            ' Hier zorgen we er voor dat de DataGridView (DGV) de juiste data presenteert.
            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            ' In het geval van een error -> laat een message box met de error zien.
            MessageBox.Show("Error: " + ex.Message)
        Finally
            ' Last but not least, sluit de connectie.
            connection.Close()
        End Try
    End Sub

    ' Met deze methode kunnen we het status label updaten.
    Public Sub setStatusLabel(ByVal message As String, ByVal color As Color)
        Label_StatusUpdate.Text = message
        Label_StatusUpdate.ForeColor = color

        ' Start een nieuwe Thread in de achtergrond.
        Dim thread As New Thread(AddressOf resetStatusLabel)
        thread.Start()
    End Sub

    ' Met behulp van deze methode resetten we het status label.
    ' Deze methode MOET async gebruikt worden omdat anders de applicatie vastloopt.
    Private Sub resetStatusLabel()
        ' Slaap 2 seconden.
        Thread.Sleep(2000)

        ' Als het form dicht is...
        If Me.IsDisposed Then
            ' Stoppen we
            Return
        End If

        ' Invoke om de MainThread (om cross thread modifications te voorkomen).
        Me.Invoke(
            Sub()
                Label_StatusUpdate.Text = ""
            End Sub
        )
    End Sub

    ' Reset de view en alle opties.
    Private Sub resetView()
        Panel_BestellingOpties.Visible = False
        Panel_UpdateStatus.Visible = False
        UpdateTimer.Stop()
        DGV_Main.DataSource = Nothing
    End Sub

    ' Update de nieuwe bestellingen direct. (secret? ;o  )
    Private Sub Label_UpdateIn_Click(sender As Object, e As EventArgs) Handles Label_UpdateIn.Click
        tijd = 0
    End Sub

    ' Functie die word uitgevoerd wanneer Form1 (Mainform) opend.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hier zorgen we er voor dat het database object present is en dat alle gegevens er in worden geladen.
        database = New DrlDatabase
        Label_StatusUpdate.Text = ""
    End Sub

    ' Laad de database opties in het DataBase object.
    Private Sub laadDatabaseOpties()
        database.adres = My.Settings.db_adres
        database.username = My.Settings.db_username
        database.wachtwoord = My.Settings.db_wachtwoord
        database.database = My.Settings.db_database
    End Sub

    ' Functie die word uitgevoerd wanneer de timer 1000ms is verstreken.
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        ' Als de timer 0 heeft berijkt...
        If (tijd = 0) Then
            ' Dan tijd naar 120 en update de DataGridView.
            tijd = 120
            updateDataGridView("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant  where status = 'OPEN' ORDER BY datum ASC")
        Else
            ' Anderes tijd - 1 en laat de nieuwe tijd zien op het label.
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
        ' Pak een nieuwe database connectie.
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            ' Open de database connectie.
            connection.Open()

            ' Maak een MySql command aan. Daarna zorgen we dat deze de juiste query krijgt toegewezen.
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET status='GESLOTEN' WHERE id = " + huidige_id.ToString()
            ' Voer het command uit.
            command.ExecuteNonQuery()

            ' Update de DataGridView zodat deze de juiste status laat zien.
            DGV_Main(7, huidige_row).Value = "GESLOTEN"

            ' Update de label met het bericht dat de bestelling succesvol is afgehandelt.
            setStatusLabel("Bestelling succesvol afgehandelt", Color.Green)
        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            ' Als de verbinding niet gesloten is...
            If connection.State <> ConnectionState.Closed Then
                ' Dan sluiten we hem.
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BT_Cancel_Click(sender As Object, e As EventArgs) Handles BT_Cancel.Click
        ' Pak een nieuwe database connectie.
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            ' Open de verbinding.
            connection.Open()

            ' Maak een MySqlCommand aan en geef deze de juiste query mee.
            ' Daarna voeren we deze uit.
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET status='CANCELLED' WHERE id = " + huidige_id.ToString()
            command.ExecuteNonQuery()

            ' Update de DataGridView met de juiste gegevens.
            DGV_Main(7, huidige_row).Value = "CANCELLED"

            ' Laat op het status label zien dat de update succusvol was.
            setStatusLabel("Bestelling succesvol gecancelled", Color.Green)
        Catch ex As Exception
            MsgBox("Onverwachte error: " + ex.Message)
        Finally
            ' Als de verbinding niet gesloten is...
            If connection.State <> ConnectionState.Closed Then
                ' dan sluiten we deze
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BT_Opslaan_Click(sender As Object, e As EventArgs) Handles BT_Opslaan.Click
        ' Maak een nieuwe connectie aan.
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            ' Open de connectie met de database.
            connection.Open()

            ' Maak een nieuwe MySqlCommand aan.
            ' Daarna geven we deze de juiste parameters mee en voeren we deze uit.
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = "UPDATE bestellingen SET adres=@adres, bestelling=@bestelling WHERE id = " + huidige_id.ToString()
            command.Parameters.AddWithValue("@adres", TB_Adres.Text)
            command.Parameters.AddWithValue("@bestelling", TB_Bestelling.Text)
            ' Voer de query uit.
            command.ExecuteNonQuery()

            ' Update de DataGridView met de juiste gegevens.
            DGV_Main(1, huidige_row).Value = TB_Bestelling.Text
            DGV_Main(3, huidige_row).Value = TB_Adres.Text

            ' Laat op het label zien dat de operatie geslaagd is.
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
        ' Zet de Form modus in bestellingen.
        modus = Mode.Bestellingen

        ' Reset de view.
        resetView()

        ' Zorg er voor dat de juiste labels en timers geactiveerd worden.
        Panel_UpdateStatus.Visible = True
        UpdateTimer.Start()

        ' Maak een nieuwe database connectie.
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            ' Open de DataBase connectie.
            connection.Open()

            ' Hier gebruiken we een DataAdapter om de resultaten uit te lezen.
            Dim adapter As New MySqlDataAdapter("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant  where status = 'OPEN' ORDER BY datum ASC", connection)
            Dim dataset As New DataSet

            ' Vul de dataset met de nieuwe gegevens.
            adapter.Fill(dataset)

            ' Update het DataGridView met de correcte gegevens.
            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            connection.Close()
            setStatusLabel("Open bestellingen geladen.", Color.Black)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Main.RowHeaderMouseClick
        ' Sla de huidge row en ID op in de public variablen.
        huidige_row = e.RowIndex
        huidige_id = DGV_Main(0, e.RowIndex).Value

        ' Als het form zich in bestelling modus bevindt:
        If modus = Mode.Bestellingen Then
            ' Zorg dat in de TextBoxen de juiste gevens komen te staan.
            TB_Bestelling.Text = DGV_Main(1, e.RowIndex).Value
            TB_Adres.Text = DGV_Main(3, e.RowIndex).Value

            ' Zorg dat op het 'bezorgen?' label de juiste gevens komen.
            If (DGV_Main(2, e.RowIndex).Value) Then
                Label_Afhalen.Text = "JA"
            Else
                Label_Afhalen.Text = "NEE"
            End If

            ' Laat het bestellingPanel zien.
            Panel_BestellingOpties.Visible = True

            ' Anders als we in de klante modus zitten.
        ElseIf modus = Mode.Klanten Then
            ' Maak een nieuwe KlantDialog aan.
            Dim dialog As New KlantDialog()

            ' Zet in de dialog de juiste gegevens.
            dialog.Text = $"Klant #{DGV_Main(0, e.RowIndex).Value} {DGV_Main(1, e.RowIndex).Value} {DGV_Main(2, e.RowIndex).Value}"
            dialog.TB_Voornaam.Text = DGV_Main(1, e.RowIndex).Value
            dialog.TB_Achternaam.Text = DGV_Main(2, e.RowIndex).Value
            dialog.TB_Email.Text = DGV_Main(4, e.RowIndex).Value
            dialog.NUD_Spaarpunten.Value = DGV_Main(5, e.RowIndex).Value
            dialog.CB_Actief.Checked = DGV_Main(6, e.RowIndex).Value
            dialog.CB_Banned.Checked = DGV_Main(7, e.RowIndex).Value

            ' Laat het dialog zien.
            dialog.ShowDialog()

            ' Als de knop opslaan wordt aangeklikt:
            If dialog.DialogResult = DialogResult.OK Then
                ' DAN:
                ' Hier updaten we de gridview om de juiste resultaten te laten zien.
                DGV_Main(1, e.RowIndex).Value = dialog.TB_Voornaam.Text
                DGV_Main(2, e.RowIndex).Value = dialog.TB_Achternaam.Text
                DGV_Main(4, e.RowIndex).Value = dialog.TB_Email.Text
                DGV_Main(5, e.RowIndex).Value = dialog.NUD_Spaarpunten.Value
                DGV_Main(6, e.RowIndex).Value = dialog.CB_Actief.Checked
                DGV_Main(7, e.RowIndex).Value = dialog.CB_Banned.Checked


                ' Pas de verandering toe in de database.
                Dim connection As MySqlConnection = database.grabConnection()
                Try
                    ' Open de verbinding met de DataBase.
                    connection.Open()

                    ' Maak een MySql command aan en zorg dat de juiste parameters worden ingevuld.
                    Dim command As MySqlCommand = connection.CreateCommand()
                    command.CommandText = "UPDATE klanten SET voornaam=@voornaam, achternaam=@achternaam, email = @email, spaarpunten = @spaarpunten, actief = @actief, banned = @banned WHERE id = " + huidige_id.ToString()
                    command.Parameters.AddWithValue("@voornaam", dialog.TB_Voornaam.Text)
                    command.Parameters.AddWithValue("@achternaam", dialog.TB_Achternaam.Text)
                    command.Parameters.AddWithValue("@email", dialog.TB_Email.Text)
                    command.Parameters.AddWithValue("@spaarpunten", dialog.NUD_Spaarpunten.Value)
                    command.Parameters.AddWithValue("@actief", dialog.CB_Actief.Checked)
                    command.Parameters.AddWithValue("@banned", dialog.CB_Banned.Checked)

                    ' Execute de update.
                    command.ExecuteNonQuery()

                    ' Laat een messageBox zien dat de update succesvol was.
                    MessageBox.Show("Klant gegevens succesvol geüpdated.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox("Onverwachte error: " + ex.Message)
                Finally
                    ' Als de verbinding niet gesloten is.
                    If connection.State <> ConnectionState.Closed Then
                        ' Dan sluiten we deze.
                        connection.Close()
                    End If

                End Try

            End If
        End If
    End Sub

    ' Deze methode word uitgevoerd wanneer de 'opties' knop word aangeklikt.
    ' Hier kan de gebruiker de juiste gegevens voor de dataBase invullen.
    Private Sub OptiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptiesToolStripMenuItem.Click
        ' Maak het dialog aan.
        Dim dialog As New DatabaseOpties()

        ' Laat het dialog zien.
        dialog.ShowDialog()

        ' Als de knop OK word gekozen:
        If (dialog.DialogResult = DialogResult.OK) Then
            ' Sla de gegevens op en laad het nieuwe database object.
            My.Settings.db_adres = dialog.TB_Adres.Text
            My.Settings.db_username = dialog.TB_Gebruikersnaam.Text
            My.Settings.db_wachtwoord = dialog.TB_Wachtwoord.Text
            My.Settings.db_database = dialog.TB_Database.Text
            My.Settings.Save()
            laadDatabaseOpties()
        End If
    End Sub

    ' Deze methode word uitgevoerd wanneer de Zoek Bestelling knop word aangeklikt.
    Private Sub BT_ZoekBestelling_Click(sender As Object, e As EventArgs) Handles BT_ZoekBestelling.Click
        ' Reset de view en zorg dat de form in Bestelling modus komt.
        resetView()
        modus = Mode.Bestellingen

        ' Maak een nieuwe zoek dialog aan en laat deze zien.
        Dim dialog As New ZoekBestellingDialog()
        dialog.ShowDialog()

        ' Als het resultaat niet OK is.
        If dialog.DialogResult <> DialogResult.OK Then
            ' dan stoppen we deze methode.
            Return
        End If

        ' Pak een nieuwe connectie uit het database object.
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            ' Open de verbinding met de DataBase.
            connection.Open()

            ' Maak ee nieuwe command aan.
            Dim command As MySqlCommand

            ' Als er een bestelling ID is ingevoerd gaan we alleen hier op zoeken. (immers er is maar 1 resultaat (of minder) met dit ID).
            If dialog.TB_BestellingID.Text <> "" Then
                command = New MySqlCommand("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant WHERE bestellingen.id=@bestellingid ORDER BY datum ASC", connection)
                command.Parameters.AddWithValue("@bestellingid", Integer.Parse(dialog.TB_BestellingID.Text))

                ' Wanneer het klant ID is ingevoerd zoeken we alleen hier op. (immers er is maar 1 klant met dit ID).
            ElseIf dialog.TB_KlantID.Text <> "" Then
                command = New MySqlCommand("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant WHERE klanten.id=@klantid ORDER BY datum ASC", connection)
                command.Parameters.AddWithValue("@klantid", Integer.Parse(dialog.TB_KlantID.Text))

                ' En anders zoeken we op de rest.
            Else
                command = New MySqlCommand("SELECT bestellingen.id, bestelling, afhalen, adres, klanten.voornaam, klanten.achternaam, datum, status FROM `bestellingen` INNER JOIN klanten ON klanten.id = bestellingen.klant WHERE bestelling LIKE @bestelling AND adres LIKE @adres AND status LIKE @status ORDER BY datum ASC", connection)
                command.Parameters.AddWithValue("@bestelling", "%" + dialog.TB_Bestelling.Text + "%")
                command.Parameters.AddWithValue("@adres", "%" + dialog.TB_Adres.Text + "%")
                command.Parameters.AddWithValue("@status", "%" + dialog.CB_Status.SelectedItem + "%")
            End If

            ' Maak een adapter aan om de gegevens uit te lezen.
            Dim adapter As New MySqlDataAdapter
            ' Deze code zorgt er voor dat de adapter de select command gebruikt.
            adapter.SelectCommand = command

            ' Update de DataGridView.
            Dim dataset As New DataSet
            adapter.Fill(dataset)
            DGV_Main.DataSource = dataset.Tables(0)

            ' Laat het status label zien:
            setStatusLabel("Bestellingen geladen", Color.Black)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            ' Als de verbinding niet gesloten is.
            If connection.State <> ConnectionState.Closed Then
                ' Dan sluiten we deze.
                connection.Close()
            End If

        End Try
    End Sub

    Private Sub BT_ZoekKlant_Click(sender As Object, e As EventArgs) Handles BT_ZoekKlant.Click
        ' Zet de Form in klant modus.
        modus = Mode.Klanten

        ' Reset de view.
        resetView()

        ' Maak een ZoekKlantDialog aan en open deze.
        Dim dialog As New ZoekKlantDialog()
        dialog.ShowDialog()

        ' Als het resultaat NIET OK is dan stoppen we deze methode.
        If dialog.DialogResult <> DialogResult.OK Then
            Return
        End If

        ' Pak een nieuwe connectie.
        Dim connection As MySqlConnection = database.grabConnection()
        Try
            ' Open die nieuwe connectie.
            connection.Open()

            ' Maak een MySql command variabel aan. Deze vullen we later pas in.
            Dim command As MySqlCommand

            ' Als het ID leeg is gelaten:
            If dialog.TB_ID.Text = "" Then
                ' Dan zoeken we op alles behalve het ID.
                command = New MySqlCommand("SELECT id, voornaam, achternaam, registratie, email, spaarpunten, actief, banned FROM klanten WHERE voornaam LIKE @voornaam AND achternaam LIKE @achternaam AND email LIKE @email", connection)
                command.Parameters.AddWithValue("@voornaam", "%" + dialog.TB_Voornaam.Text + "%")
                command.Parameters.AddWithValue("@achternaam", "%" + dialog.TB_Achternaam.Text + "%")
                command.Parameters.AddWithValue("@email", "%" + dialog.TB_Email.Text + "%")
            Else
                ' Anderes zoeken we op het ID. (Immers er is maar 1 klant met dit ID).
                command = New MySqlCommand("SELECT id, voornaam, achternaam, registratie, email, spaarpunten, actief, banned FROM klanten WHERE id=@id", connection)
                command.Parameters.AddWithValue("@id", Integer.Parse(dialog.TB_ID.Text))
            End If

            ' Met de dataAdapter lezen we de database uit. De adapter krijgt de command met instructies mee.
            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = command

            ' Laat de resultaten in de datagridview zien.
            Dim dataset As New DataSet
            adapter.Fill(dataset)
            DGV_Main.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        Finally
            ' Als de verbinding niet gesloten is:
            If connection.State <> ConnectionState.Closed Then
                ' Dan sluiten we deze.
                connection.Close()
            End If
        End Try

    End Sub

    Private Sub BT_Gebruiker_Click(sender As Object, e As EventArgs) Handles BT_Gebruiker.Click
        ' Klant dialog
        Dim dialog As New KlantDialog()

        Try
            ' Laad de gegevens uit de database.
            ' Pak een nieuwe connectie en open deze.
            Dim connection As MySqlConnection = database.grabConnection()
            connection.Open()

            ' Maak gebruik een nieuwe command voor de query.
            Dim command As New MySqlCommand("select id, voornaam, achternaam, email, spaarpunten, actief, banned from klanten where klanten.id = (select bestellingen.klant from bestellingen where bestellingen.id = " + huidige_id.ToString() + ")", connection)

            ' Hier maken we gebruik van een reader in plaats van een adapter om de database uit te lezen.
            ' Dit omdat we hier geen DataSet hoeven te vullen.
            Dim reader As MySqlDataReader = command.ExecuteReader

            ' Als de reader rows heeft, dan:
            If (reader.HasRows) Then
                ' Gaan we todat reader.Read false geeft:
                While (reader.Read)
                    ' De gegevens in de dialog updaten.
                    dialog.id = reader.GetInt32(0)
                    dialog.TB_Voornaam.Text = reader.GetString(1)
                    dialog.TB_Achternaam.Text = reader.GetString(2)
                    dialog.TB_Email.Text = reader.GetString(3)
                    dialog.NUD_Spaarpunten.Value = reader.GetInt32(4)
                    dialog.CB_Actief.Checked = reader.GetBoolean(5)
                    dialog.CB_Banned.Checked = reader.GetBoolean(6)
                End While
            End If

            ' Als de verbinding niet gesloten is:
            If connection.State <> ConnectionState.Closed Then
                ' Dan sluiten we deze.
                connection.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Onverwachte error! " + ex.ToString)
        End Try

        ' Laat het dialog met de gegevens zien:
        dialog.ShowDialog()

        ' Als het resultaat OK is (opslaan button) dan:
        If dialog.DialogResult = DialogResult.OK Then
            ' Pas de verandering toe in de database.
            Dim connection As MySqlConnection = database.grabConnection()
            Try
                ' Open de verbinding met de database.
                connection.Open()

                ' Maak de command aan geef deze de juiste parameters mee.
                Dim command As MySqlCommand = connection.CreateCommand()
                command.CommandText = "UPDATE klanten SET voornaam=@voornaam, achternaam=@achternaam, email = @email, spaarpunten = @spaarpunten, actief = @actief, banned = @banned WHERE id = " + dialog.id.ToString()
                command.Parameters.AddWithValue("@voornaam", dialog.TB_Voornaam.Text)
                command.Parameters.AddWithValue("@achternaam", dialog.TB_Achternaam.Text)
                command.Parameters.AddWithValue("@email", dialog.TB_Email.Text)
                command.Parameters.AddWithValue("@spaarpunten", dialog.NUD_Spaarpunten.Value)
                command.Parameters.AddWithValue("@actief", dialog.CB_Actief.Checked)
                command.Parameters.AddWithValue("@banned", dialog.CB_Banned.Checked)

                ' Voer de query uit.
                command.ExecuteNonQuery()

                ' Message box om te laten weten dat de actie succesvol was.
                MessageBox.Show("Klant gegevens succesvol geüpdated.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox("Onverwachte error: " + ex.Message)
            Finally
                ' Als de verbinding niet gesloten is:
                If connection.State <> ConnectionState.Closed Then
                    ' Dan sluiten we deze.
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        ' Open de link naar de GitHub pagina.
        Try
            Process.Start("https://github.com/MartenM/Pizzaria")
        Catch
            'Doe niks...
        End Try
    End Sub
End Class
' En dat was het einde al weer :D
