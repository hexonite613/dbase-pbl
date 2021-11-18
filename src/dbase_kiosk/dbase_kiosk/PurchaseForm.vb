Public Class PurchaseForm

    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        LoadPrice()
    End Sub

    Sub LoadPrice()

        Dim norm = SeatInfoForm.seat_normal
        Dim youth = SeatInfoForm.seat_youth
        Dim disab = SeatInfoForm.seat_disab
        Dim elder = SeatInfoForm.seat_elder

        Dim norm_price = 13000
        Dim youth_price = 10000
        Dim disab_price = 5000
        Dim elder_price = 6000

        Dim sumprice = norm * norm_price + youth * youth_price + disab * disab_price + elder * elder_price

        Dim printstr As String

        printstr = norm_price.ToString + "₩ × " + norm.ToString + vbCr _
                 + youth_price.ToString + "₩ × " + youth.ToString + vbCr _
                 + disab_price.ToString + "₩ × " + disab.ToString + vbCr _
                 + elder_price.ToString + "₩ × " + elder.ToString

        detailPriceLabel.Text = printstr
        sumPriceLabel.Text = sumprice.ToString + " ₩"

    End Sub

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class