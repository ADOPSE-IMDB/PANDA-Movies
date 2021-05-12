<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultForm
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
        Me.SLabel = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'SLabel
        '
        Me.SLabel.BackColor = System.Drawing.Color.DarkGray
        Me.SLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SLabel.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SLabel.Location = New System.Drawing.Point(0, 0)
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(1278, 46)
        Me.SLabel.TabIndex = 0
        Me.SLabel.Text = "Search Results for : "
        Me.SLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'result
        '
        Me.result.Dock = System.Windows.Forms.DockStyle.Top
        Me.result.Location = New System.Drawing.Point(0, 46)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(1278, 100)
        Me.result.TabIndex = 1
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.SLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SearchForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents SLabel As Label
    Friend WithEvents result As Panel
End Class
