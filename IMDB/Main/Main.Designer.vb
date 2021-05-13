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
        Me.SearchBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CommonMoviesPanel = New System.Windows.Forms.Panel()
        Me.CommonMoviesBtn = New System.Windows.Forms.Label()
        Me.FavoriteInd = New System.Windows.Forms.Panel()
        Me.FavoriteBtn = New System.Windows.Forms.Label()
        Me.HomeBtnInd = New System.Windows.Forms.Panel()
        Me.HomeBtn = New System.Windows.Forms.Label()
        Me.AppName = New System.Windows.Forms.PictureBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.NamebtnPanel = New System.Windows.Forms.Panel()
        Me.NameBtn = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.FindComFavPanel = New System.Windows.Forms.Panel()
        Me.ShowComInfo = New System.Windows.Forms.Label()
        Me.CloseCommon = New System.Windows.Forms.PictureBox()
        Me.SearchCommonPanel = New System.Windows.Forms.Panel()
        Me.SearchCommon = New System.Windows.Forms.Label()
        Me.SearchUsername = New System.Windows.Forms.TextBox()
        Me.SearchUsernamePic = New System.Windows.Forms.PictureBox()
        Me.InfoLabel = New System.Windows.Forms.Label()
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
        CType(Me.SearchBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommonMoviesPanel.SuspendLayout()
        Me.FavoriteInd.SuspendLayout()
        Me.HomeBtnInd.SuspendLayout()
        CType(Me.AppName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NamebtnPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.FindComFavPanel.SuspendLayout()
        CType(Me.CloseCommon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchCommonPanel.SuspendLayout()
        CType(Me.SearchUsernamePic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopPanel.Controls.Add(Me.SearchBtn)
        Me.TopPanel.Controls.Add(Me.PictureBox1)
        Me.TopPanel.Controls.Add(Me.CommonMoviesPanel)
        Me.TopPanel.Controls.Add(Me.FavoriteInd)
        Me.TopPanel.Controls.Add(Me.HomeBtnInd)
        Me.TopPanel.Controls.Add(Me.AppName)
        Me.TopPanel.Controls.Add(Me.SearchBox)
        Me.TopPanel.Controls.Add(Me.NamebtnPanel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 24)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 35)
        Me.TopPanel.TabIndex = 0
        '
        'SearchBtn
        '
        Me.SearchBtn.BackgroundImage = CType(resources.GetObject("SearchBtn.BackgroundImage"), System.Drawing.Image)
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBtn.Location = New System.Drawing.Point(721, 4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(25, 25)
        Me.SearchBtn.TabIndex = 9
        Me.SearchBtn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 3)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CommonMoviesPanel
        '
        Me.CommonMoviesPanel.BackColor = System.Drawing.Color.Transparent
        Me.CommonMoviesPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.CommonMoviesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CommonMoviesPanel.Controls.Add(Me.CommonMoviesBtn)
        Me.CommonMoviesPanel.Location = New System.Drawing.Point(921, 5)
        Me.CommonMoviesPanel.Name = "CommonMoviesPanel"
        Me.CommonMoviesPanel.Size = New System.Drawing.Size(132, 26)
        Me.CommonMoviesPanel.TabIndex = 4
        '
        'CommonMoviesBtn
        '
        Me.CommonMoviesBtn.BackColor = System.Drawing.Color.Transparent
        Me.CommonMoviesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CommonMoviesBtn.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CommonMoviesBtn.ForeColor = System.Drawing.Color.White
        Me.CommonMoviesBtn.Location = New System.Drawing.Point(0, 0)
        Me.CommonMoviesBtn.Name = "CommonMoviesBtn"
        Me.CommonMoviesBtn.Size = New System.Drawing.Size(132, 28)
        Me.CommonMoviesBtn.TabIndex = 0
        Me.CommonMoviesBtn.Text = "Common Movies"
        Me.CommonMoviesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FavoriteInd
        '
        Me.FavoriteInd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavoriteInd.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteInd.BackgroundImage = CType(resources.GetObject("FavoriteInd.BackgroundImage"), System.Drawing.Image)
        Me.FavoriteInd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FavoriteInd.Controls.Add(Me.FavoriteBtn)
        Me.FavoriteInd.Location = New System.Drawing.Point(1059, 5)
        Me.FavoriteInd.Name = "FavoriteInd"
        Me.FavoriteInd.Size = New System.Drawing.Size(95, 26)
        Me.FavoriteInd.TabIndex = 7
        '
        'FavoriteBtn
        '
        Me.FavoriteBtn.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FavoriteBtn.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.HomeBtnInd.Location = New System.Drawing.Point(111, 5)
        Me.HomeBtnInd.Name = "HomeBtnInd"
        Me.HomeBtnInd.Size = New System.Drawing.Size(95, 26)
        Me.HomeBtnInd.TabIndex = 7
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.Transparent
        Me.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.ForeColor = System.Drawing.Color.White
        Me.HomeBtn.Location = New System.Drawing.Point(0, 0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(95, 27)
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
        'SearchBox
        '
        Me.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SearchBox.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchBox.Location = New System.Drawing.Point(515, 5)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(200, 25)
        Me.SearchBox.TabIndex = 0
        '
        'NamebtnPanel
        '
        Me.NamebtnPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NamebtnPanel.BackColor = System.Drawing.Color.Transparent
        Me.NamebtnPanel.BackgroundImage = CType(resources.GetObject("NamebtnPanel.BackgroundImage"), System.Drawing.Image)
        Me.NamebtnPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NamebtnPanel.Controls.Add(Me.NameBtn)
        Me.NamebtnPanel.Location = New System.Drawing.Point(1160, 5)
        Me.NamebtnPanel.Name = "NamebtnPanel"
        Me.NamebtnPanel.Size = New System.Drawing.Size(95, 26)
        Me.NamebtnPanel.TabIndex = 6
        '
        'NameBtn
        '
        Me.NameBtn.BackColor = System.Drawing.Color.Transparent
        Me.NameBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NameBtn.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.MainPanel.Controls.Add(Me.FindComFavPanel)
        Me.MainPanel.Controls.Add(Me.resultPanel)
        Me.MainPanel.Controls.Add(Me.DropPanel)
        Me.MainPanel.Controls.Add(Me.Container)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 59)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 720)
        Me.MainPanel.TabIndex = 1
        '
        'FindComFavPanel
        '
        Me.FindComFavPanel.BackgroundImage = CType(resources.GetObject("FindComFavPanel.BackgroundImage"), System.Drawing.Image)
        Me.FindComFavPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FindComFavPanel.Controls.Add(Me.ShowComInfo)
        Me.FindComFavPanel.Controls.Add(Me.CloseCommon)
        Me.FindComFavPanel.Controls.Add(Me.SearchCommonPanel)
        Me.FindComFavPanel.Controls.Add(Me.SearchUsername)
        Me.FindComFavPanel.Controls.Add(Me.SearchUsernamePic)
        Me.FindComFavPanel.Controls.Add(Me.InfoLabel)
        Me.FindComFavPanel.Location = New System.Drawing.Point(340, 186)
        Me.FindComFavPanel.Name = "FindComFavPanel"
        Me.FindComFavPanel.Size = New System.Drawing.Size(600, 141)
        Me.FindComFavPanel.TabIndex = 3
        Me.FindComFavPanel.Visible = False
        '
        'ShowComInfo
        '
        Me.ShowComInfo.ForeColor = System.Drawing.Color.Red
        Me.ShowComInfo.Location = New System.Drawing.Point(0, 36)
        Me.ShowComInfo.Name = "ShowComInfo"
        Me.ShowComInfo.Size = New System.Drawing.Size(597, 23)
        Me.ShowComInfo.TabIndex = 7
        Me.ShowComInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseCommon
        '
        Me.CloseCommon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseCommon.BackColor = System.Drawing.Color.Transparent
        Me.CloseCommon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseCommon.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.CloseCommon.Location = New System.Drawing.Point(574, 3)
        Me.CloseCommon.Name = "CloseCommon"
        Me.CloseCommon.Size = New System.Drawing.Size(23, 23)
        Me.CloseCommon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseCommon.TabIndex = 6
        Me.CloseCommon.TabStop = False
        '
        'SearchCommonPanel
        '
        Me.SearchCommonPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.SearchCommonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchCommonPanel.Controls.Add(Me.SearchCommon)
        Me.SearchCommonPanel.Location = New System.Drawing.Point(391, 63)
        Me.SearchCommonPanel.Name = "SearchCommonPanel"
        Me.SearchCommonPanel.Size = New System.Drawing.Size(99, 34)
        Me.SearchCommonPanel.TabIndex = 5
        '
        'SearchCommon
        '
        Me.SearchCommon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchCommon.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchCommon.ForeColor = System.Drawing.Color.White
        Me.SearchCommon.Location = New System.Drawing.Point(0, 0)
        Me.SearchCommon.Name = "SearchCommon"
        Me.SearchCommon.Size = New System.Drawing.Size(100, 34)
        Me.SearchCommon.TabIndex = 4
        Me.SearchCommon.Text = "Search"
        Me.SearchCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchUsername
        '
        Me.SearchUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SearchUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchUsername.Location = New System.Drawing.Point(128, 72)
        Me.SearchUsername.Name = "SearchUsername"
        Me.SearchUsername.Size = New System.Drawing.Size(210, 16)
        Me.SearchUsername.TabIndex = 2
        Me.SearchUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SearchUsernamePic
        '
        Me.SearchUsernamePic.BackgroundImage = Global.IMDB.My.Resources.Resources.bgtxt
        Me.SearchUsernamePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchUsernamePic.Location = New System.Drawing.Point(112, 63)
        Me.SearchUsernamePic.Name = "SearchUsernamePic"
        Me.SearchUsernamePic.Size = New System.Drawing.Size(240, 34)
        Me.SearchUsernamePic.TabIndex = 1
        Me.SearchUsernamePic.TabStop = False
        '
        'InfoLabel
        '
        Me.InfoLabel.Font = New System.Drawing.Font("SimSun", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InfoLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.InfoLabel.Location = New System.Drawing.Point(0, 0)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(600, 42)
        Me.InfoLabel.TabIndex = 0
        Me.InfoLabel.Text = "Type a username to find common movies"
        Me.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resultPanel
        '
        Me.resultPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.resultPanel.BackColor = System.Drawing.Color.LightGray
        Me.resultPanel.Controls.Add(Me.ResultInfo)
        Me.resultPanel.Location = New System.Drawing.Point(515, 1)
        Me.resultPanel.Name = "resultPanel"
        Me.resultPanel.Size = New System.Drawing.Size(200, 30)
        Me.resultPanel.TabIndex = 2
        Me.resultPanel.Visible = False
        '
        'ResultInfo
        '
        Me.ResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.ResultInfo.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
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
        Me.DropPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.LogOut.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.OpenProfile.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.Container.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Container.BackColor = System.Drawing.Color.Transparent
        Me.Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Container.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Container.Location = New System.Drawing.Point(340, 6)
        Me.Container.Name = "Container"
        Me.Container.Size = New System.Drawing.Size(600, 698)
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
        Me.ExitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.AppLabel.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AppLabel.ForeColor = System.Drawing.Color.White
        Me.AppLabel.Location = New System.Drawing.Point(0, 0)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(127, 24)
        Me.AppLabel.TabIndex = 1
        Me.AppLabel.Text = "PANDA movies"
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 779)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MovePanel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.SearchBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommonMoviesPanel.ResumeLayout(False)
        Me.FavoriteInd.ResumeLayout(False)
        Me.HomeBtnInd.ResumeLayout(False)
        CType(Me.AppName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NamebtnPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.FindComFavPanel.ResumeLayout(False)
        Me.FindComFavPanel.PerformLayout()
        CType(Me.CloseCommon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchCommonPanel.ResumeLayout(False)
        CType(Me.SearchUsernamePic, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HomeInticator As Panel
    Friend WithEvents MovePanel As Panel
    Friend WithEvents resultPanel As Panel
    Friend WithEvents ResultInfo As Label
    Friend WithEvents AppName As PictureBox
    Friend WithEvents AppLabel As Label
    Friend WithEvents ExitBtn As PictureBox
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
    Friend WithEvents FindComFavPanel As Panel
    Friend WithEvents SearchUsername As TextBox
    Friend WithEvents SearchUsernamePic As PictureBox
    Friend WithEvents InfoLabel As Label
    Friend WithEvents SearchCommonPanel As Panel
    Friend WithEvents SearchCommon As Label
    Friend WithEvents CloseCommon As PictureBox
    Friend WithEvents ShowComInfo As Label
    Friend WithEvents CommonMoviesPanel As Panel
    Friend WithEvents CommonMoviesBtn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SearchBtn As PictureBox
End Class
