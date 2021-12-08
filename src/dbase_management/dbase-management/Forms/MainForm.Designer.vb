<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.LogoutBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModeSelectMenuPanel = New System.Windows.Forms.Panel()
        Me.ModeFacilBT = New System.Windows.Forms.PictureBox()
        Me.ModeStaffBT = New System.Windows.Forms.PictureBox()
        Me.ModeScheduleBT = New System.Windows.Forms.PictureBox()
        Me.ModePurchaseBT = New System.Windows.Forms.PictureBox()
        Me.ModeScreenBT = New System.Windows.Forms.PictureBox()
        Me.ModeFilmBT = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel_Purchase = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.pur_seat_bt = New System.Windows.Forms.Button()
        Me.pur_showcurrtheater_chk = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pur_time_end_dtp = New System.Windows.Forms.DateTimePicker()
        Me.pur_time_start_dtp = New System.Windows.Forms.DateTimePicker()
        Me.pur_del_bt = New System.Windows.Forms.Button()
        Me.pur_listupdatetime_label = New System.Windows.Forms.Label()
        Me.pur_view_bt = New System.Windows.Forms.Button()
        Me.PurchaseListView = New System.Windows.Forms.ListView()
        Me.col_purchase_num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_sche_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_seat_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_pay_price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_pay_method = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_purchase_phonenum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pur_update_bt = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel_Film = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.film_filter_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.film_listupdatetime_label = New System.Windows.Forms.Label()
        Me.film_addBT = New System.Windows.Forms.Button()
        Me.film_nextpage_bt = New System.Windows.Forms.Button()
        Me.film_prevpage_bt = New System.Windows.Forms.Button()
        Me.film_curpage_tb = New System.Windows.Forms.TextBox()
        Me.film_totalpage_label = New System.Windows.Forms.Label()
        Me.FilmListView = New System.Windows.Forms.ListView()
        Me.film_col_movie_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_gerne_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_name_eng = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_movie_time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_release_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_rating = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_col_poster = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.film_update_bt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FilmDetailPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.filminfo_country_tb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.filminfo_time_tb = New System.Windows.Forms.TextBox()
        Me.filminfo_release_date_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.filminfo_rating_cb = New System.Windows.Forms.ComboBox()
        Me.filminfo_name_eng_tb = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.filminfo_id_tb = New System.Windows.Forms.TextBox()
        Me.filminfo_genre_id_cb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.filminfo_name_tb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.filminfo_description_tb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.filminfo_poster_pb = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.film_removeBT = New System.Windows.Forms.Button()
        Me.film_editBT = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_Schedule = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.sche_showcurrtheater_chk = New System.Windows.Forms.CheckBox()
        Me.sche_filter_tb = New System.Windows.Forms.TextBox()
        Me.sche_scr_filter_cb = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.sche_time_end_dtp = New System.Windows.Forms.DateTimePicker()
        Me.sche_time_start_dtp = New System.Windows.Forms.DateTimePicker()
        Me.sche_edit_bt = New System.Windows.Forms.Button()
        Me.sche_listupdatetime_label = New System.Windows.Forms.Label()
        Me.sche_add_bt = New System.Windows.Forms.Button()
        Me.ScheListView = New System.Windows.Forms.ListView()
        Me.col_sche_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_scr_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_theater_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_movie_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_movie_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_movie_name_eng = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_start_time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_end_time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sche_runtime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sche_update_bt = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel_Screen = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.scr_edit_bt = New System.Windows.Forms.Button()
        Me.scr_listupdatetime_label = New System.Windows.Forms.Label()
        Me.scr_add_bt = New System.Windows.Forms.Button()
        Me.scr_nextpage_bt = New System.Windows.Forms.Button()
        Me.scr_prevpage_bt = New System.Windows.Forms.Button()
        Me.scr_curpage_tb = New System.Windows.Forms.TextBox()
        Me.scr_totalpage_label = New System.Windows.Forms.Label()
        Me.ScrListView = New System.Windows.Forms.ListView()
        Me.col_scr_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_theater_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_theater_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scr_update_bt = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.scr_seat_table = New System.Windows.Forms.TableLayoutPanel()
        Me.scr_seat_edit_bt = New System.Windows.Forms.Button()
        Me.SeatListView = New System.Windows.Forms.ListView()
        Me.col_scr_seat_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_row = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_col = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_sid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_tid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_available = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.col_purchase_scr_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.ModeSelectMenuPanel.SuspendLayout()
        CType(Me.ModeFacilBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeStaffBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeScheduleBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePurchaseBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeScreenBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeFilmBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.Panel_Purchase.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel_Film.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FilmDetailPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.filminfo_poster_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel_Schedule.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel_Screen.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.UserLabel)
        Me.Panel1.Controls.Add(Me.LogoutBT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(25)
        Me.Panel1.Size = New System.Drawing.Size(1231, 86)
        Me.Panel1.TabIndex = 0
        '
        'UserLabel
        '
        Me.UserLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserLabel.Font = New System.Drawing.Font("맑은 고딕 Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.UserLabel.ForeColor = System.Drawing.Color.White
        Me.UserLabel.Location = New System.Drawing.Point(359, 25)
        Me.UserLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(736, 36)
        Me.UserLabel.TabIndex = 1
        Me.UserLabel.Text = "user 님 (theater점)"
        Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LogoutBT
        '
        Me.LogoutBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.LogoutBT.Location = New System.Drawing.Point(1095, 25)
        Me.LogoutBT.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoutBT.Name = "LogoutBT"
        Me.LogoutBT.Size = New System.Drawing.Size(111, 36)
        Me.LogoutBT.TabIndex = 2
        Me.LogoutBT.Text = "로그아웃"
        Me.LogoutBT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DBASE CINEMA 관리 시스템"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModeSelectMenuPanel
        '
        Me.ModeSelectMenuPanel.AutoScroll = True
        Me.ModeSelectMenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ModeSelectMenuPanel.Controls.Add(Me.ModeFacilBT)
        Me.ModeSelectMenuPanel.Controls.Add(Me.ModeStaffBT)
        Me.ModeSelectMenuPanel.Controls.Add(Me.ModeScheduleBT)
        Me.ModeSelectMenuPanel.Controls.Add(Me.ModePurchaseBT)
        Me.ModeSelectMenuPanel.Controls.Add(Me.ModeScreenBT)
        Me.ModeSelectMenuPanel.Controls.Add(Me.ModeFilmBT)
        Me.ModeSelectMenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ModeSelectMenuPanel.Location = New System.Drawing.Point(0, 86)
        Me.ModeSelectMenuPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeSelectMenuPanel.Name = "ModeSelectMenuPanel"
        Me.ModeSelectMenuPanel.Size = New System.Drawing.Size(129, 654)
        Me.ModeSelectMenuPanel.TabIndex = 1
        '
        'ModeFacilBT
        '
        Me.ModeFacilBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModeFacilBT.Image = Global.dbase_management.My.Resources.Resources.menu_facil
        Me.ModeFacilBT.Location = New System.Drawing.Point(0, 580)
        Me.ModeFacilBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeFacilBT.Name = "ModeFacilBT"
        Me.ModeFacilBT.Size = New System.Drawing.Size(108, 116)
        Me.ModeFacilBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModeFacilBT.TabIndex = 5
        Me.ModeFacilBT.TabStop = False
        '
        'ModeStaffBT
        '
        Me.ModeStaffBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModeStaffBT.Image = Global.dbase_management.My.Resources.Resources.menu_staff
        Me.ModeStaffBT.Location = New System.Drawing.Point(0, 464)
        Me.ModeStaffBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeStaffBT.Name = "ModeStaffBT"
        Me.ModeStaffBT.Size = New System.Drawing.Size(108, 116)
        Me.ModeStaffBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModeStaffBT.TabIndex = 4
        Me.ModeStaffBT.TabStop = False
        '
        'ModeScheduleBT
        '
        Me.ModeScheduleBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModeScheduleBT.Image = Global.dbase_management.My.Resources.Resources.menu_arr
        Me.ModeScheduleBT.Location = New System.Drawing.Point(0, 348)
        Me.ModeScheduleBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeScheduleBT.Name = "ModeScheduleBT"
        Me.ModeScheduleBT.Size = New System.Drawing.Size(108, 116)
        Me.ModeScheduleBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModeScheduleBT.TabIndex = 3
        Me.ModeScheduleBT.TabStop = False
        '
        'ModePurchaseBT
        '
        Me.ModePurchaseBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModePurchaseBT.Image = Global.dbase_management.My.Resources.Resources.menu_pay
        Me.ModePurchaseBT.Location = New System.Drawing.Point(0, 232)
        Me.ModePurchaseBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ModePurchaseBT.Name = "ModePurchaseBT"
        Me.ModePurchaseBT.Size = New System.Drawing.Size(108, 116)
        Me.ModePurchaseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModePurchaseBT.TabIndex = 2
        Me.ModePurchaseBT.TabStop = False
        '
        'ModeScreenBT
        '
        Me.ModeScreenBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModeScreenBT.Image = Global.dbase_management.My.Resources.Resources.menu_screen
        Me.ModeScreenBT.Location = New System.Drawing.Point(0, 116)
        Me.ModeScreenBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeScreenBT.Name = "ModeScreenBT"
        Me.ModeScreenBT.Size = New System.Drawing.Size(108, 116)
        Me.ModeScreenBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModeScreenBT.TabIndex = 1
        Me.ModeScreenBT.TabStop = False
        '
        'ModeFilmBT
        '
        Me.ModeFilmBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModeFilmBT.Image = Global.dbase_management.My.Resources.Resources.menu_film
        Me.ModeFilmBT.Location = New System.Drawing.Point(0, 0)
        Me.ModeFilmBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeFilmBT.Name = "ModeFilmBT"
        Me.ModeFilmBT.Size = New System.Drawing.Size(108, 116)
        Me.ModeFilmBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModeFilmBT.TabIndex = 0
        Me.ModeFilmBT.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel_Purchase)
        Me.MainPanel.Controls.Add(Me.Panel_Film)
        Me.MainPanel.Controls.Add(Me.Panel_Schedule)
        Me.MainPanel.Controls.Add(Me.Panel_Screen)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(129, 86)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1102, 654)
        Me.MainPanel.TabIndex = 3
        '
        'Panel_Purchase
        '
        Me.Panel_Purchase.Controls.Add(Me.Panel11)
        Me.Panel_Purchase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Purchase.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Purchase.Name = "Panel_Purchase"
        Me.Panel_Purchase.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
        Me.Panel_Purchase.Size = New System.Drawing.Size(1102, 654)
        Me.Panel_Purchase.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.pur_seat_bt)
        Me.Panel11.Controls.Add(Me.pur_showcurrtheater_chk)
        Me.Panel11.Controls.Add(Me.Label19)
        Me.Panel11.Controls.Add(Me.Label20)
        Me.Panel11.Controls.Add(Me.pur_time_end_dtp)
        Me.Panel11.Controls.Add(Me.pur_time_start_dtp)
        Me.Panel11.Controls.Add(Me.pur_del_bt)
        Me.Panel11.Controls.Add(Me.pur_listupdatetime_label)
        Me.Panel11.Controls.Add(Me.pur_view_bt)
        Me.Panel11.Controls.Add(Me.PurchaseListView)
        Me.Panel11.Controls.Add(Me.pur_update_bt)
        Me.Panel11.Controls.Add(Me.Label23)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(20, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(1062, 624)
        Me.Panel11.TabIndex = 7
        '
        'pur_seat_bt
        '
        Me.pur_seat_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pur_seat_bt.Location = New System.Drawing.Point(936, 556)
        Me.pur_seat_bt.Name = "pur_seat_bt"
        Me.pur_seat_bt.Size = New System.Drawing.Size(118, 60)
        Me.pur_seat_bt.TabIndex = 31
        Me.pur_seat_bt.Text = "좌석 조회"
        Me.pur_seat_bt.UseVisualStyleBackColor = True
        '
        'pur_showcurrtheater_chk
        '
        Me.pur_showcurrtheater_chk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pur_showcurrtheater_chk.AutoSize = True
        Me.pur_showcurrtheater_chk.Checked = True
        Me.pur_showcurrtheater_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pur_showcurrtheater_chk.Location = New System.Drawing.Point(391, 594)
        Me.pur_showcurrtheater_chk.Name = "pur_showcurrtheater_chk"
        Me.pur_showcurrtheater_chk.Size = New System.Drawing.Size(181, 24)
        Me.pur_showcurrtheater_chk.TabIndex = 30
        Me.pur_showcurrtheater_chk.Text = "현재 지점 결제만 보기"
        Me.pur_showcurrtheater_chk.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(213, 594)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 20)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "까지"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(213, 561)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 20)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "부터"
        '
        'pur_time_end_dtp
        '
        Me.pur_time_end_dtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pur_time_end_dtp.Location = New System.Drawing.Point(9, 589)
        Me.pur_time_end_dtp.Name = "pur_time_end_dtp"
        Me.pur_time_end_dtp.Size = New System.Drawing.Size(198, 27)
        Me.pur_time_end_dtp.TabIndex = 25
        '
        'pur_time_start_dtp
        '
        Me.pur_time_start_dtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pur_time_start_dtp.Location = New System.Drawing.Point(9, 556)
        Me.pur_time_start_dtp.Name = "pur_time_start_dtp"
        Me.pur_time_start_dtp.Size = New System.Drawing.Size(198, 27)
        Me.pur_time_start_dtp.TabIndex = 24
        '
        'pur_del_bt
        '
        Me.pur_del_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pur_del_bt.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.pur_del_bt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pur_del_bt.Location = New System.Drawing.Point(690, 556)
        Me.pur_del_bt.Name = "pur_del_bt"
        Me.pur_del_bt.Size = New System.Drawing.Size(116, 60)
        Me.pur_del_bt.TabIndex = 23
        Me.pur_del_bt.Text = "결제 취소"
        Me.pur_del_bt.UseVisualStyleBackColor = True
        '
        'pur_listupdatetime_label
        '
        Me.pur_listupdatetime_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pur_listupdatetime_label.Font = New System.Drawing.Font("맑은 고딕", 8.0!)
        Me.pur_listupdatetime_label.ForeColor = System.Drawing.Color.Gray
        Me.pur_listupdatetime_label.Location = New System.Drawing.Point(875, 0)
        Me.pur_listupdatetime_label.Name = "pur_listupdatetime_label"
        Me.pur_listupdatetime_label.Size = New System.Drawing.Size(179, 46)
        Me.pur_listupdatetime_label.TabIndex = 22
        Me.pur_listupdatetime_label.Text = "업데이트 되지 않음"
        Me.pur_listupdatetime_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pur_view_bt
        '
        Me.pur_view_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pur_view_bt.Location = New System.Drawing.Point(812, 556)
        Me.pur_view_bt.Name = "pur_view_bt"
        Me.pur_view_bt.Size = New System.Drawing.Size(118, 60)
        Me.pur_view_bt.TabIndex = 21
        Me.pur_view_bt.Text = "편성 조회"
        Me.pur_view_bt.UseVisualStyleBackColor = True
        '
        'PurchaseListView
        '
        Me.PurchaseListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurchaseListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_purchase_num, Me.col_purchase_id, Me.col_purchase_sche_id, Me.col_purchase_scr_id, Me.col_purchase_seat_id, Me.col_purchase_time, Me.col_purchase_pay_price, Me.col_purchase_type, Me.col_purchase_pay_method, Me.col_purchase_phonenum})
        Me.PurchaseListView.FullRowSelect = True
        Me.PurchaseListView.HideSelection = False
        Me.PurchaseListView.Location = New System.Drawing.Point(8, 47)
        Me.PurchaseListView.MultiSelect = False
        Me.PurchaseListView.Name = "PurchaseListView"
        Me.PurchaseListView.Size = New System.Drawing.Size(1046, 503)
        Me.PurchaseListView.TabIndex = 3
        Me.PurchaseListView.UseCompatibleStateImageBehavior = False
        Me.PurchaseListView.View = System.Windows.Forms.View.Details
        '
        'col_purchase_num
        '
        Me.col_purchase_num.Text = "결제번호"
        Me.col_purchase_num.Width = 79
        '
        'col_purchase_id
        '
        Me.col_purchase_id.Text = "ID"
        Me.col_purchase_id.Width = 118
        '
        'col_purchase_sche_id
        '
        Me.col_purchase_sche_id.Text = "편성 ID"
        Me.col_purchase_sche_id.Width = 90
        '
        'col_purchase_seat_id
        '
        Me.col_purchase_seat_id.Text = "좌석 ID"
        Me.col_purchase_seat_id.Width = 94
        '
        'col_purchase_time
        '
        Me.col_purchase_time.Text = "결제 시간"
        Me.col_purchase_time.Width = 170
        '
        'col_purchase_pay_price
        '
        Me.col_purchase_pay_price.Text = "결제 금액"
        Me.col_purchase_pay_price.Width = 161
        '
        'col_purchase_type
        '
        Me.col_purchase_type.Text = "종류"
        Me.col_purchase_type.Width = 112
        '
        'col_purchase_pay_method
        '
        Me.col_purchase_pay_method.Text = "결제 방식"
        Me.col_purchase_pay_method.Width = 83
        '
        'col_purchase_phonenum
        '
        Me.col_purchase_phonenum.Text = "전화번호"
        Me.col_purchase_phonenum.Width = 131
        '
        'pur_update_bt
        '
        Me.pur_update_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pur_update_bt.Location = New System.Drawing.Point(258, 556)
        Me.pur_update_bt.Name = "pur_update_bt"
        Me.pur_update_bt.Size = New System.Drawing.Size(127, 60)
        Me.pur_update_bt.TabIndex = 4
        Me.pur_update_bt.Text = "업데이트"
        Me.pur_update_bt.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("맑은 고딕 Semilight", 15.0!)
        Me.Label23.Location = New System.Drawing.Point(8, 5)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(122, 35)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "결제 목록"
        '
        'Panel_Film
        '
        Me.Panel_Film.Controls.Add(Me.SplitContainer1)
        Me.Panel_Film.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Film.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Film.Name = "Panel_Film"
        Me.Panel_Film.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
        Me.Panel_Film.Size = New System.Drawing.Size(1102, 654)
        Me.Panel_Film.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 10)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FilmDetailPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2MinSize = 200
        Me.SplitContainer1.Size = New System.Drawing.Size(1062, 624)
        Me.SplitContainer1.SplitterDistance = 388
        Me.SplitContainer1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.film_filter_tb)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.film_listupdatetime_label)
        Me.Panel3.Controls.Add(Me.film_addBT)
        Me.Panel3.Controls.Add(Me.film_nextpage_bt)
        Me.Panel3.Controls.Add(Me.film_prevpage_bt)
        Me.Panel3.Controls.Add(Me.film_curpage_tb)
        Me.Panel3.Controls.Add(Me.film_totalpage_label)
        Me.Panel3.Controls.Add(Me.FilmListView)
        Me.Panel3.Controls.Add(Me.film_update_bt)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(1062, 388)
        Me.Panel3.TabIndex = 5
        '
        'film_filter_tb
        '
        Me.film_filter_tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.film_filter_tb.Location = New System.Drawing.Point(349, 353)
        Me.film_filter_tb.Name = "film_filter_tb"
        Me.film_filter_tb.Size = New System.Drawing.Size(176, 27)
        Me.film_filter_tb.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(305, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "필터:"
        '
        'film_listupdatetime_label
        '
        Me.film_listupdatetime_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.film_listupdatetime_label.Font = New System.Drawing.Font("맑은 고딕", 8.0!)
        Me.film_listupdatetime_label.ForeColor = System.Drawing.Color.Gray
        Me.film_listupdatetime_label.Location = New System.Drawing.Point(875, 0)
        Me.film_listupdatetime_label.Name = "film_listupdatetime_label"
        Me.film_listupdatetime_label.Size = New System.Drawing.Size(179, 46)
        Me.film_listupdatetime_label.TabIndex = 22
        Me.film_listupdatetime_label.Text = "업데이트 되지 않음"
        Me.film_listupdatetime_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'film_addBT
        '
        Me.film_addBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.film_addBT.Location = New System.Drawing.Point(907, 349)
        Me.film_addBT.Name = "film_addBT"
        Me.film_addBT.Size = New System.Drawing.Size(147, 36)
        Me.film_addBT.TabIndex = 21
        Me.film_addBT.Text = "영화 추가"
        Me.film_addBT.UseVisualStyleBackColor = True
        '
        'film_nextpage_bt
        '
        Me.film_nextpage_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.film_nextpage_bt.Enabled = False
        Me.film_nextpage_bt.Location = New System.Drawing.Point(148, 353)
        Me.film_nextpage_bt.Name = "film_nextpage_bt"
        Me.film_nextpage_bt.Size = New System.Drawing.Size(35, 29)
        Me.film_nextpage_bt.TabIndex = 20
        Me.film_nextpage_bt.Text = ">"
        Me.film_nextpage_bt.UseVisualStyleBackColor = True
        '
        'film_prevpage_bt
        '
        Me.film_prevpage_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.film_prevpage_bt.Enabled = False
        Me.film_prevpage_bt.Location = New System.Drawing.Point(8, 353)
        Me.film_prevpage_bt.Name = "film_prevpage_bt"
        Me.film_prevpage_bt.Size = New System.Drawing.Size(35, 29)
        Me.film_prevpage_bt.TabIndex = 19
        Me.film_prevpage_bt.Text = "<"
        Me.film_prevpage_bt.UseVisualStyleBackColor = True
        '
        'film_curpage_tb
        '
        Me.film_curpage_tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.film_curpage_tb.Location = New System.Drawing.Point(49, 353)
        Me.film_curpage_tb.Name = "film_curpage_tb"
        Me.film_curpage_tb.Size = New System.Drawing.Size(51, 27)
        Me.film_curpage_tb.TabIndex = 18
        Me.film_curpage_tb.Text = "1"
        '
        'film_totalpage_label
        '
        Me.film_totalpage_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.film_totalpage_label.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.film_totalpage_label.Location = New System.Drawing.Point(104, 353)
        Me.film_totalpage_label.Name = "film_totalpage_label"
        Me.film_totalpage_label.Size = New System.Drawing.Size(49, 27)
        Me.film_totalpage_label.TabIndex = 17
        Me.film_totalpage_label.Text = "/ ?"
        Me.film_totalpage_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FilmListView
        '
        Me.FilmListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilmListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.film_col_movie_id, Me.film_col_gerne_id, Me.film_col_name, Me.film_col_name_eng, Me.film_col_movie_time, Me.film_col_description, Me.film_col_release_date, Me.film_col_country, Me.film_col_rating, Me.film_col_poster})
        Me.FilmListView.FullRowSelect = True
        Me.FilmListView.HideSelection = False
        Me.FilmListView.Location = New System.Drawing.Point(8, 47)
        Me.FilmListView.MultiSelect = False
        Me.FilmListView.Name = "FilmListView"
        Me.FilmListView.Size = New System.Drawing.Size(1046, 300)
        Me.FilmListView.TabIndex = 3
        Me.FilmListView.UseCompatibleStateImageBehavior = False
        Me.FilmListView.View = System.Windows.Forms.View.Details
        '
        'film_col_movie_id
        '
        Me.film_col_movie_id.Text = "영화 ID"
        Me.film_col_movie_id.Width = 70
        '
        'film_col_gerne_id
        '
        Me.film_col_gerne_id.Text = "장르 ID"
        Me.film_col_gerne_id.Width = 70
        '
        'film_col_name
        '
        Me.film_col_name.Text = "영화명"
        Me.film_col_name.Width = 300
        '
        'film_col_name_eng
        '
        Me.film_col_name_eng.Text = "영문명"
        Me.film_col_name_eng.Width = 300
        '
        'film_col_movie_time
        '
        Me.film_col_movie_time.Text = "상영시간 (분)"
        Me.film_col_movie_time.Width = 70
        '
        'film_col_description
        '
        Me.film_col_description.Text = "설명"
        Me.film_col_description.Width = 200
        '
        'film_col_release_date
        '
        Me.film_col_release_date.Text = "개봉일"
        Me.film_col_release_date.Width = 120
        '
        'film_col_country
        '
        Me.film_col_country.Text = "국가"
        '
        'film_col_rating
        '
        Me.film_col_rating.Text = "등급"
        '
        'film_col_poster
        '
        Me.film_col_poster.Text = "포스터"
        Me.film_col_poster.Width = 100
        '
        'film_update_bt
        '
        Me.film_update_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.film_update_bt.Location = New System.Drawing.Point(189, 349)
        Me.film_update_bt.Name = "film_update_bt"
        Me.film_update_bt.Size = New System.Drawing.Size(110, 36)
        Me.film_update_bt.TabIndex = 4
        Me.film_update_bt.Text = "업데이트"
        Me.film_update_bt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕 Semilight", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "영화 목록"
        '
        'FilmDetailPanel
        '
        Me.FilmDetailPanel.Controls.Add(Me.Panel4)
        Me.FilmDetailPanel.Controls.Add(Me.filminfo_poster_pb)
        Me.FilmDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilmDetailPanel.Location = New System.Drawing.Point(0, 32)
        Me.FilmDetailPanel.Name = "FilmDetailPanel"
        Me.FilmDetailPanel.Size = New System.Drawing.Size(1062, 200)
        Me.FilmDetailPanel.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel4.Controls.Add(Me.filminfo_description_tb)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(153, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(909, 200)
        Me.Panel4.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.54377!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.45623!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(898, 106)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.filminfo_country_tb)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.filminfo_time_tb)
        Me.Panel6.Controls.Add(Me.filminfo_release_date_dtp)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(627, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(268, 100)
        Me.Panel6.TabIndex = 1
        '
        'filminfo_country_tb
        '
        Me.filminfo_country_tb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_country_tb.Location = New System.Drawing.Point(71, 72)
        Me.filminfo_country_tb.Name = "filminfo_country_tb"
        Me.filminfo_country_tb.ReadOnly = True
        Me.filminfo_country_tb.Size = New System.Drawing.Size(194, 27)
        Me.filminfo_country_tb.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(4, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "상영시간(분)"
        '
        'filminfo_time_tb
        '
        Me.filminfo_time_tb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_time_tb.Location = New System.Drawing.Point(114, 2)
        Me.filminfo_time_tb.Name = "filminfo_time_tb"
        Me.filminfo_time_tb.ReadOnly = True
        Me.filminfo_time_tb.Size = New System.Drawing.Size(151, 27)
        Me.filminfo_time_tb.TabIndex = 11
        '
        'filminfo_release_date_dtp
        '
        Me.filminfo_release_date_dtp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_release_date_dtp.Enabled = False
        Me.filminfo_release_date_dtp.Location = New System.Drawing.Point(71, 36)
        Me.filminfo_release_date_dtp.Name = "filminfo_release_date_dtp"
        Me.filminfo_release_date_dtp.Size = New System.Drawing.Size(194, 27)
        Me.filminfo_release_date_dtp.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(4, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "개봉일"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(4, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "국가"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.filminfo_rating_cb)
        Me.Panel2.Controls.Add(Me.filminfo_name_eng_tb)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.filminfo_id_tb)
        Me.Panel2.Controls.Add(Me.filminfo_genre_id_cb)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.filminfo_name_tb)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(618, 100)
        Me.Panel2.TabIndex = 0
        '
        'filminfo_rating_cb
        '
        Me.filminfo_rating_cb.Enabled = False
        Me.filminfo_rating_cb.FormattingEnabled = True
        Me.filminfo_rating_cb.Location = New System.Drawing.Point(428, 1)
        Me.filminfo_rating_cb.Name = "filminfo_rating_cb"
        Me.filminfo_rating_cb.Size = New System.Drawing.Size(126, 28)
        Me.filminfo_rating_cb.TabIndex = 19
        '
        'filminfo_name_eng_tb
        '
        Me.filminfo_name_eng_tb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_name_eng_tb.Location = New System.Drawing.Point(77, 71)
        Me.filminfo_name_eng_tb.Name = "filminfo_name_eng_tb"
        Me.filminfo_name_eng_tb.ReadOnly = True
        Me.filminfo_name_eng_tb.Size = New System.Drawing.Size(532, 27)
        Me.filminfo_name_eng_tb.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(378, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "등급"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "영화 ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(184, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "장르 ID"
        '
        'filminfo_id_tb
        '
        Me.filminfo_id_tb.Location = New System.Drawing.Point(77, 1)
        Me.filminfo_id_tb.Name = "filminfo_id_tb"
        Me.filminfo_id_tb.ReadOnly = True
        Me.filminfo_id_tb.Size = New System.Drawing.Size(100, 27)
        Me.filminfo_id_tb.TabIndex = 2
        '
        'filminfo_genre_id_cb
        '
        Me.filminfo_genre_id_cb.Enabled = False
        Me.filminfo_genre_id_cb.FormattingEnabled = True
        Me.filminfo_genre_id_cb.Location = New System.Drawing.Point(257, 1)
        Me.filminfo_genre_id_cb.Name = "filminfo_genre_id_cb"
        Me.filminfo_genre_id_cb.Size = New System.Drawing.Size(106, 28)
        Me.filminfo_genre_id_cb.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(4, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "영화명"
        '
        'filminfo_name_tb
        '
        Me.filminfo_name_tb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_name_tb.Location = New System.Drawing.Point(77, 36)
        Me.filminfo_name_tb.Name = "filminfo_name_tb"
        Me.filminfo_name_tb.ReadOnly = True
        Me.filminfo_name_tb.Size = New System.Drawing.Size(532, 27)
        Me.filminfo_name_tb.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "영문명"
        '
        'filminfo_description_tb
        '
        Me.filminfo_description_tb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_description_tb.Location = New System.Drawing.Point(86, 115)
        Me.filminfo_description_tb.Multiline = True
        Me.filminfo_description_tb.Name = "filminfo_description_tb"
        Me.filminfo_description_tb.ReadOnly = True
        Me.filminfo_description_tb.Size = New System.Drawing.Size(812, 72)
        Me.filminfo_description_tb.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(13, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 23)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "설명"
        '
        'filminfo_poster_pb
        '
        Me.filminfo_poster_pb.Dock = System.Windows.Forms.DockStyle.Left
        Me.filminfo_poster_pb.InitialImage = Global.dbase_management.My.Resources.Resources.loading
        Me.filminfo_poster_pb.Location = New System.Drawing.Point(0, 0)
        Me.filminfo_poster_pb.Name = "filminfo_poster_pb"
        Me.filminfo_poster_pb.Size = New System.Drawing.Size(153, 200)
        Me.filminfo_poster_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.filminfo_poster_pb.TabIndex = 0
        Me.filminfo_poster_pb.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.film_removeBT)
        Me.Panel5.Controls.Add(Me.film_editBT)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1062, 32)
        Me.Panel5.TabIndex = 0
        '
        'film_removeBT
        '
        Me.film_removeBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.film_removeBT.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.film_removeBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.film_removeBT.Location = New System.Drawing.Point(953, 2)
        Me.film_removeBT.Name = "film_removeBT"
        Me.film_removeBT.Size = New System.Drawing.Size(101, 27)
        Me.film_removeBT.TabIndex = 5
        Me.film_removeBT.Text = "삭제"
        Me.film_removeBT.UseVisualStyleBackColor = True
        '
        'film_editBT
        '
        Me.film_editBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.film_editBT.Location = New System.Drawing.Point(846, 2)
        Me.film_editBT.Name = "film_editBT"
        Me.film_editBT.Size = New System.Drawing.Size(101, 27)
        Me.film_editBT.TabIndex = 4
        Me.film_editBT.Text = "편집"
        Me.film_editBT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕 Semilight", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(2, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "정보"
        '
        'Panel_Schedule
        '
        Me.Panel_Schedule.Controls.Add(Me.Panel10)
        Me.Panel_Schedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Schedule.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Schedule.Name = "Panel_Schedule"
        Me.Panel_Schedule.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
        Me.Panel_Schedule.Size = New System.Drawing.Size(1102, 654)
        Me.Panel_Schedule.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.sche_showcurrtheater_chk)
        Me.Panel10.Controls.Add(Me.sche_filter_tb)
        Me.Panel10.Controls.Add(Me.sche_scr_filter_cb)
        Me.Panel10.Controls.Add(Me.Label16)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.sche_time_end_dtp)
        Me.Panel10.Controls.Add(Me.sche_time_start_dtp)
        Me.Panel10.Controls.Add(Me.sche_edit_bt)
        Me.Panel10.Controls.Add(Me.sche_listupdatetime_label)
        Me.Panel10.Controls.Add(Me.sche_add_bt)
        Me.Panel10.Controls.Add(Me.ScheListView)
        Me.Panel10.Controls.Add(Me.sche_update_bt)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(20, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel10.Size = New System.Drawing.Size(1062, 624)
        Me.Panel10.TabIndex = 7
        '
        'sche_showcurrtheater_chk
        '
        Me.sche_showcurrtheater_chk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sche_showcurrtheater_chk.AutoSize = True
        Me.sche_showcurrtheater_chk.Checked = True
        Me.sche_showcurrtheater_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sche_showcurrtheater_chk.Location = New System.Drawing.Point(563, 593)
        Me.sche_showcurrtheater_chk.Name = "sche_showcurrtheater_chk"
        Me.sche_showcurrtheater_chk.Size = New System.Drawing.Size(181, 24)
        Me.sche_showcurrtheater_chk.TabIndex = 30
        Me.sche_showcurrtheater_chk.Text = "현재 지점 편성만 보기"
        Me.sche_showcurrtheater_chk.UseVisualStyleBackColor = True
        '
        'sche_filter_tb
        '
        Me.sche_filter_tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sche_filter_tb.Location = New System.Drawing.Point(267, 589)
        Me.sche_filter_tb.Name = "sche_filter_tb"
        Me.sche_filter_tb.Size = New System.Drawing.Size(157, 27)
        Me.sche_filter_tb.TabIndex = 29
        '
        'sche_scr_filter_cb
        '
        Me.sche_scr_filter_cb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sche_scr_filter_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sche_scr_filter_cb.FormattingEnabled = True
        Me.sche_scr_filter_cb.Location = New System.Drawing.Point(267, 556)
        Me.sche_scr_filter_cb.Name = "sche_scr_filter_cb"
        Me.sche_scr_filter_cb.Size = New System.Drawing.Size(157, 28)
        Me.sche_scr_filter_cb.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(213, 594)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 20)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "까지"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(213, 561)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "부터"
        '
        'sche_time_end_dtp
        '
        Me.sche_time_end_dtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sche_time_end_dtp.Location = New System.Drawing.Point(9, 589)
        Me.sche_time_end_dtp.Name = "sche_time_end_dtp"
        Me.sche_time_end_dtp.Size = New System.Drawing.Size(198, 27)
        Me.sche_time_end_dtp.TabIndex = 25
        '
        'sche_time_start_dtp
        '
        Me.sche_time_start_dtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sche_time_start_dtp.Location = New System.Drawing.Point(9, 556)
        Me.sche_time_start_dtp.Name = "sche_time_start_dtp"
        Me.sche_time_start_dtp.Size = New System.Drawing.Size(198, 27)
        Me.sche_time_start_dtp.TabIndex = 24
        '
        'sche_edit_bt
        '
        Me.sche_edit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sche_edit_bt.Location = New System.Drawing.Point(756, 556)
        Me.sche_edit_bt.Name = "sche_edit_bt"
        Me.sche_edit_bt.Size = New System.Drawing.Size(163, 65)
        Me.sche_edit_bt.TabIndex = 23
        Me.sche_edit_bt.Text = "편성 조회 / 편집"
        Me.sche_edit_bt.UseVisualStyleBackColor = True
        '
        'sche_listupdatetime_label
        '
        Me.sche_listupdatetime_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sche_listupdatetime_label.Font = New System.Drawing.Font("맑은 고딕", 8.0!)
        Me.sche_listupdatetime_label.ForeColor = System.Drawing.Color.Gray
        Me.sche_listupdatetime_label.Location = New System.Drawing.Point(875, 0)
        Me.sche_listupdatetime_label.Name = "sche_listupdatetime_label"
        Me.sche_listupdatetime_label.Size = New System.Drawing.Size(179, 46)
        Me.sche_listupdatetime_label.TabIndex = 22
        Me.sche_listupdatetime_label.Text = "업데이트 되지 않음"
        Me.sche_listupdatetime_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sche_add_bt
        '
        Me.sche_add_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sche_add_bt.Location = New System.Drawing.Point(924, 556)
        Me.sche_add_bt.Name = "sche_add_bt"
        Me.sche_add_bt.Size = New System.Drawing.Size(130, 65)
        Me.sche_add_bt.TabIndex = 21
        Me.sche_add_bt.Text = "편성 추가"
        Me.sche_add_bt.UseVisualStyleBackColor = True
        '
        'ScheListView
        '
        Me.ScheListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScheListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_sche_id, Me.col_sche_scr_id, Me.col_sche_theater_name, Me.col_sche_movie_id, Me.col_sche_movie_name, Me.col_sche_movie_name_eng, Me.col_sche_start_time, Me.col_sche_end_time, Me.col_sche_runtime})
        Me.ScheListView.FullRowSelect = True
        Me.ScheListView.HideSelection = False
        Me.ScheListView.Location = New System.Drawing.Point(8, 47)
        Me.ScheListView.MultiSelect = False
        Me.ScheListView.Name = "ScheListView"
        Me.ScheListView.Size = New System.Drawing.Size(1046, 503)
        Me.ScheListView.TabIndex = 3
        Me.ScheListView.UseCompatibleStateImageBehavior = False
        Me.ScheListView.View = System.Windows.Forms.View.Details
        '
        'col_sche_id
        '
        Me.col_sche_id.Text = "편성 ID"
        Me.col_sche_id.Width = 78
        '
        'col_sche_scr_id
        '
        Me.col_sche_scr_id.Text = "상영관 ID"
        Me.col_sche_scr_id.Width = 86
        '
        'col_sche_theater_name
        '
        Me.col_sche_theater_name.Text = "지점 ID"
        Me.col_sche_theater_name.Width = 75
        '
        'col_sche_movie_id
        '
        Me.col_sche_movie_id.Text = "영화 ID"
        Me.col_sche_movie_id.Width = 75
        '
        'col_sche_movie_name
        '
        Me.col_sche_movie_name.Text = "영화명"
        Me.col_sche_movie_name.Width = 283
        '
        'col_sche_movie_name_eng
        '
        Me.col_sche_movie_name_eng.Text = "영문명"
        Me.col_sche_movie_name_eng.Width = 146
        '
        'col_sche_start_time
        '
        Me.col_sche_start_time.Text = "시작 시간"
        Me.col_sche_start_time.Width = 144
        '
        'col_sche_end_time
        '
        Me.col_sche_end_time.Text = "종료 시간"
        Me.col_sche_end_time.Width = 152
        '
        'col_sche_runtime
        '
        Me.col_sche_runtime.Text = "상영 시간(분)"
        Me.col_sche_runtime.Width = 81
        '
        'sche_update_bt
        '
        Me.sche_update_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sche_update_bt.Location = New System.Drawing.Point(430, 556)
        Me.sche_update_bt.Name = "sche_update_bt"
        Me.sche_update_bt.Size = New System.Drawing.Size(127, 60)
        Me.sche_update_bt.TabIndex = 4
        Me.sche_update_bt.Text = "업데이트"
        Me.sche_update_bt.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("맑은 고딕 Semilight", 15.0!)
        Me.Label18.Location = New System.Drawing.Point(8, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(179, 35)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "상영 편성 목록"
        '
        'Panel_Screen
        '
        Me.Panel_Screen.Controls.Add(Me.SplitContainer2)
        Me.Panel_Screen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Screen.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Screen.Name = "Panel_Screen"
        Me.Panel_Screen.Padding = New System.Windows.Forms.Padding(20, 10, 20, 20)
        Me.Panel_Screen.Size = New System.Drawing.Size(1102, 654)
        Me.Panel_Screen.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(20, 10)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel7)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer2.Size = New System.Drawing.Size(1062, 624)
        Me.SplitContainer2.SplitterDistance = 347
        Me.SplitContainer2.TabIndex = 25
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.scr_edit_bt)
        Me.Panel7.Controls.Add(Me.scr_listupdatetime_label)
        Me.Panel7.Controls.Add(Me.scr_add_bt)
        Me.Panel7.Controls.Add(Me.scr_nextpage_bt)
        Me.Panel7.Controls.Add(Me.scr_prevpage_bt)
        Me.Panel7.Controls.Add(Me.scr_curpage_tb)
        Me.Panel7.Controls.Add(Me.scr_totalpage_label)
        Me.Panel7.Controls.Add(Me.ScrListView)
        Me.Panel7.Controls.Add(Me.scr_update_bt)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel7.Size = New System.Drawing.Size(1062, 347)
        Me.Panel7.TabIndex = 7
        '
        'scr_edit_bt
        '
        Me.scr_edit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_edit_bt.Location = New System.Drawing.Point(789, 308)
        Me.scr_edit_bt.Name = "scr_edit_bt"
        Me.scr_edit_bt.Size = New System.Drawing.Size(130, 36)
        Me.scr_edit_bt.TabIndex = 23
        Me.scr_edit_bt.Text = "상영관 편집"
        Me.scr_edit_bt.UseVisualStyleBackColor = True
        '
        'scr_listupdatetime_label
        '
        Me.scr_listupdatetime_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_listupdatetime_label.Font = New System.Drawing.Font("맑은 고딕", 8.0!)
        Me.scr_listupdatetime_label.ForeColor = System.Drawing.Color.Gray
        Me.scr_listupdatetime_label.Location = New System.Drawing.Point(875, 0)
        Me.scr_listupdatetime_label.Name = "scr_listupdatetime_label"
        Me.scr_listupdatetime_label.Size = New System.Drawing.Size(179, 46)
        Me.scr_listupdatetime_label.TabIndex = 22
        Me.scr_listupdatetime_label.Text = "업데이트 되지 않음"
        Me.scr_listupdatetime_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'scr_add_bt
        '
        Me.scr_add_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_add_bt.Location = New System.Drawing.Point(924, 308)
        Me.scr_add_bt.Name = "scr_add_bt"
        Me.scr_add_bt.Size = New System.Drawing.Size(130, 36)
        Me.scr_add_bt.TabIndex = 21
        Me.scr_add_bt.Text = "상영관 추가"
        Me.scr_add_bt.UseVisualStyleBackColor = True
        '
        'scr_nextpage_bt
        '
        Me.scr_nextpage_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.scr_nextpage_bt.Enabled = False
        Me.scr_nextpage_bt.Location = New System.Drawing.Point(148, 312)
        Me.scr_nextpage_bt.Name = "scr_nextpage_bt"
        Me.scr_nextpage_bt.Size = New System.Drawing.Size(35, 29)
        Me.scr_nextpage_bt.TabIndex = 20
        Me.scr_nextpage_bt.Text = ">"
        Me.scr_nextpage_bt.UseVisualStyleBackColor = True
        '
        'scr_prevpage_bt
        '
        Me.scr_prevpage_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.scr_prevpage_bt.Enabled = False
        Me.scr_prevpage_bt.Location = New System.Drawing.Point(8, 312)
        Me.scr_prevpage_bt.Name = "scr_prevpage_bt"
        Me.scr_prevpage_bt.Size = New System.Drawing.Size(35, 29)
        Me.scr_prevpage_bt.TabIndex = 19
        Me.scr_prevpage_bt.Text = "<"
        Me.scr_prevpage_bt.UseVisualStyleBackColor = True
        '
        'scr_curpage_tb
        '
        Me.scr_curpage_tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.scr_curpage_tb.Location = New System.Drawing.Point(49, 312)
        Me.scr_curpage_tb.Name = "scr_curpage_tb"
        Me.scr_curpage_tb.Size = New System.Drawing.Size(51, 27)
        Me.scr_curpage_tb.TabIndex = 18
        Me.scr_curpage_tb.Text = "1"
        '
        'scr_totalpage_label
        '
        Me.scr_totalpage_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.scr_totalpage_label.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.scr_totalpage_label.Location = New System.Drawing.Point(104, 312)
        Me.scr_totalpage_label.Name = "scr_totalpage_label"
        Me.scr_totalpage_label.Size = New System.Drawing.Size(49, 27)
        Me.scr_totalpage_label.TabIndex = 17
        Me.scr_totalpage_label.Text = "/ ?"
        Me.scr_totalpage_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ScrListView
        '
        Me.ScrListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScrListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_scr_id, Me.col_scr_name, Me.col_scr_theater_id, Me.col_scr_theater_name, Me.col_scr_type})
        Me.ScrListView.FullRowSelect = True
        Me.ScrListView.HideSelection = False
        Me.ScrListView.Location = New System.Drawing.Point(8, 47)
        Me.ScrListView.MultiSelect = False
        Me.ScrListView.Name = "ScrListView"
        Me.ScrListView.Size = New System.Drawing.Size(1046, 259)
        Me.ScrListView.TabIndex = 3
        Me.ScrListView.UseCompatibleStateImageBehavior = False
        Me.ScrListView.View = System.Windows.Forms.View.Details
        '
        'col_scr_id
        '
        Me.col_scr_id.Text = "상영관 ID"
        Me.col_scr_id.Width = 80
        '
        'col_scr_name
        '
        Me.col_scr_name.Text = "상영관명"
        Me.col_scr_name.Width = 200
        '
        'col_scr_theater_id
        '
        Me.col_scr_theater_id.Text = "영화관 ID"
        Me.col_scr_theater_id.Width = 80
        '
        'col_scr_theater_name
        '
        Me.col_scr_theater_name.Text = "영화관명"
        Me.col_scr_theater_name.Width = 200
        '
        'col_scr_type
        '
        Me.col_scr_type.Text = "상영 방식"
        Me.col_scr_type.Width = 90
        '
        'scr_update_bt
        '
        Me.scr_update_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.scr_update_bt.Location = New System.Drawing.Point(189, 308)
        Me.scr_update_bt.Name = "scr_update_bt"
        Me.scr_update_bt.Size = New System.Drawing.Size(110, 36)
        Me.scr_update_bt.TabIndex = 4
        Me.scr_update_bt.Text = "업데이트"
        Me.scr_update_bt.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("맑은 고딕 Semilight", 15.0!)
        Me.Label17.Location = New System.Drawing.Point(8, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 35)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "상영관 목록"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.scr_seat_table)
        Me.Panel8.Controls.Add(Me.scr_seat_edit_bt)
        Me.Panel8.Controls.Add(Me.SeatListView)
        Me.Panel8.Controls.Add(Me.Label21)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel8.Size = New System.Drawing.Size(1062, 273)
        Me.Panel8.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("맑은 고딕 Semilight", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(647, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 23)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "배치도"
        '
        'scr_seat_table
        '
        Me.scr_seat_table.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_seat_table.ColumnCount = 1
        Me.scr_seat_table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scr_seat_table.Location = New System.Drawing.Point(651, 32)
        Me.scr_seat_table.Margin = New System.Windows.Forms.Padding(0)
        Me.scr_seat_table.Name = "scr_seat_table"
        Me.scr_seat_table.RowCount = 1
        Me.scr_seat_table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scr_seat_table.Size = New System.Drawing.Size(403, 196)
        Me.scr_seat_table.TabIndex = 22
        '
        'scr_seat_edit_bt
        '
        Me.scr_seat_edit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_seat_edit_bt.Location = New System.Drawing.Point(924, 234)
        Me.scr_seat_edit_bt.Name = "scr_seat_edit_bt"
        Me.scr_seat_edit_bt.Size = New System.Drawing.Size(130, 36)
        Me.scr_seat_edit_bt.TabIndex = 21
        Me.scr_seat_edit_bt.Text = "좌석 편집"
        Me.scr_seat_edit_bt.UseVisualStyleBackColor = True
        '
        'SeatListView
        '
        Me.SeatListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeatListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_scr_seat_id, Me.col_scr_seat_row, Me.col_scr_seat_col, Me.col_scr_seat_sid, Me.col_scr_seat_tid, Me.col_scr_seat_available})
        Me.SeatListView.FullRowSelect = True
        Me.SeatListView.HideSelection = False
        Me.SeatListView.Location = New System.Drawing.Point(8, 32)
        Me.SeatListView.MultiSelect = False
        Me.SeatListView.Name = "SeatListView"
        Me.SeatListView.Size = New System.Drawing.Size(637, 233)
        Me.SeatListView.TabIndex = 3
        Me.SeatListView.UseCompatibleStateImageBehavior = False
        Me.SeatListView.View = System.Windows.Forms.View.Details
        '
        'col_scr_seat_id
        '
        Me.col_scr_seat_id.Text = "좌석 ID"
        Me.col_scr_seat_id.Width = 70
        '
        'col_scr_seat_row
        '
        Me.col_scr_seat_row.Text = "줄"
        '
        'col_scr_seat_col
        '
        Me.col_scr_seat_col.Text = "열"
        '
        'col_scr_seat_sid
        '
        Me.col_scr_seat_sid.Text = "관 ID"
        '
        'col_scr_seat_tid
        '
        Me.col_scr_seat_tid.Text = "지점 ID"
        Me.col_scr_seat_tid.Width = 80
        '
        'col_scr_seat_available
        '
        Me.col_scr_seat_available.Text = "사용 가능 여부"
        Me.col_scr_seat_available.Width = 120
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("맑은 고딕 Semilight", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(8, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 23)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "좌석"
        '
        'col_purchase_scr_id
        '
        Me.col_purchase_scr_id.Text = "관 ID"
        Me.col_purchase_scr_id.Width = 72
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1231, 740)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.ModeSelectMenuPanel)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = Global.dbase_management.My.Resources.Resources.mng_icon
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DBASE CINEMA Management System"
        Me.Panel1.ResumeLayout(False)
        Me.ModeSelectMenuPanel.ResumeLayout(False)
        CType(Me.ModeFacilBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeStaffBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeScheduleBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePurchaseBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeScreenBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeFilmBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel_Purchase.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel_Film.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FilmDetailPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.filminfo_poster_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel_Schedule.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel_Screen.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ModeSelectMenuPanel As Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents LogoutBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ModeFacilBT As PictureBox
    Friend WithEvents ModeStaffBT As PictureBox
    Friend WithEvents ModeScheduleBT As PictureBox
    Friend WithEvents ModePurchaseBT As PictureBox
    Friend WithEvents ModeScreenBT As PictureBox
    Friend WithEvents ModeFilmBT As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel_Film As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents FilmListView As ListView
    Friend WithEvents film_col_movie_id As ColumnHeader
    Friend WithEvents film_col_gerne_id As ColumnHeader
    Friend WithEvents film_col_name As ColumnHeader
    Friend WithEvents film_col_name_eng As ColumnHeader
    Friend WithEvents film_col_movie_time As ColumnHeader
    Friend WithEvents film_col_description As ColumnHeader
    Friend WithEvents film_col_release_date As ColumnHeader
    Friend WithEvents film_col_country As ColumnHeader
    Friend WithEvents film_col_rating As ColumnHeader
    Friend WithEvents film_col_poster As ColumnHeader
    Friend WithEvents film_update_bt As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FilmDetailPanel As Panel
    Friend WithEvents filminfo_poster_pb As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents filminfo_genre_id_cb As ComboBox
    Friend WithEvents filminfo_id_tb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents filminfo_name_tb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents filminfo_description_tb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents filminfo_country_tb As TextBox
    Friend WithEvents filminfo_release_date_dtp As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents filminfo_time_tb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents filminfo_name_eng_tb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents filminfo_rating_cb As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents film_addBT As Button
    Friend WithEvents film_nextpage_bt As Button
    Friend WithEvents film_prevpage_bt As Button
    Friend WithEvents film_curpage_tb As TextBox
    Friend WithEvents film_totalpage_label As Label
    Friend WithEvents film_removeBT As Button
    Friend WithEvents film_editBT As Button
    Friend WithEvents film_listupdatetime_label As Label
    Friend WithEvents film_filter_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Screen As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel7 As Panel
    Friend WithEvents scr_listupdatetime_label As Label
    Friend WithEvents scr_add_bt As Button
    Friend WithEvents ScrListView As ListView
    Friend WithEvents col_scr_id As ColumnHeader
    Friend WithEvents col_scr_name As ColumnHeader
    Friend WithEvents col_scr_theater_id As ColumnHeader
    Friend WithEvents col_scr_theater_name As ColumnHeader
    Friend WithEvents col_scr_type As ColumnHeader
    Friend WithEvents scr_update_bt As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents scr_seat_table As TableLayoutPanel
    Friend WithEvents scr_seat_edit_bt As Button
    Friend WithEvents SeatListView As ListView
    Friend WithEvents col_scr_seat_id As ColumnHeader
    Friend WithEvents Label21 As Label
    Friend WithEvents scr_nextpage_bt As Button
    Friend WithEvents scr_prevpage_bt As Button
    Friend WithEvents scr_curpage_tb As TextBox
    Friend WithEvents scr_totalpage_label As Label
    Friend WithEvents col_scr_seat_row As ColumnHeader
    Friend WithEvents col_scr_seat_col As ColumnHeader
    Friend WithEvents col_scr_seat_sid As ColumnHeader
    Friend WithEvents col_scr_seat_tid As ColumnHeader
    Friend WithEvents col_scr_seat_available As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents scr_edit_bt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_Schedule As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents sche_time_end_dtp As DateTimePicker
    Friend WithEvents sche_time_start_dtp As DateTimePicker
    Friend WithEvents sche_edit_bt As Button
    Friend WithEvents sche_listupdatetime_label As Label
    Friend WithEvents sche_add_bt As Button
    Friend WithEvents ScheListView As ListView
    Friend WithEvents col_sche_id As ColumnHeader
    Friend WithEvents col_sche_scr_id As ColumnHeader
    Friend WithEvents col_sche_theater_name As ColumnHeader
    Friend WithEvents col_sche_movie_id As ColumnHeader
    Friend WithEvents col_sche_movie_name As ColumnHeader
    Friend WithEvents col_sche_movie_name_eng As ColumnHeader
    Friend WithEvents col_sche_start_time As ColumnHeader
    Friend WithEvents col_sche_end_time As ColumnHeader
    Friend WithEvents col_sche_runtime As ColumnHeader
    Friend WithEvents sche_update_bt As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sche_showcurrtheater_chk As CheckBox
    Friend WithEvents sche_filter_tb As TextBox
    Friend WithEvents sche_scr_filter_cb As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel_Purchase As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents pur_showcurrtheater_chk As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents pur_time_end_dtp As DateTimePicker
    Friend WithEvents pur_time_start_dtp As DateTimePicker
    Friend WithEvents pur_del_bt As Button
    Friend WithEvents pur_listupdatetime_label As Label
    Friend WithEvents pur_view_bt As Button
    Friend WithEvents PurchaseListView As ListView
    Friend WithEvents col_purchase_num As ColumnHeader
    Friend WithEvents col_purchase_id As ColumnHeader
    Friend WithEvents col_purchase_sche_id As ColumnHeader
    Friend WithEvents col_purchase_seat_id As ColumnHeader
    Friend WithEvents col_purchase_time As ColumnHeader
    Friend WithEvents col_purchase_pay_price As ColumnHeader
    Friend WithEvents col_purchase_type As ColumnHeader
    Friend WithEvents col_purchase_pay_method As ColumnHeader
    Friend WithEvents col_purchase_phonenum As ColumnHeader
    Friend WithEvents pur_update_bt As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents pur_seat_bt As Button
    Friend WithEvents col_purchase_scr_id As ColumnHeader
End Class
