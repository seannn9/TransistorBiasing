<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._Vbe = New System.Windows.Forms.Label()
        Me._Beta = New System.Windows.Forms.Label()
        Me._Vcc = New System.Windows.Forms.Label()
        Me._Rc = New System.Windows.Forms.Label()
        Me._Rb = New System.Windows.Forms.Label()
        Me.Vrc = New System.Windows.Forms.Label()
        Me.Vrb = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ic = New System.Windows.Forms.Label()
        Me.Ib = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Ie = New System.Windows.Forms.Label()
        Me.Vce = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 47)
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fixed Bias"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel4.Location = New System.Drawing.Point(-1, 355)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(539, 44)
        Me.Panel4.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(212, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Vbe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(113, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 20)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Beta"
        '
        '_Vbe
        '
        Me._Vbe.AutoSize = True
        Me._Vbe.BackColor = System.Drawing.Color.White
        Me._Vbe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Vbe.ForeColor = System.Drawing.Color.Red
        Me._Vbe.Location = New System.Drawing.Point(212, 253)
        Me._Vbe.Name = "_Vbe"
        Me._Vbe.Size = New System.Drawing.Size(41, 20)
        Me._Vbe.TabIndex = 54
        Me._Vbe.Text = "Vbe"
        '
        '_Beta
        '
        Me._Beta.AutoSize = True
        Me._Beta.BackColor = System.Drawing.Color.White
        Me._Beta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Beta.ForeColor = System.Drawing.Color.Red
        Me._Beta.Location = New System.Drawing.Point(113, 69)
        Me._Beta.Name = "_Beta"
        Me._Beta.Size = New System.Drawing.Size(47, 20)
        Me._Beta.TabIndex = 53
        Me._Beta.Text = "Beta"
        '
        '_Vcc
        '
        Me._Vcc.AutoSize = True
        Me._Vcc.BackColor = System.Drawing.Color.White
        Me._Vcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Vcc.ForeColor = System.Drawing.Color.Red
        Me._Vcc.Location = New System.Drawing.Point(349, 78)
        Me._Vcc.Name = "_Vcc"
        Me._Vcc.Size = New System.Drawing.Size(39, 20)
        Me._Vcc.TabIndex = 52
        Me._Vcc.Text = "Vcc"
        '
        '_Rc
        '
        Me._Rc.AutoSize = True
        Me._Rc.BackColor = System.Drawing.Color.White
        Me._Rc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Rc.ForeColor = System.Drawing.Color.Red
        Me._Rc.Location = New System.Drawing.Point(349, 154)
        Me._Rc.Name = "_Rc"
        Me._Rc.Size = New System.Drawing.Size(31, 20)
        Me._Rc.TabIndex = 50
        Me._Rc.Text = "Rc"
        '
        '_Rb
        '
        Me._Rb.AutoSize = True
        Me._Rb.BackColor = System.Drawing.Color.White
        Me._Rb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Rb.ForeColor = System.Drawing.Color.Red
        Me._Rb.Location = New System.Drawing.Point(132, 154)
        Me._Rb.Name = "_Rb"
        Me._Rb.Size = New System.Drawing.Size(32, 20)
        Me._Rb.TabIndex = 49
        Me._Rb.Text = "Rb"
        '
        'Vrc
        '
        Me.Vrc.AutoSize = True
        Me.Vrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vrc.Location = New System.Drawing.Point(137, 48)
        Me.Vrc.Name = "Vrc"
        Me.Vrc.Size = New System.Drawing.Size(37, 16)
        Me.Vrc.TabIndex = 26
        Me.Vrc.Text = "Vrc ="
        '
        'Vrb
        '
        Me.Vrb.AutoSize = True
        Me.Vrb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vrb.Location = New System.Drawing.Point(137, 20)
        Me.Vrb.Name = "Vrb"
        Me.Vrb.Size = New System.Drawing.Size(38, 16)
        Me.Vrb.TabIndex = 25
        Me.Vrb.Text = "Vrb ="
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(108, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 305)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Ic
        '
        Me.Ic.AutoSize = True
        Me.Ic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ic.Location = New System.Drawing.Point(17, 41)
        Me.Ic.Name = "Ic"
        Me.Ic.Size = New System.Drawing.Size(27, 16)
        Me.Ic.TabIndex = 22
        Me.Ic.Text = "Ic ="
        '
        'Ib
        '
        Me.Ib.AutoSize = True
        Me.Ib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ib.Location = New System.Drawing.Point(17, 9)
        Me.Ib.Name = "Ib"
        Me.Ib.Size = New System.Drawing.Size(28, 16)
        Me.Ib.TabIndex = 21
        Me.Ib.Text = "Ib ="
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Ie)
        Me.Panel3.Controls.Add(Me.Vrc)
        Me.Panel3.Controls.Add(Me.Vrb)
        Me.Panel3.Controls.Add(Me.Vce)
        Me.Panel3.Controls.Add(Me.Ic)
        Me.Panel3.Controls.Add(Me.Ib)
        Me.Panel3.Location = New System.Drawing.Point(256, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 134)
        Me.Panel3.TabIndex = 47
        '
        'Ie
        '
        Me.Ie.AutoSize = True
        Me.Ie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ie.Location = New System.Drawing.Point(17, 73)
        Me.Ie.Name = "Ie"
        Me.Ie.Size = New System.Drawing.Size(28, 16)
        Me.Ie.TabIndex = 27
        Me.Ie.Text = "Ie ="
        '
        'Vce
        '
        Me.Vce.AutoSize = True
        Me.Vce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vce.Location = New System.Drawing.Point(5, 105)
        Me.Vce.Name = "Vce"
        Me.Vce.Size = New System.Drawing.Size(41, 16)
        Me.Vce.TabIndex = 24
        Me.Vce.Text = "Vce ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 512)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 20)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "β"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "VCC"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(134, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 42)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "RB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "RC"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(64, 509)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(119, 26)
        Me.TextBox5.TabIndex = 41
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"V", "mV", "µV"})
        Me.ComboBox4.Location = New System.Drawing.Point(189, 474)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(61, 28)
        Me.ComboBox4.TabIndex = 40
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(64, 474)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(119, 26)
        Me.TextBox4.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(2, 542)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(536, 53)
        Me.Panel2.TabIndex = 36
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Ω", "kΩ", "MΩ"})
        Me.ComboBox2.Location = New System.Drawing.Point(189, 405)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(61, 28)
        Me.ComboBox2.TabIndex = 34
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ω", "kΩ", "MΩ"})
        Me.ComboBox1.Location = New System.Drawing.Point(189, 440)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(61, 28)
        Me.ComboBox1.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(64, 405)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 26)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(64, 440)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 26)
        Me.TextBox2.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(189, 508)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 28)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(537, 594)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me._Vbe)
        Me.Controls.Add(Me._Beta)
        Me.Controls.Add(Me._Vcc)
        Me.Controls.Add(Me._Rc)
        Me.Controls.Add(Me._Rb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(553, 633)
        Me.MinimumSize = New System.Drawing.Size(553, 633)
        Me.Name = "Form3"
        Me.Text = "Fixed Bias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents _Vbe As Label
    Friend WithEvents _Beta As Label
    Friend WithEvents _Vcc As Label
    Friend WithEvents _Rc As Label
    Friend WithEvents _Rb As Label
    Friend WithEvents Vrc As Label
    Friend WithEvents Vrb As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Ic As Label
    Friend WithEvents Ib As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Vce As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Ie As Label
    Friend WithEvents Button4 As Button
End Class
