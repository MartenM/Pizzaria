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
        Me.TbVoornaam = New System.Windows.Forms.TextBox()
        Me.TbAchternaam = New System.Windows.Forms.TextBox()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.CbActief = New System.Windows.Forms.CheckBox()
        Me.CbBanned = New System.Windows.Forms.CheckBox()
        Me.NudSpaarpunten = New System.Windows.Forms.NumericUpDown()
        Me.Voornaam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.NudSpaarpunten, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cancel_Button.Text = "Cancel"
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
        Me.OK_Button.Text = "OK"
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
        'TbVoornaam
        '
        Me.TbVoornaam.Location = New System.Drawing.Point(12, 38)
        Me.TbVoornaam.Name = "TbVoornaam"
        Me.TbVoornaam.Size = New System.Drawing.Size(265, 20)
        Me.TbVoornaam.TabIndex = 5
        '
        'TbAchternaam
        '
        Me.TbAchternaam.Location = New System.Drawing.Point(12, 81)
        Me.TbAchternaam.Name = "TbAchternaam"
        Me.TbAchternaam.Size = New System.Drawing.Size(265, 20)
        Me.TbAchternaam.TabIndex = 6
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(12, 120)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(265, 20)
        Me.TbEmail.TabIndex = 7
        '
        'CbActief
        '
        Me.CbActief.AutoSize = True
        Me.CbActief.Location = New System.Drawing.Point(15, 196)
        Me.CbActief.Name = "CbActief"
        Me.CbActief.Size = New System.Drawing.Size(53, 17)
        Me.CbActief.TabIndex = 9
        Me.CbActief.Text = "Actief"
        Me.CbActief.UseVisualStyleBackColor = True
        '
        'CbBanned
        '
        Me.CbBanned.AutoSize = True
        Me.CbBanned.Location = New System.Drawing.Point(13, 229)
        Me.CbBanned.Name = "CbBanned"
        Me.CbBanned.Size = New System.Drawing.Size(63, 17)
        Me.CbBanned.TabIndex = 10
        Me.CbBanned.Text = "Banned"
        Me.CbBanned.UseVisualStyleBackColor = True
        '
        'NudSpaarpunten
        '
        Me.NudSpaarpunten.Location = New System.Drawing.Point(12, 159)
        Me.NudSpaarpunten.Name = "NudSpaarpunten"
        Me.NudSpaarpunten.Size = New System.Drawing.Size(265, 20)
        Me.NudSpaarpunten.TabIndex = 11
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
        Me.Controls.Add(Me.NudSpaarpunten)
        Me.Controls.Add(Me.CbBanned)
        Me.Controls.Add(Me.CbActief)
        Me.Controls.Add(Me.TbEmail)
        Me.Controls.Add(Me.TbAchternaam)
        Me.Controls.Add(Me.TbVoornaam)
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
        Me.Text = "KlantDialog"
        Me.Panel2.ResumeLayout(False)
        CType(Me.NudSpaarpunten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbVoornaam As TextBox
    Friend WithEvents TbAchternaam As TextBox
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents CbActief As CheckBox
    Friend WithEvents CbBanned As CheckBox
    Friend WithEvents NudSpaarpunten As NumericUpDown
    Friend WithEvents Voornaam As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
