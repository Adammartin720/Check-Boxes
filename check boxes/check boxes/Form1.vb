Public Class Form1

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Const lx As Integer = 100
        Const bn As Integer = 500
        Const sd As Integer = 200
        Const hd As Integer = 80
        Const hm As Integer = 300
        Const am As Integer = 150
        Dim sum As Integer

        If chklx.Checked = True Then
            sum += lx
        End If
        If chkbn.Checked = True Then
            sum += bn
        End If
        If chksd.Checked = True Then
            sum += sd
        End If
        If chkhd.Checked = True Then
            sum += hd
        End If
        If chkhm.Checked = True Then
            sum += hm
        End If
        If chkam.Checked = True Then
            sum += am
        End If

        lbltotal.Text = sum.ToString("c")

    End Sub
End Class
