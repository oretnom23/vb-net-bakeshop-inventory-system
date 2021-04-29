<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOut
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
        Me.LBLMSG = New System.Windows.Forms.Label()
        Me.BTNNEW = New System.Windows.Forms.Button()
        Me.LBLTRANSNUM = New System.Windows.Forms.Label()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPTRANSDATE = New System.Windows.Forms.DateTimePicker()
        Me.BTNCLOSE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPROCODE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.LBLUNIT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTAVAILQTY = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBLUNIT2 = New System.Windows.Forms.Label()
        Me.LBLUNIT1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTREMAINQTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTTOT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTQTY = New System.Windows.Forms.TextBox()
        Me.TXTPRODUCT = New System.Windows.Forms.TextBox()
        Me.TXTDESC = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLMSG
        '
        Me.LBLMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMSG.Location = New System.Drawing.Point(12, 97)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(791, 19)
        Me.LBLMSG.TabIndex = 41
        Me.LBLMSG.Text = "Label11"
        '
        'BTNNEW
        '
        Me.BTNNEW.Location = New System.Drawing.Point(440, 471)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.Size = New System.Drawing.Size(85, 32)
        Me.BTNNEW.TabIndex = 40
        Me.BTNNEW.Text = "New"
        Me.BTNNEW.UseVisualStyleBackColor = True
        '
        'LBLTRANSNUM
        '
        Me.LBLTRANSNUM.AutoSize = True
        Me.LBLTRANSNUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTRANSNUM.Location = New System.Drawing.Point(117, 119)
        Me.LBLTRANSNUM.Name = "LBLTRANSNUM"
        Me.LBLTRANSNUM.Size = New System.Drawing.Size(58, 20)
        Me.LBLTRANSNUM.TabIndex = 34
        Me.LBLTRANSNUM.Text = "NONE"
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Location = New System.Drawing.Point(531, 471)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(85, 32)
        Me.BTNSAVE.TabIndex = 39
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Transaction #:"
        '
        'DTPTRANSDATE
        '
        Me.DTPTRANSDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTRANSDATE.Location = New System.Drawing.Point(655, 116)
        Me.DTPTRANSDATE.Name = "DTPTRANSDATE"
        Me.DTPTRANSDATE.Size = New System.Drawing.Size(145, 20)
        Me.DTPTRANSDATE.TabIndex = 36
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.Location = New System.Drawing.Point(715, 470)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(85, 32)
        Me.BTNCLOSE.TabIndex = 38
        Me.BTNCLOSE.Text = "Close"
        Me.BTNCLOSE.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(529, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Transaction Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPROCODE)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXTPRICE)
        Me.GroupBox1.Controls.Add(Me.LBLUNIT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTAVAILQTY)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TXTPRODUCT)
        Me.GroupBox1.Controls.Add(Me.TXTDESC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 314)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(455, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 26)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Find"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Product Code:"
        '
        'txtPROCODE
        '
        Me.txtPROCODE.Location = New System.Drawing.Point(125, 36)
        Me.txtPROCODE.Name = "txtPROCODE"
        Me.txtPROCODE.Size = New System.Drawing.Size(324, 26)
        Me.txtPROCODE.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(264, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "php"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Price:"
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Enabled = False
        Me.TXTPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRICE.Location = New System.Drawing.Point(125, 163)
        Me.TXTPRICE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(133, 30)
        Me.TXTPRICE.TabIndex = 32
        '
        'LBLUNIT
        '
        Me.LBLUNIT.AutoSize = True
        Me.LBLUNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUNIT.Location = New System.Drawing.Point(266, 219)
        Me.LBLUNIT.Name = "LBLUNIT"
        Me.LBLUNIT.Size = New System.Drawing.Size(33, 15)
        Me.LBLUNIT.TabIndex = 31
        Me.LBLUNIT.Text = "pcs."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 34)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Available " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quantity:"
        '
        'TXTAVAILQTY
        '
        Me.TXTAVAILQTY.Enabled = False
        Me.TXTAVAILQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAVAILQTY.Location = New System.Drawing.Point(125, 209)
        Me.TXTAVAILQTY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTAVAILQTY.Name = "TXTAVAILQTY"
        Me.TXTAVAILQTY.Size = New System.Drawing.Size(133, 30)
        Me.TXTAVAILQTY.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBLUNIT2)
        Me.GroupBox2.Controls.Add(Me.LBLUNIT1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TXTREMAINQTY)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXTTOT)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXTQTY)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 137)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'LBLUNIT2
        '
        Me.LBLUNIT2.AutoSize = True
        Me.LBLUNIT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUNIT2.Location = New System.Drawing.Point(342, 63)
        Me.LBLUNIT2.Name = "LBLUNIT2"
        Me.LBLUNIT2.Size = New System.Drawing.Size(33, 15)
        Me.LBLUNIT2.TabIndex = 34
        Me.LBLUNIT2.Text = "pcs."
        '
        'LBLUNIT1
        '
        Me.LBLUNIT1.AutoSize = True
        Me.LBLUNIT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUNIT1.Location = New System.Drawing.Point(342, 30)
        Me.LBLUNIT1.Name = "LBLUNIT1"
        Me.LBLUNIT1.Size = New System.Drawing.Size(33, 15)
        Me.LBLUNIT1.TabIndex = 33
        Me.LBLUNIT1.Text = "pcs."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Remaining Quantity:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(343, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "php"
        '
        'TXTREMAINQTY
        '
        Me.TXTREMAINQTY.Enabled = False
        Me.TXTREMAINQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREMAINQTY.Location = New System.Drawing.Point(202, 57)
        Me.TXTREMAINQTY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTREMAINQTY.Name = "TXTREMAINQTY"
        Me.TXTREMAINQTY.Size = New System.Drawing.Size(133, 29)
        Me.TXTREMAINQTY.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total Price:"
        '
        'TXTTOT
        '
        Me.TXTTOT.Enabled = False
        Me.TXTTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOT.Location = New System.Drawing.Point(204, 91)
        Me.TXTTOT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.Size = New System.Drawing.Size(133, 29)
        Me.TXTTOT.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(112, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Quantity:"
        '
        'TXTQTY
        '
        Me.TXTQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQTY.Location = New System.Drawing.Point(202, 24)
        Me.TXTQTY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTQTY.Name = "TXTQTY"
        Me.TXTQTY.Size = New System.Drawing.Size(133, 29)
        Me.TXTQTY.TabIndex = 20
        '
        'TXTPRODUCT
        '
        Me.TXTPRODUCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODUCT.Location = New System.Drawing.Point(125, 67)
        Me.TXTPRODUCT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTPRODUCT.Name = "TXTPRODUCT"
        Me.TXTPRODUCT.Size = New System.Drawing.Size(540, 23)
        Me.TXTPRODUCT.TabIndex = 28
        '
        'TXTDESC
        '
        Me.TXTDESC.Enabled = False
        Me.TXTDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDESC.Location = New System.Drawing.Point(125, 94)
        Me.TXTDESC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTDESC.Name = "TXTDESC"
        Me.TXTDESC.Size = New System.Drawing.Size(540, 65)
        Me.TXTDESC.TabIndex = 30
        Me.TXTDESC.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 46)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Stock-Out"
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(624, 471)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(85, 32)
        Me.btnList.TabIndex = 43
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'frmStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(815, 512)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLMSG)
        Me.Controls.Add(Me.BTNNEW)
        Me.Controls.Add(Me.LBLTRANSNUM)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTPTRANSDATE)
        Me.Controls.Add(Me.BTNCLOSE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStockOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockOut"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLMSG As Label
    Friend WithEvents BTNNEW As Button
    Friend WithEvents LBLTRANSNUM As Label
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPTRANSDATE As DateTimePicker
    Friend WithEvents BTNCLOSE As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPROCODE As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents LBLUNIT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTAVAILQTY As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBLUNIT2 As Label
    Friend WithEvents LBLUNIT1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTREMAINQTY As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTTOT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTQTY As TextBox
    Friend WithEvents TXTPRODUCT As TextBox
    Friend WithEvents TXTDESC As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnList As Button
End Class
