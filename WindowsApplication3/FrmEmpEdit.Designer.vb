<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpEdit))
        Me.DTGEmp = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmpID = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtEmpAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnUpdateLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTGEmp
        '
        Me.DTGEmp.AllowUserToAddRows = False
        Me.DTGEmp.AllowUserToDeleteRows = False
        Me.DTGEmp.AllowUserToResizeColumns = False
        Me.DTGEmp.AllowUserToResizeRows = False
        Me.DTGEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGEmp.BackgroundColor = System.Drawing.Color.White
        Me.DTGEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGEmp.Location = New System.Drawing.Point(572, 137)
        Me.DTGEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGEmp.MultiSelect = False
        Me.DTGEmp.Name = "DTGEmp"
        Me.DTGEmp.ReadOnly = True
        Me.DTGEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DTGEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGEmp.Size = New System.Drawing.Size(473, 368)
        Me.DTGEmp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 193)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID:"
        '
        'TxtEmpID
        '
        Me.TxtEmpID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpID.Enabled = False
        Me.TxtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtEmpID.ForeColor = System.Drawing.Color.Gray
        Me.TxtEmpID.Location = New System.Drawing.Point(245, 192)
        Me.TxtEmpID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmpID.Name = "TxtEmpID"
        Me.TxtEmpID.Size = New System.Drawing.Size(297, 24)
        Me.TxtEmpID.TabIndex = 2
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(229, 458)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(141, 64)
        Me.BtnUpdate.TabIndex = 3
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
        Me.BtnBack.Location = New System.Drawing.Point(2, 511)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(71, 50)
        Me.BtnBack.TabIndex = 4
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(41, 247)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(41, 281)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(41, 313)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Position:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(40, 348)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Employee Phone No:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(41, 383)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Employee Address:"
        '
        'TxtLName
        '
        Me.TxtLName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtLName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtLName.ForeColor = System.Drawing.Color.Black
        Me.TxtLName.Location = New System.Drawing.Point(245, 243)
        Me.TxtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLName.MaxLength = 20
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(297, 24)
        Me.TxtLName.TabIndex = 10
        '
        'TxtFName
        '
        Me.TxtFName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtFName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtFName.ForeColor = System.Drawing.Color.Black
        Me.TxtFName.Location = New System.Drawing.Point(245, 277)
        Me.TxtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFName.MaxLength = 20
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(297, 24)
        Me.TxtFName.TabIndex = 11
        '
        'TxtPosition
        '
        Me.TxtPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtPosition.ForeColor = System.Drawing.Color.Black
        Me.TxtPosition.Location = New System.Drawing.Point(245, 313)
        Me.TxtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPosition.MaxLength = 20
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(297, 24)
        Me.TxtPosition.TabIndex = 12
        '
        'TxtPhone
        '
        Me.TxtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtPhone.ForeColor = System.Drawing.Color.Black
        Me.TxtPhone.Location = New System.Drawing.Point(245, 348)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPhone.MaxLength = 13
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(297, 24)
        Me.TxtPhone.TabIndex = 13
        '
        'TxtEmpAdd
        '
        Me.TxtEmpAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtEmpAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtEmpAdd.ForeColor = System.Drawing.Color.Black
        Me.TxtEmpAdd.Location = New System.Drawing.Point(245, 383)
        Me.TxtEmpAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmpAdd.MaxLength = 20
        Me.TxtEmpAdd.Name = "TxtEmpAdd"
        Me.TxtEmpAdd.Size = New System.Drawing.Size(297, 24)
        Me.TxtEmpAdd.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(34, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(357, 44)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Edit Employee Info"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(562, 103)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Search Last Name:"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSearch.Location = New System.Drawing.Point(717, 99)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(297, 24)
        Me.TxtSearch.TabIndex = 17
        '
        'BtnUpdateLogin
        '
        Me.BtnUpdateLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnUpdateLogin.BackgroundImage = CType(resources.GetObject("BtnUpdateLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdateLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdateLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnUpdateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdateLogin.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateLogin.Location = New System.Drawing.Point(378, 459)
        Me.BtnUpdateLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdateLogin.Name = "BtnUpdateLogin"
        Me.BtnUpdateLogin.Size = New System.Drawing.Size(164, 63)
        Me.BtnUpdateLogin.TabIndex = 18
        Me.BtnUpdateLogin.Text = "Update and Add Login Info"
        Me.BtnUpdateLogin.UseVisualStyleBackColor = False
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
        'FrmEmpEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnUpdateLogin)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtEmpAdd)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtPosition)
        Me.Controls.Add(Me.TxtFName)
        Me.Controls.Add(Me.TxtLName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TxtEmpID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTGEmp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEmpEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database: Edit Employee"
        CType(Me.DTGEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTGEmp As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtLName As System.Windows.Forms.TextBox
    Friend WithEvents TxtFName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPosition As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdateLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
