Public Class Form1
    Dim movement As New Point(0, 0)
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' Create timer 
        'thanks tutlane
        Dim timer As Timer = New Timer()

        timer.Start()

        If e.KeyCode = Keys.Up Then
            pbHero.Top = pbHero.Top - 10
        End If
        If e.KeyCode = Keys.Down Then
            pbHero.Top = pbHero.Top + 10
        End If
        If e.KeyCode = Keys.Left Then
            pbHero.Left = pbHero.Left - 10
        End If
        If e.KeyCode = Keys.Right Then
            pbHero.Left = pbHero.Left + 10
        End If

        Select Case e.KeyCode
            Case Keys.W
                pbHero.Top = pbHero.Top - 10
            Case Keys.S
                pbHero.Top = pbHero.Top + 10
            Case Keys.A
                pbHero.Left = pbHero.Left - 10
            Case Keys.D
                pbHero.Left = pbHero.Left + 10
            Case Keys.Y
                MessageBox.Show("Stop Touching The Y Key Dude")
            Case Keys.C
                PictureBox1.BackColor = Color.Purple
                PictureBox2.BackColor = Color.Purple
                PictureBox3.BackColor = Color.Purple
                PictureBox4.BackColor = Color.Purple
                PictureBox6.BackColor = Color.Purple
                PictureBox7.BackColor = Color.Purple
                PictureBox8.BackColor = Color.Purple
                PictureBox9.BackColor = Color.Purple
                PictureBox10.BackColor = Color.Purple
        End Select

        If pbHero.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If
        If pbHero.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()

        End If
        If pbHero.Bounds.IntersectsWith(pbChaser.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(pbWin.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("YOU WIN")
            Application.Exit()
        End If





        If timer.Interval = 1 Then
            pbChaser.Top = pbChaser.Top - 100
        End If

        timer.Stop()
    End Sub








End Class
