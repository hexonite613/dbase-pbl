Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class MovieSelectForm
    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0

        TouchScroll.SetPanel(ListPanel)

        DateLabel.Text = Now.ToString("D")

        Dim provider As CultureInfo = CultureInfo.InvariantCulture

        DB_OPEN(0)
        DB_OPEN(1)

        Dim cmd As New MySqlCommand("", BP_CON(0))

        cmd.CommandText = "SELECT
    movie_id,
    sche_id,
    a.screen_id,
    screen_type,
    screen_name,
    NAME,
    name_eng,
    rating,
    poster,
    start_time,
    end_time
FROM
    (
    SELECT
        *,
        DATE_ADD(
            start_time,
            INTERVAL movie_time MINUTE
        ) AS end_time
    FROM schedule
NATURAL JOIN
    movie
WHERE
    theater_id = ?tid AND (start_time BETWEEN DATE(?stime) AND DATE(?stime) + 1) AND start_time > now()) a
JOIN
    screen
ON
    a.screen_id = screen.screen_id ORDER BY a.start_time DESC"
        cmd.Parameters.AddWithValue("?tid", MainForm.theater_id)
        cmd.Parameters.AddWithValue("?stime", Now.ToString("yyyy-MM-dd"))



        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("편성 데이터가 존재하지 않습니다.", vbExclamation)
            Else

                Do

                    Dim movieCtrl As New MovieSelectionCtrl

                    movieCtrl.Dock = DockStyle.Top

                    Dim totalseat As Integer = 0
                    Dim leftseat As Integer = 0

                    Dim cmd2 As New MySqlCommand("SELECT COUNT(*) as totalseat FROM screen_seat WHERE screen_id = ?sid AND available = 1", BP_CON(1))
                    cmd2.Parameters.AddWithValue("?sid", RS("screen_id"))

                    Using RS2 As MySqlDataReader = cmd2.ExecuteReader()

                        If Not RS2.Read() = False Then
                            totalseat = RS2("totalseat")
                        End If

                    End Using

                    cmd2.CommandText = "SELECT count(*) AS occupied FROM booking WHERE sche_id = ?sche_id"
                    cmd2.Parameters.AddWithValue("?sche_id", RS("sche_id"))

                    Using RS2 As MySqlDataReader = cmd2.ExecuteReader()

                        If Not RS2.Read() = False Then
                            leftseat = totalseat - RS2("occupied")
                        End If

                    End Using

                    With movieCtrl
                        .movie_title_label.Text = RS("name").ToString
                        .movie_engname_label.Text = RS("name_eng").ToString
                        .starttime_label.Text = Convert.ToDateTime(RS("start_time")).ToString("yyyy-MM-dd HH:mm")
                        .endtime_label.Text = Convert.ToDateTime(RS("end_time")).ToString("yyyy-MM-dd HH:mm")
                        .screen_name_label.Text = RS("screen_name")
                        .screen_type_label.Text = RS("screen_type")
                        .PosterPB.Load(RS("poster").ToString)
                        .seat_count_label.Text = leftseat.ToString + "석 남음 (" + totalseat.ToString + "석)"
                    End With

                    movieCtrl.SeatSelectButton.Name = RS("sche_id")
                    AddHandler movieCtrl.SeatSelectButton.Click, AddressOf selectEvent

                    ListPanel.Controls.Add(movieCtrl)

                Loop Until RS.Read() = False

                DB_CLOSE(1)

            End If

            cmd.Parameters.Clear()

        End Using

    End Sub

    Private Sub selectEvent(sender As Object, e As EventArgs)

        'MsgBox(sender.Name)
        SeatInfoForm.Close()
        SeatInfoForm.sche_id = Convert.ToInt32(sender.Name)
        SeatInfoForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        SeatInfoForm.Show()

    End Sub

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        If Not MainForm.ForceClose Then FadeOut(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class