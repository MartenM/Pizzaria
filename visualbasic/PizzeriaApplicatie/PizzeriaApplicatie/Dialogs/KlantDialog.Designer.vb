<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KlantDialog
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_Voornaam = New System.Windows.Forms.TextBox()
        Me.TB_Achternaam = New System.Windows.Forms.TextBox()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.CB_Actief = New System.Windows.Forms.CheckBox()
        Me.CB_Banned = New System.Windows.Forms.CheckBox()
        Me.NUD_Spaarpunten = New System.Windows.Forms.NumericUpDown()
        Me.Voornaam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.NUD_Spaarpunten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Cancel_Button)
        Me.Panel2.Controls.Add(Me.OK_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 33)
        Me.Panel2.TabIndex = 3
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(165, 0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 33)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Sluiten"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(232, 0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 33)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Opslaan"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 15)
        Me.Panel1.TabIndex = 4
        '
        'TB_Voornaam
        '
        Me.TB_Voornaam.Location = New System.Drawing.Point(12, 38)
        Me.TB_Voornaam.Name = "TB_Voornaam"
        Me.TB_Voornaam.Size = New System.Drawing.Size(265, 20)
        Me.TB_Voornaam.TabIndex = 5
        '
        'TB_Achternaam
        '
        Me.TB_Achternaam.Location = New System.Drawing.Point(12, 81)
        Me.TB_Achternaam.Name = "TB_Achternaam"
        Me.TB_Achternaam.Size = New System.Drawing.Size(265, 20)
        Me.TB_Achternaam.TabIndex = 6
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(12, 120)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(265, 20)
        Me.TB_Email.TabIndex = 7
        '
        'CB_Actief
        '
        Me.CB_Actief.AutoSize = True
        Me.CB_Actief.Location = New System.Drawing.Point(15, 196)
        Me.CB_Actief.Name = "CB_Actief"
        Me.CB_Actief.Size = New System.Drawing.Size(53, 17)
        Me.CB_Actief.TabIndex = 9
        Me.CB_Actief.Text = "Actief"
        Me.CB_Actief.UseVisualStyleBackColor = True
        '
        'CB_Banned
        '
        Me.CB_Banned.AutoSize = True
        Me.CB_Banned.Location = New System.Drawing.Point(13, 229)
        Me.CB_Banned.Name = "CB_Banned"
        Me.CB_Banned.Size = New System.Drawing.Size(63, 17)
        Me.CB_Banned.TabIndex = 10
        Me.CB_Banned.Text = "Banned"
        Me.CB_Banned.UseVisualStyleBackColor = True
        '
        'NUD_Spaarpunten
        '
        Me.NUD_Spaarpunten.Location = New System.Drawing.Point(12, 159)
        Me.NUD_Spaarpunten.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.NUD_Spaarpunten.Name = "NUD_Spaarpunten"
        Me.NUD_Spaarpunten.Size = New System.Drawing.Size(265, 20)
        Me.NUD_Spaarpunten.TabIndex = 11
        '
        'Voornaam
        '
        Me.Voornaam.AutoSize = True
        Me.Voornaam.Location = New System.Drawing.Point(12, 22)
        Me.Voornaam.Name = "Voornaam"
        Me.Voornaam.Size = New System.Drawing.Size(55, 13)
        Me.Voornaam.TabIndex = 12
        Me.Voornaam.Text = "Voornaam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Achternaam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Spaarpunten"
        '
        'KlantDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 289)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Voornaam)
        Me.Controls.Add(Me.NUD_Spaarpunten)
        Me.Controls.Add(Me.CB_Banned)
        Me.Controls.Add(Me.CB_Actief)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.TB_Achternaam)
        Me.Controls.Add(Me.TB_Voornaam)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(315, 328)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(315, 328)
        Me.Name = "KlantDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Klant"
        Me.Panel2.ResumeLayout(False)
        CType(Me.NUD_Spaarpunten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_Voornaam As TextBox
    Friend WithEvents TB_Achternaam As TextBox
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents CB_Actief As CheckBox
    Friend WithEvents CB_Banned As CheckBox
    Friend WithEvents NUD_Spaarpunten As NumericUpDown
    Friend WithEvents Voornaam As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
