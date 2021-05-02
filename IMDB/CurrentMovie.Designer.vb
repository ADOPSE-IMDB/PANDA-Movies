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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.actors = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MovieGenre = New System.Windows.Forms.Label()
        CType(Me.MoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoPic
        '
        Me.MoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MoPic.Image = Global.IMDB.My.Resources.Resources._200
        Me.MoPic.Location = New System.Drawing.Point(34, 30)
        Me.MoPic.Name = "MoPic"
        Me.MoPic.Size = New System.Drawing.Size(208, 306)
        Me.MoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MoPic.TabIndex = 0
        Me.MoPic.TabStop = False
        '
        'MovieName
        '
        Me.MovieName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MovieName.Location = New System.Drawing.Point(266, 30)
        Me.MovieName.Name = "MovieName"
        Me.MovieName.Size = New System.Drawing.Size(304, 40)
        Me.MovieName.TabIndex = 1
        Me.MovieName.Text = "Name"
        Me.MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(30, 393)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(540, 300)
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
        Me.AddRem.Location = New System.Drawing.Point(266, 313)
        Me.AddRem.Name = "AddRem"
        Me.AddRem.Size = New System.Drawing.Size(304, 23)
        Me.AddRem.TabIndex = 4
        Me.AddRem.Text = "Add/Rem"
        Me.AddRem.UseVisualStyleBackColor = True
        '
        'MovieDate
        '
        Me.MovieDate.Location = New System.Drawing.Point(422, 127)
        Me.MovieDate.Name = "MovieDate"
        Me.MovieDate.Size = New System.Drawing.Size(148, 23)
        Me.MovieDate.TabIndex = 5
        Me.MovieDate.Text = "date"
        Me.MovieDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rate
        '
        Me.Rate.Font = New System.Drawing.Font("Trajan Pro 3", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rate.Location = New System.Drawing.Point(266, 81)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(304, 24)
        Me.Rate.TabIndex = 6
        Me.Rate.Text = "rate"
        Me.Rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(314, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Released Date :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(266, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Actors :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'actors
        '
        Me.actors.Location = New System.Drawing.Point(422, 191)
        Me.actors.Name = "actors"
        Me.actors.Size = New System.Drawing.Size(148, 44)
        Me.actors.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(330, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(447, 257)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'MovieGenre
        '
        Me.MovieGenre.Location = New System.Drawing.Point(34, 343)
        Me.MovieGenre.Name = "MovieGenre"
        Me.MovieGenre.Size = New System.Drawing.Size(208, 50)
        Me.MovieGenre.TabIndex = 13
        '
        'CurrentMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 702)
        Me.Controls.Add(Me.MovieGenre)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.actors)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MoPic As PictureBox
    Friend WithEvents MovieName As Label
    Friend WithEvents Description As Label
    Friend WithEvents TopPanel As Panel
    Friend WithEvents CloseMovie As Button
    Friend WithEvents AddRem As Button
    Friend WithEvents MovieDate As Label
    Friend WithEvents Rate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents actors As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MovieGenre As Label
End Class
