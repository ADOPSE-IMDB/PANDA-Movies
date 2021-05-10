<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.Favorite = New System.Windows.Forms.PictureBox()
        Me.Home = New System.Windows.Forms.PictureBox()
        Me.AppName = New System.Windows.Forms.PictureBox()
        Me.NameBtn = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.resultPanel = New System.Windows.Forms.Panel()
        Me.ResultInfo = New System.Windows.Forms.Label()
        Me.DropPanel = New System.Windows.Forms.Panel()
        Me.OpenProfile = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.Container = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.PictureBox()
        Me.AppLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TopPanel.SuspendLayout()
        CType(Me.Favorite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.resultPanel.SuspendLayout()
        Me.DropPanel.SuspendLayout()
        Me.MovePanel.SuspendLayout()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.Button1)
        Me.TopPanel.Controls.Add(Me.Favorite)
        Me.TopPanel.Controls.Add(Me.Home)
        Me.TopPanel.Controls.Add(Me.AppName)
        Me.TopPanel.Controls.Add(Me.NameBtn)
        Me.TopPanel.Controls.Add(Me.Search)
        Me.TopPanel.Controls.Add(Me.SearchBox)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 24)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 36)
        Me.TopPanel.TabIndex = 0
        '
        'Favorite
        '
        Me.Favorite.BackColor = System.Drawing.Color.Transparent
        Me.Favorite.Image = CType(resources.GetObject("Favorite.Image"), System.Drawing.Image)
        Me.Favorite.Location = New System.Drawing.Point(1067, 10)
        Me.Favorite.Name = "Favorite"
        Me.Favorite.Size = New System.Drawing.Size(95, 26)
        Me.Favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Favorite.TabIndex = 4
        Me.Favorite.TabStop = False
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Transparent
        Me.Home.Image = CType(resources.GetObject("Home.Image"), System.Drawing.Image)
        Me.Home.Location = New System.Drawing.Point(124, 10)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(95, 26)
        Me.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Home.TabIndex = 3
        Me.Home.TabStop = False
        '
        'AppName
        '
        Me.AppName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppName.Image = CType(resources.GetObject("AppName.Image"), System.Drawing.Image)
        Me.AppName.Location = New System.Drawing.Point(0, 0)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(105, 37)
        Me.AppName.TabIndex = 3
        Me.AppName.TabStop = False
        '
        'NameBtn
        '
        Me.NameBtn.Location = New System.Drawing.Point(1168, 10)
        Me.NameBtn.Name = "NameBtn"
        Me.NameBtn.Size = New System.Drawing.Size(80, 23)
        Me.NameBtn.TabIndex = 2
        Me.NameBtn.Text = "UserName"
        Me.NameBtn.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Search.BackColor = System.Drawing.Color.Transparent
        Me.Search.BackgroundImage = CType(resources.GetObject("Search.BackgroundImage"), System.Drawing.Image)
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Search.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Search.FlatAppearance.BorderSize = 0
        Me.Search.Location = New System.Drawing.Point(730, 8)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(25, 25)
        Me.Search.TabIndex = 1
        Me.Search.UseVisualStyleBackColor = False
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SearchBox.Location = New System.Drawing.Point(515, 8)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(200, 23)
        Me.SearchBox.TabIndex = 0
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.DimGray
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.Controls.Add(Me.resultPanel)
        Me.MainPanel.Controls.Add(Me.DropPanel)
        Me.MainPanel.Controls.Add(Me.Container)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPanel.Location = New System.Drawing.Point(0, 61)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 718)
        Me.MainPanel.TabIndex = 1
        '
        'resultPanel
        '
        Me.resultPanel.BackColor = System.Drawing.Color.LightGray
        Me.resultPanel.Controls.Add(Me.ResultInfo)
        Me.resultPanel.Location = New System.Drawing.Point(515, 1)
        Me.resultPanel.Name = "resultPanel"
        Me.resultPanel.Size = New System.Drawing.Size(200, 131)
        Me.resultPanel.TabIndex = 2
        Me.resultPanel.Visible = False
        '
        'ResultInfo
        '
        Me.ResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.ResultInfo.Location = New System.Drawing.Point(0, 0)
        Me.ResultInfo.Name = "ResultInfo"
        Me.ResultInfo.Size = New System.Drawing.Size(200, 20)
        Me.ResultInfo.TabIndex = 0
        Me.ResultInfo.Text = "Label1"
        Me.ResultInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResultInfo.Visible = False
        '
        'DropPanel
        '
        Me.DropPanel.BackColor = System.Drawing.Color.Transparent
        Me.DropPanel.Controls.Add(Me.OpenProfile)
        Me.DropPanel.Controls.Add(Me.LogOut)
        Me.DropPanel.Location = New System.Drawing.Point(1171, -2)
        Me.DropPanel.MaximumSize = New System.Drawing.Size(74, 58)
        Me.DropPanel.MinimumSize = New System.Drawing.Size(74, 0)
        Me.DropPanel.Name = "DropPanel"
        Me.DropPanel.Size = New System.Drawing.Size(74, 58)
        Me.DropPanel.TabIndex = 0
        '
        'OpenProfile
        '
        Me.OpenProfile.Location = New System.Drawing.Point(0, 6)
        Me.OpenProfile.Name = "OpenProfile"
        Me.OpenProfile.Size = New System.Drawing.Size(74, 23)
        Me.OpenProfile.TabIndex = 1
        Me.OpenProfile.Text = "Profile"
        Me.OpenProfile.UseVisualStyleBackColor = True
        '
        'LogOut
        '
        Me.LogOut.Location = New System.Drawing.Point(0, 35)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(74, 23)
        Me.LogOut.TabIndex = 0
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = True
        '
        'Container
        '
        Me.Container.BackColor = System.Drawing.Color.Transparent
        Me.Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Container.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Container.Location = New System.Drawing.Point(340, 6)
        Me.Container.Name = "Container"
        Me.Container.Size = New System.Drawing.Size(600, 702)
        Me.Container.TabIndex = 1
        Me.Container.Visible = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 10
        '
        'MovePanel
        '
        Me.MovePanel.Controls.Add(Me.ExitBtn)
        Me.MovePanel.Controls.Add(Me.AppLabel)
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(1280, 24)
        Me.MovePanel.TabIndex = 2
        '
        'ExitBtn
        '
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.ExitBtn.Location = New System.Drawing.Point(1256, 0)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(24, 24)
        Me.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.TabStop = False
        '
        'AppLabel
        '
        Me.AppLabel.Location = New System.Drawing.Point(0, 0)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(105, 24)
        Me.AppLabel.TabIndex = 1
        Me.AppLabel.Text = "PANDA movies"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 779)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MovePanel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.Favorite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.resultPanel.ResumeLayout(False)
        Me.DropPanel.ResumeLayout(False)
        Me.MovePanel.ResumeLayout(False)
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents NameBtn As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents DropPanel As Panel
    Friend WithEvents OpenProfile As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Container As Panel
    Friend WithEvents Search As Button
    Friend WithEvents HomeInticator As Panel
    Friend WithEvents MovePanel As Panel
    Friend WithEvents resultPanel As Panel
    Friend WithEvents ResultInfo As Label
    Friend WithEvents AppName As PictureBox
    Friend WithEvents AppLabel As Label
    Friend WithEvents ExitBtn As PictureBox
    Friend WithEvents Home As PictureBox
    Friend WithEvents Favorite As PictureBox
    Friend WithEvents Button1 As Button
End Class
