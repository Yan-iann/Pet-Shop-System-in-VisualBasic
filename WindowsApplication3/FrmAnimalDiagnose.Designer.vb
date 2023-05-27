<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnimalDiagnose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnimalDiagnose))
        Me.DTGPetData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTGDiagnosisData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPetId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPetOwner = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDiagNo = New System.Windows.Forms.TextBox()
        Me.TxtDateDiag = New System.Windows.Forms.TextBox()
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPetNum = New System.Windows.Forms.TextBox()
        Me.BtnAdmit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DTGPetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGDiagnosisData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTGPetData
        '
        Me.DTGPetData.AllowUserToAddRows = False
        Me.DTGPetData.AllowUserToDeleteRows = False
        Me.DTGPetData.AllowUserToResizeColumns = False
        Me.DTGPetData.AllowUserToResizeRows = False
        Me.DTGPetData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGPetData.BackgroundColor = System.Drawing.Color.White
        Me.DTGPetData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGPetData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGPetData.Location = New System.Drawing.Point(32, 191)
        Me.DTGPetData.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGPetData.MultiSelect = False
        Me.DTGPetData.Name = "DTGPetData"
        Me.DTGPetData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGPetData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGPetData.Size = New System.Drawing.Size(308, 292)
        Me.DTGPetData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(48, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pets In The Shop"
        '
        'DTGDiagnosisData
        '
        Me.DTGDiagnosisData.AllowUserToResizeColumns = False
        Me.DTGDiagnosisData.AllowUserToResizeRows = False
        Me.DTGDiagnosisData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGDiagnosisData.BackgroundColor = System.Drawing.Color.White
        Me.DTGDiagnosisData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGDiagnosisData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGDiagnosisData.Location = New System.Drawing.Point(762, 191)
        Me.DTGDiagnosisData.Margin = New System.Windows.Forms.Padding(4)
        Me.DTGDiagnosisData.MultiSelect = False
        Me.DTGDiagnosisData.Name = "DTGDiagnosisData"
        Me.DTGDiagnosisData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGDiagnosisData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGDiagnosisData.Size = New System.Drawing.Size(310, 292)
        Me.DTGDiagnosisData.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(456, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pet ID:"
        '
        'TxtPetId
        '
        Me.TxtPetId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPetId.Location = New System.Drawing.Point(537, 30)
        Me.TxtPetId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetId.Name = "TxtPetId"
        Me.TxtPetId.Size = New System.Drawing.Size(181, 20)
        Me.TxtPetId.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(425, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pet Owner:"
        '
        'TxtPetOwner
        '
        Me.TxtPetOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetOwner.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPetOwner.Location = New System.Drawing.Point(537, 66)
        Me.TxtPetOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetOwner.Name = "TxtPetOwner"
        Me.TxtPetOwner.Size = New System.Drawing.Size(181, 20)
        Me.TxtPetOwner.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(384, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Examination No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(383, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date Examined:"
        '
        'TxtDiagNo
        '
        Me.TxtDiagNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtDiagNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDiagNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtDiagNo.Location = New System.Drawing.Point(537, 100)
        Me.TxtDiagNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiagNo.MaxLength = 4
        Me.TxtDiagNo.Name = "TxtDiagNo"
        Me.TxtDiagNo.Size = New System.Drawing.Size(181, 20)
        Me.TxtDiagNo.TabIndex = 11
        '
        'TxtDateDiag
        '
        Me.TxtDateDiag.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtDateDiag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDateDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtDateDiag.Location = New System.Drawing.Point(537, 136)
        Me.TxtDateDiag.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDateDiag.MaxLength = 10
        Me.TxtDateDiag.Name = "TxtDateDiag"
        Me.TxtDateDiag.Size = New System.Drawing.Size(181, 20)
        Me.TxtDateDiag.TabIndex = 12
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtDiagnosis.ForeColor = System.Drawing.Color.Black
        Me.TxtDiagnosis.Location = New System.Drawing.Point(385, 196)
        Me.TxtDiagnosis.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiagnosis.MaxLength = 99
        Me.TxtDiagnosis.Multiline = True
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(347, 320)
        Me.TxtDiagnosis.TabIndex = 13
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnSubmit.BackgroundImage = CType(resources.GetObject("BtnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.BtnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnSubmit.Location = New System.Drawing.Point(405, 525)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(100, 39)
        Me.BtnSubmit.TabIndex = 14
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(3, 574)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 61)
        Me.BtnExit.TabIndex = 15
        Me.BtnExit.Text = "&Back"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(915, 509)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(165, 53)
        Me.BtnDelete.TabIndex = 16
        Me.BtnDelete.Text = "Delete Diagnosis"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(797, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 31)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Diagnosis Board"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtSearch.Location = New System.Drawing.Point(172, 134)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(168, 20)
        Me.TxtSearch.TabIndex = 19
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(513, 524)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(103, 39)
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(778, 136)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Search Pet ID:"
        '
        'TxtPetNum
        '
        Me.TxtPetNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtPetNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPetNum.Location = New System.Drawing.Point(922, 136)
        Me.TxtPetNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPetNum.Name = "TxtPetNum"
        Me.TxtPetNum.Size = New System.Drawing.Size(158, 20)
        Me.TxtPetNum.TabIndex = 23
        '
        'BtnAdmit
        '
        Me.BtnAdmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnAdmit.BackgroundImage = CType(resources.GetObject("BtnAdmit.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold)
        Me.BtnAdmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnAdmit.Location = New System.Drawing.Point(624, 524)
        Me.BtnAdmit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdmit.Name = "BtnAdmit"
        Me.BtnAdmit.Size = New System.Drawing.Size(101, 40)
        Me.BtnAdmit.TabIndex = 24
        Me.BtnAdmit.Text = "Admit"
        Me.BtnAdmit.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(28, 136)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Search Pet ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1097, 663)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(383, 173)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Diagnosis:"
        '
        'FrmAnimalDiagnose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnAdmit)
        Me.Controls.Add(Me.TxtPetNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtDiagnosis)
        Me.Controls.Add(Me.TxtDateDiag)
        Me.Controls.Add(Me.TxtDiagNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPetOwner)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPetId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTGDiagnosisData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTGPetData)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAnimalDiagnose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database: Animal Examinations"
        CType(Me.DTGPetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGDiagnosisData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTGPetData As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTGDiagnosisData As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPetId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPetOwner As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDiagNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateDiag As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtPetNum As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdmit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
