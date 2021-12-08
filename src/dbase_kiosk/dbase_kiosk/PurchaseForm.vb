Imports MySql.Data.MySqlClient

Public Class PurchaseForm
    Public paymethod As String = ""
    Public paycode As String = ""

    Dim norm = SeatInfoForm.seat_normal
    Dim youth = SeatInfoForm.seat_youth
    Dim disab = SeatInfoForm.seat_disab
    Dim elder = SeatInfoForm.seat_elder

    Dim norm_price = 13000
    Dim youth_price = 10000
    Dim disab_price = 5000
    Dim elder_price = 6000

    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        LoadPrice()
    End Sub

    Public Function GetPurCode(schenum As Integer) As String

        Dim result = schenum.ToString + "-"

        Dim Generator As Random = New Random()

        For i = 0 To 3
            result += (Generator.Next(0, 9)).ToString
        Next

        result += "-"

        For i = 0 To 3
            result += (Generator.Next(0, 9)).ToString
        Next

        Return result
    End Function

    Sub LoadPrice()

        norm = SeatInfoForm.seat_normal
        youth = SeatInfoForm.seat_youth
        disab = SeatInfoForm.seat_disab
        elder = SeatInfoForm.seat_elder

        Dim sumprice = norm * norm_price + youth * youth_price + disab * disab_price + elder * elder_price

        Dim printstr As String

        printstr = norm_price.ToString + "₩ × " + norm.ToString + vbCr _
                 + youth_price.ToString + "₩ × " + youth.ToString + vbCr _
                 + disab_price.ToString + "₩ × " + disab.ToString + vbCr _
                 + elder_price.ToString + "₩ × " + elder.ToString

        detailPriceLabel.Text = printstr
        sumPriceLabel.Text = sumprice.ToString + " ₩"

    End Sub

    Private Function QueryMaker()
        Dim sqlq As String = "INSERT INTO `booking` (`book_num`, `id`, `sche_id`, `seat_id`, `time`, `pay_price`, `book_type`, `pay_method`, `cus_phonenum`, `book_id`) VALUES "

        Dim sidIndex = 0
        Dim paycode = GetPurCode(SeatSelectionForm.sche_id)

        For i = 1 To norm
            sqlq += "(NULL, NULL, " + SeatSelectionForm.sche_id.ToString _
                + ", '" + SeatSelectionForm.selectedSeats(sidIndex) _
                + "', NULL, '" + norm_price.ToString _
                + "', 'normal', '" + paymethod + "', '" + PhoneNumForm.Phonenum + "', '" + paycode + "'), "
            sidIndex += 1
        Next

        For i = 1 To youth
            sqlq += "(NULL, NULL, " + SeatSelectionForm.sche_id.ToString _
                + ", '" + SeatSelectionForm.selectedSeats(sidIndex) _
                + "', NULL, '" + youth_price.ToString _
                + "', 'youth', '" + paymethod + "', '" + PhoneNumForm.Phonenum + "', '" + paycode + "'), "
            sidIndex += 1
        Next

        For i = 1 To disab
            sqlq += "(NULL, NULL, " + SeatSelectionForm.sche_id.ToString _
                + ", '" + SeatSelectionForm.selectedSeats(sidIndex) _
                + "', NULL, '" + disab_price.ToString _
                + "', 'disab', '" + paymethod + "', '" + PhoneNumForm.Phonenum + "', '" + paycode + "'), "
            sidIndex += 1
        Next

        For i = 1 To elder
            sqlq += "(NULL, NULL, " + SeatSelectionForm.sche_id.ToString _
                + ", '" + SeatSelectionForm.selectedSeats(sidIndex) _
                + "', NULL, '" + elder_price.ToString _
                + "', 'elder', '" + paymethod + "', '" + PhoneNumForm.Phonenum + "', '" + paycode + "'), "
            sidIndex += 1
        Next

        sqlq += "{END}"
        sqlq = sqlq.Replace(", {END}", "")


        Dim cmd As New MySqlCommand(sqlq, BP_CON(0))
        cmd.ExecuteNonQuery()

        Return paycode

    End Function

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        If Not MainForm.ForceClose Then FadeOut(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        PurchaseDoneForm.Close()
        PurchaseDoneForm.TicketCode = QueryMaker()
        PurchaseDoneForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        PurchaseDoneForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles kakaopay_pb.Click, kakaopay_lb.Click
        paymethod = "kakaopay"
        paycheck()
    End Sub

    Private Sub payco_pb_Click(sender As Object, e As EventArgs) Handles payco_pb.Click
        paymethod = "payco"
        paycheck()
    End Sub

    Private Sub samsung_pb_Click(sender As Object, e As EventArgs) Handles samsung_pb.Click
        paymethod = "samsung"
        paycheck()
    End Sub

    Private Sub paycheck()
        kakaopay_lb.BackColor = Color.Transparent
        payco_lb.BackColor = Color.Transparent
        samsung_lb.BackColor = Color.Transparent

        Select Case paymethod
            Case "kakaopay"
                kakaopay_lb.BackColor = Color.FromArgb(92, 16, 234)
            Case "payco"
                payco_lb.BackColor = Color.FromArgb(92, 16, 234)
            Case "samsung"
                samsung_lb.BackColor = Color.FromArgb(92, 16, 234)
            Case Else
                PurchaseButton.Visible = False
                Exit Sub
        End Select

        PurchaseButton.Visible = True
    End Sub

End Class