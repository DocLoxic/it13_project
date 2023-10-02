Imports System.Runtime.CompilerServices

Public Class Form2
    Private Sub txtboxquantity_Enter(sender As Object, e As EventArgs) Handles txtboxquantity.Enter

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        Form1.Visible = True

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Visible = False

    End Sub
End Class