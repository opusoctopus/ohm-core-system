Public Class FormAttachMetalmask
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FormAttachMetalmask_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            conn.Open()
            str = "SELECT * FROM prodsys2_master_stencil_tbl WHERE kode_stencil='" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    TextBox1.Text = rd("kode_stencil")
                    TextBox2.Text = rd("pn_pcb")
                Else
                    MsgBox("STENCIL CODE NOT EXIST", vbInformation)
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    rd.Close()
                    conn.Close()
                    conn.Open()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rd.Close()
                conn.Close()
                conn.Dispose()
            End Try
            rd.Close()
            conn.Close()
            conn.Dispose()
        End If
    End Sub
End Class