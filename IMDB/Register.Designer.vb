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
        Me.LabelUN = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelPASS1 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LogInLink = New System.Windows.Forms.LinkLabel()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstname = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxLastname = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.LabelPASS2 = New System.Windows.Forms.Label()
        Me.LabelFN = New System.Windows.Forms.Label()
        Me.LabelLN = New System.Windows.Forms.Label()
        Me.LabelEM = New System.Windows.Forms.Label()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegisterTitle
        '
        Me.RegisterTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RegisterTitle.Location = New System.Drawing.Point(14, 20)
        Me.RegisterTitle.Name = "RegisterTitle"
        Me.RegisterTitle.Size = New System.Drawing.Size(586, 53)
        Me.RegisterTitle.TabIndex = 0
        Me.RegisterTitle.Text = "REGISTER"
        Me.RegisterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseApp
        '
        Me.CloseApp.Location = New System.Drawing.Point(566, 16)
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
        'LabelUN
        '
        Me.LabelUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelUN.Location = New System.Drawing.Point(33, 133)
        Me.LabelUN.Name = "LabelUN"
        Me.LabelUN.Size = New System.Drawing.Size(230, 31)
        Me.LabelUN.TabIndex = 0
        Me.LabelUN.Text = "Username"
        Me.LabelUN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxUsername.Location = New System.Drawing.Point(33, 168)
        Me.TextBoxUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(538, 24)
        Me.TextBoxUsername.TabIndex = 1
        Me.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPASS1
        '
        Me.LabelPASS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPASS1.Location = New System.Drawing.Point(30, 335)
        Me.LabelPASS1.Name = "LabelPASS1"
        Me.LabelPASS1.Size = New System.Drawing.Size(230, 32)
        Me.LabelPASS1.TabIndex = 2
        Me.LabelPASS1.Text = "Password"
        Me.LabelPASS1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxPassword.Location = New System.Drawing.Point(31, 371)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(229, 24)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogInLink
        '
        Me.LogInLink.ActiveLinkColor = System.Drawing.Color.BlueViolet
        Me.LogInLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogInLink.Location = New System.Drawing.Point(0, 485)
        Me.LogInLink.Name = "LogInLink"
        Me.LogInLink.Size = New System.Drawing.Size(613, 28)
        Me.LogInLink.TabIndex = 4
        Me.LogInLink.TabStop = True
        Me.LogInLink.Text = "Already have an account?"
        Me.LogInLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Location = New System.Drawing.Point(473, 436)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(229, 20)
        Me.ErrorLabel.TabIndex = 7
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxEmail.Location = New System.Drawing.Point(32, 276)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(538, 24)
        Me.TextBoxEmail.TabIndex = 8
        Me.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxFirstname
        '
        Me.TextBoxFirstname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxFirstname.Location = New System.Drawing.Point(32, 60)
        Me.TextBoxFirstname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxFirstname.Name = "TextBoxFirstname"
        Me.TextBoxFirstname.Size = New System.Drawing.Size(229, 24)
        Me.TextBoxFirstname.TabIndex = 9
        Me.TextBoxFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(341, 371)
        Me.TextBoxConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(229, 24)
        Me.TextBoxConfirmPassword.TabIndex = 10
        Me.TextBoxConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLastname
        '
        Me.TextBoxLastname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxLastname.Location = New System.Drawing.Point(342, 60)
        Me.TextBoxLastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxLastname.Name = "TextBoxLastname"
        Me.TextBoxLastname.Size = New System.Drawing.Size(229, 24)
        Me.TextBoxLastname.TabIndex = 11
        Me.TextBoxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ButtonRegister)
        Me.Panel3.Controls.Add(Me.LabelPASS2)
        Me.Panel3.Controls.Add(Me.LabelFN)
        Me.Panel3.Controls.Add(Me.LabelLN)
        Me.Panel3.Controls.Add(Me.LabelEM)
        Me.Panel3.Controls.Add(Me.TextBoxLastname)
        Me.Panel3.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Panel3.Controls.Add(Me.TextBoxFirstname)
        Me.Panel3.Controls.Add(Me.TextBoxEmail)
        Me.Panel3.Controls.Add(Me.ErrorLabel)
        Me.Panel3.Controls.Add(Me.LogInLink)
        Me.Panel3.Controls.Add(Me.TextBoxPassword)
        Me.Panel3.Controls.Add(Me.LabelPASS1)
        Me.Panel3.Controls.Add(Me.TextBoxUsername)
        Me.Panel3.Controls.Add(Me.LabelUN)
        Me.Panel3.Location = New System.Drawing.Point(1, 77)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(613, 521)
        Me.Panel3.TabIndex = 2
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRegister.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonRegister.ForeColor = System.Drawing.Color.Black
        Me.ButtonRegister.Location = New System.Drawing.Point(180, 422)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(229, 44)
        Me.ButtonRegister.TabIndex = 16
        Me.ButtonRegister.Text = "Sign Up"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'LabelPASS2
        '
        Me.LabelPASS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPASS2.Location = New System.Drawing.Point(342, 335)
        Me.LabelPASS2.Name = "LabelPASS2"
        Me.LabelPASS2.Size = New System.Drawing.Size(230, 32)
        Me.LabelPASS2.TabIndex = 15
        Me.LabelPASS2.Text = "Confirm Password"
        Me.LabelPASS2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelFN
        '
        Me.LabelFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFN.Location = New System.Drawing.Point(30, 25)
        Me.LabelFN.Name = "LabelFN"
        Me.LabelFN.Size = New System.Drawing.Size(230, 31)
        Me.LabelFN.TabIndex = 14
        Me.LabelFN.Text = "First Name"
        Me.LabelFN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelLN
        '
        Me.LabelLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelLN.Location = New System.Drawing.Point(342, 25)
        Me.LabelLN.Name = "LabelLN"
        Me.LabelLN.Size = New System.Drawing.Size(230, 31)
        Me.LabelLN.TabIndex = 13
        Me.LabelLN.Text = "Last Name"
        Me.LabelLN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelEM
        '
        Me.LabelEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelEM.Location = New System.Drawing.Point(33, 241)
        Me.LabelEM.Name = "LabelEM"
        Me.LabelEM.Size = New System.Drawing.Size(230, 31)
        Me.LabelEM.TabIndex = 12
        Me.LabelEM.Text = "Email"
        Me.LabelEM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseApp)
        Me.Controls.Add(Me.RegisterTitle)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
    Friend WithEvents TextBoxLastname As TextBox
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents TextBoxFirstname As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents LogInLink As LinkLabel
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPASS1 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelUN As Label
    Friend WithEvents LabelPASS2 As Label
    Friend WithEvents LabelFN As Label
    Friend WithEvents LabelLN As Label
    Friend WithEvents LabelEM As Label
    Friend WithEvents ButtonRegister As Button
End Class
