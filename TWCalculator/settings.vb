Public Class settings

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "v. " & My.Settings.version
        Me.Text = "TWCalculator" & " v. " & My.Settings.version & " - Einstellungen"
        If My.Settings.firstrun = True Then CheckBox1.Checked = True
        If My.Settings.language = "german" Then ComboBox1.SelectedItem = "German (Deutsch)"
        If My.Settings.language = "english" Then ComboBox1.SelectedItem = "English (English)"
        Label4.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then My.Settings.firstrun = True
        If ComboBox1.SelectedItem = "German (Deutsch)" Then My.Settings.language = "german"
        If ComboBox1.SelectedItem = "English (English)" Then My.Settings.language = "english"
        If My.Settings.language = "english" Then MsgBox("Settings will be changed after restart.")
        If My.Settings.language = "german" Then MsgBox("Einstellungen werden erst nach Neustart aktiv.")
        My.Settings.sqlpath = TextBox1.Text.ToString
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("http://forum.die-staemme.de/showthread.php?182740-TWCalculator")
    End Sub
End Class