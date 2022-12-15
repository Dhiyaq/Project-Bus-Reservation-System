<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.OnwordDateLabel = New System.Windows.Forms.Label()
        Me.OnwardMonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.EnterDestinationLabel = New System.Windows.Forms.Label()
        Me.DestinationComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.EnterSourceLabel = New System.Windows.Forms.Label()
        Me.SourceComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ReturnDateLabel = New System.Windows.Forms.Label()
        Me.ReturnDateMonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MyAccountButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 34)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bus tickets"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.SearchButton)
        Me.GroupBox1.Controls.Add(Me.ReturnDateLabel)
        Me.GroupBox1.Controls.Add(Me.ReturnDateMonthCalendar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 643)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox3)
        Me.GroupBox5.Controls.Add(Me.OnwordDateLabel)
        Me.GroupBox5.Controls.Add(Me.OnwardMonthCalendar)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 106)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(580, 231)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProjectDatabaseVB.My.Resources.Resources.icons8_calendar_24
        Me.PictureBox3.Location = New System.Drawing.Point(10, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'OnwordDateLabel
        '
        Me.OnwordDateLabel.AutoSize = True
        Me.OnwordDateLabel.Location = New System.Drawing.Point(120, 16)
        Me.OnwordDateLabel.Name = "OnwordDateLabel"
        Me.OnwordDateLabel.Size = New System.Drawing.Size(110, 16)
        Me.OnwordDateLabel.TabIndex = 26
        Me.OnwordDateLabel.Text = "ONWORD DATE"
        '
        'OnwardMonthCalendar
        '
        Me.OnwardMonthCalendar.Location = New System.Drawing.Point(267, 16)
        Me.OnwardMonthCalendar.Name = "OnwardMonthCalendar"
        Me.OnwardMonthCalendar.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.EnterDestinationLabel)
        Me.GroupBox4.Controls.Add(Me.DestinationComboBox)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(580, 50)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProjectDatabaseVB.My.Resources.Resources.icons8_bus_24
        Me.PictureBox4.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'EnterDestinationLabel
        '
        Me.EnterDestinationLabel.AutoSize = True
        Me.EnterDestinationLabel.Location = New System.Drawing.Point(82, 18)
        Me.EnterDestinationLabel.Name = "EnterDestinationLabel"
        Me.EnterDestinationLabel.Size = New System.Drawing.Size(148, 16)
        Me.EnterDestinationLabel.TabIndex = 21
        Me.EnterDestinationLabel.Text = "ENTER DESTINATION"
        '
        'DestinationComboBox
        '
        Me.DestinationComboBox.FormattingEnabled = True
        Me.DestinationComboBox.Items.AddRange(New Object() {"Kuala Lumpur", "Taiping", "Sitiawan", "Lumut", "Melaka Central ", "Terengganu", "Pahang", "Pulau Pinang ", "Muar", "Tangkak", "Johor Bahru", "Kedah", "Kamunting"})
        Me.DestinationComboBox.Location = New System.Drawing.Point(267, 18)
        Me.DestinationComboBox.Name = "DestinationComboBox"
        Me.DestinationComboBox.Size = New System.Drawing.Size(121, 24)
        Me.DestinationComboBox.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.EnterSourceLabel)
        Me.GroupBox3.Controls.Add(Me.SourceComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(580, 67)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProjectDatabaseVB.My.Resources.Resources.icons8_bus_24
        Me.PictureBox5.Location = New System.Drawing.Point(10, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'EnterSourceLabel
        '
        Me.EnterSourceLabel.AutoSize = True
        Me.EnterSourceLabel.Location = New System.Drawing.Point(116, 35)
        Me.EnterSourceLabel.Name = "EnterSourceLabel"
        Me.EnterSourceLabel.Size = New System.Drawing.Size(114, 16)
        Me.EnterSourceLabel.TabIndex = 22
        Me.EnterSourceLabel.Text = "ENTER SOURCE"
        '
        'SourceComboBox
        '
        Me.SourceComboBox.FormattingEnabled = True
        Me.SourceComboBox.Items.AddRange(New Object() {"Kuala Lumpur", "Taiping", "Sitiawan", "Lumut ", "Melaka Central", "Seremban", "Ipoh", "Kelantan ", "Pulau Pinang", "Kedah", "Perlis ", "Taiping", "Terengganu", "Pahang"})
        Me.SourceComboBox.Location = New System.Drawing.Point(267, 32)
        Me.SourceComboBox.Name = "SourceComboBox"
        Me.SourceComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SourceComboBox.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectDatabaseVB.My.Resources.Resources.icons8_calendar_24
        Me.PictureBox1.Location = New System.Drawing.Point(10, 369)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.Red
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchButton.Location = New System.Drawing.Point(168, 588)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(262, 38)
        Me.SearchButton.TabIndex = 15
        Me.SearchButton.Text = "SEARCH"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ReturnDateLabel
        '
        Me.ReturnDateLabel.AutoSize = True
        Me.ReturnDateLabel.Location = New System.Drawing.Point(47, 369)
        Me.ReturnDateLabel.Name = "ReturnDateLabel"
        Me.ReturnDateLabel.Size = New System.Drawing.Size(183, 16)
        Me.ReturnDateLabel.TabIndex = 14
        Me.ReturnDateLabel.Text = "RETURN DATE (OPTIONAL)"
        '
        'ReturnDateMonthCalendar
        '
        Me.ReturnDateMonthCalendar.Location = New System.Drawing.Point(267, 369)
        Me.ReturnDateMonthCalendar.Name = "ReturnDateMonthCalendar"
        Me.ReturnDateMonthCalendar.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MyAccountButton)
        Me.GroupBox2.Controls.Add(Me.HelpButton)
        Me.GroupBox2.Controls.Add(Me.HomeButton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 727)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 49)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'MyAccountButton
        '
        Me.MyAccountButton.Location = New System.Drawing.Point(439, 15)
        Me.MyAccountButton.Name = "MyAccountButton"
        Me.MyAccountButton.Size = New System.Drawing.Size(126, 28)
        Me.MyAccountButton.TabIndex = 3
        Me.MyAccountButton.Text = "My Account"
        Me.MyAccountButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(234, 15)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(126, 28)
        Me.HelpButton.TabIndex = 2
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HomeButton.Location = New System.Drawing.Point(16, 15)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(126, 28)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProjectDatabaseVB.My.Resources.Resources.icons8_double_decker_bus_50
        Me.PictureBox2.Location = New System.Drawing.Point(463, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(604, 815)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "HomeForm"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ReturnDateLabel As Label
    Friend WithEvents ReturnDateMonthCalendar As MonthCalendar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MyAccountButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents EnterDestinationLabel As Label
    Friend WithEvents DestinationComboBox As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents EnterSourceLabel As Label
    Friend WithEvents SourceComboBox As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents OnwordDateLabel As Label
    Friend WithEvents OnwardMonthCalendar As MonthCalendar
End Class
