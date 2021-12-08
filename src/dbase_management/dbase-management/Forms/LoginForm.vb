Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim db_verified As Boolean = False
    Public loggedin As Boolean = False

    Private Sub db_login_bt_Click(sender As Object, e As EventArgs) Handles db_login_bt.Click

        '기존 연결 끊기
        DB_CLOSE(0)

        Dim port As Integer = 3306

        If db_verified Then '이미 연결완료된 상태라면
            db_verified = False

        Else

            If db_address_tb.Text = "" Then
                MsgBox("DB 주소를 입력해 주십시오", vbCritical)
                Exit Sub
            End If

            If Not db_port_tb.Text = "" Then
                If Not IsNumeric(db_port_tb.Text) Then
                    MsgBox("DB 포트를 올바르게 입력해 주십시오", vbCritical)
                    Exit Sub
                Else
                    port = Convert.ToInt32(db_port_tb.Text)
                End If
            End If

            If db_id_tb.Text = "" Then
                MsgBox("DB 아이디를 입력해 주십시오", vbCritical)
                Exit Sub
            End If

            If db_pw_tb.Text = "" Then
                MsgBox("DB 패스워드를 입력해 주십시오", vbCritical)
                Exit Sub
            End If


            DB_INITIATE("dbase", db_address_tb.Text, port.ToString, db_id_tb.Text, db_pw_tb.Text)

            Dim ISQL = "SELECT * FROM movie"
            Dim RS As MySqlDataReader

            Try
                RS = GL_DB_READER(ISQL, 0)
            Catch ex As Exception
                db_verified = False
                MsgBox("DB 연결에 실패하였습니다." + vbCr + "(" + ex.Message + ")", vbCritical)
                Exit Sub
            End Try

            If RS.Read() = False Then
                RS.Close()
                MsgBox("DB로부터 테이블을 찾을 수 없습니다", vbCritical)
                Close()
            Else
                RS.Close()
                db_verified = True
                MsgBox("연결에 성공하였습니다", vbInformation)

                '연결 성공시
                If save_conn_chk.Checked Then
                    My.Settings.saveconn = True
                    My.Settings.db_address = db_address_tb.Text
                    My.Settings.db_port = port
                    My.Settings.db_id = db_id_tb.Text
                    My.Settings.db_pw = db_pw_tb.Text
                    My.Settings.Save()
                    My.Settings.Reload()
                End If

            End If
        End If

        DB_Conn_Initiate()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles user_login_bt.Click
        loggedin = false
        If db_verified Then
            Try
                DB_OPEN(0)

                Dim cmd As New MySqlCommand("SELECT * FROM staff WHERE id = ?id AND pwd = ?pwd", BP_CON(0))
                cmd.Parameters.AddWithValue("?id", staff_id_tb.Text)
                cmd.Parameters.AddWithValue("?pwd", GenerateSHA256String(staff_pw_tb.Text).ToLower)

                Dim RS = cmd.ExecuteReader

                'ID가 존재하는 경우
                If RS.Read() = False Then
                    MsgBox("존재하지 않는 ID이거나 잘못된 비밀번호 입니다.", vbCritical)
                Else
                    '로그인 성공시
                    loggedin = True

                    If save_acc_chk.Checked Then
                        My.Settings.saveacc = True
                        My.Settings.user_id = staff_id_tb.Text
                        My.Settings.user_pw = staff_pw_tb.Text
                        My.Settings.Save()
                        My.Settings.Reload()
                    End If

                    Dim name = RS("name").ToString
                    Dim id = RS("id").ToString
                    Dim tid = RS("theater_id").ToString
                    Dim stype = RS("staff_type").ToString
                    Dim tname = ""

                    cmd.Connection.Close()

                    DB_OPEN(0)

                    Try
                        cmd = New MySqlCommand("SELECT * FROM theater WHERE theater_id = ?tid", BP_CON(0))
                        cmd.Parameters.AddWithValue("?tid", tid)
                        RS = cmd.ExecuteReader

                        If RS.Read() = False Then
                            MsgBox("영화관 정보 검색에 실패하였습니다", vbCritical)
                        Else
                            tname = RS("theater_name")
                        End If
                    Catch ex As Exception
                        MsgBox("영화관 정보 조회에 실패하였습니다", vbCritical)
                    End Try

                    MainForm.username = name
                    MainForm.userid = id
                    MainForm.theater = tname
                    MainForm.theaterid = tid
                    MainForm.stafftype = stype

                    MainForm.Show()
                    Hide()
                End If

                cmd.Connection.Close()


            Catch ex As Exception
                MsgBox("로그인 시도 도중 문제가 발생했습니다." + vbCr + "(" + ex.Message + ")", vbCritical)
            End Try

        Else
            MsgBox("DB 연결 설정이 되어있지 않습니다", vbCritical)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.saveconn Then '이미 저장된 연결설정이 있을 경우
            save_conn_chk.Checked = True
            db_address_tb.Text = My.Settings.db_address
            db_port_tb.Text = My.Settings.db_port
            db_id_tb.Text = My.Settings.db_id
            db_pw_tb.Text = My.Settings.db_pw

            db_verified = True

            '이미 저장된 값이므로 유효성 체크는 PASS
            DB_INITIATE("dbase", My.Settings.db_address, My.Settings.db_port, My.Settings.db_id, My.Settings.db_pw)

            Dim ISQL = "SELECT * FROM movie"
            Dim RS As MySqlDataReader

            Try
                RS = GL_DB_READER(ISQL, 0)
                RS.Close()
            Catch ex As Exception
                db_verified = False
                MsgBox("DB 연결에 실패하였습니다." + vbCr + "(" + ex.Message + ")", vbCritical)
            End Try

            DB_Conn_Initiate()
        End If

        If My.Settings.saveacc Then
            save_acc_chk.Checked = True
            staff_id_tb.Text = My.Settings.user_id
            staff_pw_tb.Text = My.Settings.user_pw
        End If
    End Sub

    Private Sub DB_Conn_Initiate()
        If db_verified Then
            db_address_tb.Enabled = False
            db_port_tb.Enabled = False
            db_id_tb.Enabled = False
            db_pw_tb.Enabled = False

            db_login_bt.Text = "변경"

        Else
            db_address_tb.Enabled = True
            db_port_tb.Enabled = True
            db_id_tb.Enabled = True
            db_pw_tb.Enabled = True

            db_login_bt.Text = "연결"

        End If
    End Sub

    Private Sub save_conn_chk_CheckedChanged(sender As Object, e As EventArgs) Handles save_conn_chk.CheckedChanged
        My.Settings.saveconn = save_conn_chk.Checked
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub save_acc_chk_CheckedChanged(sender As Object, e As EventArgs) Handles save_acc_chk.CheckedChanged
        My.Settings.saveacc = save_acc_chk.Checked
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub SignUpBT_Click(sender As Object, e As EventArgs) Handles SignUpBT.Click
        Process.Start("http://dbase.kro.kr/staffregister")
    End Sub
End Class