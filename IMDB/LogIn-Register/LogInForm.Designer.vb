<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CloseLogIn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.UsernameL = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.RememberMe = New System.Windows.Forms.CheckBox()
        Me.LabelGoToSignup = New System.Windows.Forms.LinkLabel()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.PasswordL = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.XError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.CloseLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.CloseLogIn)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Login)
        Me.Panel3.Controls.Add(Me.UsernameL)
        Me.Panel3.Controls.Add(Me.ErrorLabel)
        Me.Panel3.Controls.Add(Me.RememberMe)
        Me.Panel3.Controls.Add(Me.LabelGoToSignup)
        Me.Panel3.Controls.Add(Me.TextBoxPassword)
        Me.Panel3.Controls.Add(Me.PasswordL)
        Me.Panel3.Controls.Add(Me.TextBoxUsername)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 288)
        Me.Panel3.TabIndex = 2
        '
        'CloseLogIn
        '
        Me.CloseLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseLogIn.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.CloseLogIn.Location = New System.Drawing.Point(454, 0)
        Me.CloseLogIn.Name = "CloseLogIn"
        Me.CloseLogIn.Size = New System.Drawing.Size(30, 30)
        Me.CloseLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseLogIn.TabIndex = 15
        Me.CloseLogIn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(325, 204)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(75, 23)
        Me.Login.TabIndex = 13
        Me.Login.Text = "Log in"
        Me.Login.UseVisualStyleBackColor = True
        '
        'UsernameL
        '
        Me.UsernameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameL.Location = New System.Drawing.Point(325, 39)
        Me.UsernameL.Name = "UsernameL"
        Me.UsernameL.Size = New System.Drawing.Size(102, 20)
        Me.UsernameL.TabIndex = 12
        Me.UsernameL.Text = "Username"
        Me.UsernameL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Location = New System.Drawing.Point(50, 180)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(190, 15)
        Me.ErrorLabel.TabIndex = 7
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RememberMe
        '
        Me.RememberMe.Location = New System.Drawing.Point(374, 170)
        Me.RememberMe.Name = "RememberMe"
        Me.RememberMe.Size = New System.Drawing.Size(86, 19)
        Me.RememberMe.TabIndex = 6
        Me.RememberMe.Text = "Remember Me"
        Me.RememberMe.UseVisualStyleBackColor = True
        '
        'LabelGoToSignup
        '
        Me.LabelGoToSignup.ActiveLinkColor = System.Drawing.Color.BlueViolet
        Me.LabelGoToSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoToSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelGoToSignup.ForeColor = System.Drawing.Color.DimGray
        Me.LabelGoToSignup.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelGoToSignup.Location = New System.Drawing.Point(252, 232)
        Me.LabelGoToSignup.Name = "LabelGoToSignup"
        Me.LabelGoToSignup.Size = New System.Drawing.Size(231, 47)
        Me.LabelGoToSignup.TabIndex = 4
        Me.LabelGoToSignup.TabStop = True
        Me.LabelGoToSignup.Text = "Don't have an account? Create one!"
        Me.LabelGoToSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPassword.Location = New System.Drawing.Point(277, 143)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(183, 21)
        Me.TextBoxPassword.TabIndex = 2
        '
        'PasswordL
        '
        Me.PasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordL.Location = New System.Drawing.Point(325, 120)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(102, 20)
        Me.PasswordL.TabIndex = 2
        Me.PasswordL.Text = "Password"
        Me.PasswordL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxUsername.ForeColor = System.Drawing.Color.Black
        Me.TextBoxUsername.Location = New System.Drawing.Point(277, 62)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(183, 21)
        Me.TextBoxUsername.TabIndex = 1
        '
        'XError
        '
        Me.XError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.XError.ContainerControl = Me
        '
        'LogInForm
        '
        Me.AcceptButton = Me.Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.CloseLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PasswordL As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RememberMe As CheckBox
    Friend WithEvents LabelGoToSignup As LinkLabel
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents XError As ErrorProvider
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents UsernameL As Label
    Friend WithEvents Login As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CloseLogIn As PictureBox
End Class
