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
        Me.FavoriteLabel = New System.Windows.Forms.Label()
        Me.FavoritePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FavoritePanel
        '
        Me.FavoritePanel.BackColor = System.Drawing.Color.Transparent
        Me.FavoritePanel.Controls.Add(Me.FavoriteLabel)
        Me.FavoritePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FavoritePanel.Location = New System.Drawing.Point(0, 0)
        Me.FavoritePanel.Name = "FavoritePanel"
        Me.FavoritePanel.Size = New System.Drawing.Size(1280, 335)
        Me.FavoritePanel.TabIndex = 11
        '
        'FavoriteLabel
        '
        Me.FavoriteLabel.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FavoriteLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FavoriteLabel.Location = New System.Drawing.Point(0, 0)
        Me.FavoriteLabel.Name = "FavoriteLabel"
        Me.FavoriteLabel.Size = New System.Drawing.Size(1280, 25)
        Me.FavoriteLabel.TabIndex = 0
        Me.FavoriteLabel.Text = "My Favorite Movies"
        Me.FavoriteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Favorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.FavoritePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Favorite"
        Me.Text = "Favorite"
        Me.FavoritePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FavoritePanel As Panel
    Friend WithEvents FavoriteLabel As Label
End Class
