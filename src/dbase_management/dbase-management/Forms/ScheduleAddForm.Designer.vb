<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleAddForm
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListResetBT = New System.Windows.Forms.Button()
        Me.ListSelectedRemoveBT = New System.Windows.Forms.Button()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SeeMovieDetailBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.movieTimeTB = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ListAddBT = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EndDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StartDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.movieRatingTB = New System.Windows.Forms.TextBox()
        Me.genreidTB = New System.Windows.Forms.TextBox()
        Me.movieEngNameTB = New System.Windows.Forms.TextBox()
        Me.movieNameTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PosterPB = New System.Windows.Forms.PictureBox()
        Me.movieidTB = New System.Windows.Forms.TextBox()
        Me.movieGetBT = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SetCurrentTheaterChk = New System.Windows.Forms.CheckBox()
        Me.screenCB = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.theaterIDTB = New System.Windows.Forms.TextBox()
        Me.TheaterCheckBT = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scr_seat_table = New System.Windows.Forms.TableLayoutPanel()
        Me.ScheduleAddList = New System.Windows.Forms.ListView()
        Me.col_scheadd_theater_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scheadd_scr_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scheadd_starttime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scheadd_endtime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scheadd_movie_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scheadd_movie_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PosterPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.ListResetBT)
        Me.Panel4.Controls.Add(Me.ListSelectedRemoveBT)
        Me.Panel4.Controls.Add(Me.SaveBT)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 789)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1220, 65)
        Me.Panel4.TabIndex = 10
        '
        'ListResetBT
        '
        Me.ListResetBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListResetBT.Location = New System.Drawing.Point(175, 14)
        Me.ListResetBT.Name = "ListResetBT"
        Me.ListResetBT.Size = New System.Drawing.Size(157, 39)
        Me.ListResetBT.TabIndex = 2
        Me.ListResetBT.Text = "목록 초기화"
        Me.ListResetBT.UseVisualStyleBackColor = True
        '
        'ListSelectedRemoveBT
        '
        Me.ListSelectedRemoveBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListSelectedRemoveBT.Location = New System.Drawing.Point(12, 14)
        Me.ListSelectedRemoveBT.Name = "ListSelectedRemoveBT"
        Me.ListSelectedRemoveBT.Size = New System.Drawing.Size(157, 39)
        Me.ListSelectedRemoveBT.TabIndex = 1
        Me.ListSelectedRemoveBT.Text = "선택 항목 지우기"
        Me.ListSelectedRemoveBT.UseVisualStyleBackColor = True
        '
        'SaveBT
        '
        Me.SaveBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBT.Location = New System.Drawing.Point(1051, 14)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(157, 39)
        Me.SaveBT.TabIndex = 0
        Me.SaveBT.Text = "저장"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(25)
        Me.Panel1.Size = New System.Drawing.Size(1220, 82)
        Me.Panel1.TabIndex = 9
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(25, 25)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(395, 32)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "상영 편성 추가"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SeeMovieDetailBT)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.movieTimeTB)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.EndDTP)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.StartDTP)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.movieRatingTB)
        Me.Panel3.Controls.Add(Me.genreidTB)
        Me.Panel3.Controls.Add(Me.movieEngNameTB)
        Me.Panel3.Controls.Add(Me.movieNameTB)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.PosterPB)
        Me.Panel3.Controls.Add(Me.movieidTB)
        Me.Panel3.Controls.Add(Me.movieGetBT)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1220, 481)
        Me.Panel3.TabIndex = 11
        '
        'SeeMovieDetailBT
        '
        Me.SeeMovieDetailBT.Location = New System.Drawing.Point(576, 283)
        Me.SeeMovieDetailBT.Name = "SeeMovieDetailBT"
        Me.SeeMovieDetailBT.Size = New System.Drawing.Size(161, 41)
        Me.SeeMovieDetailBT.TabIndex = 23
        Me.SeeMovieDetailBT.Text = "세부 정보 보기"
        Me.SeeMovieDetailBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "길이(분)"
        '
        'movieTimeTB
        '
        Me.movieTimeTB.Location = New System.Drawing.Point(99, 218)
        Me.movieTimeTB.Name = "movieTimeTB"
        Me.movieTimeTB.ReadOnly = True
        Me.movieTimeTB.Size = New System.Drawing.Size(159, 27)
        Me.movieTimeTB.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.ListAddBT)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 416)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(758, 65)
        Me.Panel6.TabIndex = 20
        '
        'ListAddBT
        '
        Me.ListAddBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListAddBT.Location = New System.Drawing.Point(589, 14)
        Me.ListAddBT.Name = "ListAddBT"
        Me.ListAddBT.Size = New System.Drawing.Size(157, 39)
        Me.ListAddBT.TabIndex = 0
        Me.ListAddBT.Text = "목록에 추가"
        Me.ListAddBT.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(26, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "종료 시간"
        '
        'EndDTP
        '
        Me.EndDTP.CalendarFont = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.EndDTP.CustomFormat = "yyyy년 MM월 dd일 HH:mm"
        Me.EndDTP.Enabled = False
        Me.EndDTP.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.EndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDTP.Location = New System.Drawing.Point(115, 358)
        Me.EndDTP.Name = "EndDTP"
        Me.EndDTP.Size = New System.Drawing.Size(256, 30)
        Me.EndDTP.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(26, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 23)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "시작 시간"
        '
        'StartDTP
        '
        Me.StartDTP.CalendarFont = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.StartDTP.CustomFormat = "yyyy년 MM월 dd일 HH:mm"
        Me.StartDTP.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.StartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDTP.Location = New System.Drawing.Point(115, 322)
        Me.StartDTP.Name = "StartDTP"
        Me.StartDTP.Size = New System.Drawing.Size(256, 30)
        Me.StartDTP.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(267, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 23)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "상영등급"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(26, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "장르(ID)"
        '
        'movieRatingTB
        '
        Me.movieRatingTB.Location = New System.Drawing.Point(353, 185)
        Me.movieRatingTB.Name = "movieRatingTB"
        Me.movieRatingTB.ReadOnly = True
        Me.movieRatingTB.Size = New System.Drawing.Size(152, 27)
        Me.movieRatingTB.TabIndex = 13
        '
        'genreidTB
        '
        Me.genreidTB.Location = New System.Drawing.Point(99, 185)
        Me.genreidTB.Name = "genreidTB"
        Me.genreidTB.ReadOnly = True
        Me.genreidTB.Size = New System.Drawing.Size(159, 27)
        Me.genreidTB.TabIndex = 12
        '
        'movieEngNameTB
        '
        Me.movieEngNameTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.movieEngNameTB.Location = New System.Drawing.Point(99, 152)
        Me.movieEngNameTB.Name = "movieEngNameTB"
        Me.movieEngNameTB.ReadOnly = True
        Me.movieEngNameTB.Size = New System.Drawing.Size(450, 27)
        Me.movieEngNameTB.TabIndex = 11
        '
        'movieNameTB
        '
        Me.movieNameTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.movieNameTB.Location = New System.Drawing.Point(99, 119)
        Me.movieNameTB.Name = "movieNameTB"
        Me.movieNameTB.ReadOnly = True
        Me.movieNameTB.Size = New System.Drawing.Size(450, 27)
        Me.movieNameTB.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "영문명"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(26, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "영화명"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(572, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "포스터"
        '
        'PosterPB
        '
        Me.PosterPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PosterPB.Location = New System.Drawing.Point(576, 51)
        Me.PosterPB.Name = "PosterPB"
        Me.PosterPB.Size = New System.Drawing.Size(161, 226)
        Me.PosterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PosterPB.TabIndex = 6
        Me.PosterPB.TabStop = False
        '
        'movieidTB
        '
        Me.movieidTB.Location = New System.Drawing.Point(99, 74)
        Me.movieidTB.Name = "movieidTB"
        Me.movieidTB.Size = New System.Drawing.Size(272, 27)
        Me.movieidTB.TabIndex = 5
        '
        'movieGetBT
        '
        Me.movieGetBT.Location = New System.Drawing.Point(377, 73)
        Me.movieGetBT.Name = "movieGetBT"
        Me.movieGetBT.Size = New System.Drawing.Size(85, 29)
        Me.movieGetBT.TabIndex = 4
        Me.movieGetBT.Text = "조회"
        Me.movieGetBT.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(26, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "영화 ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕 Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "시간"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕 Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "영화"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.SetCurrentTheaterChk)
        Me.Panel2.Controls.Add(Me.screenCB)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.theaterIDTB)
        Me.Panel2.Controls.Add(Me.TheaterCheckBT)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(758, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(462, 481)
        Me.Panel2.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(15, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 23)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "좌석 배치도"
        '
        'SetCurrentTheaterChk
        '
        Me.SetCurrentTheaterChk.AutoSize = True
        Me.SetCurrentTheaterChk.Location = New System.Drawing.Point(261, 29)
        Me.SetCurrentTheaterChk.Name = "SetCurrentTheaterChk"
        Me.SetCurrentTheaterChk.Size = New System.Drawing.Size(176, 24)
        Me.SetCurrentTheaterChk.TabIndex = 11
        Me.SetCurrentTheaterChk.Text = "현재 상영관으로 설정"
        Me.SetCurrentTheaterChk.UseVisualStyleBackColor = True
        '
        'screenCB
        '
        Me.screenCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.screenCB.FormattingEnabled = True
        Me.screenCB.Location = New System.Drawing.Point(90, 92)
        Me.screenCB.Name = "screenCB"
        Me.screenCB.Size = New System.Drawing.Size(256, 28)
        Me.screenCB.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(15, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 23)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "상영관"
        '
        'theaterIDTB
        '
        Me.theaterIDTB.Location = New System.Drawing.Point(90, 59)
        Me.theaterIDTB.Name = "theaterIDTB"
        Me.theaterIDTB.Size = New System.Drawing.Size(256, 27)
        Me.theaterIDTB.TabIndex = 8
        '
        'TheaterCheckBT
        '
        Me.TheaterCheckBT.Location = New System.Drawing.Point(352, 57)
        Me.TheaterCheckBT.Name = "TheaterCheckBT"
        Me.TheaterCheckBT.Size = New System.Drawing.Size(85, 29)
        Me.TheaterCheckBT.TabIndex = 7
        Me.TheaterCheckBT.Text = "조회"
        Me.TheaterCheckBT.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(15, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 23)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "지점 ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕 Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "상영관"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.scr_seat_table)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 177)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(462, 304)
        Me.Panel5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(138, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "S C R E E N"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scr_seat_table
        '
        Me.scr_seat_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_seat_table.BackColor = System.Drawing.Color.Transparent
        Me.scr_seat_table.ColumnCount = 1
        Me.scr_seat_table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scr_seat_table.Location = New System.Drawing.Point(19, 63)
        Me.scr_seat_table.Margin = New System.Windows.Forms.Padding(0)
        Me.scr_seat_table.Name = "scr_seat_table"
        Me.scr_seat_table.RowCount = 1
        Me.scr_seat_table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scr_seat_table.Size = New System.Drawing.Size(418, 209)
        Me.scr_seat_table.TabIndex = 26
        '
        'ScheduleAddList
        '
        Me.ScheduleAddList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_scheadd_theater_id, Me.col_scheadd_scr_id, Me.col_scheadd_starttime, Me.col_scheadd_endtime, Me.col_scheadd_movie_id, Me.col_scheadd_movie_name})
        Me.ScheduleAddList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduleAddList.FullRowSelect = True
        Me.ScheduleAddList.HideSelection = False
        Me.ScheduleAddList.Location = New System.Drawing.Point(0, 563)
        Me.ScheduleAddList.Name = "ScheduleAddList"
        Me.ScheduleAddList.Size = New System.Drawing.Size(1220, 226)
        Me.ScheduleAddList.TabIndex = 12
        Me.ScheduleAddList.UseCompatibleStateImageBehavior = False
        Me.ScheduleAddList.View = System.Windows.Forms.View.Details
        '
        'col_scheadd_theater_id
        '
        Me.col_scheadd_theater_id.Text = "지점 ID"
        Me.col_scheadd_theater_id.Width = 78
        '
        'col_scheadd_scr_id
        '
        Me.col_scheadd_scr_id.Text = "상영관 ID"
        Me.col_scheadd_scr_id.Width = 100
        '
        'col_scheadd_starttime
        '
        Me.col_scheadd_starttime.Text = "시작 시간"
        Me.col_scheadd_starttime.Width = 209
        '
        'col_scheadd_endtime
        '
        Me.col_scheadd_endtime.Text = "종료 시간"
        Me.col_scheadd_endtime.Width = 217
        '
        'col_scheadd_movie_id
        '
        Me.col_scheadd_movie_id.Text = "영화 ID"
        Me.col_scheadd_movie_id.Width = 87
        '
        'col_scheadd_movie_name
        '
        Me.col_scheadd_movie_name.Text = "영화명"
        Me.col_scheadd_movie_name.Width = 415
        '
        'ScheduleAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1220, 854)
        Me.Controls.Add(Me.ScheduleAddList)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Icon = Global.dbase_management.My.Resources.Resources.mng_icon
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScheduleAddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "상영 편성 추가"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PosterPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents SaveBT As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ScheduleAddList As ListView
    Friend WithEvents col_scheadd_theater_id As ColumnHeader
    Friend WithEvents col_scheadd_scr_id As ColumnHeader
    Friend WithEvents col_scheadd_starttime As ColumnHeader
    Friend WithEvents col_scheadd_endtime As ColumnHeader
    Friend WithEvents col_scheadd_movie_id As ColumnHeader
    Friend WithEvents col_scheadd_movie_name As ColumnHeader
    Friend WithEvents movieRatingTB As TextBox
    Friend WithEvents genreidTB As TextBox
    Friend WithEvents movieEngNameTB As TextBox
    Friend WithEvents movieNameTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PosterPB As PictureBox
    Friend WithEvents movieidTB As TextBox
    Friend WithEvents movieGetBT As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents scr_seat_table As TableLayoutPanel
    Friend WithEvents ListResetBT As Button
    Friend WithEvents ListSelectedRemoveBT As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListAddBT As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents EndDTP As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents StartDTP As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents screenCB As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents theaterIDTB As TextBox
    Friend WithEvents TheaterCheckBT As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents SetCurrentTheaterChk As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents movieTimeTB As TextBox
    Friend WithEvents SeeMovieDetailBT As Button
End Class
