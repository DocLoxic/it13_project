<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.panelcartdata = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btncheckcart = New FontAwesome.Sharp.IconButton()
        Me.btninventory = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panelcarttext = New System.Windows.Forms.Panel()
        Me.txtboxquantity = New System.Windows.Forms.TextBox()
        Me.btnaddtocart = New FontAwesome.Sharp.IconButton()
        Me.txtboxpdisplay2 = New System.Windows.Forms.TextBox()
        Me.txtboxtotal = New System.Windows.Forms.TextBox()
        Me.txtboxpcost2 = New System.Windows.Forms.TextBox()
        Me.txtboxpname2 = New System.Windows.Forms.TextBox()
        Me.txtboxid2 = New System.Windows.Forms.TextBox()
        Me.panelcartdata.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcarttext.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelcartdata
        '
        Me.panelcartdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelcartdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panelcartdata.Controls.Add(Me.IconButton1)
        Me.panelcartdata.Controls.Add(Me.btncheckcart)
        Me.panelcartdata.Controls.Add(Me.btninventory)
        Me.panelcartdata.Controls.Add(Me.DataGridView1)
        Me.panelcartdata.Location = New System.Drawing.Point(-1, 0)
        Me.panelcartdata.Name = "panelcartdata"
        Me.panelcartdata.Size = New System.Drawing.Size(575, 496)
        Me.panelcartdata.TabIndex = 4
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(13, 420)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(69, 64)
        Me.IconButton1.TabIndex = 11
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'btncheckcart
        '
        Me.btncheckcart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btncheckcart.FlatAppearance.BorderSize = 0
        Me.btncheckcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckcart.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheckcart.ForeColor = System.Drawing.Color.Gainsboro
        Me.btncheckcart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btncheckcart.IconColor = System.Drawing.Color.White
        Me.btncheckcart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncheckcart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncheckcart.Location = New System.Drawing.Point(317, 418)
        Me.btncheckcart.Name = "btncheckcart"
        Me.btncheckcart.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btncheckcart.Size = New System.Drawing.Size(177, 66)
        Me.btncheckcart.TabIndex = 10
        Me.btncheckcart.Text = "CART"
        Me.btncheckcart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncheckcart.UseVisualStyleBackColor = True
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
        Me.btninventory.Location = New System.Drawing.Point(116, 418)
        Me.btninventory.Name = "btninventory"
        Me.btninventory.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btninventory.Size = New System.Drawing.Size(177, 66)
        Me.btninventory.TabIndex = 9
        Me.btninventory.Text = "INVENTORY"
        Me.btninventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninventory.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Size = New System.Drawing.Size(561, 398)
        Me.DataGridView1.TabIndex = 0
        '
        'panelcarttext
        '
        Me.panelcarttext.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelcarttext.Controls.Add(Me.txtboxquantity)
        Me.panelcarttext.Controls.Add(Me.btnaddtocart)
        Me.panelcarttext.Controls.Add(Me.txtboxpdisplay2)
        Me.panelcarttext.Controls.Add(Me.txtboxtotal)
        Me.panelcarttext.Controls.Add(Me.txtboxpcost2)
        Me.panelcarttext.Controls.Add(Me.txtboxpname2)
        Me.panelcarttext.Controls.Add(Me.txtboxid2)
        Me.panelcarttext.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelcarttext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelcarttext.Location = New System.Drawing.Point(572, 0)
        Me.panelcarttext.Name = "panelcarttext"
        Me.panelcarttext.Size = New System.Drawing.Size(318, 494)
        Me.panelcarttext.TabIndex = 5
        '
        'txtboxquantity
        '
        Me.txtboxquantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxquantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxquantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxquantity.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxquantity.Location = New System.Drawing.Point(162, 54)
        Me.txtboxquantity.Name = "txtboxquantity"
        Me.txtboxquantity.Size = New System.Drawing.Size(126, 26)
        Me.txtboxquantity.TabIndex = 12
        Me.txtboxquantity.Text = "Quantity"
        '
        'btnaddtocart
        '
        Me.btnaddtocart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddtocart.FlatAppearance.BorderSize = 0
        Me.btnaddtocart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddtocart.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddtocart.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnaddtocart.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.btnaddtocart.IconColor = System.Drawing.Color.White
        Me.btnaddtocart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnaddtocart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddtocart.Location = New System.Drawing.Point(44, 395)
        Me.btnaddtocart.Name = "btnaddtocart"
        Me.btnaddtocart.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnaddtocart.Size = New System.Drawing.Size(203, 45)
        Me.btnaddtocart.TabIndex = 11
        Me.btnaddtocart.Text = "ADD TO CART"
        Me.btnaddtocart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddtocart.UseVisualStyleBackColor = True
        '
        'txtboxpdisplay2
        '
        Me.txtboxpdisplay2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpdisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpdisplay2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpdisplay2.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpdisplay2.Location = New System.Drawing.Point(60, 185)
        Me.txtboxpdisplay2.Name = "txtboxpdisplay2"
        Me.txtboxpdisplay2.Size = New System.Drawing.Size(168, 26)
        Me.txtboxpdisplay2.TabIndex = 4
        Me.txtboxpdisplay2.Text = "Products Displayed"
        '
        'txtboxtotal
        '
        Me.txtboxtotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxtotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxtotal.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxtotal.Location = New System.Drawing.Point(44, 317)
        Me.txtboxtotal.Name = "txtboxtotal"
        Me.txtboxtotal.Size = New System.Drawing.Size(203, 26)
        Me.txtboxtotal.TabIndex = 3
        Me.txtboxtotal.Text = "Total"
        '
        'txtboxpcost2
        '
        Me.txtboxpcost2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpcost2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpcost2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpcost2.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpcost2.Location = New System.Drawing.Point(81, 122)
        Me.txtboxpcost2.Name = "txtboxpcost2"
        Me.txtboxpcost2.Size = New System.Drawing.Size(126, 26)
        Me.txtboxpcost2.TabIndex = 2
        Me.txtboxpcost2.Text = "Product Cost"
        '
        'txtboxpname2
        '
        Me.txtboxpname2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxpname2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxpname2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpname2.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxpname2.Location = New System.Drawing.Point(60, 243)
        Me.txtboxpname2.MinimumSize = New System.Drawing.Size(168, 26)
        Me.txtboxpname2.Name = "txtboxpname2"
        Me.txtboxpname2.Size = New System.Drawing.Size(168, 26)
        Me.txtboxpname2.TabIndex = 1
        Me.txtboxpname2.Text = "Product Name"
        '
        'txtboxid2
        '
        Me.txtboxid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxid2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtboxid2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxid2.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtboxid2.Location = New System.Drawing.Point(18, 54)
        Me.txtboxid2.Name = "txtboxid2"
        Me.txtboxid2.Size = New System.Drawing.Size(126, 26)
        Me.txtboxid2.TabIndex = 0
        Me.txtboxid2.Text = "ID"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 494)
        Me.Controls.Add(Me.panelcarttext)
        Me.Controls.Add(Me.panelcartdata)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier"
        Me.panelcartdata.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcarttext.ResumeLayout(False)
        Me.panelcarttext.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelcartdata As Panel
    Friend WithEvents btncheckcart As FontAwesome.Sharp.IconButton
    Friend WithEvents btninventory As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents panelcarttext As Panel
    Friend WithEvents btnaddtocart As FontAwesome.Sharp.IconButton
    Friend WithEvents txtboxpdisplay2 As TextBox
    Friend WithEvents txtboxtotal As TextBox
    Friend WithEvents txtboxpcost2 As TextBox
    Friend WithEvents txtboxpname2 As TextBox
    Friend WithEvents txtboxid2 As TextBox
    Friend WithEvents txtboxquantity As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
