Public Class SeatInfoForm
    Public availableSeat As Integer = 5
    Dim currentseat As Integer = 0

    Public seat_normal As Integer = 0
    Public seat_youth As Integer = 0
    Public seat_disab As Integer = 0
    Public seat_elder As Integer = 0


    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0

        SubLabel1.Text = "관람 인원수" + vbCrLf + "(" + availableSeat.ToString + "명 가능)"
        BtnCheck()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SeatSelectButton.Click
        SeatSelectionForm.Close()
        SeatSelectionForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        SeatSelectionForm.seatcount = currentseat
        SeatSelectionForm.Show()
    End Sub

    Private Sub mpbutton_Click(sender As Object, e As EventArgs) Handles minusBt1.Click, minusBt2.Click,
        minusBt3.Click, minusBt4.Click, plusBt1.Click, plusBt2.Click, plusBt3.Click, plusBt4.Click

        Dim bt As PictureBox = sender

        If bt.Name.Contains("minus") Then
            If currentseat <= 0 Then
                Exit Sub
            End If

            Select Case bt.Name
                Case "minusBt1"
                    If seat_normal > 0 Then seat_normal -= 1
                Case "minusBt2"
                    If seat_youth > 0 Then seat_youth -= 1
                Case "minusBt3"
                    If seat_disab > 0 Then seat_disab -= 1
                Case "minusBt4"
                    If seat_elder > 0 Then seat_elder -= 1
            End Select
        Else
            If currentseat >= availableSeat Then
                Exit Sub
            End If

            Select Case bt.Name
                Case "plusBt1"
                    seat_normal += 1
                Case "plusBt2"
                    seat_youth += 1
                Case "plusBt3"
                    seat_disab += 1
                Case "plusBt4"
                    seat_elder += 1
            End Select

        End If

        normalSeatLabel.Text = seat_normal.ToString + "명"
        youthSeatLabel.Text = seat_youth.ToString + "명"
        disabSeatLabel.Text = seat_disab.ToString + "명"
        elderSeatLabel.Text = seat_elder.ToString + "명"

        currentseat = seat_normal + seat_youth + seat_disab + seat_elder
        totalSeatLabel.Text = "총 " + currentseat.ToString + "명"

        BtnCheck()
    End Sub

    Sub BtnCheck()
        If seat_normal <= 0 Then
            minusBt1.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt1.BackColor = Color.Gray
        End If

        If seat_youth <= 0 Then
            minusBt2.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt2.BackColor = Color.Gray
        End If

        If seat_disab <= 0 Then
            minusBt3.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt3.BackColor = Color.Gray
        End If

        If seat_elder <= 0 Then
            minusBt4.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt4.BackColor = Color.Gray
        End If

        If currentseat >= availableSeat Then
            plusBt1.BackColor = Color.FromArgb(64, 64, 64)
            plusBt2.BackColor = Color.FromArgb(64, 64, 64)
            plusBt3.BackColor = Color.FromArgb(64, 64, 64)
            plusBt4.BackColor = Color.FromArgb(64, 64, 64)
        Else
            plusBt1.BackColor = Color.Gray
            plusBt2.BackColor = Color.Gray
            plusBt3.BackColor = Color.Gray
            plusBt4.BackColor = Color.Gray
        End If

        SeatSelectButton.Visible = currentseat > 0
    End Sub
End Class