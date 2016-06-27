

Public Class frmQuanLyKhachHang
    'Khai biến để truy xuất database từ lớp DatabaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến trạng thái kiểm tra dữ liệu đang load
    Private _isLoading As Boolean = False

    'Định nghĩa thủ tục load dử liệu từ bảng Mã loại Sản phẩm theo từng lớp vào gridview
    Private Sub LoadDataOngridView()
        Dim sqlQuery As String = String.Format("SELECT Ma_KH, HoTen, SoDienThoai, DiaChi, Email FROM  KhachHang")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvKH.DataSource = dTable
        With dgvKH
            .Columns(0).HeaderText = "Ma_KH"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "SoDienThoai"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(4).HeaderText = "Email"
        End With
    End Sub


    'Định nghĩa thủ tục hiển thị kết quả Search: theo phương pháp tương tự - Tìm kiếm tương tự
    Private Sub SearchKH(value As String)
        Dim sqlQuery As String = _
            String.Format("SELECT Ma_KH, HoTen, SoDienThoai, DiaChi, Email FROM KhachHang")
        If Me.cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format(" WHERE Ma_KH  LIKE '{0}%'", value)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format(" WHERE HoTen LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvKH.DataSource = dTable
        With dgvKH
            .Columns(0).HeaderText = "Ma_KH"
            .Columns(1).HeaderText = "HoTen"
            .Columns(2).HeaderText = "SoDienThoai"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(4).HeaderText = "Email"
        End With
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchKH(Me.txtSearch.Text)

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmKhachhang(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            'load dữ liệu'
            LoadDataOngridView()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frmKhachhang(True)
        frm.txtMaKH.ReadOnly = True
        With Me.dgvKH
            frm.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("Ma_KH").Value
            frm.txtHoten.Text = .Rows(.CurrentCell.RowIndex).Cells("HoTen").Value
            frm.txtsdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SoDienThoai").Value
            frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            frm.txtemail.Text = .Rows(.CurrentCell.RowIndex).Cells("Email").Value

        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then  'Sửa dữ liệu thành công thì load lại vào Gridview
            LoadDataOngridView()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Khai báo biến lấy Mã Sản phẩm mà dòng cần xóa được chọn trên gridview 
        Dim Ma_KH As String = Me.dgvKH.Rows(Me.dgvKH.CurrentCell.RowIndex).Cells("Ma_KH").Value

        'Khai báo câu lệnh Query để xóa
        Dim sqlQuery As String = String.Format("DELETE KhachHang WHERE Ma_KH = '{0}'", Ma_KH)

        'Thực hiện xóa
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            LoadDataOngridView()
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If
    End Sub
   

    Private Sub frmQuanLyKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOngridView()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmQuanLyHoaDon.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmQuanLySP.ShowDialog()
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        frmMain.ShowDialog()
    End Sub
End Class