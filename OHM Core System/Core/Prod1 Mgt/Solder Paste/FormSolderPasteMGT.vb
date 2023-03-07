Imports MySql.Data.MySqlClient

Public Class FormSolderPasteMGT

    Sub customdgv2()
        With DataGridView1 'Ganti dengan nama datagridview kalian
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.WrapMode = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 30
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(204, 0, 102)
            With .ColumnHeadersDefaultCellStyle
                .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .BackColor = Color.FromArgb(135, 156, 167)
                .ForeColor = Color.White
            End With
            With .RowTemplate
                .Height = 22
            End With
        End With
        With DataGridView2 'Ganti dengan nama datagridview kalian
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.WrapMode = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 30
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(204, 0, 102)
            With .ColumnHeadersDefaultCellStyle
                .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .BackColor = Color.FromArgb(135, 156, 167)
                .ForeColor = Color.White
            End With
            With .RowTemplate
                .Height = 22
            End With
        End With
        With DataGridView3 'Ganti dengan nama datagridview kalian
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.WrapMode = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 30
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(204, 0, 102)
            With .ColumnHeadersDefaultCellStyle
                .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .BackColor = Color.FromArgb(135, 156, 167)
                .ForeColor = Color.White
            End With
            With .RowTemplate
                .Height = 22
            End With
        End With
        With DataGridView4 'Ganti dengan nama datagridview kalian
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.WrapMode = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 30
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(204, 0, 102)
            With .ColumnHeadersDefaultCellStyle
                .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .BackColor = Color.FromArgb(135, 156, 167)
                .ForeColor = Color.White
            End With
            With .RowTemplate
                .Height = 22
            End With
        End With
    End Sub

    Sub KolomCoolingCase()
        DataGridView1.Columns(0).Width = 150 'Barcode
        DataGridView1.Columns(1).Width = 120 'Maker
        DataGridView1.Columns(2).Width = 120 'Type name
        DataGridView1.Columns(3).Width = 120 'top/bott
        DataGridView1.Columns(4).Width = 180 'start time
        DataGridView1.Columns(5).Width = 180 'running time
        DataGridView1.Columns(6).Width = 180 'end time
        DataGridView1.Columns(7).Width = 120 'status
    End Sub

    Sub KolomCheckRight()
        DataGridView2.Columns(0).Width = 150 'Barcode
        DataGridView2.Columns(1).Width = 120 'Maker
        DataGridView2.Columns(2).Width = 120 'Type name
        DataGridView2.Columns(3).Width = 120 'top/bott
        DataGridView2.Columns(4).Width = 120 'hole
        DataGridView2.Columns(5).Width = 180 'start time
        DataGridView2.Columns(6).Width = 180 'running time
        DataGridView2.Columns(7).Width = 180 'end time
        DataGridView2.Columns(8).Width = 180 'status
        DataGridView2.Columns(9).Width = 180 'pic
    End Sub

    Sub KolomMixer()
        DataGridView3.Columns(0).Width = 150 'Barcode
        DataGridView3.Columns(1).Width = 120 'Maker
        DataGridView3.Columns(2).Width = 120 'Type name
        DataGridView3.Columns(3).Width = 120 'top/bott
        DataGridView3.Columns(4).Width = 180 'start time
        DataGridView3.Columns(5).Width = 180 'running time
        DataGridView3.Columns(6).Width = 180 'end time
        DataGridView3.Columns(7).Width = 180 'status
    End Sub

    Sub KolomLine()
        DataGridView4.Columns(0).Width = 150 'Barcode
        DataGridView4.Columns(1).Width = 120 'Maker
        DataGridView4.Columns(2).Width = 120 'Type name
        DataGridView4.Columns(3).Width = 120 'top/bott
        DataGridView4.Columns(4).Width = 120 'line
        DataGridView4.Columns(5).Width = 180 'start time
        DataGridView4.Columns(6).Width = 180 'running time
        DataGridView4.Columns(7).Width = 180 'end time
        DataGridView4.Columns(8).Width = 180 'status
        DataGridView4.Columns(9).Width = 180 'pic
    End Sub

    Sub LoadDataCoolingCase()
        Try
            str = "SELECT txn_id, maker, n_type, topbott, start_time, run_time, end_time, status FROM prodsys2_solder_paste_mgt_coolingcase_tbl WHERE status = 'AVAILABLE'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call KolomCoolingCase()
    End Sub

    Sub LoadDataCheckRight()
        Try
            str = "SELECT txn_id, maker, n_type, topbott, hole, start_time, run_time, end_time, status, pic FROM prodsys2_solder_paste_mgt_checkright_tbl WHERE status = 'AVAILABLE'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call KolomCheckRight()
    End Sub

    Sub LoadDataMixer()
        Try
            str = "SELECT txn_id, maker, n_type, topbott, start_time, run_time, end_time, status FROM prodsys2_solder_paste_mgt_mixer_tbl WHERE status = 'AVAILABLE'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView3.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call KolomMixer()
    End Sub

    Sub LoadDataLine()
        Try
            str = "SELECT txn_id, maker, n_type, topbott, line, start_time, run_time, end_time, status, pic FROM prodsys2_solder_paste_mgt_line_tbl WHERE status = 'AVAILABLE'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView4.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call KolomLine()
    End Sub

    Sub ShowCountCoolingCase()
        Label3.Text = DataGridView1.RowCount
        TabPage1.Text = "Cooling Case [" & DataGridView1.RowCount & "]"
    End Sub

    Sub ShowCountCheckRight()
        Label6.Text = DataGridView2.RowCount
        TabPage2.Text = "Check Right [" & DataGridView2.RowCount & "]"
    End Sub

    Sub ShowCountMixer()
        Label11.Text = DataGridView3.RowCount
        TabPage3.Text = "Mixer [" & DataGridView3.RowCount & "]"
    End Sub

    Sub ShowCountLine()
        Label7.Text = DataGridView4.RowCount
        TabPage4.Text = "Line [" & DataGridView4.RowCount & "]"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormCoolingCase.ShowDialog()
    End Sub

    Private Sub FormSolderPasteMGT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call customdgv2()
        'Call KolomCoolingCase()
        'Call KolomCheckRight()
        'Call KolomMixer()
        'Call KolomLine()

        Call LoadDataCoolingCase()
        Call LoadDataCheckRight()
        Call LoadDataMixer()
        'Call LoadDataLine()

        Call ShowCountCoolingCase()
        Call ShowCountCheckRight()
        Call ShowCountMixer()
        Call ShowCountLine()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call connection()
        For Baris As Integer = 0 To DataGridView1.Rows.Count - 1
            rd.Close()
            str = "SELECT * FROM prodsys2_solder_paste_mgt_coolingcase_tbl WHERE txn_id='" & DataGridView1.Rows(Baris).Cells(0).Value.ToString & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    'Label15.Text = rd("start_time")
                    Dim now As DateTime = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Dim start As DateTime = rd.Item("start_time")
                    Dim durasi As TimeSpan = New TimeSpan

                    durasi = now - start
                    DataGridView1.Rows(Baris).Cells(5).Value = durasi
                    'Label16.Text = durasi.ToString

                    'If DataGridView2.Rows(Baris).Cells(12).Value = "7d.00:00:00" Then
                    'FormPopupInfoMSL3.Label1.Text = "EXPIRED"
                    'FormPopupInfoMSL3.Label2.Text = DataGridView2.Rows(Baris).Cells(0).Value
                    'DataGridView2.Rows(Baris).Cells(12).Style.BackColor = Color.Lime
                    'DataGridView2.Rows(Baris).Cells(12).Style.ForeColor = Color.Black
                    'FormPopupInfoMSL3.ShowDialog()
                    'End If
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End Try
        Next
        rd.Close()
        conn.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Call connection()
        For Baris As Integer = 0 To DataGridView2.Rows.Count - 1
            rd.Close()
            str = "SELECT * FROM prodsys2_solder_paste_mgt_checkright_tbl WHERE txn_id='" & DataGridView2.Rows(Baris).Cells(0).Value.ToString & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    'Label15.Text = rd("start_time")
                    Dim now As DateTime = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Dim start As DateTime = rd.Item("start_time")
                    Dim durasi As TimeSpan = New TimeSpan

                    durasi = now - start
                    DataGridView2.Rows(Baris).Cells(6).Value = durasi
                    'Label16.Text = durasi.ToString
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End Try

            If DataGridView2.Rows(Baris).Cells(6).Value = "02:00:00" Then
                FormPopupInfoCheckRight.Label1.Text = DataGridView2.Rows(Baris).Cells(0).Value
                FormPopupInfoCheckRight.Label2.Text = "SUDAH LEBIH DARI 2 JAM"
                DataGridView2.Rows(Baris).Cells(6).Style.BackColor = Color.Lime
                DataGridView2.Rows(Baris).Cells(6).Style.ForeColor = Color.Black
                FormPopupInfoCheckRight.Show()

                Dim sql As String
                rd.Close()
                sql = "UPDATE prodsys2_solder_paste_mgt_checkright_tbl SET run_time = @run_time, end_time = @end_time, status = @status WHERE txn_id = @txn_id"
                cmd.Connection = conn
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@txn_id", DataGridView2.Rows(Baris).Cells(0).Value)
                cmd.Parameters.AddWithValue("@run_time", DataGridView2.Rows(Baris).Cells(6).Value)
                cmd.Parameters.AddWithValue("@end_time", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                cmd.Parameters.AddWithValue("@status", "EMPTY")
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
        Next
        rd.Close()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormCheckRight.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call LoadDataCoolingCase()
        Call LoadDataCheckRight()
        Call LoadDataMixer()
        Call ShowCountCoolingCase()
        Call ShowCountCheckRight()
        Call ShowCountMixer()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormMixer.ShowDialog()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Call connection()
        For Baris As Integer = 0 To DataGridView3.Rows.Count - 1
            rd.Close()
            str = "SELECT * FROM prodsys2_solder_paste_mgt_mixer_tbl WHERE txn_id='" & DataGridView3.Rows(Baris).Cells(0).Value.ToString & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    'Label15.Text = rd("start_time")
                    Dim now As DateTime = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Dim start As DateTime = rd.Item("start_time")
                    Dim durasi As TimeSpan = New TimeSpan

                    durasi = now - start
                    DataGridView3.Rows(Baris).Cells(5).Value = durasi
                    'Label16.Text = durasi.ToString
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End Try

            If DataGridView3.Rows(Baris).Cells(5).Value = "00:00:45" Then
                FormPopupInfoMixer.Label1.Text = DataGridView3.Rows(Baris).Cells(0).Value
                FormPopupInfoMixer.Label2.Text = "MIXING SUDAH SELESAI!"
                DataGridView3.Rows(Baris).Cells(5).Style.BackColor = Color.Lime
                DataGridView3.Rows(Baris).Cells(5).Style.ForeColor = Color.Black
                FormPopupInfoMixer.Show()

                Dim sql As String
                rd.Close()
                sql = "UPDATE prodsys2_solder_paste_mgt_mixer_tbl SET run_time = @run_time, end_time = @end_time, status = @status WHERE txn_id = @txn_id"
                cmd.Connection = conn
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@txn_id", DataGridView3.Rows(Baris).Cells(0).Value)
                cmd.Parameters.AddWithValue("@run_time", DataGridView3.Rows(Baris).Cells(5).Value)
                cmd.Parameters.AddWithValue("@end_time", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                cmd.Parameters.AddWithValue("@status", "EMPTY")
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
        Next
        rd.Close()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Call connection()
        For Baris As Integer = 0 To DataGridView4.Rows.Count - 1
            rd.Close()
            str = "SELECT * FROM prodsys2_solder_paste_mgt_line_tbl WHERE txn_id='" & DataGridView4.Rows(Baris).Cells(0).Value.ToString & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    'Label15.Text = rd("start_time")
                    Dim now As DateTime = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Dim start As DateTime = rd.Item("start_time")
                    Dim durasi As TimeSpan = New TimeSpan

                    durasi = now - start
                    DataGridView1.Rows(Baris).Cells(6).Value = durasi
                    'Label16.Text = durasi.ToString

                    'If DataGridView2.Rows(Baris).Cells(12).Value = "7d.00:00:00" Then
                    'FormPopupInfoMSL3.Label1.Text = "EXPIRED"
                    'FormPopupInfoMSL3.Label2.Text = DataGridView2.Rows(Baris).Cells(0).Value
                    'DataGridView2.Rows(Baris).Cells(12).Style.BackColor = Color.Lime
                    'DataGridView2.Rows(Baris).Cells(12).Style.ForeColor = Color.Black
                    'FormPopupInfoMSL3.ShowDialog()
                    'End If
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End Try
        Next
        rd.Close()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormTrashSolderPaste.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormLine.ShowDialog()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TextBox2.Text = "COOLING CASE IN" Then
                FormCoolingCase.ShowDialog()
                TextBox2.Clear()
            ElseIf TextBox2.Text = "CHECKRIGHT" Then
                FormCheckRight.ShowDialog()
                TextBox2.Clear()
            ElseIf TextBox2.Text = "MIXER" Then
                FormMixer.ShowDialog()
                TextBox2.Clear()
            ElseIf TextBox2.Text = "LINEIN" Then
                FormLine.ShowDialog()
                TextBox2.Clear()
            ElseIf TextBox2.Text = "TRASH" Then
                FormTrashSolderPaste.ShowDialog()
                TextBox2.Clear()
            Else
                MsgBox("KODE SALAH!", vbInformation)
                TextBox2.Clear()
            End If
        End If
    End Sub
End Class