<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerEdit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCustomerId = New System.Windows.Forms.TextBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TxtCustomerAdd = New System.Windows.Forms.TextBox()
        Me.TxtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.DTGCustomer = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(44, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Customer Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(563, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(50, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(50, 298)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(50, 341)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Customer Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(50, 383)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Customer Phone No:"
        '
        'TxtCustomerId
        '
        Me.TxtCustomerId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtCustomerId.ForeColor = System.Drawing.Color.Gray
        Me.TxtCustomerId.Location = New System.Drawing.Point(298, 201)
        Me.TxtCustomerId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerId.Name = "TxtCustomerId"
        Me.TxtCustomerId.Size = New System.Drawing.Size(246, 24)
        Me.TxtCustomerId.TabIndex = 6
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSearch.Location = New System.Drawing.Point(758, 98)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(246, 24)
        Me.TxtSearch.TabIndex = 7
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtCustomerName.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerName.Location = New System.Drawing.Point(298, 298)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(246, 24)
        Me.TxtCustomerName.TabIndex = 8
        '
        'TxtCustomerAdd
        '
        Me.TxtCustomerAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtCustomerAdd.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerAdd.Location = New System.Drawing.Point(298, 341)
        Me.TxtCustomerAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerAdd.Name = "TxtCustomerAdd"
        Me.TxtCustomerAdd.Size = New System.Drawing.Size(246, 24)
        Me.TxtCustomerAdd.TabIndex = 9
        '
        'TxtCustomerPhone
        '
        Me.TxtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtCustomerPhone.ForeColor = System.Drawing.Color.Black
        Me.TxtCustomerPhone.Location = New System.Drawing.Point(298, 383)
        Me.TxtCustomerPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustomerPhone.Name = "TxtCustomerPhone"
        Me.TxtCustomerPhone.Size = New System.Drawing.Size(246, 24)
        Me.TxtCustomerPhone.TabIndex = 10
        '
        'DTGCustomer
        '
        Me.DTGCustomer.AllowUserToAddRows = False
        Me.DTGCustomer.AllowUserToDeleteRows = False
        Me.DTGCustomer.AllowUserToResizeColumns = False
        Me.DTGCustomer.AllowUserToResizeRows = False
        Me.DTGCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGCustomer.BackgroundColor = System.Drawing.Color.White
        Me.DTGCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGCustomer.Location = New System.Drawing.Point(572, 141)
        Me.DTGCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGCustomer.MultiSelect = False
        Me.DTGCustomer.Name = "DTGCustomer"
        Me.DTGCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DTGCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGCustomer.Size = New System.Drawing.Size(470, 367)
        Me.DTGCustomer.TabIndex = 11
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(411, 433)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(142, 51)
        Me.BtnUpdate.TabIndex = 12
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBack.Location = New System.Drawing.Point(2, 507)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(78, 52)
        Me.BtnBack.TabIndex = 14
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
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
        'FrmCustomerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DTGCustomer)
        Me.Controls.Add(Me.TxtCustomerPhone)
        Me.Controls.Add(Me.TxtCustomerAdd)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.TxtCustomerId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCustomerEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database: Customer Edit"
        CType(Me.DTGCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerPhone As System.Windows.Forms.TextBox
    Friend WithEvents DTGCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
