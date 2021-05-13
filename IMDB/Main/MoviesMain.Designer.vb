<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MoviesMain
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
        Me.curr = New System.Windows.Forms.Label()
        Me.AllMoviesPanel = New System.Windows.Forms.Panel()
        Me.AllMoviesLabel = New System.Windows.Forms.Label()
        Me.TopMoviesPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopMoviesLabel = New System.Windows.Forms.Label()
        Me.NextPanel = New System.Windows.Forms.Panel()
        Me.Ne = New System.Windows.Forms.Label()
        Me.PrePanel = New System.Windows.Forms.Panel()
        Me.Pre = New System.Windows.Forms.Label()
        Me.AllMoviesPanel.SuspendLayout()
        Me.TopMoviesPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NextPanel.SuspendLayout()
        Me.PrePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'curr
        '
        Me.curr.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.curr.BackColor = System.Drawing.Color.DarkGray
        Me.curr.ForeColor = System.Drawing.Color.White
        Me.curr.Image = Global.IMDB.My.Resources.Resources.Indicator
        Me.curr.Location = New System.Drawing.Point(604, 668)
        Me.curr.Name = "curr"
        Me.curr.Size = New System.Drawing.Size(74, 20)
        Me.curr.TabIndex = 19
        Me.curr.Text = "1 -> 20"
        Me.curr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AllMoviesPanel
        '
        Me.AllMoviesPanel.BackColor = System.Drawing.Color.Transparent
        Me.AllMoviesPanel.Controls.Add(Me.AllMoviesLabel)
        Me.AllMoviesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AllMoviesPanel.Location = New System.Drawing.Point(0, 325)
        Me.AllMoviesPanel.Name = "AllMoviesPanel"
        Me.AllMoviesPanel.Size = New System.Drawing.Size(1280, 254)
        Me.AllMoviesPanel.TabIndex = 16
        '
        'AllMoviesLabel
        '
        Me.AllMoviesLabel.BackColor = System.Drawing.Color.Transparent
        Me.AllMoviesLabel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AllMoviesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AllMoviesLabel.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AllMoviesLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.AllMoviesLabel.Location = New System.Drawing.Point(0, 0)
        Me.AllMoviesLabel.Name = "AllMoviesLabel"
        Me.AllMoviesLabel.Size = New System.Drawing.Size(1280, 50)
        Me.AllMoviesLabel.TabIndex = 1
        Me.AllMoviesLabel.Text = "More movies"
        Me.AllMoviesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TopMoviesPanel
        '
        Me.TopMoviesPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopMoviesPanel.Controls.Add(Me.PictureBox1)
        Me.TopMoviesPanel.Controls.Add(Me.TopMoviesLabel)
        Me.TopMoviesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMoviesPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopMoviesPanel.Name = "TopMoviesPanel"
        Me.TopMoviesPanel.Size = New System.Drawing.Size(1280, 325)
        Me.TopMoviesPanel.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 3)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'TopMoviesLabel
        '
        Me.TopMoviesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMoviesLabel.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TopMoviesLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.TopMoviesLabel.Location = New System.Drawing.Point(0, 0)
        Me.TopMoviesLabel.Name = "TopMoviesLabel"
        Me.TopMoviesLabel.Size = New System.Drawing.Size(1280, 55)
        Me.TopMoviesLabel.TabIndex = 21
        Me.TopMoviesLabel.Text = "Top 10 Movies"
        Me.TopMoviesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextPanel
        '
        Me.NextPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NextPanel.BackColor = System.Drawing.Color.Transparent
        Me.NextPanel.BackgroundImage = Global.IMDB.My.Resources.Resources.GeneralBtn1
        Me.NextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextPanel.Controls.Add(Me.Ne)
        Me.NextPanel.Location = New System.Drawing.Point(659, 691)
        Me.NextPanel.Name = "NextPanel"
        Me.NextPanel.Size = New System.Drawing.Size(75, 23)
        Me.NextPanel.TabIndex = 21
        '
        'Ne
        '
        Me.Ne.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Ne.BackColor = System.Drawing.Color.Transparent
        Me.Ne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ne.ForeColor = System.Drawing.Color.White
        Me.Ne.Location = New System.Drawing.Point(0, 0)
        Me.Ne.Name = "Ne"
        Me.Ne.Size = New System.Drawing.Size(75, 23)
        Me.Ne.TabIndex = 0
        Me.Ne.Text = "21 -> 40"
        Me.Ne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrePanel
        '
        Me.PrePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrePanel.BackColor = System.Drawing.Color.Black
        Me.PrePanel.BackgroundImage = Global.IMDB.My.Resources.Resources.Indicator
        Me.PrePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrePanel.Controls.Add(Me.Pre)
        Me.PrePanel.Location = New System.Drawing.Point(551, 691)
        Me.PrePanel.Name = "PrePanel"
        Me.PrePanel.Size = New System.Drawing.Size(75, 23)
        Me.PrePanel.TabIndex = 22
        '
        'Pre
        '
        Me.Pre.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Pre.BackColor = System.Drawing.Color.Transparent
        Me.Pre.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pre.ForeColor = System.Drawing.Color.White
        Me.Pre.Location = New System.Drawing.Point(0, 0)
        Me.Pre.Name = "Pre"
        Me.Pre.Size = New System.Drawing.Size(75, 23)
        Me.Pre.TabIndex = 0
        Me.Pre.Text = "Start"
        Me.Pre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MoviesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1280, 719)
        Me.Controls.Add(Me.PrePanel)
        Me.Controls.Add(Me.NextPanel)
        Me.Controls.Add(Me.curr)
        Me.Controls.Add(Me.AllMoviesPanel)
        Me.Controls.Add(Me.TopMoviesPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MoviesMain"
        Me.AllMoviesPanel.ResumeLayout(False)
        Me.TopMoviesPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NextPanel.ResumeLayout(False)
        Me.PrePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents curr As Label
    Friend WithEvents AllMoviesPanel As Panel
    Friend WithEvents TopMoviesPanel As Panel
    Friend WithEvents AllMoviesLabel As Label
    Friend WithEvents TopMoviesLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NextPanel As Panel
    Friend WithEvents Ne As Label
    Friend WithEvents PrePanel As Panel
    Friend WithEvents Pre As Label
End Class
