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
        Me.ButtonLoadTable = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FavoritePanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FavoritePanel
        '
        Me.FavoritePanel.BackColor = System.Drawing.Color.Transparent
        Me.FavoritePanel.Controls.Add(Me.FavoriteLabel)
        Me.FavoritePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FavoritePanel.Location = New System.Drawing.Point(0, 0)
        Me.FavoritePanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FavoritePanel.Name = "FavoritePanel"
        Me.FavoritePanel.Size = New System.Drawing.Size(1463, 447)
        Me.FavoritePanel.TabIndex = 11
        '
        'FavoriteLabel
        '
        Me.FavoriteLabel.BackColor = System.Drawing.Color.Transparent
        Me.FavoriteLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FavoriteLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FavoriteLabel.Location = New System.Drawing.Point(0, 0)
        Me.FavoriteLabel.Name = "FavoriteLabel"
        Me.FavoriteLabel.Size = New System.Drawing.Size(1463, 33)
        Me.FavoriteLabel.TabIndex = 0
        Me.FavoriteLabel.Text = "My Favorite Movies"
        Me.FavoriteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonLoadTable
        '
        Me.ButtonLoadTable.Location = New System.Drawing.Point(622, 919)
        Me.ButtonLoadTable.Name = "ButtonLoadTable"
        Me.ButtonLoadTable.Size = New System.Drawing.Size(94, 29)
        Me.ButtonLoadTable.TabIndex = 2
        Me.ButtonLoadTable.Text = "Load Table"
        Me.ButtonLoadTable.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 733)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(591, 180)
        Me.DataGridView1.TabIndex = 1
        '
        'Favorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1463, 960)
        Me.Controls.Add(Me.ButtonLoadTable)
        Me.Controls.Add(Me.FavoritePanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Favorite"
        Me.Text = "Favorite"
        Me.FavoritePanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FavoritePanel As Panel
    Friend WithEvents FavoriteLabel As Label
    Friend WithEvents ButtonLoadTable As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
