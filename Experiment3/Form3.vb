Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form3
    Dim connection As MySqlConnection
    Dim cmd As MySqlCommand
    Dim table_name As New String("fixed")
    'formatted values for database
    Dim f_Ib As New String("")
    Dim f_Ic As New String("")
    Dim f_Ie As New String("")
    Dim f_Vrb As New String("")
    Dim f_Vrc As New String("")
    Dim f_Vce As New String("")
    Dim f_Vbe As New String("")
    Dim calculated As Boolean = False

    Public Sub New(conn As MySqlConnection)
        InitializeComponent()
        connection = conn
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mainForm As Form1 = Application.OpenForms.OfType(Of Form1)().FirstOrDefault()
        If mainForm IsNot Nothing Then
            mainForm.ShowMainForm()
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If String.IsNullOrWhiteSpace(TextBox2.Text) Or
               String.IsNullOrWhiteSpace(TextBox1.Text) Or
               String.IsNullOrWhiteSpace(TextBox4.Text) Or
               String.IsNullOrWhiteSpace(TextBox5.Text) Then
                MsgBox("Please fill in all input fields", vbExclamation, Title:="Warning")
            ElseIf String.IsNullOrEmpty(ComboBox1.Text) Or
                   String.IsNullOrEmpty(ComboBox2.Text) Or
                   String.IsNullOrEmpty(ComboBox4.Text) Then
                MsgBox("Please select units for all values", vbExclamation, Title:="Warning")
            Else
                Dim Rc As Double = Convert.ToDouble(TextBox2.Text)
                Dim Rb As Double = Convert.ToDouble(TextBox1.Text)
                Dim Vcc As Double = Convert.ToDouble(TextBox4.Text)
                Dim Beta As Double = Convert.ToDouble(TextBox5.Text)

                ' Convert based on user choice
                If ComboBox1.Text = "Ω" Then
                    Rc = Rc
                    _Rc.Text = Rc & ComboBox1.Text
                ElseIf ComboBox1.Text = "kΩ" Then
                    Rc = Rc * 1000
                    _Rc.Text = (Rc / 1000) & ComboBox1.Text
                Else
                    Rc = Rc * 1000000
                    _Rc.Text = (Rc / 1000000) & ComboBox1.Text
                End If

                If ComboBox2.Text = "Ω" Then
                    Rb = Rb
                    _Rb.Text = Rb & ComboBox2.Text
                ElseIf ComboBox2.Text = "kΩ" Then
                    Rb = Rb * 1000
                    _Rb.Text = (Rb / 1000) & ComboBox2.Text
                Else
                    Rb = Rb * 1000000
                    _Rb.Text = (Rb / 1000000) & ComboBox2.Text
                End If

                If ComboBox4.Text = "V" Then
                    Vcc = Vcc
                    _Vcc.Text = Vcc & ComboBox4.Text
                ElseIf ComboBox4.Text = "mV" Then
                    Vcc /= 1000
                    _Vcc.Text = (Vcc * 1000) & ComboBox4.Text
                Else
                    Vcc /= 1000000
                    _Vcc.Text = (Vcc * 1000000) & ComboBox4.Text
                End If
                _Beta.Text = Beta

                ' Calculate the fixed bias 
                Dim Vbe As Double = 0.7
                Dim Ib As Double = (Vcc - Vbe) / Rb
                Dim Ic As Double = Beta * Ib
                Dim Ie As Double = Ic + Ib
                Dim Vrb As Double = Ib * Rb
                Dim Vrc As Double = Ic * Rc
                Dim Vce As Double = Vcc - Vrc

                ' Format the results
                If Ib < 0.001 Then
                    f_Ib = Math.Round((Ib * 1000000), 2) & " µA"
                    Me.Ib.Text = "Ib = " & f_Ib
                ElseIf Ib < 1 Then
                    f_Ib = Math.Round((Ib * 1000), 2) & " mA"
                    Me.Ib.Text = "Ib = " & f_Ib
                Else
                    f_Ib = Math.Round(Ib, 2) & " A"
                    Me.Ib.Text = "Ib = " & f_Ib
                End If

                If Ic < 0.001 Then
                    f_Ic = Math.Round((Ic * 1000000), 2) & " µA"
                    Me.Ic.Text = "Ic = " & f_Ic
                ElseIf Ic < 1 Then
                    f_Ic = Math.Round((Ic * 1000), 2) & " mA"
                    Me.Ic.Text = "Ic = " & f_Ic
                Else
                    f_Ic = Math.Round(Ic, 2) & " A"
                    Me.Ic.Text = "Ic = " & f_Ic
                End If

                If Ie < 0.001 Then
                    f_Ie = Math.Round((Ie * 1000000), 2) & " µA"
                    Me.Ie.Text = "Ie = " & f_Ie
                ElseIf Ie < 1 Then
                    f_Ie = Math.Round((Ie * 1000), 2) & " mA"
                    Me.Ie.Text = "Ie = " & f_Ie
                Else
                    f_Ie = Math.Round(Ie, 2) & " A"
                    Me.Ie.Text = "Ie = " & f_Ie
                End If

                If Vrb < 0.001 Then
                    f_Vrb = Math.Round((Vrb * 1000000), 2) & " µV"
                    Me.Vrb.Text = "Vrb = " & f_Vrb
                ElseIf Vrb < 1 Then
                    f_Vrb = Math.Round((Vrb * 1000), 2) & " mV"
                    Me.Vrb.Text = "Vrb = " & f_Vrb
                Else
                    f_Vrb = Math.Round(Vrb, 2) & " V"
                    Me.Vrb.Text = "Vrb = " & f_Vrb
                End If

                If Vrc < 0.001 Then
                    f_Vrc = Math.Round((Vrc * 1000000), 2) & " µV"
                    Me.Vrc.Text = "Vrc = " & f_Vrc
                ElseIf Vrc < 1 Then
                    f_Vrc = Math.Round((Vrc * 1000), 2) & " mV"
                    Me.Vrc.Text = "Vrc = " & f_Vrc
                Else
                    f_Vrc = Math.Round(Vrc, 2) & " V"
                    Me.Vrc.Text = "Vrc = " & f_Vrc
                End If

                If Vce < 0.001 Then
                    f_Vce = Math.Round((Vce * 1000000), 2) & " µV"
                    Me.Vce.Text = "Vce = " & f_Vce
                ElseIf Vce < 1 Then
                    f_Vce = Math.Round((Vce * 1000), 2) & " mV"
                    Me.Vce.Text = "Vce = " & f_Vce
                Else
                    f_Vce = Math.Round(Vce, 2) & " V"
                    Me.Vce.Text = "Vce = " & f_Vce
                End If

                f_Vbe = Vbe & " V"
                _Vbe.Text = f_Vbe
                calculated = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If connection.State = ConnectionState.Closed Then
                MsgBox("Please connect to the database first", vbExclamation, Title:="Warning")
            ElseIf String.IsNullOrWhiteSpace(TextBox2.Text) Or
                   String.IsNullOrWhiteSpace(TextBox1.Text) Or
                   String.IsNullOrWhiteSpace(TextBox4.Text) Or
                   String.IsNullOrWhiteSpace(TextBox5.Text) Then
                MsgBox("Please fill in all input fields", vbExclamation, Title:="Warning")
            ElseIf String.IsNullOrEmpty(ComboBox1.Text) Or
                   String.IsNullOrEmpty(ComboBox2.Text) Or
                   String.IsNullOrEmpty(ComboBox4.Text) Then
                MsgBox("Please select units for all values", vbExclamation, Title:="Warning")
            ElseIf calculated = False Then
                MsgBox("Please calculate first", vbExclamation, Title:="Warning")
            Else
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                cmd = New MySqlCommand("INSERT INTO " & table_name & "(RB, RC, VCC, BETA, VRB, VRC, VCE, IB, IC, IE, VBE)
                        values (@RB, @RC, @VCC, @BETA, @VRB, @VRC, @VCE, @IB, @IC, @IE, @VBE)", connection)
                cmd.Parameters.AddWithValue("@RB", _Rb.Text)
                cmd.Parameters.AddWithValue("@RC", _Rc.Text)
                cmd.Parameters.AddWithValue("@VCC", _Vcc.Text)
                cmd.Parameters.AddWithValue("@BETA", _Beta.Text)
                cmd.Parameters.AddWithValue("@VRB", f_Vrb)
                cmd.Parameters.AddWithValue("@VRC", f_Vrc)
                cmd.Parameters.AddWithValue("@VCE", f_Vce)
                cmd.Parameters.AddWithValue("@IB", f_Ib)
                cmd.Parameters.AddWithValue("@IC", f_Ic)
                cmd.Parameters.AddWithValue("@IE", f_Ie)
                cmd.Parameters.AddWithValue("@VBE", f_Vbe)

                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Successfully Added Record to " & table_name & "", vbInformation, Title:="Success")
                Else
                    MsgBox("Failed to Add Record to " & table_name & "", vbExclamation, Title:="Error")
                End If
                ' Reset all text after successfully adding record
                TextBox2.Clear()
                TextBox1.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                _Beta.Text = "Beta"
                _Vcc.Text = "Vcc"
                _Rb.Text = "Rb"
                _Rc.Text = "Rc"
                _Vbe.Text = "Vbe"
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                ComboBox4.SelectedIndex = -1
                Ib.Text = "Ib = "
                Ic.Text = "Ic = "
                Ie.Text = "Ie = "
                Vce.Text = "Vce = "
                Vrb.Text = "Vrb = "
                Vrc.Text = "Vrc = "
                calculated = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Clear()
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        _Beta.Text = "Beta"
        _Vcc.Text = "Vcc"
        _Rb.Text = "Rb"
        _Rc.Text = "Rc"

        _Vbe.Text = "Vbe"
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1

        ComboBox4.SelectedIndex = -1
        Ib.Text = "Ib = "
        Ic.Text = "Ic = "
        Ie.Text = "Ie = "
        Vce.Text = "Vce = "
        Vrb.Text = "Vrb = "
        Vrc.Text = "Vrc = "

        calculated = False
    End Sub
End Class