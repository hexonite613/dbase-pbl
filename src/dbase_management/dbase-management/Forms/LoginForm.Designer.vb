<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.db_address_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.db_id_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.db_pw_tb = New System.Windows.Forms.TextBox()
        Me.db_port_tb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.save_conn_chk = New System.Windows.Forms.CheckBox()
        Me.db_login_bt = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.db_conn_panel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SignUpBT = New System.Windows.Forms.Button()
        Me.staff_id_tb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save_acc_chk = New System.Windows.Forms.CheckBox()
        Me.user_login_bt = New System.Windows.Forms.Button()
        Me.staff_pw_tb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.db_conn_panel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(25)
        Me.Panel1.Size = New System.Drawing.Size(817, 86)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(674, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "로그인"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DBASE CINEMA 관리 시스템"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'db_address_tb
        '
        Me.db_address_tb.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.db_address_tb.Location = New System.Drawing.Point(135, 79)
        Me.db_address_tb.Name = "db_address_tb"
        Me.db_address_tb.Size = New System.Drawing.Size(155, 30)
        Me.db_address_tb.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(44, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "서버 주소"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(40, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DB 아이디"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'db_id_tb
        '
        Me.db_id_tb.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.db_id_tb.Location = New System.Drawing.Point(135, 115)
        Me.db_id_tb.Name = "db_id_tb"
        Me.db_id_tb.Size = New System.Drawing.Size(255, 30)
        Me.db_id_tb.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(40, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "패스워드"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'db_pw_tb
        '
        Me.db_pw_tb.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.db_pw_tb.Location = New System.Drawing.Point(135, 151)
        Me.db_pw_tb.Name = "db_pw_tb"
        Me.db_pw_tb.Size = New System.Drawing.Size(255, 30)
        Me.db_pw_tb.TabIndex = 6
        Me.db_pw_tb.UseSystemPasswordChar = True
        '
        'db_port_tb
        '
        Me.db_port_tb.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.db_port_tb.Location = New System.Drawing.Point(296, 79)
        Me.db_port_tb.Name = "db_port_tb"
        Me.db_port_tb.Size = New System.Drawing.Size(94, 30)
        Me.db_port_tb.TabIndex = 11
        Me.db_port_tb.Text = "3306"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 7.0!)
        Me.Label7.Location = New System.Drawing.Point(292, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "연결 포트*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'save_conn_chk
        '
        Me.save_conn_chk.AutoSize = True
        Me.save_conn_chk.Location = New System.Drawing.Point(259, 240)
        Me.save_conn_chk.Name = "save_conn_chk"
        Me.save_conn_chk.Size = New System.Drawing.Size(131, 24)
        Me.save_conn_chk.TabIndex = 9
        Me.save_conn_chk.Text = "연결 설정 저장"
        Me.save_conn_chk.UseVisualStyleBackColor = True
        '
        'db_login_bt
        '
        Me.db_login_bt.Location = New System.Drawing.Point(259, 270)
        Me.db_login_bt.Name = "db_login_bt"
        Me.db_login_bt.Size = New System.Drawing.Size(131, 46)
        Me.db_login_bt.TabIndex = 8
        Me.db_login_bt.Text = "연결"
        Me.db_login_bt.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.db_conn_panel)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(817, 352)
        Me.Panel2.TabIndex = 9
        '
        'db_conn_panel
        '
        Me.db_conn_panel.Controls.Add(Me.Label3)
        Me.db_conn_panel.Controls.Add(Me.Label10)
        Me.db_conn_panel.Controls.Add(Me.db_address_tb)
        Me.db_conn_panel.Controls.Add(Me.Label5)
        Me.db_conn_panel.Controls.Add(Me.Label9)
        Me.db_conn_panel.Controls.Add(Me.Label4)
        Me.db_conn_panel.Controls.Add(Me.db_port_tb)
        Me.db_conn_panel.Controls.Add(Me.db_pw_tb)
        Me.db_conn_panel.Controls.Add(Me.Label7)
        Me.db_conn_panel.Controls.Add(Me.db_id_tb)
        Me.db_conn_panel.Controls.Add(Me.save_conn_chk)
        Me.db_conn_panel.Controls.Add(Me.db_login_bt)
        Me.db_conn_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.db_conn_panel.Location = New System.Drawing.Point(0, 0)
        Me.db_conn_panel.Name = "db_conn_panel"
        Me.db_conn_panel.Size = New System.Drawing.Size(424, 352)
        Me.db_conn_panel.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("맑은 고딕", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(26, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "DB 연결"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 7.0!)
        Me.Label9.Location = New System.Drawing.Point(48, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(342, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "* 빈 칸은 기본값으로 설정됩니다"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.SignUpBT)
        Me.Panel3.Controls.Add(Me.staff_id_tb)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.save_acc_chk)
        Me.Panel3.Controls.Add(Me.user_login_bt)
        Me.Panel3.Controls.Add(Me.staff_pw_tb)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(424, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 352)
        Me.Panel3.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("맑은 고딕", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(34, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "로그인"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.dbase_management.My.Resources.Resources.right_mid
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(21, 352)
        Me.Panel4.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(27, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 30)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "직원 아이디"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SignUpBT
        '
        Me.SignUpBT.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SignUpBT.ForeColor = System.Drawing.Color.Black
        Me.SignUpBT.Location = New System.Drawing.Point(130, 152)
        Me.SignUpBT.Name = "SignUpBT"
        Me.SignUpBT.Size = New System.Drawing.Size(221, 69)
        Me.SignUpBT.TabIndex = 13
        Me.SignUpBT.Text = "계정이 없나요?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "관리 계정 발급하기"
        Me.SignUpBT.UseVisualStyleBackColor = True
        '
        'staff_id_tb
        '
        Me.staff_id_tb.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.staff_id_tb.Location = New System.Drawing.Point(130, 80)
        Me.staff_id_tb.Name = "staff_id_tb"
        Me.staff_id_tb.Size = New System.Drawing.Size(221, 30)
        Me.staff_id_tb.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(31, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 30)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "패스워드"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'save_acc_chk
        '
        Me.save_acc_chk.AutoSize = True
        Me.save_acc_chk.Location = New System.Drawing.Point(255, 240)
        Me.save_acc_chk.Name = "save_acc_chk"
        Me.save_acc_chk.Size = New System.Drawing.Size(96, 24)
        Me.save_acc_chk.TabIndex = 9
        Me.save_acc_chk.Text = "계정 저장"
        Me.save_acc_chk.UseVisualStyleBackColor = True
        '
        'user_login_bt
        '
        Me.user_login_bt.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.user_login_bt.Location = New System.Drawing.Point(130, 270)
        Me.user_login_bt.Name = "user_login_bt"
        Me.user_login_bt.Size = New System.Drawing.Size(221, 46)
        Me.user_login_bt.TabIndex = 8
        Me.user_login_bt.Text = "로그인"
        Me.user_login_bt.UseVisualStyleBackColor = True
        '
        'staff_pw_tb
        '
        Me.staff_pw_tb.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.staff_pw_tb.Location = New System.Drawing.Point(130, 116)
        Me.staff_pw_tb.Name = "staff_pw_tb"
        Me.staff_pw_tb.Size = New System.Drawing.Size(221, 30)
        Me.staff_pw_tb.TabIndex = 6
        Me.staff_pw_tb.UseSystemPasswordChar = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 438)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Global.dbase_management.My.Resources.Resources.mng_icon
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DCMS - 로그인"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.db_conn_panel.ResumeLayout(False)
        Me.db_conn_panel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents db_address_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents db_id_tb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents db_pw_tb As TextBox
    Friend WithEvents save_conn_chk As CheckBox
    Friend WithEvents db_login_bt As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents save_acc_chk As CheckBox
    Friend WithEvents user_login_bt As Button
    Friend WithEvents staff_pw_tb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents staff_id_tb As TextBox
    Friend WithEvents db_port_tb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SignUpBT As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents db_conn_panel As Panel
End Class
