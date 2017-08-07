Imports System.IO

Public Class twcalc_main
    Dim speerBauzeit, schwertBauzeit, axtBauzeit, bogenBauzeit, späherBauzeit, leichteBauzeit, beritteneBauzeit, schwerBauzeit, rammenBauzeit, katasBauzeit As Integer
    Dim Speer, Schwert, Axt, Bogen, Späher, Leichte, Beritten, Schwer, Rammen, Katas As Integer

    'Stats
    Dim speerBKHolz As Integer = 50
    Dim speerBKLehm As Integer = 30
    Dim speerBKEisen As Integer = 10
    Dim speerBHP As Integer = 1
    Dim speerAAtt As Integer = 10
    Dim speerADev As Integer = 15
    Dim speerKDev As Integer = 45
    Dim speerBDef As Integer = 20
    Dim speerGeschw As Integer = 18
    Dim speerBeute As Integer = 25
    Dim schwertBKHolz As Integer = 30
    Dim schwertBKLehm As Integer = 30
    Dim schwertBKEisen As Integer = 70
    Dim schwertBHP As Integer = 1
    Dim schwertAAtt As Integer = 25
    Dim schwertADev As Integer = 50
    Dim schwertKDev As Integer = 15
    Dim schwertBDef As Integer = 40
    Dim schwertGeschw As Integer = 22
    Dim schwertBeute As Integer = 15
    Dim axtBKHolz As Integer = 60
    Dim axtBKLehm As Integer = 30
    Dim axtBKEisen As Integer = 40
    Dim axtBHP As Integer = 1
    Dim axtAAtt As Integer = 40
    Dim axtADev As Integer = 10
    Dim axtKDev As Integer = 5
    Dim axtBDef As Integer = 10
    Dim axtGeschw As Integer = 18
    Dim axtBeute As Integer = 10
    Dim bogenBKHolz As Integer = 100
    Dim bogenBKLehm As Integer = 30
    Dim bogenBKEisen As Integer = 60
    Dim bogenBHP As Integer = 1
    Dim bogenAAtt As Integer = 15
    Dim bogenADev As Integer = 50
    Dim bogenKDev As Integer = 40
    Dim bogenBDef As Integer = 5
    Dim bogenGeschw As Integer = 18
    Dim bogenBeute As Integer = 10
    Dim späherBKHolz As Integer = 50
    Dim späherBKLehm As Integer = 50
    Dim späherBKEisen As Integer = 20
    Dim späherBHP As Integer = 2
    Dim späherAAtt As Integer = 0
    Dim späherADev As Integer = 2
    Dim späherKDev As Integer = 1
    Dim späherBDef As Integer = 2
    Dim späherGeschw As Integer = 9
    Dim späherBeute As Integer = 0
    Dim leichteBKHolz As Integer = 125
    Dim leichteBKLehm As Integer = 100
    Dim leichteBKEisen As Integer = 250
    Dim leichteBHP As Integer = 4
    Dim leichteAAtt As Integer = 130
    Dim leichteADev As Integer = 30
    Dim leichteKDev As Integer = 40
    Dim leichteBDef As Integer = 30
    Dim leichteGeschw As Integer = 10
    Dim leichteBeute As Integer = 80
    Dim beritteneBKHolz As Integer = 250
    Dim beritteneBKLehm As Integer = 100
    Dim beritteneBKEisen As Integer = 150
    Dim beritteneBHP As Integer = 5
    Dim beritteneAAtt As Integer = 120
    Dim beritteneADev As Integer = 40
    Dim beritteneKDev As Integer = 30
    Dim beritteneBDef As Integer = 50
    Dim beritteneGeschw As Integer = 10
    Dim beritteneBeute As Integer = 50
    Dim schwerBKHolz As Integer = 200
    Dim schwerBKLehm As Integer = 150
    Dim schwerBKEisen As Integer = 600
    Dim schwerBHP As Integer = 6
    Dim schwerAAtt As Integer = 150
    Dim schwerADev As Integer = 200
    Dim schwerKDev As Integer = 80
    Dim schwerBDef As Integer = 180
    Dim schwerGeschw As Integer = 11
    Dim schwerBeute As Integer = 50
    Dim rammenBKHolz As Integer = 300
    Dim rammenBKLehm As Integer = 200
    Dim rammenBKEisen As Integer = 200
    Dim rammenBHP As Integer = 5
    Dim rammenAAtt As Integer = 2
    Dim rammenADev As Integer = 20
    Dim rammenKDev As Integer = 50
    Dim rammenBDef As Integer = 20
    Dim rammenGeschw As Integer = 30
    Dim rammenBeute As Integer = 0
    Dim katasBKHolz As Integer = 320
    Dim katasBKLehm As Integer = 400
    Dim katasBKEisen As Integer = 100
    Dim katasBHP As Integer = 8
    Dim katasAAtt As Integer = 100
    Dim katasADev As Integer = 100
    Dim katasKDev As Integer = 50
    Dim katasBDef As Integer = 100
    Dim katasGeschw As Integer = 30
    Dim katasBeute As Integer = 0
    

    Private Sub twcalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "TWCalculator" & " v. " & My.Settings.version
        Me.Size = New System.Drawing.Size(683, 548)
    End Sub


    Public Sub rechnen()

        Speer = Val(TextBox1.Text)
        Schwert = Val(TextBox2.Text)
        Axt = Val(TextBox3.Text)
        Bogen = Val(TextBox4.Text)
        Späher = Val(TextBox5.Text)
        Leichte = Val(TextBox6.Text)
        Beritten = Val(TextBox7.Text)
        Schwer = Val(TextBox8.Text)
        Rammen = Val(TextBox9.Text)
        Katas = Val(TextBox10.Text)

        TextBox11.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) * 2 + Val(TextBox6.Text) * 4 + Val(TextBox7.Text) * 5 + Val(TextBox8.Text) * 6 + Val(TextBox9.Text) * 5 + Val(TextBox10.Text) * 8
        TextBox12.Text = speerBKHolz * Val(TextBox1.Text) + schwertBKHolz * Val(TextBox2.Text) + axtBKHolz * Val(TextBox3.Text) + bogenBKHolz * Val(TextBox4.Text) + späherBKHolz * Val(TextBox5.Text) + leichteBKHolz * Val(TextBox6.Text) + beritteneBKHolz * Val(TextBox7.Text) + schwerBKHolz * Val(TextBox8.Text) + rammenBKHolz * Val(TextBox9.Text) + katasBKHolz * Val(TextBox10.Text)
        TextBox13.Text = speerBKLehm * Val(TextBox1.Text) + schwertBKLehm * Val(TextBox2.Text) + axtBKLehm * Val(TextBox3.Text) + bogenBKLehm * Val(TextBox4.Text) + späherBKLehm * Val(TextBox5.Text) + leichteBKLehm * Val(TextBox6.Text) + beritteneBKLehm * Val(TextBox7.Text) + schwerBKLehm * Val(TextBox8.Text) + rammenBKLehm * Val(TextBox9.Text) + katasBKLehm * Val(TextBox10.Text)
        TextBox14.Text = speerBKEisen * Val(TextBox1.Text) + schwertBKEisen * Val(TextBox2.Text) + axtBKEisen * Val(TextBox3.Text) + bogenBKEisen * Val(TextBox4.Text) + späherBKEisen * Val(TextBox5.Text) + leichteBKEisen * Val(TextBox6.Text) + beritteneBKEisen * Val(TextBox7.Text) + schwerBKEisen * Val(TextBox8.Text) + rammenBKEisen * Val(TextBox9.Text) + katasBKEisen * Val(TextBox10.Text)
        TextBox15.Text = speerAAtt * Val(TextBox1.Text) + schwertAAtt * Val(TextBox2.Text) + axtAAtt * Val(TextBox3.Text) + bogenAAtt * Val(TextBox4.Text) + späherAAtt * Val(TextBox5.Text) + leichteAAtt * Val(TextBox6.Text) + beritteneAAtt * Val(TextBox7.Text) + schwerAAtt * Val(TextBox8.Text) + rammenAAtt * Val(TextBox9.Text) + katasAAtt * Val(TextBox10.Text)
        TextBox16.Text = speerADev * Val(TextBox1.Text) + schwertADev * Val(TextBox2.Text) + axtADev * Val(TextBox3.Text) + bogenADev * Val(TextBox4.Text) + späherADev * Val(TextBox5.Text) + leichteADev * Val(TextBox6.Text) + beritteneADev * Val(TextBox7.Text) + schwerADev * Val(TextBox8.Text) + rammenADev * Val(TextBox9.Text) + katasADev * Val(TextBox10.Text)
        TextBox17.Text = speerKDev * Val(TextBox1.Text) + schwertKDev * Val(TextBox2.Text) + axtKDev * Val(TextBox3.Text) + bogenKDev * Val(TextBox4.Text) + späherKDev * Val(TextBox5.Text) + leichteKDev * Val(TextBox6.Text) + beritteneKDev * Val(TextBox7.Text) + schwerKDev * Val(TextBox8.Text) + rammenKDev * Val(TextBox9.Text) + katasKDev * Val(TextBox10.Text)
        TextBox18.Text = speerBDef * Val(TextBox1.Text) + schwertBDef * Val(TextBox2.Text) + axtBDef * Val(TextBox3.Text) + bogenBDef * Val(TextBox4.Text) + späherBDef * Val(TextBox5.Text) + leichteBDef * Val(TextBox6.Text) + beritteneBDef * Val(TextBox7.Text) + schwerBDef * Val(TextBox8.Text) + rammenBDef * Val(TextBox9.Text) + katasBDef * Val(TextBox10.Text)
        TextBox19.Text = speerBeute * Val(TextBox1.Text) + schwertBeute * Val(TextBox2.Text) + axtBeute * Val(TextBox3.Text) + bogenBeute * Val(TextBox4.Text) + späherBeute * Val(TextBox5.Text) + leichteBeute * Val(TextBox6.Text) + beritteneBeute * Val(TextBox7.Text) + schwerBeute * Val(TextBox8.Text) + rammenBeute * Val(TextBox9.Text) + katasBeute * Val(TextBox10.Text)

        If Späher <> 0 Then TextBox20.Text = 9
        If Leichte <> 0 Or Beritten <> 0 Then TextBox20.Text = 10
        If Schwer <> 0 Then TextBox20.Text = 11
        If Speer <> 0 Or Axt <> 0 Or Bogen <> 0 Then TextBox20.Text = 18
        If Schwert <> 0 Then TextBox20.Text = 22
        If Rammen <> 0 Or Katas <> 0 Then TextBox20.Text = 30

        TextBox21.Text = (Val(TextBox1.Text) * speerBauzeit + Val(TextBox2.Text) * schwertBauzeit + Val(TextBox3.Text) * axtBauzeit + Val(TextBox4.Text) * bogenBauzeit) / 60 / 60 / 24
        TextBox22.Text = (späherBauzeit * Val(TextBox5.Text) + leichteBauzeit * Val(TextBox6.Text) + beritteneBauzeit * Val(TextBox7.Text) + schwerBauzeit * Val(TextBox8.Text)) / 60 / 60 / 24
        TextBox23.Text = (rammenBauzeit * Val(TextBox9.Text) + katasBauzeit * Val(TextBox10.Text)) / 60 / 60 / 24

        If TextBox21.Text < TextBox22.Text Then
            If TextBox22.Text < TextBox23.Text Then TextBox24.Text = TextBox23.Text Else TextBox24.Text = TextBox22.Text
        Else
            If TextBox21.Text < TextBox23.Text Then TextBox24.Text = TextBox23.Text Else TextBox24.Text = TextBox21.Text
        End If

        TextBox25.Text = (Val(TextBox1.Text) * speerBauzeit + Val(TextBox2.Text) * schwertBauzeit + Val(TextBox3.Text) * axtBauzeit + Val(TextBox4.Text) * bogenBauzeit) / 60 / 60
        TextBox26.Text = (späherBauzeit * Val(TextBox5.Text) + leichteBauzeit * Val(TextBox6.Text) + beritteneBauzeit * Val(TextBox7.Text) + schwerBauzeit * Val(TextBox8.Text)) / 60 / 60
        TextBox27.Text = (rammenBauzeit * Val(TextBox9.Text) + katasBauzeit * Val(TextBox10.Text)) / 60 / 60
        If TextBox25.Text < TextBox26.Text Then
            If TextBox26.Text < TextBox27.Text Then TextBox28.Text = TextBox27.Text Else TextBox28.Text = TextBox26.Text
        Else
            If TextBox25.Text < TextBox27.Text Then TextBox28.Text = TextBox27.Text Else TextBox28.Text = TextBox25.Text
        End If

        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Werte wurden ausgerechnet.")
    End Sub

    Private Sub VergleicherFuellen()
        If RadioButton1.Checked = True Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add(TextBox2.Text)
            ListBox1.Items.Add(TextBox3.Text)
            ListBox1.Items.Add(TextBox4.Text)
            ListBox1.Items.Add(TextBox5.Text)
            ListBox1.Items.Add(TextBox6.Text)
            ListBox1.Items.Add(TextBox7.Text)
            ListBox1.Items.Add(TextBox8.Text)
            ListBox1.Items.Add(TextBox9.Text)
            ListBox1.Items.Add(TextBox10.Text)
            ListBox1.Items.Add("-----------------------------------")
            ListBox1.Items.Add(TextBox12.Text)
            ListBox1.Items.Add(TextBox13.Text)
            ListBox1.Items.Add(TextBox14.Text)
            ListBox1.Items.Add("-----------------------------------")
            ListBox1.Items.Add(TextBox15.Text)
            ListBox1.Items.Add(TextBox16.Text)
            ListBox1.Items.Add(TextBox17.Text)
            ListBox1.Items.Add(TextBox18.Text)
            ListBox1.Items.Add("-----------------------------------")
            ListBox1.Items.Add(TextBox20.Text)
            ListBox1.Items.Add(TextBox11.Text)
            ListBox1.Items.Add(TextBox19.Text)
            ListBox1.Items.Add("-----------------------------------")
            ListBox1.Items.Add(TextBox21.Text)
            ListBox1.Items.Add(TextBox22.Text)
            ListBox1.Items.Add(TextBox23.Text)
            ListBox1.Items.Add(TextBox24.Text)
        Else
            If RadioButton2.Checked = True Then
                ListBox2.Items.Clear()
                ListBox2.Items.Add(TextBox1.Text)
                ListBox2.Items.Add(TextBox2.Text)
                ListBox2.Items.Add(TextBox3.Text)
                ListBox2.Items.Add(TextBox4.Text)
                ListBox2.Items.Add(TextBox5.Text)
                ListBox2.Items.Add(TextBox6.Text)
                ListBox2.Items.Add(TextBox7.Text)
                ListBox2.Items.Add(TextBox8.Text)
                ListBox2.Items.Add(TextBox9.Text)
                ListBox2.Items.Add(TextBox10.Text)
                ListBox2.Items.Add("-----------------------------------")
                ListBox2.Items.Add(TextBox12.Text)
                ListBox2.Items.Add(TextBox13.Text)
                ListBox2.Items.Add(TextBox14.Text)
                ListBox2.Items.Add("-----------------------------------")
                ListBox2.Items.Add(TextBox15.Text)
                ListBox2.Items.Add(TextBox16.Text)
                ListBox2.Items.Add(TextBox17.Text)
                ListBox2.Items.Add(TextBox18.Text)
                ListBox2.Items.Add("-----------------------------------")
                ListBox2.Items.Add(TextBox20.Text)
                ListBox2.Items.Add(TextBox11.Text)
                ListBox2.Items.Add(TextBox19.Text)
                ListBox2.Items.Add("-----------------------------------")
                ListBox2.Items.Add(TextBox21.Text)
                ListBox2.Items.Add(TextBox22.Text)
                ListBox2.Items.Add(TextBox23.Text)
                ListBox2.Items.Add(TextBox24.Text)
            End If
        End If
    End Sub
   
    Private Sub SchließenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchließenToolStripMenuItem.Click
        schließen()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        ÜberTWCalculator.Show()
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Zeige den Infoscreen.")
    End Sub

    Private Sub LogAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogAnzeigenToolStripMenuItem.Click
        aktivitätslog.Show()
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Zeige Log.")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Size.Width = 683 Then
            Me.Size = New System.Drawing.Size(1142, 548)
            Button1.Text = "<<"
        Else
            Me.Size = New System.Drawing.Size(683, 548)
            Button1.Text = ">>"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then TextBox1.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then TextBox2.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then TextBox3.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then TextBox4.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then TextBox5.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then TextBox6.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then TextBox7.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then TextBox8.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then TextBox9.Text = 0
        rechnen()
    End Sub
    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "" Then TextBox10.Text = 0
        rechnen()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        settings.Show()
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Zeige Einstellungen")
    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged
        Vergleich1SpeichernToolStripMenuItem.Text = TextBox29.Text
    End Sub

    Private Sub TextBox30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.TextChanged
        Vergleich2SpeichernToolStripMenuItem.Text = TextBox30.Text
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        Dim sav As New SaveFileDialog
        Dim text As String = ""
        sav.Filter = "TWCalculator |*.twc"
        If sav.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each item As String In ListBox1.Items
                text &= vbCrLf & item
            Next
            IO.File.WriteAllText(sav.FileName, text)
        End If
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Sichere Vergleich 1")
    End Sub

    Private Sub SpeichernToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripMenuItem1.Click
        Dim text As String = ""
        SaveFileDialog1.Filter = "TWCalculator |*.twc"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each item As String In ListBox2.Items
                text &= vbCrLf & item
            Next
            IO.File.WriteAllText(SaveFileDialog1.FileName, text)
        End If
        aktivitätslog.ListBox1.Items.Add(TimeOfDay & " Sichere Vergleich 2")
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        Dim Array() As String = Nothing
        OpenFileDialog1.ShowDialog()
        ListBox1.Items.Clear()
        Array = System.IO.File.ReadAllText(OpenFileDialog1.FileName.ToString).Split(CChar(vbCrLf))
        ListBox1.Items.AddRange(Array)
        ListBox1.Items.RemoveAt(0)

        aktivitätslog.ListBox1.Items.Add("Öffne Vergleich 1")
    End Sub

    Private Sub ÖffnenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem1.Click
        Dim Array() As String = Nothing
        OpenFileDialog1.ShowDialog()
        ListBox2.Items.Clear()
        Array = System.IO.File.ReadAllText(OpenFileDialog1.FileName.ToString).Split(CChar(vbCrLf))
        ListBox2.Items.AddRange(Array)
        ListBox1.Items.RemoveAt(0)

        aktivitätslog.ListBox1.Items.Add("Öffne Datei in Vergleich 2")
    End Sub

    Private Sub GuselerinoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuselerinoToolStripMenuItem.Click
        Da_Abzieher01.Show()
    End Sub

    Private Sub AngriffsplanerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngriffsplanerToolStripMenuItem.Click
        Angriffsplaner.Show()
    End Sub

    Private Sub schließen()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index As Integer = ComboBox1.SelectedIndex
        If index = -1 Then
            MsgBox("Bitte Welt auswählen", "TWCalculator")
        Else
            'Speed: 1
            If index = 0 Or 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 9 Or 10 Or 11 Or 12 Or 14 Or 16 Or 19 Or 20 Or 23 Or 24 Or 27 Or 28 Or 29 Or 30 Or 31 Or 32 Or 33 Then
                speerBauzeit = 158
                schwertBauzeit = 232
                axtBauzeit = 205
                bogenBauzeit = 279
                späherBauzeit = 187
                leichteBauzeit = 374
                beritteneBauzeit = 561
                schwerBauzeit = 748
                rammenBauzeit = 1335
                katasBauzeit = 2002
            End If

            'Speed: 1,6
            If index = 8 Or 13 Or 15 Or 17 Or 18 Or 21 Or 22 Or 25 Or 26 Or 34 Then
                speerBauzeit = 100
                schwertBauzeit = 146
                axtBauzeit = 129
                bogenBauzeit = 175
                späherBauzeit = 117
                leichteBauzeit = 234
                beritteneBauzeit = 351
                schwerBauzeit = 468
                rammenBauzeit = 835
                katasBauzeit = 1252
            End If
        End If
    End Sub
End Class