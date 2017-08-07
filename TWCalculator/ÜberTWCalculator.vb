Public Class ÜberTWCalculator
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "v. " & My.Settings.version
        Me.Text = "Über: TWCalculator" & "v. " & My.Settings.version
    End Sub
End Class