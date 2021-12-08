Imports MySql.Data.MySqlClient

Public Class SeatEditForm
    Public theater_id As String = ""
    Public screen_id As Integer = -1
    Public listindex As Integer = -1
    Public readonlymode As Boolean = False
    Public highlightSeat As Integer = -1

    Dim row_list As New List(Of String) '행 목록
    Dim col_list As New List(Of Integer) '열 목록
    Dim seat_list_av As New List(Of String) '사용가능좌석
    Dim seat_list_na As New List(Of String) '사용불가좌석
    Dim seat_list_del As New List(Of String) '삭제좌석
    Dim seat_list_new As New List(Of String) '생성좌석

    ' 상태표시 문자열 -> 나중에 List에서 읽어들일때 일정하게 읽어야하므로 따로 선언해놓음
    Dim avail_str As String = "가능"
    Dim notav_str As String = "불가능"
    Dim unknown_str As String = "알 수 없음"
    Dim del_str As String = "삭제됨"
    Dim new_str As String = "생성"

    Dim scr_selectedid As Integer = -1

    Private Sub SeatEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSeatInfo()

        If readonlymode Then
            Text = "좌석 조회"
            TitleLabel.Text = "좌석 조회"
            disable_bt.Enabled = False
            enable_bt.Enabled = False
            seat_row_tb.Enabled = False
            seat_col_tb.Enabled = False
            add_seat_bt.Enabled = False
            DeleteBT.Enabled = False
            SaveBT.Text = "닫기"


            For Each i As ListViewItem In SeatListView.Items
                If i.SubItems.Item(0).Text = highlightSeat.ToString Then
                    i.Selected = True
                End If
            Next

        End If
    End Sub

    Private Sub getSeatInfo() '좌석 정보 불러오기 -> 맨 처음 하는거니까 최초실행만 하면 됨

        If Not MainForm.stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Exit Sub
        End If

        DB_OPEN(0)

        ' 좌석 조회 쿼리 실행
        Dim cmd As New MySqlCommand("SELECT * FROM screen_seat WHERE screen_id = " + screen_id.ToString + " ORDER BY seat_row, seat_col", BP_CON(0))

        Dim RS = cmd.ExecuteReader()

        If RS.Read() = False Then
            MsgBox("좌석 데이터가 존재하지 않습니다.", vbExclamation)
        Else
            SeatListView.Items.Clear()
            Do
                Dim avail As String = ""
                Select Case RS("available")
                    Case "1"
                        avail = avail_str
                    Case "0"
                        avail = notav_str
                    Case Else
                        avail = unknown_str
                End Select

                '좌석ID 행 열 관ID 지점ID 사용가능여부
                SeatListView.Items.Add(New ListViewItem(New String() {RS("seat_id"),
                                                        RS("seat_row"),
                                                        RS("seat_col"),
                                                        RS("screen_id"),
                                                        avail})) '값 채우기

                If Not RS("theater_id").ToString = "" Then
                    theater_id = RS("theater_id")
                End If

            Loop Until RS.Read = False

            UpdateSeatInfo()

        End If

        ' 탐색 쿼리 종료
        RS.Close()
    End Sub

    Private Sub UpdateSeatInfo() '좌석 정보 "SeatListView"로부터 그리기 -> 이건 매 변경마다 하는것
        '리스트 초기화
        row_list.Clear()
        col_list.Clear()
        seat_list_av.Clear()
        seat_list_na.Clear()
        seat_list_del.Clear()
        seat_list_new.Clear()

        ' 좌석 탐색 후
        'MsgBox(row_list.Count)
        'MsgBox(col_list.Count)


        '좌석ID 행 열 관ID 지점ID 사용가능여부
        For Each i As ListViewItem In SeatListView.Items
            Dim sid As String = i.SubItems.Item(0).Text
            Dim row As String = i.SubItems.Item(1).Text.ToUpper
            Dim col As String = i.SubItems.Item(2).Text
            Dim avail As String = i.SubItems.Item(4).Text

            If Not row_list.Contains(row) Then
                row_list.Add(row)
            End If

            If Not col_list.Contains(Convert.ToInt32(col)) Then
                col_list.Add(Convert.ToInt32(col))
            End If

            Select Case avail
                Case avail_str
                    If Not seat_list_av.Contains(row + " " + col) Then
                        seat_list_av.Add(row + " " + col)
                    End If
                Case notav_str
                    If Not seat_list_na.Contains(row + " " + col) Then
                        seat_list_na.Add(row + " " + col)
                    End If
                Case del_str
                    If Not seat_list_del.Contains(row + " " + col) Then
                        seat_list_del.Add(row + " " + col)
                    End If
                Case new_str
                    If Not seat_list_new.Contains(row + " " + col) Then
                        seat_list_new.Add(row + " " + col)
                    End If
            End Select
        Next


        ' 테이블 완전 비우기
        scr_seat_table.Controls.Clear()
        scr_seat_table.RowStyles.Clear()
        scr_seat_table.ColumnStyles.Clear()

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

        ' 사용가능 자리 표시
        For Each seat In seat_list_av
            Dim row = Asc(seat.Split(" ")(0)) - 65
            Dim col = Convert.ToInt32(seat.Split(" ")(1)) - 1

            Dim lb As New Label
            lb.AutoSize = False
            lb.Dock = DockStyle.Fill
            lb.Text = seat.Replace(" ", "")
            lb.Name = seat
            lb.Font = New Font("맑은 고딕", 9)
            lb.TextAlign = ContentAlignment.MiddleCenter
            lb.BackColor = Color.FromArgb(141, 93, 228)
            lb.ForeColor = Color.White
            lb.Margin = New Padding(6)
            AddHandler lb.Click, AddressOf seat_Click

            scr_seat_table.Controls.Add(lb, col, row)
        Next

        ' 사용불가 자리 표시
        For Each seat In seat_list_na
            Dim row = Asc(seat.Split(" ")(0)) - 65
            Dim col = Convert.ToInt32(seat.Split(" ")(1)) - 1

            Dim lb As New Label
            lb.AutoSize = False
            lb.Dock = DockStyle.Fill
            lb.Text = seat.Replace(" ", "")
            lb.Name = seat
            lb.Font = New Font("맑은 고딕", 9)
            lb.TextAlign = ContentAlignment.MiddleCenter
            lb.BackColor = Color.FromArgb(44, 36, 58)
            lb.ForeColor = Color.Gray
            lb.Margin = New Padding(6)
            AddHandler lb.Click, AddressOf seat_Click

            scr_seat_table.Controls.Add(lb, col, row)
        Next

        ' 삭제처리 자리 표시
        For Each seat In seat_list_del
            Dim row = Asc(seat.Split(" ")(0)) - 65
            Dim col = Convert.ToInt32(seat.Split(" ")(1)) - 1

            Dim lb As New Label
            lb.AutoSize = False
            lb.Dock = DockStyle.Fill
            lb.Text = seat.Replace(" ", "")
            lb.Name = seat
            lb.Font = New Font("맑은 고딕", 9)
            lb.TextAlign = ContentAlignment.MiddleCenter
            lb.BackColor = Color.Red
            lb.ForeColor = Color.Gray
            lb.Margin = New Padding(6)
            AddHandler lb.Click, AddressOf seat_Click

            scr_seat_table.Controls.Add(lb, col, row)
        Next

        ' 생성 자리 표시
        For Each seat In seat_list_new
            Dim row = Asc(seat.Split(" ")(0)) - 65
            Dim col = Convert.ToInt32(seat.Split(" ")(1)) - 1

            Dim lb As New Label
            lb.AutoSize = False
            lb.Dock = DockStyle.Fill
            lb.Text = seat.Replace(" ", "")
            lb.Name = seat
            lb.Font = New Font("맑은 고딕", 9)
            lb.TextAlign = ContentAlignment.MiddleCenter
            lb.BackColor = Color.Green
            lb.ForeColor = Color.White
            lb.Margin = New Padding(6)
            AddHandler lb.Click, AddressOf seat_Click

            scr_seat_table.Controls.Add(lb, col, row)
        Next

        SeatSelectHightlightCheck()

    End Sub

    Private Sub seat_Click(sender As Object, e As EventArgs)
        Dim senderName As String = sender.Name
        Dim row = senderName.Split(" ")(0)
        Dim col = senderName.Split(" ")(1)
        For Each i As ListViewItem In SeatListView.Items
            If i.SubItems.Item(1).Text = row And i.SubItems.Item(2).Text = col Then
                i.Selected = Not i.Selected
            End If
        Next
    End Sub

    Private Sub SeatListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeatListView.SelectedIndexChanged
        SeatSelectHightlightCheck()
    End Sub

    Private Sub SeatSelectHightlightCheck()
        For Each i As ListViewItem In SeatListView.Items
            Dim row = Asc(i.SubItems.Item(1).Text) - 65
            Dim col = Convert.ToInt32(i.SubItems.Item(2).Text) - 1
            Dim ctrl As Label = scr_seat_table.GetControlFromPosition(col, row)

            If i.Selected Then
                ctrl.Font = New Font("맑은 고딕", 9, FontStyle.Bold)
                ctrl.Margin = New Padding(3)
            Else
                ctrl.Font = New Font("맑은 고딕", 9)
                ctrl.Margin = New Padding(6)
            End If
        Next
    End Sub

    Private Sub disable_bt_Click(sender As Object, e As EventArgs) Handles disable_bt.Click
        Dim new_flag As Boolean = False

        If SeatListView.SelectedItems.Count > 0 Then
            For Each i As ListViewItem In SeatListView.SelectedItems
                If i.SubItems.Item(4).Text = new_str Then
                    new_flag = True
                Else
                    i.SubItems.Item(4).Text = notav_str
                End If
            Next

            If new_flag Then
                MsgBox("새로 생성한 좌석은 상태를 바꿀 수 없습니다.", vbInformation)
            End If

            UpdateSeatInfo()
        End If
    End Sub

    Private Sub enable_bt_Click(sender As Object, e As EventArgs) Handles enable_bt.Click
        Dim new_flag As Boolean = False

        If SeatListView.SelectedItems.Count > 0 Then
            For Each i As ListViewItem In SeatListView.SelectedItems
                If i.SubItems.Item(4).Text = new_str Then
                    new_flag = True
                Else
                    i.SubItems.Item(4).Text = avail_str
                End If
            Next

            If new_flag Then
                MsgBox("새로 생성한 좌석은 상태를 바꿀 수 없습니다.", vbInformation)
            End If

            UpdateSeatInfo()
        End If
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If SeatListView.SelectedItems.Count > 0 Then
            For Each i As ListViewItem In SeatListView.SelectedItems

                Select Case i.SubItems.Item(4).Text
                    Case del_str
                        i.SubItems.Item(4).Text = avail_str
                    Case new_str
                        i.Remove()
                    Case Else
                        i.SubItems.Item(4).Text = del_str
                End Select
            Next

            UpdateSeatInfo()
        End If
    End Sub

    Private Sub add_seat_bt_Click(sender As Object, e As EventArgs) Handles add_seat_bt.Click
        Dim autotype As Boolean = False

        If seat_row_tb.Text = "" Then
            MsgBox("행 값을 입력해 주십시오", vbExclamation)
            Exit Sub
        ElseIf seat_row_tb.Text.Length > 1 Then
            MsgBox("행 값은 A~Z의 알파벳 1 자여야 합니다.", vbExclamation)
            Exit Sub
        End If

        seat_row_tb.Text = seat_row_tb.Text.ToUpper

        If Not (Asc(seat_row_tb.Text) >= 65 And Asc(seat_row_tb.Text) <= 90) Then
            MsgBox("행 값은 A~Z 사이의 알파벳이어야 합니다.", vbExclamation)
            Exit Sub
        End If

        If seat_col_tb.Text.Contains("!") Then
            autotype = True
            seat_col_tb.Text = seat_col_tb.Text.Replace("!", "")
        End If

        If seat_col_tb.Text = "" Then
            MsgBox("열 값을 입력해 주십시오", vbExclamation)
            Exit Sub
        ElseIf Not IsNumeric(seat_col_tb.Text) Then
            MsgBox("열 값은 정수여야 합니다.", vbExclamation)
            Exit Sub
        ElseIf Convert.ToInt32(seat_col_tb.Text) < 1 Then
            MsgBox("열 값은 0 이상의 정수여야 합니다.", vbExclamation)
            Exit Sub
        End If


        If autotype Then ' 자동 한줄 채우기 모드

            For col = 1 To Convert.ToInt32(seat_col_tb.Text)
                Dim row As String = seat_row_tb.Text
                Dim exists As Boolean = False

                For Each i As ListViewItem In SeatListView.Items
                    Dim isid As String = i.SubItems.Item(0).Text
                    Dim irow As String = i.SubItems.Item(1).Text
                    Dim icol As String = i.SubItems.Item(2).Text

                    If (row = irow) And (col.ToString = icol) Then exists = True
                Next

                If Not exists Then
                    SeatListView.Items.Add(New ListViewItem(New String() {"자동",
                                                            row,
                                                            col.ToString,
                                                            screen_id,
                                                            new_str})) '값 채우기
                End If
            Next

            seat_col_tb.Text = "!" + seat_col_tb.Text

        Else ' 단일 모드
            Dim row As String = seat_row_tb.Text
            Dim col As Integer = Convert.ToInt32(seat_col_tb.Text)

            For Each i As ListViewItem In SeatListView.Items
                Dim isid As String = i.SubItems.Item(0).Text
                Dim irow As String = i.SubItems.Item(1).Text
                Dim icol As String = i.SubItems.Item(2).Text

                If (row = irow) And (col.ToString = icol) Then
                    MsgBox("이미 해당 좌석이 존재합니다.", vbExclamation)
                    Exit Sub
                End If
            Next

            '통과했을시

            SeatListView.Items.Add(New ListViewItem(New String() {"자동",
                                                            row,
                                                            col.ToString,
                                                            screen_id,
                                                            new_str})) '값 채우기

        End If

        UpdateSeatInfo()
    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        If readonlymode Then
            Close()
            Exit Sub
        End If

        Dim sqlq = QueryBuilder()

        If sqlq.Contains("DELETE") Then
            If MsgBox("좌석 삭제 작업이 포함되어 있습니다. 해당 좌석이 이미 예약되어 있다면 삭제가 불가능하거나 오류가 발생할 수 있습니다." _
                      + vbCr + vbCr + "그래도 계속하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
                Exit Sub
            End If
        End If

        DB_OPEN(0)

        ' 좌석 조회 쿼리 실행
        Dim cmd As New MySqlCommand(sqlq, BP_CON(0))
        cmd.ExecuteNonQuery()

        MsgBox("적용되었습니다.", vbInformation)

        If Not listindex = -1 Then
            MainForm.ScrListView.Items(listindex).Selected = True
        End If

        MainForm.scr_update_seat_list()
        Close()

    End Sub

    Private Function QueryBuilder() As String

        Dim sqlq As String = ""
        Dim newexists As Boolean = False

        For Each i As ListViewItem In SeatListView.Items
            Dim sid As String = i.SubItems.Item(0).Text
            Dim row As String = i.SubItems.Item(1).Text
            Dim col As String = i.SubItems.Item(2).Text
            Dim avail As String = i.SubItems.Item(4).Text

            Select Case avail
                Case avail_str
                    sqlq += "UPDATE screen_seat SET available = 1 WHERE seat_id = " _
                        + sid + " AND seat_row = '" + row + "' AND seat_col = " + col _
                        + " AND screen_id = " + screen_id.ToString + " AND theater_id = '" + theater_id + "';" + vbCrLf

                Case notav_str
                    sqlq += "UPDATE screen_seat SET available = 0 WHERE seat_id = " _
                        + sid + " AND seat_row = '" + row + "' AND seat_col = " + col _
                        + " AND screen_id = " + screen_id.ToString + " AND theater_id = '" + theater_id + "';" + vbCrLf

                Case del_str
                    sqlq += "DELETE FROM screen_seat WHERE seat_id = " _
                        + sid + " AND seat_row = '" + row + "' AND seat_col = " + col _
                        + " AND screen_id = " + screen_id.ToString + " AND theater_id = '" + theater_id + "';" + vbCrLf

                Case new_str
                    newexists = True

            End Select
        Next

        If newexists Then

            sqlq += "INSERT INTO `screen_seat` (`seat_id`, `seat_row`, `seat_col`, `screen_id`, `theater_id`, `available`) VALUES " + vbCrLf

            For Each i As ListViewItem In SeatListView.Items
                Dim row As String = i.SubItems.Item(1).Text
                Dim col As String = i.SubItems.Item(2).Text
                Dim avail As String = i.SubItems.Item(4).Text

                If avail = new_str Then
                    sqlq += "(NULL, '" + row + "', " + col + ", " + screen_id.ToString + ", '" + theater_id + "', 1), "
                End If

            Next

            sqlq += "{END}"
            sqlq = sqlq.Replace(", {END}", ";")
        End If

        Return sqlq

    End Function
End Class