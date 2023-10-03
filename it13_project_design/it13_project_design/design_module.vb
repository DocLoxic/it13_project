Module design_module
    Public Sub txtbox_readonly_true()
        Form1.txtboxid.ReadOnly = True
        Form1.txtboxpcost.ReadOnly = True
        Form1.txtboxpdisplay.ReadOnly = True
        Form1.txtboxpinstock.ReadOnly = True
        Form1.txtboxpname.ReadOnly = True
    End Sub
    Public Sub txtbox_readonly_false(ByVal operation As Integer)
        If (operation = 1) Then
            Form1.txtboxpdisplay.ReadOnly = True
            Form1.txtboxpcost.ReadOnly = False
            Form1.txtboxpinstock.ReadOnly = False
            Form1.txtboxpname.ReadOnly = False
        ElseIf (operation = 3) Then
            Form1.txtboxpdisplay.ReadOnly = True
            Form1.txtboxpcost.ReadOnly = True
            Form1.txtboxpinstock.ReadOnly = True
            Form1.txtboxpname.ReadOnly = True
        Else
            Form1.txtboxpdisplay.ReadOnly = False
            Form1.txtboxpcost.ReadOnly = False
            Form1.txtboxpinstock.ReadOnly = False
            Form1.txtboxpname.ReadOnly = False
        End If
    End Sub
    Public Sub clear()
        Form1.txtboxid.Clear()
        Form1.txtboxpcost.Clear()
        Form1.txtboxpdisplay.Clear()
        Form1.txtboxpinstock.Clear()
        Form1.txtboxpname.Clear()
        Form1.sales_date.Clear()
        Form1.id_sales.Clear()
        Form1.total_sales.Clear()
        Form1.trans_id_sales.Clear()
        Form1.product_id_logs.Clear()
        Form1.log_date.Clear()
        Form1.log_id.Clear()
        Form1.log_type.Clear()
        Form1.txt_quantity.Clear()
        Form1.txt_payment.Clear()
    End Sub
    Public Sub show_elements(ByVal show As Integer)
        Select Case show
            Case 1
                Form1.lbl_product_name.Visible = True
                Form1.lbl_product_cost.Visible = True
                Form1.lbl_in_stock.Visible = True
                Form1.lbl_displayed.Visible = True
                Form1.lbl_log_date.Visible = False
                Form1.lbl_log_type.Visible = False
                Form1.lbl_product_id.Visible = False
                Form1.lbl_sales_date.Visible = False
                Form1.lbl_total_sales.Visible = False
                Form1.lbl_trans_id.Visible = False
                Form1.txtboxid.BringToFront()
                Form1.txtboxpname.BringToFront()
                Form1.txtboxpinstock.BringToFront()
                Form1.txtboxpcost.BringToFront()
                Form1.txtboxpdisplay.Visible = True
                Form1.lbl_quantity.Visible = False
                Form1.txt_quantity.Visible = False
                Form1.lbl_order_total.Visible = False
                Form1.txt_order_total.Visible = False
                Form1.lbl_payment.Visible = False
                Form1.txt_payment.Visible = False
            Case 2
                Form1.lbl_product_name.Visible = False
                Form1.lbl_product_cost.Visible = False
                Form1.lbl_in_stock.Visible = False
                Form1.lbl_displayed.Visible = False
                Form1.lbl_log_date.Visible = False
                Form1.lbl_log_type.Visible = False
                Form1.lbl_product_id.Visible = False
                Form1.lbl_sales_date.Visible = True
                Form1.lbl_total_sales.Visible = True
                Form1.lbl_trans_id.Visible = True
                Form1.total_sales.BringToFront()
                Form1.sales_date.BringToFront()
                Form1.trans_id_sales.BringToFront()
                Form1.id_sales.BringToFront()
                Form1.txtboxpdisplay.Visible = False
                Form1.lbl_quantity.Visible = False
                Form1.txt_quantity.Visible = False
                Form1.lbl_order_total.Visible = False
                Form1.txt_order_total.Visible = False
                Form1.lbl_payment.Visible = False
                Form1.txt_payment.Visible = False
            Case 3
                Form1.lbl_product_name.Visible = False
                Form1.lbl_product_cost.Visible = False
                Form1.lbl_in_stock.Visible = False
                Form1.lbl_displayed.Visible = False
                Form1.lbl_sales_date.Visible = False
                Form1.lbl_total_sales.Visible = False
                Form1.lbl_trans_id.Visible = False
                Form1.lbl_log_date.Visible = True
                Form1.lbl_log_type.Visible = True
                Form1.lbl_product_id.Visible = True
                Form1.log_id.BringToFront()
                Form1.log_date.BringToFront()
                Form1.log_type.BringToFront()
                Form1.product_id_logs.BringToFront()
                Form1.txtboxpdisplay.Visible = False
                Form1.lbl_quantity.Visible = False
                Form1.txt_quantity.Visible = False
                Form1.lbl_order_total.Visible = False
                Form1.txt_order_total.Visible = False
                Form1.lbl_payment.Visible = False
                Form1.txt_payment.Visible = False
            Case 4
                Form1.lbl_product_name.Visible = True
                Form1.lbl_product_cost.Visible = True
                Form1.lbl_in_stock.Visible = True
                Form1.lbl_displayed.Visible = True
                Form1.lbl_log_date.Visible = False
                Form1.lbl_log_type.Visible = False
                Form1.lbl_product_id.Visible = False
                Form1.lbl_sales_date.Visible = False
                Form1.lbl_total_sales.Visible = False
                Form1.lbl_trans_id.Visible = False
                Form1.txtboxid.BringToFront()
                Form1.txtboxpname.BringToFront()
                Form1.txtboxpinstock.BringToFront()
                Form1.txtboxpcost.BringToFront()
                Form1.txtboxpdisplay.Visible = True
                Form1.lbl_quantity.Visible = True
                Form1.txt_quantity.Visible = True
                Form1.lbl_order_total.Visible = True
                Form1.txt_order_total.Visible = True
                Form1.lbl_payment.Visible = False
                Form1.txt_payment.Visible = False
        End Select
    End Sub
End Module
