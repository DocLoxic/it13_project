<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.panellogo = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btncashier = New FontAwesome.Sharp.IconButton()
        Me.btnlogs = New FontAwesome.Sharp.IconButton()
        Me.btnupdate = New FontAwesome.Sharp.IconButton()
        Me.btnadd = New FontAwesome.Sharp.IconButton()
        Me.panelheading = New System.Windows.Forms.Panel()
        Me.lblTopmain = New System.Windows.Forms.Label()
        Me.iconcurrentform = New FontAwesome.Sharp.IconPictureBox()
        Me.paneldata = New System.Windows.Forms.Panel()
        Me.dgv_all = New System.Windows.Forms.DataGridView()
        Me.panelbottom = New System.Windows.Forms.Panel()
        Me.btn_new_trans = New FontAwesome.Sharp.IconButton()
        Me.btn_show_cart = New FontAwesome.Sharp.IconButton()
        Me.btnsales = New FontAwesome.Sharp.IconButton()
        Me.btninventory = New FontAwesome.Sharp.IconButton()
        Me.paneltexts = New System.Windows.Forms.Panel()
        Me.lblnuID = New System.Windows.Forms.Label()
        Me.lblniDisp = New System.Windows.Forms.Label()
        Me.lblniID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_payment = New System.Windows.Forms.Label()
        Me.txt_payment = New System.Windows.Forms.TextBox()
        Me.btn_pay = New FontAwesome.Sharp.IconButton()
        Me.lbl_order_total = New System.Windows.Forms.Label()
        Me.txt_order_total = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.btn_add_to_cart = New FontAwesome.Sharp.IconButton()
        Me.product_id_logs = New System.Windows.Forms.TextBox()
        Me.log_date = New System.Windows.Forms.TextBox()
        Me.log_type = New System.Windows.Forms.TextBox()
        Me.log_id = New System.Windows.Forms.TextBox()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.lbl_log_date = New System.Windows.Forms.Label()
        Me.lbl_log_type = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trans_id_sales = New System.Windows.Forms.TextBox()
        Me.sales_date = New System.Windows.Forms.TextBox()
        Me.total_sales = New System.Windows.Forms.TextBox()
        Me.id_sales = New System.Windows.Forms.TextBox()
        Me.lbl_trans_id = New System.Windows.Forms.Label()
        Me.lbl_sales_date = New System.Windows.Forms.Label()
        Me.lbl_total_sales = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_displayed = New System.Windows.Forms.Label()
        Me.lbl_in_stock = New System.Windows.Forms.Label()
        Me.lbl_product_cost = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.btnsubmit = New FontAwesome.Sharp.IconButton()
        Me.txtboxpdisplay = New System.Windows.Forms.TextBox()
        Me.txtboxpinstock = New System.Windows.Forms.TextBox()
        Me.txtboxpcost = New System.Windows.Forms.TextBox()
        Me.txtboxpname = New System.Windows.Forms.TextBox()
        Me.txtboxid = New System.Windows.Forms.TextBox()
        Me.lblRO1 = New System.Windows.Forms.Label()
        Me.lblRO2 = New System.Windows.Forms.Label()
        Me.lblRO3 = New System.Windows.Forms.Label()
        Me.lblRO4 = New System.Windows.Forms.Label()
        Me.lblRO5 = New System.Windows.Forms.Label()
        Me.lblRO6 = New System.Windows.Forms.Label()
        Me.lblRO7 = New System.Windows.Forms.Label()
        Me.panelmenu.SuspendLayout()
        Me.panellogo.SuspendLayout()
        Me.panelheading.SuspendLayout()
        CType(Me.iconcurrentform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldata.SuspendLayout()
        CType(Me.dgv_all, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelmenu.Margin = New System.Windows.Forms.Padding(4)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(236, 634)
        Me.panelmenu.TabIndex = 0
        '
        'panellogo
        '
        Me.panellogo.Controls.Add(Me.lbltitle)
        Me.panellogo.Location = New System.Drawing.Point(0, 0)
        Me.panellogo.Margin = New System.Windows.Forms.Padding(4)
        Me.panellogo.Name = "panellogo"
        Me.panellogo.Size = New System.Drawing.Size(236, 112)
        Me.panellogo.TabIndex = 5
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbltitle.Location = New System.Drawing.Point(63, 37)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(105, 35)
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
        Me.btncashier.Location = New System.Drawing.Point(0, 538)
        Me.btncashier.Margin = New System.Windows.Forms.Padding(4)
        Me.btncashier.Name = "btncashier"
        Me.btncashier.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btncashier.Size = New System.Drawing.Size(236, 81)
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
        Me.btnlogs.Location = New System.Drawing.Point(0, 266)
        Me.btnlogs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogs.Name = "btnlogs"
        Me.btnlogs.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnlogs.Size = New System.Drawing.Size(232, 81)
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
        Me.btnupdate.Location = New System.Drawing.Point(0, 193)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Padding = New System.Windows.Forms.Padding(15, 0, 27, 0)
        Me.btnupdate.Size = New System.Drawing.Size(232, 81)
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
        Me.btnadd.Location = New System.Drawing.Point(0, 119)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnadd.Size = New System.Drawing.Size(236, 81)
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
        Me.panelheading.Controls.Add(Me.lblTopmain)
        Me.panelheading.Controls.Add(Me.iconcurrentform)
        Me.panelheading.Location = New System.Drawing.Point(236, 0)
        Me.panelheading.Margin = New System.Windows.Forms.Padding(4)
        Me.panelheading.Name = "panelheading"
        Me.panelheading.Size = New System.Drawing.Size(725, 73)
        Me.panelheading.TabIndex = 2
        '
        'lblTopmain
        '
        Me.lblTopmain.AutoSize = True
        Me.lblTopmain.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopmain.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTopmain.Location = New System.Drawing.Point(73, 22)
        Me.lblTopmain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTopmain.Name = "lblTopmain"
        Me.lblTopmain.Size = New System.Drawing.Size(199, 24)
        Me.lblTopmain.TabIndex = 1
        Me.lblTopmain.Text = "Product Information"
        '
        'iconcurrentform
        '
        Me.iconcurrentform.BackColor = System.Drawing.Color.SlateBlue
        Me.iconcurrentform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.iconcurrentform.IconChar = FontAwesome.Sharp.IconChar.List
        Me.iconcurrentform.IconColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.iconcurrentform.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconcurrentform.IconSize = 54
        Me.iconcurrentform.Location = New System.Drawing.Point(8, 7)
        Me.iconcurrentform.Margin = New System.Windows.Forms.Padding(4)
        Me.iconcurrentform.Name = "iconcurrentform"
        Me.iconcurrentform.Size = New System.Drawing.Size(57, 54)
        Me.iconcurrentform.TabIndex = 0
        Me.iconcurrentform.TabStop = False
        '
        'paneldata
        '
        Me.paneldata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneldata.BackColor = System.Drawing.Color.SlateBlue
        Me.paneldata.Controls.Add(Me.dgv_all)
        Me.paneldata.Controls.Add(Me.panelbottom)
        Me.paneldata.Location = New System.Drawing.Point(236, 69)
        Me.paneldata.Margin = New System.Windows.Forms.Padding(4)
        Me.paneldata.Name = "paneldata"
        Me.paneldata.Size = New System.Drawing.Size(993, 565)
        Me.paneldata.TabIndex = 3
        '
        'dgv_all
        '
        Me.dgv_all.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_all.Location = New System.Drawing.Point(8, 11)
        Me.dgv_all.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_all.Name = "dgv_all"
        Me.dgv_all.RowHeadersWidth = 51
        Me.dgv_all.Size = New System.Drawing.Size(699, 444)
        Me.dgv_all.TabIndex = 0
        '
        'panelbottom
        '
        Me.panelbottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panelbottom.BackColor = System.Drawing.Color.SlateBlue
        Me.panelbottom.Controls.Add(Me.btn_new_trans)
        Me.panelbottom.Controls.Add(Me.btn_show_cart)
        Me.panelbottom.Controls.Add(Me.btnsales)
        Me.panelbottom.Controls.Add(Me.btninventory)
        Me.panelbottom.Location = New System.Drawing.Point(8, 446)
        Me.panelbottom.Margin = New System.Windows.Forms.Padding(4)
        Me.panelbottom.Name = "panelbottom"
        Me.panelbottom.Size = New System.Drawing.Size(699, 119)
        Me.panelbottom.TabIndex = 11
        '
        'btn_new_trans
        '
        Me.btn_new_trans.FlatAppearance.BorderSize = 0
        Me.btn_new_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_trans.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_trans.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_new_trans.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btn_new_trans.IconColor = System.Drawing.Color.White
        Me.btn_new_trans.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_new_trans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_trans.Location = New System.Drawing.Point(173, 25)
        Me.btn_new_trans.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_new_trans.Name = "btn_new_trans"
        Me.btn_new_trans.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btn_new_trans.Size = New System.Drawing.Size(347, 81)
        Me.btn_new_trans.TabIndex = 9
        Me.btn_new_trans.Text = "NEW TRANSACTION"
        Me.btn_new_trans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_new_trans.UseVisualStyleBackColor = True
        '
        'btn_show_cart
        '
        Me.btn_show_cart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_show_cart.FlatAppearance.BorderSize = 0
        Me.btn_show_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show_cart.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_cart.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_show_cart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btn_show_cart.IconColor = System.Drawing.Color.White
        Me.btn_show_cart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_show_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show_cart.Location = New System.Drawing.Point(385, 26)
        Me.btn_show_cart.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_show_cart.Name = "btn_show_cart"
        Me.btn_show_cart.Padding = New System.Windows.Forms.Padding(7, 0, 27, 0)
        Me.btn_show_cart.Size = New System.Drawing.Size(236, 81)
        Me.btn_show_cart.TabIndex = 33
        Me.btn_show_cart.Text = "ORDERS"
        Me.btn_show_cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show_cart.UseVisualStyleBackColor = True
        Me.btn_show_cart.Visible = False
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
        Me.btnsales.Location = New System.Drawing.Point(385, 25)
        Me.btnsales.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.Padding = New System.Windows.Forms.Padding(7, 0, 27, 0)
        Me.btnsales.Size = New System.Drawing.Size(236, 81)
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
        Me.btninventory.Location = New System.Drawing.Point(93, 25)
        Me.btninventory.Margin = New System.Windows.Forms.Padding(4)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Padding = New System.Windows.Forms.Padding(7, 0, 27, 0)
        Me.btninventory.Size = New System.Drawing.Size(236, 81)
        Me.btninventory.TabIndex = 9
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninventory.UseVisualStyleBackColor = True
        '
        'paneltexts
        '
        Me.paneltexts.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.paneltexts.Controls.Add(Me.lblRO7)
        Me.paneltexts.Controls.Add(Me.lblRO6)
        Me.paneltexts.Controls.Add(Me.lblRO5)
        Me.paneltexts.Controls.Add(Me.lblRO4)
        Me.paneltexts.Controls.Add(Me.lblRO3)
        Me.paneltexts.Controls.Add(Me.lblRO2)
        Me.paneltexts.Controls.Add(Me.lblRO1)
        Me.paneltexts.Controls.Add(Me.lblnuID)
        Me.paneltexts.Controls.Add(Me.lblniDisp)
        Me.paneltexts.Controls.Add(Me.lblniID)
        Me.paneltexts.Controls.Add(Me.Label2)
        Me.paneltexts.Controls.Add(Me.lbl_payment)
        Me.paneltexts.Controls.Add(Me.txt_payment)
        Me.paneltexts.Controls.Add(Me.btn_pay)
        Me.paneltexts.Controls.Add(Me.lbl_order_total)
        Me.paneltexts.Controls.Add(Me.txt_order_total)
        Me.paneltexts.Controls.Add(Me.lbl_quantity)
        Me.paneltexts.Controls.Add(Me.txt_quantity)
        Me.paneltexts.Controls.Add(Me.btn_add_to_cart)
        Me.paneltexts.Controls.Add(Me.product_id_logs)
        Me.paneltexts.Controls.Add(Me.log_date)
        Me.paneltexts.Controls.Add(Me.log_type)
        Me.paneltexts.Controls.Add(Me.log_id)
        Me.paneltexts.Controls.Add(Me.lbl_product_id)
        Me.paneltexts.Controls.Add(Me.lbl_log_date)
        Me.paneltexts.Controls.Add(Me.lbl_log_type)
        Me.paneltexts.Controls.Add(Me.Label5)
        Me.paneltexts.Controls.Add(Me.trans_id_sales)
        Me.paneltexts.Controls.Add(Me.sales_date)
        Me.paneltexts.Controls.Add(Me.total_sales)
        Me.paneltexts.Controls.Add(Me.id_sales)
        Me.paneltexts.Controls.Add(Me.lbl_trans_id)
        Me.paneltexts.Controls.Add(Me.lbl_sales_date)
        Me.paneltexts.Controls.Add(Me.lbl_total_sales)
        Me.paneltexts.Controls.Add(Me.lbl_id)
        Me.paneltexts.Controls.Add(Me.lbl_displayed)
        Me.paneltexts.Controls.Add(Me.lbl_in_stock)
        Me.paneltexts.Controls.Add(Me.lbl_product_cost)
        Me.paneltexts.Controls.Add(Me.lbl_product_name)
        Me.paneltexts.Controls.Add(Me.btnsubmit)
        Me.paneltexts.Controls.Add(Me.txtboxpdisplay)
        Me.paneltexts.Controls.Add(Me.txtboxpinstock)
        Me.paneltexts.Controls.Add(Me.txtboxpcost)
        Me.paneltexts.Controls.Add(Me.txtboxpname)
        Me.paneltexts.Controls.Add(Me.txtboxid)
        Me.paneltexts.Dock = System.Windows.Forms.DockStyle.Right
        Me.paneltexts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.paneltexts.Location = New System.Drawing.Point(954, 0)
        Me.paneltexts.Margin = New System.Windows.Forms.Padding(4)
        Me.paneltexts.Name = "paneltexts"
        Me.paneltexts.Size = New System.Drawing.Size(275, 634)
        Me.paneltexts.TabIndex = 4
        '
        'lblnuID
        '
        Me.lblnuID.AutoSize = True
        Me.lblnuID.ForeColor = System.Drawing.Color.Red
        Me.lblnuID.Location = New System.Drawing.Point(175, 16)
        Me.lblnuID.Name = "lblnuID"
        Me.lblnuID.Size = New System.Drawing.Size(67, 16)
        Me.lblnuID.TabIndex = 43
        Me.lblnuID.Text = "ID is fixed!"
        Me.lblnuID.Visible = False
        '
        'lblniDisp
        '
        Me.lblniDisp.AutoSize = True
        Me.lblniDisp.ForeColor = System.Drawing.Color.Red
        Me.lblniDisp.Location = New System.Drawing.Point(126, 313)
        Me.lblniDisp.Name = "lblniDisp"
        Me.lblniDisp.Size = New System.Drawing.Size(116, 16)
        Me.lblniDisp.TabIndex = 42
        Me.lblniDisp.Text = "No inputs allowed!"
        Me.lblniDisp.Visible = False
        '
        'lblniID
        '
        Me.lblniID.AutoSize = True
        Me.lblniID.ForeColor = System.Drawing.Color.Red
        Me.lblniID.Location = New System.Drawing.Point(126, 16)
        Me.lblniID.Name = "lblniID"
        Me.lblniID.Size = New System.Drawing.Size(116, 16)
        Me.lblniID.TabIndex = 41
        Me.lblniID.Text = "No inputs allowed!"
        Me.lblniID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Label2"
        '
        'lbl_payment
        '
        Me.lbl_payment.AutoSize = True
        Me.lbl_payment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_payment.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_payment.Location = New System.Drawing.Point(4, 391)
        Me.lbl_payment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_payment.Name = "lbl_payment"
        Me.lbl_payment.Size = New System.Drawing.Size(92, 24)
        Me.lbl_payment.TabIndex = 39
        Me.lbl_payment.Text = "Payment"
        Me.lbl_payment.Visible = False
        '
        'txt_payment
        '
        Me.txt_payment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_payment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payment.ForeColor = System.Drawing.Color.Gainsboro
        Me.txt_payment.Location = New System.Drawing.Point(3, 419)
        Me.txt_payment.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_payment.Name = "txt_payment"
        Me.txt_payment.Size = New System.Drawing.Size(265, 30)
        Me.txt_payment.TabIndex = 38
        Me.txt_payment.Visible = False
        '
        'btn_pay
        '
        Me.btn_pay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_pay.FlatAppearance.BorderSize = 0
        Me.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pay.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_pay.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btn_pay.IconColor = System.Drawing.Color.White
        Me.btn_pay.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pay.Location = New System.Drawing.Point(65, 539)
        Me.btn_pay.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Padding = New System.Windows.Forms.Padding(7, 0, 27, 0)
        Me.btn_pay.Size = New System.Drawing.Size(159, 81)
        Me.btn_pay.TabIndex = 37
        Me.btn_pay.Text = "PAY"
        Me.btn_pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_pay.UseVisualStyleBackColor = True
        Me.btn_pay.Visible = False
        '
        'lbl_order_total
        '
        Me.lbl_order_total.AutoSize = True
        Me.lbl_order_total.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_total.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_order_total.Location = New System.Drawing.Point(4, 465)
        Me.lbl_order_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_order_total.Name = "lbl_order_total"
        Me.lbl_order_total.Size = New System.Drawing.Size(118, 24)
        Me.lbl_order_total.TabIndex = 36
        Me.lbl_order_total.Text = "Order Total"
        Me.lbl_order_total.Visible = False
        '
        'txt_order_total
        '
        Me.txt_order_total.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_order_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_order_total.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_order_total.ForeColor = System.Drawing.Color.Gainsboro
        Me.txt_order_total.Location = New System.Drawing.Point(4, 492)
        Me.txt_order_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_order_total.Name = "txt_order_total"
        Me.txt_order_total.ReadOnly = True
        Me.txt_order_total.Size = New System.Drawing.Size(265, 30)
        Me.txt_order_total.TabIndex = 35
        Me.txt_order_total.Visible = False
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_quantity.Location = New System.Drawing.Point(4, 391)
        Me.lbl_quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(91, 24)
        Me.lbl_quantity.TabIndex = 34
        Me.lbl_quantity.Text = "Quantity"
        Me.lbl_quantity.Visible = False
        '
        'txt_quantity
        '
        Me.txt_quantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_quantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_quantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.ForeColor = System.Drawing.Color.Gainsboro
        Me.txt_quantity.Location = New System.Drawing.Point(4, 418)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(265, 30)
        Me.txt_quantity.TabIndex = 33
        Me.txt_quantity.Visible = False
        '
        'btn_add_to_cart
        '
        Me.btn_add_to_cart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_add_to_cart.FlatAppearance.BorderSize = 0
        Me.btn_add_to_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_to_cart.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_to_cart.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_add_to_cart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btn_add_to_cart.IconColor = System.Drawing.Color.White
        Me.btn_add_to_cart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_add_to_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_to_cart.Location = New System.Drawing.Point(23, 538)
        Me.btn_add_to_cart.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_add_to_cart.Name = "btn_add_to_cart"
        Me.btn_add_to_cart.Padding = New System.Windows.Forms.Padding(7, 0, 27, 0)
        Me.btn_add_to_cart.Size = New System.Drawing.Size(236, 81)
        Me.btn_add_to_cart.TabIndex = 32
        Me.btn_add_to_cart.Text = "ADD TO CART"
        Me.btn_add_to_cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add_to_cart.UseVisualStyleBackColor = True
        Me.btn_add_to_cart.Visible = False
        '
        'product_id_logs
        '
        Me.product_id_logs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.product_id_logs.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.product_id_logs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_id_logs.ForeColor = System.Drawing.Color.Gainsboro
        Me.product_id_logs.Location = New System.Drawing.Point(4, 266)
        Me.product_id_logs.Margin = New System.Windows.Forms.Padding(4)
        Me.product_id_logs.Name = "product_id_logs"
        Me.product_id_logs.ReadOnly = True
        Me.product_id_logs.Size = New System.Drawing.Size(265, 30)
        Me.product_id_logs.TabIndex = 31
        '
        'log_date
        '
        Me.log_date.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.log_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.log_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_date.ForeColor = System.Drawing.Color.Gainsboro
        Me.log_date.Location = New System.Drawing.Point(4, 190)
        Me.log_date.Margin = New System.Windows.Forms.Padding(4)
        Me.log_date.Name = "log_date"
        Me.log_date.ReadOnly = True
        Me.log_date.Size = New System.Drawing.Size(265, 30)
        Me.log_date.TabIndex = 30
        '
        'log_type
        '
        Me.log_type.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.log_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.log_type.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_type.ForeColor = System.Drawing.Color.Gainsboro
        Me.log_type.Location = New System.Drawing.Point(4, 117)
        Me.log_type.Margin = New System.Windows.Forms.Padding(4)
        Me.log_type.Name = "log_type"
        Me.log_type.ReadOnly = True
        Me.log_type.Size = New System.Drawing.Size(265, 30)
        Me.log_type.TabIndex = 29
        '
        'log_id
        '
        Me.log_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.log_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.log_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_id.ForeColor = System.Drawing.Color.Gainsboro
        Me.log_id.Location = New System.Drawing.Point(4, 43)
        Me.log_id.Margin = New System.Windows.Forms.Padding(4)
        Me.log_id.Name = "log_id"
        Me.log_id.ReadOnly = True
        Me.log_id.Size = New System.Drawing.Size(265, 30)
        Me.log_id.TabIndex = 28
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_product_id.Location = New System.Drawing.Point(4, 239)
        Me.lbl_product_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(110, 24)
        Me.lbl_product_id.TabIndex = 27
        Me.lbl_product_id.Text = "Product ID"
        '
        'lbl_log_date
        '
        Me.lbl_log_date.AutoSize = True
        Me.lbl_log_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_log_date.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_log_date.Location = New System.Drawing.Point(4, 162)
        Me.lbl_log_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_log_date.Name = "lbl_log_date"
        Me.lbl_log_date.Size = New System.Drawing.Size(95, 24)
        Me.lbl_log_date.TabIndex = 26
        Me.lbl_log_date.Text = "Log Date"
        '
        'lbl_log_type
        '
        Me.lbl_log_type.AutoSize = True
        Me.lbl_log_type.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_log_type.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_log_type.Location = New System.Drawing.Point(4, 90)
        Me.lbl_log_type.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_log_type.Name = "lbl_log_type"
        Me.lbl_log_type.Size = New System.Drawing.Size(98, 24)
        Me.lbl_log_type.TabIndex = 25
        Me.lbl_log_type.Text = "Log Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(4, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID"
        '
        'trans_id_sales
        '
        Me.trans_id_sales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trans_id_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.trans_id_sales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trans_id_sales.ForeColor = System.Drawing.Color.Gainsboro
        Me.trans_id_sales.Location = New System.Drawing.Point(4, 266)
        Me.trans_id_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.trans_id_sales.Name = "trans_id_sales"
        Me.trans_id_sales.ReadOnly = True
        Me.trans_id_sales.Size = New System.Drawing.Size(265, 30)
        Me.trans_id_sales.TabIndex = 23
        '
        'sales_date
        '
        Me.sales_date.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sales_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.sales_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales_date.ForeColor = System.Drawing.Color.Gainsboro
        Me.sales_date.Location = New System.Drawing.Point(4, 190)
        Me.sales_date.Margin = New System.Windows.Forms.Padding(4)
        Me.sales_date.Name = "sales_date"
        Me.sales_date.ReadOnly = True
        Me.sales_date.Size = New System.Drawing.Size(265, 30)
        Me.sales_date.TabIndex = 22
        '
        'total_sales
        '
        Me.total_sales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.total_sales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_sales.ForeColor = System.Drawing.Color.Gainsboro
        Me.total_sales.Location = New System.Drawing.Point(4, 117)
        Me.total_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.total_sales.Name = "total_sales"
        Me.total_sales.ReadOnly = True
        Me.total_sales.Size = New System.Drawing.Size(265, 30)
        Me.total_sales.TabIndex = 21
        '
        'id_sales
        '
        Me.id_sales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.id_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.id_sales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_sales.ForeColor = System.Drawing.Color.Gainsboro
        Me.id_sales.Location = New System.Drawing.Point(4, 43)
        Me.id_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.id_sales.Name = "id_sales"
        Me.id_sales.ReadOnly = True
        Me.id_sales.Size = New System.Drawing.Size(265, 30)
        Me.id_sales.TabIndex = 20
        '
        'lbl_trans_id
        '
        Me.lbl_trans_id.AutoSize = True
        Me.lbl_trans_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trans_id.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_trans_id.Location = New System.Drawing.Point(4, 239)
        Me.lbl_trans_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_trans_id.Name = "lbl_trans_id"
        Me.lbl_trans_id.Size = New System.Drawing.Size(147, 24)
        Me.lbl_trans_id.TabIndex = 19
        Me.lbl_trans_id.Text = "Transaction ID"
        '
        'lbl_sales_date
        '
        Me.lbl_sales_date.AutoSize = True
        Me.lbl_sales_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sales_date.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_sales_date.Location = New System.Drawing.Point(4, 162)
        Me.lbl_sales_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sales_date.Name = "lbl_sales_date"
        Me.lbl_sales_date.Size = New System.Drawing.Size(110, 24)
        Me.lbl_sales_date.TabIndex = 18
        Me.lbl_sales_date.Text = "Sales Date"
        '
        'lbl_total_sales
        '
        Me.lbl_total_sales.AutoSize = True
        Me.lbl_total_sales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_sales.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_total_sales.Location = New System.Drawing.Point(4, 90)
        Me.lbl_total_sales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_sales.Name = "lbl_total_sales"
        Me.lbl_total_sales.Size = New System.Drawing.Size(114, 24)
        Me.lbl_total_sales.TabIndex = 17
        Me.lbl_total_sales.Text = "Total Sales"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_id.Location = New System.Drawing.Point(4, 16)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(29, 24)
        Me.lbl_id.TabIndex = 16
        Me.lbl_id.Text = "ID"
        '
        'lbl_displayed
        '
        Me.lbl_displayed.AutoSize = True
        Me.lbl_displayed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_displayed.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_displayed.Location = New System.Drawing.Point(4, 313)
        Me.lbl_displayed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_displayed.Name = "lbl_displayed"
        Me.lbl_displayed.Size = New System.Drawing.Size(102, 24)
        Me.lbl_displayed.TabIndex = 15
        Me.lbl_displayed.Text = "Displayed"
        '
        'lbl_in_stock
        '
        Me.lbl_in_stock.AutoSize = True
        Me.lbl_in_stock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_in_stock.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_in_stock.Location = New System.Drawing.Point(4, 236)
        Me.lbl_in_stock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_in_stock.Name = "lbl_in_stock"
        Me.lbl_in_stock.Size = New System.Drawing.Size(87, 24)
        Me.lbl_in_stock.TabIndex = 14
        Me.lbl_in_stock.Text = "In Stock"
        '
        'lbl_product_cost
        '
        Me.lbl_product_cost.AutoSize = True
        Me.lbl_product_cost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_cost.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_product_cost.Location = New System.Drawing.Point(4, 162)
        Me.lbl_product_cost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_product_cost.Name = "lbl_product_cost"
        Me.lbl_product_cost.Size = New System.Drawing.Size(135, 24)
        Me.lbl_product_cost.TabIndex = 13
        Me.lbl_product_cost.Text = "Product Cost"
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_product_name.Location = New System.Drawing.Point(4, 90)
        Me.lbl_product_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(144, 24)
        Me.lbl_product_name.TabIndex = 12
        Me.lbl_product_name.Text = "Product Name"
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
        Me.btnsubmit.Location = New System.Drawing.Point(23, 538)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Padding = New System.Windows.Forms.Padding(33, 0, 0, 0)
        Me.btnsubmit.Size = New System.Drawing.Size(236, 81)
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
        Me.txtboxpdisplay.Location = New System.Drawing.Point(4, 340)
        Me.txtboxpdisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxpdisplay.Name = "txtboxpdisplay"
        Me.txtboxpdisplay.Size = New System.Drawing.Size(265, 30)
        Me.txtboxpdisplay.TabIndex = 4
        '
        'txtboxpinstock
        '
        Me.txtboxpinstock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpinstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpinstock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpinstock.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpinstock.Location = New System.Drawing.Point(4, 266)
        Me.txtboxpinstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxpinstock.Name = "txtboxpinstock"
        Me.txtboxpinstock.ReadOnly = True
        Me.txtboxpinstock.Size = New System.Drawing.Size(265, 30)
        Me.txtboxpinstock.TabIndex = 3
        '
        'txtboxpcost
        '
        Me.txtboxpcost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpcost.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpcost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpcost.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpcost.Location = New System.Drawing.Point(4, 190)
        Me.txtboxpcost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxpcost.Name = "txtboxpcost"
        Me.txtboxpcost.ReadOnly = True
        Me.txtboxpcost.Size = New System.Drawing.Size(265, 30)
        Me.txtboxpcost.TabIndex = 2
        '
        'txtboxpname
        '
        Me.txtboxpname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpname.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpname.Location = New System.Drawing.Point(4, 117)
        Me.txtboxpname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxpname.Name = "txtboxpname"
        Me.txtboxpname.ReadOnly = True
        Me.txtboxpname.Size = New System.Drawing.Size(265, 30)
        Me.txtboxpname.TabIndex = 1
        '
        'txtboxid
        '
        Me.txtboxid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxid.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxid.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxid.Location = New System.Drawing.Point(4, 43)
        Me.txtboxid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxid.Name = "txtboxid"
        Me.txtboxid.ReadOnly = True
        Me.txtboxid.Size = New System.Drawing.Size(265, 30)
        Me.txtboxid.TabIndex = 0
        '
        'lblRO1
        '
        Me.lblRO1.AutoSize = True
        Me.lblRO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO1.ForeColor = System.Drawing.Color.White
        Me.lblRO1.Location = New System.Drawing.Point(184, 22)
        Me.lblRO1.Name = "lblRO1"
        Me.lblRO1.Size = New System.Drawing.Size(85, 16)
        Me.lblRO1.TabIndex = 44
        Me.lblRO1.Text = "READ-ONLY"
        '
        'lblRO2
        '
        Me.lblRO2.AutoSize = True
        Me.lblRO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO2.ForeColor = System.Drawing.Color.White
        Me.lblRO2.Location = New System.Drawing.Point(184, 96)
        Me.lblRO2.Name = "lblRO2"
        Me.lblRO2.Size = New System.Drawing.Size(85, 16)
        Me.lblRO2.TabIndex = 45
        Me.lblRO2.Text = "READ-ONLY"
        '
        'lblRO3
        '
        Me.lblRO3.AutoSize = True
        Me.lblRO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO3.ForeColor = System.Drawing.Color.White
        Me.lblRO3.Location = New System.Drawing.Point(184, 168)
        Me.lblRO3.Name = "lblRO3"
        Me.lblRO3.Size = New System.Drawing.Size(85, 16)
        Me.lblRO3.TabIndex = 46
        Me.lblRO3.Text = "READ-ONLY"
        '
        'lblRO4
        '
        Me.lblRO4.AutoSize = True
        Me.lblRO4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO4.ForeColor = System.Drawing.Color.White
        Me.lblRO4.Location = New System.Drawing.Point(184, 245)
        Me.lblRO4.Name = "lblRO4"
        Me.lblRO4.Size = New System.Drawing.Size(85, 16)
        Me.lblRO4.TabIndex = 47
        Me.lblRO4.Text = "READ-ONLY"
        '
        'lblRO5
        '
        Me.lblRO5.AutoSize = True
        Me.lblRO5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO5.ForeColor = System.Drawing.Color.White
        Me.lblRO5.Location = New System.Drawing.Point(184, 319)
        Me.lblRO5.Name = "lblRO5"
        Me.lblRO5.Size = New System.Drawing.Size(85, 16)
        Me.lblRO5.TabIndex = 48
        Me.lblRO5.Text = "READ-ONLY"
        '
        'lblRO6
        '
        Me.lblRO6.AutoSize = True
        Me.lblRO6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO6.ForeColor = System.Drawing.Color.White
        Me.lblRO6.Location = New System.Drawing.Point(184, 397)
        Me.lblRO6.Name = "lblRO6"
        Me.lblRO6.Size = New System.Drawing.Size(85, 16)
        Me.lblRO6.TabIndex = 49
        Me.lblRO6.Text = "READ-ONLY"
        Me.lblRO6.Visible = False
        '
        'lblRO7
        '
        Me.lblRO7.AutoSize = True
        Me.lblRO7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRO7.ForeColor = System.Drawing.Color.White
        Me.lblRO7.Location = New System.Drawing.Point(184, 471)
        Me.lblRO7.Name = "lblRO7"
        Me.lblRO7.Size = New System.Drawing.Size(85, 16)
        Me.lblRO7.TabIndex = 50
        Me.lblRO7.Text = "READ-ONLY"
        Me.lblRO7.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 634)
        Me.Controls.Add(Me.paneltexts)
        Me.Controls.Add(Me.paneldata)
        Me.Controls.Add(Me.panelheading)
        Me.Controls.Add(Me.panelmenu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1245, 671)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aling NIta's Sari-Sari Store"
        Me.panelmenu.ResumeLayout(False)
        Me.panellogo.ResumeLayout(False)
        Me.panellogo.PerformLayout()
        Me.panelheading.ResumeLayout(False)
        Me.panelheading.PerformLayout()
        CType(Me.iconcurrentform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldata.ResumeLayout(False)
        CType(Me.dgv_all, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTopmain As Label
    Friend WithEvents iconcurrentform As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents paneldata As Panel
    Friend WithEvents dgv_all As DataGridView
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
    Friend WithEvents lbl_displayed As Label
    Friend WithEvents lbl_in_stock As Label
    Friend WithEvents lbl_product_cost As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents trans_id_sales As TextBox
    Friend WithEvents sales_date As TextBox
    Friend WithEvents total_sales As TextBox
    Friend WithEvents id_sales As TextBox
    Friend WithEvents lbl_trans_id As Label
    Friend WithEvents lbl_sales_date As Label
    Friend WithEvents lbl_total_sales As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents lbl_log_date As Label
    Friend WithEvents lbl_log_type As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents product_id_logs As TextBox
    Friend WithEvents log_date As TextBox
    Friend WithEvents log_type As TextBox
    Friend WithEvents log_id As TextBox
    Friend WithEvents btn_new_trans As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_add_to_cart As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_show_cart As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_order_total As Label
    Friend WithEvents txt_order_total As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_payment As Label
    Friend WithEvents txt_payment As TextBox
    Friend WithEvents btn_pay As FontAwesome.Sharp.IconButton
    Friend WithEvents lblniID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblniDisp As Label
    Friend WithEvents lblnuID As Label
    Friend WithEvents lblRO1 As Label
    Friend WithEvents lblRO7 As Label
    Friend WithEvents lblRO6 As Label
    Friend WithEvents lblRO5 As Label
    Friend WithEvents lblRO4 As Label
    Friend WithEvents lblRO3 As Label
    Friend WithEvents lblRO2 As Label
End Class
