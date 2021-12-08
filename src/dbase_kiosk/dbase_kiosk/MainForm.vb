Imports System.Globalization

'오리지널 사이즈 1080, 1133

Public Class MainForm
    Public theater_id = "ansan"
    Public ForceClose As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DB_INITIATE("", "", 3306, "", "")
    End Sub

    Private Sub main_bt_MouseEnter(sender As Object, e As EventArgs) Handles buy_ticket_bt.MouseEnter, chk_prnt_bt.MouseEnter
        sender.BackColor = Color.FromArgb(71, 48, 114)
    End Sub

    Private Sub main_bt_MouseLeave(sender As Object, e As EventArgs) Handles buy_ticket_bt.MouseLeave, chk_prnt_bt.MouseLeave
        sender.BackColor = Color.FromArgb(95, 65, 150)
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        MainTimeLabel.Text = Now.ToString("HH:mm")
        MainTimeLabelAMPM.Text = Now.ToString("tt", New CultureInfo("en-US"))
        LeftTitle.Text = Now.ToString("D")
    End Sub

    Private Sub buy_ticket_bt_Click(sender As Object, e As EventArgs) Handles buy_ticket_bt.Click
        MovieSelectForm.SetDesktopLocation(Location.X + MainPanel.Location.X, Location.Y + MainPanel.Location.Y)
        MovieSelectForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Browser.Show()
    End Sub

End Class
