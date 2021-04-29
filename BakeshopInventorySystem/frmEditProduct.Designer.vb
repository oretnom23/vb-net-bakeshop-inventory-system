<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProduct
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCateg = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPROCODE = New System.Windows.Forms.TextBox()
        Me.TXTDESC = New System.Windows.Forms.RichTextBox()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPRONAME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(592, 77)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Edit Product"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCateg
        '
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Items.AddRange(New Object() {"Bread", "Cake", "Pastry"})
        Me.cboCateg.Location = New System.Drawing.Point(179, 255)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(339, 21)
        Me.cboCateg.TabIndex = 54
        Me.cboCateg.Text = "Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Product Code:"
        '
        'txtPROCODE
        '
        Me.txtPROCODE.Enabled = False
        Me.txtPROCODE.Location = New System.Drawing.Point(179, 121)
        Me.txtPROCODE.Name = "txtPROCODE"
        Me.txtPROCODE.Size = New System.Drawing.Size(339, 20)
        Me.txtPROCODE.TabIndex = 52
        '
        'TXTDESC
        '
        Me.TXTDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDESC.Location = New System.Drawing.Point(179, 188)
        Me.TXTDESC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTDESC.Name = "TXTDESC"
        Me.TXTDESC.Size = New System.Drawing.Size(339, 60)
        Me.TXTDESC.TabIndex = 45
        Me.TXTDESC.Text = ""
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRICE.Location = New System.Drawing.Point(179, 291)
        Me.TXTPRICE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(99, 30)
        Me.TXTPRICE.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Name :"
        '
        'TXTPRONAME
        '
        Me.TXTPRONAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRONAME.Location = New System.Drawing.Point(179, 155)
        Me.TXTPRONAME.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTPRONAME.Name = "TXTPRONAME"
        Me.TXTPRONAME.Size = New System.Drawing.Size(339, 23)
        Me.TXTPRONAME.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Description :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 256)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Category : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 291)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "php"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 291)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Price :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(481, 403)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 32)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(376, 403)
        Me.btnList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(97, 32)
        Me.btnList.TabIndex = 42
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.Location = New System.Drawing.Point(271, 403)
        Me.BTNSAVE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(97, 32)
        Me.BTNSAVE.TabIndex = 41
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = True
        '
        'frmEditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 441)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCateg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPROCODE)
        Me.Controls.Add(Me.TXTDESC)
        Me.Controls.Add(Me.TXTPRICE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTPRONAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Name = "frmEditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cboCateg As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPROCODE As TextBox
    Friend WithEvents TXTDESC As RichTextBox
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPRONAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnList As Button
    Friend WithEvents BTNSAVE As Button
End Class
