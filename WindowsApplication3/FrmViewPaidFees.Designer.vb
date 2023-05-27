<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewPaidFees
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
        Me.DgvFees = New System.Windows.Forms.DataGridView()
        CType(Me.DgvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvFees
        '
        Me.DgvFees.AllowUserToAddRows = False
        Me.DgvFees.AllowUserToDeleteRows = False
        Me.DgvFees.AllowUserToResizeColumns = False
        Me.DgvFees.AllowUserToResizeRows = False
        Me.DgvFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFees.Location = New System.Drawing.Point(0, 0)
        Me.DgvFees.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvFees.MultiSelect = False
        Me.DgvFees.Name = "DgvFees"
        Me.DgvFees.ReadOnly = True
        Me.DgvFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvFees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFees.ShowCellErrors = False
        Me.DgvFees.ShowCellToolTips = False
        Me.DgvFees.ShowEditingIcon = False
        Me.DgvFees.ShowRowErrors = False
        Me.DgvFees.Size = New System.Drawing.Size(494, 696)
        Me.DgvFees.TabIndex = 1
        '
        'FrmViewPaidFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 696)
        Me.Controls.Add(Me.DgvFees)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmViewPaidFees"
        Me.Text = "FrmViewPaidFees"
        CType(Me.DgvFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvFees As System.Windows.Forms.DataGridView
End Class
