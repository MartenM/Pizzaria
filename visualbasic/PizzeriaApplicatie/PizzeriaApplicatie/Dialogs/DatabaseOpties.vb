Imports System.Windows.Forms

Public Class DatabaseOpties

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DatabaseOpties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Laad de juiste gegevens in de TextBoxen.
        TB_Adres.Text = My.Settings.db_adres
        TB_Gebruikersnaam.Text = My.Settings.db_username
        TB_Wachtwoord.Text = My.Settings.db_wachtwoord
        TB_Database.Text = My.Settings.db_database
    End Sub
End Class
