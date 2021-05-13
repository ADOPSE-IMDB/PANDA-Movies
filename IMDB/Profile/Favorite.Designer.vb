<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Favorite
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
        Me.FavoritePanel = New System.Windows.Forms.Panel()
        Me.info = New System.Windows.Forms.Label()
        Me.FavoriteLabel = New System.Windows.Forms.Label()
        Me.curr = New System.Windows.Forms.Label()
        Me.PrePanel = New System.Windows.Forms.Panel()
        Me.Pre = New System.Windows.Forms.Label()
        Me.NextPanel = New System.Windows.Forms.Panel()
        Me.ne = New System.Windows.Forms.Label()
        Me.FavoritePanel.SuspendLayout()
        Me.PrePanel.SuspendLayout()
        Me.NextPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FavoritePanel
        '
        Me.FavoritePanel.BackColor = System.Drawing.Color.Transparent
        Me.FavoritePanel.Controls.Add(Me.info)
        Me.FavoritePanel.Controls.Add(Me.FavoriteLabel)
        Me.FavoritePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FavoritePanel.Location = New System.Drawing.Point(0, 0)
        Me.FavoritePanel.Name = "FavoritePanel"
        Me.FavoritePanel.Size = New System.Drawing.Size(1280, 649)
        Me.FavoritePanel.TabIndex = 11
        '
        'info
        '
        Me.info.Font = New System.Drawing.Font("SimSun", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.info.ForeColor = System.Drawing.Color.DarkOrange
        Me.info.Location = New System.Drawing.Point(12, 44)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(1256, 605)
        Me.info.TabIndex = 1
        Me.info.Text = "Add Movies to your Favorite first"
        Me.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info.Visible = False
        '
        'FavoriteLabel
        '
        Me.FavoriteLabel.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FavoriteLabel.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FavoriteLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.FavoriteLabel.Location = New System.Drawing.Point(0, 0)
        Me.FavoriteLabel.Name = "FavoriteLabel"
        Me.FavoriteLabel.Size = New System.Drawing.Size(1280, 44)
        Me.FavoriteLabel.TabIndex = 0
        Me.FavoriteLabel.Text = "My Favorite Movies"
        Me.FavoriteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'curr
        '
        Me.curr.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.curr.BackColor = System.Drawing.Color.DarkGray
        Me.curr.ForeColor = System.Drawing.Color.White
        Me.curr.Image = Global.IMDB.My.Resources.Resources.Indicator
        Me.curr.Location = New System.Drawing.Point(604, 662)
        Me.curr.Name = "curr"
        Me.curr.Size = New System.Drawing.Size(74, 20)
        Me.curr.TabIndex = 17
        Me.curr.Text = "1 -> 20"
        Me.curr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrePanel
        '
        Me.PrePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrePanel.BackColor = System.Drawing.Color.Black
        Me.PrePanel.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.PrePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrePanel.Controls.Add(Me.Pre)
        Me.PrePanel.Location = New System.Drawing.Point(548, 689)
        Me.PrePanel.Name = "PrePanel"
        Me.PrePanel.Size = New System.Drawing.Size(75, 23)
        Me.PrePanel.TabIndex = 24
        '
        'Pre
        '
        Me.Pre.BackColor = System.Drawing.Color.Transparent
        Me.Pre.ForeColor = System.Drawing.Color.White
        Me.Pre.Location = New System.Drawing.Point(0, 0)
        Me.Pre.Name = "Pre"
        Me.Pre.Size = New System.Drawing.Size(75, 23)
        Me.Pre.TabIndex = 1
        Me.Pre.Text = "Start"
        Me.Pre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextPanel
        '
        Me.NextPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NextPanel.BackColor = System.Drawing.Color.Transparent
        Me.NextPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.NextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextPanel.Controls.Add(Me.ne)
        Me.NextPanel.Location = New System.Drawing.Point(656, 689)
        Me.NextPanel.Name = "NextPanel"
        Me.NextPanel.Size = New System.Drawing.Size(75, 23)
        Me.NextPanel.TabIndex = 23
        '
        'ne
        '
        Me.ne.BackColor = System.Drawing.Color.Transparent
        Me.ne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ne.ForeColor = System.Drawing.Color.White
        Me.ne.Location = New System.Drawing.Point(0, 0)
        Me.ne.Name = "ne"
        Me.ne.Size = New System.Drawing.Size(75, 23)
        Me.ne.TabIndex = 2
        Me.ne.Text = "Start"
        Me.ne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Favorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PrePanel)
        Me.Controls.Add(Me.NextPanel)
        Me.Controls.Add(Me.curr)
        Me.Controls.Add(Me.FavoritePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Favorite"
        Me.Text = "Favorite"
        Me.FavoritePanel.ResumeLayout(False)
        Me.PrePanel.ResumeLayout(False)
        Me.NextPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FavoritePanel As Panel
    Friend WithEvents FavoriteLabel As Label
    Friend WithEvents info As Label
    Friend WithEvents curr As Label
    Friend WithEvents PrePanel As Panel
    Friend WithEvents Pre As Label
    Friend WithEvents NextPanel As Panel
    Friend WithEvents ne As Label
End Class
