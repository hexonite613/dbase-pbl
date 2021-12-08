
Public Class PurchaseDoneForm
    Public TicketCode As String = ""
    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
    End Sub

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
    Private Sub PurchaseDoneForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim qrurl As String = "https://api.qrserver.com/v1/create-qr-code/?size=300x300&data="

        qrurl += Net.WebUtility.UrlEncode("http://dbase.kro.kr/ticket/?tid=" + TicketCode)

        QRPB.Load(qrurl)
        TIcketCodeLabel.Text = TicketCode
    End Sub

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        MainForm.ForceClose = True

        MovieSelectForm.Close()
        PhoneNumForm.Close()
        PurchaseForm.Close()
        SeatInfoForm.Close()
        SeatSelectionForm.Close()

        MainForm.ForceClose = False

        Close()
    End Sub
End Class