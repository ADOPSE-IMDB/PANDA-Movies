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
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.SearchPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnPanel = New System.Windows.Forms.Panel()
        Me.ListBtn = New System.Windows.Forms.Button()
        Me.NameBtn = New System.Windows.Forms.Button()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.AppName = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.DropPanel = New System.Windows.Forms.Panel()
        Me.OpenProfile = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        Me.SearchPanel.SuspendLayout()
        Me.BtnPanel.SuspendLayout()
        Me.HomePanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.DropPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.SearchPanel)
        Me.TopPanel.Controls.Add(Me.BtnPanel)
        Me.TopPanel.Controls.Add(Me.HomePanel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 36)
        Me.TopPanel.TabIndex = 0
        '
        'SearchPanel
        '
        Me.SearchPanel.Controls.Add(Me.TextBox1)
        Me.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchPanel.Location = New System.Drawing.Point(56, 0)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(1024, 36)
        Me.SearchPanel.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(451, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 23)
        Me.TextBox1.TabIndex = 0
        '
        'BtnPanel
        '
        Me.BtnPanel.Controls.Add(Me.ListBtn)
        Me.BtnPanel.Controls.Add(Me.NameBtn)
        Me.BtnPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPanel.Location = New System.Drawing.Point(1080, 0)
        Me.BtnPanel.Name = "BtnPanel"
        Me.BtnPanel.Size = New System.Drawing.Size(200, 36)
        Me.BtnPanel.TabIndex = 1
        '
        'ListBtn
        '
        Me.ListBtn.Location = New System.Drawing.Point(15, 10)
        Me.ListBtn.Name = "ListBtn"
        Me.ListBtn.Size = New System.Drawing.Size(80, 23)
        Me.ListBtn.TabIndex = 1
        Me.ListBtn.Text = "List"
        Me.ListBtn.UseVisualStyleBackColor = True
        '
        'NameBtn
        '
        Me.NameBtn.Location = New System.Drawing.Point(105, 10)
        Me.NameBtn.Name = "NameBtn"
        Me.NameBtn.Size = New System.Drawing.Size(80, 23)
        Me.NameBtn.TabIndex = 2
        Me.NameBtn.UseVisualStyleBackColor = True
        '
        'HomePanel
        '
        Me.HomePanel.Controls.Add(Me.AppName)
        Me.HomePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.HomePanel.Location = New System.Drawing.Point(0, 0)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(56, 36)
        Me.HomePanel.TabIndex = 1
        '
        'AppName
        '
        Me.AppName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppName.Location = New System.Drawing.Point(0, 0)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(56, 36)
        Me.AppName.TabIndex = 0
        Me.AppName.Text = "IMDB"
        Me.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.DropPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 36)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 720)
        Me.MainPanel.TabIndex = 1
        '
        'DropPanel
        '
        Me.DropPanel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DropPanel.Controls.Add(Me.OpenProfile)
        Me.DropPanel.Controls.Add(Me.LogOut)
        Me.DropPanel.Location = New System.Drawing.Point(1174, 0)
        Me.DropPanel.MaximumSize = New System.Drawing.Size(75, 60)
        Me.DropPanel.MinimumSize = New System.Drawing.Size(75, 0)
        Me.DropPanel.Name = "DropPanel"
        Me.DropPanel.Size = New System.Drawing.Size(75, 0)
        Me.DropPanel.TabIndex = 0
        '
        'OpenProfile
        '
        Me.OpenProfile.Location = New System.Drawing.Point(0, 6)
        Me.OpenProfile.Name = "OpenProfile"
        Me.OpenProfile.Size = New System.Drawing.Size(75, 23)
        Me.OpenProfile.TabIndex = 1
        Me.OpenProfile.Text = "Profile"
        Me.OpenProfile.UseVisualStyleBackColor = True
        '
        'LogOut
        '
        Me.LogOut.Location = New System.Drawing.Point(0, 35)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(75, 23)
        Me.LogOut.TabIndex = 0
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 10
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 756)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.TopPanel.ResumeLayout(False)
        Me.SearchPanel.ResumeLayout(False)
        Me.SearchPanel.PerformLayout()
        Me.BtnPanel.ResumeLayout(False)
        Me.HomePanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.DropPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents SearchPanel As Panel
    Friend WithEvents BtnPanel As Panel
    Friend WithEvents ListBtn As Button
    Friend WithEvents NameBtn As Button
    Friend WithEvents HomePanel As Panel
    Friend WithEvents AppName As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DropPanel As Panel
    Friend WithEvents OpenProfile As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents Timer As Timer
End Class
