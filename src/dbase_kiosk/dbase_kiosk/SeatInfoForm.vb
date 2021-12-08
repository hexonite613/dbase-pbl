Imports MySql.Data.MySqlClient

Public Class SeatInfoForm
    Public sche_id As Integer = -1
    Public screen_id As Integer = -1

    Public availableSeat As Integer = 5
    Dim currentseat As Integer = 0

    Public seat_normal As Integer = 0
    Public seat_youth As Integer = 0
    Public seat_disab As Integer = 0
    Public seat_elder As Integer = 0


    Private Sub Common_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = 0

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
    sche_id = ?sid
LIMIT 20) a
JOIN
    screen
ON
    a.screen_id = screen.screen_id"
        cmd.Parameters.AddWithValue("?sid", sche_id)

        Using RS As MySqlDataReader = cmd.ExecuteReader()

            If RS.Read() = False Then
                MsgBox("편성 데이터가 존재하지 않습니다.", vbExclamation)
            Else

                Do

                    Dim movieCtrl As New MovieSelectionCtrl

                    movieCtrl.Dock = DockStyle.Fill

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
                        .starttime_label.Text = Convert.ToDateTime(RS("start_time")).ToString("HH:mm")
                        .endtime_label.Text = Convert.ToDateTime(RS("end_time")).ToString("HH:mm")
                        .screen_name_label.Text = RS("screen_name")
                        .screen_type_label.Text = RS("screen_type")
                        .PosterPB.Load(RS("poster").ToString)
                        .seat_count_label.Text = leftseat.ToString + "석 남음 (" + totalseat.ToString + "석)"
                        .SeatSelectButton.Visible = False
                    End With

                    SelectedSchePanel.Controls.Add(movieCtrl)

                    availableSeat = leftseat
                    screen_id = RS("screen_id")

                Loop Until RS.Read() = False

                DB_CLOSE(1)

            End If

            cmd.Parameters.Clear()

        End Using

        SubLabel1.Text = "관람 인원수" + vbCrLf + "(" + availableSeat.ToString + "명 가능)"
        BtnCheck()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SeatSelectButton.Click
        SeatSelectionForm.Close()
        SeatSelectionForm.SetDesktopLocation(MainForm.Location.X + MainForm.MainPanel.Location.X,
                                            MainForm.Location.Y + MainForm.MainPanel.Location.Y)
        SeatSelectionForm.seatcount = currentseat
        SeatSelectionForm.screenId = screen_id
        SeatSelectionForm.sche_id = sche_id
        SeatSelectionForm.Show()
    End Sub

    Private Sub mpbutton_Click(sender As Object, e As EventArgs) Handles minusBt1.Click, minusBt2.Click,
        minusBt3.Click, minusBt4.Click, plusBt1.Click, plusBt2.Click, plusBt3.Click, plusBt4.Click

        Dim bt As PictureBox = sender

        If bt.Name.Contains("minus") Then
            If currentseat <= 0 Then
                Exit Sub
            End If

            Select Case bt.Name
                Case "minusBt1"
                    If seat_normal > 0 Then seat_normal -= 1
                Case "minusBt2"
                    If seat_youth > 0 Then seat_youth -= 1
                Case "minusBt3"
                    If seat_disab > 0 Then seat_disab -= 1
                Case "minusBt4"
                    If seat_elder > 0 Then seat_elder -= 1
            End Select
        Else
            If currentseat >= availableSeat Then
                Exit Sub
            End If

            Select Case bt.Name
                Case "plusBt1"
                    seat_normal += 1
                Case "plusBt2"
                    seat_youth += 1
                Case "plusBt3"
                    seat_disab += 1
                Case "plusBt4"
                    seat_elder += 1
            End Select

        End If

        normalSeatLabel.Text = seat_normal.ToString + "명"
        youthSeatLabel.Text = seat_youth.ToString + "명"
        disabSeatLabel.Text = seat_disab.ToString + "명"
        elderSeatLabel.Text = seat_elder.ToString + "명"

        currentseat = seat_normal + seat_youth + seat_disab + seat_elder
        totalSeatLabel.Text = "총 " + currentseat.ToString + "명"

        BtnCheck()
    End Sub

    Sub BtnCheck()
        If seat_normal <= 0 Then
            minusBt1.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt1.BackColor = Color.Gray
        End If

        If seat_youth <= 0 Then
            minusBt2.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt2.BackColor = Color.Gray
        End If

        If seat_disab <= 0 Then
            minusBt3.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt3.BackColor = Color.Gray
        End If

        If seat_elder <= 0 Then
            minusBt4.BackColor = Color.FromArgb(64, 64, 64)
        Else
            minusBt4.BackColor = Color.Gray
        End If

        If currentseat >= availableSeat Then
            plusBt1.BackColor = Color.FromArgb(64, 64, 64)
            plusBt2.BackColor = Color.FromArgb(64, 64, 64)
            plusBt3.BackColor = Color.FromArgb(64, 64, 64)
            plusBt4.BackColor = Color.FromArgb(64, 64, 64)
        Else
            plusBt1.BackColor = Color.Gray
            plusBt2.BackColor = Color.Gray
            plusBt3.BackColor = Color.Gray
            plusBt4.BackColor = Color.Gray
        End If

        SeatSelectButton.Visible = currentseat > 0
    End Sub
End Class