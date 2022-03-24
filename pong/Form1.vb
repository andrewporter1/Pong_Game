Public Class Frm_Pong
    Dim ball_across As Single
    Dim ball_vertical As Single
    Private Sub Frm_Pong_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'movement of player
        Select Case e.KeyCode
            Case Keys.W
                Lbl_PlayerOne.Top -= 20
            Case Keys.S
                Lbl_PlayerOne.Top += 20
        End Select
        Select Case e.KeyCode
            Case Keys.Up
                Lbl_AI.Top -= 20
            Case Keys.Down
                Lbl_AI.Top += 20
        End Select
    End Sub
    Private Sub Tmr_Ball_Tick(sender As Object, e As EventArgs) Handles Tmr_Ball.Tick
        'ball movement
        Lbl_Ball.Left -= ball_across
        Lbl_Ball.Top -= ball_vertical
        If Lbl_Ball.Bounds.IntersectsWith(Lbl_PlayerOne.Bounds) Then
            ball_across = -ball_across
            ball_vertical = +ball_vertical
        End If
        If Lbl_Ball.Bounds.IntersectsWith(Lbl_AI.Bounds) Then
            ball_across = 5
        End If
        'top border
        If Lbl_Ball.Bounds.IntersectsWith(Lbl_Top.Bounds) Then
            ball_across = +ball_across
            ball_vertical = -ball_vertical
        End If
        'bottom border
        If Lbl_Ball.Bounds.IntersectsWith(Lbl_Bottom.Bounds) Then
            ball_across = +ball_across
            ball_vertical = -ball_vertical
        End If
        'scoring system
        If Lbl_Ball.Bounds.IntersectsWith(Lbl_Left.Bounds) Then
            Score_Ai.Text += 1
            Lbl_Ball.Left = 300
        End If
        If Lbl_Ball.Bounds.IntersectsWith(Lbl_Right.Bounds) Then
            Score_p1.Text += 1
            Lbl_Ball.Left = 400
        End If
    End Sub
    Private Sub Frm_Pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting in
        ball_across = 5
        ball_vertical = 2
    End Sub
End Class
