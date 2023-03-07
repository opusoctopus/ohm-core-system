﻿Imports System.Security.Cryptography
Public Class FormProdPlan2
    Private tripleDes As New TripleDESCryptoServiceProvider
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
            .ColumnHeadersHeight = 35
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 122, 131)
            With .ColumnHeadersDefaultCellStyle
                .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .BackColor = Color.FromArgb(112, 122, 131)
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
            .ColumnHeadersHeight = 35
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 122, 131)
            With .ColumnHeadersDefaultCellStyle
                .Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .BackColor = Color.FromArgb(112, 122, 131)
                .ForeColor = Color.White
            End With
            With .RowTemplate
                .Height = 22
            End With
        End With
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FormBOMKit.TextBox2.Text = Me.DataGridView1.SelectedCells(2).Value.ToString ' wo supply
        FormBOMKit.TextBox1.Text = Me.DataGridView1.SelectedCells(4).Value.ToString ' pn
        FormBOMKit.TextBox4.Text = Me.DataGridView1.SelectedCells(7).Value.ToString ' qty
        Me.Close()
        FormBOMKit.DataGridView1.DataSource = Nothing
        FormBOMKit.DataGridView1.Rows.Clear()
        FormBOMKit.DataGridView2.DataSource = Nothing
        FormBOMKit.DataGridView2.Rows.Clear()
        FormBOMKit.GroupBox1.Enabled = True

        FormBOMKit.RadioButton2.Checked = False
        FormBOMKit.RadioButton1.Checked = True
        FormBOMKit.TextBox3.Text = ""
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        FormBOMKit.TextBox1.Text = Me.DataGridView2.SelectedCells(0).Value.ToString ' pn
        FormBOMKit.TextBox3.Text = Me.DataGridView2.SelectedCells(3).Value.ToString ' wo demand
        FormBOMKit.TextBox4.Text = Me.DataGridView2.SelectedCells(6).Value.ToString ' qty
        Me.Close()
        FormBOMKit.DataGridView1.DataSource = Nothing
        FormBOMKit.DataGridView1.Rows.Clear()
        FormBOMKit.DataGridView2.DataSource = Nothing
        FormBOMKit.DataGridView2.Rows.Clear()
        FormBOMKit.GroupBox1.Enabled = True

        FormBOMKit.RadioButton1.Checked = False
        FormBOMKit.RadioButton2.Checked = True
        FormBOMKit.TextBox2.Text = ""
    End Sub

    Private Sub FormProdPlan2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call customdgv2()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("select line, org, supply_wo, model, pn, demand_wo, pcb, lot_qty, pst, remark, created from prodsys2_prod_plan_tbl", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("select ebt, supply_wo, supply_qty, wo, assembly_partno, demand_line, wo_qty, created from prodsys_prod_plan_tbl", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.Text IsNot Nothing Then
            TextBox1.Focus()
        End If
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.TabControl1.SelectedIndex = 0 Then ' SMT PLAN
                If ComboBox1.Text = "Supply WO" Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.Refresh()
                    da = New MySql.Data.MySqlClient.MySqlDataAdapter("select line, org, supply_wo, model, pn, demand_wo, pcb, lot_qty, pst, remark, created from prodsys2_prod_plan_tbl where supply_wo like '" & TextBox1.Text & "' ", conn)
                    ds = New DataSet
                    da.Fill(ds)
                    DataGridView1.DataSource = ds.Tables(0)
                ElseIf ComboBox1.Text = "Partnumber" Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.Refresh()
                    da = New MySql.Data.MySqlClient.MySqlDataAdapter("select line, org, supply_wo, model, pn, demand_wo, pcb, lot_qty, pst, remark, created from prodsys2_prod_plan_tbl where pn like '" & TextBox1.Text & "' ", conn)
                    ds = New DataSet
                    da.Fill(ds)
                    DataGridView1.DataSource = ds.Tables(0)
                End If
            ElseIf Me.TabControl1.SelectedIndex = 1 Then ' ASP
                If ComboBox1.Text = "Demand WO" Then
                    DataGridView2.DataSource = Nothing
                    DataGridView2.Refresh()
                    da = New MySql.Data.MySqlClient.MySqlDataAdapter("select ebt, supply_wo, supply_qty, wo, assembly_partno, demand_line, wo_qty, created from prodsys_prod_plan_tbl where wo like '" & TextBox1.Text & "' ", conn)
                    ds = New DataSet
                    da.Fill(ds)
                    DataGridView2.DataSource = ds.Tables(0)
                ElseIf ComboBox1.Text = "Partnumber" Then
                    DataGridView2.DataSource = Nothing
                    DataGridView2.Refresh()
                    da = New MySql.Data.MySqlClient.MySqlDataAdapter("select ebt, supply_wo, supply_qty, wo, assembly_partno, demand_line, wo_qty, created from prodsys_prod_plan_tbl where ebt like '" & TextBox1.Text & "' ", conn)
                    ds = New DataSet
                    da.Fill(ds)
                    DataGridView2.DataSource = ds.Tables(0)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class