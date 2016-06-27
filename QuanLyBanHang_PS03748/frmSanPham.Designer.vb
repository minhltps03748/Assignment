<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanPham))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.lblDongia = New System.Windows.Forms.Label()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.lblDonvitinh = New System.Windows.Forms.Label()
        Me.txtDonvitinh = New System.Windows.Forms.TextBox()
        Me.lblMaloaiSP = New System.Windows.Forms.Label()
        Me.txtMaloaiSP = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Orange
        Me.btnOK.Location = New System.Drawing.Point(21, 145)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(92, 35)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSP.Location = New System.Drawing.Point(18, 17)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(95, 16)
        Me.lblMaSP.TabIndex = 1
        Me.lblMaSP.Text = "Mã sản phẩm: "
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(141, 13)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaSP.TabIndex = 2
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSP.Location = New System.Drawing.Point(18, 43)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(97, 16)
        Me.lblTenSP.TabIndex = 1
        Me.lblTenSP.Text = "Tên sản phẩm:"
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(141, 39)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(100, 20)
        Me.txtTenSP.TabIndex = 2
        '
        'lblDongia
        '
        Me.lblDongia.AutoSize = True
        Me.lblDongia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDongia.Location = New System.Drawing.Point(18, 71)
        Me.lblDongia.Name = "lblDongia"
        Me.lblDongia.Size = New System.Drawing.Size(57, 16)
        Me.lblDongia.TabIndex = 1
        Me.lblDongia.Text = "Đơn giá:"
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(141, 67)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(100, 20)
        Me.txtDongia.TabIndex = 2
        '
        'lblDonvitinh
        '
        Me.lblDonvitinh.AutoSize = True
        Me.lblDonvitinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonvitinh.Location = New System.Drawing.Point(18, 97)
        Me.lblDonvitinh.Name = "lblDonvitinh"
        Me.lblDonvitinh.Size = New System.Drawing.Size(71, 16)
        Me.lblDonvitinh.TabIndex = 1
        Me.lblDonvitinh.Text = "Đơn vị tính:"
        '
        'txtDonvitinh
        '
        Me.txtDonvitinh.Location = New System.Drawing.Point(141, 93)
        Me.txtDonvitinh.Name = "txtDonvitinh"
        Me.txtDonvitinh.Size = New System.Drawing.Size(100, 20)
        Me.txtDonvitinh.TabIndex = 2
        '
        'lblMaloaiSP
        '
        Me.lblMaloaiSP.AutoSize = True
        Me.lblMaloaiSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaloaiSP.Location = New System.Drawing.Point(18, 123)
        Me.lblMaloaiSP.Name = "lblMaloaiSP"
        Me.lblMaloaiSP.Size = New System.Drawing.Size(117, 16)
        Me.lblMaloaiSP.TabIndex = 1
        Me.lblMaloaiSP.Text = "Mã loại sản phẩm:"
        '
        'txtMaloaiSP
        '
        Me.txtMaloaiSP.Location = New System.Drawing.Point(141, 119)
        Me.txtMaloaiSP.Name = "txtMaloaiSP"
        Me.txtMaloaiSP.ReadOnly = True
        Me.txtMaloaiSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaloaiSP.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Orange
        Me.btnCancel.Location = New System.Drawing.Point(141, 145)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 35)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(255, 210)
        Me.Controls.Add(Me.txtMaloaiSP)
        Me.Controls.Add(Me.lblMaloaiSP)
        Me.Controls.Add(Me.txtDonvitinh)
        Me.Controls.Add(Me.lblDonvitinh)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.lblTenSP)
        Me.Controls.Add(Me.lblDongia)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblMaSP)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sản phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents lblDongia As System.Windows.Forms.Label
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents lblDonvitinh As System.Windows.Forms.Label
    Friend WithEvents txtDonvitinh As System.Windows.Forms.TextBox
    Friend WithEvents lblMaloaiSP As System.Windows.Forms.Label
    Friend WithEvents txtMaloaiSP As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
