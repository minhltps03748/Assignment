Public Class frmQuanLyHoaDon
    'Khai biến để truy xuất database từ lớp DatabaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False

    'Định nghĩa thủ tục load dữ liệu từ bảng lớp vào ComboBox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "SElECT Ma_KH FROM KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbMaKH.DataSource = dTable
        Me.cmbMaKH.ValueMember = "Ma_KH"
        Me.cmbMaKH.DisplayMember = "Ma_KH"

    End Sub
    'Định nghĩa thủ tục load dử liệu từ bảng Mã loại Sản phẩm theo từng lớp vào gridview
    Private Sub LoadDataOngridView(Ma_KH As String)
        Dim sqlQuery As String = _
            String.Format("SELECT Ma_HD, NgayLapHD FROM HoaDon WHERE Ma_KH = '{0}'", Ma_KH)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvHD.DataSource = dTable
        With Me.dgvHD
            .Columns(0).HeaderText = "Ma_HD"
            .Columns(1).HeaderText = "NgayLapHD"
        End With
    End Sub

    Private Sub frmQuanLyHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True

        LoadDataOnComBobox()
        LoadDataOngridView(Me.cmbMaKH.SelectedValue)

        _isLoading = False
    End Sub

    Private Sub cmbMaKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaKH.SelectedIndexChanged
        If Not _isLoading Then
            LoadDataOngridView(Me.cmbMaKH.SelectedValue)
        End If
    End Sub
    'Định nghĩa thủ tục hiển thị kết quả Search: theo phương pháp tương tự - Tìm kiếm tương tự
    Private Sub SearchHD(MaKh As String, value As String)
        Dim sqlQuery As String = _
        String.Format("SELECT Ma_HD, NgayLapHD FROM HoaDon WHERE Ma_KH = '{0}'", MaKh)
        If cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format("AND Ma_HD LIKE '{0}%'", value)
        End If
        Dim dtable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvHD.DataSource = dtable
        With dgvHD
            .Columns(0).HeaderText = "Ma_HD"
            .Columns(1).HeaderText = "NgayLapHD"
        End With
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchHD(Me.cmbMaKH.SelectedValue, Me.txtSearch.Text)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmHoaDon(False)
        frm.txtMaKH.Text = Me.cmbMaKH.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            'load dữ liệu'
            LoadDataOngridView(Me.cmbMaKH.SelectedValue)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frmHoaDon(True)
        frm.txtMaKH.Text = Me.cmbMaKH.SelectedValue
        frm.txtMaHD.ReadOnly = True
        With Me.dgvHD
            frm.txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("Ma_HD").Value
            frm.txtNgayLapHD.Text = .Rows(.CurrentCell.RowIndex).Cells("NgayLapHD").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then  'Sửa dữ liệu thành công thì load lại vào Gridview
            LoadDataOngridView(Me.cmbMaKH.SelectedValue)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Khai báo biến lấy Mã Sản phẩm mà dòng cần xóa được chọn trên gridview 
        Dim Ma_HD As String = Me.dgvHD.Rows(Me.dgvHD.CurrentCell.RowIndex).Cells("Ma_HD").Value

        'Khai báo câu lệnh Query để xóa
        Dim sqlQuery As String = String.Format("DELETE HoaDon WHERE Ma_HD = '{0}'", Ma_HD)

        'Thực hiện xóa
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            LoadDataOngridView(Me.cmbMaKH.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmQuanLyKhachHang.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmQuanLySP.ShowDialog()
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        frmMain.ShowDialog()
    End Sub
End Class