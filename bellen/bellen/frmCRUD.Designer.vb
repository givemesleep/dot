<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRUD
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnldata = New System.Windows.Forms.Panel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.pnl4 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod = New System.Windows.Forms.Label()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.pnldata.SuspendLayout()
        Me.pnl3.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl4.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnldata
        '
        Me.pnldata.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnldata.Controls.Add(Me.btnsearch)
        Me.pnldata.Controls.Add(Me.Label1)
        Me.pnldata.Controls.Add(Me.txtsearch)
        Me.pnldata.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnldata.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnldata.Location = New System.Drawing.Point(0, 0)
        Me.pnldata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnldata.Name = "pnldata"
        Me.pnldata.Size = New System.Drawing.Size(820, 72)
        Me.pnldata.TabIndex = 0
        '
        'btnsearch
        '
        Me.btnsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsearch.Location = New System.Drawing.Point(730, 32)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(77, 27)
        Me.btnsearch.TabIndex = 2
        Me.btnsearch.Text = "S&earch"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(519, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Keyword:"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtsearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(521, 37)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(198, 22)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnl3
        '
        Me.pnl3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl3.Controls.Add(Me.Button6)
        Me.pnl3.Controls.Add(Me.Button5)
        Me.pnl3.Controls.Add(Me.Button4)
        Me.pnl3.Controls.Add(Me.Button3)
        Me.pnl3.Controls.Add(Me.Button2)
        Me.pnl3.Controls.Add(Me.Button1)
        Me.pnl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl3.Location = New System.Drawing.Point(0, 424)
        Me.pnl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(820, 73)
        Me.pnl3.TabIndex = 1
        '
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.txtunitprice)
        Me.pnl2.Controls.Add(Me.Label4)
        Me.pnl2.Controls.Add(Me.Label3)
        Me.pnl2.Controls.Add(Me.txtdescription)
        Me.pnl2.Controls.Add(Me.Label2)
        Me.pnl2.Controls.Add(Me.txtbrand)
        Me.pnl2.Controls.Add(Me.txtproductid)
        Me.pnl2.Controls.Add(Me.prod)
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl2.Location = New System.Drawing.Point(0, 72)
        Me.pnl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(196, 352)
        Me.pnl2.TabIndex = 2
        '
        'pnl4
        '
        Me.pnl4.Controls.Add(Me.dgv)
        Me.pnl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl4.Location = New System.Drawing.Point(196, 72)
        Me.pnl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnl4.Name = "pnl4"
        Me.pnl4.Size = New System.Drawing.Size(624, 352)
        Me.pnl4.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Brand, Me.Column2, Me.Column3})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(624, 352)
        Me.dgv.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "productid"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Brand
        '
        Me.Brand.DataPropertyName = "brand"
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "description"
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "unit_price"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Unit Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'prod
        '
        Me.prod.AutoSize = True
        Me.prod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod.Location = New System.Drawing.Point(11, 9)
        Me.prod.Name = "prod"
        Me.prod.Size = New System.Drawing.Size(82, 16)
        Me.prod.TabIndex = 0
        Me.prod.Text = "Product ID :"
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(12, 26)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(173, 22)
        Me.txtproductid.TabIndex = 1
        '
        'txtbrand
        '
        Me.txtbrand.Location = New System.Drawing.Point(14, 77)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(171, 22)
        Me.txtbrand.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brand :"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(15, 130)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(170, 121)
        Me.txtdescription.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unit Price :"
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(15, 277)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(169, 22)
        Me.txtunitprice.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(143, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(208, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Edi&t"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(274, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "&Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(744, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(61, 49)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "E&xit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 497)
        Me.Controls.Add(Me.pnl4)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnldata)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCRUD"
        Me.Text = "frmCRUD"
        Me.pnldata.ResumeLayout(False)
        Me.pnldata.PerformLayout()
        Me.pnl3.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.pnl4.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnldata As System.Windows.Forms.Panel
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents pnl3 As System.Windows.Forms.Panel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents pnl4 As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtunitprice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbrand As System.Windows.Forms.TextBox
    Friend WithEvents txtproductid As System.Windows.Forms.TextBox
    Friend WithEvents prod As System.Windows.Forms.Label

End Class
