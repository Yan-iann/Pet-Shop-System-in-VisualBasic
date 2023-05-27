<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFeePay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFeePay))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DgvFees = New System.Windows.Forms.DataGridView()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.TxtCustName = New System.Windows.Forms.TextBox()
        Me.TxtCustID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFeeNo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBack.Location = New System.Drawing.Point(2, 521)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(95, 40)
        Me.BtnBack.TabIndex = 52
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnPay
        '
        Me.BtnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPay.BackgroundImage = CType(resources.GetObject("BtnPay.BackgroundImage"), System.Drawing.Image)
        Me.BtnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPay.ForeColor = System.Drawing.Color.White
        Me.BtnPay.Location = New System.Drawing.Point(336, 409)
        Me.BtnPay.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(137, 62)
        Me.BtnPay.TabIndex = 49
        Me.BtnPay.Text = "Pay"
        Me.BtnPay.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(78, 137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 44)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Fee Payment"
        '
        'DgvFees
        '
        Me.DgvFees.AllowUserToAddRows = False
        Me.DgvFees.AllowUserToResizeColumns = False
        Me.DgvFees.AllowUserToResizeRows = False
        Me.DgvFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFees.BackgroundColor = System.Drawing.Color.White
        Me.DgvFees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFees.Location = New System.Drawing.Point(650, 139)
        Me.DgvFees.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvFees.MultiSelect = False
        Me.DgvFees.Name = "DgvFees"
        Me.DgvFees.ReadOnly = True
        Me.DgvFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFees.Size = New System.Drawing.Size(398, 361)
        Me.DgvFees.TabIndex = 47
        '
        'TxtAmount
        '
        Me.TxtAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAmount.Enabled = False
        Me.TxtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.Location = New System.Drawing.Point(287, 347)
        Me.TxtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(232, 24)
        Me.TxtAmount.TabIndex = 46
        '
        'TxtCustName
        '
        Me.TxtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustName.Enabled = False
        Me.TxtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustName.ForeColor = System.Drawing.Color.Black
        Me.TxtCustName.Location = New System.Drawing.Point(287, 304)
        Me.TxtCustName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustName.Name = "TxtCustName"
        Me.TxtCustName.Size = New System.Drawing.Size(232, 24)
        Me.TxtCustName.TabIndex = 45
        '
        'TxtCustID
        '
        Me.TxtCustID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustID.Enabled = False
        Me.TxtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustID.ForeColor = System.Drawing.Color.Black
        Me.TxtCustID.Location = New System.Drawing.Point(287, 259)
        Me.TxtCustID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustID.Name = "TxtCustID"
        Me.TxtCustID.Size = New System.Drawing.Size(232, 24)
        Me.TxtCustID.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(85, 347)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Total Fee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(85, 304)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(85, 259)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(85, 215)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Fee Number:"
        '
        'TxtFeeNo
        '
        Me.TxtFeeNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtFeeNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFeeNo.Enabled = False
        Me.TxtFeeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFeeNo.ForeColor = System.Drawing.Color.Gray
        Me.TxtFeeNo.Location = New System.Drawing.Point(287, 215)
        Me.TxtFeeNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFeeNo.MaxLength = 4
        Me.TxtFeeNo.Name = "TxtFeeNo"
        Me.TxtFeeNo.Size = New System.Drawing.Size(232, 24)
        Me.TxtFeeNo.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1097, 663)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'FrmFeePay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DgvFees)
        Me.Controls.Add(Me.TxtAmount)
        Me.Controls.Add(Me.TxtCustName)
        Me.Controls.Add(Me.TxtCustID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFeeNo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmFeePay"
        Me.Text = "The Pet Shop: Fee Payment"
        CType(Me.DgvFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnPay As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DgvFees As System.Windows.Forms.DataGridView
    Friend WithEvents TxtAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFeeNo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
