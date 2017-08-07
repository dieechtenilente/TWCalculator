Public Class aktivitätslog
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SaveFileDialog1.Filter = "Logdatei|*.txt"
        Me.Text = "Log: TWCalculator" & "v. " & My.Settings.version
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Text = "TWCalculator: Log"

            For Each item As String In ListBox1.Items
                Text &= vbCrLf & item
            Next
            IO.File.WriteAllText(SaveFileDialog1.FileName, Text)
            Me.Text = "TWCalculator: Log"
        End If
        Me.Text = "Log: TWCalculator" & "v. " & My.Settings.version
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class