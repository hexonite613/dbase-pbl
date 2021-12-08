<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilmEditForm
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PosterPicBox = New System.Windows.Forms.PictureBox()
        Me.PosterUrlTB = New System.Windows.Forms.TextBox()
        Me.PosterModifyBT = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.filminfo_description_tb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filminfo_country_tb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.filminfo_time_tb = New System.Windows.Forms.TextBox()
        Me.filminfo_release_date_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PosterPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1063, 86)
        Me.Panel1.TabIndex = 1
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(25, 25)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(395, 36)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "영화 정보 편집"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PosterPicBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 514)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(239, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "포스터 이미지"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PosterPicBox
        '
        Me.PosterPicBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PosterPicBox.InitialImage = Global.dbase_management.My.Resources.Resources.loading
        Me.PosterPicBox.Location = New System.Drawing.Point(0, 0)
        Me.PosterPicBox.Name = "PosterPicBox"
        Me.PosterPicBox.Size = New System.Drawing.Size(239, 348)
        Me.PosterPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PosterPicBox.TabIndex = 0
        Me.PosterPicBox.TabStop = False
        '
        'PosterUrlTB
        '
        Me.PosterUrlTB.Location = New System.Drawing.Point(402, 72)
        Me.PosterUrlTB.Name = "PosterUrlTB"
        Me.PosterUrlTB.Size = New System.Drawing.Size(309, 27)
        Me.PosterUrlTB.TabIndex = 3
        '
        'PosterModifyBT
        '
        Me.PosterModifyBT.Font = New System.Drawing.Font("맑은 고딕", 8.0!)
        Me.PosterModifyBT.Location = New System.Drawing.Point(717, 71)
        Me.PosterModifyBT.Name = "PosterModifyBT"
        Me.PosterModifyBT.Size = New System.Drawing.Size(84, 28)
        Me.PosterModifyBT.TabIndex = 2
        Me.PosterModifyBT.Text = "변경"
        Me.PosterModifyBT.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.filminfo_description_tb)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(239, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(824, 514)
        Me.Panel3.TabIndex = 3
        '
        'filminfo_description_tb
        '
        Me.filminfo_description_tb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_description_tb.Location = New System.Drawing.Point(81, 230)
        Me.filminfo_description_tb.Multiline = True
        Me.filminfo_description_tb.Name = "filminfo_description_tb"
        Me.filminfo_description_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.filminfo_description_tb.Size = New System.Drawing.Size(730, 213)
        Me.filminfo_description_tb.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(14, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "설명"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PosterModifyBT)
        Me.Panel6.Controls.Add(Me.PosterUrlTB)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.filminfo_country_tb)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.filminfo_time_tb)
        Me.Panel6.Controls.Add(Me.filminfo_release_date_dtp)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(10, 116)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(804, 107)
        Me.Panel6.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(299, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "포스터 URL"
        '
        'filminfo_country_tb
        '
        Me.filminfo_country_tb.Location = New System.Drawing.Point(71, 72)
        Me.filminfo_country_tb.Name = "filminfo_country_tb"
        Me.filminfo_country_tb.Size = New System.Drawing.Size(199, 27)
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
        Me.filminfo_time_tb.Size = New System.Drawing.Size(687, 27)
        Me.filminfo_time_tb.TabIndex = 11
        '
        'filminfo_release_date_dtp
        '
        Me.filminfo_release_date_dtp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filminfo_release_date_dtp.Location = New System.Drawing.Point(71, 36)
        Me.filminfo_release_date_dtp.Name = "filminfo_release_date_dtp"
        Me.filminfo_release_date_dtp.Size = New System.Drawing.Size(730, 27)
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.filminfo_rating_cb)
        Me.Panel5.Controls.Add(Me.filminfo_name_eng_tb)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.filminfo_id_tb)
        Me.Panel5.Controls.Add(Me.filminfo_genre_id_cb)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.filminfo_name_tb)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 106)
        Me.Panel5.TabIndex = 1
        '
        'filminfo_rating_cb
        '
        Me.filminfo_rating_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filminfo_rating_cb.FormattingEnabled = True
        Me.filminfo_rating_cb.Items.AddRange(New Object() {"ALL", "12", "15", "18", "R18"})
        Me.filminfo_rating_cb.Location = New System.Drawing.Point(502, 1)
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
        Me.filminfo_name_eng_tb.Size = New System.Drawing.Size(725, 27)
        Me.filminfo_name_eng_tb.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(452, 1)
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
        Me.filminfo_id_tb.Size = New System.Drawing.Size(100, 27)
        Me.filminfo_id_tb.TabIndex = 2
        '
        'filminfo_genre_id_cb
        '
        Me.filminfo_genre_id_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filminfo_genre_id_cb.FormattingEnabled = True
        Me.filminfo_genre_id_cb.Location = New System.Drawing.Point(257, 1)
        Me.filminfo_genre_id_cb.Name = "filminfo_genre_id_cb"
        Me.filminfo_genre_id_cb.Size = New System.Drawing.Size(189, 28)
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
        Me.filminfo_name_tb.Size = New System.Drawing.Size(725, 27)
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.DeleteBT)
        Me.Panel4.Controls.Add(Me.SaveBT)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(239, 535)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(824, 65)
        Me.Panel4.TabIndex = 4
        '
        'DeleteBT
        '
        Me.DeleteBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBT.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBT.Location = New System.Drawing.Point(554, 14)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(95, 39)
        Me.DeleteBT.TabIndex = 1
        Me.DeleteBT.Text = "삭제"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'SaveBT
        '
        Me.SaveBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBT.Location = New System.Drawing.Point(655, 14)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(157, 39)
        Me.SaveBT.TabIndex = 0
        Me.SaveBT.Text = "저장"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'FilmEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 600)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = Global.dbase_management.My.Resources.Resources.mng_icon
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FilmEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FilmEditForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PosterPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PosterPicBox As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DeleteBT As Button
    Friend WithEvents SaveBT As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents filminfo_rating_cb As ComboBox
    Friend WithEvents filminfo_name_eng_tb As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents filminfo_id_tb As TextBox
    Friend WithEvents filminfo_genre_id_cb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents filminfo_name_tb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents filminfo_country_tb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents filminfo_time_tb As TextBox
    Friend WithEvents filminfo_release_date_dtp As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents filminfo_description_tb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PosterUrlTB As TextBox
    Friend WithEvents PosterModifyBT As Button
    Friend WithEvents Label1 As Label
End Class
