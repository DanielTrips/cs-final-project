Public Class Form1
    Dim movement As New Point(0, 0)
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'making arrow keys
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

        'making game user friendly (WASD)
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
                'suddenly clicking C will change everything to purple
            Case Keys.C
                PictureBox1.BackColor = Color.Purple
                PictureBox2.BackColor = Color.Purple
                PictureBox3.BackColor = Color.Purple
                PictureBox4.BackColor = Color.Purple
                PictureBox5.BackColor = Color.Purple
                PictureBox6.BackColor = Color.Purple
                PictureBox7.BackColor = Color.Purple
                PictureBox8.BackColor = Color.Purple
                PictureBox9.BackColor = Color.Purple
                PictureBox10.BackColor = Color.Purple
                PictureBox11.BackColor = Color.Purple
                PictureBox12.BackColor = Color.Purple
                PictureBox13.BackColor = Color.Purple
                PictureBox14.BackColor = Color.Purple
                PictureBox15.BackColor = Color.Purple
                PictureBox16.BackColor = Color.Purple
                PictureBox17.BackColor = Color.Purple
                PictureBox18.BackColor = Color.Purple
                PictureBox19.BackColor = Color.Purple
                PictureBox20.BackColor = Color.Purple
                PictureBox21.BackColor = Color.Purple
                PictureBox22.BackColor = Color.Purple
                PictureBox23.BackColor = Color.Purple
                PictureBox24.BackColor = Color.Purple
        End Select

        'this whole lodge of if statements is my collision detection 
        'i didnt use a function but now realize it couldve and saved me a lot of time
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
        If pbHero.Bounds.IntersectsWith(pbChaser.Bounds) Or pbHero.Bounds.IntersectsWith(pbChasi.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox20.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox22.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox23.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(PictureBox24.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(pbChasi.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(pbChace.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        If pbHero.Bounds.IntersectsWith(pbChaze.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("GAME OVER")
            Application.Exit()
        End If

        'if player hits the blue box they win
        If pbHero.Bounds.IntersectsWith(pbWin.Bounds) Then
            pbHero.Visible = False
            MessageBox.Show("YOU WIN")
            Application.Exit()
        End If

    End Sub
    Private Function checkCollision(heroguy As Object, chaserguy As Object) As Boolean

        'my collision function that never ended up being used
        Return pbHero.Top + pbHero.Size.Height <= pbChaser.Top - pbChaser.Size.Height And
            pbHero.Top - pbHero.Size.Height >= pbChaser.Top + pbChaser.Size.Height And
           pbHero.Left + pbHero.Size.Width <= pbChaser.Left - pbChaser.Size.Width And
          pbHero.Left + pbHero.Size.Width <= pbChaser.Left - pbChaser.Size.Width

    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, MyBase.KeyDown
        ' code for chaser1
        Dim hero As Integer = pbHero.Top
        Dim hero2 As Integer = pbHero.Left
        Dim speed As Double = 1
        Dim chasers() As Object = {pbChaser, pbChasi, pbChase, pbChace, pbChaze}
        For index As Integer = 0 To chasers.Length - 1
            Dim thisChaser As Object = chasers(index)

            Dim chaser As Integer = thisChaser.Top
            Dim chaser2 As Integer = thisChaser.Left
            If hero > chaser Then
                thisChaser.Top = thisChaser.Top + speed
            ElseIf hero < chaser Then
                thisChaser.Top = thisChaser.Top - speed
            End If
            If hero2 > chaser2 Then
                thisChaser.Left = thisChaser.Left + speed
            ElseIf hero2 < chaser2 Then
                thisChaser.Left = thisChaser.Left - speed
            End If


            If thisChaser.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox14.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                thisChaser.Top = thisChaser.Top - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If thisChaser.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                thisChaser.Left = thisChaser.Left - 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                pbChasi.Top = pbChasi.Top + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                pbChasi.Top = pbChasi.Top + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                pbChasi.Top = pbChasi.Top + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                pbChasi.Top = pbChasi.Top + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                pbChasi.Top = pbChasi.Top - 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox14.Bounds) Then
                pbChasi.Left = pbChasi.Left - 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                pbChasi.Top = pbChasi.Top + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                pbChasi.Top = pbChasi.Top + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChasi.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                pbChasi.Left = pbChasi.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                pbChase.Top = pbChase.Top + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                pbChase.Top = pbChase.Top + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                pbChase.Top = pbChase.Top + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                pbChase.Top = pbChase.Top + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                pbChase.Top = pbChase.Top - 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox14.Bounds) Then
                pbChase.Left = pbChase.Left - 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                pbChase.Top = pbChase.Top + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                pbChase.Top = pbChase.Top + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                pbChase.Left = pbChase.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                pbChace.Left = pbChace.Left - 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If
            'add more to stuff
            If pbChace.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChase.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                pbChace.Top = pbChace.Top + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                pbChace.Top = pbChace.Top + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                pbChace.Top = pbChace.Top + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                pbChace.Top = pbChace.Top + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                pbChace.Top = pbChace.Top - 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox14.Bounds) Then
                pbChace.Left = pbChace.Left - 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                pbChace.Top = pbChace.Top + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                pbChace.Top = pbChace.Top + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChace.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                pbChace.Left = pbChace.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If
            'add more to stuff
            If pbChaze.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                pbChaze.Top = pbChaze.Top - 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox14.Bounds) Then
                pbChaze.Left = pbChaze.Left - 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                pbChaze.Top = pbChaze.Top + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If

            If pbChaze.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                pbChaze.Left = pbChaze.Left + 1
            End If
        Next
    End Sub


End Class
