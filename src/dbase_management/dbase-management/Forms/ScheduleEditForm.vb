Imports MySql.Data.MySqlClient

Public Class ScheduleEditForm
    Public movieId As Integer = -1
    Public theaterId As String = ""
    Public screenId As Integer = -1
    Public readonlymode As Boolean = False

    Public orgscheid As Integer = -1
    Public orgscrid As Integer = -1
    Dim orgsch_cb_index As Integer = -1

    Dim screenIndex As New List(Of Integer)
    Dim starttime As New DateTime
    Dim movietime As Integer = -1

    Private Sub ScheduleAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DB_OPEN(0)

        Dim cmd As New MySqlCommand("SELECT * FROM schedule WHERE sche_id = ?sid", BP_CON(0))
        cmd.Parameters.AddWithValue("?sid", orgscheid)

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("편성 데이터가 존재하지 않습니다.", vbExclamation)
            Else
                movieId = RS("movie_id")
                theaterId = RS("theater_id")
                orgscrid = RS("screen_id")
                screenId = RS("screen_id")
                starttime = RS("start_time")
            End If

            cmd.Parameters.Clear()

        End Using

        CheckTheater()
        CheckSeats()
        CheckMovie()

        If Not movieId = -1 Then
            screenCB.SelectedIndex = orgsch_cb_index
            theaterIDTB.Text = theaterId
            movieidTB.Text = movieId
            movieidTB.Enabled = False
            movieGetBT.Text = "변경"
            StartDTP.Value = starttime
        End If

        If readonlymode Then
            Text = "상영 편성 조회"
            TitleLabel.Text = "상영 편성 조회"
            movieGetBT.Text = "닫기"
            DeleteBT.Enabled = False
            DeleteBT.Visible = False
            Panel3.Enabled = False
        End If


    End Sub

    Private Sub SetCurrentTheaterChk_CheckedChanged(sender As Object, e As EventArgs) Handles SetCurrentTheaterChk.CheckedChanged
        theaterIDTB.Enabled = Not SetCurrentTheaterChk.Checked
        theaterIDTB.Text = MainForm.theaterid
    End Sub

    Private Sub TheaterCheckBT_Click(sender As Object, e As EventArgs) Handles TheaterCheckBT.Click
        theaterId = theaterIDTB.Text
        CheckTheater()
    End Sub

    Function CheckTheater()
        DB_OPEN(0)

        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM theater WHERE theater_id = ?tid", BP_CON(0))
        cmd.Parameters.AddWithValue("?tid", theaterId)

        ' 영화관 ID가 없을 경우
        If Not Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
            MsgBox("존재하지 않는 영화관 ID입니다. ID를 확인하여 주십시오.", vbExclamation)
            theaterId = ""
            Return False
        End If

        cmd.CommandText = "SELECT DISTINCT screen_id, screen_name FROM screen WHERE theater_id = ?tid"
        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("상영관 데이터가 존재하지 않습니다.", vbExclamation)
            Else

                screenCB.Items.Clear()
                screenIndex.Clear()

                Do
                    screenCB.Items.Add(RS("screen_id").ToString + " (" + RS("screen_name") + ")")
                    screenIndex.Add(RS("screen_id"))

                    If (Convert.ToInt32(RS("screen_id")) = orgscrid) Then
                        orgsch_cb_index = screenIndex.Count - 1
                    End If
                Loop Until RS.Read = False

            End If

            cmd.Parameters.Clear()

        End Using

        Return True
    End Function


    Sub CheckSeats()

        Dim row As New List(Of String)
        Dim col As New List(Of Integer)
        Dim status As New List(Of Boolean)

        If Not MainForm.stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

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

                Dim lb As New Label
                lb.AutoSize = False
                lb.Dock = DockStyle.Fill
                lb.Font = New Font("맑은 고딕", 6)
                lb.TextAlign = ContentAlignment.MiddleCenter

                lb.Margin = New Padding(4)
                lb.Text = row(i) + col(i).ToString

                If status(i) Then
                    lb.BackColor = Color.FromArgb(141, 93, 228)
                Else
                    lb.BackColor = Color.FromArgb(44, 36, 58)
                End If

                scr_seat_table.Controls.Add(lb, c, r)
            Next

            ' 탐색 쿼리 종료
        End Using


    End Sub

    Private Sub screenCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles screenCB.SelectedIndexChanged
        If Not screenCB.SelectedIndex = -1 Then
            screenId = screenIndex(screenCB.SelectedIndex)
            CheckSeats()
        Else
            screenId = -1
        End If
    End Sub

    Private Sub movieGetBT_Click(sender As Object, e As EventArgs) Handles movieGetBT.Click
        If movieId = -1 Then '영화가 선택되지 않았을 경우

            If movieidTB.Text = "" Then
                MsgBox("영화 ID를 입력해 주십시오", vbExclamation)
                Exit Sub
            ElseIf Not IsNumeric(movieidTB.Text) Then
                MsgBox("영화 ID는 숫자여야 합니다.", vbExclamation)
                Exit Sub
            End If

            movieId = Convert.ToInt32(movieidTB.Text)
            CheckMovie()

            If Not movieId = -1 Then
                movieidTB.Enabled = False
                movieGetBT.Text = "변경"
            End If

        Else
            movieId = -1
            movietime = -1
            movieidTB.Clear()
            movieidTB.Enabled = True
            movieGetBT.Text = "확인"

            movieNameTB.Text = ""
            movieEngNameTB.Text = ""
            genreidTB.Text = ""
            movieRatingTB.Text = ""
            movieTimeTB.Text = ""
            PosterPB.Image = Nothing
        End If
    End Sub

    Sub CheckMovie()
        DB_OPEN(0)

        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM movie WHERE movie_id = ?mid", BP_CON(0))
        cmd.Parameters.AddWithValue("?mid", movieId)

        ' 영화관 ID가 없을 경우
        If Not Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
            MsgBox("존재하지 않는 영화 ID입니다. ID를 확인하여 주십시오.", vbExclamation)
            movieId = -1
            movietime = -1
            Exit Sub
        End If

        cmd.CommandText = "SELECT * FROM movie NATURAL JOIN genre WHERE movie_id = ?mid"

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("영화 데이터가 존재하지 않습니다.", vbExclamation)
                movieId = -1
                movietime = -1
                Exit Sub
            Else
                movieNameTB.Text = RS("name")
                movieEngNameTB.Text = RS("name_eng")
                genreidTB.Text = RS("genre_id").ToString + " " + RS("genre_name")
                movieRatingTB.Text = RS("rating")
                movieTimeTB.Text = RS("movie_time")
                movietime = Convert.ToInt32(RS("movie_time"))
                PosterPB.LoadAsync(RS("poster"))

                EndDTP.Value = StartDTP.Value.AddMinutes(movietime)

            End If

            cmd.Parameters.Clear()

        End Using

    End Sub

    Private Sub SeeMovieDetailBT_Click(sender As Object, e As EventArgs) Handles SeeMovieDetailBT.Click
        If movieId = -1 Then
            MsgBox("영화를 선택하여 주세요", vbExclamation)
        Else
            FilmEditForm.Close()
            FilmEditForm.readonlymode = True
            FilmEditForm.movieId = movieId
            FilmEditForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub StartDTP_ValueChanged(sender As Object, e As EventArgs) Handles StartDTP.ValueChanged
        If movietime = -1 Then
            EndDTP.Value = StartDTP.Value
        Else
            EndDTP.Value = StartDTP.Value.AddMinutes(movietime)
        End If

    End Sub

    Private Sub ListAddBT_Click(sender As Object, e As EventArgs) Handles ListAddBT.Click

        If readonlymode Then
            Close()
            Exit Sub
        End If


        Dim Conflict As Boolean = False
        Dim conf_log As String = ""

        DB_OPEN(0)

        Dim cmd As New MySqlCommand("", BP_CON(0))

        cmd.CommandText = "SELECT * FROM schedule NATURAL JOIN movie 
                                    WHERE
                                        screen_id = ?sid
                                        AND !((?c_start <= start_time AND ?c_end <= start_time)
                                        OR (?c_start >= DATE_ADD(start_time, INTERVAL movie_time MINUTE) AND ?c_end >= DATE_ADD(start_time, INTERVAL movie_time MINUTE)))
                                        AND sche_id != ?scheid"

        cmd.Parameters.AddWithValue("?c_start", StartDTP.Value.ToString("yyyy-MM-dd HH:mm"))
        cmd.Parameters.AddWithValue("?c_end", EndDTP.Value.ToString("yyyy-MM-dd HH:mm"))
        cmd.Parameters.AddWithValue("?sid", screenId)
        cmd.Parameters.AddWithValue("?scheid", orgscheid)

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If Not RS.Read() = False Then

                Conflict = True
                conf_log += vbCrLf + "#0 " + StartDTP.Value.ToString("yyyy-MM-dd HH:mm") + "~" + EndDTP.Value.ToString("yyyy-MM-dd HH:mm")
                conf_log += vbCrLf + "ID: " + theaterId.ToString + " - " + screenId.ToString + "  영화:" + movieNameTB.Text + vbCrLf
                conf_log += "겹치는 편성:" + "ID: " + RS("sche_id").ToString + " - " + RS("theater_id").ToString + " - " + RS("screen_id").ToString + vbCrLf
                conf_log += RS("start_time").ToString + " : " + RS("name") + vbCrLf + vbCrLf + vbCrLf

            End If

        End Using


        If Conflict Then
            If MsgBox("겹치는 편성이 존재합니다." + vbCr + "확인 후 다시 시도하세요." + vbCr + vbCr + "('예'를 누르면 겹치는 편성의 내역이 출력됩니다)", vbExclamation + vbYesNo) = vbYes Then
                ConflictLogForm.TextBox1.Text = conf_log
                ConflictLogForm.ShowDialog(Me)
                Exit Sub
            End If
        End If

        cmd.Parameters.Clear()

        cmd.CommandText = "UPDATE `schedule` SET `movie_id` = ?mid, `screen_id` = ?sid, `theater_id` = ?tid, `start_time` = ?stime WHERE `schedule`.`sche_id` = ?scheid"

        cmd.Parameters.AddWithValue("?mid", movieId)
        cmd.Parameters.AddWithValue("?sid", screenId)
        cmd.Parameters.AddWithValue("?tid", theaterId)
        cmd.Parameters.AddWithValue("?stime", StartDTP.Value.ToString("yyyy-MM-dd HH:mm"))
        cmd.Parameters.AddWithValue("?scheid", orgscheid)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("데이터 적용 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
            Exit Sub
        End Try

        MsgBox("적용되었습니다.", vbInformation)
        MainForm.sche_update_list()
        Close()

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If orgscheid = -1 Then
            MsgBox("편성 값을 불러올 수 없습니다", vbCritical)
        Else
            Dim ISQL = "Select * From schedule WHERE sche_id=" + orgscheid.ToString
            Dim RS = GL_DB_READER(ISQL, 0)

            If RS.Read() = False Then
                RS.Close()
                MsgBox("해당 편성이 존재하지 않습니다." + vbCr + "(이미 삭제되었을 수도 있습니다)", vbExclamation)
            Else
                If MsgBox("해당 편성을 정말로 삭제하시겠습니까?" + vbCr + vbCr + "(이미 예약된 편성일 경우 예약을 취소하지 않으면 삭제에 실패할 수 있습니다)", vbQuestion + vbYesNo) = vbYes Then
                    RS.Close()
                    ISQL = "DELETE FROM schedule WHERE schedule.sche_id = " + orgscheid.ToString

                    Try
                        RS = GL_DB_READER(ISQL, 0)
                        RS.Close()
                    Catch ex As Exception
                        MsgBox("삭제 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
                        RS.Close()
                        Exit Sub
                    End Try

                    MainForm.sche_update_list()
                    Close()
                Else
                    RS.Close()
                End If
            End If

        End If
    End Sub
End Class