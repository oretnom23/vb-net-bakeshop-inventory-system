<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BTNNEW = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.DTPTRANSDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BTNCLOSE = New System.Windows.Forms.Button()
        Me.LBLTRANSNUM = New System.Windows.Forms.Label()
        Me.LBLMSG = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPROCODE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTPRODUCT = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBLUNIT = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTOT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTQTY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.TXTDESC = New System.Windows.Forms.RichTextBox()
        Me.CBOUNIT = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 17)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Transaction #:"
        '
        'BTNNEW
        '
        Me.BTNNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNEW.Location = New System.Drawing.Point(481, 451)
        Me.BTNNEW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.Size = New System.Drawing.Size(73, 36)
        Me.BTNNEW.TabIndex = 22
        Me.BTNNEW.Text = "New"
        Me.BTNNEW.UseVisualStyleBackColor = True
        '
        'BTNADD
        '
        Me.BTNADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNADD.Location = New System.Drawing.Point(560, 451)
        Me.BTNADD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(73, 36)
        Me.BTNADD.TabIndex = 23
        Me.BTNADD.Text = "Save"
        Me.BTNADD.UseVisualStyleBackColor = True
        '
        'DTPTRANSDATE
        '
        Me.DTPTRANSDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTRANSDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTRANSDATE.Location = New System.Drawing.Point(641, 86)
        Me.DTPTRANSDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPTRANSDATE.Name = "DTPTRANSDATE"
        Me.DTPTRANSDATE.Size = New System.Drawing.Size(155, 23)
        Me.DTPTRANSDATE.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(497, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Transaction Date:"
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLOSE.Location = New System.Drawing.Point(718, 451)
        Me.BTNCLOSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(73, 36)
        Me.BTNCLOSE.TabIndex = 24
        Me.BTNCLOSE.Text = "Close"
        Me.BTNCLOSE.UseVisualStyleBackColor = True
        '
        'LBLTRANSNUM
        '
        Me.LBLTRANSNUM.AutoSize = True
        Me.LBLTRANSNUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTRANSNUM.Location = New System.Drawing.Point(135, 86)
        Me.LBLTRANSNUM.Name = "LBLTRANSNUM"
        Me.LBLTRANSNUM.Size = New System.Drawing.Size(52, 17)
        Me.LBLTRANSNUM.TabIndex = 27
        Me.LBLTRANSNUM.Text = "NONE"
        '
        'LBLMSG
        '
        Me.LBLMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMSG.Location = New System.Drawing.Point(12, 59)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(789, 19)
        Me.LBLMSG.TabIndex = 25
        Me.LBLMSG.Text = "Label11"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPROCODE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTPRODUCT)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TXTDESC)
        Me.GroupBox1.Controls.Add(Me.CBOUNIT)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 113)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(779, 313)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(475, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 26)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Find"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Product Code:"
        '
        'txtPROCODE
        '
        Me.txtPROCODE.Location = New System.Drawing.Point(145, 32)
        Me.txtPROCODE.Name = "txtPROCODE"
        Me.txtPROCODE.Size = New System.Drawing.Size(324, 26)
        Me.txtPROCODE.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Description:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 170)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(277, 119)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Notes:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Write your notes here............................"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Product:"
        '
        'TXTPRODUCT
        '
        Me.TXTPRODUCT.Enabled = False
        Me.TXTPRODUCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODUCT.Location = New System.Drawing.Point(145, 63)
        Me.TXTPRODUCT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTPRODUCT.Name = "TXTPRODUCT"
        Me.TXTPRODUCT.Size = New System.Drawing.Size(412, 23)
        Me.TXTPRODUCT.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LBLUNIT)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TXTTOT)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TXTQTY)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TXTPRICE)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(311, 156)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(462, 140)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'LBLUNIT
        '
        Me.LBLUNIT.AutoSize = True
        Me.LBLUNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUNIT.Location = New System.Drawing.Point(255, 69)
        Me.LBLUNIT.Name = "LBLUNIT"
        Me.LBLUNIT.Size = New System.Drawing.Size(42, 17)
        Me.LBLUNIT.TabIndex = 13
        Me.LBLUNIT.Text = "Unit:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(255, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "php"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(256, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "php"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total Price:"
        '
        'TXTTOT
        '
        Me.TXTTOT.Enabled = False
        Me.TXTTOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOT.Location = New System.Drawing.Point(117, 96)
        Me.TXTTOT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.Size = New System.Drawing.Size(133, 29)
        Me.TXTTOT.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity:"
        '
        'TXTQTY
        '
        Me.TXTQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQTY.Location = New System.Drawing.Point(117, 63)
        Me.TXTQTY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTQTY.Name = "TXTQTY"
        Me.TXTQTY.Size = New System.Drawing.Size(133, 29)
        Me.TXTQTY.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Price :"
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Enabled = False
        Me.TXTPRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRICE.Location = New System.Drawing.Point(117, 30)
        Me.TXTPRICE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(133, 29)
        Me.TXTPRICE.TabIndex = 3
        '
        'TXTDESC
        '
        Me.TXTDESC.Enabled = False
        Me.TXTDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDESC.Location = New System.Drawing.Point(145, 99)
        Me.TXTDESC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTDESC.Name = "TXTDESC"
        Me.TXTDESC.Size = New System.Drawing.Size(412, 56)
        Me.TXTDESC.TabIndex = 9
        Me.TXTDESC.Text = ""
        '
        'CBOUNIT
        '
        Me.CBOUNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUNIT.FormattingEnabled = True
        Me.CBOUNIT.Location = New System.Drawing.Point(482, 102)
        Me.CBOUNIT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBOUNIT.Name = "CBOUNIT"
        Me.CBOUNIT.Size = New System.Drawing.Size(15, 28)
        Me.CBOUNIT.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 46)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Stock-in"
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.Location = New System.Drawing.Point(639, 451)
        Me.btnList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(73, 36)
        Me.btnList.TabIndex = 31
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(815, 498)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BTNNEW)
        Me.Controls.Add(Me.BTNADD)
        Me.Controls.Add(Me.DTPTRANSDATE)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BTNCLOSE)
        Me.Controls.Add(Me.LBLTRANSNUM)
        Me.Controls.Add(Me.LBLMSG)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStockIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Products"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents BTNNEW As Button
    Friend WithEvents BTNADD As Button
    Friend WithEvents DTPTRANSDATE As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents BTNCLOSE As Button
    Friend WithEvents LBLTRANSNUM As Label
    Friend WithEvents LBLMSG As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPROCODE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTPRODUCT As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LBLUNIT As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTTOT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTQTY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents TXTDESC As RichTextBox
    Friend WithEvents CBOUNIT As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnList As Button
End Class
