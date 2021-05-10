<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.ProfilePL = New System.Windows.Forms.Label()
        Me.UploadB = New System.Windows.Forms.Button()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.Na = New System.Windows.Forms.Label()
        Me.Su = New System.Windows.Forms.Label()
        Me.EL = New System.Windows.Forms.Label()
        Me.Psw = New System.Windows.Forms.Label()
        Me.EditB = New System.Windows.Forms.Button()
        Me.NameL = New System.Windows.Forms.Label()
        Me.Surname = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.UpdateB = New System.Windows.Forms.Button()
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
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfilePL
        '
        Me.ProfilePL.AutoSize = True
        Me.ProfilePL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProfilePL.Location = New System.Drawing.Point(202, 147)
        Me.ProfilePL.Name = "ProfilePL"
        Me.ProfilePL.Size = New System.Drawing.Size(143, 25)
        Me.ProfilePL.TabIndex = 1
        Me.ProfilePL.Text = "Profile Picture :"
        '
        'UploadB
        '
        Me.UploadB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UploadB.Location = New System.Drawing.Point(399, 149)
        Me.UploadB.Name = "UploadB"
        Me.UploadB.Size = New System.Drawing.Size(74, 23)
        Me.UploadB.TabIndex = 2
        Me.UploadB.Text = "Upload"
        Me.UploadB.UseVisualStyleBackColor = True
        '
        'ProfilePic
        '
        Me.ProfilePic.Image = CType(resources.GetObject("ProfilePic.Image"), System.Drawing.Image)
        Me.ProfilePic.Location = New System.Drawing.Point(42, 106)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(105, 112)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePic.TabIndex = 3
        Me.ProfilePic.TabStop = False
        '
        'Na
        '
        Me.Na.AutoSize = True
        Me.Na.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Na.Location = New System.Drawing.Point(202, 269)
        Me.Na.Name = "Na"
        Me.Na.Size = New System.Drawing.Size(72, 25)
        Me.Na.TabIndex = 4
        Me.Na.Text = "Name :"
        '
        'Su
        '
        Me.Su.AutoSize = True
        Me.Su.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Su.Location = New System.Drawing.Point(202, 326)
        Me.Su.Name = "Su"
        Me.Su.Size = New System.Drawing.Size(97, 25)
        Me.Su.TabIndex = 5
        Me.Su.Text = "Surname :"
        '
        'EL
        '
        Me.EL.AutoSize = True
        Me.EL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EL.Location = New System.Drawing.Point(202, 386)
        Me.EL.Name = "EL"
        Me.EL.Size = New System.Drawing.Size(75, 25)
        Me.EL.TabIndex = 6
        Me.EL.Text = "E-mail :"
        '
        'Psw
        '
        Me.Psw.AutoSize = True
        Me.Psw.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Psw.Location = New System.Drawing.Point(202, 443)
        Me.Psw.Name = "Psw"
        Me.Psw.Size = New System.Drawing.Size(140, 25)
        Me.Psw.TabIndex = 7
        Me.Psw.Text = "New Password:"
        Me.Psw.Visible = False
        '
        'EditB
        '
        Me.EditB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditB.Location = New System.Drawing.Point(199, 445)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(75, 23)
        Me.EditB.TabIndex = 8
        Me.EditB.Text = "Edit"
        Me.EditB.UseVisualStyleBackColor = True
        '
        'NameL
        '
        Me.NameL.AutoSize = True
        Me.NameL.Location = New System.Drawing.Point(472, 275)
        Me.NameL.Name = "NameL"
        Me.NameL.Size = New System.Drawing.Size(41, 15)
        Me.NameL.TabIndex = 9
        Me.NameL.Text = "Label1"
        '
        'Surname
        '
        Me.Surname.AutoSize = True
        Me.Surname.Location = New System.Drawing.Point(472, 336)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(41, 15)
        Me.Surname.TabIndex = 10
        Me.Surname.Text = "Label2"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(472, 392)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(41, 15)
        Me.Email.TabIndex = 11
        Me.Email.Text = "Label3"
        '
        'UpdateB
        '
        Me.UpdateB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateB.Location = New System.Drawing.Point(399, 552)
        Me.UpdateB.Name = "UpdateB"
        Me.UpdateB.Size = New System.Drawing.Size(75, 23)
        Me.UpdateB.TabIndex = 13
        Me.UpdateB.Text = "Update"
        Me.UpdateB.UseVisualStyleBackColor = True
        Me.UpdateB.Visible = False
        '
        'NameTB
        '
        Me.NameTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameTB.ForeColor = System.Drawing.Color.DarkGray
        Me.NameTB.Location = New System.Drawing.Point(435, 272)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 22)
        Me.NameTB.TabIndex = 14
        Me.NameTB.Visible = False
        '
        'SurnameTB
        '
        Me.SurnameTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SurnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SurnameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SurnameTB.ForeColor = System.Drawing.Color.DarkGray
        Me.SurnameTB.Location = New System.Drawing.Point(435, 329)
        Me.SurnameTB.Name = "SurnameTB"
        Me.SurnameTB.Size = New System.Drawing.Size(100, 22)
        Me.SurnameTB.TabIndex = 15
        Me.SurnameTB.Visible = False
        '
        'EmailTB
        '
        Me.EmailTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailTB.ForeColor = System.Drawing.Color.DarkGray
        Me.EmailTB.Location = New System.Drawing.Point(435, 392)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(100, 22)
        Me.EmailTB.TabIndex = 16
        Me.EmailTB.Visible = False
        '
        'NewPasswordTB
        '
        Me.NewPasswordTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.NewPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewPasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewPasswordTB.ForeColor = System.Drawing.Color.DarkGray
        Me.NewPasswordTB.Location = New System.Drawing.Point(435, 446)
        Me.NewPasswordTB.Name = "NewPasswordTB"
        Me.NewPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTB.Size = New System.Drawing.Size(100, 22)
        Me.NewPasswordTB.TabIndex = 17
        Me.NewPasswordTB.Visible = False
        '
        'ConfirmTB
        '
        Me.ConfirmTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ConfirmTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConfirmTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmTB.ForeColor = System.Drawing.Color.DarkGray
        Me.ConfirmTB.Location = New System.Drawing.Point(435, 497)
        Me.ConfirmTB.Name = "ConfirmTB"
        Me.ConfirmTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmTB.Size = New System.Drawing.Size(100, 22)
        Me.ConfirmTB.TabIndex = 18
        Me.ConfirmTB.Visible = False
        '
        'CnP
        '
        Me.CnP.AutoSize = True
        Me.CnP.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CnP.Location = New System.Drawing.Point(202, 494)
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
        Me.PbN.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PbN.BackColor = System.Drawing.Color.Transparent
        Me.PbN.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbN.Location = New System.Drawing.Point(415, 269)
        Me.PbN.Name = "PbN"
        Me.PbN.Size = New System.Drawing.Size(141, 33)
        Me.PbN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbN.TabIndex = 20
        Me.PbN.TabStop = False
        Me.PbN.Visible = False
        '
        'PbS
        '
        Me.PbS.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PbS.BackColor = System.Drawing.Color.Transparent
        Me.PbS.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbS.Location = New System.Drawing.Point(415, 326)
        Me.PbS.Name = "PbS"
        Me.PbS.Size = New System.Drawing.Size(141, 33)
        Me.PbS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbS.TabIndex = 21
        Me.PbS.TabStop = False
        Me.PbS.Visible = False
        '
        'PbE
        '
        Me.PbE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PbE.BackColor = System.Drawing.Color.Transparent
        Me.PbE.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbE.Location = New System.Drawing.Point(415, 386)
        Me.PbE.Name = "PbE"
        Me.PbE.Size = New System.Drawing.Size(141, 33)
        Me.PbE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbE.TabIndex = 22
        Me.PbE.TabStop = False
        Me.PbE.Visible = False
        '
        'PbP
        '
        Me.PbP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PbP.BackColor = System.Drawing.Color.Transparent
        Me.PbP.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbP.Location = New System.Drawing.Point(415, 443)
        Me.PbP.Name = "PbP"
        Me.PbP.Size = New System.Drawing.Size(141, 33)
        Me.PbP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbP.TabIndex = 23
        Me.PbP.TabStop = False
        Me.PbP.Visible = False
        '
        'PbCP
        '
        Me.PbCP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PbCP.BackColor = System.Drawing.Color.Transparent
        Me.PbCP.Image = Global.IMDB.My.Resources.Resources.bgtxt
        Me.PbCP.Location = New System.Drawing.Point(415, 494)
        Me.PbCP.Name = "PbCP"
        Me.PbCP.Size = New System.Drawing.Size(141, 33)
        Me.PbCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbCP.TabIndex = 24
        Me.PbCP.TabStop = False
        Me.PbCP.Visible = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(600, 702)
        Me.Controls.Add(Me.CnP)
        Me.Controls.Add(Me.ConfirmTB)
        Me.Controls.Add(Me.NewPasswordTB)
        Me.Controls.Add(Me.EmailTB)
        Me.Controls.Add(Me.SurnameTB)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.UpdateB)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.NameL)
        Me.Controls.Add(Me.EditB)
        Me.Controls.Add(Me.Psw)
        Me.Controls.Add(Me.EL)
        Me.Controls.Add(Me.Su)
        Me.Controls.Add(Me.Na)
        Me.Controls.Add(Me.ProfilePic)
        Me.Controls.Add(Me.UploadB)
        Me.Controls.Add(Me.ProfilePL)
        Me.Controls.Add(Me.PbN)
        Me.Controls.Add(Me.PbS)
        Me.Controls.Add(Me.PbE)
        Me.Controls.Add(Me.PbP)
        Me.Controls.Add(Me.PbCP)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProfilePL As Label
    Friend WithEvents UploadB As Button
    Friend WithEvents ProfilePic As PictureBox
    Friend WithEvents Na As Label
    Friend WithEvents Su As Label
    Friend WithEvents EL As Label
    Friend WithEvents Ps As Label
    Friend WithEvents EditB As Button
    Friend WithEvents NameL As Label
    Friend WithEvents Surname As Label
    Friend WithEvents Email As Label
    Friend WithEvents UpdateB As Button
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
End Class
