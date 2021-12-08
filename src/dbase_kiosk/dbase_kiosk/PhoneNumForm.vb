Public Class PhoneNumForm
    Public Phonenum As String = ""
    Private Sub numbt_Click(sender As Object, e As EventArgs) Handles bt1.Click, bt2.Click,
        bt3.Click, bt4.Click, bt5.Click, bt6.Click, bt7.Click, bt8.Click, bt9.Click, bt0.Click
        Dim num = sender.Name.ToString.Replace("bt", "")
        PhoneNumTB.Text += num

    End Sub
    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
    End Sub

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        If Not MainForm.ForceClose Then FadeOut(Me)
    End Sub


    Private Sub backsp_bt_Click(sender As Object, e As EventArgs) Handles backsp_bt.Click
        PhoneNumTB.Text = Mid(PhoneNumTB.Text, 1, PhoneNumTB.Text.Length - 1)
    End Sub

    Private Sub clear_bt_Click(sender As Object, e As EventArgs) Handles clear_bt.Click
        PhoneNumTB.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub PhoneNumTB_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumTB.TextChanged
        If PhoneNumTB.Text.Length > 10 Then
            If IsNumeric(PhoneNumTB.Text) Then
                SubmitButton.Visible = True
                Exit Sub
            End If
        End If

        SubmitButton.Visible = False
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        PurchaseForm.Close()
        PurchaseForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        Phonenum = PhoneNumTB.Text
        PurchaseForm.Show()
    End Sub
End Class