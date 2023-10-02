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
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.panellogo = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btncashier = New FontAwesome.Sharp.IconButton()
        Me.btnlogs = New FontAwesome.Sharp.IconButton()
        Me.btnupdate = New FontAwesome.Sharp.IconButton()
        Me.btnadd = New FontAwesome.Sharp.IconButton()
        Me.panelheading = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconcurrentform = New FontAwesome.Sharp.IconPictureBox()
        Me.paneldata = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panelbottom = New System.Windows.Forms.Panel()
        Me.btnsales = New FontAwesome.Sharp.IconButton()
        Me.btninventory = New FontAwesome.Sharp.IconButton()
        Me.paneltexts = New System.Windows.Forms.Panel()
        Me.btnsubmit = New FontAwesome.Sharp.IconButton()
        Me.txtboxpdisplay = New System.Windows.Forms.TextBox()
        Me.txtboxpinstock = New System.Windows.Forms.TextBox()
        Me.txtboxpcost = New System.Windows.Forms.TextBox()
        Me.txtboxpname = New System.Windows.Forms.TextBox()
        Me.txtboxid = New System.Windows.Forms.TextBox()
        Me.panelmenu.SuspendLayout()
        Me.panellogo.SuspendLayout()
        Me.panelheading.SuspendLayout()
        CType(Me.iconcurrentform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldata.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelbottom.SuspendLayout()
        Me.paneltexts.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelmenu.Controls.Add(Me.panellogo)
        Me.panelmenu.Controls.Add(Me.btncashier)
        Me.panelmenu.Controls.Add(Me.btnlogs)
        Me.panelmenu.Controls.Add(Me.btnupdate)
        Me.panelmenu.Controls.Add(Me.btnadd)
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(177, 515)
        Me.panelmenu.TabIndex = 0
        '
        'panellogo
        '
        Me.panellogo.Controls.Add(Me.lbltitle)
        Me.panellogo.Location = New System.Drawing.Point(0, 0)
        Me.panellogo.Name = "panellogo"
        Me.panellogo.Size = New System.Drawing.Size(177, 91)
        Me.panellogo.TabIndex = 5
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbltitle.Location = New System.Drawing.Point(47, 30)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(85, 29)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "HOME"
        '
        'btncashier
        '
        Me.btncashier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncashier.FlatAppearance.BorderSize = 0
        Me.btncashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncashier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncashier.ForeColor = System.Drawing.Color.Gainsboro
        Me.btncashier.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.btncashier.IconColor = System.Drawing.Color.Gainsboro
        Me.btncashier.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncashier.Location = New System.Drawing.Point(0, 437)
        Me.btncashier.Name = "btncashier"
        Me.btncashier.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btncashier.Size = New System.Drawing.Size(177, 66)
        Me.btncashier.TabIndex = 8
        Me.btncashier.Text = "CASHIER"
        Me.btncashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncashier.UseVisualStyleBackColor = True
        '
        'btnlogs
        '
        Me.btnlogs.FlatAppearance.BorderSize = 0
        Me.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogs.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnlogs.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        Me.btnlogs.IconColor = System.Drawing.Color.Gainsboro
        Me.btnlogs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogs.Location = New System.Drawing.Point(0, 216)
        Me.btnlogs.Name = "btnlogs"
        Me.btnlogs.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnlogs.Size = New System.Drawing.Size(174, 66)
        Me.btnlogs.TabIndex = 7
        Me.btnlogs.Text = "LOGS"
        Me.btnlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogs.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.FlatAppearance.BorderSize = 0
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnupdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnupdate.IconColor = System.Drawing.Color.Gainsboro
        Me.btnupdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(0, 157)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnupdate.Size = New System.Drawing.Size(174, 66)
        Me.btnupdate.TabIndex = 5
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnadd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnadd.IconColor = System.Drawing.Color.White
        Me.btnadd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(0, 97)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnadd.Size = New System.Drawing.Size(177, 66)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'panelheading
        '
        Me.panelheading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelheading.BackColor = System.Drawing.Color.SlateBlue
        Me.panelheading.Controls.Add(Me.Label1)
        Me.panelheading.Controls.Add(Me.iconcurrentform)
        Me.panelheading.Location = New System.Drawing.Point(177, 0)
        Me.panelheading.Name = "panelheading"
        Me.panelheading.Size = New System.Drawing.Size(544, 59)
        Me.panelheading.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(55, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data"
        '
        'iconcurrentform
        '
        Me.iconcurrentform.BackColor = System.Drawing.Color.SlateBlue
        Me.iconcurrentform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.iconcurrentform.IconChar = FontAwesome.Sharp.IconChar.List
        Me.iconcurrentform.IconColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.iconcurrentform.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconcurrentform.IconSize = 43
        Me.iconcurrentform.Location = New System.Drawing.Point(6, 6)
        Me.iconcurrentform.Name = "iconcurrentform"
        Me.iconcurrentform.Size = New System.Drawing.Size(43, 44)
        Me.iconcurrentform.TabIndex = 0
        Me.iconcurrentform.TabStop = False
        '
        'paneldata
        '
        Me.paneldata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneldata.BackColor = System.Drawing.Color.SlateBlue
        Me.paneldata.Controls.Add(Me.DataGridView1)
        Me.paneldata.Controls.Add(Me.panelbottom)
        Me.paneldata.Location = New System.Drawing.Point(177, 56)
        Me.paneldata.Name = "paneldata"
        Me.paneldata.Size = New System.Drawing.Size(745, 459)
        Me.paneldata.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(524, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'panelbottom
        '
        Me.panelbottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panelbottom.BackColor = System.Drawing.Color.SlateBlue
        Me.panelbottom.Controls.Add(Me.btnsales)
        Me.panelbottom.Controls.Add(Me.btninventory)
        Me.panelbottom.Location = New System.Drawing.Point(6, 362)
        Me.panelbottom.Name = "panelbottom"
        Me.panelbottom.Size = New System.Drawing.Size(524, 97)
        Me.panelbottom.TabIndex = 11
        '
        'btnsales
        '
        Me.btnsales.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnsales.FlatAppearance.BorderSize = 0
        Me.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsales.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnsales.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd
        Me.btnsales.IconColor = System.Drawing.Color.White
        Me.btnsales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsales.Location = New System.Drawing.Point(289, 20)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnsales.Size = New System.Drawing.Size(177, 66)
        Me.btnsales.TabIndex = 10
        Me.btnsales.Text = "SALES"
        Me.btnsales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsales.UseVisualStyleBackColor = True
        '
        'btninventory
        '
        Me.btninventory.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btninventory.FlatAppearance.BorderSize = 0
        Me.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninventory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btninventory.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.btninventory.IconColor = System.Drawing.Color.White
        Me.btninventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btninventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninventory.Location = New System.Drawing.Point(70, 20)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btninventory.Size = New System.Drawing.Size(177, 66)
        Me.btninventory.TabIndex = 9
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninventory.UseVisualStyleBackColor = True
        '
        'paneltexts
        '
        Me.paneltexts.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.paneltexts.Controls.Add(Me.btnsubmit)
        Me.paneltexts.Controls.Add(Me.txtboxpdisplay)
        Me.paneltexts.Controls.Add(Me.txtboxpinstock)
        Me.paneltexts.Controls.Add(Me.txtboxpcost)
        Me.paneltexts.Controls.Add(Me.txtboxpname)
        Me.paneltexts.Controls.Add(Me.txtboxid)
        Me.paneltexts.Dock = System.Windows.Forms.DockStyle.Right
        Me.paneltexts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.paneltexts.Location = New System.Drawing.Point(716, 0)
        Me.paneltexts.Name = "paneltexts"
        Me.paneltexts.Size = New System.Drawing.Size(206, 515)
        Me.paneltexts.TabIndex = 4
        '
        'btnsubmit
        '
        Me.btnsubmit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsubmit.FlatAppearance.BorderSize = 0
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnsubmit.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        Me.btnsubmit.IconColor = System.Drawing.Color.White
        Me.btnsubmit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubmit.Location = New System.Drawing.Point(17, 418)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnsubmit.Size = New System.Drawing.Size(177, 66)
        Me.btnsubmit.TabIndex = 11
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtboxpdisplay
        '
        Me.txtboxpdisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpdisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpdisplay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpdisplay.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpdisplay.Location = New System.Drawing.Point(3, 344)
        Me.txtboxpdisplay.Name = "txtboxpdisplay"
        Me.txtboxpdisplay.Size = New System.Drawing.Size(200, 26)
        Me.txtboxpdisplay.TabIndex = 4
        Me.txtboxpdisplay.Text = "Products Displayed"
        '
        'txtboxpinstock
        '
        Me.txtboxpinstock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpinstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpinstock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpinstock.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpinstock.Location = New System.Drawing.Point(3, 278)
        Me.txtboxpinstock.Name = "txtboxpinstock"
        Me.txtboxpinstock.Size = New System.Drawing.Size(200, 26)
        Me.txtboxpinstock.TabIndex = 3
        Me.txtboxpinstock.Text = "Products In Stock"
        '
        'txtboxpcost
        '
        Me.txtboxpcost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpcost.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpcost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpcost.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpcost.Location = New System.Drawing.Point(3, 216)
        Me.txtboxpcost.Name = "txtboxpcost"
        Me.txtboxpcost.Size = New System.Drawing.Size(200, 26)
        Me.txtboxpcost.TabIndex = 2
        Me.txtboxpcost.Text = "Product Cost"
        '
        'txtboxpname
        '
        Me.txtboxpname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpname.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpname.Location = New System.Drawing.Point(3, 157)
        Me.txtboxpname.Name = "txtboxpname"
        Me.txtboxpname.Size = New System.Drawing.Size(200, 26)
        Me.txtboxpname.TabIndex = 1
        Me.txtboxpname.Text = "Product Name"
        '
        'txtboxid
        '
        Me.txtboxid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxid.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxid.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxid.Location = New System.Drawing.Point(3, 97)
        Me.txtboxid.Name = "txtboxid"
        Me.txtboxid.Size = New System.Drawing.Size(200, 26)
        Me.txtboxid.TabIndex = 0
        Me.txtboxid.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 515)
        Me.Controls.Add(Me.paneltexts)
        Me.Controls.Add(Me.paneldata)
        Me.Controls.Add(Me.panelheading)
        Me.Controls.Add(Me.panelmenu)
        Me.MinimumSize = New System.Drawing.Size(938, 554)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelmenu.ResumeLayout(False)
        Me.panellogo.ResumeLayout(False)
        Me.panellogo.PerformLayout()
        Me.panelheading.ResumeLayout(False)
        Me.panelheading.PerformLayout()
        CType(Me.iconcurrentform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldata.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelbottom.ResumeLayout(False)
        Me.paneltexts.ResumeLayout(False)
        Me.paneltexts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents panelheading As Panel
    Friend WithEvents btnadd As FontAwesome.Sharp.IconButton
    Friend WithEvents btncashier As FontAwesome.Sharp.IconButton
    Friend WithEvents btnlogs As FontAwesome.Sharp.IconButton
    Friend WithEvents btnupdate As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents iconcurrentform As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents paneldata As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents paneltexts As Panel
    Friend WithEvents panellogo As Panel
    Friend WithEvents btnsales As FontAwesome.Sharp.IconButton
    Friend WithEvents btninventory As FontAwesome.Sharp.IconButton
    Friend WithEvents txtboxid As TextBox
    Friend WithEvents txtboxpdisplay As TextBox
    Friend WithEvents txtboxpinstock As TextBox
    Friend WithEvents txtboxpcost As TextBox
    Friend WithEvents txtboxpname As TextBox
    Friend WithEvents btnsubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents lbltitle As Label
    Friend WithEvents panelbottom As Panel
End Class
