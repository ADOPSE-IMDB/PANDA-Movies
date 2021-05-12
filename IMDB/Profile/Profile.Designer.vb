<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.Na = New System.Windows.Forms.Label()
        Me.Su = New System.Windows.Forms.Label()
        Me.EL = New System.Windows.Forms.Label()
        Me.Psw = New System.Windows.Forms.Label()
        Me.NameL = New System.Windows.Forms.Label()
        Me.Surname = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.SurnameTB = New System.Windows.Forms.TextBox()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.NewPasswordTB = New System.Windows.Forms.TextBox()
        Me.ConfirmTB = New System.Windows.Forms.TextBox()
        Me.CnP = New System.Windows.Forms.Label()
        Me.XError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PbN = New System.Windows.Forms.PictureBox()
        Me.PbS = New System.Windows.Forms.PictureBox()
        Me.PbE = New System.Windows.Forms.PictureBox()
        Me.PbP = New System.Windows.Forms.PictureBox()
        Me.PbCP = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ChangeAvatarPanel = New System.Windows.Forms.Panel()
        Me.PanelChangeBtn = New System.Windows.Forms.Panel()
        Me.ChangeBtn = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Savebtn = New System.Windows.Forms.Label()
        Me.Editbtn = New System.Windows.Forms.Label()
        Me.SaveInfo = New System.Windows.Forms.Label()
        Me.EmailInfo = New System.Windows.Forms.Label()
        Me.PassInfo = New System.Windows.Forms.Label()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChangeBtn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProfilePic
        '
        Me.ProfilePic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProfilePic.Location = New System.Drawing.Point(565, 26)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(150, 150)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePic.TabIndex = 3
        Me.ProfilePic.TabStop = False
        '
        'Na
        '
        Me.Na.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Na.AutoSize = True
        Me.Na.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Na.Location = New System.Drawing.Point(463, 338)
        Me.Na.Name = "Na"
        Me.Na.Size = New System.Drawing.Size(72, 25)
        Me.Na.TabIndex = 4
        Me.Na.Text = "Name :"
        '
        'Su
        '
        Me.Su.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Su.AutoSize = True
        Me.Su.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Su.Location = New System.Drawing.Point(463, 395)
        Me.Su.Name = "Su"
        Me.Su.Size = New System.Drawing.Size(97, 25)
        Me.Su.TabIndex = 5
        Me.Su.Text = "Surname :"
        '
        'EL
        '
        Me.EL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EL.AutoSize = True
        Me.EL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EL.Location = New System.Drawing.Point(463, 455)
        Me.EL.Name = "EL"
        Me.EL.Size = New System.Drawing.Size(75, 25)
        Me.EL.TabIndex = 6
        Me.EL.Text = "E-mail :"
        '
        'Psw
        '
        Me.Psw.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Psw.AutoSize = True
        Me.Psw.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Psw.Location = New System.Drawing.Point(463, 512)
        Me.Psw.Name = "Psw"
        Me.Psw.Size = New System.Drawing.Size(140, 25)
        Me.Psw.TabIndex = 7
        Me.Psw.Text = "New Password:"
        Me.Psw.Visible = False
        '
        'NameL
        '
        Me.NameL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameL.AutoSize = True
        Me.NameL.Location = New System.Drawing.Point(733, 341)
        Me.NameL.Name = "NameL"
        Me.NameL.Size = New System.Drawing.Size(41, 15)
        Me.NameL.TabIndex = 9
        Me.NameL.Text = "Label1"
        '
        'Surname
        '
        Me.Surname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Surname.AutoSize = True
        Me.Surname.Location = New System.Drawing.Point(733, 402)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(41, 15)
        Me.Surname.TabIndex = 10
        Me.Surname.Text = "Label2"
        '
        'Email
        '
        Me.Email.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(733, 458)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(41, 15)
        Me.Email.TabIndex = 11
        Me.Email.Text = "Label3"
        '
        'NameTB
        '
        Me.NameTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameTB.ForeColor = System.Drawing.Color.DarkGray
        Me.NameTB.Location = New System.Drawing.Point(696, 341)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 22)
        Me.NameTB.TabIndex = 14
        Me.NameTB.Visible = False
        '
        'SurnameTB
        '
        Me.SurnameTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SurnameTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SurnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SurnameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SurnameTB.ForeColor = System.Drawing.Color.DarkGray
        Me.SurnameTB.Location = New System.Drawing.Point(696, 398)
        Me.SurnameTB.Name = "SurnameTB"
        Me.SurnameTB.Size = New System.Drawing.Size(100, 22)
        Me.SurnameTB.TabIndex = 15
        Me.SurnameTB.Visible = False
        '
        'EmailTB
        '
        Me.EmailTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmailTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailTB.ForeColor = System.Drawing.Color.DarkGray
        Me.EmailTB.Location = New System.Drawing.Point(696, 458)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(100, 22)
        Me.EmailTB.TabIndex = 16
        Me.EmailTB.Visible = False
        '
        'NewPasswordTB
        '
        Me.NewPasswordTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewPasswordTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.NewPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewPasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewPasswordTB.ForeColor = System.Drawing.Color.DarkGray
        Me.NewPasswordTB.Location = New System.Drawing.Point(696, 515)
        Me.NewPasswordTB.Name = "NewPasswordTB"
        Me.NewPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTB.Size = New System.Drawing.Size(100, 22)
        Me.NewPasswordTB.TabIndex = 17
        Me.NewPasswordTB.Visible = False
        '
        'ConfirmTB
        '
        Me.ConfirmTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ConfirmTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ConfirmTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConfirmTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmTB.ForeColor = System.Drawing.Color.DarkGray
        Me.ConfirmTB.Location = New System.Drawing.Point(696, 566)
        Me.ConfirmTB.Name = "ConfirmTB"
        Me.ConfirmTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmTB.Size = New System.Drawing.Size(100, 22)
        Me.ConfirmTB.TabIndex = 18
        Me.ConfirmTB.Visible = False
        '
        'CnP
        '
        Me.CnP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CnP.AutoSize = True
        Me.CnP.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CnP.Location = New System.Drawing.Point(463, 563)
        Me.CnP.Name = "CnP"
        Me.CnP.Size = New System.Drawing.Size(175, 25)
        Me.CnP.TabIndex = 19
        Me.CnP.Text = "Confirm Password :"
        Me.CnP.Visible = False
        '
        'XError
        '
        Me.XError.ContainerControl = Me
        '
        'PbN
        '
        Me.PbN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbN.BackColor = System.Drawing.Color.Transparent
        Me.PbN.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbN.Location = New System.Drawing.Point(676, 335)
        Me.PbN.Name = "PbN"
        Me.PbN.Size = New System.Drawing.Size(141, 33)
        Me.PbN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbN.TabIndex = 20
        Me.PbN.TabStop = False
        Me.PbN.Visible = False
        '
        'PbS
        '
        Me.PbS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbS.BackColor = System.Drawing.Color.Transparent
        Me.PbS.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbS.Location = New System.Drawing.Point(676, 392)
        Me.PbS.Name = "PbS"
        Me.PbS.Size = New System.Drawing.Size(141, 33)
        Me.PbS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbS.TabIndex = 21
        Me.PbS.TabStop = False
        Me.PbS.Visible = False
        '
        'PbE
        '
        Me.PbE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbE.BackColor = System.Drawing.Color.Transparent
        Me.PbE.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbE.Location = New System.Drawing.Point(676, 452)
        Me.PbE.Name = "PbE"
        Me.PbE.Size = New System.Drawing.Size(141, 33)
        Me.PbE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbE.TabIndex = 22
        Me.PbE.TabStop = False
        Me.PbE.Visible = False
        '
        'PbP
        '
        Me.PbP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbP.BackColor = System.Drawing.Color.Transparent
        Me.PbP.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbP.Location = New System.Drawing.Point(676, 509)
        Me.PbP.Name = "PbP"
        Me.PbP.Size = New System.Drawing.Size(141, 33)
        Me.PbP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbP.TabIndex = 23
        Me.PbP.TabStop = False
        Me.PbP.Visible = False
        '
        'PbCP
        '
        Me.PbCP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbCP.BackColor = System.Drawing.Color.Transparent
        Me.PbCP.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbCP.Location = New System.Drawing.Point(676, 560)
        Me.PbCP.Name = "PbCP"
        Me.PbCP.Size = New System.Drawing.Size(141, 33)
        Me.PbCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbCP.TabIndex = 24
        Me.PbCP.TabStop = False
        Me.PbCP.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ChangeAvatarPanel
        '
        Me.ChangeAvatarPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChangeAvatarPanel.AutoScroll = True
        Me.ChangeAvatarPanel.BackColor = System.Drawing.Color.White
        Me.ChangeAvatarPanel.Location = New System.Drawing.Point(469, 229)
        Me.ChangeAvatarPanel.MaximumSize = New System.Drawing.Size(340, 355)
        Me.ChangeAvatarPanel.Name = "ChangeAvatarPanel"
        Me.ChangeAvatarPanel.Size = New System.Drawing.Size(340, 50)
        Me.ChangeAvatarPanel.TabIndex = 25
        Me.ChangeAvatarPanel.Visible = False
        '
        'PanelChangeBtn
        '
        Me.PanelChangeBtn.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.PanelChangeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelChangeBtn.Controls.Add(Me.ChangeBtn)
        Me.PanelChangeBtn.Location = New System.Drawing.Point(565, 191)
        Me.PanelChangeBtn.Name = "PanelChangeBtn"
        Me.PanelChangeBtn.Size = New System.Drawing.Size(150, 32)
        Me.PanelChangeBtn.TabIndex = 26
        '
        'ChangeBtn
        '
        Me.ChangeBtn.BackColor = System.Drawing.Color.Transparent
        Me.ChangeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeBtn.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChangeBtn.ForeColor = System.Drawing.Color.White
        Me.ChangeBtn.Location = New System.Drawing.Point(0, 0)
        Me.ChangeBtn.Name = "ChangeBtn"
        Me.ChangeBtn.Size = New System.Drawing.Size(150, 32)
        Me.ChangeBtn.TabIndex = 0
        Me.ChangeBtn.Text = "Change Avatar"
        Me.ChangeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Savebtn)
        Me.Panel1.Controls.Add(Me.Editbtn)
        Me.Panel1.Location = New System.Drawing.Point(565, 629)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 32)
        Me.Panel1.TabIndex = 27
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.Transparent
        Me.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Savebtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Savebtn.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(0, 0)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(150, 32)
        Me.Savebtn.TabIndex = 1
        Me.Savebtn.Text = "Save"
        Me.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Savebtn.Visible = False
        '
        'Editbtn
        '
        Me.Editbtn.BackColor = System.Drawing.Color.Transparent
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Editbtn.Font = New System.Drawing.Font("SimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Editbtn.ForeColor = System.Drawing.Color.White
        Me.Editbtn.Location = New System.Drawing.Point(0, 0)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(150, 32)
        Me.Editbtn.TabIndex = 0
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveInfo
        '
        Me.SaveInfo.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SaveInfo.ForeColor = System.Drawing.Color.DarkOrange
        Me.SaveInfo.Location = New System.Drawing.Point(469, 282)
        Me.SaveInfo.Name = "SaveInfo"
        Me.SaveInfo.Size = New System.Drawing.Size(340, 37)
        Me.SaveInfo.TabIndex = 28
        Me.SaveInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailInfo
        '
        Me.EmailInfo.BackColor = System.Drawing.Color.Transparent
        Me.EmailInfo.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailInfo.ForeColor = System.Drawing.Color.DarkOrange
        Me.EmailInfo.Location = New System.Drawing.Point(823, 452)
        Me.EmailInfo.Name = "EmailInfo"
        Me.EmailInfo.Size = New System.Drawing.Size(207, 33)
        Me.EmailInfo.TabIndex = 29
        Me.EmailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PassInfo
        '
        Me.PassInfo.BackColor = System.Drawing.Color.Transparent
        Me.PassInfo.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PassInfo.ForeColor = System.Drawing.Color.DarkOrange
        Me.PassInfo.Location = New System.Drawing.Point(823, 560)
        Me.PassInfo.Name = "PassInfo"
        Me.PassInfo.Size = New System.Drawing.Size(207, 33)
        Me.PassInfo.TabIndex = 30
        Me.PassInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PassInfo)
        Me.Controls.Add(Me.EmailInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelChangeBtn)
        Me.Controls.Add(Me.ChangeAvatarPanel)
        Me.Controls.Add(Me.CnP)
        Me.Controls.Add(Me.ConfirmTB)
        Me.Controls.Add(Me.NewPasswordTB)
        Me.Controls.Add(Me.EmailTB)
        Me.Controls.Add(Me.SurnameTB)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.NameL)
        Me.Controls.Add(Me.Psw)
        Me.Controls.Add(Me.EL)
        Me.Controls.Add(Me.Su)
        Me.Controls.Add(Me.Na)
        Me.Controls.Add(Me.ProfilePic)
        Me.Controls.Add(Me.PbN)
        Me.Controls.Add(Me.PbS)
        Me.Controls.Add(Me.PbE)
        Me.Controls.Add(Me.PbP)
        Me.Controls.Add(Me.PbCP)
        Me.Controls.Add(Me.SaveInfo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChangeBtn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProfilePic As PictureBox
    Friend WithEvents Na As Label
    Friend WithEvents Su As Label
    Friend WithEvents EL As Label
    Friend WithEvents Ps As Label
    Friend WithEvents NameL As Label
    Friend WithEvents Surname As Label
    Friend WithEvents Email As Label
    Friend WithEvents NameTB As TextBox
    Friend WithEvents SurnameTB As TextBox
    Friend WithEvents EmailTB As TextBox
    Friend WithEvents NewPasswordTB As TextBox
    Friend WithEvents Psw As Label
    Friend WithEvents ConfirmTB As TextBox
    Friend WithEvents CnP As Label
    Friend WithEvents XError As ErrorProvider
    Friend WithEvents PbCP As PictureBox
    Friend WithEvents PbP As PictureBox
    Friend WithEvents PbE As PictureBox
    Friend WithEvents PbS As PictureBox
    Friend WithEvents PbN As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Avata As Panel
    Friend WithEvents ChangeAvatarPanel As Panel
    Friend WithEvents PanelChangeBtn As Panel
    Friend WithEvents ChangeBtn As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Editbtn As Label
    Friend WithEvents Savebtn As Label
    Friend WithEvents SaveInfo As Label
    Friend WithEvents EmailInfo As Label
    Friend WithEvents PassInfo As Label
End Class
