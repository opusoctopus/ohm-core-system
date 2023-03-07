Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class FormMasterMSL3
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox2.Focus()
    End Sub

    Sub cancel()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Sub add()
        GroupBox1.Enabled = True
        Call NomorOtomatis()
        TextBox2.Select()
    End Sub

    Sub off()
        conn.Close()
        GroupBox1.Enabled = False
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 149
        DataGridView1.Columns(6).Width = 200

        DataGridView2.Columns(0).Width = 125 ' unique id
        DataGridView2.Columns(1).Width = 110 ' pn_maker
        DataGridView2.Columns(2).Width = 100
        DataGridView2.Columns(3).Width = 50
        DataGridView2.Columns(4).Width = 50 ' qty
        DataGridView2.Columns(5).Width = 149
        DataGridView2.Columns(6).Width = 80 ' line
        DataGridView2.Columns(7).Width = 200
        DataGridView2.Columns(8).Width = 200
        DataGridView2.Columns(9).Width = 200
        DataGridView2.Columns(10).Width = 200
        DataGridView2.Columns(11).Width = 125 ' Start time
        DataGridView2.Columns(12).Width = 80 ' Run time
        DataGridView2.Columns(13).Width = 200
        DataGridView2.Columns(14).Width = 200
        DataGridView2.Columns(15).Width = 200
        DataGridView2.Columns(16).Width = 200
        DataGridView2.Columns(17).Width = 125
        DataGridView2.Columns(18).Width = 200
    End Sub

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
    End Sub

    Sub NomorOtomatis()
        conn.Open()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM prodsys2_master_msl3_tbl WHERE unique_id IN (SELECT MAX(unique_id) FROM prodsys2_master_msl3_tbl)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = "MSL3" + System.DateTime.Now.ToString("yyyyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            UrutanKode = "MSL3" + System.DateTime.Now.ToString("yyyyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
        rd.Close()
        conn.Close()
    End Sub

    Sub LoadData()
        Try
            str = "SELECT unique_id, pn_maker, pn_lg, lot_id, qty, incoming_date, created FROM prodsys2_master_msl3_tbl"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Try
            str = "SELECT * FROM prodsys2_msl3_transaction_attach_log_tbl WHERE is_detach = '0'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt
            With DataGridView2
                .Columns("pn_maker").Visible = False
                .Columns("lot_id").Visible = False
                .Columns("incoming_date").Visible = False
                .Columns("shift").Visible = False
                .Columns("supply_wo").Visible = False
                .Columns("lot_qty").Visible = False
                .Columns("pn").Visible = False
                .Columns("end_time").Visible = False
                .Columns("employee").Visible = False
                .Columns("remark").Visible = False
                .Columns("is_detach").Visible = False
                .Columns("date_detach").Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Try
            str = "SELECT * FROM prodsys2_msl3_transaction_attach_log_tbl WHERE is_detach = '1'"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView3.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Sub showcount()
        Label7.Text = DataGridView1.RowCount
        Label12.Text = DataGridView2.RowCount
        Label15.Text = DataGridView3.RowCount
    End Sub

    Public Sub StripNonAlphabetCharacters(ByVal input As TextBox)
        ' pattern matches any character that is NOT A-Z (allows upper and lower case alphabets)
        Dim rx As New Regex("[^0-9]")
        If (rx.IsMatch(input.Text)) Then
            Dim startPosition As Integer = input.SelectionStart - 1
            input.Text = rx.Replace(input.Text, "")
            input.SelectionStart = startPosition
        End If
    End Sub

    Private Sub FormMasterMSL3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call bersih()
        Call off()
        Call LoadData()
        Call customdgv2()
        Call BuatKolom()
        Call showcount()
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call add()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            TextBox5.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn.Open()
        cmd = New MySql.Data.MySqlClient.MySqlCommand
        cmd.Connection = conn
        str = "INSERT INTO `prodsys2_master_msl3_tbl`(`unique_id`, `pn_maker`, `pn_lg`, `lot_id`, `qty`, `incoming_date`, `created`) VALUES (@unique_id,@pn_maker,@pn_lg,@lot_id,@qty,@incoming_date,@created)"
        cmd.Parameters.Add("@unique_id", MySqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@pn_maker", MySqlDbType.VarChar).Value = TextBox2.Text
        cmd.Parameters.Add("@pn_lg", MySqlDbType.VarChar).Value = TextBox3.Text
        cmd.Parameters.Add("@lot_id", MySqlDbType.VarChar).Value = TextBox4.Text
        cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = TextBox5.Text
        cmd.Parameters.Add("@incoming_date", MySqlDbType.VarChar).Value = DateTimePicker1.Text
        cmd.Parameters.Add("@created", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        cmd.CommandText = str
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        Call bersih()
        Call off()
        Call LoadData()
        Call showcount()
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call bersih()
        Call off()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        StripNonAlphabetCharacters(TextBox5)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FormAttachMSL3.TextBox1.Text = Me.DataGridView1.SelectedCells(0).Value.ToString ' Unique ID
        FormAttachMSL3.TextBox2.Text = Me.DataGridView1.SelectedCells(1).Value.ToString ' PN Maker
        FormAttachMSL3.TextBox3.Text = Me.DataGridView1.SelectedCells(2).Value.ToString ' PN LG
        FormAttachMSL3.TextBox4.Text = Me.DataGridView1.SelectedCells(3).Value.ToString ' Lot ID
        FormAttachMSL3.TextBox5.Text = Me.DataGridView1.SelectedCells(4).Value.ToString ' Qty
        FormAttachMSL3.TextBox6.Text = Me.DataGridView1.SelectedCells(5).Value.ToString ' Incoming Date
        FormAttachMSL3.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormProdPlanMSL3.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label14.Text = FormatDateTime(Now, DateFormat.GeneralDate)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Call connection()
        For Baris As Integer = 0 To DataGridView2.Rows.Count - 1
            rd.Close()
            str = "SELECT * FROM prodsys2_msl3_transaction_attach_log_tbl WHERE unique_id='" & DataGridView2.Rows(Baris).Cells(0).Value.ToString & "'"
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
                    DataGridView2.Rows(Baris).Cells(12).Value = durasi
                    'Label16.Text = durasi.ToString

                    If DataGridView2.Rows(Baris).Cells(12).Value = "7d.00:00:00" Then
                        FormPopupInfoMSL3.Label1.Text = "EXPIRED"
                        FormPopupInfoMSL3.Label2.Text = DataGridView2.Rows(Baris).Cells(0).Value
                        DataGridView2.Rows(Baris).Cells(12).Style.BackColor = Color.Lime
                        DataGridView2.Rows(Baris).Cells(12).Style.ForeColor = Color.Black
                        FormPopupInfoMSL3.ShowDialog()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
            End Try
        Next
        rd.Close()
        conn.Close()
        'If durasi > TimeSpan.FromDays(7) Then
        'TextBox16.BackColor = Color.Red
        'TextBox16.ForeColor = Color.AntiqueWhite
        'Else
        'TextBox16.ReadOnly = True
        'End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call bersih()
        Call off()
        Call LoadData()
        Call customdgv2()
        Call BuatKolom()
        Call showcount()
        TextBox1.ReadOnly = True
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        FormDetachMSL3.TextBox1.Text = Me.DataGridView2.SelectedCells(0).Value.ToString ' Unique ID
        FormDetachMSL3.TextBox2.Text = Me.DataGridView2.SelectedCells(1).Value.ToString ' PN Maker
        FormDetachMSL3.TextBox3.Text = Me.DataGridView2.SelectedCells(2).Value.ToString ' PN LG
        FormDetachMSL3.TextBox4.Text = Me.DataGridView2.SelectedCells(3).Value.ToString ' Lot ID
        FormDetachMSL3.TextBox5.Text = Me.DataGridView2.SelectedCells(4).Value.ToString ' Qty
        FormDetachMSL3.TextBox6.Text = Me.DataGridView2.SelectedCells(5).Value.ToString ' Incoming Date
        FormDetachMSL3.ComboBox1.Text = Me.DataGridView2.SelectedCells(6).Value ' Line
        If DataGridView2.SelectedCells(7).Value = "Shift 1" Then
            FormDetachMSL3.CheckBox1.Checked = True
        ElseIf DataGridView2.SelectedCells(7).Value = "Shift 2" Then
            FormDetachMSL3.CheckBox2.Checked = True
        End If
        FormDetachMSL3.TextBox9.Text = Me.DataGridView2.SelectedCells(8).Value.ToString ' Supply WO
        FormDetachMSL3.TextBox8.Text = Me.DataGridView2.SelectedCells(9).Value.ToString ' PN
        FormDetachMSL3.TextBox7.Text = Me.DataGridView2.SelectedCells(10).Value.ToString ' Lot QTY
        FormDetachMSL3.TextBox17.Text = Me.DataGridView2.SelectedCells(11).Value.ToString ' Start Time
        FormDetachMSL3.TextBox16.Text = Me.DataGridView2.SelectedCells(12).Value.ToString ' Run Time
        FormDetachMSL3.TextBox15.Text = Me.DataGridView2.SelectedCells(13).Value.ToString ' End Time
        FormDetachMSL3.TextBox14.Text = Me.DataGridView2.SelectedCells(14).Value.ToString ' Employee
        FormDetachMSL3.TextBox13.Text = Me.DataGridView2.SelectedCells(15).Value.ToString ' Remark
        FormDetachMSL3.TextBox12.Text = Me.DataGridView2.SelectedCells(16).Value.ToString ' Is Detach
        FormDetachMSL3.TextBox19.Text = Me.DataGridView2.SelectedCells(17).Value.ToString ' Date Attach
        FormDetachMSL3.TextBox18.Text = Me.DataGridView2.SelectedCells(18).Value.ToString ' Date Detach
        FormDetachMSL3.ShowDialog()
    End Sub
End Class