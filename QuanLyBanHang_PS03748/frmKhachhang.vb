Public Class frmKhachhang
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
    Private Function InsertKH() As Boolean
        Dim sqlQuery As String = "INSERT INTO KhachHang (Ma_KH, HoTen, SoDienThoai, DiaChi, Email)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')", txtMaKH.Text, txtHoten.Text, txtsdt.Text, txtdiachi.Text, txtemail.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Định nghĩa hàm update
    Private Function UpdateKH() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE KhachHang SET HoTen ='{0}', SoDienThoai ='{1}', DiaChi ='{2}', Email = '{3}' WHERE Ma_KH ='{4}'", _
                                                txtHoten.Text, txtsdt.Text, txtdiachi.Text, txtemail.Text, txtMaKH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Định nghĩa hàm kiểm tra giá trị trước khi Insert dữ liệu vào database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtMaKH.Text) OrElse String.IsNullOrEmpty(txtHoten.Text) OrElse String.IsNullOrEmpty(txtsdt.Text) OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse String.IsNullOrEmpty(txtemail.Text))
    End Function


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then 'Kiểm tra trường dữ liệu trước khi thực hiện Thêm, Sửa
            MessageBox.Show("Hãy nhập thông tin vào", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then 'Nếu là Edit thì gọi hàm update
                If UpdateKH() Then
                    MessageBox.Show("Sửa dữ liệu thành công", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Sửa lỗi dữ liệu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If

            Else    'Nếu không phải Edit thì gọi hàm Insert 
                If InsertKH() Then 'Nếu Insert thành công thì thông báo
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