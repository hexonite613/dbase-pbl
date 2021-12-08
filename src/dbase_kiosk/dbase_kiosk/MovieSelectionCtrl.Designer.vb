<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieSelectionCtrl
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.TopEdgePanel = New System.Windows.Forms.Panel()
        Me.TopMidEdgePanel = New System.Windows.Forms.Panel()
        Me.TopRightCornerPanel = New System.Windows.Forms.Panel()
        Me.TopLeftCornerPanel = New System.Windows.Forms.Panel()
        Me.BottomEdgePanel = New System.Windows.Forms.Panel()
        Me.BottomMidEdgePanel = New System.Windows.Forms.Panel()
        Me.BottomRightCornerPanel = New System.Windows.Forms.Panel()
        Me.BottomLeftCornerPanel = New System.Windows.Forms.Panel()
        Me.InnerPanel = New System.Windows.Forms.Panel()
        Me.SeatSelectButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.seat_count_label = New System.Windows.Forms.Label()
        Me.endtime_label = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.starttime_label = New System.Windows.Forms.Label()
        Me.screen_name_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.screen_type_label = New System.Windows.Forms.Label()
        Me.movie_engname_label = New System.Windows.Forms.Label()
        Me.movie_rating_label = New System.Windows.Forms.Label()
        Me.movie_title_label = New System.Windows.Forms.Label()
        Me.PosterPB = New System.Windows.Forms.PictureBox()
        Me.RightEdgePanel = New System.Windows.Forms.Panel()
        Me.LeftEdgePanel = New System.Windows.Forms.Panel()
        Me.TopEdgePanel.SuspendLayout()
        Me.BottomEdgePanel.SuspendLayout()
        Me.InnerPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PosterPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopEdgePanel
        '
        Me.TopEdgePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopEdgePanel.Controls.Add(Me.TopMidEdgePanel)
        Me.TopEdgePanel.Controls.Add(Me.TopRightCornerPanel)
        Me.TopEdgePanel.Controls.Add(Me.TopLeftCornerPanel)
        Me.TopEdgePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopEdgePanel.Location = New System.Drawing.Point(0, 0)
        Me.TopEdgePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopEdgePanel.Name = "TopEdgePanel"
        Me.TopEdgePanel.Size = New System.Drawing.Size(1022, 48)
        Me.TopEdgePanel.TabIndex = 0
        '
        'TopMidEdgePanel
        '
        Me.TopMidEdgePanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.top_mid
        Me.TopMidEdgePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopMidEdgePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopMidEdgePanel.Location = New System.Drawing.Point(48, 0)
        Me.TopMidEdgePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopMidEdgePanel.Name = "TopMidEdgePanel"
        Me.TopMidEdgePanel.Size = New System.Drawing.Size(926, 48)
        Me.TopMidEdgePanel.TabIndex = 5
        '
        'TopRightCornerPanel
        '
        Me.TopRightCornerPanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.top_right
        Me.TopRightCornerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopRightCornerPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.TopRightCornerPanel.Location = New System.Drawing.Point(974, 0)
        Me.TopRightCornerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopRightCornerPanel.Name = "TopRightCornerPanel"
        Me.TopRightCornerPanel.Size = New System.Drawing.Size(48, 48)
        Me.TopRightCornerPanel.TabIndex = 4
        '
        'TopLeftCornerPanel
        '
        Me.TopLeftCornerPanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.top_left
        Me.TopLeftCornerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopLeftCornerPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TopLeftCornerPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopLeftCornerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopLeftCornerPanel.Name = "TopLeftCornerPanel"
        Me.TopLeftCornerPanel.Size = New System.Drawing.Size(48, 48)
        Me.TopLeftCornerPanel.TabIndex = 3
        '
        'BottomEdgePanel
        '
        Me.BottomEdgePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomEdgePanel.Controls.Add(Me.BottomMidEdgePanel)
        Me.BottomEdgePanel.Controls.Add(Me.BottomRightCornerPanel)
        Me.BottomEdgePanel.Controls.Add(Me.BottomLeftCornerPanel)
        Me.BottomEdgePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomEdgePanel.Location = New System.Drawing.Point(0, 277)
        Me.BottomEdgePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomEdgePanel.Name = "BottomEdgePanel"
        Me.BottomEdgePanel.Size = New System.Drawing.Size(1022, 48)
        Me.BottomEdgePanel.TabIndex = 1
        '
        'BottomMidEdgePanel
        '
        Me.BottomMidEdgePanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.bottom_mid
        Me.BottomMidEdgePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomMidEdgePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomMidEdgePanel.Location = New System.Drawing.Point(48, 0)
        Me.BottomMidEdgePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomMidEdgePanel.Name = "BottomMidEdgePanel"
        Me.BottomMidEdgePanel.Size = New System.Drawing.Size(926, 48)
        Me.BottomMidEdgePanel.TabIndex = 0
        '
        'BottomRightCornerPanel
        '
        Me.BottomRightCornerPanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.bottom_right
        Me.BottomRightCornerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomRightCornerPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BottomRightCornerPanel.Location = New System.Drawing.Point(974, 0)
        Me.BottomRightCornerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomRightCornerPanel.Name = "BottomRightCornerPanel"
        Me.BottomRightCornerPanel.Size = New System.Drawing.Size(48, 48)
        Me.BottomRightCornerPanel.TabIndex = 4
        '
        'BottomLeftCornerPanel
        '
        Me.BottomLeftCornerPanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.bottom_left
        Me.BottomLeftCornerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomLeftCornerPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BottomLeftCornerPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomLeftCornerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomLeftCornerPanel.Name = "BottomLeftCornerPanel"
        Me.BottomLeftCornerPanel.Size = New System.Drawing.Size(48, 48)
        Me.BottomLeftCornerPanel.TabIndex = 3
        '
        'InnerPanel
        '
        Me.InnerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.InnerPanel.Controls.Add(Me.SeatSelectButton)
        Me.InnerPanel.Controls.Add(Me.Panel2)
        Me.InnerPanel.Controls.Add(Me.Panel1)
        Me.InnerPanel.Controls.Add(Me.movie_title_label)
        Me.InnerPanel.Controls.Add(Me.PosterPB)
        Me.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InnerPanel.Location = New System.Drawing.Point(48, 48)
        Me.InnerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.InnerPanel.Name = "InnerPanel"
        Me.InnerPanel.Size = New System.Drawing.Size(926, 229)
        Me.InnerPanel.TabIndex = 4
        '
        'SeatSelectButton
        '
        Me.SeatSelectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.SeatSelectButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SeatSelectButton.FlatAppearance.BorderSize = 0
        Me.SeatSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeatSelectButton.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 25.0!)
        Me.SeatSelectButton.ForeColor = System.Drawing.Color.White
        Me.SeatSelectButton.Location = New System.Drawing.Point(809, 0)
        Me.SeatSelectButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SeatSelectButton.Name = "SeatSelectButton"
        Me.SeatSelectButton.Size = New System.Drawing.Size(117, 229)
        Me.SeatSelectButton.TabIndex = 10
        Me.SeatSelectButton.Text = "선택"
        Me.SeatSelectButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.seat_count_label)
        Me.Panel2.Controls.Add(Me.endtime_label)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.starttime_label)
        Me.Panel2.Controls.Add(Me.screen_name_label)
        Me.Panel2.Location = New System.Drawing.Point(196, 153)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 54)
        Me.Panel2.TabIndex = 9
        '
        'seat_count_label
        '
        Me.seat_count_label.AutoSize = True
        Me.seat_count_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.seat_count_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.seat_count_label.ForeColor = System.Drawing.Color.SteelBlue
        Me.seat_count_label.Location = New System.Drawing.Point(320, 0)
        Me.seat_count_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.seat_count_label.Name = "seat_count_label"
        Me.seat_count_label.Size = New System.Drawing.Size(134, 41)
        Me.seat_count_label.TabIndex = 10
        Me.seat_count_label.Text = "42/56석"
        '
        'endtime_label
        '
        Me.endtime_label.AutoSize = True
        Me.endtime_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.endtime_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.endtime_label.ForeColor = System.Drawing.Color.White
        Me.endtime_label.Location = New System.Drawing.Point(229, 0)
        Me.endtime_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.endtime_label.Name = "endtime_label"
        Me.endtime_label.Size = New System.Drawing.Size(91, 41)
        Me.endtime_label.TabIndex = 12
        Me.endtime_label.Text = "16:21"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(189, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 41)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "~"
        '
        'starttime_label
        '
        Me.starttime_label.AutoSize = True
        Me.starttime_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.starttime_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.starttime_label.ForeColor = System.Drawing.Color.White
        Me.starttime_label.Location = New System.Drawing.Point(89, 0)
        Me.starttime_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.starttime_label.Name = "starttime_label"
        Me.starttime_label.Size = New System.Drawing.Size(100, 41)
        Me.starttime_label.TabIndex = 9
        Me.starttime_label.Text = "14:30"
        '
        'screen_name_label
        '
        Me.screen_name_label.AutoSize = True
        Me.screen_name_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.screen_name_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.screen_name_label.ForeColor = System.Drawing.Color.White
        Me.screen_name_label.Location = New System.Drawing.Point(0, 0)
        Me.screen_name_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.screen_name_label.Name = "screen_name_label"
        Me.screen_name_label.Size = New System.Drawing.Size(89, 41)
        Me.screen_name_label.TabIndex = 8
        Me.screen_name_label.Text = "제1관"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.screen_type_label)
        Me.Panel1.Controls.Add(Me.movie_engname_label)
        Me.Panel1.Controls.Add(Me.movie_rating_label)
        Me.Panel1.Location = New System.Drawing.Point(196, 95)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 41)
        Me.Panel1.TabIndex = 7
        '
        'screen_type_label
        '
        Me.screen_type_label.AutoSize = True
        Me.screen_type_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.screen_type_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.screen_type_label.ForeColor = System.Drawing.Color.Silver
        Me.screen_type_label.Location = New System.Drawing.Point(208, 0)
        Me.screen_type_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.screen_type_label.Name = "screen_type_label"
        Me.screen_type_label.Size = New System.Drawing.Size(51, 36)
        Me.screen_type_label.TabIndex = 2
        Me.screen_type_label.Text = "2D"
        '
        'movie_engname_label
        '
        Me.movie_engname_label.AutoSize = True
        Me.movie_engname_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.movie_engname_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.movie_engname_label.ForeColor = System.Drawing.Color.Gray
        Me.movie_engname_label.Location = New System.Drawing.Point(68, 0)
        Me.movie_engname_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.movie_engname_label.Name = "movie_engname_label"
        Me.movie_engname_label.Size = New System.Drawing.Size(140, 36)
        Me.movie_engname_label.TabIndex = 1
        Me.movie_engname_label.Text = "Ethernals"
        '
        'movie_rating_label
        '
        Me.movie_rating_label.AutoSize = True
        Me.movie_rating_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.movie_rating_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.movie_rating_label.ForeColor = System.Drawing.Color.Orange
        Me.movie_rating_label.Location = New System.Drawing.Point(0, 0)
        Me.movie_rating_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.movie_rating_label.Name = "movie_rating_label"
        Me.movie_rating_label.Size = New System.Drawing.Size(68, 36)
        Me.movie_rating_label.TabIndex = 0
        Me.movie_rating_label.Text = "12세"
        '
        'movie_title_label
        '
        Me.movie_title_label.AutoSize = True
        Me.movie_title_label.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.movie_title_label.ForeColor = System.Drawing.Color.White
        Me.movie_title_label.Location = New System.Drawing.Point(190, 30)
        Me.movie_title_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.movie_title_label.Name = "movie_title_label"
        Me.movie_title_label.Size = New System.Drawing.Size(188, 56)
        Me.movie_title_label.TabIndex = 6
        Me.movie_title_label.Text = "이터널스"
        '
        'PosterPB
        '
        Me.PosterPB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PosterPB.Image = Global.dbase_kiosk.My.Resources.Resources.noimg
        Me.PosterPB.Location = New System.Drawing.Point(0, 0)
        Me.PosterPB.Margin = New System.Windows.Forms.Padding(4)
        Me.PosterPB.Name = "PosterPB"
        Me.PosterPB.Size = New System.Drawing.Size(166, 229)
        Me.PosterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PosterPB.TabIndex = 5
        Me.PosterPB.TabStop = False
        '
        'RightEdgePanel
        '
        Me.RightEdgePanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.right_mid
        Me.RightEdgePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightEdgePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightEdgePanel.Location = New System.Drawing.Point(974, 48)
        Me.RightEdgePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.RightEdgePanel.Name = "RightEdgePanel"
        Me.RightEdgePanel.Size = New System.Drawing.Size(48, 229)
        Me.RightEdgePanel.TabIndex = 3
        '
        'LeftEdgePanel
        '
        Me.LeftEdgePanel.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.left_mid
        Me.LeftEdgePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftEdgePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftEdgePanel.Location = New System.Drawing.Point(0, 48)
        Me.LeftEdgePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftEdgePanel.Name = "LeftEdgePanel"
        Me.LeftEdgePanel.Size = New System.Drawing.Size(48, 229)
        Me.LeftEdgePanel.TabIndex = 2
        '
        'MovieSelectionCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.InnerPanel)
        Me.Controls.Add(Me.RightEdgePanel)
        Me.Controls.Add(Me.LeftEdgePanel)
        Me.Controls.Add(Me.BottomEdgePanel)
        Me.Controls.Add(Me.TopEdgePanel)
        Me.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MovieSelectionCtrl"
        Me.Size = New System.Drawing.Size(1022, 325)
        Me.TopEdgePanel.ResumeLayout(False)
        Me.BottomEdgePanel.ResumeLayout(False)
        Me.InnerPanel.ResumeLayout(False)
        Me.InnerPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PosterPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopEdgePanel As Panel
    Friend WithEvents BottomEdgePanel As Panel
    Friend WithEvents LeftEdgePanel As Panel
    Friend WithEvents TopRightCornerPanel As Panel
    Friend WithEvents TopLeftCornerPanel As Panel
    Friend WithEvents BottomRightCornerPanel As Panel
    Friend WithEvents BottomLeftCornerPanel As Panel
    Friend WithEvents RightEdgePanel As Panel
    Friend WithEvents InnerPanel As Panel
    Friend WithEvents PosterPB As PictureBox
    Friend WithEvents TopMidEdgePanel As Panel
    Friend WithEvents BottomMidEdgePanel As Panel
    Friend WithEvents movie_title_label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents movie_engname_label As Label
    Friend WithEvents movie_rating_label As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents seat_count_label As Label
    Friend WithEvents starttime_label As Label
    Friend WithEvents screen_name_label As Label
    Friend WithEvents screen_type_label As Label
    Friend WithEvents SeatSelectButton As Button
    Friend WithEvents endtime_label As Label
    Friend WithEvents Label8 As Label
End Class
