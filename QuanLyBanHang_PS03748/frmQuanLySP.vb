Public Class frmQuanLySP
    'Khai biến để truy xuất database từ lớp DatabaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False

    'Định nghĩa thủ tục load dữ liệu từ bảng lớp vào ComboBox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "SElECT Ma_LoaiSP, TenLoaiSP FROM dbo.LoaiSanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbLoaiSP.DataSource = dTable
        Me.cmbLoaiSP.ValueMember = "Ma_LoaiSP"
        Me.cmbLoaiSP.DisplayMember = "TenLoaiSP"

    End Sub
    'Định nghĩa thủ tục load dử liệu từ bảng Mã loại Sản phẩm theo từng lớp vào gridview
    Private Sub LoadDataOngridView(Ma_LoaiSP As String)
        Dim sqlQuery As String = _
            String.Format("SELECT Ma_SP, Ten_SP, DonGia, DonViTinh FROM  dbo.SanPham WHERE Ma_LoaiSP = '{0}'", Ma_LoaiSP)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSP.DataSource = dTable
        With Me.dgvSP
            .Columns(0).HeaderText = "Ma_SP"
            .Columns(1).HeaderText = "Ten_SP"
            .Columns(2).HeaderText = "DonGia"
            .Columns(3).HeaderText = "DonViTinh"
        End With
    End Sub

    Private Sub frmQuanLySP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True

        LoadDataOnComBobox()
        LoadDataOngridView(Me.cmbLoaiSP.SelectedValue)

        _isLoading = False
    End Sub

    Private Sub cmbLoaiSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoaiSP.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOngridView(Me.cmbLoaiSP.SelectedValue)
        End If
    End Sub
    'Định nghĩa thủ tục hiển thị kết quả Search: theo phương pháp tương tự - Tìm kiếm tương tự
    Private Sub SearchSP(Ma_LoaiSP As String, value As String)
        Dim sqlQuery As String = _
            String.Format("SELECT Ma_SP, Ten_SP, DonGia, DonViTinh FROM  dbo.SanPham WHERE Ma_LoaiSP = '{0}'", Ma_LoaiSP)
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND Ma_SP  LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND Ten_SP LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSP.DataSource = dTable
        With Me.dgvSP
            .Columns(0).HeaderText = "Ma_SP"
            .Columns(1).HeaderText = "Ten_SP"
            .Columns(2).HeaderText = "DonGia"
            .Columns(3).HeaderText = "DonViTinh"
        End With
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchSP(Me.cmbLoaiSP.SelectedValue, Me.txtSearch.Text)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmSanPham(False)
        frm.txtMaloaiSP.Text = Me.cmbLoaiSP.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            'load dữ liệu'
            LoadDataOngridView(Me.cmbLoaiSP.SelectedValue)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frmSanPham(True)
        frm.txtMaloaiSP.Text = Me.cmbLoaiSP.SelectedValue
        frm.txtMaSP.ReadOnly = True
        With Me.dgvSP
            frm.txtMaSP.Text = .Rows(.CurrentCell.RowIndex).Cells("Ma_SP").Value
            frm.txtTenSP.Text = .Rows(.CurrentCell.RowIndex).Cells("Ten_SP").Value
            frm.txtDongia.Text = .Rows(.CurrentCell.RowIndex).Cells("DonGia").Value
            frm.txtDonvitinh.Text = .Rows(.CurrentCell.RowIndex).Cells("DonViTinh").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then  'Sửa dữ liệu thành công thì load lại vào Gridview
            LoadDataOngridView(Me.cmbLoaiSP.SelectedValue)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Khai báo biến lấy Mã Sản phẩm mà dòng cần xóa được chọn trên gridview 
        Dim Ma_SP As String = Me.dgvSP.Rows(Me.dgvSP.CurrentCell.RowIndex).Cells("Ma_SP").Value

        'Khai báo câu lệnh Query để xóa
        Dim sqlQuery As String = String.Format("DELETE SanPham WHERE Ma_SP = '{0}'", Ma_SP)

        'Thực hiện xóa
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            LoadDataOngridView(Me.cmbLoaiSP.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        frmMain.ShowDialog()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmQuanLyKhachHang.ShowDialog()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmQuanLyHoaDon.ShowDialog()
    End Sub
End Class
