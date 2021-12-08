Imports MySql.Data.MySqlClient

Public Class ScheduleAddForm
    Dim movieId As Integer = -1
    Dim theaterId As String = ""
    Dim screenId As Integer = -1

    Dim screenIndex As New List(Of Integer)
    Dim starttime As New DateTime
    Dim movietime As Integer = -1

    Private Sub ScheduleAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCurrentTheaterChk.Checked = True
        theaterId = MainForm.theaterid
        CheckTheater()
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
        If movieId = -1 Then
            MsgBox("영화를 선택해 주세요", vbExclamation)
            Exit Sub
        End If

        If screenId = -1 Then
            MsgBox("상영관을 선택해 주세요", vbExclamation)
            Exit Sub
        End If

        If theaterId = "" Then
            MsgBox("지점ID를 설정해 주세요", vbExclamation)
            Exit Sub
        End If

        For Each i As ListViewItem In ScheduleAddList.Items

            If i.SubItems.Item(1).Text = screenId.ToString Then
                If Not ((StartDTP.Value <= Convert.ToDateTime(i.SubItems.Item(2).Text) And EndDTP.Value <= Convert.ToDateTime(i.SubItems.Item(2).Text)) _
                    Or (StartDTP.Value >= Convert.ToDateTime(i.SubItems.Item(3).Text) And EndDTP.Value >= Convert.ToDateTime(i.SubItems.Item(3).Text))) Then

                    MsgBox(i.SubItems.Item(2).Text + "에 " + i.SubItems.Item(5).Text + " 을(를)" + vbCr + "상영하는 편성과 겹칩니다.", vbExclamation, "편성 겹침")
                    Exit Sub
                End If
            End If
        Next

        ScheduleAddList.Items.Add(New ListViewItem(New String() {theaterId,
                                                   screenId,
                                                   StartDTP.Value.ToString("yyyy-MM-dd HH:mm"),
                                                   EndDTP.Value.ToString("yyyy-MM-dd HH:mm"),
                                                   movieId,
                                                   movieNameTB.Text})) '값 채우기
    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim Conflict As Boolean = False
        Dim conf_log As String = ""

        Dim sqlq As String = "INSERT INTO `schedule` (`sche_id`, `movie_id`, `screen_id`, `theater_id`, `start_time`) VALUES "

        DB_OPEN(0)

        Dim cmd As New MySqlCommand("", BP_CON(0))

        For Each i As ListViewItem In ScheduleAddList.Items

            cmd.Parameters.Clear()

            cmd.CommandText = "SELECT * FROM schedule NATURAL JOIN movie 
                                    WHERE
                                        screen_id = ?sid
                                        AND !((?c_start <= start_time AND ?c_end <= start_time)
                                              OR (?c_start >= DATE_ADD(start_time, INTERVAL movie_time MINUTE) AND ?c_end >= DATE_ADD(start_time, INTERVAL movie_time MINUTE)))"

            cmd.Parameters.AddWithValue("?c_start", i.SubItems.Item(2).Text)
            cmd.Parameters.AddWithValue("?c_end", i.SubItems.Item(3).Text)
            cmd.Parameters.AddWithValue("?sid", i.SubItems.Item(1).Text)

            Using RS As MySqlDataReader = cmd.ExecuteReader()

                If Not RS.Read() = False Then

                    Conflict = True
                    conf_log += vbCrLf + "#" + i.Index.ToString + " " + i.SubItems.Item(2).Text + "~" + i.SubItems.Item(3).Text
                    conf_log += vbCrLf + "ID: " + i.SubItems.Item(0).Text + " - " + i.SubItems.Item(1).Text + "  영화:" + i.SubItems.Item(5).Text + vbCrLf
                    conf_log += "겹치는 편성:" + "ID: " + RS("sche_id").ToString + " - " + RS("theater_id").ToString + " - " + RS("screen_id").ToString + vbCrLf
                    conf_log += RS("start_time").ToString + " : " + RS("name") + vbCrLf + vbCrLf + vbCrLf

                Else

                    sqlq += "(NULL, '" + i.SubItems.Item(4).Text + "', '" + i.SubItems.Item(1).Text + "', '" + i.SubItems.Item(0).Text + "', '" + i.SubItems.Item(2).Text + "'), "

                End If

            End Using

        Next

        sqlq += "{END}"


        If Conflict Then
            If MsgBox("겹치는 편성이 존재합니다." + vbCr + "확인 후 다시 시도하세요." + vbCr + vbCr + "('예'를 누르면 겹치는 편성의 내역이 출력됩니다)", vbExclamation + vbYesNo) = vbYes Then
                ConflictLogForm.TextBox1.Text = conf_log
                ConflictLogForm.ShowDialog(Me)
                Exit Sub
            End If
        End If

        sqlq = sqlq.Replace(", {END}", "")
        cmd.CommandText = sqlq

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

    Private Sub ListSelectedRemoveBT_Click(sender As Object, e As EventArgs) Handles ListSelectedRemoveBT.Click
        For Each i As ListViewItem In ScheduleAddList.SelectedItems
            i.Remove()
        Next
    End Sub

    Private Sub ListResetBT_Click(sender As Object, e As EventArgs) Handles ListResetBT.Click
        ScheduleAddList.Items.Clear()
    End Sub
End Class