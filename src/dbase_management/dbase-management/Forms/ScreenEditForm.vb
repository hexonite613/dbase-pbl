Imports MySql.Data.MySqlClient

Public Class ScreenEditForm
    Public screenId As Integer = -1
    Public editmode As Boolean = True
    Public listindex As Integer = -1

    Dim scr_id, scr_name, theater_id, scr_type As String

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        If scr_id_tb.Text = "" Then
            MsgBox("상영관 ID를 입력하여 주십시오", vbCritical)
            Exit Sub
        ElseIf Not IsNumeric(scr_id_tb.Text) Then
            MsgBox("상영관 ID는 1 이상의 숫자여야 합니다", vbCritical)
            Exit Sub
        End If

        If theater_id_tb.Text = "" Then
            MsgBox("영화관 ID를 입력하여 주십시오", vbCritical)
            Exit Sub
        End If

        If scr_name_tb.Text = "" Then
            MsgBox("상영관명을 입력해 주십시오", vbCritical)
            Exit Sub
        End If

        If scr_type_cb.SelectedIndex = -1 Then
            MsgBox("상영방식을 지정해 주십시오", vbCritical)
            Exit Sub
        End If

        Dim done As Boolean = False

        Try
            done = ChkAndApplyQuery()
        Catch ex As Exception
            MsgBox("데이터 적용 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
            Exit Sub
        End Try

        If Not done Then Exit Sub

        MsgBox("적용되었습니다.", vbInformation)

        If Not listindex = -1 Then
            MainForm.ScrListView.Items(listindex).Selected = True
        End If

        MainForm.scr_update_list()
        MainForm.scr_update_seat_list()
        Close()

    End Sub

    Function ChkAndApplyQuery() As Boolean
        ' 키 유효성 체크
        Dim cmd As New MySqlCommand("SELECT count(*) FROM theater WHERE theater_id = ?tid", BP_CON(0))
        cmd.Parameters.AddWithValue("?tid", theater_id_tb.Text)

        ' 영화관 ID가 없을 경우
        If Not Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
            MsgBox("존재하지 않는 영화관 ID입니다. ID를 확인하여 주십시오.", vbExclamation)
            Return False
        End If

        ' 상영관 키 유효성 체크
        cmd.CommandText = "SELECT count(*) FROM screen WHERE screen_id = ?sid"
        cmd.Parameters.AddWithValue("?sid", scr_id_tb.Text)

        ' 상영관 키값이 이미 존재할 경우
        If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
            '그런데 그 ID가 편집하는 영화의 ID가 아닐 경우 (ID를 수정하는 경우)
            If Not screenId.ToString = scr_id_tb.Text Then
                MsgBox("중복되는 상영관 ID입니다. 다른 ID로 지정해 주세요.", vbExclamation)
                Return False
            End If
        End If

        ' 상영관명 중복 체크
        cmd.CommandText = "SELECT count(*) FROM screen WHERE theater_id = ?tid AND screen_name = ?sname AND NOT screen_id = ?sid"
        cmd.Parameters.AddWithValue("?sname", scr_name_tb.Text)

        ' 상영관명이 이미 존재할 경우
        If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
            If MsgBox("해당 영화관에 이미 존재하는 상영관명입니다" + vbCr + "그래도 계속하시겠습니까?", vbExclamation + vbYesNo) = vbNo Then
                Return False
            End If
        End If

        cmd.Parameters.AddWithValue("?stype", scr_type_cb.Text)

        If editmode Then
            cmd.CommandText = "UPDATE screen SET screen_id = ?sid, theater_id = ?tid, screen_name = ?sname, screen_type = ?stype
                               WHERE screen.screen_id = ?orgsid"
            cmd.Parameters.AddWithValue("?orgsid", screenId)
        Else
            cmd.CommandText = "INSERT INTO `screen` (`screen_id`, `theater_id`, `screen_name`, `screen_type`) VALUES (?sid, ?tid, ?sname, ?stype)"
        End If

        cmd.ExecuteNonQuery()

        Return True
    End Function

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If screenId = -1 Then
            MsgBox("영화가 선택되지 않았습니다", vbCritical)
        Else
            Dim ISQL = "Select * From screen WHERE screen_id=" + screenId.ToString
            Dim RS = GL_DB_READER(ISQL, 0)

            If RS.Read() = False Then
                RS.Close()
                MsgBox("해당 상영관이 존재하지 않습니다." + vbCr + "(이미 삭제되었을 수도 있습니다)", vbExclamation)
            Else
                If MsgBox(RS("screen_name") + vbCr + vbCr + "위 상영관을 정말로 삭제하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                    RS.Close()
                    ISQL = "DELETE FROM screen WHERE screen.screen_id = " + screenId.ToString

                    Try
                        RS = GL_DB_READER(ISQL, 0)
                        RS.Close()
                    Catch ex As Exception
                        MsgBox("삭제 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
                        RS.Close()
                        Exit Sub
                    End Try

                    MainForm.scr_update_list()
                    Close()
                Else
                    RS.Close()
                End If
            End If

        End If
    End Sub

    Private Sub getCurrentTheaterIDbt_Click(sender As Object, e As EventArgs) Handles getCurrentTheaterIDbt.Click
        theater_id_tb.Text = MainForm.theaterid
    End Sub

    Private Sub ScreenEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If editmode Then
            TitleLabel.Text = "상영관 정보 편집"
            Text = "상영관 정보 편집"
            DeleteBT.Enabled = True
            getScreenInfo()
        Else
            TitleLabel.Text = "상영관 추가"
            Text = "상영관 추가"
            DeleteBT.Enabled = False
        End If
    End Sub

    Private Sub getScreenInfo() 'DB로부터 정보 불러오기

        If Not MainForm.stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Close()
            Exit Sub
        End If

        '데이터 로드
        If editmode Then
            Dim ISQL = "Select * From screen WHERE screen_id = " + screenId.ToString
            Dim RS = GL_DB_READER(ISQL, 0)

            If RS.Read() = False Then
                RS.Close()
                MsgBox("DB로부터 상영관 정보를 찾을 수 없습니다", vbCritical)
                Close()
            Else
                scr_id = RS("screen_id")
                scr_name = RS("screen_name")
                theater_id = RS("theater_id")
                scr_type = RS("screen_type")
                RS.Close()

                scr_id_tb.Text = scr_id
                scr_name_tb.Text = scr_name
                theater_id_tb.Text = theater_id
                scr_type_cb.SelectedItem = scr_type

            End If
        End If
    End Sub
End Class