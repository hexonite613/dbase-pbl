<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.detailPriceLabel = New System.Windows.Forms.Label()
        Me.sumPriceLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.kakaopay_lb = New System.Windows.Forms.Label()
        Me.payco_lb = New System.Windows.Forms.Label()
        Me.samsung_lb = New System.Windows.Forms.Label()
        Me.samsung_pb = New System.Windows.Forms.PictureBox()
        Me.payco_pb = New System.Windows.Forms.PictureBox()
        Me.kakaopay_pb = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.samsung_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payco_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kakaopay_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PurchaseButton)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1103)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1350, 138)
        Me.Panel2.TabIndex = 11
        '
        'PurchaseButton
        '
        Me.PurchaseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.PurchaseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.PurchaseButton.FlatAppearance.BorderSize = 0
        Me.PurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PurchaseButton.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 38.0!)
        Me.PurchaseButton.ForeColor = System.Drawing.Color.White
        Me.PurchaseButton.Location = New System.Drawing.Point(826, 0)
        Me.PurchaseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(524, 138)
        Me.PurchaseButton.TabIndex = 1
        Me.PurchaseButton.Text = "예매하기"
        Me.PurchaseButton.UseVisualStyleBackColor = False
        Me.PurchaseButton.Visible = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Button1.ForeColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(541, 138)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "< 좌석 선택으로"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 139)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "결제 진행"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(46, 189)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 60)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "결제금액"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 275)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 144)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "일반" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "청소년" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "장애인" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "경로"
        '
        'detailPriceLabel
        '
        Me.detailPriceLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.detailPriceLabel.ForeColor = System.Drawing.Color.White
        Me.detailPriceLabel.Location = New System.Drawing.Point(190, 275)
        Me.detailPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.detailPriceLabel.Name = "detailPriceLabel"
        Me.detailPriceLabel.Size = New System.Drawing.Size(215, 145)
        Me.detailPriceLabel.TabIndex = 15
        Me.detailPriceLabel.Text = "13000₩ × 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10000₩ × 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5000₩ × 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6000₩ × 0"
        Me.detailPriceLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'sumPriceLabel
        '
        Me.sumPriceLabel.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 55.0!)
        Me.sumPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sumPriceLabel.Location = New System.Drawing.Point(429, 275)
        Me.sumPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sumPriceLabel.Name = "sumPriceLabel"
        Me.sumPriceLabel.Size = New System.Drawing.Size(842, 145)
        Me.sumPriceLabel.TabIndex = 16
        Me.sumPriceLabel.Text = "000000 ₩"
        Me.sumPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1085, 189)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 60)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "총 금액"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(154, 521)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1034, 60)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "결제 수단을 선택하세요"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 1065)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1350, 38)
        Me.Panel4.TabIndex = 12
        '
        'kakaopay_lb
        '
        Me.kakaopay_lb.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.kakaopay_lb.ForeColor = System.Drawing.Color.White
        Me.kakaopay_lb.Location = New System.Drawing.Point(154, 955)
        Me.kakaopay_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.kakaopay_lb.Name = "kakaopay_lb"
        Me.kakaopay_lb.Size = New System.Drawing.Size(325, 81)
        Me.kakaopay_lb.TabIndex = 22
        Me.kakaopay_lb.Text = "카카오페이"
        Me.kakaopay_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'payco_lb
        '
        Me.payco_lb.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.payco_lb.ForeColor = System.Drawing.Color.White
        Me.payco_lb.Location = New System.Drawing.Point(509, 955)
        Me.payco_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.payco_lb.Name = "payco_lb"
        Me.payco_lb.Size = New System.Drawing.Size(325, 81)
        Me.payco_lb.TabIndex = 23
        Me.payco_lb.Text = "페이코"
        Me.payco_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'samsung_lb
        '
        Me.samsung_lb.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 20.0!)
        Me.samsung_lb.ForeColor = System.Drawing.Color.White
        Me.samsung_lb.Location = New System.Drawing.Point(862, 955)
        Me.samsung_lb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.samsung_lb.Name = "samsung_lb"
        Me.samsung_lb.Size = New System.Drawing.Size(325, 81)
        Me.samsung_lb.TabIndex = 24
        Me.samsung_lb.Text = "삼성페이"
        Me.samsung_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'samsung_pb
        '
        Me.samsung_pb.Image = Global.dbase_kiosk.My.Resources.Resources.paymethod_samsung
        Me.samsung_pb.Location = New System.Drawing.Point(862, 630)
        Me.samsung_pb.Margin = New System.Windows.Forms.Padding(0)
        Me.samsung_pb.Name = "samsung_pb"
        Me.samsung_pb.Size = New System.Drawing.Size(325, 325)
        Me.samsung_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.samsung_pb.TabIndex = 20
        Me.samsung_pb.TabStop = False
        '
        'payco_pb
        '
        Me.payco_pb.Image = Global.dbase_kiosk.My.Resources.Resources.paymethod_payco
        Me.payco_pb.Location = New System.Drawing.Point(509, 630)
        Me.payco_pb.Margin = New System.Windows.Forms.Padding(0)
        Me.payco_pb.Name = "payco_pb"
        Me.payco_pb.Size = New System.Drawing.Size(325, 325)
        Me.payco_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.payco_pb.TabIndex = 19
        Me.payco_pb.TabStop = False
        '
        'kakaopay_pb
        '
        Me.kakaopay_pb.Image = Global.dbase_kiosk.My.Resources.Resources.paymethod_kakao
        Me.kakaopay_pb.Location = New System.Drawing.Point(154, 630)
        Me.kakaopay_pb.Margin = New System.Windows.Forms.Padding(0)
        Me.kakaopay_pb.Name = "kakaopay_pb"
        Me.kakaopay_pb.Size = New System.Drawing.Size(325, 325)
        Me.kakaopay_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.kakaopay_pb.TabIndex = 18
        Me.kakaopay_pb.TabStop = False
        '
        'PurchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 1241)
        Me.Controls.Add(Me.samsung_lb)
        Me.Controls.Add(Me.payco_lb)
        Me.Controls.Add(Me.kakaopay_lb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.samsung_pb)
        Me.Controls.Add(Me.payco_pb)
        Me.Controls.Add(Me.kakaopay_pb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.sumPriceLabel)
        Me.Controls.Add(Me.detailPriceLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PurchaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PurchaseForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.samsung_pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payco_pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kakaopay_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents detailPriceLabel As Label
    Friend WithEvents sumPriceLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents kakaopay_pb As PictureBox
    Friend WithEvents payco_pb As PictureBox
    Friend WithEvents samsung_pb As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents kakaopay_lb As Label
    Friend WithEvents payco_lb As Label
    Friend WithEvents samsung_lb As Label
End Class
