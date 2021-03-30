<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoviesMain
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
        Me.Top1 = New System.Windows.Forms.Label()
        Me.Top2 = New System.Windows.Forms.Label()
        Me.Top3 = New System.Windows.Forms.Label()
        Me.Top4 = New System.Windows.Forms.Label()
        Me.Top5 = New System.Windows.Forms.Label()
        Me.Top9 = New System.Windows.Forms.Label()
        Me.Top8 = New System.Windows.Forms.Label()
        Me.Top7 = New System.Windows.Forms.Label()
        Me.Top6 = New System.Windows.Forms.Label()
        Me.Top10 = New System.Windows.Forms.Label()
        Me.TopMoviesPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TopMoviesLabel = New System.Windows.Forms.Label()
        Me.AllMoviesPanel = New System.Windows.Forms.Panel()
        Me.FilterPanel = New System.Windows.Forms.Panel()
        Me.sortRate = New System.Windows.Forms.Button()
        Me.sortDate = New System.Windows.Forms.Button()
        Me.SortLabel = New System.Windows.Forms.Label()
        Me.SortName = New System.Windows.Forms.Button()
        Me.AllMoviesLabel = New System.Windows.Forms.Label()
        Me.TopMoviesPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AllMoviesPanel.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Top1
        '
        Me.Top1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top1.Location = New System.Drawing.Point(20, 50)
        Me.Top1.Name = "Top1"
        Me.Top1.Size = New System.Drawing.Size(190, 250)
        Me.Top1.TabIndex = 0
        '
        'Top2
        '
        Me.Top2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top2.Location = New System.Drawing.Point(270, 50)
        Me.Top2.Margin = New System.Windows.Forms.Padding(3)
        Me.Top2.Name = "Top2"
        Me.Top2.Size = New System.Drawing.Size(190, 250)
        Me.Top2.TabIndex = 1
        '
        'Top3
        '
        Me.Top3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top3.Location = New System.Drawing.Point(520, 50)
        Me.Top3.Name = "Top3"
        Me.Top3.Size = New System.Drawing.Size(200, 250)
        Me.Top3.TabIndex = 2
        '
        'Top4
        '
        Me.Top4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top4.Location = New System.Drawing.Point(770, 50)
        Me.Top4.Name = "Top4"
        Me.Top4.Size = New System.Drawing.Size(200, 250)
        Me.Top4.TabIndex = 3
        '
        'Top5
        '
        Me.Top5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top5.Location = New System.Drawing.Point(1020, 50)
        Me.Top5.Name = "Top5"
        Me.Top5.Size = New System.Drawing.Size(200, 250)
        Me.Top5.TabIndex = 4
        '
        'Top9
        '
        Me.Top9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top9.Location = New System.Drawing.Point(770, 325)
        Me.Top9.Name = "Top9"
        Me.Top9.Size = New System.Drawing.Size(200, 250)
        Me.Top9.TabIndex = 8
        '
        'Top8
        '
        Me.Top8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top8.Location = New System.Drawing.Point(520, 325)
        Me.Top8.Name = "Top8"
        Me.Top8.Size = New System.Drawing.Size(200, 250)
        Me.Top8.TabIndex = 7
        '
        'Top7
        '
        Me.Top7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top7.Location = New System.Drawing.Point(270, 325)
        Me.Top7.Margin = New System.Windows.Forms.Padding(3)
        Me.Top7.Name = "Top7"
        Me.Top7.Size = New System.Drawing.Size(190, 250)
        Me.Top7.TabIndex = 6
        '
        'Top6
        '
        Me.Top6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top6.Location = New System.Drawing.Point(20, 325)
        Me.Top6.Name = "Top6"
        Me.Top6.Size = New System.Drawing.Size(190, 250)
        Me.Top6.TabIndex = 5
        '
        'Top10
        '
        Me.Top10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Top10.Location = New System.Drawing.Point(1020, 325)
        Me.Top10.Name = "Top10"
        Me.Top10.Size = New System.Drawing.Size(200, 250)
        Me.Top10.TabIndex = 9
        '
        'TopMoviesPanel
        '
        Me.TopMoviesPanel.AutoSize = True
        Me.TopMoviesPanel.Controls.Add(Me.Panel1)
        Me.TopMoviesPanel.Controls.Add(Me.Top10)
        Me.TopMoviesPanel.Controls.Add(Me.Top9)
        Me.TopMoviesPanel.Controls.Add(Me.Top8)
        Me.TopMoviesPanel.Controls.Add(Me.Top7)
        Me.TopMoviesPanel.Controls.Add(Me.Top6)
        Me.TopMoviesPanel.Controls.Add(Me.Top5)
        Me.TopMoviesPanel.Controls.Add(Me.Top4)
        Me.TopMoviesPanel.Controls.Add(Me.Top3)
        Me.TopMoviesPanel.Controls.Add(Me.Top2)
        Me.TopMoviesPanel.Controls.Add(Me.Top1)
        Me.TopMoviesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMoviesPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopMoviesPanel.Name = "TopMoviesPanel"
        Me.TopMoviesPanel.Size = New System.Drawing.Size(1316, 578)
        Me.TopMoviesPanel.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TopMoviesLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1316, 45)
        Me.Panel1.TabIndex = 10
        '
        'TopMoviesLabel
        '
        Me.TopMoviesLabel.AutoSize = True
        Me.TopMoviesLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TopMoviesLabel.Location = New System.Drawing.Point(20, 9)
        Me.TopMoviesLabel.Name = "TopMoviesLabel"
        Me.TopMoviesLabel.Size = New System.Drawing.Size(110, 21)
        Me.TopMoviesLabel.TabIndex = 0
        Me.TopMoviesLabel.Text = "Top 10 Movies"
        '
        'AllMoviesPanel
        '
        Me.AllMoviesPanel.Controls.Add(Me.FilterPanel)
        Me.AllMoviesPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AllMoviesPanel.Location = New System.Drawing.Point(0, 578)
        Me.AllMoviesPanel.Name = "AllMoviesPanel"
        Me.AllMoviesPanel.Size = New System.Drawing.Size(1316, 500)
        Me.AllMoviesPanel.TabIndex = 11
        '
        'FilterPanel
        '
        Me.FilterPanel.AutoScroll = True
        Me.FilterPanel.Controls.Add(Me.sortRate)
        Me.FilterPanel.Controls.Add(Me.sortDate)
        Me.FilterPanel.Controls.Add(Me.SortLabel)
        Me.FilterPanel.Controls.Add(Me.SortName)
        Me.FilterPanel.Controls.Add(Me.AllMoviesLabel)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(1316, 81)
        Me.FilterPanel.TabIndex = 2
        '
        'sortRate
        '
        Me.sortRate.Location = New System.Drawing.Point(279, 52)
        Me.sortRate.Name = "sortRate"
        Me.sortRate.Size = New System.Drawing.Size(90, 23)
        Me.sortRate.TabIndex = 4
        Me.sortRate.Text = "Rate"
        Me.sortRate.UseVisualStyleBackColor = True
        '
        'sortDate
        '
        Me.sortDate.Location = New System.Drawing.Point(183, 52)
        Me.sortDate.Name = "sortDate"
        Me.sortDate.Size = New System.Drawing.Size(90, 23)
        Me.sortDate.TabIndex = 3
        Me.sortDate.Text = "Date"
        Me.sortDate.UseVisualStyleBackColor = True
        '
        'SortLabel
        '
        Me.SortLabel.AutoSize = True
        Me.SortLabel.Location = New System.Drawing.Point(20, 56)
        Me.SortLabel.Name = "SortLabel"
        Me.SortLabel.Size = New System.Drawing.Size(44, 15)
        Me.SortLabel.TabIndex = 2
        Me.SortLabel.Text = "Sort By"
        '
        'SortName
        '
        Me.SortName.Location = New System.Drawing.Point(87, 52)
        Me.SortName.Name = "SortName"
        Me.SortName.Size = New System.Drawing.Size(90, 23)
        Me.SortName.TabIndex = 1
        Me.SortName.Text = "Name A->Z"
        Me.SortName.UseVisualStyleBackColor = True
        '
        'AllMoviesLabel
        '
        Me.AllMoviesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AllMoviesLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AllMoviesLabel.Location = New System.Drawing.Point(0, 0)
        Me.AllMoviesLabel.Name = "AllMoviesLabel"
        Me.AllMoviesLabel.Size = New System.Drawing.Size(1316, 49)
        Me.AllMoviesLabel.TabIndex = 0
        Me.AllMoviesLabel.Text = "More movies"
        Me.AllMoviesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AllMoviesLabel.UseWaitCursor = True
        '
        'MoviesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1333, 609)
        Me.Controls.Add(Me.AllMoviesPanel)
        Me.Controls.Add(Me.TopMoviesPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MoviesMain"
        Me.TopMoviesPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AllMoviesPanel.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Top1 As Label
    Friend WithEvents Top2 As Label
    Friend WithEvents Top3 As Label
    Friend WithEvents Top4 As Label
    Friend WithEvents Top5 As Label
    Friend WithEvents Top9 As Label
    Friend WithEvents Top8 As Label
    Friend WithEvents Top7 As Label
    Friend WithEvents Top6 As Label
    Friend WithEvents Top10 As Label
    Friend WithEvents TopMoviesPanel As Panel
    Friend WithEvents AllMoviesPanel As Panel
    Friend WithEvents FilterPanel As Panel
    Friend WithEvents SortLabel As Label
    Friend WithEvents SortName As Button
    Friend WithEvents AllMoviesLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TopMoviesLabel As Label
    Friend WithEvents sortDate As Button
    Friend WithEvents sortRate As Button
End Class
