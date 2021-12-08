<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneNumForm
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PhoneNumTB = New System.Windows.Forms.TextBox()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.bt6 = New System.Windows.Forms.Button()
        Me.bt5 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.bt9 = New System.Windows.Forms.Button()
        Me.bt8 = New System.Windows.Forms.Button()
        Me.bt7 = New System.Windows.Forms.Button()
        Me.backsp_bt = New System.Windows.Forms.Button()
        Me.bt0 = New System.Windows.Forms.Button()
        Me.clear_bt = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SubmitButton)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1103)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1350, 138)
        Me.Panel2.TabIndex = 11
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.SubmitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SubmitButton.FlatAppearance.BorderSize = 0
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 38.0!)
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.Location = New System.Drawing.Point(826, 0)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(524, 138)
        Me.SubmitButton.TabIndex = 1
        Me.SubmitButton.Text = "예매하기"
        Me.SubmitButton.UseVisualStyleBackColor = False
        Me.SubmitButton.Visible = False
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
        Me.Label1.Size = New System.Drawing.Size(400, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "전화번호 입력"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(46, 189)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(869, 60)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "적립/조회를 위한 전화번호를 입력해 주세요"
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
        'PhoneNumTB
        '
        Me.PhoneNumTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneNumTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneNumTB.Font = New System.Drawing.Font("맑은 고딕 Semilight", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PhoneNumTB.ForeColor = System.Drawing.Color.White
        Me.PhoneNumTB.Location = New System.Drawing.Point(56, 284)
        Me.PhoneNumTB.Name = "PhoneNumTB"
        Me.PhoneNumTB.ReadOnly = True
        Me.PhoneNumTB.Size = New System.Drawing.Size(1253, 134)
        Me.PhoneNumTB.TabIndex = 14
        Me.PhoneNumTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt2.FlatAppearance.BorderSize = 0
        Me.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt2.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt2.Location = New System.Drawing.Point(557, 451)
        Me.bt2.Margin = New System.Windows.Forms.Padding(5)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(202, 137)
        Me.bt2.TabIndex = 17
        Me.bt2.Text = "2"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'bt3
        '
        Me.bt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt3.FlatAppearance.BorderSize = 0
        Me.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt3.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt3.Location = New System.Drawing.Point(769, 451)
        Me.bt3.Margin = New System.Windows.Forms.Padding(5)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(202, 137)
        Me.bt3.TabIndex = 18
        Me.bt3.Text = "3"
        Me.bt3.UseVisualStyleBackColor = False
        '
        'bt6
        '
        Me.bt6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt6.FlatAppearance.BorderSize = 0
        Me.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt6.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt6.Location = New System.Drawing.Point(769, 598)
        Me.bt6.Margin = New System.Windows.Forms.Padding(5)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(202, 137)
        Me.bt6.TabIndex = 21
        Me.bt6.Text = "6"
        Me.bt6.UseVisualStyleBackColor = False
        '
        'bt5
        '
        Me.bt5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt5.FlatAppearance.BorderSize = 0
        Me.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt5.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt5.Location = New System.Drawing.Point(557, 598)
        Me.bt5.Margin = New System.Windows.Forms.Padding(5)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(202, 137)
        Me.bt5.TabIndex = 20
        Me.bt5.Text = "5"
        Me.bt5.UseVisualStyleBackColor = False
        '
        'bt4
        '
        Me.bt4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt4.FlatAppearance.BorderSize = 0
        Me.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt4.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt4.Location = New System.Drawing.Point(345, 598)
        Me.bt4.Margin = New System.Windows.Forms.Padding(5)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(202, 137)
        Me.bt4.TabIndex = 19
        Me.bt4.Text = "4"
        Me.bt4.UseVisualStyleBackColor = False
        '
        'bt9
        '
        Me.bt9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt9.FlatAppearance.BorderSize = 0
        Me.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt9.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt9.Location = New System.Drawing.Point(769, 745)
        Me.bt9.Margin = New System.Windows.Forms.Padding(5)
        Me.bt9.Name = "bt9"
        Me.bt9.Size = New System.Drawing.Size(202, 137)
        Me.bt9.TabIndex = 24
        Me.bt9.Text = "9"
        Me.bt9.UseVisualStyleBackColor = False
        '
        'bt8
        '
        Me.bt8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt8.FlatAppearance.BorderSize = 0
        Me.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt8.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt8.Location = New System.Drawing.Point(557, 745)
        Me.bt8.Margin = New System.Windows.Forms.Padding(5)
        Me.bt8.Name = "bt8"
        Me.bt8.Size = New System.Drawing.Size(202, 137)
        Me.bt8.TabIndex = 23
        Me.bt8.Text = "8"
        Me.bt8.UseVisualStyleBackColor = False
        '
        'bt7
        '
        Me.bt7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt7.FlatAppearance.BorderSize = 0
        Me.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt7.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt7.Location = New System.Drawing.Point(345, 745)
        Me.bt7.Margin = New System.Windows.Forms.Padding(5)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(202, 137)
        Me.bt7.TabIndex = 22
        Me.bt7.Text = "7"
        Me.bt7.UseVisualStyleBackColor = False
        '
        'backsp_bt
        '
        Me.backsp_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.backsp_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backsp_bt.FlatAppearance.BorderSize = 0
        Me.backsp_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backsp_bt.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.backsp_bt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.backsp_bt.Location = New System.Drawing.Point(769, 892)
        Me.backsp_bt.Margin = New System.Windows.Forms.Padding(5)
        Me.backsp_bt.Name = "backsp_bt"
        Me.backsp_bt.Size = New System.Drawing.Size(202, 137)
        Me.backsp_bt.TabIndex = 27
        Me.backsp_bt.Text = "←"
        Me.backsp_bt.UseVisualStyleBackColor = False
        '
        'bt0
        '
        Me.bt0.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt0.FlatAppearance.BorderSize = 0
        Me.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt0.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt0.Location = New System.Drawing.Point(557, 892)
        Me.bt0.Margin = New System.Windows.Forms.Padding(5)
        Me.bt0.Name = "bt0"
        Me.bt0.Size = New System.Drawing.Size(202, 137)
        Me.bt0.TabIndex = 26
        Me.bt0.Text = "0"
        Me.bt0.UseVisualStyleBackColor = False
        '
        'clear_bt
        '
        Me.clear_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.clear_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clear_bt.FlatAppearance.BorderSize = 0
        Me.clear_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_bt.Font = New System.Drawing.Font("AppleSDGothicNeoM00", 20.0!)
        Me.clear_bt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.clear_bt.Location = New System.Drawing.Point(345, 892)
        Me.clear_bt.Margin = New System.Windows.Forms.Padding(5)
        Me.clear_bt.Name = "clear_bt"
        Me.clear_bt.Size = New System.Drawing.Size(202, 137)
        Me.clear_bt.TabIndex = 25
        Me.clear_bt.Text = "비우기"
        Me.clear_bt.UseVisualStyleBackColor = False
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt1.FlatAppearance.BorderSize = 0
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.bt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bt1.Location = New System.Drawing.Point(345, 451)
        Me.bt1.Margin = New System.Windows.Forms.Padding(5)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(202, 137)
        Me.bt1.TabIndex = 16
        Me.bt1.Text = "1"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'PhoneNumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 1241)
        Me.Controls.Add(Me.backsp_bt)
        Me.Controls.Add(Me.bt0)
        Me.Controls.Add(Me.clear_bt)
        Me.Controls.Add(Me.bt9)
        Me.Controls.Add(Me.bt8)
        Me.Controls.Add(Me.bt7)
        Me.Controls.Add(Me.bt6)
        Me.Controls.Add(Me.bt5)
        Me.Controls.Add(Me.bt4)
        Me.Controls.Add(Me.bt3)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.PhoneNumTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PhoneNumForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PhoneNumForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PhoneNumTB As TextBox
    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents backsp_bt As Button
    Friend WithEvents bt0 As Button
    Friend WithEvents clear_bt As Button
End Class
