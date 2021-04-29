<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.LBLUSERID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(595, 30)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "User Details"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Role :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(594, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "List of User"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(348, 258)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(128, 28)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(482, 258)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(128, 28)
        Me.btnnew.TabIndex = 14
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.Cyan
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(76, 516)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(329, 26)
        Me.txtsearch.TabIndex = 16
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(411, 513)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(96, 29)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(116, 38)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(443, 26)
        Me.txtname.TabIndex = 0
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(513, 513)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 29)
        Me.btnclose.TabIndex = 18
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'LBLUSERID
        '
        Me.LBLUSERID.AutoSize = True
        Me.LBLUSERID.Location = New System.Drawing.Point(178, 39)
        Me.LBLUSERID.Name = "LBLUSERID"
        Me.LBLUSERID.Size = New System.Drawing.Size(48, 13)
        Me.LBLUSERID.TabIndex = 12
        Me.LBLUSERID.Text = "USERID"
        Me.LBLUSERID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtglist)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 215)
        Me.Panel1.TabIndex = 19
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(0, 30)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.RowHeadersVisible = False
        Me.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist.Size = New System.Drawing.Size(594, 183)
        Me.dtglist.TabIndex = 6
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(116, 70)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(443, 26)
        Me.txtusername.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Username :"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(116, 102)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(443, 26)
        Me.txtpass.TabIndex = 2
        Me.txtpass.UseSystemPasswordChar = True
        '
        'cbotype
        '
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.cbotype.Location = New System.Drawing.Point(116, 134)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(443, 28)
        Me.cbotype.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(622, 56)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Add New User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.LBLUSERID)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.cbotype)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(11, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 181)
        Me.Panel2.TabIndex = 20
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 552)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnclose As Button
    Friend WithEvents LBLUSERID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
