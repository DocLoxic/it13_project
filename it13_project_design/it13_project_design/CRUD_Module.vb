Imports System.Data.Common
Imports System.Data.SQLite

Module CRUD_Module
    Dim conn As New SQLiteConnection
    Dim cmd As SQLiteCommand
    Private SQLreader As DbDataReader

    Public Sub Inventory_View(ByVal num As Integer)
        show_elements(num)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "select * from inventory;"
        Dim dataAdapter As New SQLiteDataAdapter(cmd)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Sub Orders_View(ByVal trans_id As Integer)
        show_elements(1)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "select * from orders where trans_id = '" & trans_id & "';"
        Dim dataAdapter As New SQLiteDataAdapter(cmd)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Function order_total_query(ByVal trans_id As Integer)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        Dim orderTotal As SQLiteCommand
        orderTotal = conn.CreateCommand
        orderTotal.CommandText = "select sum(total_cost) from orders where trans_id = '" & trans_id & "';"
        SQLreader = orderTotal.ExecuteReader()
        Dim total As Double
        While (SQLreader.Read())
            Try
                total = SQLreader.GetDouble(0)
            Catch ex As Exception
                total = 0
            End Try
        End While
        conn.Close()
        Return total
    End Function

    Public Sub Sales_View()
        show_elements(2)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "select * from sales;"
        Dim dataAdapter As New SQLiteDataAdapter(cmd)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Sub Logs_View()
        show_elements(3)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "select log_id, log_type, log_date, product_id from logs;"
        Dim dataAdapter As New SQLiteDataAdapter(cmd)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Sub add_update_query(ByVal operation As Integer, product_id As String, product_name As String, product_price As String, in_stock As String, displayed As String)
        If (product_id = "") Then
            product_id = 0
        Else
            Dim id = Int(product_id)
        End If
        If (displayed = "") Then
            product_id = 0
        Else
            Dim display = Int(displayed)
        End If
        Dim price = Double.Parse(product_price)
        Dim stock = Int(in_stock)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        Dim refresh As SQLiteCommand
        refresh = conn.CreateCommand
        refresh.CommandText = "select * from inventory;"
        Select Case operation
            Case 1
                cmd.CommandText = "insert into inventory(product_id, product_name, product_price, in_stock, displayed) values(NULL, '" & product_name & "', '" & product_price & "', '" & in_stock & "', 0);"
            Case 2
                cmd.CommandText = "update inventory set product_name = '" & product_name & "', product_price = '" & product_price & "', in_stock = '" & in_stock - displayed & "', displayed = '" & displayed & "' where product_id = '" & product_id & "';"
        End Select
        cmd.ExecuteNonQuery()
        Dim dataAdapter As New SQLiteDataAdapter(refresh)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Sub add_order_query(ByVal product_id As String, trans_id As Integer, product_price As String, in_stock As String, displayed As String, quantity As String)
        Dim p_id = Int(product_id)
        Dim t_id = Int(trans_id)
        Dim price = Double.Parse(product_price)
        Dim stock = Int(in_stock)
        Dim disp = Int(displayed)
        Dim quan = Int(quantity)
        Dim newdisp As Integer
        Dim checkstock As Integer
        Dim newstock As Integer
        Dim updateInv As SQLiteCommand
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        If (disp > quan) Then
            newdisp = displayed - quan
            updateInv = conn.CreateCommand
            cmd.CommandText = "insert into orders(product_id, trans_id, total_cost, order_quantity) values('" & p_id & "', '" & t_id & "', '" & price * quan & "', '" & quan & "');"
            cmd.ExecuteNonQuery()
            updateInv.CommandText = "update inventory set displayed = '" & newdisp & "' where product_id = '" & p_id & "';"
            updateInv.ExecuteNonQuery()
        ElseIf (disp < quantity) Then
            checkstock = Math.Abs(disp - quan)
            If (checkstock < stock) Then
                newstock = stock - checkstock
                updateInv = conn.CreateCommand
                cmd.CommandText = "insert into orders(product_id, trans_id, total_cost, order_quantity) values('" & p_id & "', '" & t_id & "', '" & price * quan & "', '" & quan & "');"
                cmd.ExecuteNonQuery()
                updateInv.CommandText = "update inventory set in_stock = '" & newstock & "', displayed = '" & newdisp & "' where product_id = '" & p_id & "';"
                updateInv.ExecuteNonQuery()
            End If
        End If
        Dim refresh As SQLiteCommand
        refresh = conn.CreateCommand
        refresh.CommandText = "select * from inventory;"
        Dim dataAdapter As New SQLiteDataAdapter(refresh)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Sub commit_order(ByVal trans_id As Integer, order_total As String, payment As String)
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        Dim t_id = Int(trans_id)
        Dim pay = Double.Parse(payment)
        Dim price = order_total
        Dim change As Double = (pay - price)
        Dim updateTrans As SQLiteCommand
        updateTrans = conn.CreateCommand
        updateTrans.CommandText = "update transactions set trans_amount = '" & pay & "', trans_change = '" & change & "' where trans_id = '" & t_id & "';"
        updateTrans.ExecuteNonQuery()
        Dim refresh As SQLiteCommand
        refresh = conn.CreateCommand
        refresh.CommandText = "select * from inventory;"
        Dim dataAdapter As New SQLiteDataAdapter(refresh)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
    End Sub
    Public Function add_trans_query()
        conn.ConnectionString = "Data Source=C:\projects\vs_projects\it13_project\it13_project_design\it13_project_design\Resources\it13_db.db; Integrated Security=true"
        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandText = "insert into transactions(trans_id, trans_amount, trans_date, trans_change) values(NULL, 0, '" & Date.Now & "', 0);"
        cmd.ExecuteNonQuery()
        Dim transCheck As SQLiteCommand
        transCheck = conn.CreateCommand
        transCheck.CommandText = "select count(trans_id) from transactions;"
        SQLreader = transCheck.ExecuteReader()
        Dim currTrans As Integer
        While (SQLreader.Read())
            currTrans = SQLreader.GetInt64(0)
        End While
        Dim refresh As SQLiteCommand
        refresh = conn.CreateCommand
        refresh.CommandText = "select * from inventory;"
        Dim dataAdapter As New SQLiteDataAdapter(refresh)
        Dim dt As New DataTable
        dataAdapter.Fill(dt)
        Form1.dgv_all.DataSource = dt
        conn.Close()
        Return currTrans
    End Function
End Module
