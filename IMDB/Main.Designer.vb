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
        Me.UsernameInticator = New System.Windows.Forms.Panel()
        Me.FavoriteInticator = New System.Windows.Forms.Panel()
        Me.NameBtn = New System.Windows.Forms.Button()
        Me.AppName = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        Me.FavoriteBtn = New System.Windows.Forms.Button()
        Me.HomeInticator = New System.Windows.Forms.Panel()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.DropPanel = New System.Windows.Forms.Panel()
        Me.OpenProfile = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.Container = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.TopPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.DropPanel.SuspendLayout()
        Me.MovePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.UsernameInticator)
        Me.TopPanel.Controls.Add(Me.FavoriteInticator)
        Me.TopPanel.Controls.Add(Me.NameBtn)
        Me.TopPanel.Controls.Add(Me.AppName)
        Me.TopPanel.Controls.Add(Me.Search)
        Me.TopPanel.Controls.Add(Me.FavoriteBtn)
        Me.TopPanel.Controls.Add(Me.HomeInticator)
        Me.TopPanel.Controls.Add(Me.SearchBox)
        Me.TopPanel.Controls.Add(Me.HomeButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 24)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 36)
        Me.TopPanel.TabIndex = 0
        '
        'UsernameInticator
        '
        Me.UsernameInticator.BackColor = System.Drawing.Color.Black
        Me.UsernameInticator.Location = New System.Drawing.Point(1168, 32)
        Me.UsernameInticator.Name = "UsernameInticator"
        Me.UsernameInticator.Size = New System.Drawing.Size(80, 5)
        Me.UsernameInticator.TabIndex = 5
        '
        'FavoriteInticator
        '
        Me.FavoriteInticator.BackColor = System.Drawing.Color.Black
        Me.FavoriteInticator.Location = New System.Drawing.Point(1082, 32)
        Me.FavoriteInticator.Name = "FavoriteInticator"
        Me.FavoriteInticator.Size = New System.Drawing.Size(80, 5)
        Me.FavoriteInticator.TabIndex = 4
        Me.FavoriteInticator.Visible = False
        '
        'NameBtn
        '
        Me.NameBtn.Location = New System.Drawing.Point(1168, 10)
        Me.NameBtn.Name = "NameBtn"
        Me.NameBtn.Size = New System.Drawing.Size(80, 23)
        Me.NameBtn.TabIndex = 2
        Me.NameBtn.Text = "Username"
        Me.NameBtn.UseVisualStyleBackColor = True
        '
        'AppName
        '
        Me.AppName.BackColor = System.Drawing.Color.White
        Me.AppName.Image = CType(resources.GetObject("AppName.Image"), System.Drawing.Image)
        Me.AppName.Location = New System.Drawing.Point(0, 0)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(107, 36)
        Me.AppName.TabIndex = 0
        Me.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'FavoriteBtn
        '
        Me.FavoriteBtn.Location = New System.Drawing.Point(1082, 10)
        Me.FavoriteBtn.Name = "FavoriteBtn"
        Me.FavoriteBtn.Size = New System.Drawing.Size(80, 23)
        Me.FavoriteBtn.TabIndex = 1
        Me.FavoriteBtn.Text = "Favorite"
        Me.FavoriteBtn.UseVisualStyleBackColor = True
        '
        'HomeInticator
        '
        Me.HomeInticator.BackColor = System.Drawing.Color.Black
        Me.HomeInticator.Location = New System.Drawing.Point(127, 32)
        Me.HomeInticator.Name = "HomeInticator"
        Me.HomeInticator.Size = New System.Drawing.Size(80, 5)
        Me.HomeInticator.TabIndex = 3
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SearchBox.Location = New System.Drawing.Point(515, 8)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(200, 23)
        Me.SearchBox.TabIndex = 0
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(127, 10)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(80, 23)
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.DimGray
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.Controls.Add(Me.DropPanel)
        Me.MainPanel.Controls.Add(Me.Container)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPanel.Location = New System.Drawing.Point(0, 60)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 720)
        Me.MainPanel.TabIndex = 1
        '
        'DropPanel
        '
        Me.DropPanel.BackColor = System.Drawing.Color.Transparent
        Me.DropPanel.Controls.Add(Me.OpenProfile)
        Me.DropPanel.Controls.Add(Me.LogOut)
        Me.DropPanel.Location = New System.Drawing.Point(1171, 0)
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
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(1280, 24)
        Me.MovePanel.TabIndex = 2
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(1205, 1)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Close"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MovePanel)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.DropPanel.ResumeLayout(False)
        Me.MovePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents FavoriteBtn As Button
    Friend WithEvents NameBtn As Button
    Friend WithEvents AppName As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents DropPanel As Panel
    Friend WithEvents OpenProfile As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Container As Panel
    Friend WithEvents Search As Button
    Friend WithEvents HomeInticator As Panel
    Friend WithEvents HomeButton As Button
    Friend WithEvents MovePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents UsernameInticator As Panel
    Friend WithEvents FavoriteInticator As Panel
    Friend WithEvents ExitBtn As Button
End Class
