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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FavoriteInd = New System.Windows.Forms.Panel()
        Me.FavoriteBtn = New System.Windows.Forms.Label()
        Me.HomeBtnInd = New System.Windows.Forms.Panel()
        Me.HomeBtn = New System.Windows.Forms.Label()
        Me.AppName = New System.Windows.Forms.PictureBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.NamebtnPanel = New System.Windows.Forms.Panel()
        Me.NameBtn = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.resultPanel = New System.Windows.Forms.Panel()
        Me.ResultInfo = New System.Windows.Forms.Label()
        Me.DropPanel = New System.Windows.Forms.Panel()
        Me.LogOutPanel = New System.Windows.Forms.Panel()
        Me.LogOut = New System.Windows.Forms.Label()
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.OpenProfile = New System.Windows.Forms.Label()
        Me.Container = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.PictureBox()
        Me.AppLabel = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        Me.FavoriteInd.SuspendLayout()
        Me.HomeBtnInd.SuspendLayout()
        CType(Me.AppName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NamebtnPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.resultPanel.SuspendLayout()
        Me.DropPanel.SuspendLayout()
        Me.LogOutPanel.SuspendLayout()
        Me.ProfilePanel.SuspendLayout()
        Me.MovePanel.SuspendLayout()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.Button1)
        Me.TopPanel.Controls.Add(Me.FavoriteInd)
        Me.TopPanel.Controls.Add(Me.HomeBtnInd)
        Me.TopPanel.Controls.Add(Me.AppName)
        Me.TopPanel.Controls.Add(Me.Search)
        Me.TopPanel.Controls.Add(Me.SearchBox)
        Me.TopPanel.Controls.Add(Me.NamebtnPanel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 24)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 36)
        Me.TopPanel.TabIndex = 0
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
        'FavoriteInd
        '
        Me.FavoriteInd.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteInd.BackgroundImage = CType(resources.GetObject("FavoriteInd.BackgroundImage"), System.Drawing.Image)
        Me.FavoriteInd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FavoriteInd.Controls.Add(Me.FavoriteBtn)
        Me.FavoriteInd.Location = New System.Drawing.Point(1059, 10)
        Me.FavoriteInd.Name = "FavoriteInd"
        Me.FavoriteInd.Size = New System.Drawing.Size(95, 26)
        Me.FavoriteInd.TabIndex = 7
        '
        'FavoriteBtn
        '
        Me.FavoriteBtn.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FavoriteBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FavoriteBtn.ForeColor = System.Drawing.Color.White
        Me.FavoriteBtn.Location = New System.Drawing.Point(0, 0)
        Me.FavoriteBtn.Name = "FavoriteBtn"
        Me.FavoriteBtn.Size = New System.Drawing.Size(95, 28)
        Me.FavoriteBtn.TabIndex = 0
        Me.FavoriteBtn.Text = "Favorite"
        Me.FavoriteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomeBtnInd
        '
        Me.HomeBtnInd.BackColor = System.Drawing.Color.Transparent
        Me.HomeBtnInd.BackgroundImage = CType(resources.GetObject("HomeBtnInd.BackgroundImage"), System.Drawing.Image)
        Me.HomeBtnInd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeBtnInd.Controls.Add(Me.HomeBtn)
        Me.HomeBtnInd.Location = New System.Drawing.Point(111, 10)
        Me.HomeBtnInd.Name = "HomeBtnInd"
        Me.HomeBtnInd.Size = New System.Drawing.Size(95, 26)
        Me.HomeBtnInd.TabIndex = 7
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.Transparent
        Me.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.ForeColor = System.Drawing.Color.White
        Me.HomeBtn.Location = New System.Drawing.Point(0, -1)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(95, 28)
        Me.HomeBtn.TabIndex = 0
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'NamebtnPanel
        '
        Me.NamebtnPanel.BackColor = System.Drawing.Color.Transparent
        Me.NamebtnPanel.BackgroundImage = CType(resources.GetObject("NamebtnPanel.BackgroundImage"), System.Drawing.Image)
        Me.NamebtnPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NamebtnPanel.Controls.Add(Me.NameBtn)
        Me.NamebtnPanel.Location = New System.Drawing.Point(1160, 10)
        Me.NamebtnPanel.Name = "NamebtnPanel"
        Me.NamebtnPanel.Size = New System.Drawing.Size(95, 26)
        Me.NamebtnPanel.TabIndex = 6
        '
        'NameBtn
        '
        Me.NameBtn.BackColor = System.Drawing.Color.Transparent
        Me.NameBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NameBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameBtn.ForeColor = System.Drawing.Color.White
        Me.NameBtn.Location = New System.Drawing.Point(0, 0)
        Me.NameBtn.Name = "NameBtn"
        Me.NameBtn.Size = New System.Drawing.Size(95, 28)
        Me.NameBtn.TabIndex = 0
        Me.NameBtn.Text = "LogedUser"
        Me.NameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
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
        Me.ResultInfo.ForeColor = System.Drawing.Color.White
        Me.ResultInfo.Image = Global.IMDB.My.Resources.Resources.Indicator
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
        Me.DropPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.DropPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DropPanel.Controls.Add(Me.LogOutPanel)
        Me.DropPanel.Controls.Add(Me.ProfilePanel)
        Me.DropPanel.Location = New System.Drawing.Point(1171, -1)
        Me.DropPanel.MaximumSize = New System.Drawing.Size(74, 65)
        Me.DropPanel.MinimumSize = New System.Drawing.Size(74, 0)
        Me.DropPanel.Name = "DropPanel"
        Me.DropPanel.Size = New System.Drawing.Size(74, 65)
        Me.DropPanel.TabIndex = 0
        '
        'LogOutPanel
        '
        Me.LogOutPanel.BackColor = System.Drawing.Color.Transparent
        Me.LogOutPanel.BackgroundImage = CType(resources.GetObject("LogOutPanel.BackgroundImage"), System.Drawing.Image)
        Me.LogOutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogOutPanel.Controls.Add(Me.LogOut)
        Me.LogOutPanel.Location = New System.Drawing.Point(0, 39)
        Me.LogOutPanel.Name = "LogOutPanel"
        Me.LogOutPanel.Size = New System.Drawing.Size(74, 24)
        Me.LogOutPanel.TabIndex = 9
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.Transparent
        Me.LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOut.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogOut.ForeColor = System.Drawing.Color.White
        Me.LogOut.Location = New System.Drawing.Point(0, 0)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(74, 24)
        Me.LogOut.TabIndex = 1
        Me.LogOut.Text = "Log Out"
        Me.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BackColor = System.Drawing.Color.Transparent
        Me.ProfilePanel.BackgroundImage = CType(resources.GetObject("ProfilePanel.BackgroundImage"), System.Drawing.Image)
        Me.ProfilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProfilePanel.Controls.Add(Me.OpenProfile)
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 8)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(74, 24)
        Me.ProfilePanel.TabIndex = 8
        '
        'OpenProfile
        '
        Me.OpenProfile.BackColor = System.Drawing.Color.Transparent
        Me.OpenProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpenProfile.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OpenProfile.ForeColor = System.Drawing.Color.White
        Me.OpenProfile.Location = New System.Drawing.Point(0, 0)
        Me.OpenProfile.Name = "OpenProfile"
        Me.OpenProfile.Size = New System.Drawing.Size(74, 24)
        Me.OpenProfile.TabIndex = 1
        Me.OpenProfile.Text = "Profile"
        Me.OpenProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.MovePanel.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.MovePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.ExitBtn.Location = New System.Drawing.Point(1256, 1)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(23, 23)
        Me.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.TabStop = False
        '
        'AppLabel
        '
        Me.AppLabel.BackColor = System.Drawing.Color.Transparent
        Me.AppLabel.ForeColor = System.Drawing.Color.White
        Me.AppLabel.Location = New System.Drawing.Point(0, 0)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(105, 24)
        Me.AppLabel.TabIndex = 1
        Me.AppLabel.Text = "PANDA movies"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 779)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MovePanel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.FavoriteInd.ResumeLayout(False)
        Me.HomeBtnInd.ResumeLayout(False)
        CType(Me.AppName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NamebtnPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.resultPanel.ResumeLayout(False)
        Me.DropPanel.ResumeLayout(False)
        Me.LogOutPanel.ResumeLayout(False)
        Me.ProfilePanel.ResumeLayout(False)
        Me.MovePanel.ResumeLayout(False)
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents DropPanel As Panel
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
    Friend WithEvents Button1 As Button
    Friend WithEvents NamebtnPanel As Panel
    Friend WithEvents NameBtn As Label
    Friend WithEvents HomeBtnInd As Panel
    Friend WithEvents HomeBtn As Label
    Friend WithEvents FavoriteInd As Panel
    Friend WithEvents FavoriteBtn As Label
    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents OpenProfile As Label
    Friend WithEvents LogOutPanel As Panel
    Friend WithEvents LogOut As Label
End Class
