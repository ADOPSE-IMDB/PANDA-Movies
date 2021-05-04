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
        Me.Pre = New System.Windows.Forms.Button()
        Me.AllMoviesPanel = New System.Windows.Forms.Panel()
        Me.AllMoviesLabel = New System.Windows.Forms.Label()
        Me.TopMoviesPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopMoviesLabel = New System.Windows.Forms.Label()
        Me.ne = New System.Windows.Forms.Button()
        Me.AllMoviesPanel.SuspendLayout()
        Me.TopMoviesPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'curr
        '
        Me.curr.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.curr.BackColor = System.Drawing.Color.DarkGray
        Me.curr.Location = New System.Drawing.Point(604, 668)
        Me.curr.Name = "curr"
        Me.curr.Size = New System.Drawing.Size(74, 20)
        Me.curr.TabIndex = 19
        Me.curr.Text = "1 -> 20"
        Me.curr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pre
        '
        Me.Pre.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Pre.Enabled = False
        Me.Pre.Location = New System.Drawing.Point(547, 691)
        Me.Pre.Name = "Pre"
        Me.Pre.Size = New System.Drawing.Size(75, 23)
        Me.Pre.TabIndex = 17
        Me.Pre.Text = "Start"
        Me.Pre.UseVisualStyleBackColor = True
        '
        'AllMoviesPanel
        '
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
        Me.TopMoviesLabel.Location = New System.Drawing.Point(0, 0)
        Me.TopMoviesLabel.Name = "TopMoviesLabel"
        Me.TopMoviesLabel.Size = New System.Drawing.Size(1280, 55)
        Me.TopMoviesLabel.TabIndex = 21
        Me.TopMoviesLabel.Text = "Top 10 Movies"
        Me.TopMoviesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ne
        '
        Me.ne.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ne.Location = New System.Drawing.Point(658, 691)
        Me.ne.Name = "ne"
        Me.ne.Size = New System.Drawing.Size(75, 23)
        Me.ne.TabIndex = 20
        Me.ne.Text = "21 - > 40"
        Me.ne.UseVisualStyleBackColor = True
        '
        'MoviesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 719)
        Me.Controls.Add(Me.curr)
        Me.Controls.Add(Me.ne)
        Me.Controls.Add(Me.Pre)
        Me.Controls.Add(Me.AllMoviesPanel)
        Me.Controls.Add(Me.TopMoviesPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MoviesMain"
        Me.AllMoviesPanel.ResumeLayout(False)
        Me.TopMoviesPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents curr As Label
    Friend WithEvents Pre As Button
    Friend WithEvents AllMoviesPanel As Panel
    Friend WithEvents TopMoviesPanel As Panel
    Friend WithEvents AllMoviesLabel As Label
    Friend WithEvents TopMoviesLabel As Label
    Friend WithEvents ne As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
