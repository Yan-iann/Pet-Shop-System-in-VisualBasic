<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewProd
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
        Me.DgvItemsList = New System.Windows.Forms.DataGridView()
        CType(Me.DgvItemsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvItemsList
        '
        Me.DgvItemsList.AllowUserToAddRows = False
        Me.DgvItemsList.AllowUserToDeleteRows = False
        Me.DgvItemsList.AllowUserToResizeColumns = False
        Me.DgvItemsList.AllowUserToResizeRows = False
        Me.DgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItemsList.Location = New System.Drawing.Point(0, 0)
        Me.DgvItemsList.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvItemsList.MultiSelect = False
        Me.DgvItemsList.Name = "DgvItemsList"
        Me.DgvItemsList.ReadOnly = True
        Me.DgvItemsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItemsList.Size = New System.Drawing.Size(543, 704)
        Me.DgvItemsList.TabIndex = 0
        '
        'FrmViewProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 704)
        Me.Controls.Add(Me.DgvItemsList)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmViewProd"
        Me.Text = "Product List"
        CType(Me.DgvItemsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvItemsList As System.Windows.Forms.DataGridView
End Class
