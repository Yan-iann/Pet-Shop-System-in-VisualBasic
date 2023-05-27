<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuClerk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuClerk))
        Me.BtnCustNew = New System.Windows.Forms.Button()
        Me.BtnCustEdit = New System.Windows.Forms.Button()
        Me.BtnCustDelete = New System.Windows.Forms.Button()
        Me.BtnPetNew = New System.Windows.Forms.Button()
        Me.BtnPetEdit = New System.Windows.Forms.Button()
        Me.BtnPetDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCustNew
        '
        Me.BtnCustNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnCustNew.BackgroundImage = CType(resources.GetObject("BtnCustNew.BackgroundImage"), System.Drawing.Image)
        Me.BtnCustNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustNew.ForeColor = System.Drawing.Color.White
        Me.BtnCustNew.Location = New System.Drawing.Point(254, 119)
        Me.BtnCustNew.Name = "BtnCustNew"
        Me.BtnCustNew.Size = New System.Drawing.Size(110, 119)
        Me.BtnCustNew.TabIndex = 0
        Me.BtnCustNew.Text = "NEW " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUSTOMER"
        Me.BtnCustNew.UseVisualStyleBackColor = False
        '
        'BtnCustEdit
        '
        Me.BtnCustEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnCustEdit.BackgroundImage = CType(resources.GetObject("BtnCustEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnCustEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnCustEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnCustEdit.ForeColor = System.Drawing.Color.White
        Me.BtnCustEdit.Location = New System.Drawing.Point(254, 257)
        Me.BtnCustEdit.Name = "BtnCustEdit"
        Me.BtnCustEdit.Size = New System.Drawing.Size(110, 119)
        Me.BtnCustEdit.TabIndex = 1
        Me.BtnCustEdit.Text = "EDIT CUSTOMER INFO"
        Me.BtnCustEdit.UseVisualStyleBackColor = False
        '
        'BtnCustDelete
        '
        Me.BtnCustDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnCustDelete.BackgroundImage = CType(resources.GetObject("BtnCustDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnCustDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnCustDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnCustDelete.ForeColor = System.Drawing.Color.White
        Me.BtnCustDelete.Location = New System.Drawing.Point(254, 391)
        Me.BtnCustDelete.Name = "BtnCustDelete"
        Me.BtnCustDelete.Size = New System.Drawing.Size(110, 119)
        Me.BtnCustDelete.TabIndex = 2
        Me.BtnCustDelete.Text = "DELETE CUSTOMER INFO"
        Me.BtnCustDelete.UseVisualStyleBackColor = False
        '
        'BtnPetNew
        '
        Me.BtnPetNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetNew.BackgroundImage = CType(resources.GetObject("BtnPetNew.BackgroundImage"), System.Drawing.Image)
        Me.BtnPetNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPetNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPetNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnPetNew.ForeColor = System.Drawing.Color.White
        Me.BtnPetNew.Location = New System.Drawing.Point(455, 119)
        Me.BtnPetNew.Name = "BtnPetNew"
        Me.BtnPetNew.Size = New System.Drawing.Size(110, 119)
        Me.BtnPetNew.TabIndex = 3
        Me.BtnPetNew.Text = "NEW PET"
        Me.BtnPetNew.UseVisualStyleBackColor = False
        '
        'BtnPetEdit
        '
        Me.BtnPetEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetEdit.BackgroundImage = CType(resources.GetObject("BtnPetEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnPetEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPetEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPetEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnPetEdit.ForeColor = System.Drawing.Color.White
        Me.BtnPetEdit.Location = New System.Drawing.Point(455, 257)
        Me.BtnPetEdit.Name = "BtnPetEdit"
        Me.BtnPetEdit.Size = New System.Drawing.Size(110, 119)
        Me.BtnPetEdit.TabIndex = 4
        Me.BtnPetEdit.Text = "EDIT PET INFO"
        Me.BtnPetEdit.UseVisualStyleBackColor = False
        '
        'BtnPetDelete
        '
        Me.BtnPetDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetDelete.BackgroundImage = CType(resources.GetObject("BtnPetDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnPetDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPetDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnPetDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPetDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnPetDelete.ForeColor = System.Drawing.Color.White
        Me.BtnPetDelete.Location = New System.Drawing.Point(455, 391)
        Me.BtnPetDelete.Name = "BtnPetDelete"
        Me.BtnPetDelete.Size = New System.Drawing.Size(110, 119)
        Me.BtnPetDelete.TabIndex = 5
        Me.BtnPetDelete.Text = "DELETE PET INFO"
        Me.BtnPetDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(307, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Clerk Menu"
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(32, 477)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(89, 38)
        Me.BtnLogout.TabIndex = 11
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(823, 562)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'FrmMenuClerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPetDelete)
        Me.Controls.Add(Me.BtnPetEdit)
        Me.Controls.Add(Me.BtnPetNew)
        Me.Controls.Add(Me.BtnCustDelete)
        Me.Controls.Add(Me.BtnCustEdit)
        Me.Controls.Add(Me.BtnCustNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuClerk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Pet Shop Database"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCustNew As System.Windows.Forms.Button
    Friend WithEvents BtnCustEdit As System.Windows.Forms.Button
    Friend WithEvents BtnCustDelete As System.Windows.Forms.Button
    Friend WithEvents BtnPetNew As System.Windows.Forms.Button
    Friend WithEvents BtnPetEdit As System.Windows.Forms.Button
    Friend WithEvents BtnPetDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
