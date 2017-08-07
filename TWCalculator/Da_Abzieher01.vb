Public Class Da_Abzieher01
    Private Sub rechnen()
        Dim temp1 As Date
        Dim temp2 As Date
        Dim temp3 As Date

        temp3 = Date.ParseExact(MaskedTextBox1.Text, "HH:mm:ss", New Globalization.CultureInfo("de-DE"))
        temp1 = temp3
        temp3 = Date.ParseExact(MaskedTextBox2.Text, "HH:mm:ss", New Globalization.CultureInfo("de-DE"))
        temp2 = temp3
        MsgBox(temp1)
        MsgBox(temp2)

        ' MaskedTextBox3.Text = temp1 - temp2
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Da_Abzieher01: Gerechnet!")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim timeoftheday As String
        timeoftheday = TimeOfDay.Hour.ToString + ":" + TimeOfDay.Minute.ToString + ":" + TimeOfDay.Second.ToString

        '   If timeoftheday.ToString = background.alarmzeit.ToString Then
        'background.alarm()
        '  End If
    End Sub

    Private Sub MaskedTextBox2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox2.KeyDown
        If e.KeyCode = Keys.Tab Then
            e.SuppressKeyPress = True
            rechnen()
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            rechnen()
        End If
    End Sub

    Private Sub MaskedTextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Tab Then
            e.SuppressKeyPress = True
            MaskedTextBox2.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            MaskedTextBox2.Focus()
        End If
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        rechnen()
        Button3.Enabled = True
    End Sub

    'Alle Werte Löschen
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
    End Sub

    'Alarm setzen
    '   Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    '     background.AlarmSetzen()
    '  End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Stop()
        MsgBox("Alarm wurde abgebrochen!")
        Button5.Enabled = False
    End Sub

End Class