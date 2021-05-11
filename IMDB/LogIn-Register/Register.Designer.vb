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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.RegisterTitle = New System.Windows.Forms.Label()
        Me.XError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LogInLink = New System.Windows.Forms.LinkLabel()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstname = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxLastname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ReturnBtn = New System.Windows.Forms.PictureBox()
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.BtnRegister = New System.Windows.Forms.PictureBox()
        Me.info = New System.Windows.Forms.Label()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MovePanel.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegisterTitle
        '
        Me.RegisterTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RegisterTitle.BackColor = System.Drawing.Color.Transparent
        Me.RegisterTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RegisterTitle.Location = New System.Drawing.Point(16, 32)
        Me.RegisterTitle.Name = "RegisterTitle"
        Me.RegisterTitle.Size = New System.Drawing.Size(504, 31)
        Me.RegisterTitle.TabIndex = 0
        Me.RegisterTitle.Text = "Welcome to PANDA movies"
        Me.RegisterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XError
        '
        Me.XError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.XError.ContainerControl = Me
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.AccessibleName = "Username"
        Me.TextBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxUsername.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxUsername.Location = New System.Drawing.Point(34, 312)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(471, 22)
        Me.TextBoxUsername.TabIndex = 4
        Me.TextBoxUsername.Text = "Username"
        Me.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.AccessibleName = "Password"
        Me.TextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxPassword.Location = New System.Drawing.Point(32, 464)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxPassword.TabIndex = 6
        Me.TextBoxPassword.Text = "Password"
        Me.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogInLink
        '
        Me.LogInLink.ActiveLinkColor = System.Drawing.Color.DarkOrange
        Me.LogInLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LogInLink.BackColor = System.Drawing.Color.Transparent
        Me.LogInLink.LinkColor = System.Drawing.Color.DarkOrange
        Me.LogInLink.Location = New System.Drawing.Point(178, 563)
        Me.LogInLink.Name = "LogInLink"
        Me.LogInLink.Size = New System.Drawing.Size(175, 21)
        Me.LogInLink.TabIndex = 8
        Me.LogInLink.TabStop = True
        Me.LogInLink.Text = "Already have an account?"
        Me.LogInLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LogInLink.VisitedLinkColor = System.Drawing.Color.DarkOrange
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.AccessibleName = "Email"
        Me.TextBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxEmail.Location = New System.Drawing.Point(33, 393)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(471, 22)
        Me.TextBoxEmail.TabIndex = 5
        Me.TextBoxEmail.Text = "Email"
        Me.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxFirstname
        '
        Me.TextBoxFirstname.AccessibleName = "Name"
        Me.TextBoxFirstname.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxFirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxFirstname.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxFirstname.Location = New System.Drawing.Point(33, 229)
        Me.TextBoxFirstname.Name = "TextBoxFirstname"
        Me.TextBoxFirstname.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxFirstname.TabIndex = 2
        Me.TextBoxFirstname.Text = "Name"
        Me.TextBoxFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.AccessibleName = "Confirm Password"
        Me.TextBoxConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxConfirmPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(303, 464)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxConfirmPassword.TabIndex = 7
        Me.TextBoxConfirmPassword.Text = "Confirm Password"
        Me.TextBoxConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLastname
        '
        Me.TextBoxLastname.AccessibleName = "Surname"
        Me.TextBoxLastname.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxLastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TextBoxLastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxLastname.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxLastname.Location = New System.Drawing.Point(303, 229)
        Me.TextBoxLastname.Name = "TextBoxLastname"
        Me.TextBoxLastname.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxLastname.TabIndex = 3
        Me.TextBoxLastname.Text = "Surname"
        Me.TextBoxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PictureBox1.Location = New System.Drawing.Point(15, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PictureBox2.Location = New System.Drawing.Point(285, 220)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(235, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PictureBox3.Location = New System.Drawing.Point(285, 455)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(235, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PictureBox4.Location = New System.Drawing.Point(15, 455)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(235, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PictureBox5.Location = New System.Drawing.Point(15, 303)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(505, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PictureBox6.Location = New System.Drawing.Point(15, 384)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(505, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ReturnBtn.BackColor = System.Drawing.Color.Transparent
        Me.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnBtn.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.ReturnBtn.Location = New System.Drawing.Point(505, 3)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(27, 27)
        Me.ReturnBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReturnBtn.TabIndex = 18
        Me.ReturnBtn.TabStop = False
        '
        'MovePanel
        '
        Me.MovePanel.BackColor = System.Drawing.Color.Transparent
        Me.MovePanel.Controls.Add(Me.ReturnBtn)
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(535, 30)
        Me.MovePanel.TabIndex = 19
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.IMDB.My.Resources.Resources.Panda_movies
        Me.PictureBox7.Location = New System.Drawing.Point(178, 68)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(165, 143)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'BtnRegister
        '
        Me.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.Image = CType(resources.GetObject("BtnRegister.Image"), System.Drawing.Image)
        Me.BtnRegister.Location = New System.Drawing.Point(178, 527)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(175, 35)
        Me.BtnRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnRegister.TabIndex = 21
        Me.BtnRegister.TabStop = False
        '
        'info
        '
        Me.info.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.info.ForeColor = System.Drawing.Color.DarkOrange
        Me.info.Location = New System.Drawing.Point(16, 501)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(504, 23)
        Me.info.TabIndex = 30
        Me.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.LogInLink
        Me.ClientSize = New System.Drawing.Size(535, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.TextBoxFirstname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RegisterTitle)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxLastname)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LogInLink)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.MovePanel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.XError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MovePanel.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegisterTitle As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents XError As ErrorProvider
    Friend WithEvents TextBoxLastname As TextBox
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents TextBoxFirstname As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LogInLink As LinkLabel
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ReturnBtn As PictureBox
    Friend WithEvents MovePanel As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents BtnRegister As PictureBox
    Friend WithEvents info As Label
End Class
