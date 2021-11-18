<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovieSelectForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SubPanel1 = New System.Windows.Forms.Panel()
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.MovieSelectionCtrl3 = New dbase_kiosk.MovieSelectionCtrl()
        Me.MovieSelectionCtrl2 = New dbase_kiosk.MovieSelectionCtrl()
        Me.MovieSelectionCtrl1 = New dbase_kiosk.MovieSelectionCtrl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SubPanel1.SuspendLayout()
        Me.ListPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 883)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1080, 110)
        Me.Panel2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 38.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(661, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(419, 110)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "인원 설정하기"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 30.0!)
        Me.Button1.ForeColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(433, 110)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "< 돌아가기"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SubPanel1
        '
        Me.SubPanel1.Controls.Add(Me.Panel3)
        Me.SubPanel1.Controls.Add(Me.ListPanel)
        Me.SubPanel1.Controls.Add(Me.Panel1)
        Me.SubPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SubPanel1.Name = "SubPanel1"
        Me.SubPanel1.Size = New System.Drawing.Size(1080, 853)
        Me.SubPanel1.TabIndex = 6
        '
        'ListPanel
        '
        Me.ListPanel.AutoScroll = True
        Me.ListPanel.Controls.Add(Me.MovieSelectionCtrl3)
        Me.ListPanel.Controls.Add(Me.MovieSelectionCtrl2)
        Me.ListPanel.Controls.Add(Me.MovieSelectionCtrl1)
        Me.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPanel.Location = New System.Drawing.Point(0, 187)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Padding = New System.Windows.Forms.Padding(20, 0, 17, 0)
        Me.ListPanel.Size = New System.Drawing.Size(1080, 666)
        Me.ListPanel.TabIndex = 1
        '
        'MovieSelectionCtrl3
        '
        Me.MovieSelectionCtrl3.BackColor = System.Drawing.Color.Transparent
        Me.MovieSelectionCtrl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovieSelectionCtrl3.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MovieSelectionCtrl3.ForeColor = System.Drawing.Color.White
        Me.MovieSelectionCtrl3.Location = New System.Drawing.Point(20, 584)
        Me.MovieSelectionCtrl3.Name = "MovieSelectionCtrl3"
        Me.MovieSelectionCtrl3.Size = New System.Drawing.Size(1026, 292)
        Me.MovieSelectionCtrl3.TabIndex = 2
        '
        'MovieSelectionCtrl2
        '
        Me.MovieSelectionCtrl2.BackColor = System.Drawing.Color.Transparent
        Me.MovieSelectionCtrl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovieSelectionCtrl2.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MovieSelectionCtrl2.ForeColor = System.Drawing.Color.White
        Me.MovieSelectionCtrl2.Location = New System.Drawing.Point(20, 292)
        Me.MovieSelectionCtrl2.Name = "MovieSelectionCtrl2"
        Me.MovieSelectionCtrl2.Size = New System.Drawing.Size(1026, 292)
        Me.MovieSelectionCtrl2.TabIndex = 1
        '
        'MovieSelectionCtrl1
        '
        Me.MovieSelectionCtrl1.BackColor = System.Drawing.Color.Transparent
        Me.MovieSelectionCtrl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovieSelectionCtrl1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MovieSelectionCtrl1.ForeColor = System.Drawing.Color.White
        Me.MovieSelectionCtrl1.Location = New System.Drawing.Point(20, 0)
        Me.MovieSelectionCtrl1.Name = "MovieSelectionCtrl1"
        Me.MovieSelectionCtrl1.Size = New System.Drawing.Size(1026, 292)
        Me.MovieSelectionCtrl1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 187)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 38.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(536, 61)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2021년 12월 23일 목요일"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(681, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "예매하실 영화를 선택해 주세요"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.dbase_kiosk.My.Resources.Resources.top_mid
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 853)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1080, 30)
        Me.Panel4.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(1052, 177)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(50, 685)
        Me.Panel3.TabIndex = 2
        '
        'MovieSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 993)
        Me.Controls.Add(Me.SubPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("AppleSDGothicNeoB00", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MovieSelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MovieSelectForm"
        Me.Panel2.ResumeLayout(False)
        Me.SubPanel1.ResumeLayout(False)
        Me.ListPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SubPanel1 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListPanel As Panel
    Friend WithEvents MovieSelectionCtrl1 As MovieSelectionCtrl
    Friend WithEvents MovieSelectionCtrl3 As MovieSelectionCtrl
    Friend WithEvents MovieSelectionCtrl2 As MovieSelectionCtrl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
End Class
