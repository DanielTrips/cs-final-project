Public Class Form1
    Dim movement As New Point(0, 0)
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

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
        Dim 
        If pbChaser Then
    End Sub

    Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
                Object2.Top + Object2.Height >= Object1.Top And
                Object1.Left + Object1.Width >= Object2.Left And
                Object2.Left And Object2.Width >= Object1.Left Then
            Collided = True
        End If
        Return Collided
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim pos_y As Double
        Dim pos_x As Double




    End Sub
End Class
