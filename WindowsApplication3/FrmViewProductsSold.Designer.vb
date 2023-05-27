<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewProductsSold
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
        Me.DgvItemsBought = New System.Windows.Forms.DataGridView()
        CType(Me.DgvItemsBought, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvItemsBought
        '
        Me.DgvItemsBought.AllowUserToAddRows = False
        Me.DgvItemsBought.AllowUserToDeleteRows = False
        Me.DgvItemsBought.AllowUserToResizeColumns = False
        Me.DgvItemsBought.AllowUserToResizeRows = False
        Me.DgvItemsBought.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvItemsBought.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemsBought.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItemsBought.Location = New System.Drawing.Point(0, 0)
        Me.DgvItemsBought.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvItemsBought.MultiSelect = False
        Me.DgvItemsBought.Name = "DgvItemsBought"
        Me.DgvItemsBought.ReadOnly = True
        Me.DgvItemsBought.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvItemsBought.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvItemsBought.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItemsBought.ShowCellErrors = False
        Me.DgvItemsBought.ShowCellToolTips = False
        Me.DgvItemsBought.ShowEditingIcon = False
        Me.DgvItemsBought.ShowRowErrors = False
        Me.DgvItemsBought.Size = New System.Drawing.Size(559, 667)
        Me.DgvItemsBought.TabIndex = 0
        '
        'FrmViewProductsSold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(559, 667)
        Me.Controls.Add(Me.DgvItemsBought)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmViewProductsSold"
        Me.Text = "Products Sold"
        CType(Me.DgvItemsBought, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvItemsBought As System.Windows.Forms.DataGridView
End Class
