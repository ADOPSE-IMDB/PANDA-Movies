<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentMovie
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
        Me.MoPic = New System.Windows.Forms.PictureBox()
        Me.MovieName = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.CloseMovie = New System.Windows.Forms.Button()
        Me.AddRem = New System.Windows.Forms.Button()
        Me.MovieDate = New System.Windows.Forms.Label()
        Me.Rate = New System.Windows.Forms.Label()
        CType(Me.MoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MoPic
        '
        Me.MoPic.Location = New System.Drawing.Point(30, 30)
        Me.MoPic.Name = "MoPic"
        Me.MoPic.Size = New System.Drawing.Size(190, 250)
        Me.MoPic.TabIndex = 0
        Me.MoPic.TabStop = False
        '
        'MovieName
        '
        Me.MovieName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MovieName.Location = New System.Drawing.Point(226, 30)
        Me.MovieName.Name = "MovieName"
        Me.MovieName.Size = New System.Drawing.Size(362, 23)
        Me.MovieName.TabIndex = 1
        Me.MovieName.Text = "Name"
        Me.MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(30, 348)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(362, 194)
        Me.Description.TabIndex = 2
        Me.Description.Text = "Description"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.CloseMovie)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(600, 24)
        Me.TopPanel.TabIndex = 3
        '
        'CloseMovie
        '
        Me.CloseMovie.Location = New System.Drawing.Point(578, 0)
        Me.CloseMovie.Name = "CloseMovie"
        Me.CloseMovie.Size = New System.Drawing.Size(22, 22)
        Me.CloseMovie.TabIndex = 4
        Me.CloseMovie.Text = "X"
        Me.CloseMovie.UseVisualStyleBackColor = True
        '
        'AddRem
        '
        Me.AddRem.Location = New System.Drawing.Point(362, 242)
        Me.AddRem.Name = "AddRem"
        Me.AddRem.Size = New System.Drawing.Size(75, 23)
        Me.AddRem.TabIndex = 4
        Me.AddRem.Text = "Add/Rem"
        Me.AddRem.UseVisualStyleBackColor = True
        '
        'MovieDate
        '
        Me.MovieDate.AutoSize = True
        Me.MovieDate.Location = New System.Drawing.Point(395, 141)
        Me.MovieDate.Name = "MovieDate"
        Me.MovieDate.Size = New System.Drawing.Size(30, 15)
        Me.MovieDate.TabIndex = 5
        Me.MovieDate.Text = "date"
        '
        'Rate
        '
        Me.Rate.AutoSize = True
        Me.Rate.Location = New System.Drawing.Point(395, 71)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(27, 15)
        Me.Rate.TabIndex = 6
        Me.Rate.Text = "rate"
        '
        'CurrentMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 702)
        Me.Controls.Add(Me.Rate)
        Me.Controls.Add(Me.MovieDate)
        Me.Controls.Add(Me.AddRem)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.MovieName)
        Me.Controls.Add(Me.MoPic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CurrentMovie"
        Me.Text = "CurrentMovie"
        CType(Me.MoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoPic As PictureBox
    Friend WithEvents MovieName As Label
    Friend WithEvents Description As Label
    Friend WithEvents TopPanel As Panel
    Friend WithEvents CloseMovie As Button
    Friend WithEvents AddRem As Button
    Friend WithEvents MovieDate As Label
    Friend WithEvents Rate As Label

End Class
