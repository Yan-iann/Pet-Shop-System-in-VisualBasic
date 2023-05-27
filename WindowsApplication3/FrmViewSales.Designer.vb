<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDgvPurchases
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
        Me.DgvPurchases = New System.Windows.Forms.DataGridView()
        CType(Me.DgvPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvPurchases
        '
        Me.DgvPurchases.AllowUserToAddRows = False
        Me.DgvPurchases.AllowUserToDeleteRows = False
        Me.DgvPurchases.AllowUserToResizeColumns = False
        Me.DgvPurchases.AllowUserToResizeRows = False
        Me.DgvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPurchases.Location = New System.Drawing.Point(0, 0)
        Me.DgvPurchases.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvPurchases.MultiSelect = False
        Me.DgvPurchases.Name = "DgvPurchases"
        Me.DgvPurchases.ReadOnly = True
        Me.DgvPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPurchases.ShowCellErrors = False
        Me.DgvPurchases.ShowCellToolTips = False
        Me.DgvPurchases.ShowEditingIcon = False
        Me.DgvPurchases.ShowRowErrors = False
        Me.DgvPurchases.Size = New System.Drawing.Size(517, 685)
        Me.DgvPurchases.TabIndex = 0
        '
        'FrmDgvPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 685)
        Me.Controls.Add(Me.DgvPurchases)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmDgvPurchases"
        Me.Text = "Sales"
        CType(Me.DgvPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvPurchases As System.Windows.Forms.DataGridView
End Class
