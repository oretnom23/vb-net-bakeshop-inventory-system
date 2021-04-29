<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupStockin
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsClose, Me.tsSelect, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(802, 57)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(600, 54)
        Me.ToolStripLabel1.Text = "List of Product"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.dtgList)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 427)
        Me.Panel1.TabIndex = 13
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(526, 69)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(270, 20)
        Me.txtSearch.TabIndex = 13
        '
        'dtgList
        '
        Me.dtgList.AllowUserToAddRows = False
        Me.dtgList.AllowUserToDeleteRows = False
        Me.dtgList.AllowUserToResizeColumns = False
        Me.dtgList.AllowUserToResizeRows = False
        Me.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgList.Location = New System.Drawing.Point(11, 95)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgList.Size = New System.Drawing.Size(785, 319)
        Me.dtgList.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(473, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Search :"
        '
        'tsClose
        '
        Me.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(54, 54)
        Me.tsClose.Text = "Close"
        '
        'tsSelect
        '
        Me.tsSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tsSelect.ForeColor = System.Drawing.Color.Black
        Me.tsSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSelect.Name = "tsSelect"
        Me.tsSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsSelect.Size = New System.Drawing.Size(46, 54)
        Me.tsSelect.Text = "Select"
        Me.tsSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'frmPopupStockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(804, 427)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPopupStockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Products"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsSelect As ToolStripButton
    Friend WithEvents tsClose As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
