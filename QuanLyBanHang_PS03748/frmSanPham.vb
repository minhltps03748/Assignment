Public Class frmSanPham
    'Khai báo biến truy xuất Database từ lớp DBAccess
    Private _DBAccess As New DataBaseAccess
    'Khai báo biến để biết đạy là Edit hay Insert
    Private _isEdit As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    'Định nghĩa hàm thêm bản ghi SP vào database
    Private Function InsertSP() As Boolean
        Dim sqlQuery As String = "INSERT INTO SanPham (Ma_SP, Ten_SP, DonGia, DonViTinh, Ma_LoaiSP)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')", txtMaSP.Text, txtTenSP.Text, txtDongia.Text, txtDonvitinh.Text, txtMaloaiSP.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Định nghĩa hàm update
    Private Function UpdateSP() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE SanPham SET Ten_SP ='{0}', DonGia ='{1}', DonViTinh ='{2}' WHERE Ma_SP ='{3}'", _
                                                Me.txtTenSP.Text, Me.txtDongia.Text, Me.txtDonvitinh.Text, Me.txtMaSP.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Định nghĩa hàm kiểm tra giá trị trước khi Insert dữ liệu vào database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaSP.Text) OrElse String.IsNullOrEmpty(txtTenSP.Text) OrElse String.IsNullOrEmpty(txtDongia.Text) OrElse String.IsNullOrEmpty(txtDonvitinh.Text) OrElse String.IsNullOrEmpty(txtMaloaiSP.Text))
    End Function


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then 'Kiểm tra trường dữ liệu trước khi thực hiện Thêm, Sửa
            MessageBox.Show("Hãy nhập thông tin vào", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then 'Nếu là Edit thì gọi hàm update
                If UpdateSP() Then
                    MessageBox.Show("Sửa dữ liệu thành công", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Sửa lỗi dữ liệu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If

            Else    'Nếu không phải Edit thì gọi hàm Insert 
                If InsertSP() Then 'Nếu Insert thành công thì thông báo
                    MessageBox.Show("Dữ liệu thêm vào thành công!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else

                    MessageBox.Show("Lỗi thêm dữ liệu vào!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If

            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class