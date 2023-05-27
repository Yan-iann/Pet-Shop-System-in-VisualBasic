<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployee))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEmpId = New System.Windows.Forms.TextBox()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtEmpAdd = New System.Windows.Forms.TextBox()
        Me.DTGEmp = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnRegLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(37, 252)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 212)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(37, 293)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(37, 333)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Position:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(37, 410)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Employee Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(37, 371)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Employee Phone No:"
        '
        'TxtEmpId
        '
        Me.TxtEmpId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtEmpId.ForeColor = System.Drawing.Color.Black
        Me.TxtEmpId.Location = New System.Drawing.Point(244, 212)
        Me.TxtEmpId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmpId.MaxLength = 4
        Me.TxtEmpId.Name = "TxtEmpId"
        Me.TxtEmpId.Size = New System.Drawing.Size(296, 24)
        Me.TxtEmpId.TabIndex = 6
        '
        'TxtLName
        '
        Me.TxtLName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtLName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtLName.ForeColor = System.Drawing.Color.Black
        Me.TxtLName.Location = New System.Drawing.Point(244, 252)
        Me.TxtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLName.MaxLength = 20
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(296, 24)
        Me.TxtLName.TabIndex = 7
        '
        'TxtFName
        '
        Me.TxtFName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtFName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtFName.ForeColor = System.Drawing.Color.Black
        Me.TxtFName.Location = New System.Drawing.Point(244, 293)
        Me.TxtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFName.MaxLength = 20
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(296, 24)
        Me.TxtFName.TabIndex = 8
        '
        'TxtPosition
        '
        Me.TxtPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtPosition.ForeColor = System.Drawing.Color.Black
        Me.TxtPosition.Location = New System.Drawing.Point(244, 333)
        Me.TxtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPosition.MaxLength = 20
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(296, 24)
        Me.TxtPosition.TabIndex = 9
        '
        'TxtPhone
        '
        Me.TxtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtPhone.ForeColor = System.Drawing.Color.Black
        Me.TxtPhone.Location = New System.Drawing.Point(244, 371)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPhone.MaxLength = 11
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(296, 24)
        Me.TxtPhone.TabIndex = 10
        '
        'TxtEmpAdd
        '
        Me.TxtEmpAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtEmpAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtEmpAdd.ForeColor = System.Drawing.Color.Black
        Me.TxtEmpAdd.Location = New System.Drawing.Point(244, 410)
        Me.TxtEmpAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmpAdd.MaxLength = 20
        Me.TxtEmpAdd.Name = "TxtEmpAdd"
        Me.TxtEmpAdd.Size = New System.Drawing.Size(296, 24)
        Me.TxtEmpAdd.TabIndex = 11
        '
        'DTGEmp
        '
        Me.DTGEmp.AllowUserToDeleteRows = False
        Me.DTGEmp.AllowUserToResizeColumns = False
        Me.DTGEmp.AllowUserToResizeRows = False
        Me.DTGEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGEmp.BackgroundColor = System.Drawing.Color.White
        Me.DTGEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGEmp.Location = New System.Drawing.Point(572, 141)
        Me.DTGEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGEmp.MultiSelect = False
        Me.DTGEmp.Name = "DTGEmp"
        Me.DTGEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DTGEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGEmp.Size = New System.Drawing.Size(473, 366)
        Me.DTGEmp.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(25, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(425, 44)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Employee Registration"
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegister.BackgroundImage = CType(resources.GetObject("BtnRegister.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.Location = New System.Drawing.Point(234, 450)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(141, 57)
        Me.BtnRegister.TabIndex = 14
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(0, 514)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(80, 45)
        Me.BtnClose.TabIndex = 15
        Me.BtnClose.Text = "&Back"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnRegLogin
        '
        Me.BtnRegLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegLogin.BackgroundImage = CType(resources.GetObject("BtnRegLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRegLogin.Location = New System.Drawing.Point(371, 448)
        Me.BtnRegLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegLogin.Name = "BtnRegLogin"
        Me.BtnRegLogin.Size = New System.Drawing.Size(179, 61)
        Me.BtnRegLogin.TabIndex = 16
        Me.BtnRegLogin.Text = "Register and Add Login Info"
        Me.BtnRegLogin.UseVisualStyleBackColor = False
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
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnRegLogin)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTGEmp)
        Me.Controls.Add(Me.TxtEmpAdd)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtPosition)
        Me.Controls.Add(Me.TxtFName)
        Me.Controls.Add(Me.TxtLName)
        Me.Controls.Add(Me.TxtEmpId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database: Employee Registration"
        CType(Me.DTGEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents TxtLName As System.Windows.Forms.TextBox
    Friend WithEvents TxtFName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPosition As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpAdd As System.Windows.Forms.TextBox
    Friend WithEvents DTGEmp As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnRegLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
