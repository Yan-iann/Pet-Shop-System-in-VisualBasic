<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPetRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPetRegistration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPetId = New System.Windows.Forms.TextBox()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.TxtAnimalType = New System.Windows.Forms.TextBox()
        Me.TxtOwnerId = New System.Windows.Forms.TextBox()
        Me.DTGPet = New System.Windows.Forms.DataGridView()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtOwnerName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGPet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(79, 141)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pet Registration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(85, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pet ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(85, 258)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pet Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(85, 301)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Animal Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(85, 350)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Owner ID:"
        '
        'TxtPetId
        '
        Me.TxtPetId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetId.ForeColor = System.Drawing.Color.Black
        Me.TxtPetId.Location = New System.Drawing.Point(233, 213)
        Me.TxtPetId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetId.MaxLength = 4
        Me.TxtPetId.Name = "TxtPetId"
        Me.TxtPetId.Size = New System.Drawing.Size(301, 19)
        Me.TxtPetId.TabIndex = 5
        '
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetName.ForeColor = System.Drawing.Color.Black
        Me.TxtPetName.Location = New System.Drawing.Point(233, 255)
        Me.TxtPetName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetName.MaxLength = 20
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.Size = New System.Drawing.Size(301, 19)
        Me.TxtPetName.TabIndex = 6
        '
        'TxtAnimalType
        '
        Me.TxtAnimalType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtAnimalType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAnimalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnimalType.ForeColor = System.Drawing.Color.Black
        Me.TxtAnimalType.Location = New System.Drawing.Point(233, 301)
        Me.TxtAnimalType.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAnimalType.MaxLength = 20
        Me.TxtAnimalType.Name = "TxtAnimalType"
        Me.TxtAnimalType.Size = New System.Drawing.Size(301, 19)
        Me.TxtAnimalType.TabIndex = 7
        '
        'TxtOwnerId
        '
        Me.TxtOwnerId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtOwnerId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOwnerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOwnerId.ForeColor = System.Drawing.Color.Black
        Me.TxtOwnerId.Location = New System.Drawing.Point(233, 347)
        Me.TxtOwnerId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOwnerId.MaxLength = 4
        Me.TxtOwnerId.Name = "TxtOwnerId"
        Me.TxtOwnerId.Size = New System.Drawing.Size(301, 19)
        Me.TxtOwnerId.TabIndex = 8
        '
        'DTGPet
        '
        Me.DTGPet.AllowUserToDeleteRows = False
        Me.DTGPet.AllowUserToResizeColumns = False
        Me.DTGPet.AllowUserToResizeRows = False
        Me.DTGPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGPet.BackgroundColor = System.Drawing.Color.White
        Me.DTGPet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGPet.Location = New System.Drawing.Point(570, 138)
        Me.DTGPet.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGPet.MultiSelect = False
        Me.DTGPet.Name = "DTGPet"
        Me.DTGPet.ReadOnly = True
        Me.DTGPet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGPet.Size = New System.Drawing.Size(471, 368)
        Me.DTGPet.TabIndex = 9
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegister.BackgroundImage = CType(resources.GetObject("BtnRegister.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegister.Location = New System.Drawing.Point(405, 438)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(138, 59)
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
        Me.BtnExit.Location = New System.Drawing.Point(13, 520)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(95, 40)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "&Back"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(85, 397)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Owner Name:"
        '
        'TxtOwnerName
        '
        Me.TxtOwnerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOwnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOwnerName.ForeColor = System.Drawing.Color.Gray
        Me.TxtOwnerName.Location = New System.Drawing.Point(233, 397)
        Me.TxtOwnerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOwnerName.Name = "TxtOwnerName"
        Me.TxtOwnerName.Size = New System.Drawing.Size(301, 19)
        Me.TxtOwnerName.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1097, 663)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FrmPetRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtOwnerName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.DTGPet)
        Me.Controls.Add(Me.TxtOwnerId)
        Me.Controls.Add(Me.TxtAnimalType)
        Me.Controls.Add(Me.TxtPetName)
        Me.Controls.Add(Me.TxtPetId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPetRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPetRegistration"
        CType(Me.DTGPet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPetId As System.Windows.Forms.TextBox
    Friend WithEvents TxtPetName As System.Windows.Forms.TextBox
    Friend WithEvents TxtAnimalType As System.Windows.Forms.TextBox
    Friend WithEvents TxtOwnerId As System.Windows.Forms.TextBox
    Friend WithEvents DTGPet As System.Windows.Forms.DataGridView
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
End Class
