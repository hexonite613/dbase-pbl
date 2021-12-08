Imports MySql.Data.MySqlClient

Public Class MainForm
    Public userid As String = ""
    Public username As String = ""
    Public theater As String = ""
    Public theaterid As String = ""
    Public stafftype As String = ""

    Dim mode As Integer = 0
    Dim modeBtActiveColor As Color = Color.FromArgb(74, 38, 140)
    Dim film_selectedid As Integer = -1
    Dim film_totalcount As Integer = 0
    Dim film_currentpage As Integer = 1
    Dim film_pagesize As Integer = 25

    Dim scr_selectedid As Integer = -1
    Dim scr_totalcount As Integer = 0
    Dim scr_currentpage As Integer = 1
    Dim scr_pagesize As Integer = 25

    Dim sche_screen_index As New List(Of Integer)
    Dim sche_screen_prevselect As Integer = -1

    Dim pur_seletedid As Integer = -1


#Region "공통"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainer1.Panel2.Enabled = False

        ModeFilmBT.Visible = False
        ModeScreenBT.Visible = False
        ModePurchaseBT.Visible = False
        ModeScheduleBT.Visible = False
        ModeStaffBT.Visible = False
        ModeFacilBT.Visible = False

        Select Case stafftype
            Case "staff" '일반 직원 -> 결제, 시설만 표시
                ModePurchaseBT.Visible = True
                ModeFacilBT.Visible = True
                ModeSelector(3)

            Case "admin" '관리자 -> 모두 표시
                ModeFilmBT.Visible = True
                ModeScreenBT.Visible = True
                ModePurchaseBT.Visible = True
                ModeScheduleBT.Visible = True
                ModeStaffBT.Visible = True
                ModeFacilBT.Visible = True
                ModeSelector(1)

            Case Else
                MsgBox("직원 직함을 불러오는 데 실패했습니다." + vbCr + "계정을 확인해 주십시오.", vbCritical)

        End Select

        UserLabel.Text = username + " 님 (" + theater + ")"
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 로그인된 상태라면
        If LoginForm.loggedin Then
            Application.Exit()
        End If
    End Sub

    Private Sub LogoutBT_Click(sender As Object, e As EventArgs) Handles LogoutBT.Click
        If MsgBox("로그아웃 하시겠습니까?", vbYesNo + vbQuestion) = vbYes Then
            LoginForm.loggedin = False
            LoginForm.Show()
            Close()
        End If
    End Sub

    Private Sub ModeBT_MouseEnter(sender As Object, e As EventArgs) Handles ModeFilmBT.MouseEnter, ModeScreenBT.MouseEnter,
        ModePurchaseBT.MouseEnter, ModeScheduleBT.MouseEnter, ModeStaffBT.MouseEnter, ModeFacilBT.MouseEnter
        Dim currentBt As Integer = 0

        Select Case sender.Name
            Case "ModeFilmBT"
                currentBt = 1
            Case "ModeScreenBT"
                currentBt = 2
            Case "ModePurchaseBT"
                currentBt = 3
            Case "ModeArrangeBT"
                currentBt = 4
            Case "ModeStaffBT"
                currentBt = 5
            Case "ModeFacilBT"
                currentBt = 6
        End Select

        If Not currentBt = mode Then '현재 hover 버튼이 선택버튼이 "아닐"때
            sender.BackColor = Color.FromArgb(60, 60, 60)
        End If

    End Sub

    Private Sub ModeBT_MouseLeave(sender As Object, e As EventArgs) Handles ModeFilmBT.MouseLeave, ModeScreenBT.MouseLeave,
        ModePurchaseBT.MouseLeave, ModeScheduleBT.MouseLeave, ModeStaffBT.MouseLeave, ModeFacilBT.MouseLeave
        Dim currentBt As Integer = 0

        Select Case sender.Name
            Case ModeFilmBT.Name
                currentBt = 1
            Case ModeScreenBT.Name
                currentBt = 2
            Case ModePurchaseBT.Name
                currentBt = 3
            Case ModeScheduleBT.Name
                currentBt = 4
            Case ModeStaffBT.Name
                currentBt = 5
            Case ModeFacilBT.Name
                currentBt = 6
        End Select

        If Not currentBt = mode Then '현재 hover 버튼이 선택버튼이 "아닐"때
            sender.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub ModeBT_Click(sender As Object, e As EventArgs) Handles ModeFilmBT.Click, ModeScreenBT.Click,
        ModePurchaseBT.Click, ModeScheduleBT.Click, ModeStaffBT.Click, ModeFacilBT.Click
        Select Case sender.Name
            Case ModeFilmBT.Name
                ModeSelector(1)
            Case ModeScreenBT.Name
                ModeSelector(2)
            Case ModePurchaseBT.Name
                ModeSelector(3)
            Case ModeScheduleBT.Name
                ModeSelector(4)
            Case ModeStaffBT.Name
                ModeSelector(5)
            Case ModeFacilBT.Name
                ModeSelector(6)
        End Select
    End Sub

    Private Sub ModeSelector(mode As Integer)
        Me.mode = mode

        ModeFilmBT.BackColor = Color.Transparent
        ModeScreenBT.BackColor = Color.Transparent
        ModePurchaseBT.BackColor = Color.Transparent
        ModeScheduleBT.BackColor = Color.Transparent
        ModeStaffBT.BackColor = Color.Transparent
        ModeFacilBT.BackColor = Color.Transparent

        Panel_Film.Visible = False
        Panel_Screen.Visible = False
        Panel_Schedule.Visible = False
        Panel_Purchase.Visible = False

        Select Case mode
            Case 1
                Panel_Film.Show()
                ModeFilmBT.BackColor = modeBtActiveColor
                '자동으로 영화화면 출력 & 목록 업데이트 하기
                film_update_list()
            Case 2
                Panel_Screen.Show()
                ModeScreenBT.BackColor = modeBtActiveColor
                '자동으로 상영관목록 업데이트 하기
                scr_update_list()
            Case 3
                Panel_Purchase.Show()
                ModePurchaseBT.BackColor = modeBtActiveColor
                pur_update_list()
            Case 4
                Panel_Schedule.Show()
                ModeScheduleBT.BackColor = modeBtActiveColor
                sche_update_list()
            Case 5
                ModeStaffBT.BackColor = modeBtActiveColor
            Case 6
                ModeFacilBT.BackColor = modeBtActiveColor
        End Select
    End Sub

