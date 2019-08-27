Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Data.OleDb
Public Class Form1
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafe.accdb")
    Dim cmd As New OleDbCommand
    Public hours, min, sec, mini As Integer
    Dim dtFuture As New DateTime

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            cmd.CommandText = "select * from Tickets where ticket = '" & TextBox1.Text & "'"
            cmd.Connection = cn
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If (reader.Read) = True Then
                min = reader(3)

                timerform.Show()
                timerform.RestartTime()
                Me.Hide()

            ElseIf TextBox1.Text = My.Settings.password Then
                ControlPanel.Show()
                Me.Hide()
                Timer1.Stop()
            Else

                MessageBox.Show("Please Contact the admin for ticket")
                Application.Exit()
            End If
            reader.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Dim T As New Threading.Thread(AddressOf Block)
        T.Start()
    End Sub
    Sub Block()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TopMost = True
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "explorer" Then
                'selProcess.Kill()
                Exit For
            End If
        Next

    End Sub
    Sub KillExplorer()
        Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
        taskKill.WindowStyle = ProcessWindowStyle.Hidden
        Dim Process As Process = New Process()
        Process.StartInfo = taskKill
        Process.Start()
        Process.WaitForExit()
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property
End Class
