<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindTicketForm
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
        Me.RightTitle = New System.Windows.Forms.Label()
        Me.LeftTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.SubPanel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RightTitle)
        Me.Panel1.Controls.Add(Me.LeftTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.Panel1.Size = New System.Drawing.Size(1350, 138)
        Me.Panel1.TabIndex = 0
        '
        'RightTitle
        '
        Me.RightTitle.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightTitle.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.RightTitle.Location = New System.Drawing.Point(740, 0)
        Me.RightTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RightTitle.Name = "RightTitle"
        Me.RightTitle.Size = New System.Drawing.Size(585, 138)
        Me.RightTitle.TabIndex = 1
        Me.RightTitle.Text = "DBASE 안산점"
        Me.RightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LeftTitle
        '
        Me.LeftTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftTitle.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.LeftTitle.Location = New System.Drawing.Point(25, 0)
        Me.LeftTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LeftTitle.Name = "LeftTitle"
        Me.LeftTitle.Size = New System.Drawing.Size(651, 138)
        Me.LeftTitle.TabIndex = 0
        Me.LeftTitle.Text = "표 조회/출력"
        Me.LeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 1278)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1350, 138)
        Me.Panel2.TabIndex = 1
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.SubPanel1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 176)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1350, 1064)
        Me.MainPanel.TabIndex = 4
        '
        'SubPanel1
        '
        Me.SubPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SubPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubPanel1.Name = "SubPanel1"
        Me.SubPanel1.Size = New System.Drawing.Size(1350, 1064)
        Me.SubPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.top_mid
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 1240)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1350, 38)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.bottom_mid
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 138)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1350, 38)
        Me.Panel3.TabIndex = 2
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
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "< 돌아가기"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FindTicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 1416)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FindTicketForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FindTicketForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RightTitle As Label
    Friend WithEvents LeftTitle As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SubPanel1 As Panel
    Friend WithEvents Button1 As Button
End Class
