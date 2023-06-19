Public Class Form1
    Dim alarm As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker4.Format = DateTimePickerFormat.Time
        DateTimePicker5.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbltanggal.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbltanggal.Text = Format(Now, "dd/MMM/yyyy")
        lbljam.Text = DateTime.Now.ToLongTimeString
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If TimeOfDay = DateTimePicker1.Text Then
                If alarm = 1 Then
                    AxWindowsMediaPlayer1.URL = txtsubuh.Text.ToString
                    Label8.Text = "SHOLAT SUBUH"

                Else
                    MsgBox(DateTimePicker1.Value)
                End If
            End If
            If TimeOfDay = DateTimePicker2.Text Then
                If alarm = 1 Then
                    AxWindowsMediaPlayer1.URL = txtnada.Text.ToString
                    Label8.Text = "SHOLAT ZUHUR"
                Else
                    MsgBox(DateTimePicker2.Value)
                End If
            End If

            If TimeOfDay = DateTimePicker3.Text Then
                If alarm = 1 Then
                    AxWindowsMediaPlayer1.URL = txtnada.Text.ToString
                    Label8.Text = "SHOLAT ASHAR"
                Else
                    MsgBox(DateTimePicker3.Value)
                End If
            End If

            If TimeOfDay = DateTimePicker4.Text Then
                If alarm = 1 Then
                    AxWindowsMediaPlayer1.URL = txtnada.Text.ToString
                    Label8.Text = "SHOLAT MAGRIB"
                Else
                    MsgBox(DateTimePicker4.Value)

                End If
            End If

            If TimeOfDay = DateTimePicker5.Text Then
                If alarm = 1 Then
                    AxWindowsMediaPlayer1.URL = txtnada.Text.ToString
                    Label8.Text = "SHOLAT ISYA"
                Else
                    MsgBox(DateTimePicker5.Value)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbon_CheckedChanged(sender As Object, e As EventArgs) Handles cbon.CheckedChanged
        If cbon.Checked = True Then
            cbon.Text = "ON"
            Timer1.Enabled = True
        Else
            cbon.Text = "OFF"
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub btnpilih_Click(sender As Object, e As EventArgs) Handles btnpilih.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtnada.Text = ""
            txtnada.Text = OpenFileDialog1.FileName
            alarm = 1

        End If
    End Sub

    Private Sub btmati_Click(sender As Object, e As EventArgs) Handles btmati.Click
        cbon.Text = "OFF"
        cbon.Checked = False
        Timer1.Enabled = False
        AxWindowsMediaPlayer1.close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label9.Click

    End Sub

    Private Sub txtnada_TextChanged(sender As Object, e As EventArgs) Handles txtnada.TextChanged, txtsubuh.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub btnsubuh_Click(sender As Object, e As EventArgs) Handles btnsubuh.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtsubuh.Text = ""
            txtsubuh.Text = OpenFileDialog1.FileName
            alarm = 1

        End If
    End Sub
End Class
