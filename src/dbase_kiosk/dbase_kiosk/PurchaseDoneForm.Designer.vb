<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseDoneForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TIcketCodeLabel = New System.Windows.Forms.Label()
        Me.QRPB = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.QRPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PurchaseButton)
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
        Me.PurchaseButton.FlatAppearance.BorderSize = 0
        Me.PurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PurchaseButton.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 38.0!)
        Me.PurchaseButton.ForeColor = System.Drawing.Color.White
        Me.PurchaseButton.Location = New System.Drawing.Point(325, 0)
        Me.PurchaseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(670, 138)
        Me.PurchaseButton.TabIndex = 1
        Me.PurchaseButton.Text = "초기 화면으로"
        Me.PurchaseButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 40.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1241, 107)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "결제 및 예매가 완료되었습니다."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 25.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1241, 73)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "아래 QR코드를 찍어 모바일 티켓을 확인하실 수 있습니다."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 805)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1241, 73)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "예매 코드:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIcketCodeLabel
        '
        Me.TIcketCodeLabel.Font = New System.Drawing.Font("Roboto Condensed", 55.0!)
        Me.TIcketCodeLabel.ForeColor = System.Drawing.Color.White
        Me.TIcketCodeLabel.Location = New System.Drawing.Point(46, 878)
        Me.TIcketCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TIcketCodeLabel.Name = "TIcketCodeLabel"
        Me.TIcketCodeLabel.Size = New System.Drawing.Size(1241, 115)
        Me.TIcketCodeLabel.TabIndex = 16
        Me.TIcketCodeLabel.Text = "00-0000-0000"
        Me.TIcketCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QRPB
        '
        Me.QRPB.Location = New System.Drawing.Point(402, 258)
        Me.QRPB.Name = "QRPB"
        Me.QRPB.Size = New System.Drawing.Size(510, 510)
        Me.QRPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.QRPB.TabIndex = 17
        Me.QRPB.TabStop = False
        '
        'PurchaseDoneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 1241)
        Me.Controls.Add(Me.QRPB)
        Me.Controls.Add(Me.TIcketCodeLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PurchaseDoneForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PurchaseDone"
        Me.Panel2.ResumeLayout(False)
        CType(Me.QRPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TIcketCodeLabel As Label
    Friend WithEvents QRPB As PictureBox
End Class
