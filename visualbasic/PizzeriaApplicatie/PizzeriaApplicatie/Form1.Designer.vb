<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BT_ZoekKlant = New System.Windows.Forms.Button()
        Me.BT_ZoekBestelling = New System.Windows.Forms.Button()
        Me.BT_OpenBestellingen = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.Labl_Logo = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BT_Gebruiker = New System.Windows.Forms.Button()
        Me.BT_Cancel = New System.Windows.Forms.Button()
        Me.BT_Afhandelen = New System.Windows.Forms.Button()
        Me.TB_Adres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_Afhalen = New System.Windows.Forms.Label()
        Me.BT_Opslaan = New System.Windows.Forms.Button()
        Me.TB_Bestelling = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_StatusUpdate = New System.Windows.Forms.Label()
        Me.label_tijd = New System.Windows.Forms.Label()
        Me.Label_UpdateIn = New System.Windows.Forms.Label()
        Me.DGV_Main = New System.Windows.Forms.DataGridView()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sidePanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.logoPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.Silver
        Me.sidePanel.Controls.Add(Me.Panel5)
        Me.sidePanel.Controls.Add(Me.Panel4)
        Me.sidePanel.Controls.Add(Me.logoPanel)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 24)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(186, 479)
        Me.sidePanel.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.BT_ZoekKlant)
        Me.Panel5.Controls.Add(Me.BT_ZoekBestelling)
        Me.Panel5.Controls.Add(Me.BT_OpenBestellingen)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 90)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(186, 280)
        Me.Panel5.TabIndex = 2
        '
        'BT_ZoekKlant
        '
        Me.BT_ZoekKlant.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_ZoekKlant.Dock = System.Windows.Forms.DockStyle.Top
        Me.BT_ZoekKlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ZoekKlant.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ZoekKlant.ForeColor = System.Drawing.Color.White
        Me.BT_ZoekKlant.Location = New System.Drawing.Point(0, 80)
        Me.BT_ZoekKlant.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ZoekKlant.Name = "BT_ZoekKlant"
        Me.BT_ZoekKlant.Size = New System.Drawing.Size(186, 40)
        Me.BT_ZoekKlant.TabIndex = 9
        Me.BT_ZoekKlant.Text = "Zoek klant"
        Me.BT_ZoekKlant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_ZoekKlant.UseVisualStyleBackColor = False
        '
        'BT_ZoekBestelling
        '
        Me.BT_ZoekBestelling.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_ZoekBestelling.Dock = System.Windows.Forms.DockStyle.Top
        Me.BT_ZoekBestelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ZoekBestelling.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ZoekBestelling.ForeColor = System.Drawing.Color.White
        Me.BT_ZoekBestelling.Location = New System.Drawing.Point(0, 40)
        Me.BT_ZoekBestelling.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_ZoekBestelling.Name = "BT_ZoekBestelling"
        Me.BT_ZoekBestelling.Size = New System.Drawing.Size(186, 40)
        Me.BT_ZoekBestelling.TabIndex = 8
        Me.BT_ZoekBestelling.Text = "Zoek bestelling"
        Me.BT_ZoekBestelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_ZoekBestelling.UseVisualStyleBackColor = False
        '
        'BT_OpenBestellingen
        '
        Me.BT_OpenBestellingen.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_OpenBestellingen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BT_OpenBestellingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_OpenBestellingen.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_OpenBestellingen.ForeColor = System.Drawing.Color.White
        Me.BT_OpenBestellingen.Location = New System.Drawing.Point(0, 0)
        Me.BT_OpenBestellingen.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_OpenBestellingen.Name = "BT_OpenBestellingen"
        Me.BT_OpenBestellingen.Size = New System.Drawing.Size(186, 40)
        Me.BT_OpenBestellingen.TabIndex = 7
        Me.BT_OpenBestellingen.Text = "Open bestellingen"
        Me.BT_OpenBestellingen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_OpenBestellingen.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(186, 30)
        Me.Panel4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Grid opties"
        '
        'logoPanel
        '
        Me.logoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.logoPanel.Controls.Add(Me.Labl_Logo)
        Me.logoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(186, 60)
        Me.logoPanel.TabIndex = 0
        '
        'Labl_Logo
        '
        Me.Labl_Logo.AutoSize = True
        Me.Labl_Logo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labl_Logo.ForeColor = System.Drawing.Color.White
        Me.Labl_Logo.Location = New System.Drawing.Point(5, 9)
        Me.Labl_Logo.Name = "Labl_Logo"
        Me.Labl_Logo.Size = New System.Drawing.Size(178, 33)
        Me.Labl_Logo.TabIndex = 0
        Me.Labl_Logo.Text = "DRL Pizzas"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(186, 24)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(706, 60)
        Me.header.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TB_Adres)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.L_Afhalen)
        Me.Panel1.Controls.Add(Me.BT_Opslaan)
        Me.Panel1.Controls.Add(Me.TB_Bestelling)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(693, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 419)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.BT_Gebruiker)
        Me.Panel2.Controls.Add(Me.BT_Cancel)
        Me.Panel2.Controls.Add(Me.BT_Afhandelen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(199, 211)
        Me.Panel2.TabIndex = 9
        '
        'BT_Gebruiker
        '
        Me.BT_Gebruiker.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_Gebruiker.Dock = System.Windows.Forms.DockStyle.Top
        Me.BT_Gebruiker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Gebruiker.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Gebruiker.ForeColor = System.Drawing.Color.White
        Me.BT_Gebruiker.Location = New System.Drawing.Point(0, 80)
        Me.BT_Gebruiker.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_Gebruiker.Name = "BT_Gebruiker"
        Me.BT_Gebruiker.Size = New System.Drawing.Size(199, 40)
        Me.BT_Gebruiker.TabIndex = 7
        Me.BT_Gebruiker.Text = "Bekijk Gebruiker"
        Me.BT_Gebruiker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_Gebruiker.UseVisualStyleBackColor = False
        '
        'BT_Cancel
        '
        Me.BT_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_Cancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Cancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Cancel.ForeColor = System.Drawing.Color.White
        Me.BT_Cancel.Location = New System.Drawing.Point(0, 40)
        Me.BT_Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_Cancel.Name = "BT_Cancel"
        Me.BT_Cancel.Size = New System.Drawing.Size(199, 40)
        Me.BT_Cancel.TabIndex = 8
        Me.BT_Cancel.Text = "Cancel"
        Me.BT_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_Cancel.UseVisualStyleBackColor = False
        '
        'BT_Afhandelen
        '
        Me.BT_Afhandelen.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_Afhandelen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BT_Afhandelen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Afhandelen.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Afhandelen.ForeColor = System.Drawing.Color.White
        Me.BT_Afhandelen.Location = New System.Drawing.Point(0, 0)
        Me.BT_Afhandelen.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_Afhandelen.Name = "BT_Afhandelen"
        Me.BT_Afhandelen.Size = New System.Drawing.Size(199, 40)
        Me.BT_Afhandelen.TabIndex = 6
        Me.BT_Afhandelen.Text = "Afhandelen"
        Me.BT_Afhandelen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_Afhandelen.UseVisualStyleBackColor = False
        '
        'TB_Adres
        '
        Me.TB_Adres.Location = New System.Drawing.Point(12, 121)
        Me.TB_Adres.Name = "TB_Adres"
        Me.TB_Adres.Size = New System.Drawing.Size(175, 20)
        Me.TB_Adres.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "<input>"
        '
        'L_Afhalen
        '
        Me.L_Afhalen.AutoSize = True
        Me.L_Afhalen.Location = New System.Drawing.Point(9, 104)
        Me.L_Afhalen.Name = "L_Afhalen"
        Me.L_Afhalen.Size = New System.Drawing.Size(93, 13)
        Me.L_Afhalen.TabIndex = 3
        Me.L_Afhalen.Text = "Bestelling afhalen:"
        '
        'BT_Opslaan
        '
        Me.BT_Opslaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BT_Opslaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Opslaan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Opslaan.ForeColor = System.Drawing.Color.White
        Me.BT_Opslaan.Location = New System.Drawing.Point(0, 147)
        Me.BT_Opslaan.Name = "BT_Opslaan"
        Me.BT_Opslaan.Size = New System.Drawing.Size(199, 30)
        Me.BT_Opslaan.TabIndex = 2
        Me.BT_Opslaan.Text = "Update bestelling"
        Me.BT_Opslaan.UseVisualStyleBackColor = False
        '
        'TB_Bestelling
        '
        Me.TB_Bestelling.Location = New System.Drawing.Point(9, 20)
        Me.TB_Bestelling.Multiline = True
        Me.TB_Bestelling.Name = "TB_Bestelling"
        Me.TB_Bestelling.Size = New System.Drawing.Size(178, 77)
        Me.TB_Bestelling.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bestelling"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_StatusUpdate)
        Me.Panel3.Controls.Add(Me.label_tijd)
        Me.Panel3.Controls.Add(Me.Label_UpdateIn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(186, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(507, 30)
        Me.Panel3.TabIndex = 4
        '
        'Label_StatusUpdate
        '
        Me.Label_StatusUpdate.AutoSize = True
        Me.Label_StatusUpdate.Location = New System.Drawing.Point(117, 7)
        Me.Label_StatusUpdate.Name = "Label_StatusUpdate"
        Me.Label_StatusUpdate.Size = New System.Drawing.Size(47, 13)
        Me.Label_StatusUpdate.TabIndex = 2
        Me.Label_StatusUpdate.Text = "<status>"
        '
        'label_tijd
        '
        Me.label_tijd.AutoSize = True
        Me.label_tijd.Location = New System.Drawing.Point(77, 7)
        Me.label_tijd.Name = "label_tijd"
        Me.label_tijd.Size = New System.Drawing.Size(16, 13)
        Me.label_tijd.TabIndex = 1
        Me.label_tijd.Text = "..."
        '
        'Label_UpdateIn
        '
        Me.Label_UpdateIn.AutoSize = True
        Me.Label_UpdateIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_UpdateIn.Location = New System.Drawing.Point(7, 7)
        Me.Label_UpdateIn.Name = "Label_UpdateIn"
        Me.Label_UpdateIn.Size = New System.Drawing.Size(64, 13)
        Me.Label_UpdateIn.TabIndex = 0
        Me.Label_UpdateIn.Text = "Update in:"
        '
        'DGV_Main
        '
        Me.DGV_Main.AllowUserToAddRows = False
        Me.DGV_Main.AllowUserToDeleteRows = False
        Me.DGV_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Main.Location = New System.Drawing.Point(186, 114)
        Me.DGV_Main.Name = "DGV_Main"
        Me.DGV_Main.ReadOnly = True
        Me.DGV_Main.Size = New System.Drawing.Size(507, 389)
        Me.DGV_Main.TabIndex = 5
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Enabled = True
        Me.UpdateTimer.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptiesToolStripMenuItem, Me.OverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptiesToolStripMenuItem
        '
        Me.OptiesToolStripMenuItem.Name = "OptiesToolStripMenuItem"
        Me.OptiesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.OptiesToolStripMenuItem.Text = "Opties"
        '
        'OverToolStripMenuItem
        '
        Me.OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        Me.OverToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.OverToolStripMenuItem.Text = "Over"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 503)
        Me.Controls.Add(Me.DGV_Main)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 500)
        Me.Name = "Form1"
        Me.Text = "Pizzeria Applicatie"
        Me.sidePanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.logoPanel.ResumeLayout(False)
        Me.logoPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents header As Panel
    Friend WithEvents Labl_Logo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BT_Gebruiker As Button
    Friend WithEvents BT_Cancel As Button
    Friend WithEvents BT_Afhandelen As Button
    Friend WithEvents TB_Adres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents L_Afhalen As Label
    Friend WithEvents BT_Opslaan As Button
    Friend WithEvents TB_Bestelling As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents label_tijd As Label
    Friend WithEvents Label_UpdateIn As Label
    Friend WithEvents DGV_Main As DataGridView
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BT_OpenBestellingen As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_ZoekKlant As Button
    Friend WithEvents BT_ZoekBestelling As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_StatusUpdate As Label
End Class
