Imports FontAwesome.Sharp

Public Class Form1
    Private currentbtn As IconButton
    Private leftborderbtn As Panel
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
        panelbottom.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ActivateButton(sender, RGBColors.color2)
        panelbottom.Hide()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color3)
        panelbottom.Hide()
    End Sub

    Private Sub btnlogs_Click(sender As Object, e As EventArgs) Handles btnlogs.Click
        ActivateButton(sender, RGBColors.color4)
        panelbottom.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxunderline(txtboxid, Nothing, Nothing, Color.Gainsboro, 2, 1)
        txtboxunderline(txtboxpname, Nothing, Nothing, Color.Gainsboro, 2, 1)
        txtboxunderline(txtboxpcost, Nothing, Nothing, Color.Gainsboro, 2, 1)
        txtboxunderline(txtboxpinstock, Nothing, Nothing, Color.Gainsboro, 2, 1)
        txtboxunderline(txtboxpdisplay, Nothing, Nothing, Color.Gainsboro, 2, 1)
    End Sub

    Private Sub txtboxid_Enter(sender As Object, e As EventArgs) Handles txtboxid.Enter
        If txtboxid.Text = "ID" Then
            txtboxid.Text = ""
        End If
    End Sub

    Private Sub txtboxpname_Enter(sender As Object, e As EventArgs) Handles txtboxpname.Enter
        If txtboxpname.Text = "Product Name" Then
            txtboxpname.Text = ""
        End If
    End Sub

    Private Sub txtboxpcost_Enter(sender As Object, e As EventArgs) Handles txtboxpcost.Enter
        If txtboxpcost.Text = "Product Cost" Then
            txtboxpcost.Text = ""
        End If
    End Sub
    Private Sub txtboxpdisplay_Enter(sender As Object, e As EventArgs) Handles txtboxpdisplay.Enter
        If txtboxpdisplay.Text = "Products Displayed" Then
            txtboxpdisplay.Text = ""
        End If
    End Sub

    Private Sub txtboxpinstock_Enter(sender As Object, e As EventArgs) Handles txtboxpinstock.Enter
        If txtboxpinstock.Text = "Products In Stock" Then
            txtboxpinstock.Text = ""
        End If
    End Sub

    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncashier.Click
        Dim secondform As New Form2()
        secondform.Show()

    End Sub
End Class
