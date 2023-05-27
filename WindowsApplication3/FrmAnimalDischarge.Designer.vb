<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnimalDischarge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnimalDischarge))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPetIdAdmit = New System.Windows.Forms.TextBox()
        Me.DTGAdmit = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAdmitNo = New System.Windows.Forms.TextBox()
        Me.TxtDateAdmitted = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnDischarge = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDateDisCharged = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGAdmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(108, 231)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pet ID:"
        '
        'TxtPetIdAdmit
        '
        Me.TxtPetIdAdmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetIdAdmit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetIdAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtPetIdAdmit.ForeColor = System.Drawing.Color.Gray
        Me.TxtPetIdAdmit.Location = New System.Drawing.Point(283, 231)
        Me.TxtPetIdAdmit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetIdAdmit.Name = "TxtPetIdAdmit"
        Me.TxtPetIdAdmit.Size = New System.Drawing.Size(257, 24)
        Me.TxtPetIdAdmit.TabIndex = 3
        '
        'DTGAdmit
        '
        Me.DTGAdmit.AllowUserToAddRows = False
        Me.DTGAdmit.AllowUserToResizeColumns = False
        Me.DTGAdmit.AllowUserToResizeRows = False
        Me.DTGAdmit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGAdmit.BackgroundColor = System.Drawing.Color.White
        Me.DTGAdmit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGAdmit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGAdmit.Location = New System.Drawing.Point(573, 144)
        Me.DTGAdmit.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGAdmit.MultiSelect = False
        Me.DTGAdmit.Name = "DTGAdmit"
        Me.DTGAdmit.ReadOnly = True
        Me.DTGAdmit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGAdmit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGAdmit.Size = New System.Drawing.Size(469, 363)
        Me.DTGAdmit.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(108, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Admit No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(108, 345)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date Admitted:"
        '
        'TxtAdmitNo
        '
        Me.TxtAdmitNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtAdmitNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAdmitNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtAdmitNo.ForeColor = System.Drawing.Color.Gray
        Me.TxtAdmitNo.Location = New System.Drawing.Point(283, 308)
        Me.TxtAdmitNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAdmitNo.Name = "TxtAdmitNo"
        Me.TxtAdmitNo.Size = New System.Drawing.Size(257, 24)
        Me.TxtAdmitNo.TabIndex = 10
        '
        'TxtDateAdmitted
        '
        Me.TxtDateAdmitted.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtDateAdmitted.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDateAdmitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtDateAdmitted.ForeColor = System.Drawing.Color.Gray
        Me.TxtDateAdmitted.Location = New System.Drawing.Point(283, 345)
        Me.TxtDateAdmitted.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDateAdmitted.Name = "TxtDateAdmitted"
        Me.TxtDateAdmitted.Size = New System.Drawing.Size(257, 24)
        Me.TxtDateAdmitted.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(91, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 44)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Discharge Pet"
        '
        'BtnDischarge
        '
        Me.BtnDischarge.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnDischarge.BackgroundImage = CType(resources.GetObject("BtnDischarge.BackgroundImage"), System.Drawing.Image)
        Me.BtnDischarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDischarge.ForeColor = System.Drawing.Color.White
        Me.BtnDischarge.Location = New System.Drawing.Point(380, 484)
        Me.BtnDischarge.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDischarge.Name = "BtnDischarge"
        Me.BtnDischarge.Size = New System.Drawing.Size(160, 52)
        Me.BtnDischarge.TabIndex = 14
        Me.BtnDischarge.Text = "Discharge"
        Me.BtnDischarge.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBack.Location = New System.Drawing.Point(2, 512)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(74, 44)
        Me.BtnBack.TabIndex = 15
        Me.BtnBack.Text = "&Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(108, 271)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Pet Name:"
        '
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtPetName.ForeColor = System.Drawing.Color.Gray
        Me.TxtPetName.Location = New System.Drawing.Point(283, 271)
        Me.TxtPetName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.Size = New System.Drawing.Size(257, 24)
        Me.TxtPetName.TabIndex = 20
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSearch.Location = New System.Drawing.Point(708, 100)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearch.MaxLength = 4
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(257, 24)
        Me.TxtSearch.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(567, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Search Admit No:"
        '
        'TxtDateDisCharged
        '
        Me.TxtDateDisCharged.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtDateDisCharged.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDateDisCharged.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.TxtDateDisCharged.ForeColor = System.Drawing.Color.Black
        Me.TxtDateDisCharged.Location = New System.Drawing.Point(283, 382)
        Me.TxtDateDisCharged.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDateDisCharged.MaxLength = 10
        Me.TxtDateDisCharged.Name = "TxtDateDisCharged"
        Me.TxtDateDisCharged.Size = New System.Drawing.Size(257, 24)
        Me.TxtDateDisCharged.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(108, 382)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Date Discharged:"
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
        'FrmAnimalDischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDateDisCharged)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.TxtPetName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnDischarge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDateAdmitted)
        Me.Controls.Add(Me.TxtAdmitNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTGAdmit)
        Me.Controls.Add(Me.TxtPetIdAdmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAnimalDischarge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database:  Discharge"
        CType(Me.DTGAdmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPetIdAdmit As System.Windows.Forms.TextBox
    Friend WithEvents DTGAdmit As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAdmitNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateAdmitted As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnDischarge As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPetName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDateDisCharged As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
