<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZoekBestellingDialog
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
        Me.TB_Adres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Bestelling = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_KlantID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_BestellingID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Status = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Cancel_Button)
        Me.Panel2.Controls.Add(Me.OK_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 33)
        Me.Panel2.TabIndex = 4
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(276, 0)
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
        Me.OK_Button.Location = New System.Drawing.Point(343, 0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 33)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Zoeken"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 15)
        Me.Panel1.TabIndex = 5
        '
        'TB_Adres
        '
        Me.TB_Adres.Location = New System.Drawing.Point(12, 155)
        Me.TB_Adres.Name = "TB_Adres"
        Me.TB_Adres.Size = New System.Drawing.Size(391, 20)
        Me.TB_Adres.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Adres"
        '
        'TB_Bestelling
        '
        Me.TB_Bestelling.Location = New System.Drawing.Point(12, 116)
        Me.TB_Bestelling.Name = "TB_Bestelling"
        Me.TB_Bestelling.Size = New System.Drawing.Size(391, 20)
        Me.TB_Bestelling.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Bestelling"
        '
        'TB_KlantID
        '
        Me.TB_KlantID.Location = New System.Drawing.Point(12, 77)
        Me.TB_KlantID.Name = "TB_KlantID"
        Me.TB_KlantID.Size = New System.Drawing.Size(391, 20)
        Me.TB_KlantID.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Klant ID"
        '
        'TB_BestellingID
        '
        Me.TB_BestellingID.Location = New System.Drawing.Point(12, 38)
        Me.TB_BestellingID.Name = "TB_BestellingID"
        Me.TB_BestellingID.Size = New System.Drawing.Size(391, 20)
        Me.TB_BestellingID.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Bestelling ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Status"
        '
        'CB_Status
        '
        Me.CB_Status.FormattingEnabled = True
        Me.CB_Status.Items.AddRange(New Object() {"OPEN", "GESLOTEN", "CANCELLED"})
        Me.CB_Status.Location = New System.Drawing.Point(12, 194)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(391, 21)
        Me.CB_Status.TabIndex = 28
        '
        'ZoekBestellingDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 261)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Adres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_Bestelling)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_KlantID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_BestellingID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(426, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(426, 257)
        Me.Name = "ZoekBestellingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ZoekBestellingDialog"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_Adres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Bestelling As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_KlantID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_BestellingID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Status As ComboBox
End Class
