<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMessageBox
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
        Me.CloseMessageBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitAppBtn = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MovePanel = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogOut = New System.Windows.Forms.Label()
        CType(Me.CloseMessageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MovePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseMessageBox
        '
        Me.CloseMessageBox.BackColor = System.Drawing.Color.Transparent
        Me.CloseMessageBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseMessageBox.Image = Global.IMDB.My.Resources.Resources.Close1
        Me.CloseMessageBox.Location = New System.Drawing.Point(275, 0)
        Me.CloseMessageBox.Name = "CloseMessageBox"
        Me.CloseMessageBox.Size = New System.Drawing.Size(25, 25)
        Me.CloseMessageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseMessageBox.TabIndex = 0
        Me.CloseMessageBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ExitAppBtn)
        Me.Panel1.Location = New System.Drawing.Point(15, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 30)
        Me.Panel1.TabIndex = 1
        '
        'ExitAppBtn
        '
        Me.ExitAppBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitAppBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitAppBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitAppBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.ExitAppBtn.ForeColor = System.Drawing.Color.White
        Me.ExitAppBtn.Location = New System.Drawing.Point(0, 0)
        Me.ExitAppBtn.Name = "ExitAppBtn"
        Me.ExitAppBtn.Size = New System.Drawing.Size(130, 30)
        Me.ExitAppBtn.TabIndex = 0
        Me.ExitAppBtn.Text = "Exit PANDApp"
        Me.ExitAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel2.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.LogOut)
        Me.Panel2.Location = New System.Drawing.Point(155, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 30)
        Me.Panel2.TabIndex = 2
        '
        'MovePanel
        '
        Me.MovePanel.BackColor = System.Drawing.Color.Transparent
        Me.MovePanel.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.MovePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MovePanel.Controls.Add(Me.Title)
        Me.MovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel.Name = "MovePanel"
        Me.MovePanel.Size = New System.Drawing.Size(300, 25)
        Me.MovePanel.TabIndex = 3
        '
        'Title
        '
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(300, 25)
        Me.Title.TabIndex = 0
        Me.Title.Text = "We will miss you :/"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(0, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Do you want to exit or Log Out?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.Transparent
        Me.LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogOut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LogOut.ForeColor = System.Drawing.Color.White
        Me.LogOut.Location = New System.Drawing.Point(0, 0)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(130, 30)
        Me.LogOut.TabIndex = 1
        Me.LogOut.Text = "Log Out"
        Me.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 103)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CloseMessageBox)
        Me.Controls.Add(Me.MovePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomMessageBox"
        Me.TopMost = True
        CType(Me.CloseMessageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MovePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseMessageBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MovePanel As Panel
    Friend WithEvents ExitAppBtn As Label
    Friend WithEvents Title As Label
    Friend WithEvents LogOut As Label
    Friend WithEvents Label1 As Label
End Class
