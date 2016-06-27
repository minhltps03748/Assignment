<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachhang))
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.txtHoten = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.lblHoten = New System.Windows.Forms.Label()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(143, 119)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 10
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(20, 123)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(45, 16)
        Me.lblemail.TabIndex = 5
        Me.lblemail.Text = "Email:"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(143, 93)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 11
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiachi.Location = New System.Drawing.Point(20, 97)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(51, 16)
        Me.lblDiachi.TabIndex = 6
        Me.lblDiachi.Text = "Địa chỉ:"
        '
        'txtHoten
        '
        Me.txtHoten.Location = New System.Drawing.Point(143, 39)
        Me.txtHoten.Name = "txtHoten"
        Me.txtHoten.Size = New System.Drawing.Size(100, 20)
        Me.txtHoten.TabIndex = 12
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(143, 67)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(100, 20)
        Me.txtsdt.TabIndex = 13
        '
        'lblHoten
        '
        Me.lblHoten.AutoSize = True
        Me.lblHoten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoten.Location = New System.Drawing.Point(20, 43)
        Me.lblHoten.Name = "lblHoten"
        Me.lblHoten.Size = New System.Drawing.Size(68, 16)
        Me.lblHoten.TabIndex = 7
        Me.lblHoten.Text = "Họ và tên:"
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsdt.Location = New System.Drawing.Point(20, 71)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(89, 16)
        Me.lblsdt.TabIndex = 8
        Me.lblsdt.Text = "Số điện thoại:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(143, 13)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(100, 20)
        Me.txtMaKH.TabIndex = 14
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKH.Location = New System.Drawing.Point(20, 17)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(105, 16)
        Me.lblMaKH.TabIndex = 9
        Me.lblMaKH.Text = "Mã khách hàng: "
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Orange
        Me.btnCancel.Location = New System.Drawing.Point(143, 145)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 33)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Orange
        Me.btnOK.Location = New System.Drawing.Point(23, 145)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(92, 33)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmKhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(265, 190)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.txtHoten)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.lblHoten)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents txtHoten As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents lblHoten As System.Windows.Forms.Label
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
