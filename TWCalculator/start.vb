Public Class start

    Private Sub start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "TWCalculator" & "v. " & My.Settings.version & " on " & My.Computer.Info.OSFullName.ToString & " - Willkommen"
        Label2.Text = "v. " & My.Settings.version
        Label3.Text = "Herzlich willkommen zu dem Tribal Wars Calculator v." & My.Settings.version & "!"

        If My.Settings.firstrun = False Then
            twcalc_main.Show()
            Me.Close()
        End If

        If My.Settings.language = "german" Then ComboBox1.SelectedItem = "German (Deutsch)"
        If My.Settings.language = "english" Then ComboBox1.SelectedItem = "English (English)"

        aktivitätslog.ListBox1.Items.Add("Betriebssystem: " + My.Computer.Info.OSFullName.ToString + " (" + My.Computer.Info.OSVersion.ToString + ")")
        aktivitätslog.ListBox1.Items.Add("TWCalculator-Version: " + My.Settings.version + " (" + My.Settings.internalver + ")")
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " TWCalculator wurde gestartet.")
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Beginn der Aufzeichnung.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then My.Settings.firstrun = False
        twcalc_main.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "German (Deutsch)" Then My.Settings.language = "german"
        If ComboBox1.SelectedItem = "English (English)" Then My.Settings.language = "english"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://forum.die-staemme.de/showthread.php?182740-TWCalculator")
    End Sub

End Class