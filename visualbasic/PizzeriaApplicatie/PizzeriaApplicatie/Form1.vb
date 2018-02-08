Imports MySql.Data.MySqlClient

Public Class Form1
    Dim tijd As Integer = 120
    Dim database As DrlDatabase

    Public Sub updateDataGridView(ByVal query As String)
        label_tijd.Text = "Query word uitgevoerd: " + query

        Dim connection As MySqlConnection = database.grabConnection()
        Try
            connection.Open()

            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataset As New DataSet

            adapter.Fill(dataset)

            DataGridView1.DataSource = dataset.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
        End Try
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
    End Sub

    ' Functie die word uitgevoerd wanneer de timer 1000ms is verstreken.
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        If (tijd = 0) Then
            tijd = 120
            updateDataGridView("select * from bestellingen")
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
End Class
