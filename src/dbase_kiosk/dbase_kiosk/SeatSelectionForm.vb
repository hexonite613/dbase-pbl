Public Class SeatSelectionForm
    Dim existingSeats As New List(Of String)
    Dim availableSeats As New List(Of String)
    Dim selectedSeats As New List(Of String)

    Public seatcount = 3
    Dim currentSeatCount = 0

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

    Sub SetDemoSeats()
        Dim str1 = "A1;A2;A3;A4;A5;A6;A7;A8;A9;A10;A11;A12;A13;A14;A15;"
        str1 += "B1;B2;B3;B4;B5;B6;B7;B8;B9;B10;B11;B12;B13;B14;B15;"
        str1 += "C1;C2;C3;C4;C5;C6;C7;C8;C9;C10;C11;C12;C13;C14;C15;"
        str1 += "D1;D2;D3;D4;D5;D6;D7;D8;D9;D10;D11;D12;D13;D14;D15;"
        str1 += "E1;E2;E3;E4;E6;E7;E8;E9;E10;E12;E13;E14;E15"

        existingSeats = str1.Split(";").ToList

        str1 = "A6;A7;A8;A9;A10;A11;A12;A13;"
        str1 += "B4;B5;B6;B7;B10;B11;B12;B13;"
        str1 += "C7;C8;C9;C10;C11C14;"
        str1 += "D1;D8;D9;D10;D15;"
        str1 += "E1;E2;E3;E12;E13;"

        availableSeats = str1.Split(";").ToList
    End Sub

    '좌석 클릭시 이벤트
    Private Sub SeatBt_Click(sender As Object, e As EventArgs)
        If selectedSeats.Contains(sender.name) Then
            selectedSeats.Remove(sender.name)
            sender.BackColor = Color.FromArgb(90, 90, 90)
            If currentSeatCount > 0 Then
                currentSeatCount -= 1
            End If
        Else
            If Not currentSeatCount + 1 > seatcount Then
                selectedSeats.Add(sender.name)
                sender.BackColor = Color.FromArgb(90, 0, 255)
                currentSeatCount += 1
            End If
        End If

        If seatcount - currentSeatCount = 0 Then
            SeatLeftLabel.Text = "좌석을 결정하셨다면 아래 '예매하기' 버튼을 누르세요"
            SubmitButton.Visible = True
        Else
            SeatLeftLabel.Text = (seatcount - currentSeatCount).ToString + "개의 좌석이 남았습니다"
            SubmitButton.Visible = False
        End If
        'MsgBox("clicked: " + sender.name)
    End Sub


    Private Sub SeatSelectionForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetDemoSeats()


        Dim g As Graphics = CreateGraphics()
        Dim dpi = g.DpiX
        Dim current = dpi / 96

        Opacity = 0

        SeatGridPanel.Controls.Clear()

        For ynum = 1 To 10

            For xnum = 1 To 15

                Dim btname As String

                Select Case ynum
                    Case 1
                        btname = "A"
                    Case 2
                        btname = "B"
                    Case 3
                        btname = "C"
                    Case 4
                        btname = "D"
                    Case 5
                        btname = "E"
                    Case 6
                        btname = "F"
                    Case 7
                        btname = "G"
                    Case 8
                        btname = "H"
                    Case 9
                        btname = "I"
                    Case 10
                        btname = "J"
                    Case Else
                        btname = "?"
                End Select

                btname += xnum.ToString

                Dim seatBt As New Button

                seatBt.Name = btname
                seatBt.Text = btname
                seatBt.Dock = DockStyle.Fill
                seatBt.FlatStyle = FlatStyle.Flat
                seatBt.FlatAppearance.BorderSize = 0
                seatBt.ForeColor = Color.White
                seatBt.BackColor = Color.FromArgb(39, 39, 39)
                seatBt.Font = New Font("Roboto Condensed", 13 * current)

                '존재하는 자리일 경우에만 보이기
                If (Not existingSeats.Contains(btname)) Then
                    seatBt.Text = ""
                    seatBt.BackColor = SeatGridPanel.BackColor
                End If

                '비지 않은 자리일 경우 활성화 -> 아니면 비활성화
                If (availableSeats.Contains(btname)) Then
                    seatBt.BackColor = Color.FromArgb(90, 90, 90)
                Else
                    seatBt.Enabled = False
                End If

                AddHandler seatBt.Click, AddressOf SeatBt_Click

                SeatGridPanel.Controls.Add(seatBt)

            Next

        Next
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        PurchaseForm.Close()
        PurchaseForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        PurchaseForm.Show()
    End Sub
End Class