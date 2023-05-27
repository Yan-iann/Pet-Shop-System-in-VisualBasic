<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustomerId = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TxtCustomerAdd = New System.Windows.Forms.TextBox()
        Me.TxtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.DTGCustomer = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 277)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 328)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(30, 379)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer Phone No:"
        '
        'TxtCustomerId
        '
        Me.TxtCustomerId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerId.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerId.Location = New System.Drawing.Point(232, 223)
        Me.TxtCustomerId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerId.Name = "TxtCustomerId"
        Me.TxtCustomerId.Size = New System.Drawing.Size(309, 22)
        Me.TxtCustomerId.TabIndex = 4
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerName.Location = New System.Drawing.Point(232, 277)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(309, 22)
        Me.TxtCustomerName.TabIndex = 5
        '
        'TxtCustomerAdd
        '
        Me.TxtCustomerAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerAdd.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerAdd.Location = New System.Drawing.Point(232, 328)
        Me.TxtCustomerAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerAdd.Name = "TxtCustomerAdd"
        Me.TxtCustomerAdd.Size = New System.Drawing.Size(309, 22)
        Me.TxtCustomerAdd.TabIndex = 6
        '
        'TxtCustomerPhone
        '
        Me.TxtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerPhone.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerPhone.Location = New System.Drawing.Point(232, 379)
        Me.TxtCustomerPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerPhone.Name = "TxtCustomerPhone"
        Me.TxtCustomerPhone.Size = New System.Drawing.Size(309, 22)
        Me.TxtCustomerPhone.TabIndex = 7
        '
        'DTGCustomer
        '
        Me.DTGCustomer.AllowUserToResizeColumns = False
        Me.DTGCustomer.AllowUserToResizeRows = False
        Me.DTGCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGCustomer.BackgroundColor = System.Drawing.Color.White
        Me.DTGCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGCustomer.Location = New System.Drawing.Point(572, 143)
        Me.DTGCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGCustomer.MultiSelect = False
        Me.DTGCustomer.Name = "DTGCustomer"
        Me.DTGCustomer.ReadOnly = True
        Me.DTGCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGCustomer.Size = New System.Drawing.Size(472, 361)
        Me.DTGCustomer.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(18, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(421, 44)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Customer Registration"
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegister.BackgroundImage = CType(resources.GetObject("BtnRegister.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.Location = New System.Drawing.Point(244, 427)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(150, 54)
        Me.BtnRegister.TabIndex = 10
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(2, 502)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(89, 56)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "&Back"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRefresh.BackgroundImage = CType(resources.GetObject("BtnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRefresh.Location = New System.Drawing.Point(391, 426)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(134, 57)
        Me.BtnRefresh.TabIndex = 13
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1097, 663)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTGCustomer)
        Me.Controls.Add(Me.TxtCustomerPhone)
        Me.Controls.Add(Me.TxtCustomerAdd)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.TxtCustomerId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database: Customer Registration"
        CType(Me.DTGCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerPhone As System.Windows.Forms.TextBox
    Friend WithEvents DTGCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