#End Region

#Region "영화 관리"

    Public Sub film_update_list()
        If Not stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

        ' 컨트롤로부터 페이지 설정값 읽기
        If Not IsNumeric(film_curpage_tb.Text) Then
            film_curpage_tb.Text = "1"
        ElseIf Convert.ToInt32(film_curpage_tb.Text) < 1 Then
            film_curpage_tb.Text = "1"
        End If

        DB_OPEN(0)

        ' 총 개수 쿼리 실행
        Dim cmd As New MySqlCommand("SELECT count(*) FROM movie", BP_CON(0))
        film_totalcount = Convert.ToInt32(cmd.ExecuteScalar())

        ' 페이지 값 최대값 초과시 최대값으로 설정
        Dim maxpage = film_totalcount \ film_pagesize + 1
        If film_totalcount Mod film_pagesize = 0 Then maxpage -= 1

        film_totalpage_label.Text = "/ " + maxpage.ToString

        If Convert.ToInt32(film_curpage_tb.Text) > maxpage Then
            film_curpage_tb.Text = maxpage.ToString
        End If

        film_currentpage = Convert.ToInt32(film_curpage_tb.Text)


        cmd.CommandText = "Select * FROM movie "

        If Not film_filter_tb.Text = "" Then
            cmd.CommandText += "WHERE name LIKE ?nl1 OR name_eng LIKE ?nl2 "
            cmd.Parameters.AddWithValue("?nl1", "%" + film_filter_tb.Text + "%")
            cmd.Parameters.AddWithValue("?nl2", "%" + film_filter_tb.Text + "%")
        End If

        cmd.CommandText += "ORDER BY movie_id DESC LIMIT " + (film_pagesize * (film_currentpage - 1)).ToString + ", " + film_pagesize.ToString


        'Dim ISQL = "Select * FROM movie ORDER BY movie_id DESC LIMIT " + (film_pagesize * (film_currentpage - 1)).ToString + ", " + film_pagesize.ToString
        'Dim RS = GL_DB_READER(ISQL, 0)

        Dim RS = cmd.ExecuteReader()


        If RS.Read() = False Then
            MsgBox("영화 데이터가 존재하지 않습니다.", vbExclamation)
        Else
            FilmListView.Items.Clear()
            Do

                '영화ID 장르ID 영화명 영문명 상영시간 설명 개봉일 국가 등급 포스터
                FilmListView.Items.Add(New ListViewItem(New String() {RS("movie_id"),
                                                     RS("genre_id"),
                                                     RS("name"),
                                                     RS("name_eng"),
                                                     RS("movie_time"),
                                                     newlineConverter(RS("description").ToString),
                                                     RS("release_date"),
                                                     RS("country"),
                                                     RS("rating"),
                                                     RS("poster").ToString}))

            Loop Until RS.Read = False

            film_listupdatetime_label.Text = "마지막 업데이트 시간:" + vbCr + Now.ToString("yyyy-MM-dd HH:mm:ss")
        End If

        ' 탐색 쿼리 종료
        RS.Close()

        If maxpage = 1 Then
            film_prevpage_bt.Enabled = False
            film_nextpage_bt.Enabled = False
        ElseIf film_currentpage = maxpage Then
            film_prevpage_bt.Enabled = True
            film_nextpage_bt.Enabled = False
        ElseIf film_currentpage = 1 Then
            film_prevpage_bt.Enabled = False
            film_nextpage_bt.Enabled = True
        Else
            film_prevpage_bt.Enabled = True
            film_nextpage_bt.Enabled = True
        End If

    End Sub


    Private Sub film_update_bt_Click(sender As Object, e As EventArgs) Handles film_update_bt.Click
        film_update_list()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilmListView.SelectedIndexChanged

        If FilmListView.SelectedItems.Count > 0 Then

            Dim item As ListViewItem = FilmListView.SelectedItems(0)

            filminfo_id_tb.Text = item.SubItems(0).Text
            filminfo_genre_id_cb.Text = item.SubItems(1).Text
            filminfo_name_tb.Text = item.SubItems(2).Text
            filminfo_name_eng_tb.Text = item.SubItems(3).Text
            filminfo_time_tb.Text = item.SubItems(4).Text
            filminfo_description_tb.Text = item.SubItems(5).Text
            filminfo_release_date_dtp.Value = Date.Parse(item.SubItems(6).Text)
            filminfo_country_tb.Text = item.SubItems(7).Text
            filminfo_rating_cb.Text = item.SubItems(8).Text
            If item.SubItems(9).Text = "" Then
                filminfo_poster_pb.Image = My.Resources.noimg
            Else
                filminfo_poster_pb.LoadAsync(item.SubItems(9).Text)
                filminfo_poster_pb.Image = My.Resources.loading
            End If

            film_selectedid = Convert.ToInt32(item.SubItems(0).Text)
            SplitContainer1.Panel2.Enabled = True
        Else
            SplitContainer1.Panel2.Enabled = False
        End If

    End Sub

    Dim MaxWidth As Integer = dpicalc(Me, 300)
    Dim MinWidth As Integer = dpicalc(Me, 50)

    Private Sub filminfo_poster_pb_SizeChanged(sender As Object, e As EventArgs) Handles filminfo_poster_pb.SizeChanged
        Dim PanelHeight As Integer = filminfo_poster_pb.Height
        Dim PanelWidth As Integer = PanelHeight * 0.7

        ' 공식: 높이 x 0.7 = 너비
        If PanelWidth >= MaxWidth Then
            filminfo_poster_pb.Width = MaxWidth
        ElseIf PanelWidth <= MinWidth Then
            filminfo_poster_pb.Width = MinWidth
        Else
            filminfo_poster_pb.Width = PanelWidth
        End If

    End Sub

    Private Sub film_editBT_Click(sender As Object, e As EventArgs) Handles film_editBT.Click
        If film_selectedid = -1 Then
            MsgBox("영화가 선택되지 않았습니다", vbCritical)
        Else
            FilmEditForm.Close()
            FilmEditForm.editmode = True
            FilmEditForm.listindex = FilmListView.SelectedItems(0).Index
            FilmEditForm.movieId = film_selectedid
            FilmEditForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub film_addBT_Click(sender As Object, e As EventArgs) Handles film_addBT.Click
        FilmEditForm.Close()
        FilmEditForm.editmode = False
        FilmEditForm.ShowDialog(Me)
    End Sub

    'TODO : 제거 손보기
    Private Sub film_removeBT_Click(sender As Object, e As EventArgs) Handles film_removeBT.Click
        If film_selectedid = -1 Then
            MsgBox("영화가 선택되지 않았습니다", vbCritical)
        Else
            Dim ISQL = "Select * From movie WHERE movie_id=" + film_selectedid.ToString
            Dim RS = GL_DB_READER(ISQL, 0)

            If RS.Read() = False Then
                RS.Close()
                MsgBox("해당 영화가 존재하지 않습니다." + vbCr + "(이미 삭제되었을 수도 있습니다)", vbExclamation)
            Else
                If MsgBox(RS("name") + vbCr + vbCr + "위 영화를 정말로 삭제하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                    RS.Close()
                    ISQL = "DELETE FROM movie WHERE movie.movie_id = " + film_selectedid.ToString

                    Try
                        RS = GL_DB_READER(ISQL, 0)
                        RS.Close()
                    Catch ex As Exception
                        MsgBox("삭제 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
                        RS.Close()
                        Exit Sub
                    End Try

                    film_update_list()
                Else
                    RS.Close()
                End If
            End If

        End If
    End Sub


    Private Sub film_prevpage_bt_Click(sender As Object, e As EventArgs) Handles film_prevpage_bt.Click
        ' 페이지 TB의 값이 숫자일때
        If IsNumeric(film_curpage_tb.Text) Then
            film_curpage_tb.Text = (Convert.ToInt32(film_curpage_tb.Text) - 1).ToString
        Else ' 숫자가 아닐때 -> 그냥 변수에 저장된 페이지값 쓰기
            film_currentpage -= 1
            film_curpage_tb.Text = film_currentpage.ToString
        End If
        film_update_list()
    End Sub

    Private Sub film_nextpage_bt_Click(sender As Object, e As EventArgs) Handles film_nextpage_bt.Click
        ' 페이지 TB의 값이 숫자일때
        If IsNumeric(film_curpage_tb.Text) Then
            film_curpage_tb.Text = (Convert.ToInt32(film_curpage_tb.Text) + 1).ToString
        Else ' 숫자가 아닐때 -> 그냥 변수에 저장된 페이지값 쓰기
            film_currentpage += 1
            film_curpage_tb.Text = film_currentpage.ToString
        End If
        film_update_list()
    End Sub

#End Region

#Region "상영관 좌석 관리"

    Public Sub scr_update_list()

        If Not stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

        ' 컨트롤로부터 페이지 설정값 읽기
        If Not IsNumeric(scr_curpage_tb.Text) Then
            scr_curpage_tb.Text = "1"
        ElseIf Convert.ToInt32(scr_curpage_tb.Text) < 1 Then
            scr_curpage_tb.Text = "1"
        End If

        DB_OPEN(0)

        ' 총 개수 쿼리 실행
        Dim cmd As New MySqlCommand("SELECT count(*) FROM screen", BP_CON(0))
        scr_totalcount = Convert.ToInt32(cmd.ExecuteScalar())

        ' 페이지 값 최대값 초과시 최대값으로 설정
        Dim maxpage = scr_totalcount \ scr_pagesize + 1
        If scr_totalcount Mod scr_pagesize = 0 Then maxpage -= 1

        scr_totalpage_label.Text = "/ " + maxpage.ToString

        If Convert.ToInt32(scr_curpage_tb.Text) > maxpage Then
            scr_curpage_tb.Text = maxpage.ToString
        End If

        scr_currentpage = Convert.ToInt32(scr_curpage_tb.Text)


        cmd.CommandText = "Select * FROM screen NATURAL JOIN theater "
        cmd.CommandText += "ORDER BY screen_id DESC LIMIT " + (scr_pagesize * (scr_currentpage - 1)).ToString + ", " + scr_pagesize.ToString


        'Dim ISQL = "Select * FROM movie ORDER BY movie_id DESC LIMIT " + (scr_pagesize * (scr_currentpage - 1)).ToString + ", " + scr_pagesize.ToString
        'Dim RS = GL_DB_READER(ISQL, 0)

        Dim RS = cmd.ExecuteReader()


        If RS.Read() = False Then
            MsgBox("영화 데이터가 존재하지 않습니다.", vbExclamation)
        Else
            ScrListView.Items.Clear()
            Do

                '관ID 관명 영화관ID 영화관명 상영방식 행 열 좌석수
                ScrListView.Items.Add(New ListViewItem(New String() {RS("screen_id"),
                                                       RS("screen_name"),
                                                       RS("theater_id"),
                                                       RS("theater_name"),
                                                       RS("screen_type")}))

            Loop Until RS.Read = False

            scr_listupdatetime_label.Text = "마지막 업데이트 시간:" + vbCr + Now.ToString("yyyy-MM-dd HH:mm:ss")
        End If

        ' 탐색 쿼리 종료
        RS.Close()

        If maxpage = 1 Then
            scr_prevpage_bt.Enabled = False
            scr_nextpage_bt.Enabled = False
        ElseIf scr_currentpage = maxpage Then
            scr_prevpage_bt.Enabled = True
            scr_nextpage_bt.Enabled = False
        ElseIf scr_currentpage = 1 Then
            scr_prevpage_bt.Enabled = False
            scr_nextpage_bt.Enabled = True
        Else
            scr_prevpage_bt.Enabled = True
            scr_nextpage_bt.Enabled = True
        End If

        scr_edit_bt.Enabled = ScrListView.SelectedItems.Count > 0

    End Sub

    Private Sub scr_update_bt_Click(sender As Object, e As EventArgs) Handles scr_update_bt.Click
        scr_update_list()
    End Sub

    Public Sub scr_update_seat_list()
        Dim row_list As New List(Of String) '행 목록
        Dim col_list As New List(Of Integer) '열 목록
        Dim seat_list_av As New List(Of String) '사용가능좌석
        Dim seat_list_na As New List(Of String) '사용불가좌석

        If Not stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

        DB_OPEN(0)

        ' 좌석 조회 쿼리 실행
        Dim cmd As New MySqlCommand("SELECT * FROM screen_seat WHERE screen_id = " + scr_selectedid.ToString + " ORDER BY seat_row, seat_col", BP_CON(0))

        Dim RS = cmd.ExecuteReader()

        ' 테이블 완전 비우기
        scr_seat_table.Controls.Clear()
        scr_seat_table.RowStyles.Clear()
        scr_seat_table.ColumnStyles.Clear()

        If RS.Read() = False Then
            SeatListView.Items.Add(New ListViewItem(New String() {"(없음)"}))
        Else
            SeatListView.Items.Clear()
            Do
                Dim avail As String = ""
                Select Case RS("available")
                    Case "1"
                        avail = "가능"
                    Case "0"
                        avail = "불가"
                    Case Else
                        avail = "알 수 없음"
                End Select

                '영화ID 장르ID 영화명 영문명 상영시간 설명 개봉일 국가 등급 포스터
                SeatListView.Items.Add(New ListViewItem(New String() {RS("seat_id"),
                                                        RS("seat_row"),
                                                        RS("seat_col"),
                                                        RS("screen_id"),
                                                        RS("theater_id"),
                                                        avail}))

                If Not row_list.Contains(RS("seat_row")) Then
                    row_list.Add(RS("seat_row"))
                End If

                If Not col_list.Contains(Convert.ToInt32(RS("seat_col"))) Then
                    col_list.Add(Convert.ToInt32(RS("seat_col")))
                End If

                If RS("available") = "1" And Not seat_list_av.Contains(RS("seat_row") + " " + RS("seat_col").ToString) Then
                    seat_list_av.Add(RS("seat_row") + " " + RS("seat_col").ToString)
                End If

                If RS("available") = "0" And Not seat_list_na.Contains(RS("seat_row") + " " + RS("seat_col").ToString) Then
                    seat_list_na.Add(RS("seat_row") + " " + RS("seat_col").ToString)
                End If

            Loop Until RS.Read = False

            ' 좌석 탐색 후
            'MsgBox(row_list.Count)
            'MsgBox(col_list.Count)

            row_list.Sort()
            col_list.Sort()

            Dim row_size As Integer = Asc(row_list.Last) - Asc(row_list.First) + 1
            Dim col_size As Integer = col_list.Last - col_list.First + 1

            ' 테이블 행렬 설정 및 비율설정
            scr_seat_table.RowCount = row_size
            For i = 1 To row_size
                scr_seat_table.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / row_size))
            Next
            scr_seat_table.ColumnCount = col_size
            For i = 1 To col_size
                scr_seat_table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / col_size))
            Next

            For Each seat In seat_list_av
                Dim row = Asc(seat.Split(" ")(0)) - 65
                Dim col = Convert.ToInt32(seat.Split(" ")(1)) - 1

                Dim lb As New Label
                lb.AutoSize = False
                lb.Dock = DockStyle.Fill
                lb.Text = seat.Replace(" ", "")
                lb.Font = New Font("맑은 고딕", 7.5)
                lb.TextAlign = ContentAlignment.MiddleCenter
                lb.BackColor = Color.FromArgb(141, 93, 228)
                lb.ForeColor = Color.White
                lb.Margin = New Padding(1)


                scr_seat_table.Controls.Add(lb, col, row)
            Next

            For Each seat In seat_list_na
                Dim row = Asc(seat.Split(" ")(0)) - 65
                Dim col = Convert.ToInt32(seat.Split(" ")(1)) - 1

                Dim lb As New Label
                lb.AutoSize = False
                lb.Dock = DockStyle.Fill
                lb.Text = seat.Replace(" ", "")
                lb.Font = New Font("맑은 고딕", 7.5)
                lb.TextAlign = ContentAlignment.MiddleCenter
                lb.BackColor = Color.FromArgb(44, 36, 58)
                lb.ForeColor = Color.Gray
                lb.Margin = New Padding(1)

                scr_seat_table.Controls.Add(lb, col, row)
            Next

        End If

        ' 탐색 쿼리 종료
        RS.Close()

    End Sub

    Private Sub ScrListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScrListView.SelectedIndexChanged
        If ScrListView.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = ScrListView.SelectedItems(0)
            scr_selectedid = Convert.ToInt32(item.SubItems(0).Text)
            SplitContainer2.Panel2.Enabled = True
            scr_edit_bt.Enabled = True
            scr_update_seat_list()
        Else
            SplitContainer2.Panel2.Enabled = False
            scr_edit_bt.Enabled = False
            SeatListView.Items.Clear()
        End If
    End Sub

    Private Sub scr_seat_edit_bt_Click(sender As Object, e As EventArgs) Handles scr_seat_edit_bt.Click
        If ScrListView.SelectedItems.Count > 0 Then
            SeatEditForm.Close()
            SeatEditForm.screen_id = scr_selectedid
            SeatEditForm.theater_id = ScrListView.SelectedItems(0).SubItems(2).Text
            SeatEditForm.listindex = ScrListView.SelectedItems(0).Index
            SeatEditForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub scr_edit_bt_Click(sender As Object, e As EventArgs) Handles scr_edit_bt.Click
        If ScrListView.SelectedItems.Count > 0 Then
            ScreenEditForm.Close()
            ScreenEditForm.screenId = scr_selectedid
            ScreenEditForm.listindex = ScrListView.SelectedItems(0).Index
            ScreenEditForm.editmode = True
            ScreenEditForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub scr_add_bt_Click(sender As Object, e As EventArgs) Handles scr_add_bt.Click
        ScreenEditForm.Close()
        ScreenEditForm.editmode = False
        ScreenEditForm.ShowDialog(Me)
    End Sub

