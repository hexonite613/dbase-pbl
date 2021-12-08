<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatEditForm
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.seat_col_tb = New System.Windows.Forms.TextBox()
        Me.seat_row_tb = New System.Windows.Forms.TextBox()
        Me.add_seat_bt = New System.Windows.Forms.Button()
        Me.enable_bt = New System.Windows.Forms.Button()
        Me.disable_bt = New System.Windows.Forms.Button()
        Me.SeatListView = New System.Windows.Forms.ListView()
        Me.col_scr_seat_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_row = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_col = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_sid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_scr_seat_cond = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scr_seat_table = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.SaveBT)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 609)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1138, 65)
        Me.Panel4.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(461, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*열 칸에 ""!""를 입력하면 해당 번호까지 순차적으로 일괄 입력됩니다"
        '
        'SaveBT
        '
        Me.SaveBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBT.Location = New System.Drawing.Point(969, 14)
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
        Me.DeleteBT.Location = New System.Drawing.Point(433, 481)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(93, 33)
        Me.DeleteBT.TabIndex = 1
        Me.DeleteBT.Text = "삭제/복구"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(25, 25)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(395, 32)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "좌석 편집"
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
        Me.Panel1.Size = New System.Drawing.Size(1138, 82)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SplitContainer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1138, 527)
        Me.Panel3.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1138, 527)
        Me.SplitContainer1.SplitterDistance = 539
        Me.SplitContainer1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.seat_col_tb)
        Me.Panel2.Controls.Add(Me.seat_row_tb)
        Me.Panel2.Controls.Add(Me.add_seat_bt)
        Me.Panel2.Controls.Add(Me.enable_bt)
        Me.Panel2.Controls.Add(Me.disable_bt)
        Me.Panel2.Controls.Add(Me.DeleteBT)
        Me.Panel2.Controls.Add(Me.SeatListView)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(539, 527)
        Me.Panel2.TabIndex = 0
        '
        'seat_col_tb
        '
        Me.seat_col_tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seat_col_tb.Location = New System.Drawing.Point(292, 484)
        Me.seat_col_tb.Name = "seat_col_tb"
        Me.seat_col_tb.Size = New System.Drawing.Size(49, 27)
        Me.seat_col_tb.TabIndex = 25
        '
        'seat_row_tb
        '
        Me.seat_row_tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seat_row_tb.Location = New System.Drawing.Point(237, 484)
        Me.seat_row_tb.Name = "seat_row_tb"
        Me.seat_row_tb.Size = New System.Drawing.Size(49, 27)
        Me.seat_row_tb.TabIndex = 24
        '
        'add_seat_bt
        '
        Me.add_seat_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_seat_bt.Location = New System.Drawing.Point(347, 481)
        Me.add_seat_bt.Name = "add_seat_bt"
        Me.add_seat_bt.Size = New System.Drawing.Size(80, 33)
        Me.add_seat_bt.TabIndex = 23
        Me.add_seat_bt.Text = "추가*"
        Me.add_seat_bt.UseVisualStyleBackColor = True
        '
        'enable_bt
        '
        Me.enable_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.enable_bt.Location = New System.Drawing.Point(124, 481)
        Me.enable_bt.Name = "enable_bt"
        Me.enable_bt.Size = New System.Drawing.Size(106, 33)
        Me.enable_bt.TabIndex = 22
        Me.enable_bt.Text = "활성화"
        Me.enable_bt.UseVisualStyleBackColor = True
        '
        'disable_bt
        '
        Me.disable_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.disable_bt.Location = New System.Drawing.Point(12, 481)
        Me.disable_bt.Name = "disable_bt"
        Me.disable_bt.Size = New System.Drawing.Size(106, 33)
        Me.disable_bt.TabIndex = 21
        Me.disable_bt.Text = "비활성화"
        Me.disable_bt.UseVisualStyleBackColor = True
        '
        'SeatListView
        '
        Me.SeatListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeatListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_scr_seat_id, Me.col_scr_seat_row, Me.col_scr_seat_col, Me.col_scr_seat_sid, Me.col_scr_seat_cond})
        Me.SeatListView.FullRowSelect = True
        Me.SeatListView.HideSelection = False
        Me.SeatListView.Location = New System.Drawing.Point(13, 36)
        Me.SeatListView.Name = "SeatListView"
        Me.SeatListView.Size = New System.Drawing.Size(513, 439)
        Me.SeatListView.TabIndex = 20
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
        'col_scr_seat_cond
        '
        Me.col_scr_seat_cond.Text = "상태"
        Me.col_scr_seat_cond.Width = 120
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(13, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 23)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "좌석 목록"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.scr_seat_table)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(595, 527)
        Me.Panel5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(138, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "S C R E E N"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scr_seat_table
        '
        Me.scr_seat_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr_seat_table.BackColor = System.Drawing.Color.Transparent
        Me.scr_seat_table.ColumnCount = 1
        Me.scr_seat_table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scr_seat_table.Location = New System.Drawing.Point(19, 63)
        Me.scr_seat_table.Margin = New System.Windows.Forms.Padding(0)
        Me.scr_seat_table.Name = "scr_seat_table"
        Me.scr_seat_table.RowCount = 1
        Me.scr_seat_table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scr_seat_table.Size = New System.Drawing.Size(551, 432)
        Me.scr_seat_table.TabIndex = 26
        '
        'SeatEditForm
        '
        Me.AcceptButton = Me.add_seat_bt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1138, 674)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.Icon = Global.dbase_management.My.Resources.Resources.mng_icon
        Me.Name = "SeatEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "좌석 편집"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents DeleteBT As Button
    Friend WithEvents SaveBT As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents seat_col_tb As TextBox
    Friend WithEvents seat_row_tb As TextBox
    Friend WithEvents add_seat_bt As Button
    Friend WithEvents enable_bt As Button
    Friend WithEvents disable_bt As Button
    Friend WithEvents SeatListView As ListView
    Friend WithEvents col_scr_seat_id As ColumnHeader
    Friend WithEvents col_scr_seat_row As ColumnHeader
    Friend WithEvents col_scr_seat_col As ColumnHeader
    Friend WithEvents col_scr_seat_sid As ColumnHeader
    Friend WithEvents col_scr_seat_cond As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents scr_seat_table As TableLayoutPanel
    Friend WithEvents Label2 As Label
End Class
