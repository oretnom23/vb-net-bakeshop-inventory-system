<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoProduct = New System.Windows.Forms.RadioButton()
        Me.rdoStockIn = New System.Windows.Forms.RadioButton()
        Me.rdoStockOut = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.rdoToday = New System.Windows.Forms.RadioButton()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.LBLLIST = New System.Windows.Forms.Label()
        Me.BTNSEARCHGRID = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.cboCateg = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.rdoProduct)
        Me.GroupBox1.Controls.Add(Me.rdoStockIn)
        Me.GroupBox1.Controls.Add(Me.rdoStockOut)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 146)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory of Products"
        '
        'rdoProduct
        '
        Me.rdoProduct.AutoSize = True
        Me.rdoProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoProduct.Location = New System.Drawing.Point(29, 28)
        Me.rdoProduct.Name = "rdoProduct"
        Me.rdoProduct.Size = New System.Drawing.Size(39, 17)
        Me.rdoProduct.TabIndex = 14
        Me.rdoProduct.TabStop = True
        Me.rdoProduct.Text = "All"
        Me.rdoProduct.UseVisualStyleBackColor = True
        '
        'rdoStockIn
        '
        Me.rdoStockIn.AutoSize = True
        Me.rdoStockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoStockIn.Location = New System.Drawing.Point(29, 56)
        Me.rdoStockIn.Name = "rdoStockIn"
        Me.rdoStockIn.Size = New System.Drawing.Size(73, 17)
        Me.rdoStockIn.TabIndex = 0
        Me.rdoStockIn.TabStop = True
        Me.rdoStockIn.Text = "Stock-In"
        Me.rdoStockIn.UseVisualStyleBackColor = True
        '
        'rdoStockOut
        '
        Me.rdoStockOut.AutoSize = True
        Me.rdoStockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoStockOut.Location = New System.Drawing.Point(29, 79)
        Me.rdoStockOut.Name = "rdoStockOut"
        Me.rdoStockOut.Size = New System.Drawing.Size(50, 17)
        Me.rdoStockOut.TabIndex = 0
        Me.rdoStockOut.TabStop = True
        Me.rdoStockOut.Text = "Sold"
        Me.rdoStockOut.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 493)
        Me.Panel2.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.rdoWeekly)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.rdoMonthly)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpFrom)
        Me.GroupBox2.Controls.Add(Me.rdoToday)
        Me.GroupBox2.Controls.Add(Me.dtpTo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 185)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Filter"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(102, 92)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(69, 29)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rdoWeekly
        '
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWeekly.Location = New System.Drawing.Point(18, 150)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(67, 17)
        Me.rdoWeekly.TabIndex = 2
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'rdoMonthly
        '
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMonthly.Location = New System.Drawing.Point(102, 150)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(69, 17)
        Me.rdoMonthly.TabIndex = 2
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "To"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(49, 35)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(122, 20)
        Me.dtpFrom.TabIndex = 0
        '
        'rdoToday
        '
        Me.rdoToday.AutoSize = True
        Me.rdoToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoToday.Location = New System.Drawing.Point(18, 127)
        Me.rdoToday.Name = "rdoToday"
        Me.rdoToday.Size = New System.Drawing.Size(60, 17)
        Me.rdoToday.TabIndex = 2
        Me.rdoToday.TabStop = True
        Me.rdoToday.Text = "Today"
        Me.rdoToday.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(49, 66)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(122, 20)
        Me.dtpTo.TabIndex = 0
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglist.Location = New System.Drawing.Point(0, 28)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.ReadOnly = True
        Me.dtglist.RowHeadersVisible = False
        Me.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist.Size = New System.Drawing.Size(793, 297)
        Me.dtglist.TabIndex = 1
        '
        'LBLLIST
        '
        Me.LBLLIST.BackColor = System.Drawing.Color.White
        Me.LBLLIST.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLLIST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLIST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBLLIST.Location = New System.Drawing.Point(0, 0)
        Me.LBLLIST.Name = "LBLLIST"
        Me.LBLLIST.Size = New System.Drawing.Size(793, 28)
        Me.LBLLIST.TabIndex = 2
        Me.LBLLIST.Text = "List"
        Me.LBLLIST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNSEARCHGRID
        '
        Me.BTNSEARCHGRID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSEARCHGRID.Location = New System.Drawing.Point(769, 93)
        Me.BTNSEARCHGRID.Name = "BTNSEARCHGRID"
        Me.BTNSEARCHGRID.Size = New System.Drawing.Size(68, 26)
        Me.BTNSEARCHGRID.TabIndex = 31
        Me.BTNSEARCHGRID.Text = "Search"
        Me.BTNSEARCHGRID.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(509, 93)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(261, 26)
        Me.txtSearch.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(198, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Categories"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(884, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 28)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtglist)
        Me.Panel3.Controls.Add(Me.LBLLIST)
        Me.Panel3.Location = New System.Drawing.Point(199, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(793, 325)
        Me.Panel3.TabIndex = 30
        '
        'btnpreview
        '
        Me.btnpreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Location = New System.Drawing.Point(773, 455)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(108, 28)
        Me.btnpreview.TabIndex = 26
        Me.btnpreview.Text = "Print Preview"
        Me.btnpreview.UseVisualStyleBackColor = True
        '
        'cboCateg
        '
        Me.cboCateg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateg.Items.AddRange(New Object() {"Bread", "Cake", "Pastry"})
        Me.cboCateg.Location = New System.Drawing.Point(1, -1)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(302, 24)
        Me.cboCateg.TabIndex = 6
        Me.cboCateg.Text = "Bread"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(506, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Product"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboCateg)
        Me.Panel1.Location = New System.Drawing.Point(199, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 25)
        Me.Panel1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(193, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(809, 52)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Inventory Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 493)
        Me.Controls.Add(Me.BTNSEARCHGRID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoProduct As RadioButton
    Friend WithEvents rdoStockIn As RadioButton
    Friend WithEvents rdoStockOut As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents rdoWeekly As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents rdoToday As RadioButton
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents LBLLIST As Label
    Friend WithEvents BTNSEARCHGRID As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnpreview As Button
    Friend WithEvents cboCateg As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
