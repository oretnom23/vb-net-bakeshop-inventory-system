<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoldProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSoldProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ManageUsersToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProductToolStripMenuItem, Me.ListOfProductsToolStripMenuItem})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddNewProductToolStripMenuItem.Text = "Add New Product"
        '
        'ListOfProductsToolStripMenuItem
        '
        Me.ListOfProductsToolStripMenuItem.Name = "ListOfProductsToolStripMenuItem"
        Me.ListOfProductsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ListOfProductsToolStripMenuItem.Text = "List of Products"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockinToolStripMenuItem, Me.StockoutToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'StockinToolStripMenuItem
        '
        Me.StockinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ReceiveProductsToolStripMenuItem})
        Me.StockinToolStripMenuItem.Name = "StockinToolStripMenuItem"
        Me.StockinToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StockinToolStripMenuItem.Text = "Stock-in"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddToolStripMenuItem.Text = "Stock-in Products"
        '
        'ReceiveProductsToolStripMenuItem
        '
        Me.ReceiveProductsToolStripMenuItem.Name = "ReceiveProductsToolStripMenuItem"
        Me.ReceiveProductsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReceiveProductsToolStripMenuItem.Text = "History"
        '
        'StockoutToolStripMenuItem
        '
        Me.StockoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoldProductToolStripMenuItem, Me.ListOfSoldProductsToolStripMenuItem})
        Me.StockoutToolStripMenuItem.Name = "StockoutToolStripMenuItem"
        Me.StockoutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StockoutToolStripMenuItem.Text = "Stock-out"
        '
        'SoldProductToolStripMenuItem
        '
        Me.SoldProductToolStripMenuItem.Name = "SoldProductToolStripMenuItem"
        Me.SoldProductToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SoldProductToolStripMenuItem.Text = "Stock-out Product"
        '
        'ListOfSoldProductsToolStripMenuItem
        '
        Me.ListOfSoldProductsToolStripMenuItem.Name = "ListOfSoldProductsToolStripMenuItem"
        Me.ListOfSoldProductsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ListOfSoldProductsToolStripMenuItem.Text = "History"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.ReportsToolStripMenuItem.Text = "Inventory Reports"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bakeshop Inventory System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.BakeshopInventorySystem.My.Resources.Resources.Bakery_Logo_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(879, 507)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bakeshop Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoldProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSoldProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
