Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connection As MySqlConnection
    Dim database_name As New String("experiment3")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;username=root;password=;database='" & database_name & "'"
        If connection.State = ConnectionState.Closed Then
            Button2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Public Sub ShowMainForm()
        Me.Show()
        Me.Activate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                ConnectionStatus.Text = "Connected"
                ConnectionStatus.ForeColor = Color.Green
                Button1.Text = "Disconnect to Database"
                Button2.Enabled = True
                Button3.Enabled = True
            Else
                connection.Close()
                ConnectionStatus.Text = "Disconnected"
                ConnectionStatus.ForeColor = Color.DarkRed
                Button1.Text = "Connect to Database"
                Button2.Enabled = False
                Button3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emitterForm As New Form2(connection)
        emitterForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fixedForm As New Form3(connection)
        fixedForm.Show()
        Me.Hide()
    End Sub
End Class
