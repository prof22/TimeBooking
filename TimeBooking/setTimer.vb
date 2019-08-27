Imports System.Data.OleDb
Public Class setTimer
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prof\Documents\Visual Studio 2008\Projects\TimeBooking\TimeBooking\Cafe.accdb")
    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand
            cmd.Connection = cn

            cmd.CommandText = "insert into [Tickets]([ticket], [min], [sec]) VALUES(@ticket, @min, @sec)"
            With cmd.Parameters
                .AddWithValue("@ticket", txtTicket.Text)
                .AddWithValue("@min", txtMin.Text)
                .AddWithValue("@sec", Txtsecond.Text)
                cmd.ExecuteNonQuery()
                MsgBox("New Record Added")
                'Else

            End With
           
            '    MessageBox.Show("Please Contact the admin for ticket")
            'End If

            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class