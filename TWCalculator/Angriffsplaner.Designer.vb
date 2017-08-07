<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Angriffsplaner
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Angriffsplaner))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Zeit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngriffsDorf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Angreifer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZielDorf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Verteidiger = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abschickzeit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnkunftsZeit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Laufzeit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kommentar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Zeit, Me.AngriffsDorf, Me.Angreifer, Me.ZielDorf, Me.Verteidiger, Me.Abschickzeit, Me.AnkunftsZeit, Me.Laufzeit, Me.Kommentar})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(950, 296)
        Me.DataGridView1.TabIndex = 1
        '
        'Zeit
        '
        Me.Zeit.DividerWidth = 2
        Me.Zeit.HeaderText = "Aktiv"
        Me.Zeit.Name = "Zeit"
        Me.Zeit.ToolTipText = "Ist der Alarm aktiv?"
        '
        'AngriffsDorf
        '
        Me.AngriffsDorf.HeaderText = "[A]Angriffs-Dorf"
        Me.AngriffsDorf.Name = "AngriffsDorf"
        Me.AngriffsDorf.ToolTipText = "Das Dorf des Angreifers"
        '
        'Angreifer
        '
        Me.Angreifer.DividerWidth = 2
        Me.Angreifer.HeaderText = "[A]Angreifer"
        Me.Angreifer.Name = "Angreifer"
        Me.Angreifer.ToolTipText = "Der Angreifer"
        '
        'ZielDorf
        '
        Me.ZielDorf.HeaderText = "[V]Ziel-Dorf"
        Me.ZielDorf.Name = "ZielDorf"
        Me.ZielDorf.ToolTipText = "Das Zieldorf des Angriffs"
        '
        'Verteidiger
        '
        Me.Verteidiger.HeaderText = "[V]Verteidiger"
        Me.Verteidiger.Name = "Verteidiger"
        Me.Verteidiger.ToolTipText = "Der Verteidiger"
        '
        'Abschickzeit
        '
        Me.Abschickzeit.HeaderText = "[V]Abschickzeit"
        Me.Abschickzeit.Name = "Abschickzeit"
        Me.Abschickzeit.ToolTipText = "Die Abschickszeit, bei der die Deff abgeschickt werden muss."
        '
        'AnkunftsZeit
        '
        Me.AnkunftsZeit.HeaderText = "[V]Ankunfts-Zeit"
        Me.AnkunftsZeit.Name = "AnkunftsZeit"
        Me.AnkunftsZeit.ToolTipText = "Die Ankunfszeit der Deff"
        '
        'Laufzeit
        '
        Me.Laufzeit.DividerWidth = 5
        Me.Laufzeit.HeaderText = "[V]Laufzeit"
        Me.Laufzeit.Name = "Laufzeit"
        Me.Laufzeit.ToolTipText = "Die Laufzeit der Deff"
        '
        'Kommentar
        '
        Me.Kommentar.DividerWidth = 1
        Me.Kommentar.HeaderText = "[V]Kommentar"
        Me.Kommentar.Name = "Kommentar"
        Me.Kommentar.ToolTipText = "Zusätzlicher Kommentar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button1.Location = New System.Drawing.Point(376, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Eintrag hinzufügen"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(199, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Angriffs-Dorf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Angreifer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Verteidiger"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(199, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Zieldorf-Dorf"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(202, 106)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Alarm Aktiv?"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Abschickzeit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(199, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ankunfts-Zeit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Laufzeit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(6, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Kommentar:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TextBox1.Location = New System.Drawing.Point(79, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TextBox3.Location = New System.Drawing.Point(79, 52)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TextBox8.Location = New System.Drawing.Point(79, 130)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(291, 20)
        Me.TextBox8.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox6)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox7)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 159)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daten"
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.MaskedTextBox6.BeepOnError = True
        Me.MaskedTextBox6.Location = New System.Drawing.Point(270, 79)
        Me.MaskedTextBox6.Mask = "__:__:__"
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox6.TabIndex = 24
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.MaskedTextBox4.BeepOnError = True
        Me.MaskedTextBox4.Location = New System.Drawing.Point(270, 53)
        Me.MaskedTextBox4.Mask = "___,___"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox4.TabIndex = 23
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.MaskedTextBox2.BeepOnError = True
        Me.MaskedTextBox2.Location = New System.Drawing.Point(270, 26)
        Me.MaskedTextBox2.Mask = "___,___"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 22
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.MaskedTextBox7.BeepOnError = True
        Me.MaskedTextBox7.Location = New System.Drawing.Point(79, 104)
        Me.MaskedTextBox7.Mask = "__:__:__"
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox7.TabIndex = 21
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.MaskedTextBox5.BeepOnError = True
        Me.MaskedTextBox5.Location = New System.Drawing.Point(79, 78)
        Me.MaskedTextBox5.Mask = "__:__:__"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox5.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(536, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 159)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(206, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "NOT ENABLED YET."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(414, 140)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Angriffsplaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TWCalculator.My.Resources.Resources.bg_tile
        Me.ClientSize = New System.Drawing.Size(974, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Angriffsplaner"
        Me.Text = "Angriffsplaner"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Zeit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AngriffsDorf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Angreifer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZielDorf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Verteidiger As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abschickzeit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnkunftsZeit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Laufzeit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kommentar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox7 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
End Class
