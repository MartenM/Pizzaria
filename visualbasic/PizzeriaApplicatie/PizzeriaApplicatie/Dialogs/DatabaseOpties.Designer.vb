<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseOpties
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TB_Gebruikersnaam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Wachtwoord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Database = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Adres = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(348, 0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 33)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(281, 0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 33)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 15)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Cancel_Button)
        Me.Panel2.Controls.Add(Me.OK_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 33)
        Me.Panel2.TabIndex = 2
        '
        'TB_Gebruikersnaam
        '
        Me.TB_Gebruikersnaam.Location = New System.Drawing.Point(12, 74)
        Me.TB_Gebruikersnaam.Name = "TB_Gebruikersnaam"
        Me.TB_Gebruikersnaam.Size = New System.Drawing.Size(391, 20)
        Me.TB_Gebruikersnaam.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Gebruikersnaam"
        '
        'TB_Wachtwoord
        '
        Me.TB_Wachtwoord.Location = New System.Drawing.Point(12, 113)
        Me.TB_Wachtwoord.Name = "TB_Wachtwoord"
        Me.TB_Wachtwoord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TB_Wachtwoord.Size = New System.Drawing.Size(391, 20)
        Me.TB_Wachtwoord.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wachtwoord"
        '
        'TB_Database
        '
        Me.TB_Database.Location = New System.Drawing.Point(12, 152)
        Me.TB_Database.Name = "TB_Database"
        Me.TB_Database.Size = New System.Drawing.Size(391, 20)
        Me.TB_Database.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Database"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Adres"
        '
        'TB_Adres
        '
        Me.TB_Adres.Location = New System.Drawing.Point(12, 35)
        Me.TB_Adres.Name = "TB_Adres"
        Me.TB_Adres.Size = New System.Drawing.Size(391, 20)
        Me.TB_Adres.TabIndex = 4
        '
        'DatabaseOpties
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(415, 218)
        Me.Controls.Add(Me.TB_Database)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_Wachtwoord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Gebruikersnaam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Adres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabaseOpties"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opties"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TB_Gebruikersnaam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Wachtwoord As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Database As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Adres As TextBox
End Class
