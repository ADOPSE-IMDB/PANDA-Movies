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
        Me.LogInTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RememberMe = New System.Windows.Forms.CheckBox()
        Me.LogInBtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PswLabel = New System.Windows.Forms.Label()
        Me.UsrNm = New System.Windows.Forms.TextBox()
        Me.UsrNmLabel = New System.Windows.Forms.Label()
        Me.CloseApp = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogInTitle
        '
        Me.LogInTitle.Font = New System.Drawing.Font("Tekton Pro Ext", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogInTitle.Location = New System.Drawing.Point(0, 9)
        Me.LogInTitle.Name = "LogInTitle"
        Me.LogInTitle.Size = New System.Drawing.Size(300, 50)
        Me.LogInTitle.TabIndex = 0
        Me.LogInTitle.Text = "IMDB?"
        Me.LogInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RememberMe)
        Me.Panel3.Controls.Add(Me.LogInBtn)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.PswLabel)
        Me.Panel3.Controls.Add(Me.UsrNm)
        Me.Panel3.Controls.Add(Me.UsrNmLabel)
        Me.Panel3.Location = New System.Drawing.Point(0, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 230)
        Me.Panel3.TabIndex = 2
        '
        'RememberMe
        '
        Me.RememberMe.Location = New System.Drawing.Point(98, 120)
        Me.RememberMe.Name = "RememberMe"
        Me.RememberMe.Size = New System.Drawing.Size(104, 19)
        Me.RememberMe.TabIndex = 6
        Me.RememberMe.Text = "Remember Me"
        Me.RememberMe.UseVisualStyleBackColor = True
        '
        'LogInBtn
        '
        Me.LogInBtn.Font = New System.Drawing.Font("Tekton Pro Ext", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogInBtn.Location = New System.Drawing.Point(90, 150)
        Me.LogInBtn.Name = "LogInBtn"
        Me.LogInBtn.Size = New System.Drawing.Size(120, 25)
        Me.LogInBtn.TabIndex = 5
        Me.LogInBtn.Text = "Log In"
        Me.LogInBtn.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.BlueViolet
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(75, 208)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(150, 15)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create your IMDB account"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(50, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PswLabel
        '
        Me.PswLabel.Font = New System.Drawing.Font("Tekton Pro Ext", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PswLabel.Location = New System.Drawing.Point(0, 51)
        Me.PswLabel.Name = "PswLabel"
        Me.PswLabel.Size = New System.Drawing.Size(300, 32)
        Me.PswLabel.TabIndex = 2
        Me.PswLabel.Text = "Password"
        Me.PswLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UsrNm
        '
        Me.UsrNm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsrNm.Font = New System.Drawing.Font("Tekton Pro Ext", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsrNm.Location = New System.Drawing.Point(50, 26)
        Me.UsrNm.Name = "UsrNm"
        Me.UsrNm.Size = New System.Drawing.Size(200, 22)
        Me.UsrNm.TabIndex = 1
        Me.UsrNm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsrNmLabel
        '
        Me.UsrNmLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.UsrNmLabel.Font = New System.Drawing.Font("Tekton Pro Ext", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsrNmLabel.Location = New System.Drawing.Point(0, 0)
        Me.UsrNmLabel.Name = "UsrNmLabel"
        Me.UsrNmLabel.Size = New System.Drawing.Size(300, 23)
        Me.UsrNmLabel.TabIndex = 0
        Me.UsrNmLabel.Text = "Username"
        Me.UsrNmLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CloseApp
        '
        Me.CloseApp.Location = New System.Drawing.Point(258, 9)
        Me.CloseApp.Name = "CloseApp"
        Me.CloseApp.Size = New System.Drawing.Size(30, 30)
        Me.CloseApp.TabIndex = 3
        Me.CloseApp.Text = "X"
        Me.CloseApp.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseApp)
        Me.Controls.Add(Me.LogInTitle)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogInTitle As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UsrNmLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PswLabel As Label
    Friend WithEvents UsrNm As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CloseApp As Button
    Friend WithEvents RememberMe As CheckBox
    Friend WithEvents LogInBtn As Button
End Class
