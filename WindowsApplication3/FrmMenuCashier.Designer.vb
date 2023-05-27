<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuCashier))
        Me.BtnPurchases = New System.Windows.Forms.Button()
        Me.BtnItemsBought = New System.Windows.Forms.Button()
        Me.BtnNewPurchase = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnProduct = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPurchases
        '
        Me.BtnPurchases.BackgroundImage = CType(resources.GetObject("BtnPurchases.BackgroundImage"), System.Drawing.Image)
        Me.BtnPurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPurchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnPurchases.Location = New System.Drawing.Point(20, 150)
        Me.BtnPurchases.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPurchases.Name = "BtnPurchases"
        Me.BtnPurchases.Size = New System.Drawing.Size(125, 125)
        Me.BtnPurchases.TabIndex = 1
        Me.BtnPurchases.Text = "VIEW SALES"
        Me.BtnPurchases.UseVisualStyleBackColor = True
        '
        'BtnItemsBought
        '
        Me.BtnItemsBought.BackgroundImage = CType(resources.GetObject("BtnItemsBought.BackgroundImage"), System.Drawing.Image)
        Me.BtnItemsBought.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnItemsBought.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnItemsBought.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnItemsBought.Location = New System.Drawing.Point(20, 280)
        Me.BtnItemsBought.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnItemsBought.Name = "BtnItemsBought"
        Me.BtnItemsBought.Size = New System.Drawing.Size(125, 125)
        Me.BtnItemsBought.TabIndex = 2
        Me.BtnItemsBought.Text = "PRODUCTS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SOLD"
        Me.BtnItemsBought.UseVisualStyleBackColor = True
        '
        'BtnNewPurchase
        '
        Me.BtnNewPurchase.BackgroundImage = CType(resources.GetObject("BtnNewPurchase.BackgroundImage"), System.Drawing.Image)
        Me.BtnNewPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnNewPurchase.Location = New System.Drawing.Point(20, 17)
        Me.BtnNewPurchase.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewPurchase.Name = "BtnNewPurchase"
        Me.BtnNewPurchase.Size = New System.Drawing.Size(125, 125)
        Me.BtnNewPurchase.TabIndex = 4
        Me.BtnNewPurchase.Text = "NEW " & Global.Microsoft.VisualBasic.ChrW(13) & "TRANSACTION"
        Me.BtnNewPurchase.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Button2.Location = New System.Drawing.Point(97, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 125)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "ADD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnUpdate.Location = New System.Drawing.Point(97, 149)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(125, 125)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "UPDATE/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DELETE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnProduct
        '
        Me.BtnProduct.BackgroundImage = CType(resources.GetObject("BtnProduct.BackgroundImage"), System.Drawing.Image)
        Me.BtnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.BtnProduct.Location = New System.Drawing.Point(97, 280)
        Me.BtnProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnProduct.Name = "BtnProduct"
        Me.BtnProduct.Size = New System.Drawing.Size(125, 125)
        Me.BtnProduct.TabIndex = 7
        Me.BtnProduct.Text = "VIEW " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnProduct.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BtnProduct)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(125, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 417)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnNewPurchase)
        Me.GroupBox2.Controls.Add(Me.BtnPurchases)
        Me.GroupBox2.Controls.Add(Me.BtnItemsBought)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(656, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 417)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(26, 594)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(120, 47)
        Me.BtnLogout.TabIndex = 10
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
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
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(165, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 125)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "FEE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAYMENT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(165, 150)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 125)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "VIEW PAID FEES"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmMenuCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Petshop Database: Cashier Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnPurchases As System.Windows.Forms.Button
    Friend WithEvents BtnItemsBought As System.Windows.Forms.Button
    Friend WithEvents BtnNewPurchase As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnProduct As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
