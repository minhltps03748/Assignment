Public Class frmMain

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmQuanLySP.ShowDialog()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmQuanLyKhachHang.ShowDialog()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmQuanLyHoaDon.ShowDialog()
    End Sub
    'Khai báo biến nhận kết quả trả về của form Login
    Private _LoginResult As DialogResult

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _LoginResult <> Windows.Forms.DialogResult.OK Then
            Close()
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim frm As New frmLogin
        frm.ShowDialog()
        _LoginResult = frm.DialogResult
    End Sub
End Class