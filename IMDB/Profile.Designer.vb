<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Me.ProfilePL = New System.Windows.Forms.Label()
        Me.UploadB = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NameL = New System.Windows.Forms.Label()
        Me.SurnameL = New System.Windows.Forms.Label()
        Me.EmailL = New System.Windows.Forms.Label()
        Me.PasswordL = New System.Windows.Forms.Label()
        Me.EditB = New System.Windows.Forms.Button()
        Me.Name = New System.Windows.Forms.Label()
        Me.Surname = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Update = New System.Windows.Forms.Button()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.SurnameTB = New System.Windows.Forms.TextBox()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.NewPasswordTB = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(38, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'NameL
        '
        Me.NameL.AutoSize = True
        Me.NameL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameL.Location = New System.Drawing.Point(202, 269)
        Me.NameL.Name = "NameL"
        Me.NameL.Size = New System.Drawing.Size(72, 25)
        Me.NameL.TabIndex = 4
        Me.NameL.Text = "Name :"
        '
        'SurnameL
        '
        Me.SurnameL.AutoSize = True
        Me.SurnameL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SurnameL.Location = New System.Drawing.Point(202, 326)
        Me.SurnameL.Name = "SurnameL"
        Me.SurnameL.Size = New System.Drawing.Size(97, 25)
        Me.SurnameL.TabIndex = 5
        Me.SurnameL.Text = "Surname :"
        '
        'EmailL
        '
        Me.EmailL.AutoSize = True
        Me.EmailL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmailL.Location = New System.Drawing.Point(202, 386)
        Me.EmailL.Name = "EmailL"
        Me.EmailL.Size = New System.Drawing.Size(75, 25)
        Me.EmailL.TabIndex = 6
        Me.EmailL.Text = "E-mail :"
        '
        'PasswordL
        '
        Me.PasswordL.AutoSize = True
        Me.PasswordL.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordL.Location = New System.Drawing.Point(202, 443)
        Me.PasswordL.Name = "PasswordL"
        Me.PasswordL.Size = New System.Drawing.Size(145, 25)
        Me.PasswordL.TabIndex = 7
        Me.PasswordL.Text = "New Password :"
        '
        'EditB
        '
        Me.EditB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditB.Location = New System.Drawing.Point(202, 516)
        Me.EditB.Name = "EditB"
        Me.EditB.Size = New System.Drawing.Size(75, 23)
        Me.EditB.TabIndex = 8
        Me.EditB.Text = "Edit"
        Me.EditB.UseVisualStyleBackColor = True
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(399, 275)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(41, 15)
        Me.Name.TabIndex = 9
        Me.Name.Text = "Label1"
        '
        'Surname
        '
        Me.Surname.AutoSize = True
        Me.Surname.Location = New System.Drawing.Point(399, 336)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(41, 15)
        Me.Surname.TabIndex = 10
        Me.Surname.Text = "Label2"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(399, 392)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(41, 15)
        Me.Email.TabIndex = 11
        Me.Email.Text = "Label3"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(399, 453)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(41, 15)
        Me.Password.TabIndex = 12
        Me.Password.Text = "Label4"
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Update.Location = New System.Drawing.Point(365, 516)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 23)
        Me.Update.TabIndex = 13
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        Me.Update.Visible = False
        '
        'NameTB
        '
        Me.NameTB.Location = New System.Drawing.Point(381, 272)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 23)
        Me.NameTB.TabIndex = 14
        Me.NameTB.Visible = False
        '
        'SurnameTB
        '
        Me.SurnameTB.Location = New System.Drawing.Point(381, 329)
        Me.SurnameTB.Name = "SurnameTB"
        Me.SurnameTB.Size = New System.Drawing.Size(100, 23)
        Me.SurnameTB.TabIndex = 15
        Me.SurnameTB.Visible = False
        '
        'EmailTB
        '
        Me.EmailTB.Location = New System.Drawing.Point(381, 389)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(100, 23)
        Me.EmailTB.TabIndex = 16
        Me.EmailTB.Visible = False
        '
        'NewPasswordTB
        '
        Me.NewPasswordTB.Location = New System.Drawing.Point(381, 446)
        Me.NewPasswordTB.Name = "NewPasswordTB"
        Me.NewPasswordTB.Size = New System.Drawing.Size(100, 23)
        Me.NewPasswordTB.TabIndex = 17
        Me.NewPasswordTB.Visible = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 702)
        Me.Controls.Add(Me.NewPasswordTB)
        Me.Controls.Add(Me.EmailTB)
        Me.Controls.Add(Me.SurnameTB)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.EditB)
        Me.Controls.Add(Me.PasswordL)
        Me.Controls.Add(Me.EmailL)
        Me.Controls.Add(Me.SurnameL)
        Me.Controls.Add(Me.NameL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UploadB)
        Me.Controls.Add(Me.ProfilePL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProfilePL As Label
    Friend WithEvents UploadB As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NameL As Label
    Friend WithEvents SurnameL As Label
    Friend WithEvents EmailL As Label
    Friend WithEvents PasswordL As Label
    Friend WithEvents EditB As Button
    Friend WithEvents Name As Label
    Friend WithEvents Surname As Label
    Friend WithEvents Email As Label
    Friend WithEvents Password As Label
    Friend WithEvents Update As Button
    Friend WithEvents NameTB As TextBox
    Friend WithEvents SurnameTB As TextBox
    Friend WithEvents EmailTB As TextBox
    Friend WithEvents NewPasswordTB As TextBox
End Class
