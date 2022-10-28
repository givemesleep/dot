Public Class frmCRUD

    Private Sub frmCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadDGV("SELECT * FROM product", dgv)
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Call loadDGV("SELECT * FROM product", dgv, "description", Trim(txtsearch.Text))
    End Sub
End Class
