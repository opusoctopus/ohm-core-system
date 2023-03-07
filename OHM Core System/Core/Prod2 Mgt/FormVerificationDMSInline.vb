﻿Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FormVerificationDMSInline
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim arrImage2() As Byte
    Dim arrImage3() As Byte
    'Dim conn As MySqlConnection
    'Dim cmd As MySqlCommand
    'Dim da As MySqlDataAdapter
    Dim sql As String
    Dim result As Integer
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox4.Enabled = True
        Label4.Text = ""
        Label5.Text = ""
        Label9.Text = ""
        Label11.Text = ""
        ComboBox1.SelectedItem = Nothing
        DataGridView1.Rows.Clear()
        DataGridView2.DataSource = Nothing
        DataGridView2.Refresh()
        DataGridView3.DataSource = Nothing
        DataGridView3.Refresh()
        Call off()
    End Sub

    Sub onn()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        TextBox1.Focus()
    End Sub

    Sub off()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Supply WO", "Supply WO")
        DataGridView1.Columns.Add("Lot. QTY", "Lot. QTY")
        DataGridView1.Columns.Add("Partnumber", "Partnumber")
        DataGridView1.Columns.Add("Process", "Process")
        DataGridView1.Columns.Add("Prepare List Material", "Prepare List Material")
        DataGridView1.Columns.Add("Barcode Worksheet", "Barcode Worksheet")
        DataGridView1.Columns.Add("Barcode Label", "Barcode Label")
        DataGridView1.Columns.Add("Result", "Result")
        DataGridView1.Columns.Add("Remark", "Remark")
        DataGridView1.Columns.Add("Created", "Created")
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

        With DataGridView2 'Ganti dengan nama datagridview kalian
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

        With DataGridView3 'Ganti dengan nama datagridview kalian
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
        rd.Close()
        da = New MySqlDataAdapter("SELECT id_bom, child, description, designators, qty FROM prodsys2_master_bom_tbl WHERE id_bom='" & TextBox2.Text & "' AND supply_type = ('Assembly Pull') AND level in (1,2) AND qty > 0 AND description NOT IN ('Label', 'Tape,Double Faced', 'Ribbon', 'Primary Cell Battery,Lithium', 'PCB Assembly,Sub', 'Connector,DSUB', 'Tape,Polyester', 'Screw Assembly', 'Filter,AC Line', 'Screw,Taptite', 'Bag')", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)

        rd.Close()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id_bom, parent_desc, child, designators, qty FROM prodsys2_master_bom_tbl WHERE id_bom='" & TextBox2.Text & "' AND parent_desc = ('Substitutes')", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView3.DataSource = ds.Tables(0)
    End Sub

    Private Sub FormVerificationDMSInline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call off()
        Call customdgv2()
        Call BuatKolom()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call onn()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CheckBox1.Checked = False And CheckBox2.Checked = False Then
                MsgBox("ORG [" & CheckBox1.Text & "] & [" & CheckBox2.Text & "] not checked!", vbCritical)
            ElseIf CheckBox1.Checked = True Then
                conn.Open()
                str = "SELECT org, supply_wo, pn, lot_qty, result FROM prodsys2_preparelist_material_log_tbl WHERE supply_wo='" & TextBox1.Text & "' AND result='OK' AND org='" & CheckBox1.Text & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Try
                    If rd.HasRows Then
                        Label5.Text = ""
                        Label4.Text = rd("result")
                        Label4.ForeColor = Color.Lime
                        Label4.Font = New Font("Arial", 72)
                        TextBox1.Text = rd("supply_wo")
                        TextBox2.Text = rd("pn")
                        TextBox3.Text = rd("lot_qty")

                        Call LoadData()

                        TextBox4.Enabled = False
                        TextBox5.Enabled = False
                        TextBox6.Enabled = False
                    Else
                        Label4.Text = "NG"
                        Label4.Font = New Font("Arial", 72)
                        Label4.ForeColor = Color.Red
                        Label5.Text = "WO SUPPLY [" & TextBox1.Text & "] NOT COMPLETE"
                        Label5.Font = New Font("Arial Narrow", 8)
                        Label5.ForeColor = Color.Crimson
                        TextBox1.Text = ""
                        TextBox1.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                rd.Close()
                conn.Close()
                conn.Dispose()
            ElseIf CheckBox2.Checked = True Then
                conn.Open()
                str = "SELECT org, supply_wo, pn, lot_qty, result FROM prodsys2_preparelist_material_log_tbl WHERE supply_wo='" & TextBox1.Text & "' AND result='OK' AND org='" & CheckBox2.Text & "'"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Try
                    If rd.HasRows Then
                        Label5.Text = ""
                        Label4.Text = rd("result")
                        Label4.ForeColor = Color.Lime
                        Label4.Font = New Font("Arial", 72)
                        TextBox1.Text = rd("supply_wo")
                        TextBox2.Text = rd("pn")
                        TextBox3.Text = rd("lot_qty")

                        Call LoadData()

                        TextBox4.Enabled = False
                        TextBox5.Enabled = False
                        TextBox6.Enabled = False
                    Else
                        Label4.Text = "NG"
                        Label4.Font = New Font("Arial", 72)
                        Label4.ForeColor = Color.Red
                        Label5.Text = "WO SUPPLY [" & TextBox1.Text & "] NOT COMPLETE"
                        Label5.Font = New Font("Arial Narrow", 8)
                        Label5.ForeColor = Color.Crimson
                        TextBox1.Text = ""
                        TextBox1.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                rd.Close()
                conn.Close()
                conn.Dispose()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.Text IsNot Nothing Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            If TextBox5.Text = "" And TextBox6.Text = "" Then
                Label9.Text = "NG"
                Label9.Font = New Font("Arial", 72)
                Label9.ForeColor = Color.Red
                Label11.Text = "NO BARCODE IS SCANNED"
                Label11.Font = New Font("Arial Narrow", 14)
                Label11.ForeColor = Color.Crimson
            ElseIf TextBox5.Text <> TextBox6.Text Then
                Label9.Text = "NG"
                Label9.Font = New Font("Arial", 72)
                Label9.ForeColor = Color.Red
                Label11.Text = "WRONG COMPONENT [" & TextBox5.Text & "] & [" & TextBox6.Text & "]"
                Label11.Font = New Font("Arial Narrow", 12)
                Label11.ForeColor = Color.Crimson
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox5.Focus()
            Else
                Dim IsFound As Boolean = False
                For Each row As DataGridViewRow In DataGridView2.Rows
                    For i As Integer = 0 To DataGridView2.Columns.Count - 1
                        If row.Cells(i).Value.ToString = TextBox6.Text Then
                            IsFound = True
                            row.Cells(i).Style.BackColor = Color.Lime
                            row.Cells(i).Style.ForeColor = Color.Black
                        End If
                    Next
                Next
                For Each row As DataGridViewRow In DataGridView3.Rows
                    For j As Integer = 0 To DataGridView3.Columns.Count - 1
                        If row.Cells(j).Value.ToString = TextBox6.Text Then
                            IsFound = True
                            row.Cells(j).Style.BackColor = Color.Lime
                            row.Cells(j).Style.ForeColor = Color.Black
                        End If
                    Next
                Next

                If (IsFound) Then
                    Label11.Text = ""
                    Label9.Text = "OK"
                    Label9.ForeColor = Color.Lime
                    Label9.Font = New Font("Arial", 72)

                    Dim duplicate As Boolean = False
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        For i As Integer = 0 To DataGridView1.Columns.Count - 1
                            If row.Cells(i).Value.ToString = TextBox6.Text Then
                                duplicate = True
                            End If
                        Next
                    Next

                    If (duplicate) Then
                        Label9.Text = "NG"
                        Label9.Font = New Font("Arial", 72)
                        Label9.ForeColor = Color.Red
                        Label11.Text = "DUPLICATE ENTRY [" & TextBox6.Text & "]"
                        Label11.Font = New Font("Arial Narrow", 12)
                        Label11.ForeColor = Color.Crimson
                    Else
                        DataGridView1.Rows.Add(New String() {TextBox1.Text, TextBox3.Text, TextBox2.Text, ComboBox1.Text, Label4.Text, TextBox5.Text, TextBox6.Text, Label9.Text, "OK DMS", System.DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")})
                    End If

                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox5.Focus()
                    If DataGridView1.RowCount <> DataGridView2.RowCount Then
                        Button3.Enabled = False
                    Else : DataGridView1.RowCount = DataGridView2.RowCount
                        For Baris As Integer = 0 To DataGridView1.Rows.Count - 1
                            rd.Close()
                            Call connection()
                            cmd = New MySql.Data.MySqlClient.MySqlCommand
                            cmd.Connection = conn
                            str = "INSERT INTO `prodsys2_dms_inline_process_verif_log_tbl`(`id_worksheet`, `org`, `supply_wo`, `lot_qty`, `pn`, `process` , `preparelist_material_status`, `barcode_worksheet`, `barcode_label`, `result`, `remark`, `created`) VALUES (@id_worksheet,@org,@supply_wo,@lot_qty,@pn,@process,@preparelist_material_status,@barcode_worksheet,@barcode_label,@result,@remark,@created)"
                            cmd.Parameters.Add("@id_worksheet", MySqlDbType.VarChar).Value = TextBox4.Text
                            If CheckBox1.Checked = True Then
                                cmd.Parameters.Add("@org", MySqlDbType.VarChar).Value = CheckBox1.Text
                            ElseIf CheckBox2.Checked = True Then
                                cmd.Parameters.Add("@org", MySqlDbType.VarChar).Value = CheckBox2.Text
                            End If
                            cmd.Parameters.Add("@supply_wo", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(0).Value.ToString
                            cmd.Parameters.Add("@lot_qty", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(1).Value.ToString
                            cmd.Parameters.Add("@pn", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(2).Value.ToString
                            cmd.Parameters.Add("@process", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(3).Value.ToString
                            cmd.Parameters.Add("@preparelist_material_status", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(4).Value.ToString
                            cmd.Parameters.Add("@barcode_worksheet", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(5).Value.ToString
                            cmd.Parameters.Add("@barcode_label", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(6).Value.ToString
                            cmd.Parameters.Add("@result", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(7).Value.ToString
                            cmd.Parameters.Add("@remark", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(8).Value.ToString
                            cmd.Parameters.Add("@created", MySqlDbType.VarChar).Value = DataGridView1.Rows(Baris).Cells(9).Value.ToString
                            cmd.CommandText = str
                            cmd.ExecuteNonQuery()
                        Next

                        ' SHOW WI MULTI MONITOR                       
                        Try
                            conn = New MySqlConnection
                            conn.ConnectionString = "server=10.217.4.115; user id=ohmuser; password=; database=stockflow_system;"
                            conn.Open()
                            sql = "SELECT pn, wi1 FROM prodsys2_wi_multi_tbl WHERE pn = @pn;"
                            cmd = New MySqlCommand
                            With cmd
                                .Connection = conn
                                .CommandText = sql
                                .Parameters.Clear()
                                .Parameters.AddWithValue("@pn", TextBox2.Text)
                                .ExecuteNonQuery()
                            End With
                            Dim arrImage(), arrImage2(), arrImage3() As Byte
                            Dim dt As New DataTable
                            da = New MySqlDataAdapter
                            da.SelectCommand = cmd
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                arrImage = dt.Rows(0).Item(1)
                                arrImage2 = dt.Rows(0).Item(1)
                                arrImage3 = dt.Rows(0).Item(1)

                                Dim mstream As New MemoryStream(arrImage)
                                Dim mstream2 As New MemoryStream(arrImage2)
                                Dim mstream3 As New MemoryStream(arrImage3)

                                FormWIDMSInlineMNT1.PictureBox1.Image = Image.FromStream(mstream)
                                FormWIDMSInlineMNT2.PictureBox1.Image = Image.FromStream(mstream2)
                                FormWIDMSInlineMNT3.PictureBox1.Image = Image.FromStream(mstream3)

                                FormWIDMSInlineMNT1.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                                FormWIDMSInlineMNT2.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                                FormWIDMSInlineMNT3.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                                Dim screen As Screen
                                screen = Screen.AllScreens(0)
                                FormWIDMSInlineMNT1.StartPosition = FormStartPosition.Manual
                                FormWIDMSInlineMNT1.Location = screen.Bounds.Location + New Point(100, 100)
                                FormWIDMSInlineMNT1.Show()

                                Dim screen2 As Screen
                                screen2 = Screen.AllScreens(1)
                                FormWIDMSInlineMNT2.StartPosition = FormStartPosition.Manual
                                FormWIDMSInlineMNT2.Location = screen2.Bounds.Location + New Point(100, 100)
                                FormWIDMSInlineMNT2.Show()

                                Dim screen3 As Screen
                                screen3 = Screen.AllScreens(2)
                                FormWIDMSInlineMNT3.StartPosition = FormStartPosition.Manual
                                FormWIDMSInlineMNT3.Location = screen3.Bounds.Location + New Point(100, 100)
                                FormWIDMSInlineMNT3.Show()

                            Else
                                MsgBox("WI Belum diupload!", vbExclamation)
                            End If
                        Catch ex As MySqlException
                            MsgBox(ex.Message)
                        End Try
                        rd.Close()
                        conn.Close()
                        conn.Dispose()

                        Call bersih()
                        Exit Sub
                    End If
                Else
                    Label9.Text = "NG"
                    Label9.Font = New Font("Arial", 72)
                    Label9.ForeColor = Color.Red
                    Label11.Text = "MIXING COMPONENT [" & TextBox5.Text & "] & [" & TextBox6.Text & "]"
                    Label11.Font = New Font("Arial Narrow", 12)
                    Label11.ForeColor = Color.Crimson
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox5.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call bersih()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Call connection()
            str = "SELECT * FROM prodsys2_worksheet_tbl WHERE id_worksheet='" & TextBox4.Text & "' AND process='DMS'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Try
                If rd.HasRows Then
                    rd.Close()
                    str = "SELECT * FROM prodsys2_bpr_process_verif_log_tbl WHERE id_worksheet='" & TextBox4.Text & "'"
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    Try
                        If rd.HasRows Then
                            Label9.Text = "NG"
                            Label9.Font = New Font("Arial", 72)
                            Label9.ForeColor = Color.Red
                            Label11.Text = "ID WORKSHEET [" & TextBox4.Text & "] ALREADY SCANNED"
                            Label11.Font = New Font("Arial Narrow", 9)
                            Label11.ForeColor = Color.Crimson
                            TextBox4.Text = ""
                            TextBox4.Focus()
                            rd.Close()
                        Else
                            TextBox5.Enabled = True
                            TextBox6.Enabled = True
                            TextBox4.Enabled = False
                            TextBox5.Focus()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    rd.Close()
                    conn.Close()
                    conn.Dispose()
                Else
                    Label9.Text = "NG"
                    Label9.Font = New Font("Arial", 72)
                    Label9.ForeColor = Color.Red
                    Label11.Text = "ID WORKSHEET [" & TextBox4.Text & "] NO HISTORY PRINTED"
                    Label11.Font = New Font("Arial Narrow", 9)
                    Label11.ForeColor = Color.Crimson
                    TextBox4.Text = ""
                    TextBox4.Focus()
                    rd.Close()
                    conn.Close()
                    conn.Dispose()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        CheckBox2.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        CheckBox1.Checked = False
        TextBox1.Focus()
    End Sub
End Class