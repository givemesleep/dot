Public Class main

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadDGV()
    End Sub

    Private Sub loadDGV()
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Dim str As String = "SELECT * FROM product"
        Try
            Call connectDB()
            da = New Odbc.OdbcDataAdapter(str, con)
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
            GC.Collect()
        End Try
    End Sub

    Private Sub toggle(ByVal bool As Boolean)
        btnNew.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        btnExit.Enabled = bool
        pnlDataEntry.Enabled = Not bool
        dgv.Enabled = bool
    End Sub

    Private Sub cleaner(ByVal pnl As Panel)
        For Each obj As Object In pnl.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        dgv.Tag = 0
        Call cleaner(pnlDataEntry)
        toggle(False)
        tbBrand.Focus()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim strInsert As String = "INSERT INTO product(brand,description,unit_price)VALUES(?,?,?)"
        Dim strUpdate As String = "UPDATE product SET brand=?, description=?,unit_price=? WHERE productid=?"
        Try
            Call connectDB()
            If Val(dgv.Tag) = 0 Then

                cmd = New Odbc.OdbcCommand(strInsert, con)
                cmd.Parameters.AddWithValue("@", Trim(tbBrand.Text))
                cmd.Parameters.AddWithValue("@", Trim(tbDescription.Text))
                cmd.Parameters.AddWithValue("@", Val(tbUnitPrice.Text))
            Else
                cmd = New Odbc.OdbcCommand(strUpdate, con)
                cmd.Parameters.AddWithValue("@", Trim(tbBrand.Text))
                cmd.Parameters.AddWithValue("@", Trim(tbDescription.Text))
                cmd.Parameters.AddWithValue("@", Val(tbUnitPrice.Text))
                cmd.Parameters.AddWithValue("@", Val(dgv.Tag))

            End If
            cmd.ExecuteNonQuery()
            Call cleaner(pnlDataEntry)
            Call toggle(False)
            Call loadDGV()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Cancel?", vbYesNo + vbQuestion, "Warning") = vbYes Then
            Call cleaner(pnlDataEntry)
            Call toggle(True)
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Try
            dgv.Tag = dgv.Item(0, e.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub loadRecord(ByVal id As Integer)
        Dim cmd As Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Dim str As String = "SELECT * FROM product WHERE productid=?"
        Try
            cmd = New Odbc.OdbcCommand(str, con)
            cmd.Parameters.AddWithValue("@", id)
            da.SelectCommand = cmd
            da.Fill(dt)
            tbBrand.Text = dt.Rows(0)(1).ToString
            tbDescription.Text = dt.Rows(0)(2).ToString
            tbUnitPrice.Text = dt.Rows(0)(3).ToString
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
            GC.Collect()
        End Try

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Val(dgv.Tag) = 0 Then
            MsgBox("Please select a record to edit!", vbCritical, "Warning")
        Else
            If MsgBox("Are you sure you want to edit the selected record?", vbYesNo + vbQuestion = "Warning") Then
                Call cleaner(pnlDataEntry)
                Call toggle(False)
                Call loadRecord(Val(dgv.Tag))
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As Odbc.OdbcCommand
        Dim str As String = "DELETE FROM product WHERE productid=?"
        If Val(dgv.Tag) = 0 Then
            MsgBox("Select a record to delete", vbCritical, "Warning")
        Else
            If MsgBox("Are you sure you want to DELETE the selected record?", vbYesNo + vbQuestion, "Warning") = vbYes Then
                Try
                    Call connectDB()
                    cmd = New Odbc.OdbcCommand(str, con)
                    cmd.Parameters.AddWithValue("@", Val(dgv.Tag))
                    cmd.ExecuteNonQuery()
                    loadDGV()
                    dgv.Tag = 0
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    con.Close()
                    GC.Collect()
                End Try
            End If
        End If
    End Sub
End Class

