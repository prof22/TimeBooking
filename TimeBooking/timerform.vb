Public Class timerform
    Dim dtFuture As New DateTime

    Private Sub timerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False

        'Timer2.Enabled = False
        'TextBox1.Text = "0" : TextBox2.Text = "0" : TextBox3.Text = "0" : TextBox4.Text = "000"
        'TextBox1.Text = "0" : TextBox2.Text = "0" : TextBox3.Text = "10" : TextBox4.Text = "000"
        Button1.PerformClick()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If Timer1.Interval <> 100 Then Timer1.Interval = 100
            If DateTime.Now > dtFuture Then

                Timer1.Stop()
                Form1.Show()



            Else

                Dim foo As New TimeSpan
                foo = dtFuture - DateTime.Now
                TextBox5.Text = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", _
                                              foo.Hours, foo.Minutes, foo.Seconds, foo.Milliseconds)

            End If

        Catch ex As Exception

        End Try

    End Sub
    Public Sub RestartTime()
        TextBox1.Text = "0" : TextBox2.Text = Form1.min : TextBox3.Text = "10" : TextBox4.Text = "000"
        Dim h, m, s, ms As Integer
        If Not Integer.TryParse(TextBox1.Text, h) OrElse _
            Not Integer.TryParse(TextBox2.Text, m) OrElse _
            Not Integer.TryParse(TextBox3.Text, s) OrElse _
            Not Integer.TryParse(TextBox4.Text, ms) Then
            'bad input data
            Exit Sub

        End If

        dtFuture = DateTime.Now.AddHours(h).AddMinutes(m).AddSeconds(s).AddMilliseconds(ms)
        Timer1.Interval = 1
        Timer1.Start()


        'Timer1.Stop()
        ' TextBox1.Text = "0" : TextBox2.Text = "0" : TextBox3.Text = "10" : TextBox4.Text = "000"
        If Timer1.Interval <> 100 Then Timer1.Interval = 100
        If DateTime.Now < dtFuture Then
            Dim foo As New TimeSpan
            foo = dtFuture - DateTime.Now
            TextBox5.Text = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", _
                                          foo.Hours, foo.Minutes, foo.Seconds, foo.Milliseconds)

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim h, m, s, ms As Integer
        If Not Integer.TryParse(TextBox1.Text, h) OrElse _
            Not Integer.TryParse(TextBox2.Text, m) OrElse _
            Not Integer.TryParse(TextBox3.Text, s) OrElse _
            Not Integer.TryParse(TextBox4.Text, ms) Then
            'bad input data
            Exit Sub

        End If

        dtFuture = DateTime.Now.AddHours(h).AddMinutes(m).AddSeconds(s).AddMilliseconds(ms)
        Timer1.Interval = 1
        Timer1.Start()


    End Sub
End Class