<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenEditForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.scr_id_tb = New System.Windows.Forms.TextBox()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.scr_type_cb = New System.Windows.Forms.ComboBox()
        Me.getCurrentTheaterIDbt = New System.Windows.Forms.Button()
        Me.scr_name_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.theater_id_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "상영관 ID"
        '
        'scr_id_tb
        '
        Me.scr_id_tb.Location = New System.Drawing.Point(116, 25)
        Me.scr_id_tb.Name = "scr_id_tb"
        Me.scr_id_tb.Size = New System.Drawing.Size(493, 27)
        Me.scr_id_tb.TabIndex = 2
        '
        'SaveBT
        '
        Me.SaveBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBT.Location = New System.Drawing.Point(475, 14)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(157, 39)
        Me.SaveBT.TabIndex = 0
        Me.SaveBT.Text = "저장"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'DeleteBT
        '
        Me.DeleteBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBT.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBT.Location = New System.Drawing.Point(374, 14)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(95, 39)
        Me.DeleteBT.TabIndex = 1
        Me.DeleteBT.Text = "삭제"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.scr_type_cb)
        Me.Panel3.Controls.Add(Me.getCurrentTheaterIDbt)
        Me.Panel3.Controls.Add(Me.scr_name_tb)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.theater_id_tb)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.scr_id_tb)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(644, 187)
        Me.Panel3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "상영방식"
        '
        'scr_type_cb
        '
        Me.scr_type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.scr_type_cb.FormattingEnabled = True
        Me.scr_type_cb.Items.AddRange(New Object() {"2D", "3D", "IMAX", "4DX"})
        Me.scr_type_cb.Location = New System.Drawing.Point(116, 128)
        Me.scr_type_cb.Name = "scr_type_cb"
        Me.scr_type_cb.Size = New System.Drawing.Size(493, 28)
        Me.scr_type_cb.TabIndex = 8
        '
        'getCurrentTheaterIDbt
        '
        Me.getCurrentTheaterIDbt.Font = New System.Drawing.Font("맑은 고딕", 7.0!)
        Me.getCurrentTheaterIDbt.Location = New System.Drawing.Point(418, 62)
        Me.getCurrentTheaterIDbt.Name = "getCurrentTheaterIDbt"
        Me.getCurrentTheaterIDbt.Size = New System.Drawing.Size(191, 27)
        Me.getCurrentTheaterIDbt.TabIndex = 7
        Me.getCurrentTheaterIDbt.Text = "현재 영화관 가져오기"
        Me.getCurrentTheaterIDbt.UseVisualStyleBackColor = True
        '
        'scr_name_tb
        '
        Me.scr_name_tb.Location = New System.Drawing.Point(116, 95)
        Me.scr_name_tb.Name = "scr_name_tb"
        Me.scr_name_tb.Size = New System.Drawing.Size(493, 27)
        Me.scr_name_tb.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "상영관명"
        '
        'theater_id_tb
        '
        Me.theater_id_tb.Location = New System.Drawing.Point(116, 62)
        Me.theater_id_tb.Name = "theater_id_tb"
        Me.theater_id_tb.Size = New System.Drawing.Size(296, 27)
        Me.theater_id_tb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "영화관 ID"
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
        Me.TitleLabel.Text = "상영관 정보 편집"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Size = New System.Drawing.Size(644, 86)
        Me.Panel1.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.DeleteBT)
        Me.Panel4.Controls.Add(Me.SaveBT)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 273)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(644, 65)
        Me.Panel4.TabIndex = 8
        '
        'ScreenEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 338)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Global.dbase_management.My.Resources.Resources.mng_icon
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScreenEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScreenEditForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents scr_id_tb As TextBox
    Friend WithEvents SaveBT As Button
    Friend WithEvents DeleteBT As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents scr_name_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents theater_id_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents getCurrentTheaterIDbt As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents scr_type_cb As ComboBox
End Class
