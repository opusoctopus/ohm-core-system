Imports MySql.Data.MySqlClient

Public Class FormMixer

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
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns(0).Width = 150 'Barcode
        DataGridView1.Columns(1).Width = 120 'Maker
        DataGridView1.Columns(2).Width = 120 'Type name
        DataGridView1.Columns(3).Width = 120 'top/bott
        DataGridView1.Columns(4).Width = 180 'start time
        DataGridView1.Columns(5).Width = 180 'running time
        DataGridView1.Columns(6).Width = 180 'end time
        DataGridView1.Columns(7).Width = 120 'status
    End Sub

    Sub LoadData()
        Try
            str = "SELECT txn_id, maker, n_type, topbott, start_time, run_time, end_time, status FROM prodsys2_solder_paste_mgt_checkright_tbl WHERE txn_id = '" & TextBox1.Text & "' AND status = 'AVAILABLE'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call BuatKolom()
        rd.Close()
        conn.Close()
        conn.Dispose()
    End Sub

    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label9.Text = ""
        Label10.Text = ""
        DataGridView1.DataSource = Nothing
        ComboBox1.SelectedItem = Nothing
        TextBox1.Select()
    End Sub

    Sub KolomCoolingCase()
        FormSolderPasteMGT.DataGridView1.Columns(0).Width = 150 'Barcode
        FormSolderPasteMGT.DataGridView1.Columns(1).Width = 120 'Maker
        FormSolderPasteMGT.DataGridView1.Columns(2).Width = 120 'Type name
        FormSolderPasteMGT.DataGridView1.Columns(3).Width = 120 'top/bott
        FormSolderPasteMGT.DataGridView1.Columns(4).Width = 180 'start time
        FormSolderPasteMGT.DataGridView1.Columns(5).Width = 180 'running time
        FormSolderPasteMGT.DataGridView1.Columns(6).Width = 180 'end time
        FormSolderPasteMGT.DataGridView1.Columns(7).Width = 120 'status
    End Sub

    Sub KolomCheckRight()
        FormSolderPasteMGT.DataGridView2.Columns(0).Width = 150 'Barcode
        FormSolderPasteMGT.DataGridView2.Columns(1).Width = 120 'Maker
        FormSolderPasteMGT.DataGridView2.Columns(2).Width = 120 'Type name
        FormSolderPasteMGT.DataGridView2.Columns(3).Width = 120 'top/bott
        FormSolderPasteMGT.DataGridView2.Columns(4).Width = 120 'hole
        FormSolderPasteMGT.DataGridView2.Columns(5).Width = 180 'start time
        FormSolderPasteMGT.DataGridView2.Columns(6).Width = 180 'running time
        FormSolderPasteMGT.DataGridView2.Columns(7).Width = 180 'end time
        FormSolderPasteMGT.DataGridView2.Columns(8).Width = 180 'status
        FormSolderPasteMGT.DataGridView2.Columns(9).Width = 180 'pic
    End Sub

    Sub KolomMixer()
        FormSolderPasteMGT.DataGridView3.Columns(0).Width = 150 'Barcode
        FormSolderPasteMGT.DataGridView3.Columns(1).Width = 120 'Maker
        FormSolderPasteMGT.DataGridView3.Columns(2).Width = 120 'Type name
        FormSolderPasteMGT.DataGridView3.Columns(3).Width = 120 'top/bott
        FormSolderPasteMGT.DataGridView3.Columns(4).Width = 180 'start time
        FormSolderPasteMGT.DataGridView3.Columns(5).Width = 180 'running time
        FormSolderPasteMGT.DataGridView3.Columns(6).Width = 180 'end time
        FormSolderPasteMGT.DataGridView3.Columns(7).Width = 180 'status
    End Sub

    Sub KolomLine()
        FormSolderPasteMGT.DataGridView4.Columns(0).Width = 150 'Barcode
        FormSolderPasteMGT.DataGridView4.Columns(1).Width = 120 'Maker
        FormSolderPasteMGT.DataGridView4.Columns(2).Width = 120 'Type name
        FormSolderPasteMGT.DataGridView4.Columns(3).Width = 120 'top/bott
        FormSolderPasteMGT.DataGridView4.Columns(4).Width = 120 'line
        FormSolderPasteMGT.DataGridView4.Columns(5).Width = 180 'start time
        FormSolderPasteMGT.DataGridView4.Columns(6).Width = 180 'running time
        FormSolderPasteMGT.DataGridView4.Columns(7).Width = 180 'end time
        FormSolderPasteMGT.DataGridView2.Columns(8).Width = 180 'status
        FormSolderPasteMGT.DataGridView4.Columns(9).Width = 180 'pic
    End Sub

    Sub LoadDataCoolingCase()
        Try
            str = "SELECT txn_id, maker, n_type, topbott, start_time, run_time, end_time, status FROM prodsys2_solder_paste_mgt_coolingcase_tbl WHERE status = 'AVAILABLE'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            FormSolderPasteMGT.DataGridView1.DataSource = dt
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
            FormSolderPasteMGT.DataGridView2.DataSource = dt
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
            FormSolderPasteMGT.DataGridView3.DataSource = dt
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
            FormSolderPasteMGT.DataGridView4.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call KolomLine()
    End Sub

    Sub ShowCountCoolingCase()
        FormSolderPasteMGT.Label3.Text = FormSolderPasteMGT.DataGridView1.RowCount
        FormSolderPasteMGT.TabPage1.Text = "Cooling Case [" & FormSolderPasteMGT.DataGridView1.RowCount & "]"
    End Sub

    Sub ShowCountCheckRight()
        FormSolderPasteMGT.Label6.Text = FormSolderPasteMGT.DataGridView2.RowCount
        FormSolderPasteMGT.TabPage2.Text = "Check Right [" & FormSolderPasteMGT.DataGridView2.RowCount & "]"
    End Sub

    Sub ShowCountMixer()
        FormSolderPasteMGT.Label11.Text = FormSolderPasteMGT.DataGridView3.RowCount
        FormSolderPasteMGT.TabPage3.Text = "Mixer [" & FormSolderPasteMGT.DataGridView3.RowCount & "]"
    End Sub

    Sub ShowCountLine()
        FormSolderPasteMGT.Label7.Text = FormSolderPasteMGT.DataGridView4.RowCount
        FormSolderPasteMGT.TabPage4.Text = "Line [" & FormSolderPasteMGT.DataGridView4.RowCount & "]"
    End Sub

    Sub CheckFIFO()
        If ComboBox1.Text = "TOP" Then
            Call connection()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT txn_id FROM prodsys2_solder_paste_mgt_mixer_tbl WHERE txn_id IN (SELECT MAX(txn_id) FROM prodsys2_solder_paste_mgt_mixer_tbl WHERE topbott='TOP')", conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Label7.Text = rd("txn_id")
                If Len(Label7.Text) > 10 Then
                    Label7.Text = Strings.Left(Label7.Text, 10)
                End If
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
                UrutanKode = Label7.Text + Microsoft.VisualBasic.Right("000" & Hitung, 3)
                Label8.Text = UrutanKode
                rd.Close()
                conn.Close()
                conn.Dispose()
            End If
        ElseIf ComboBox1.Text = "BOTTOM" Then
            Call connection()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT txn_id FROM prodsys2_solder_paste_mgt_mixer_tbl WHERE txn_id IN (SELECT MAX(txn_id) FROM prodsys2_solder_paste_mgt_mixer_tbl WHERE topbott='BOTTOM')", conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Label7.Text = rd("txn_id")
                If Len(Label7.Text) > 10 Then
                    Label7.Text = Strings.Left(Label7.Text, 10)
                End If
                Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
                UrutanKode = Label7.Text + Microsoft.VisualBasic.Right("000" & Hitung, 3)
                Label8.Text = UrutanKode
                rd.Close()
                conn.Close()
                conn.Dispose()
            End If
        End If
    End Sub

    Private Sub FormMixer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call customdgv2()

        TextBox1.Select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call connection()
        For Baris As Integer = 0 To DataGridView1.Rows.Count - 1
            rd.Close()
            str = "SELECT * FROM prodsys2_solder_paste_mgt_checkright_tbl WHERE txn_id='" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    Dim now As DateTime = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Dim start As DateTime = rd.Item("start_time")
                    Dim durasi As TimeSpan = New TimeSpan

                    durasi = now - start
                    Label10.Text = durasi.ToString
                    'Label10.Text = DataGridView1.Rows(Baris).Cells(5).Value

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
        str = "SELECT * FROM prodsys2_solder_paste_mgt_checkright_tbl WHERE txn_id='" & TextBox1.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows Then
                If rd("run_time").ToString = "" Then
                    Dim sql As String
                    rd.Close()
                    sql = "UPDATE prodsys2_solder_paste_mgt_checkright_tbl SET run_time = @run_time, end_time = @end_time, status = @status WHERE txn_id = @txn_id"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@txn_id", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@run_time", Label10.Text)
                    cmd.Parameters.AddWithValue("@end_time", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@status", "ALREADY CHECKRIGHT")
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                Else
                    Timer1.Stop()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        rd.Close()
        conn.Close()
        conn.Dispose()
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call connection()
        str = "SELECT * FROM prodsys2_solder_paste_mgt_checkright_tbl WHERE txn_id='" & TextBox1.Text & "' AND status = 'EMPTY'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows Then
                TextBox2.Text = rd("maker")
                'TextBox3.Text = rd("n_type")
                ComboBox1.Text = rd("topbott")
                rd.Close()
                Call LoadData()
                conn.Open()
                cmd = New MySql.Data.MySqlClient.MySqlCommand
                cmd.Connection = conn
                str = "INSERT INTO `prodsys2_solder_paste_mgt_mixer_tbl`(`txn_id`, `maker`, `n_type`, `topbott`, `start_time`, `status`) VALUES (@txn_id,@maker,@n_type,@topbott,@start_time,@status)"
                cmd.Parameters.Add("@txn_id", MySqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@maker", MySqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@n_type", MySqlDbType.VarChar).Value = TextBox3.Text
                cmd.Parameters.Add("@topbott", MySqlDbType.VarChar).Value = ComboBox1.Text
                cmd.Parameters.Add("@start_time", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = "AVAILABLE"
                cmd.CommandText = str
                Try
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    Timer1.Enabled = True
                    Timer1.Start()
                Catch ex As Exception
                    MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    rd.Close()
                    conn.Close()
                    conn.Dispose()
                End Try
            Else
                MsgBox("SOLDER PASTE STILL CHECKRIGHT PROCESS!", vbInformation)
                Call bersih()
                rd.Close()
                conn.Close()
                conn.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rd.Close()
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class