<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatInfoForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SeatSelectButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SubLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.elderSeatLabel = New System.Windows.Forms.Label()
        Me.disabSeatLabel = New System.Windows.Forms.Label()
        Me.youthSeatLabel = New System.Windows.Forms.Label()
        Me.normalSeatLabel = New System.Windows.Forms.Label()
        Me.totalSeatLabel = New System.Windows.Forms.Label()
        Me.plusBt4 = New System.Windows.Forms.PictureBox()
        Me.minusBt4 = New System.Windows.Forms.PictureBox()
        Me.plusBt3 = New System.Windows.Forms.PictureBox()
        Me.minusBt3 = New System.Windows.Forms.PictureBox()
        Me.plusBt2 = New System.Windows.Forms.PictureBox()
        Me.minusBt2 = New System.Windows.Forms.PictureBox()
        Me.plusBt1 = New System.Windows.Forms.PictureBox()
        Me.minusBt1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SelectedSchePanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.plusBt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusBt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plusBt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusBt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plusBt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusBt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plusBt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusBt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 139)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "인원 정보를 입력해 주세요"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SeatSelectButton)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1103)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1350, 138)
        Me.Panel2.TabIndex = 6
        '
        'SeatSelectButton
        '
        Me.SeatSelectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.SeatSelectButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SeatSelectButton.FlatAppearance.BorderSize = 0
        Me.SeatSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeatSelectButton.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 38.0!)
        Me.SeatSelectButton.ForeColor = System.Drawing.Color.White
        Me.SeatSelectButton.Location = New System.Drawing.Point(826, 0)
        Me.SeatSelectButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SeatSelectButton.Name = "SeatSelectButton"
        Me.SeatSelectButton.Size = New System.Drawing.Size(524, 138)
        Me.SeatSelectButton.TabIndex = 1
        Me.SeatSelectButton.Text = "좌석 선택하기"
        Me.SeatSelectButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Button1.ForeColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(541, 138)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "< 영화 목록으로"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SubLabel1
        '
        Me.SubLabel1.AutoSize = True
        Me.SubLabel1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 35.0!)
        Me.SubLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.SubLabel1.Location = New System.Drawing.Point(44, 521)
        Me.SubLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SubLabel1.Name = "SubLabel1"
        Me.SubLabel1.Size = New System.Drawing.Size(301, 71)
        Me.SubLabel1.TabIndex = 0
        Me.SubLabel1.Text = "관람 인원수"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AppleSDGothicNeoM00", 30.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(429, 532)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 60)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "일반"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("AppleSDGothicNeoM00", 30.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(429, 635)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 60)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "청소년"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("AppleSDGothicNeoM00", 30.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(429, 738)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 60)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "장애인"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("AppleSDGothicNeoM00", 30.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(429, 840)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 60)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "경로"
        '
        'elderSeatLabel
        '
        Me.elderSeatLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.elderSeatLabel.ForeColor = System.Drawing.Color.White
        Me.elderSeatLabel.Location = New System.Drawing.Point(629, 829)
        Me.elderSeatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.elderSeatLabel.Name = "elderSeatLabel"
        Me.elderSeatLabel.Size = New System.Drawing.Size(416, 62)
        Me.elderSeatLabel.TabIndex = 16
        Me.elderSeatLabel.Text = "0명"
        Me.elderSeatLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'disabSeatLabel
        '
        Me.disabSeatLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.disabSeatLabel.ForeColor = System.Drawing.Color.White
        Me.disabSeatLabel.Location = New System.Drawing.Point(629, 726)
        Me.disabSeatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.disabSeatLabel.Name = "disabSeatLabel"
        Me.disabSeatLabel.Size = New System.Drawing.Size(416, 62)
        Me.disabSeatLabel.TabIndex = 15
        Me.disabSeatLabel.Text = "0명"
        Me.disabSeatLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'youthSeatLabel
        '
        Me.youthSeatLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.youthSeatLabel.ForeColor = System.Drawing.Color.White
        Me.youthSeatLabel.Location = New System.Drawing.Point(629, 624)
        Me.youthSeatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.youthSeatLabel.Name = "youthSeatLabel"
        Me.youthSeatLabel.Size = New System.Drawing.Size(416, 62)
        Me.youthSeatLabel.TabIndex = 14
        Me.youthSeatLabel.Text = "0명"
        Me.youthSeatLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'normalSeatLabel
        '
        Me.normalSeatLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.normalSeatLabel.ForeColor = System.Drawing.Color.White
        Me.normalSeatLabel.Location = New System.Drawing.Point(629, 521)
        Me.normalSeatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.normalSeatLabel.Name = "normalSeatLabel"
        Me.normalSeatLabel.Size = New System.Drawing.Size(416, 62)
        Me.normalSeatLabel.TabIndex = 13
        Me.normalSeatLabel.Text = "0명"
        Me.normalSeatLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'totalSeatLabel
        '
        Me.totalSeatLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 50.0!)
        Me.totalSeatLabel.ForeColor = System.Drawing.Color.White
        Me.totalSeatLabel.Location = New System.Drawing.Point(869, 944)
        Me.totalSeatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalSeatLabel.Name = "totalSeatLabel"
        Me.totalSeatLabel.Size = New System.Drawing.Size(416, 100)
        Me.totalSeatLabel.TabIndex = 19
        Me.totalSeatLabel.Text = "총 0명"
        Me.totalSeatLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'plusBt4
        '
        Me.plusBt4.BackColor = System.Drawing.Color.Gray
        Me.plusBt4.Image = Global.dbase_kiosk.My.Resources.Resources.plus_bt
        Me.plusBt4.Location = New System.Drawing.Point(1204, 825)
        Me.plusBt4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plusBt4.Name = "plusBt4"
        Me.plusBt4.Size = New System.Drawing.Size(75, 75)
        Me.plusBt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.plusBt4.TabIndex = 25
        Me.plusBt4.TabStop = False
        '
        'minusBt4
        '
        Me.minusBt4.BackColor = System.Drawing.Color.Gray
        Me.minusBt4.Image = Global.dbase_kiosk.My.Resources.Resources.minus_bt
        Me.minusBt4.Location = New System.Drawing.Point(1081, 825)
        Me.minusBt4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.minusBt4.Name = "minusBt4"
        Me.minusBt4.Size = New System.Drawing.Size(75, 75)
        Me.minusBt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minusBt4.TabIndex = 24
        Me.minusBt4.TabStop = False
        '
        'plusBt3
        '
        Me.plusBt3.BackColor = System.Drawing.Color.Gray
        Me.plusBt3.Image = Global.dbase_kiosk.My.Resources.Resources.plus_bt
        Me.plusBt3.Location = New System.Drawing.Point(1204, 722)
        Me.plusBt3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plusBt3.Name = "plusBt3"
        Me.plusBt3.Size = New System.Drawing.Size(75, 75)
        Me.plusBt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.plusBt3.TabIndex = 23
        Me.plusBt3.TabStop = False
        '
        'minusBt3
        '
        Me.minusBt3.BackColor = System.Drawing.Color.Gray
        Me.minusBt3.Image = Global.dbase_kiosk.My.Resources.Resources.minus_bt
        Me.minusBt3.Location = New System.Drawing.Point(1081, 722)
        Me.minusBt3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.minusBt3.Name = "minusBt3"
        Me.minusBt3.Size = New System.Drawing.Size(75, 75)
        Me.minusBt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minusBt3.TabIndex = 22
        Me.minusBt3.TabStop = False
        '
        'plusBt2
        '
        Me.plusBt2.BackColor = System.Drawing.Color.Gray
        Me.plusBt2.Image = Global.dbase_kiosk.My.Resources.Resources.plus_bt
        Me.plusBt2.Location = New System.Drawing.Point(1204, 620)
        Me.plusBt2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plusBt2.Name = "plusBt2"
        Me.plusBt2.Size = New System.Drawing.Size(75, 75)
        Me.plusBt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.plusBt2.TabIndex = 21
        Me.plusBt2.TabStop = False
        '
        'minusBt2
        '
        Me.minusBt2.BackColor = System.Drawing.Color.Gray
        Me.minusBt2.Image = Global.dbase_kiosk.My.Resources.Resources.minus_bt
        Me.minusBt2.Location = New System.Drawing.Point(1081, 620)
        Me.minusBt2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.minusBt2.Name = "minusBt2"
        Me.minusBt2.Size = New System.Drawing.Size(75, 75)
        Me.minusBt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minusBt2.TabIndex = 20
        Me.minusBt2.TabStop = False
        '
        'plusBt1
        '
        Me.plusBt1.BackColor = System.Drawing.Color.Gray
        Me.plusBt1.Image = Global.dbase_kiosk.My.Resources.Resources.plus_bt
        Me.plusBt1.Location = New System.Drawing.Point(1204, 518)
        Me.plusBt1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plusBt1.Name = "plusBt1"
        Me.plusBt1.Size = New System.Drawing.Size(75, 75)
        Me.plusBt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.plusBt1.TabIndex = 18
        Me.plusBt1.TabStop = False
        '
        'minusBt1
        '
        Me.minusBt1.BackColor = System.Drawing.Color.Gray
        Me.minusBt1.Image = Global.dbase_kiosk.My.Resources.Resources.minus_bt
        Me.minusBt1.Location = New System.Drawing.Point(1081, 518)
        Me.minusBt1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.minusBt1.Name = "minusBt1"
        Me.minusBt1.Size = New System.Drawing.Size(75, 75)
        Me.minusBt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minusBt1.TabIndex = 17
        Me.minusBt1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.top_mid
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 1065)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1350, 38)
        Me.Panel4.TabIndex = 7
        '
        'SelectedSchePanel
        '
        Me.SelectedSchePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SelectedSchePanel.Location = New System.Drawing.Point(0, 139)
        Me.SelectedSchePanel.Name = "SelectedSchePanel"
        Me.SelectedSchePanel.Size = New System.Drawing.Size(1350, 372)
        Me.SelectedSchePanel.TabIndex = 26
        '
        'SeatInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 1241)
        Me.Controls.Add(Me.SelectedSchePanel)
        Me.Controls.Add(Me.plusBt4)
        Me.Controls.Add(Me.minusBt4)
        Me.Controls.Add(Me.plusBt3)
        Me.Controls.Add(Me.minusBt3)
        Me.Controls.Add(Me.plusBt2)
        Me.Controls.Add(Me.minusBt2)
        Me.Controls.Add(Me.totalSeatLabel)
        Me.Controls.Add(Me.plusBt1)
        Me.Controls.Add(Me.minusBt1)
        Me.Controls.Add(Me.elderSeatLabel)
        Me.Controls.Add(Me.disabSeatLabel)
        Me.Controls.Add(Me.youthSeatLabel)
        Me.Controls.Add(Me.normalSeatLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SubLabel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SeatInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SeatInfoForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.plusBt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusBt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plusBt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusBt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plusBt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusBt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plusBt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusBt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents SubLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents elderSeatLabel As Label
    Friend WithEvents disabSeatLabel As Label
    Friend WithEvents youthSeatLabel As Label
    Friend WithEvents normalSeatLabel As Label
    Friend WithEvents minusBt1 As PictureBox
    Friend WithEvents SeatSelectButton As Button
    Friend WithEvents plusBt1 As PictureBox
    Friend WithEvents totalSeatLabel As Label
    Friend WithEvents plusBt2 As PictureBox
    Friend WithEvents minusBt2 As PictureBox
    Friend WithEvents plusBt3 As PictureBox
    Friend WithEvents minusBt3 As PictureBox
    Friend WithEvents plusBt4 As PictureBox
    Friend WithEvents minusBt4 As PictureBox
    Friend WithEvents SelectedSchePanel As Panel
End Class
