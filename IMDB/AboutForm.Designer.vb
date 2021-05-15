<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.AboutName = New System.Windows.Forms.Label()
        Me.CloseAboutForm = New System.Windows.Forms.PictureBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.AppInfo = New System.Windows.Forms.Label()
        Me.ProjectManager = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Border = New System.Windows.Forms.Panel()
        Me.theTeam = New System.Windows.Forms.Label()
        Me.MovePanel.SuspendLayout()
        CType(Me.CloseAboutForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Border.SuspendLayout()
        Me.SuspendLayout()
        '
        'MovePanel
        '
        Me.MovePanel.BackColor = System.Drawing.Color.Transparent
        Me.MovePanel.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.MovePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MovePanel.Controls.Add(Me.AboutName)
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(464, 22)
        Me.MovePanel.TabIndex = 0
        '
        'AboutName
        '
        Me.AboutName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutName.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AboutName.Location = New System.Drawing.Point(0, 0)
        Me.AboutName.Name = "AboutName"
        Me.AboutName.Size = New System.Drawing.Size(464, 22)
        Me.AboutName.TabIndex = 0
        Me.AboutName.Text = "About Us"
        Me.AboutName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseAboutForm
        '
        Me.CloseAboutForm.BackColor = System.Drawing.Color.Transparent
        Me.CloseAboutForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseAboutForm.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.CloseAboutForm.Location = New System.Drawing.Point(434, 5)
        Me.CloseAboutForm.Name = "CloseAboutForm"
        Me.CloseAboutForm.Size = New System.Drawing.Size(25, 25)
        Me.CloseAboutForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseAboutForm.TabIndex = 1
        Me.CloseAboutForm.TabStop = False
        '
        'Logo
        '
        Me.Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = Global.IMDB.My.Resources.Resources.Panda_movies
        Me.Logo.Location = New System.Drawing.Point(7, 48)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(145, 139)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'AppInfo
        '
        Me.AppInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AppInfo.BackColor = System.Drawing.Color.Transparent
        Me.AppInfo.Font = New System.Drawing.Font("SimSun-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AppInfo.ForeColor = System.Drawing.Color.DarkOrange
        Me.AppInfo.Location = New System.Drawing.Point(158, 52)
        Me.AppInfo.Name = "AppInfo"
        Me.AppInfo.Size = New System.Drawing.Size(289, 241)
        Me.AppInfo.TabIndex = 3
        Me.AppInfo.Text = resources.GetString("AppInfo.Text")
        '
        'ProjectManager
        '
        Me.ProjectManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ProjectManager.BackColor = System.Drawing.Color.Transparent
        Me.ProjectManager.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProjectManager.ForeColor = System.Drawing.Color.DarkOrange
        Me.ProjectManager.Location = New System.Drawing.Point(0, 344)
        Me.ProjectManager.Name = "ProjectManager"
        Me.ProjectManager.Size = New System.Drawing.Size(454, 21)
        Me.ProjectManager.TabIndex = 4
        Me.ProjectManager.Text = "Project Manager"
        Me.ProjectManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(0, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Back end developer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(0, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Front end devloper"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SimSun-ExtB", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(0, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Νικόλαος Μαυροδόντης"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("SimSun-ExtB", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(0, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(454, 38)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Νικόλαος Μαυροδόντης" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Παντελεήμων Καμπούρης"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("SimSun-ExtB", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(0, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(454, 38)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Παπαδόπουλος Αλέξανδρος" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Δημήτριος Κουτσοκώστας"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("SimSun-ExtB", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(0, 548)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(454, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Θάνος Αθανάσιος Νικόλαος"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(0, 524)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(454, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "UX / Design / Testing"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Border
        '
        Me.Border.BackColor = System.Drawing.SystemColors.Control
        Me.Border.BackgroundImage = CType(resources.GetObject("Border.BackgroundImage"), System.Drawing.Image)
        Me.Border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Border.Controls.Add(Me.theTeam)
        Me.Border.Controls.Add(Me.Label6)
        Me.Border.Controls.Add(Me.Logo)
        Me.Border.Controls.Add(Me.Label7)
        Me.Border.Controls.Add(Me.AppInfo)
        Me.Border.Controls.Add(Me.Label5)
        Me.Border.Controls.Add(Me.ProjectManager)
        Me.Border.Controls.Add(Me.Label4)
        Me.Border.Controls.Add(Me.Label1)
        Me.Border.Controls.Add(Me.Label3)
        Me.Border.Controls.Add(Me.Label2)
        Me.Border.Location = New System.Drawing.Point(5, 0)
        Me.Border.Name = "Border"
        Me.Border.Size = New System.Drawing.Size(454, 571)
        Me.Border.TabIndex = 12
        '
        'theTeam
        '
        Me.theTeam.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.theTeam.BackColor = System.Drawing.Color.Transparent
        Me.theTeam.Font = New System.Drawing.Font("SimSun", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.theTeam.ForeColor = System.Drawing.Color.DarkOrange
        Me.theTeam.Location = New System.Drawing.Point(0, 306)
        Me.theTeam.Name = "theTeam"
        Me.theTeam.Size = New System.Drawing.Size(454, 32)
        Me.theTeam.TabIndex = 12
        Me.theTeam.Text = "The PANDA team"
        Me.theTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 575)
        Me.Controls.Add(Me.CloseAboutForm)
        Me.Controls.Add(Me.MovePanel)
        Me.Controls.Add(Me.Border)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutForm"
        Me.MovePanel.ResumeLayout(False)
        CType(Me.CloseAboutForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Border.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MovePanel As Panel
    Friend WithEvents CloseAboutForm As PictureBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents AppInfo As Label
    Friend WithEvents ProjectManager As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AboutName As Label
    Friend WithEvents Border As Panel
    Friend WithEvents theTeam As Label
End Class
