Imports MySql.Data.MySqlClient

Public Class FilmEditForm
    Public movieId As Integer = -1
    Public editmode As Boolean = True
    Public readonlymode As Boolean = False
    Public listindex As Integer = -1

    Dim posterEditMode As Boolean = False
    Dim genreidlist As New List(Of String)
    Dim genrenamelist As New List(Of String)
    Dim ratinglist As New List(Of String)

    Dim movie_id, genre_id, movie_time As Integer
    Dim _name, name_eng, description, country, rating, poster, posterUrl As String
    Dim release_date As Date

    Private Sub FilmEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PosterUrlTB.Enabled = posterEditMode

        If readonlymode Then '열람 모드일 경우
            DeleteBT.Enabled = False
            DeleteBT.Visible = False

            Panel5.Enabled = False
            Panel6.Enabled = False

            filminfo_description_tb.ReadOnly = True

            TitleLabel.Text = "영화 정보"
            Text = "영화 정보"
            SaveBT.Text = "닫기"

        Else

            If editmode Then '편집 모드
                DeleteBT.Enabled = True
                TitleLabel.Text = "영화 정보 편집"
                Text = "영화 정보 편집"
            Else '추가 모드
                DeleteBT.Enabled = False
                TitleLabel.Text = "영화 정보 추가"
                Text = "영화 정보 추가"
            End If

        End If



        If movieId = -1 And editmode Then
            MsgBox("영화 정보가 로드되지 않았습니다", vbCritical)
            Close()
        Else
            getFilmInfo()

            filminfo_genre_id_cb.Items.Clear()

            For i = 0 To genreidlist.Count - 1
                filminfo_genre_id_cb.Items.Add(genreidlist(i) + " [" + genrenamelist(i) + "]")
                If genre_id.ToString = genreidlist(i) Then
                    filminfo_genre_id_cb.SelectedIndex = i
                End If
            Next

            If editmode Then
                filminfo_rating_cb.SelectedItem = rating

                filminfo_id_tb.Text = movie_id.ToString
                filminfo_name_tb.Text = _name
                filminfo_name_eng_tb.Text = name_eng
                filminfo_time_tb.Text = movie_time.ToString
                filminfo_release_date_dtp.Value = release_date
                filminfo_country_tb.Text = country
                filminfo_description_tb.Text = description

                If poster = "" Then
                    PosterPicBox.Image = My.Resources.noimg
                Else
                    PosterPicBox.LoadAsync(poster)
                End If

                posterUrl = poster
                PosterUrlTB.Text = poster
            End If

        End If
    End Sub

    Private Sub getFilmInfo() 'DB로부터 정보 불러오기

        If Not MainForm.stafftype = "admin" Then
            MsgBox("권한 오류입니다.", vbCritical)
            Close()
            Exit Sub
        End If

        '리스트 초기화
        genreidlist.Clear()
        genrenamelist.Clear()
        ratinglist.Clear()

        '장르 데이터 로드
        Dim ISQL = "Select * From genre"
        Dim RS = GL_DB_READER(ISQL, 0)

        If RS.Read() = False Then
            RS.Close()
            MsgBox("DB로부터 장르 정보를 찾을 수 없습니다", vbCritical)
            Close()
        Else
            Do
                genreidlist.Add(RS("genre_id"))
                genrenamelist.Add(RS("genre_name"))
            Loop Until RS.Read = False
            RS.Close()
        End If

        If editmode Then
            ISQL = "Select * From movie WHERE movie_id = " + movieId.ToString
            RS = GL_DB_READER(ISQL, 0)

            If RS.Read() = False Then
                RS.Close()
                MsgBox("DB로부터 영화 정보를 찾을 수 없습니다", vbCritical)
                Close()
            Else
                movie_id = RS("movie_id")
                genre_id = RS("genre_id")
                _name = RS("name")
                name_eng = RS("name_eng")
                movie_time = RS("movie_time")
                description = newlineConverter(RS("description").ToString)
                release_date = Date.Parse(RS("release_date"))
                country = RS("country")
                rating = RS("rating")
                poster = RS("poster").ToString
                RS.Close()
            End If
        Else
            RS.Close()
        End If

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If movieId = -1 Then
            MsgBox("영화가 선택되지 않았습니다", vbCritical)
        Else
            Dim ISQL = "Select * From movie WHERE movie_id=" + movieId.ToString
            Dim RS = GL_DB_READER(ISQL, 0)

            If RS.Read() = False Then
                RS.Close()
                MsgBox("해당 영화가 존재하지 않습니다." + vbCr + "(이미 삭제되었을 수도 있습니다)", vbExclamation)
            Else
                If MsgBox(RS("name") + vbCr + vbCr + "위 영화를 정말로 삭제하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                    RS.Close()
                    ISQL = "DELETE FROM movie WHERE movie.movie_id = " + movieId.ToString

                    Try
                        RS = GL_DB_READER(ISQL, 0)
                        RS.Close()
                    Catch ex As Exception
                        MsgBox("삭제 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
                        RS.Close()
                        Exit Sub
                    End Try

                    MainForm.film_update_list()
                    Close()
                Else
                    RS.Close()
                End If
            End If

        End If
    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        If readonlymode Then
            Close()
            Exit Sub
        End If

        '자체 유효성 체크

        If Not IsNumeric(filminfo_id_tb.Text) Then
            MsgBox("올바른 영화 ID를 입력해 주십시오", vbCritical)
            Exit Sub
        End If

        If Convert.ToInt32(filminfo_id_tb.Text) < 1 Then
            MsgBox("영화 ID는 1 이상의 숫자여야 합니다", vbCritical)
            Exit Sub
        End If

        If Not IsNumeric(filminfo_time_tb.Text) Then
            MsgBox("올바른 상영시간을 입력해 주십시오", vbCritical)
            Exit Sub
        End If

        If Convert.ToInt32(filminfo_time_tb.Text) < 1 Then
            MsgBox("상영시간은 1 이상의 숫자여야 합니다", vbCritical)
            Exit Sub
        End If

        If filminfo_genre_id_cb.SelectedIndex = -1 Then
            MsgBox("장르를 선택해 주십시오", vbCritical)
            Exit Sub
        End If

        If filminfo_rating_cb.SelectedIndex = -1 Then
            MsgBox("등급을 선택해 주십시오", vbCritical)
            Exit Sub
        End If

        If filminfo_name_tb.Text = "" Then
            MsgBox("영화명을 입력해 주십시오", vbCritical)
            Exit Sub
        End If

        If filminfo_name_eng_tb.Text = "" Then
            MsgBox("영문명을 입력해 주십시오", vbCritical)
            Exit Sub
        End If

        If filminfo_country_tb.Text = "" Then
            MsgBox("국가를 입력해 주십시오", vbCritical)
            Exit Sub
        End If


        Try
            ChkAndApplyQuery()
        Catch ex As Exception
            MsgBox("데이터 적용 도중 문제가 발생했습니다:" + vbCr + ex.Message, vbCritical)
        End Try

    End Sub

    Sub ChkAndApplyQuery()
        ' 키 유효성 체크
        Dim cmd As New MySqlCommand("SELECT count(*) FROM movie WHERE movie_id = " + filminfo_id_tb.Text, BP_CON(0))

        '입력한 무비아이디의 값이 이미 존재할 경우
        If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
            '그런데 그 ID가 편집하는 영화의 ID가 아닐 경우 (ID를 수정하는 경우)
            If Not movieId = filminfo_id_tb.Text Then
                MsgBox("중복되는 영화 ID입니다. 다른 ID로 지정해 주세요.", vbExclamation)
                Exit Sub
            End If
        End If

        If editmode Then '편집 모드일시

            cmd.CommandText = "UPDATE movie SET movie.movie_id = ?movie_id, movie.genre_id = ?genre_id, name = ?name,
            name_eng = ?name_eng, movie_time = ?movie_time, description = ?descr, release_date = ?release_date,
            country = ?country, rating = ?rating, poster = ?poster WHERE movie.movie_id = ?ID"

            cmd.Parameters.AddWithValue("?movie_id", filminfo_id_tb.Text)
            cmd.Parameters.AddWithValue("?genre_id", filminfo_genre_id_cb.SelectedIndex + 1) 'ID는 1부터 시작하기 때문에 1을 더해야함
            cmd.Parameters.AddWithValue("?name", filminfo_name_tb.Text)
            cmd.Parameters.AddWithValue("?name_eng", filminfo_name_eng_tb.Text)
            cmd.Parameters.AddWithValue("?movie_time", filminfo_time_tb.Text)
            cmd.Parameters.AddWithValue("?descr", filminfo_description_tb.Text)
            cmd.Parameters.AddWithValue("?release_date", filminfo_release_date_dtp.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("?country", filminfo_country_tb.Text)
            cmd.Parameters.AddWithValue("?rating", filminfo_rating_cb.Text)
            cmd.Parameters.AddWithValue("?poster", posterUrl)

            cmd.Parameters.AddWithValue("?ID", movieId)

            cmd.ExecuteNonQuery()

            MsgBox("적용되었습니다.", vbInformation)


        Else '추가 모드일시

            cmd.CommandText = "INSERT INTO movie (movie_id, genre_id, name, name_eng, movie_time, description,
            release_date, country, rating, poster) VALUES (?movie_id, ?genre_id, ?name, ?name_eng, ?movie_time,
            ?descr, ?release_date, ?country, ?rating, ?poster)"

            cmd.Parameters.AddWithValue("?movie_id", filminfo_id_tb.Text)
            cmd.Parameters.AddWithValue("?genre_id", filminfo_genre_id_cb.SelectedIndex + 1) 'ID는 1부터 시작하기 때문에 1을 더해야함
            cmd.Parameters.AddWithValue("?name", filminfo_name_tb.Text)
            cmd.Parameters.AddWithValue("?name_eng", filminfo_name_eng_tb.Text)
            cmd.Parameters.AddWithValue("?movie_time", filminfo_time_tb.Text)
            cmd.Parameters.AddWithValue("?descr", filminfo_description_tb.Text)
            cmd.Parameters.AddWithValue("?release_date", filminfo_release_date_dtp.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("?country", filminfo_country_tb.Text)
            cmd.Parameters.AddWithValue("?rating", filminfo_rating_cb.Text)
            cmd.Parameters.AddWithValue("?poster", posterUrl)

            cmd.ExecuteNonQuery()

            MsgBox("추가되었습니다.", vbInformation)

        End If

        '연결 종료
        cmd.Connection.Close()

        MainForm.film_update_list()
        If Not listindex = -1 Then
            MainForm.FilmListView.Items(listindex).Selected = True
        End If

        Close()

    End Sub

    Private Sub PosterModifyBT_Click(sender As Object, e As EventArgs) Handles PosterModifyBT.Click
        If posterEditMode Then '원래 편집 모드였다면 -> 적용하고 모드 해제

            Try
                PosterPicBox.LoadAsync(PosterUrlTB.Text)
                posterUrl = PosterUrlTB.Text
                posterEditMode = False
                PosterModifyBT.Text = "변경"
            Catch ex As Exception
                MsgBox("포스터 이미지 조회 중 오류가 발생하였습니다." + vbCr + ex.Message, vbCritical)
            End Try

        Else '편집 모드가 아니라면 -> 편집 모드로 설정

            posterEditMode = True
            PosterModifyBT.Text = "적용"

        End If
        PosterUrlTB.Enabled = posterEditMode
    End Sub
End Class