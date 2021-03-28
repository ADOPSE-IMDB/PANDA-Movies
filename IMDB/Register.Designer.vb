<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Me.RegisterTitle = New System.Windows.Forms.Label()
        Me.CloseApp = New System.Windows.Forms.Button()
        Me.XError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UsernameL = New System.Windows.Forms.Label()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.PasswordL = New System.Windows.Forms.Label()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.LogInLink = New System.Windows.Forms.LinkLabel()
        Me.SignUpB = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.FirstNameTB = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTB = New System.Windows.Forms.TextBox()
        Me.LastNameTB = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ConfirmPasswordLabel = New System.Windows.Forms.Label()
        Me.FirstNameL = New System.Windows.Forms.Label()
        Me.LastNameL = New System.Windows.Forms.Label()
        Me.EmailL = New System.Windows.Forms.Label()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegisterTitle
        '
        Me.RegisterTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RegisterTitle.Location = New System.Drawing.Point(12, 15)
        Me.RegisterTitle.Name = "RegisterTitle"
        Me.RegisterTitle.Size = New System.Drawing.Size(513, 50)
        Me.RegisterTitle.TabIndex = 0
        Me.RegisterTitle.Text = "REGISTER"
        Me.RegisterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseApp
        '
        Me.CloseApp.Location = New System.Drawing.Point(663, 9)
        Me.CloseApp.Name = "CloseApp"
        Me.CloseApp.Size = New System.Drawing.Size(30, 30)
        Me.CloseApp.TabIndex = 3
        Me.CloseApp.Text = "X"
        Me.CloseApp.UseVisualStyleBackColor = True
        '
        'XError
        '
        Me.XError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.XError.ContainerControl = Me
        '
        'UsernameL
        '
        Me.UsernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameL.Location = New System.Drawing.Point(27, 121)
        Me.UsernameL.Name = "UsernameL"
        Me.UsernameL.Size = New System.Drawing.Size(201, 23)
        Me.UsernameL.TabIndex = 0
        Me.UsernameL.Text = "Username"
        Me.UsernameL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UsernameTB
        '
        Me.UsernameTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsernameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameTB.Location = New System.Drawing.Point(27, 166)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(201, 21)
        Me.UsernameTB.TabIndex = 1
        Me.UsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordL
        '
        Me.PasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordL.Location = New System.Drawing.Point(27, 203)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(201, 24)
        Me.PasswordL.TabIndex = 2
        Me.PasswordL.Text = "Password"
        Me.PasswordL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PasswordTB
        '
        Me.PasswordTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTB.Location = New System.Drawing.Point(27, 244)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTB.Size = New System.Drawing.Size(201, 21)
        Me.PasswordTB.TabIndex = 3
        Me.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogInLink
        '
        Me.LogInLink.ActiveLinkColor = System.Drawing.Color.BlueViolet
        Me.LogInLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInLink.Location = New System.Drawing.Point(0, 351)
        Me.LogInLink.Name = "LogInLink"
        Me.LogInLink.Size = New System.Drawing.Size(536, 21)
        Me.LogInLink.TabIndex = 4
        Me.LogInLink.TabStop = True
        Me.LogInLink.Text = "Already have an account?"
        Me.LogInLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SignUpB
        '
        Me.SignUpB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SignUpB.Location = New System.Drawing.Point(207, 318)
        Me.SignUpB.Name = "SignUpB"
        Me.SignUpB.Size = New System.Drawing.Size(120, 30)
        Me.SignUpB.TabIndex = 5
        Me.SignUpB.Text = "Sign Up"
        Me.SignUpB.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Location = New System.Drawing.Point(414, 327)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(200, 15)
        Me.ErrorLabel.TabIndex = 7
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailTB
        '
        Me.EmailTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmailTB.Location = New System.Drawing.Point(298, 166)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(201, 21)
        Me.EmailTB.TabIndex = 8
        Me.EmailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FirstNameTB
        '
        Me.FirstNameTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FirstNameTB.Location = New System.Drawing.Point(27, 83)
        Me.FirstNameTB.Name = "FirstNameTB"
        Me.FirstNameTB.Size = New System.Drawing.Size(201, 21)
        Me.FirstNameTB.TabIndex = 9
        Me.FirstNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConfirmPasswordTB
        '
        Me.ConfirmPasswordTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfirmPasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPasswordTB.Location = New System.Drawing.Point(298, 244)
        Me.ConfirmPasswordTB.Name = "ConfirmPasswordTB"
        Me.ConfirmPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTB.Size = New System.Drawing.Size(201, 21)
        Me.ConfirmPasswordTB.TabIndex = 10
        Me.ConfirmPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LastNameTB
        '
        Me.LastNameTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LastNameTB.Location = New System.Drawing.Point(298, 83)
        Me.LastNameTB.Name = "LastNameTB"
        Me.LastNameTB.Size = New System.Drawing.Size(201, 21)
        Me.LastNameTB.TabIndex = 11
        Me.LastNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ConfirmPasswordLabel)
        Me.Panel3.Controls.Add(Me.FirstNameL)
        Me.Panel3.Controls.Add(Me.LastNameL)
        Me.Panel3.Controls.Add(Me.EmailL)
        Me.Panel3.Controls.Add(Me.LastNameTB)
        Me.Panel3.Controls.Add(Me.ConfirmPasswordTB)
        Me.Panel3.Controls.Add(Me.FirstNameTB)
        Me.Panel3.Controls.Add(Me.EmailTB)
        Me.Panel3.Controls.Add(Me.ErrorLabel)
        Me.Panel3.Controls.Add(Me.SignUpB)
        Me.Panel3.Controls.Add(Me.LogInLink)
        Me.Panel3.Controls.Add(Me.PasswordTB)
        Me.Panel3.Controls.Add(Me.PasswordL)
        Me.Panel3.Controls.Add(Me.UsernameTB)
        Me.Panel3.Controls.Add(Me.UsernameL)
        Me.Panel3.Location = New System.Drawing.Point(1, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 380)
        Me.Panel3.TabIndex = 2
        '
        'ConfirmPasswordLabel
        '
        Me.ConfirmPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(298, 203)
        Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(201, 24)
        Me.ConfirmPasswordLabel.TabIndex = 15
        Me.ConfirmPasswordLabel.Text = "Confirm Password"
        Me.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FirstNameL
        '
        Me.FirstNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FirstNameL.Location = New System.Drawing.Point(27, 40)
        Me.FirstNameL.Name = "FirstNameL"
        Me.FirstNameL.Size = New System.Drawing.Size(201, 23)
        Me.FirstNameL.TabIndex = 14
        Me.FirstNameL.Text = "First Name"
        Me.FirstNameL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LastNameL
        '
        Me.LastNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LastNameL.Location = New System.Drawing.Point(298, 40)
        Me.LastNameL.Name = "LastNameL"
        Me.LastNameL.Size = New System.Drawing.Size(201, 23)
        Me.LastNameL.TabIndex = 13
        Me.LastNameL.Text = "Last Name"
        Me.LastNameL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'EmailL
        '
        Me.EmailL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmailL.Location = New System.Drawing.Point(298, 121)
        Me.EmailL.Name = "EmailL"
        Me.EmailL.Size = New System.Drawing.Size(201, 23)
        Me.EmailL.TabIndex = 12
        Me.EmailL.Text = "Email"
        Me.EmailL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseApp)
        Me.Controls.Add(Me.RegisterTitle)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.XError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RegisterTitle As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CloseApp As Button
    Friend WithEvents XError As ErrorProvider
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LastNameTB As TextBox
    Friend WithEvents ConfirmPasswordTB As TextBox
    Friend WithEvents FirstNameTB As TextBox
    Friend WithEvents EmailTB As TextBox
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents SignUpB As Button
    Friend WithEvents LogInLink As LinkLabel
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents PasswordL As Label
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents UsernameL As Label
    Friend WithEvents ConfirmPasswordLabel As Label
    Friend WithEvents FirstNameL As Label
    Friend WithEvents LastNameL As Label
    Friend WithEvents EmailL As Label
End Class