#End Region

#Region "상영 일정"

    Public Sub sche_update_list()
        If Not stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

        DB_OPEN(0)

        Dim cmd As New MySqlCommand("SELECT DISTINCT screen_id, screen_name FROM screen WHERE theater_id = ?tid", BP_CON(0))

        cmd.Parameters.AddWithValue("?tid", theaterid)

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("상영관 데이터가 존재하지 않습니다.", vbExclamation)
            Else

                sche_scr_filter_cb.Items.Clear()
                sche_screen_index.Clear()

                sche_scr_filter_cb.Items.Add("전체 상영관")
                sche_screen_index.Add(-1)

                Do
                    sche_scr_filter_cb.Items.Add(RS("screen_id").ToString + " (" + RS("screen_name") + ")")
                    sche_screen_index.Add(RS("screen_id"))
                Loop Until RS.Read = False

            End If

            If sche_screen_prevselect = -1 Then
                sche_scr_filter_cb.SelectedIndex = 0
            Else
                sche_scr_filter_cb.SelectedIndex = sche_screen_index.IndexOf(sche_screen_prevselect)
            End If

            cmd.Parameters.Clear()

        End Using

        cmd.CommandText = "Select *, DATE_ADD(start_time, INTERVAL movie_time MINUTE) AS end_time FROM schedule NATURAL JOIN movie "

        Dim starttime As Date = sche_time_start_dtp.Value
        Dim endtime As Date = sche_time_end_dtp.Value

        cmd.CommandText += "WHERE ( start_time BETWEEN DATE(?stime) AND DATE(?etime) + 1 ) "

        cmd.Parameters.AddWithValue("?stime", starttime.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("?etime", endtime.ToString("yyyy-MM-dd"))

        If Not sche_filter_tb.Text = "" Then
            cmd.CommandText += "AND ( name LIKE ?nl1 OR name_eng LIKE ?nl2 ) "
            cmd.Parameters.AddWithValue("?nl1", "%" + sche_filter_tb.Text + "%")
            cmd.Parameters.AddWithValue("?nl2", "%" + sche_filter_tb.Text + "%")
        End If

        If Not sche_screen_index(sche_scr_filter_cb.SelectedIndex) = -1 Then
            cmd.CommandText += "AND screen_id = ?sid "
            cmd.Parameters.AddWithValue("?sid", sche_screen_index(sche_scr_filter_cb.SelectedIndex))
        End If

        If sche_showcurrtheater_chk.Checked Then
            cmd.CommandText += "AND theater_id = ?tid"
            cmd.Parameters.AddWithValue("?tid", theaterid)
        End If

        cmd.CommandText += " ORDER BY start_time"

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            ScheListView.Items.Clear()

            If RS.Read() = False Then
                ScheListView.Items.Add(New ListViewItem(New String() {"(편성 없음)"}))
            Else
                Do
                    '편성 ID, 상영관명(ID), 영화관 ID, 영화 ID, 영화 이름, 영문 이름, 시작 시간, 종료 시간, 상영 시간(분)
                    ScheListView.Items.Add(New ListViewItem(New String() {RS("sche_id"),
                                                         RS("screen_id"),
                                                         RS("theater_id"),
                                                         RS("movie_id"),
                                                         RS("name"),
                                                         RS("name_eng"),
                                                         Convert.ToDateTime(RS("start_time")).ToString("yyyy-MM-dd HH:mm"),
                                                         Convert.ToDateTime(RS("end_time")).ToString("yyyy-MM-dd HH:mm"),
                                                         RS("movie_time")}))

                Loop Until RS.Read = False

                sche_listupdatetime_label.Text = "마지막 업데이트 시간:" + vbCr + Now.ToString("yyyy-MM-dd HH:mm:ss")
            End If

            ' 탐색 쿼리 종료
            RS.Close()

        End Using




        'Dim ISQL = "Select * FROM movie ORDER BY movie_id DESC LIMIT " + (sche_pagesize * (sche_currentpage - 1)).ToString + ", " + sche_pagesize.ToString
        'Dim RS = GL_DB_READER(ISQL, 0)





    End Sub

    Private Sub sche_update_bt_Click(sender As Object, e As EventArgs) Handles sche_update_bt.Click

        Dim stime = sche_time_start_dtp.Value
        sche_time_start_dtp.Value = New DateTime(stime.Year, stime.Month, stime.Day)

        Dim etime = sche_time_end_dtp.Value
        sche_time_end_dtp.Value = New DateTime(etime.Year, etime.Month, etime.Day)


        If sche_time_start_dtp.Value > sche_time_end_dtp.Value Then
            MsgBox("탐색 시작 범위가 끝 범위보다 앞설 수 없습니다.", vbExclamation)
        Else
            sche_update_list()
        End If
    End Sub

    Private Sub sche_scr_filter_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sche_scr_filter_cb.SelectedIndexChanged
        sche_screen_prevselect = sche_screen_index(sche_scr_filter_cb.SelectedIndex)
    End Sub

    Private Sub sche_add_bt_Click(sender As Object, e As EventArgs) Handles sche_add_bt.Click
        ScheduleAddForm.Close()
        ScheduleAddForm.ShowDialog()
    End Sub

    Private Sub sche_edit_bt_Click(sender As Object, e As EventArgs) Handles sche_edit_bt.Click
        If ScheListView.SelectedItems.Count > 0 Then
            Dim i As ListViewItem = ScheListView.SelectedItems(0)

            ScheduleEditForm.Close()

            ScheduleEditForm.orgscheid = Convert.ToInt32(i.SubItems.Item(0).Text)

            ScheduleEditForm.ShowDialog(Me)

        End If
    End Sub

#End Region

#Region "결제"

    Public Sub pur_update_list()

        If Not stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

        DB_OPEN(0)

        Dim cmd As New MySqlCommand("Select * FROM booking NATURAL JOIN schedule ", BP_CON(0))


        Dim starttime As Date = pur_time_start_dtp.Value
        Dim endtime As Date = pur_time_end_dtp.Value

        cmd.CommandText += "WHERE ( time BETWEEN DATE(?stime) AND DATE(?etime) + 1 ) "

        cmd.Parameters.AddWithValue("?stime", starttime.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("?etime", endtime.ToString("yyyy-MM-dd"))


        If pur_showcurrtheater_chk.Checked Then
            cmd.CommandText += "AND theater_id = ?tid"
            cmd.Parameters.AddWithValue("?tid", theaterid)
        End If

        cmd.CommandText += " ORDER BY start_time"

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            PurchaseListView.Items.Clear()

            If RS.Read() = False Then
                PurchaseListView.Items.Add(New ListViewItem(New String() {"(편성 없음)"}))
            Else
                Do
                    'book_num id sche_id seat_id time pay_price book_type pay_method cus_phonenum
                    PurchaseListView.Items.Add(New ListViewItem(New String() {RS("book_num"),
                                                                RS("id"),
                                                                RS("sche_id"),
                                                                RS("screen_id"),
                                                                RS("seat_id"),
                                                                RS("time"),
                                                                RS("pay_price"),
                                                                RS("book_type"),
                                                                RS("pay_method"),
                                                                RS("cus_phonenum")}))

                Loop Until RS.Read = False

                pur_listupdatetime_label.Text = "마지막 업데이트 시간:" + vbCr + Now.ToString("yyyy-MM-dd HH:mm:ss")
            End If

            ' 탐색 쿼리 종료
            RS.Close()

        End Using

    End Sub

    Private Sub pur_update_bt_Click(sender As Object, e As EventArgs) Handles pur_update_bt.Click

        Dim stime = pur_time_start_dtp.Value
        pur_time_start_dtp.Value = New DateTime(stime.Year, stime.Month, stime.Day)

        Dim etime = pur_time_end_dtp.Value
        pur_time_end_dtp.Value = New DateTime(etime.Year, etime.Month, etime.Day)


        If pur_time_start_dtp.Value > pur_time_end_dtp.Value Then
            MsgBox("탐색 시작 범위가 끝 범위보다 앞설 수 없습니다.", vbExclamation)
        Else
            pur_update_list()
        End If
    End Sub

    Private Sub pur_del_bt_Click(sender As Object, e As EventArgs) Handles pur_del_bt.Click
        If Not PurchaseListView.SelectedItems.Count > 0 Then
            Exit Sub
        End If

        If MsgBox("선택한 결제를 정말로 취소하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
            Exit Sub
        End If

        Try
            For Each i As ListViewItem In PurchaseListView.SelectedItems

                Dim ISQL = "Select * From booking WHERE book_num=" + i.SubItems.Item(0).Text
                Dim RS = GL_DB_READER(ISQL, 0)

                If RS.Read() = False Then
                    RS.Close() '이미 없으므로 패스
                Else
                    RS.Close()
                    ISQL = "DELETE FROM booking WHERE booking.book_num = " + i.SubItems.Item(0).Text
                    RS = GL_DB_READER(ISQL, 0)
                    RS.Close()
                End If

            Next
        Catch ex As Exception
            MsgBox("삭제 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
            Exit Sub
        End Try


        MsgBox("취소가 완료되었습니다.", vbInformation)
    End Sub

    Private Sub pur_view_bt_Click(sender As Object, e As EventArgs) Handles pur_view_bt.Click
        If PurchaseListView.SelectedItems.Count > 0 Then
            ScheduleEditForm.Close()
            ScheduleEditForm.readonlymode = True
            ScheduleEditForm.orgscheid = Convert.ToInt32(PurchaseListView.SelectedItems(0).SubItems(2).Text)
            ScheduleEditForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub pur_seat_bt_Click(sender As Object, e As EventArgs) Handles pur_seat_bt.Click
        If PurchaseListView.SelectedItems.Count > 0 Then
            SeatEditForm.Close()
            SeatEditForm.readonlymode = True
            SeatEditForm.screen_id = Convert.ToInt32(PurchaseListView.SelectedItems(0).SubItems(3).Text)
            SeatEditForm.highlightSeat = Convert.ToInt32(PurchaseListView.SelectedItems(0).SubItems(4).Text)
            SeatEditForm.ShowDialog(Me)
        End If
    End Sub
#End Region

End Class
