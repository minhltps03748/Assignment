<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.txtNgayLapHD = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblNgayLapHD = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.lblMaHD = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNgayLapHD
        '
        Me.txtNgayLapHD.Location = New System.Drawing.Point(147, 34)
        Me.txtNgayLapHD.Name = "txtNgayLapHD"
        Me.txtNgayLapHD.Size = New System.Drawing.Size(79, 20)
        Me.txtNgayLapHD.TabIndex = 12
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(147, 62)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(79, 20)
        Me.txtMaKH.TabIndex = 13
        '
        'lblNgayLapHD
        '
        Me.lblNgayLapHD.AutoSize = True
        Me.lblNgayLapHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgayLapHD.Location = New System.Drawing.Point(12, 38)
        Me.lblNgayLapHD.Name = "lblNgayLapHD"
        Me.lblNgayLapHD.Size = New System.Drawing.Size(126, 16)
        Me.lblNgayLapHD.TabIndex = 7
        Me.lblNgayLapHD.Text = "Ngày Lập Hóa Đơn:"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKH.Location = New System.Drawing.Point(12, 66)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(106, 16)
        Me.lblMaKH.TabIndex = 8
        Me.lblMaKH.Text = "Mã Khách Hàng:"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(147, 8)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(79, 20)
        Me.txtMaHD.TabIndex = 14
        '
        'lblMaHD
        '
        Me.lblMaHD.AutoSize = True
        Me.lblMaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaHD.Location = New System.Drawing.Point(12, 12)
        Me.lblMaHD.Name = "lblMaHD"
        Me.lblMaHD.Size = New System.Drawing.Size(89, 16)
        Me.lblMaHD.TabIndex = 9
        Me.lblMaHD.Text = "Mã Hóa Đơn: "
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Orange
        Me.btnCancel.Location = New System.Drawing.Point(147, 102)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 27)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Orange
        Me.btnOK.Location = New System.Drawing.Point(27, 102)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(74, 27)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(244, 154)
        Me.Controls.Add(Me.txtNgayLapHD)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblNgayLapHD)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.lblMaHD)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNgayLapHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents lblNgayLapHD As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents lblMaHD As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
