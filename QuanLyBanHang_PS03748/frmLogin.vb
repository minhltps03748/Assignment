Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmLogin
    'Khai báo biến toàn cục kết nốiCSDL
    Private _ConnectionString As String = ConfigurationSettings.AppSettings("MyConnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    'Định nghĩa hàm lấy dữ liệu vào table
    Private Function getDatatable(sqlQuery As String) As DataTable
        Dim dtable As New DataTable
        'Khởi tạo biến conn
        conn = New SqlConnection(_ConnectionString)

        'Khởi tạo biến da
        da = New SqlDataAdapter(sqlQuery, conn)

        Try
            'mở connection
            conn.Open()

            'Đổ dữ liệu vào dtable
            da.Fill(dtable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error") 'thông báo lỗi
        Finally
            conn.Close()
        End Try
        Return dtable

    End Function

    'Định nghĩa hàm kiểm tra username, password nhập vào có đúng hay không
    Private Function CheckLogin(user As String, pass As String)
        Dim sqlQuery As String = String.Format("SELECT * FROM Login WHERE Username = '{0}' AND Password = '{1}'", user, pass)
        Dim dtable As DataTable = getDatatable(sqlQuery)
        Return dtable.Rows.Count > 0
    End Function

    'Định nghĩa hàm kiểm tra username, password có rỗng hay không
    Private Function IsEmpty() As Boolean
        'Hàm trả về True nếu username hoặc password is empty
        Return String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtPassword.Text)
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Kiểm tra username và password có nhập vào hay không
        If IsEmpty() Then
            MessageBox.Show("Username và Password Phải nhập vào!")
        Else
            If CheckLogin(txtUsername.Text.ToLower, txtPassword.Text.ToLower) Then
                DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show("Đăng nhập thành công")
                Close()
            Else
                MessageBox.Show("Username hoặc Password không đúng!")

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
End Class