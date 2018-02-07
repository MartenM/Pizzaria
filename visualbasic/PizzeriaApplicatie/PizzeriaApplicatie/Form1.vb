Public Class Form1
    Dim tijd As Integer = 120


    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        If (tijd = 0) Then
            updateDataGridView()
            tijd = 120
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

    Sub updateDataGridView()
        label_tijd.Text = "Update!"
    End Sub

    Private Sub Label_UpdateIn_Click(sender As Object, e As EventArgs) Handles Label_UpdateIn.Click
        tijd = 0
    End Sub
End Class
