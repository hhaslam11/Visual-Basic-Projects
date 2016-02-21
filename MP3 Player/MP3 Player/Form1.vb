Public Class Form1
    Dim intSongChoice As Integer

    Private Sub rbtnSong1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSong1.CheckedChanged
        intSongChoice = 1
    End Sub

    Private Sub rbtnSong2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSong2.CheckedChanged
        intSongChoice = 2
    End Sub

    Private Sub rbtnSong3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSong3.CheckedChanged
        intSongChoice = 3
    End Sub

    Private Sub rbtnSong4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSong4.CheckedChanged
        intSongChoice = 4
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Select Case intSongChoice
            Case 1
                AxWindowsMediaPlayer1.URL = "AC DC - Thunderstruck.mp3"
            Case 2
                AxWindowsMediaPlayer1.URL = "ACDC- Shoot To Thrill.mp3"
            Case 3
                AxWindowsMediaPlayer1.URL = "BAD BOYS - BOB MARLEY.mp3"
            Case 4
                AxWindowsMediaPlayer1.URL = "Volbeat - Still Counting - YouTube.mp3"
        End Select
    End Sub


    'Kaleb Haslam
    'MP3 Player
End Class
