<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.LogInTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.RememberMe = New System.Windows.Forms.CheckBox()
        Me.LogInB = New System.Windows.Forms.Button()
        Me.RegisterLink = New System.Windows.Forms.LinkLabel()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.PasswordL = New System.Windows.Forms.Label()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.UsernameL = New System.Windows.Forms.Label()
        Me.CloseApp = New System.Windows.Forms.Button()
        Me.XError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogInTitle
        '
        Me.LogInTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogInTitle.Image = CType(resources.GetObject("LogInTitle.Image"), System.Drawing.Image)
        Me.LogInTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogInTitle.Location = New System.Drawing.Point(0, 12)
        Me.LogInTitle.Name = "LogInTitle"
        Me.LogInTitle.Size = New System.Drawing.Size(343, 67)
        Me.LogInTitle.TabIndex = 0
        Me.LogInTitle.Text = "IMDB?"
        Me.LogInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.ErrorLabel)
        Me.Panel3.Controls.Add(Me.RememberMe)
        Me.Panel3.Controls.Add(Me.LogInB)
        Me.Panel3.Controls.Add(Me.RegisterLink)
        Me.Panel3.Controls.Add(Me.PasswordTB)
        Me.Panel3.Controls.Add(Me.PasswordL)
        Me.Panel3.Controls.Add(Me.UsernameTB)
        Me.Panel3.Controls.Add(Me.UsernameL)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 93)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(343, 307)
        Me.Panel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Check Connection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Location = New System.Drawing.Point(57, 240)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(229, 20)
        Me.ErrorLabel.TabIndex = 7
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RememberMe
        '
        Me.RememberMe.Location = New System.Drawing.Point(112, 160)
        Me.RememberMe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RememberMe.Name = "RememberMe"
        Me.RememberMe.Size = New System.Drawing.Size(119, 25)
        Me.RememberMe.TabIndex = 6
        Me.RememberMe.Text = "Remember Me"
        Me.RememberMe.UseVisualStyleBackColor = True
        '
        'LogInB
        '
        Me.LogInB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogInB.Location = New System.Drawing.Point(103, 200)
        Me.LogInB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogInB.Name = "LogInB"
        Me.LogInB.Size = New System.Drawing.Size(137, 40)
        Me.LogInB.TabIndex = 5
        Me.LogInB.Text = "Log In"
        Me.LogInB.UseVisualStyleBackColor = True
        '
        'RegisterLink
        '
        Me.RegisterLink.ActiveLinkColor = System.Drawing.Color.BlueViolet
        Me.RegisterLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RegisterLink.Location = New System.Drawing.Point(86, 277)
        Me.RegisterLink.Name = "RegisterLink"
        Me.RegisterLink.Size = New System.Drawing.Size(171, 20)
        Me.RegisterLink.TabIndex = 4
        Me.RegisterLink.TabStop = True
        Me.RegisterLink.Text = "Create your IMDB account"
        Me.RegisterLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordTB
        '
        Me.PasswordTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTB.Location = New System.Drawing.Point(57, 115)
        Me.PasswordTB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTB.Size = New System.Drawing.Size(228, 24)
        Me.PasswordTB.TabIndex = 3
        Me.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordL
        '
        Me.PasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordL.Location = New System.Drawing.Point(0, 68)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(343, 43)
        Me.PasswordL.TabIndex = 2
        Me.PasswordL.Text = "Password"
        Me.PasswordL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UsernameTB
        '
        Me.UsernameTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsernameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameTB.Location = New System.Drawing.Point(57, 35)
        Me.UsernameTB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(228, 24)
        Me.UsernameTB.TabIndex = 1
        Me.UsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsernameL
        '
        Me.UsernameL.Dock = System.Windows.Forms.DockStyle.Top
        Me.UsernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameL.Location = New System.Drawing.Point(0, 0)
        Me.UsernameL.Name = "UsernameL"
        Me.UsernameL.Size = New System.Drawing.Size(343, 31)
        Me.UsernameL.TabIndex = 0
        Me.UsernameL.Text = "Username"
        Me.UsernameL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CloseApp
        '
        Me.CloseApp.Location = New System.Drawing.Point(295, 12)
        Me.CloseApp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CloseApp.Name = "CloseApp"
        Me.CloseApp.Size = New System.Drawing.Size(34, 40)
        Me.CloseApp.TabIndex = 3
        Me.CloseApp.Text = "X"
        Me.CloseApp.UseVisualStyleBackColor = True
        '
        'XError
        '
        Me.XError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.XError.ContainerControl = Me
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Location = New System.Drawing.Point(190, 247)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Create Table"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogIn
        '
        Me.AcceptButton = Me.LogInB
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseApp)
        Me.Controls.Add(Me.LogInTitle)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogInTitle As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UsernameL As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PasswordL As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CloseApp As Button
    Friend WithEvents RememberMe As CheckBox
    Friend WithEvents LogInB As Button
    Friend WithEvents RegisterLink As LinkLabel
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents XError As ErrorProvider
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
