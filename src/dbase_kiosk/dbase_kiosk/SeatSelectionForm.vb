Imports MySql.Data.MySqlClient

Public Class SeatSelectionForm
    Public selectedSeats As New List(Of String)

    Public screenId As Integer = -1
    Public sche_id As Integer = -1

    Dim avail_color As Color = Color.FromArgb(50, 50, 50)

    Public seatcount = -1
    Dim currentSeatCount = 0

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

    '좌석 클릭시 이벤트
    Private Sub SeatBt_Click(sender As Object, e As EventArgs)
        If selectedSeats.Contains(sender.name) Then
            selectedSeats.Remove(sender.name)
            sender.BackColor = avail_color
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

    Sub CheckSeats()

        Dim g As Graphics = CreateGraphics()
        Dim dpi = g.DpiX
        Dim current = dpi / 96

        Dim row As New List(Of String)
        Dim col As New List(Of Integer)
        Dim status As New List(Of Boolean)
        Dim sid As New List(Of Integer)

        ' 테이블 완전 비우기
        scr_seat_table.Controls.Clear()
        scr_seat_table.RowStyles.Clear()
        scr_seat_table.ColumnStyles.Clear()

        DB_OPEN(0)

        ' 좌석 조회 쿼리 실행
        Dim cmd As New MySqlCommand("SELECT * FROM screen_seat WHERE screen_id = ?sid ORDER BY seat_row, seat_col", BP_CON(0))
        cmd.Parameters.AddWithValue("?sid", screenId)

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("좌석 데이터가 존재하지 않습니다.", vbExclamation)
            Else
                Do
                    row.Add(RS("seat_row").ToString)
                    col.Add(Convert.ToInt32(RS("seat_col")))
                    status.Add(RS("available"))
                    sid.Add(Convert.ToInt32(RS("seat_id")))
                Loop Until RS.Read = False

            End If

            Dim row_size As Integer = Asc(row.Max) - Asc(row.Min) + 1
            Dim col_size As Integer = col.Max - col.Min + 1

            ' 테이블 행렬 설정 및 비율설정
            scr_seat_table.RowCount = row_size
            For i = 1 To row_size
                scr_seat_table.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / row_size))
            Next
            scr_seat_table.ColumnCount = col_size
            For i = 1 To col_size
                scr_seat_table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / col_size))
            Next


            For i = 0 To row.Count - 1

                Dim r = Asc(row(i)) - 65
                Dim c = col(i) - 1

                Dim lb As New Button
                lb.FlatStyle = FlatStyle.Flat
                lb.FlatAppearance.BorderSize = 0
                lb.ForeColor = Color.White
                lb.Dock = DockStyle.Fill
                lb.Font = New Font("Roboto Condensed", 13 * current)
                lb.TextAlign = ContentAlignment.MiddleCenter
                lb.Margin = New Padding(4)
                lb.Text = row(i) + " " + col(i).ToString
                lb.Name = sid(i).ToString

                If status(i) Then
                    lb.BackColor = avail_color
                Else
                    lb.BackColor = Color.FromArgb(34, 34, 34)
                    lb.Enabled = False
                    lb.Text = ""
                End If

                AddHandler lb.Click, AddressOf SeatBt_Click

                scr_seat_table.Controls.Add(lb, c, r)
            Next

            ' 탐색 쿼리 종료
        End Using


        cmd.CommandText = "SELECT * FROM
                           ( SELECT * FROM schedule
                            NATURAL JOIN screen_seat
                            WHERE
                            sche_id = ?sche_id ) a INNER JOIN booking
                            WHERE
                                a.seat_id = booking.seat_id AND booking.sche_id = ?sche_id"
        cmd.Parameters.AddWithValue("?sche_id", sche_id)

        Using RS As MySqlDataReader = cmd.ExecuteReader()
            If Not RS.Read() = False Then
                Do
                    Dim r = Asc(RS("seat_row")) - 65
                    Dim c = Convert.ToInt32(RS("seat_col")) - 1

                    Dim ctrl = scr_seat_table.GetControlFromPosition(c, r)
                    ctrl.Enabled = False
                Loop Until RS.Read = False
            End If
        End Using

    End Sub

    Private Sub SeatSelectionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0
        CheckSeats()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        PhoneNumForm.Close()
        PhoneNumForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        PhoneNumForm.Show()
    End Sub

End Class