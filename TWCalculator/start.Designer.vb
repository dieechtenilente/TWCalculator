<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nobile", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TWCalculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(455, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Versionsnummer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Weiter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(403, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Herzlich willkommen zu dem Tribal Wars Calculator v. Versionsnummer !"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(544, 98)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(12, 343)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(260, 19)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Diesen Dialog beim Starten nicht anzeigen"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"v2.2 Allgemeine Verbesserungen", "v2.1 Support für Welt de28, de43, de65, de67, de70, de80, de96, de98", "v2.1 Support für Welt  de101, de104, de105, de106, de108, de110, de114", "v2.1 Support für Welt  de115, de118, de119, de122, dep1, dep2, dep3", "v2.1 Support für Welt  dep4, dep5, de100, de107, de109, de112, de113", "v2.1 Support für Welt  de116, de117, de120, de121", "v2.1 Alarmfunktion aufgrund eines Fehlers entfernt", "v2.0 Kleine Bugfixes", "v2.0 Texte auf korrektes Deutsch gebracht. Yo.", "v2.0 Designänderungen am TWCalculator", "v2.0 Da_Abzieher01: Alarmfunktion erweitert", "v2.0 Da_Abzieher01: Alarm hinzugefügt", "v2.0 Da_Abzieher01: Kleine Design-Änderungen", "v2.0 Link zum Foren-Thread hinzugefügt", "v1.9 Da_Abzieher01 hinzugefügt", "v1.8 Updatefunktion aktiviert", "v1.8 Bugfixes", "v1.8 Sprachunterstützung für Englisch hinzugefügt", "v1.7 Erstveröffentlichung im DS-Forum", "v1.7 Sprachunterstützung hinzugefügt (noch nicht verfügbar)", "v1.7 Bugfixes", "v1.6 Bugfixes (5)", "v1.5 Öffnen-Funktion hinzugefügt", "v1.4 Startdialog hinzugefügt", "v1.3 Speichern-Funktion hinzugefügt", "v1.3 Bugfixes", "v1.0 Vergleichfunktion hinzugefügt", "v0.9 Automatisches Ausrechnen hinzugefügt", "v0.8 Icons hinzugefügt", "v0.7 Texturen eingefügt", "v0.6 Menüleiste hinzugefügt", "v0.1 - v0.5 Grobes Layout, Funktionen hinzugefügt"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 238)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(544, 94)
        Me.ListBox1.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Changelog:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(12, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Change Language"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"German (Deutsch)", "English (English)"})
        Me.ComboBox1.Location = New System.Drawing.Point(127, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 23)
        Me.ComboBox1.TabIndex = 54
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(446, 220)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 15)
        Me.LinkLabel1.TabIndex = 56
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Zum Foren-Thread"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TWCalculator.My.Resources.Resources.bg_tile_credits
        Me.ClientSize = New System.Drawing.Size(568, 369)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "start"
        Me.Text = "TWCalculator - Willkommen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
