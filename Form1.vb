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

        If pbHero.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If


    End Sub
    Private Function checkCollision(heroguy As Object, chaserguy As Object) As Boolean
        Return pbHero.Top + pbHero.Size.Height <= pbChaser.Top - pbChaser.Size.Height And
            pbHero.Top - pbHero.Size.Height >= pbChaser.Top + pbChaser.Size.Height And
           pbHero.Left + pbHero.Size.Width <= pbChaser.Left - pbChaser.Size.Width And
          pbHero.Left + pbHero.Size.Width <= pbChaser.Left - pbChaser.Size.Width

    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, MyBase.KeyDown
        Dim hero As Integer = pbHero.Top
        Dim hero2 As Integer = pbHero.Left
        Dim chaser As Integer = pbChaser.Top
        Dim chaser2 As Integer = pbChaser.Left
        Dim chaser3 As Integer = pbChasi.Top
        Dim chaser4 As Integer = pbChasi.Left
        Dim speed As Integer = 1

        If hero > chaser Then
            pbChaser.Top = pbChaser.Top + speed
        ElseIf hero < chaser Then
            pbChaser.Top = pbChaser.Top - speed
        End If
        If hero2 > chaser2 Then
            pbChaser.Left = pbChaser.Left + speed
        ElseIf hero2 < chaser2 Then
            pbChaser.Left = pbChaser.Left - speed
        End If


        If pbChaser.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            pbChaser.Left = pbChaser.Left - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            pbChaser.Left = pbChaser.Left - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            pbChaser.Left = pbChaser.Left - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            pbChaser.Left = pbChaser.Left - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            pbChaser.Top = pbChaser.Top - 1
        End If

        If pbChaser.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            pbChaser.Left = pbChaser.Left - 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim hero As Integer = pbHero.Top
        Dim hero2 As Integer = pbHero.Left
        Dim chaser As Integer = pbChasi.Top
        Dim chaser2 As Integer = pbChasi.Left
        Dim speed As Integer = 1

        If hero > chaser Then
            pbChaser.Top = pbChaser.Top + speed
        ElseIf hero < chaser Then
            pbChaser.Top = pbChaser.Top - speed
        End If
        If hero2 > chaser2 Then
            pbChaser.Left = pbChaser.Left + speed
        ElseIf hero2 < chaser2 Then
            pbChaser.Left = pbChaser.Left - speed
        End If
    End Sub
End Class

