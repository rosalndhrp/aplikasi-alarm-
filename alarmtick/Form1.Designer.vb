<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbon = New System.Windows.Forms.CheckBox()
        Me.txtnada = New System.Windows.Forms.TextBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnpilih = New System.Windows.Forms.Button()
        Me.btmati = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsubuh = New System.Windows.Forms.TextBox()
        Me.btnsubuh = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltanggal
        '
        Me.lbltanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.Location = New System.Drawing.Point(232, 9)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(100, 26)
        Me.lbltanggal.TabIndex = 0
        Me.lbltanggal.Text = "Tanggal"
        Me.lbltanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jam Sekarang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SUBUH"
        '
        'lbljam
        '
        Me.lbljam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbljam.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbljam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.Location = New System.Drawing.Point(131, 41)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(118, 32)
        Me.lbljam.TabIndex = 3
        Me.lbljam.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nada"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'cbon
        '
        Me.cbon.AutoSize = True
        Me.cbon.Location = New System.Drawing.Point(442, 53)
        Me.cbon.Name = "cbon"
        Me.cbon.Size = New System.Drawing.Size(42, 17)
        Me.cbon.TabIndex = 6
        Me.cbon.Text = "ON"
        Me.cbon.UseVisualStyleBackColor = True
        '
        'txtnada
        '
        Me.txtnada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtnada.Location = New System.Drawing.Point(131, 276)
        Me.txtnada.Name = "txtnada"
        Me.txtnada.Size = New System.Drawing.Size(118, 20)
        Me.txtnada.TabIndex = 7
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(30, 322)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(219, 48)
        Me.AxWindowsMediaPlayer1.TabIndex = 8
        '
        'btnpilih
        '
        Me.btnpilih.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpilih.Location = New System.Drawing.Point(258, 276)
        Me.btnpilih.Name = "btnpilih"
        Me.btnpilih.Size = New System.Drawing.Size(51, 20)
        Me.btnpilih.TabIndex = 9
        Me.btnpilih.Text = "Pilih"
        Me.btnpilih.UseVisualStyleBackColor = True
        '
        'btmati
        '
        Me.btmati.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btmati.Location = New System.Drawing.Point(490, 44)
        Me.btmati.Name = "btmati"
        Me.btmati.Size = New System.Drawing.Size(46, 32)
        Me.btmati.TabIndex = 9
        Me.btmati.Text = "Mati"
        Me.btmati.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(473, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "KELUAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ZUHUR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ASHAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MAGRIB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ISYA"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(131, 120)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker2.TabIndex = 15
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DateTimePicker3.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(131, 153)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker3.TabIndex = 16
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker4.Location = New System.Drawing.Point(131, 187)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker4.TabIndex = 17
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker5.Location = New System.Drawing.Point(131, 218)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker5.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(344, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 150)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nada Subuh"
        '
        'txtsubuh
        '
        Me.txtsubuh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtsubuh.Location = New System.Drawing.Point(131, 250)
        Me.txtsubuh.Name = "txtsubuh"
        Me.txtsubuh.Size = New System.Drawing.Size(118, 20)
        Me.txtsubuh.TabIndex = 7
        '
        'btnsubuh
        '
        Me.btnsubuh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsubuh.Location = New System.Drawing.Point(258, 249)
        Me.btnsubuh.Name = "btnsubuh"
        Me.btnsubuh.Size = New System.Drawing.Size(51, 22)
        Me.btnsubuh.TabIndex = 20
        Me.btnsubuh.Text = "Pilih"
        Me.btnsubuh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.alarmtick.My.Resources.Resources.wall_islami_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(548, 372)
        Me.Controls.Add(Me.btnsubuh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker5)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btmati)
        Me.Controls.Add(Me.btnpilih)
        Me.Controls.Add(Me.txtsubuh)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.txtnada)
        Me.Controls.Add(Me.cbon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbljam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltanggal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "ALARM AZAN"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltanggal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbljam As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbon As CheckBox
    Friend WithEvents txtnada As TextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnpilih As Button
    Friend WithEvents btmati As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsubuh As TextBox
    Friend WithEvents btnsubuh As Button
End Class
