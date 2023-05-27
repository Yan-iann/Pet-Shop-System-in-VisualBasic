<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuVet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuVet))
        Me.BtnPetDiagnose = New System.Windows.Forms.Button()
        Me.DgvPetInShop = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnAdmitUpdate = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DgvPetInShop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPetDiagnose
        '
        Me.BtnPetDiagnose.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetDiagnose.BackgroundImage = CType(resources.GetObject("BtnPetDiagnose.BackgroundImage"), System.Drawing.Image)
        Me.BtnPetDiagnose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPetDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPetDiagnose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPetDiagnose.ForeColor = System.Drawing.Color.White
        Me.BtnPetDiagnose.Location = New System.Drawing.Point(149, 117)
        Me.BtnPetDiagnose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPetDiagnose.Name = "BtnPetDiagnose"
        Me.BtnPetDiagnose.Size = New System.Drawing.Size(243, 94)
        Me.BtnPetDiagnose.TabIndex = 0
        Me.BtnPetDiagnose.Text = "Diagnose Pet"
        Me.BtnPetDiagnose.UseVisualStyleBackColor = False
        '
        'DgvPetInShop
        '
        Me.DgvPetInShop.AllowUserToAddRows = False
        Me.DgvPetInShop.AllowUserToDeleteRows = False
        Me.DgvPetInShop.AllowUserToResizeColumns = False
        Me.DgvPetInShop.AllowUserToResizeRows = False
        Me.DgvPetInShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPetInShop.BackgroundColor = System.Drawing.Color.White
        Me.DgvPetInShop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPetInShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPetInShop.Location = New System.Drawing.Point(544, 106)
        Me.DgvPetInShop.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvPetInShop.MultiSelect = False
        Me.DgvPetInShop.Name = "DgvPetInShop"
        Me.DgvPetInShop.ReadOnly = True
        Me.DgvPetInShop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvPetInShop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvPetInShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPetInShop.Size = New System.Drawing.Size(501, 445)
        Me.DgvPetInShop.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(149, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 82)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Discharge Pet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(528, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pets Currently Admitted"
        '
        'BtnLogout
        '
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnLogout.Location = New System.Drawing.Point(179, 508)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(180, 68)
        Me.BtnLogout.TabIndex = 11
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1099, 664)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(-1, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 68)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnAdmitUpdate
        '
        Me.BtnAdmitUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnAdmitUpdate.BackgroundImage = CType(resources.GetObject("BtnAdmitUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdmitUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdmitUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmitUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAdmitUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnAdmitUpdate.Location = New System.Drawing.Point(149, 309)
        Me.BtnAdmitUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdmitUpdate.Name = "BtnAdmitUpdate"
        Me.BtnAdmitUpdate.Size = New System.Drawing.Size(243, 94)
        Me.BtnAdmitUpdate.TabIndex = 26
        Me.BtnAdmitUpdate.Text = "Update Admissions"
        Me.BtnAdmitUpdate.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(104, 422)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 70)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Charge Fee"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(271, 422)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 70)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Update/Delete Fee"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FrmMenuVet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnAdmitUpdate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvPetInShop)
        Me.Controls.Add(Me.BtnPetDiagnose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuVet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database: Vet Menu"
        CType(Me.DgvPetInShop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPetDiagnose As System.Windows.Forms.Button
    Friend WithEvents DgvPetInShop As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnAdmitUpdate As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
