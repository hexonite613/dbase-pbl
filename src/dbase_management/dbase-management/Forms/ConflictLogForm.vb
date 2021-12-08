Public Class ConflictLogForm
    Private Sub sche_add_bt_Click(sender As Object, e As EventArgs) Handles sche_add_bt.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub
End Class