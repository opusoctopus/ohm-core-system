Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormNozzleLog

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

    Sub BuatKolom()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 90
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 130
        DataGridView1.Columns(6).Width = 180
        DataGridView1.Columns(7).Width = 130
    End Sub

    Sub LoadData()
        Try
            str = "SELECT id as ID, pic as PIC, line as LINE, machine as MACHINE, tbl as TBL, nozzle_type as NOZZLETYPE, result as RESULT, inspection_date as INSPECTIONDATE FROM prodsys2_nozzle_mgt_log_tbl"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
        conn.Close()
        Call BuatKolom()
    End Sub

    Private Sub FormNozzleLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadData()
        Call customdgv2()
        Call BuatKolom()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        FormDetailLogNozzle.Label4.Text = Me.DataGridView1.SelectedCells(0).Value.ToString ' ID
        FormDetailLogNozzle.TextBox1.Text = Me.DataGridView1.SelectedCells(1).Value.ToString ' PIC
        FormDetailLogNozzle.TextBox3.Text = Me.DataGridView1.SelectedCells(2).Value.ToString ' LINE
        FormDetailLogNozzle.TextBox4.Text = Me.DataGridView1.SelectedCells(3).Value.ToString ' MACHINE
        FormDetailLogNozzle.TextBox5.Text = Me.DataGridView1.SelectedCells(4).Value.ToString ' TBL
        FormDetailLogNozzle.TextBox6.Text = Me.DataGridView1.SelectedCells(5).Value.ToString ' NOZZLE TYPE
        FormDetailLogNozzle.TextBox7.Text = Me.DataGridView1.SelectedCells(6).Value.ToString ' RESULT

        Dim img() As Byte
        Dim Query As String
        conn.Open()
        Query = "SELECT * FROM prodsys2_nozzle_mgt_log_tbl WHERE id = '" & FormDetailLogNozzle.Label4.Text & "' "
        cmd = New MySqlCommand(Query, conn)
        rd = cmd.ExecuteReader
        While rd.Read()
            img = rd.Item("evidence")
            Dim mstream As New MemoryStream(img)
            'FormDetailLogNozzle.PictureBox1.Image = Image.FromStream(mstream)
        End While
        rd.Close()
        conn.Close()

        FormDetailLogNozzle.TextBox2.Text = Me.DataGridView1.SelectedCells(7).Value.ToString ' INSPECTION DATE

        FormDetailLogNozzle.ShowDialog()
    End Sub
End Class