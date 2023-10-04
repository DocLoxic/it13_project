Imports FontAwesome.Sharp

Public Class Form1
    Private currentbtn As IconButton
    Private leftborderbtn As Panel
    Dim currpage As Integer = 1
    Dim operation As Integer
    Dim in_transaction As Boolean = False
    Dim where As String = "home"
    Dim trans_id As Integer
    Dim inOrder As Boolean = False
    Public Sub New()
        InitializeComponent()
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 60)
        panelmenu.Controls.Add(leftborderbtn)
    End Sub
    Private Sub ActivateButton(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            DisableButton()
            currentbtn = CType(senderbtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftborderbtn.BackColor = customcolor
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()

            iconcurrentform.IconChar = currentbtn.IconChar
            iconcurrentform.IconColor = customcolor


        End If
    End Sub
    Private Sub DisableButton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(30, 31, 68)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ActivateButton(sender, RGBColors.color1)
        clear()
        lbl_lack_payment.Visible = False
        lbl_quantity_over.Visible = False
        inOrder = False
        btnsubmit.Show()
        lblniID.Visible = True
        lblniDisp.Visible = True
        lblnuID.Visible = False
        lblRO1.Visible = False
        lblRO2.Visible = False
        lblRO3.Visible = False
        lblRO4.Visible = False
        lblRO5.Visible = False
        lblRO6.Visible = False
        lblRO7.Visible = False
        btn_add_to_cart.Hide()
        btn_show_cart.Hide()
        txt_quantity.Hide()
        btn_pay.Hide()
        txt_order_total.Hide()
        lbl_order_total.Hide()
        lbl_quantity.Hide()
        operation = 1
        txtbox_readonly_false(operation)
        Inventory_View(1)
        panelbottom.Hide()
        currpage = 1
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ActivateButton(sender, RGBColors.color2)
        clear()
        lbl_lack_payment.Visible = False
        lbl_quantity_over.Visible = False
        inOrder = False
        btnsubmit.Show()
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = True
        lblRO1.Visible = False
        lblRO2.Visible = False
        lblRO3.Visible = False
        lblRO4.Visible = False
        lblRO5.Visible = False
        lblRO6.Visible = False
        lblRO7.Visible = False
        btn_add_to_cart.Hide()
        btn_show_cart.Hide()
        txt_quantity.Hide()
        btn_pay.Hide()
        txt_order_total.Hide()
        lbl_order_total.Hide()
        lbl_quantity.Hide()
        operation = 2
        txtbox_readonly_false(operation)
        Inventory_View(1)
        panelbottom.Hide()
        currpage = 1
    End Sub

    Private Sub btnlogs_Click(sender As Object, e As EventArgs) Handles btnlogs.Click
        ActivateButton(sender, RGBColors.color4)
        clear()
        lbl_lack_payment.Visible = False
        lbl_quantity_over.Visible = False
        inOrder = False
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        lblRO1.Visible = True
        lblRO2.Visible = True
        lblRO3.Visible = True
        lblRO4.Visible = True
        lblRO5.Visible = False
        lblRO6.Visible = False
        lblRO7.Visible = False
        btnsubmit.Hide()
        btn_add_to_cart.Hide()
        btn_show_cart.Hide()
        txt_quantity.Hide()
        btn_pay.Hide()
        txt_order_total.Hide()
        lbl_order_total.Hide()
        lbl_quantity.Hide()
        Logs_View()
        panelbottom.Hide()
        currpage = 3
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbox_readonly_true()
        clear()
        btnsubmit.Hide()
        btn_new_trans.Hide()
        Inventory_View(1)
    End Sub

    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncashier.Click
        clear()
        lbl_lack_payment.Visible = False
        lbl_quantity_over.Visible = False
        btnsales.Hide()
        inOrder = False
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        lblRO1.Visible = True
        lblRO2.Visible = True
        lblRO3.Visible = True
        lblRO4.Visible = True
        lblRO5.Visible = True
        lblRO6.Visible = False
        lblRO7.Visible = True
        operation = 3
        currpage = 1
        lbl_order_total.Show()
        txt_order_total.Show()
        txt_quantity.Show()
        lbl_quantity.Show()
        If (Not in_transaction) Then
            txt_quantity.Hide()
            btnsubmit.Hide()
            btn_add_to_cart.Hide()
            btn_pay.Hide()
            btninventory.Hide()
            btn_show_cart.Hide()
            btn_new_trans.Show()
        Else
            btn_show_cart.Show()
            btn_pay.Show()
            btn_add_to_cart.Show()
            txt_quantity.ReadOnly = False
        End If
        txtbox_readonly_false(operation)
        Inventory_View(4)
        panelbottom.Show()
        where = "cashier"
    End Sub

    Private Sub lbltitle_Click(sender As Object, e As EventArgs) Handles lbltitle.Click
        Inventory_View(1)
        clear()
        lbl_lack_payment.Visible = False
        lbl_quantity_over.Visible = False
        inOrder = False
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        lblRO1.Visible = True
        lblRO2.Visible = True
        lblRO3.Visible = True
        lblRO4.Visible = True
        lblRO5.Visible = True
        lblRO6.Visible = False
        lblRO7.Visible = False
        panelbottom.Show()
        btn_pay.Hide()
        btn_new_trans.Hide()
        btn_show_cart.Hide()
        btninventory.Show()
        btn_add_to_cart.Hide()
        btnsales.Show()
        txtbox_readonly_true()
        btnsubmit.Hide()
        where = "home"
    End Sub

    Private Sub btnsales_Click(sender As Object, e As EventArgs) Handles btnsales.Click
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        lblRO1.Visible = True
        lblRO2.Visible = True
        lblRO3.Visible = True
        lblRO4.Visible = True
        lblRO5.Visible = False
        lblRO6.Visible = False
        lblRO7.Visible = False
        Sales_View()
        clear()
        currpage = 2
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs) Handles btninventory.Click
        Inventory_View(1)
        lbl_quantity_over.Visible = False
        inOrder = False
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        lblRO1.Visible = True
        lblRO2.Visible = True
        lblRO3.Visible = True
        lblRO4.Visible = True
        lblRO5.Visible = True
        lblRO6.Visible = False
        lblRO7.Visible = False
        If (in_transaction) Then
            btn_pay.Hide()
            If (where = "cashier") Then
                btn_add_to_cart.Show()
                lbl_payment.Hide()
                txt_payment.Hide()
                lbl_quantity.Show()
                txt_quantity.Show()
                txt_quantity.ReadOnly = False
                lbl_order_total.Show()
                txt_order_total.Show()
                txt_order_total.Clear()
                lblRO7.Visible = True
            End If
        End If
        clear()
        currpage = 1
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If txtboxpname.Text = "" Or txtboxpcost.Text = "" Or txtboxpinstock.Text = "" Then
            MsgBox("Please input values into the correct fields!", MsgBoxStyle.Critical, "ERROR")

        Else
            add_update_query(operation, txtboxid.Text, txtboxpname.Text, txtboxpcost.Text, txtboxpinstock.Text, txtboxpdisplay.Text)
            clear()
        End If
    End Sub

    Private Sub dgv_all_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_all.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_all.Rows(e.RowIndex)
            Select Case currpage
                Case 1
                    txtboxid.Text = row.Cells("product_id").Value.ToString
                    txtboxpname.Text = row.Cells("product_name").Value.ToString
                    txtboxpcost.Text = row.Cells("product_price").Value.ToString
                    txtboxpinstock.Text = row.Cells("in_stock").Value.ToString
                    txtboxpdisplay.Text = row.Cells("displayed").Value.ToString
                Case 2
                    id_sales.Text = row.Cells("sales_id").Value.ToString
                    total_sales.Text = row.Cells("sales_total").Value.ToString
                    sales_date.Text = row.Cells("sales_date").Value.ToString
                    trans_id_sales.Text = row.Cells("trans_id").Value.ToString
                Case 3
                    log_id.Text = row.Cells("log_id").Value.ToString
                    log_type.Text = row.Cells("log_type").Value.ToString
                    log_date.Text = row.Cells("log_date").Value.ToString
                    product_id_logs.Text = row.Cells("product_id").Value.ToString
                Case Else

            End Select
        End If
    End Sub

    Private Sub btn_new_trans_Click(sender As Object, e As EventArgs) Handles btn_new_trans.Click
        lblniID.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        btninventory.Show()
        btnsubmit.Hide()
        btn_new_trans.Hide()
        btn_add_to_cart.Show()
        btn_pay.Hide()
        btn_show_cart.Show()
        txt_quantity.Show()
        txt_order_total.Show()
        lbl_order_total.Show()
        lbl_quantity.Show()
        trans_id = add_trans_query()
        txt_quantity.ReadOnly = False
        in_transaction = True
    End Sub

    Private Sub btn_show_cart_Click(sender As Object, e As EventArgs) Handles btn_show_cart.Click
        lblniID.Visible = False
        lbl_quantity_over.Visible = False
        lblniDisp.Visible = False
        lblnuID.Visible = False
        Orders_View(trans_id)
        txt_order_total.Text = order_total_query(trans_id)
        currpage = 4
        inOrder = True
        btn_pay.Show()
        lbl_payment.Show()
        txt_payment.Show()
        lbl_quantity.Hide()
        txt_quantity.Hide()
        lbl_order_total.Show()
        txt_order_total.Show()
        btn_add_to_cart.Hide()
        txt_payment.ReadOnly = False
        clear()
    End Sub

    Private Sub btn_add_to_cart_Click(sender As Object, e As EventArgs) Handles btn_add_to_cart.Click
        Dim check As Boolean = add_order_query(txtboxid.Text, trans_id, txtboxpcost.Text, txtboxpinstock.Text, txtboxpdisplay.Text, txt_quantity.Text)
        If (Not check) Then
            lbl_quantity_over.Visible = True
        Else
            lbl_quantity_over.Visible = False
        End If
        clear()
        txt_order_total.Text = order_total_query(trans_id)
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        Dim check As Boolean = commit_order(trans_id, txt_order_total.Text, txt_payment.Text)
        clear()
        If (check) Then
            lbl_lack_payment.Visible = False
            txt_order_total.Clear()
            trans_id = 0
            btninventory.Hide()
            btn_show_cart.Hide()
            btn_new_trans.Show()
            btn_pay.Hide()
            lbl_payment.Hide()
            txt_payment.Hide()
            lbl_quantity.Show()
            txt_quantity.Show()
            in_transaction = False
            inOrder = False
        Else
            lbl_lack_payment.Visible = True
        End If
    End Sub

    Private Sub dgv_all_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_all.CellDoubleClick
        If (inOrder) Then
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgv_all.Rows(e.RowIndex)
                Dim t_id As Integer
                Dim p_id As Integer
                Dim quan As Integer
                t_id = row.Cells("trans_id").Value
                p_id = row.Cells("product_id").Value
                quan = row.Cells("order_quantity").Value
                delete_order(t_id, p_id, quan)
                order_total_query(trans_id)
                txt_order_total.Text = order_total_query(trans_id)
            End If
        End If
    End Sub

    Private Sub txtboxpname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxpname.KeyPress
        If AscW(e.KeyChar) > 64 And AscW(e.KeyChar) < 91 Or AscW(e.KeyChar) > 96 And AscW(e.KeyChar) < 123 Or AscW(e.KeyChar) = 8 Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtboxpcost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxpcost.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtboxpinstock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxpinstock.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtboxpdisplay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxpdisplay.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_quantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_quantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_payment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_payment.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
