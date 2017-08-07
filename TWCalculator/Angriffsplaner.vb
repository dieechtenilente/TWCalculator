Public Class Angriffsplaner



    Private Sub Angriffsplaner_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Rufe Angriffsplaner auf!")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        'Aktiv  Angriff Angreifer   Zieldorf     Verteidiger    Abschickzeit Ankunftszeit   Laufzeit    Kommentar
        Dim timerdaten As String = CheckBox1.Checked.ToString & " " & TextBox1.Text & " " & MaskedTextBox7.Text & " " & TextBox3.Text & " " & MaskedTextBox4.Text & " " & MaskedTextBox6.Text & " " & MaskedTextBox6.Text & " " & MaskedTextBox7.Text & " " & TextBox8.Text

        DataGridView1.Rows.Add(CheckBox1.Checked, TextBox1.Text, MaskedTextBox7.Text, TextBox3.Text, MaskedTextBox4.Text, MaskedTextBox6.Text, MaskedTextBox6.Text, MaskedTextBox7.Text, TextBox8.Text)
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Angriffsplaner: Alarm hinzugefügt!" + timerdaten)
    End Sub

End Class