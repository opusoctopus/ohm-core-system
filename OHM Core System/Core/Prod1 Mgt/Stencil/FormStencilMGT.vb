Imports MySql.Data.MySqlClient
Public Class FormStencilMGT
    Sub onn()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        TextBox2.Focus()
        TextBox1.ReadOnly = True
        Call NomorOtomatis()
    End Sub

    Sub off()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub
    Sub bersih()
        Label9.Text = ""
        Label10.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedItem = Nothing
        ComboBox2.SelectedItem = Nothing
    End Sub

    Sub NomorOtomatis()
        conn.Open()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM prodsys2_master_stencil_tbl WHERE kode_stencil IN (SELECT MAX(kode_stencil) FROM prodsys2_master_stencil_tbl)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = "MM" + System.DateTime.Now.ToString("yyyyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            UrutanKode = "MM" + System.DateTime.Now.ToString("yyyyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
        rd.Close()
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call bersih()
        Call onn()
    End Sub

    Private Sub FormStencilMGT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call off()
        Call customdgv2()
        Call LoadData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call bersih()
        Call off()
    End Sub

    Sub customdgv2()
        With DataGridView1 'Ganti dengan nama datagridview kalian
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.WrapMode = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 35
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

    Sub LoadData()
        Try
            str = "SELECT kode_stencil as KodeStencil, supply_vendor as Vendor, pn_pcb as PartNumber, thickness as Thickness, pabrication_date as MakerDate, version as Version, location as Location, incoming_date as IncomingDate, maker_tension_point_a as MakerPointA, maker_tension_point_b as MakerPointB, maker_tension_point_c MakerPointC, maker_tension_point_d as MakerPointD, maker_tension_point_e as MakerPointE, maker_tension_result as MakerTensionResult, 
int_tension_point_a as OHMPointA, int_tension_point_b as OHMPointB, int_tension_point_c as OHMPointC, int_tension_point_d as OHMPointD, int_tension_point_e as OHMPointE, int_tension_result as OHMTensionResult, pic as PIC, created as Created
FROM prodsys2_master_stencil_tbl"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        rd.Close()
        conn.Close()
        Call BuatKolom()
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 130
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(6).Width = 80
        DataGridView1.Columns(7).Width = 120
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(9).Width = 100
        DataGridView1.Columns(10).Width = 100
        DataGridView1.Columns(11).Width = 100
        DataGridView1.Columns(12).Width = 100
        DataGridView1.Columns(13).Width = 150
        DataGridView1.Columns(14).Width = 100
        DataGridView1.Columns(15).Width = 100
        DataGridView1.Columns(16).Width = 100
        DataGridView1.Columns(17).Width = 100
        DataGridView1.Columns(18).Width = 100
        DataGridView1.Columns(19).Width = 150
        DataGridView1.Columns(20).Width = 100
        DataGridView1.Columns(21).Width = 120
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("NO STENCIL IS SELECTED", vbInformation)
            Call bersih()
        ElseIf ComboBox1.Text = "" Or textbox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("PARAMETER DATA NOT COMPLETE", vbInformation)
        ElseIf Label9.Text = "" Or Label10.Text = "" Then
            MsgBox("TENSION NOT INSPECT", vbInformation)
        Else
            conn.Open()
            str = "SELECT * FROM prodsys2_master_stencil_tbl WHERE kode_stencil='" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    MsgBox("STENCIL CODE IS DUPLICATED", vbInformation)
                Else
                    rd.Close()
                    conn.Close()
                    conn.Open()
                    cmd = New MySql.Data.MySqlClient.MySqlCommand
                    cmd.Connection = conn
                    str = "INSERT INTO `prodsys2_master_stencil_tbl`(`kode_stencil`, `supply_vendor`, `pn_pcb`, `thickness` , 
`pabrication_date`, `version`, `location`, `incoming_date`, `maker_tension_point_a`, `maker_tension_point_b`, `maker_tension_point_c`, `maker_tension_point_d`, `maker_tension_point_e`, `maker_tension_result`,
`int_tension_point_a`, `int_tension_point_b`, `int_tension_point_c`, `int_tension_point_d`, `int_tension_point_e`, `int_tension_result`, `pic`, `created`) 
VALUES (@kode_stencil,@supply_vendor,@pn_pcb,@thickness,@pabrication_date,@version,@location,@incoming_date,@maker_tension_point_a,@maker_tension_point_b,@maker_tension_point_c,@maker_tension_point_d,@maker_tension_point_e,@maker_tension_result,
@int_tension_point_a,@int_tension_point_b,@int_tension_point_c,@int_tension_point_d,@int_tension_point_e,@int_tension_result,@pic,@created)"
                    cmd.Parameters.Add("@kode_stencil", MySqlDbType.VarChar).Value = TextBox1.Text
                    cmd.Parameters.Add("@supply_vendor", MySqlDbType.VarChar).Value = ComboBox1.Text
                    cmd.Parameters.Add("@pn_pcb", MySqlDbType.VarChar).Value = TextBox2.Text
                    cmd.Parameters.Add("@thickness", MySqlDbType.VarChar).Value = TextBox3.Text
                    cmd.Parameters.Add("@pabrication_date", MySqlDbType.VarChar).Value = DateTimePicker1.Text
                    cmd.Parameters.Add("@version", MySqlDbType.VarChar).Value = TextBox4.Text
                    cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = ComboBox2.Text
                    cmd.Parameters.Add("@incoming_date", MySqlDbType.VarChar).Value = DateTimePicker2.Text
                    cmd.Parameters.Add("@maker_tension_point_a", MySqlDbType.VarChar).Value = TextBox5.Text
                    cmd.Parameters.Add("@maker_tension_point_b", MySqlDbType.VarChar).Value = TextBox8.Text
                    cmd.Parameters.Add("@maker_tension_point_c", MySqlDbType.VarChar).Value = TextBox7.Text
                    cmd.Parameters.Add("@maker_tension_point_d", MySqlDbType.VarChar).Value = TextBox6.Text
                    cmd.Parameters.Add("@maker_tension_point_e", MySqlDbType.VarChar).Value = TextBox9.Text
                    cmd.Parameters.Add("@maker_tension_result", MySqlDbType.VarChar).Value = Label9.Text
                    cmd.Parameters.Add("@int_tension_point_a", MySqlDbType.VarChar).Value = TextBox10.Text
                    cmd.Parameters.Add("@int_tension_point_b", MySqlDbType.VarChar).Value = TextBox14.Text
                    cmd.Parameters.Add("@int_tension_point_c", MySqlDbType.VarChar).Value = TextBox13.Text
                    cmd.Parameters.Add("@int_tension_point_d", MySqlDbType.VarChar).Value = TextBox12.Text
                    cmd.Parameters.Add("@int_tension_point_e", MySqlDbType.VarChar).Value = TextBox11.Text
                    cmd.Parameters.Add("@int_tension_result", MySqlDbType.VarChar).Value = Label10.Text
                    cmd.Parameters.Add("@pic", MySqlDbType.VarChar).Value = FormMain.LabelNama.Text
                    cmd.Parameters.Add("@created", MySqlDbType.VarChar).Value = System.DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")
                    cmd.CommandText = str
                    Try
                        cmd.ExecuteNonQuery()
                        Call LoadData()
                    Catch ex As Exception
                        MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        rd.Close()
                        conn.Close()
                        conn.Dispose()
                    End Try
                End If
                Call bersih()
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rd.Close()
                conn.Close()
                conn.Dispose()
            End Try
            rd.Close()
            conn.Close()
            conn.Dispose()
            Call bersih()
            Call off()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not Nothing Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Not Nothing Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox5.Text) < 0.5 Or Val(TextBox5.Text) > 0.8 Then
                TextBox5.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox5.Text) >= 0.5 Or Val(TextBox5.Text) <= 0.8 Then
                TextBox5.ForeColor = Color.Black
            End If
            TextBox8.Focus()
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox8.Text) < 0.5 Or Val(TextBox8.Text) > 0.8 Then
                TextBox8.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox8.Text) >= 0.5 Or Val(TextBox8.Text) <= 0.8 Then
                TextBox8.ForeColor = Color.Black
            End If
            TextBox7.Focus()
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox7.Text) < 0.5 Or Val(TextBox7.Text) > 0.8 Then
                TextBox7.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox7.Text) >= 0.5 Or Val(TextBox7.Text) <= 0.8 Then
                TextBox7.ForeColor = Color.Black
            End If
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox6.Text) < 0.5 Or Val(TextBox6.Text) > 0.8 Then
                TextBox6.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox6.Text) >= 0.5 Or Val(TextBox6.Text) <= 0.8 Then
                TextBox6.ForeColor = Color.Black
            End If
            TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox9.Text) < 0.5 Or Val(TextBox9.Text) > 0.8 Then
                TextBox9.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox9.Text) >= 0.5 Or Val(TextBox9.Text) <= 0.8 Then
                TextBox9.ForeColor = Color.Black
            End If
            Try
                If TextBox5.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox8.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox7.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox6.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox9.ForeColor = Color.FromArgb(200, 5, 83) Then
                    Label9.Text = "NG"
                    Label9.ForeColor = Color.FromArgb(200, 5, 83)
                Else
                    Label9.Text = "OK"
                    Label9.ForeColor = Color.Black
                    TextBox10.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormAttachMetalmask.ShowDialog()
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox11.Text) < 0.5 Or Val(TextBox11.Text) > 0.8 Then
                TextBox11.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox11.Text) >= 0.5 Or Val(TextBox11.Text) <= 0.8 Then
                TextBox11.ForeColor = Color.Black
            End If
            Try
                If TextBox10.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox14.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox13.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox12.ForeColor = Color.FromArgb(200, 5, 83) Or TextBox11.ForeColor = Color.FromArgb(200, 5, 83) Then
                    Label10.Text = "NG"
                    Label10.ForeColor = Color.FromArgb(200, 5, 83)
                Else
                    Label10.Text = "OK"
                    Label10.ForeColor = Color.Black
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox10.Text) < 0.5 Or Val(TextBox10.Text) > 0.8 Then
                TextBox10.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox10.Text) >= 0.5 Or Val(TextBox10.Text) <= 0.8 Then
                TextBox6.ForeColor = Color.Black
            End If
            TextBox14.Focus()
        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox12.Text) < 0.5 Or Val(TextBox12.Text) > 0.8 Then
                TextBox12.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox12.Text) >= 0.5 Or Val(TextBox12.Text) <= 0.8 Then
                TextBox12.ForeColor = Color.Black
            End If
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox13.Text) < 0.5 Or Val(TextBox13.Text) > 0.8 Then
                TextBox13.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox13.Text) >= 0.5 Or Val(TextBox13.Text) <= 0.8 Then
                TextBox13.ForeColor = Color.Black
            End If
            TextBox12.Focus()
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox14.Text) < 0.5 Or Val(TextBox14.Text) > 0.8 Then
                TextBox14.ForeColor = Color.FromArgb(200, 5, 83)
            ElseIf Val(TextBox14.Text) >= 0.5 Or Val(TextBox14.Text) <= 0.8 Then
                TextBox14.ForeColor = Color.Black
            End If
            TextBox13.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FormAttachMetalmask.TextBox1.Text = Me.DataGridView1.SelectedCells(0).Value.ToString ' Kode Stencil
        FormAttachMetalmask.TextBox2.Text = Me.DataGridView1.SelectedCells(3).Value.ToString ' Kode Stencil
        FormAttachMetalmask.TextBox1.ReadOnly = True
        FormAttachMetalmask.TextBox2.ReadOnly = True
        FormAttachMetalmask.ShowDialog()
    End Sub
End Class