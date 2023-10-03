Module Module1
    Friend Sub txtboxunderline(ByVal ctr As TextBox, ByVal bCol As Color, ByVal fCol As Color, ByVal borderCol As Color, ByVal borderSize As Integer, ByVal borderMargin As Integer)
        If bCol = Nothing Then
            bCol = ctr.Parent.BackColor
        End If
        If fCol = Nothing Then
            fCol = ctr.Parent.ForeColor
        End If
        If borderCol = Nothing Then
            borderCol = ctr.Parent.ForeColor
        End If
        ctr.BorderStyle = BorderStyle.None
        ctr.BackColor = bCol
        ctr.BackColor = fCol
        Dim underlinePanel As New Panel
        underlinePanel.BackColor = borderCol
        underlinePanel.Height = borderSize
        underlinePanel.Width = ctr.Width
        underlinePanel.Location = New Point(ctr.Location.X, (ctr.Location.Y + ctr.Height + borderMargin))
        underlinePanel.BringToFront()
        ctr.Parent.Controls.Add(underlinePanel)
    End Sub
End Module
