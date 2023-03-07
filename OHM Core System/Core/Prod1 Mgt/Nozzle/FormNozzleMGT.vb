Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormNozzleMGT
    Private WithEvents cam As New DSCamCapture
    Dim MyPicturesFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
    Dim Myconnection As String = "server=10.217.4.115;user id=ohmuser;password=;database=stockflow_system" 'con2
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Sub bersih()
        ComboBox1.SelectedItem = Nothing
        ComboBox2.SelectedItem = Nothing
        ComboBox3.SelectedItem = Nothing
        TextBox2.Text = ""
    End Sub

    Private Sub ComboBox_Devices_DropDown(sender As Object, e As EventArgs) Handles ComboBox_Devices.DropDown
        ComboBox_Devices.Items.Clear()
        ComboBox_Devices.Items.AddRange(cam.GetCaptureDevices)
        Button_Connect.Enabled = (ComboBox_Devices.Items.Count > 0)
        If ComboBox_Devices.SelectedIndex = -1 And ComboBox_Devices.Items.Count > 0 Then ComboBox_Devices.SelectedIndex = 0
    End Sub

    Private Sub FormNozzleMGT_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cam.Dispose()
    End Sub

    Private Sub FormNozzleMGT_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox_Devices.Items.AddRange(cam.GetCaptureDevices)
        If ComboBox_Devices.Items.Count > 0 Then ComboBox_Devices.SelectedIndex = 0

        For Each sz As String In [Enum].GetNames(GetType(DSCamCapture.FrameSizes))
            ComboBox_FrameSize.Items.Add(sz.Replace("s", ""))
        Next
        If ComboBox_FrameSize.Items.Count > 2 Then ComboBox_FrameSize.SelectedIndex = 2

        Button_Connect.Enabled = (ComboBox_Devices.Items.Count > 0)
        Button_Save.Enabled = False
        PictureBox2.Hide()
        ComboBox_FrameSize.Text = "640x480"
        Button_Save.Enabled = False
    End Sub

    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        If Not cam.IsConnected Then
            Dim si As Integer = ComboBox_FrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(ComboBox_Devices.SelectedIndex, 15, PictureBox1.ClientSize, SelectedSize, PictureBox1.Handle) Then
                cam.Start()
                Button_Connect.Text = "Disconnect"
            End If
        Else
            cam.Dispose()
            Button_Connect.Text = "Connect"
        End If
        Button_Save.Enabled = cam.IsConnected
        ComboBox_Devices.Enabled = Not cam.IsConnected
        ComboBox_FrameSize.Enabled = Not cam.IsConnected
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If Not IO.Directory.Exists(MyPicturesFolder) Then IO.Directory.CreateDirectory(MyPicturesFolder)
        Dim fName As String = Now.ToString.Replace("/", "-").Replace(":", "-").Replace(" ", "_") & ".jpg"
        Dim SaveAs As String = IO.Path.Combine(MyPicturesFolder, fName)
        cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)
        PictureBox1.Hide()
        PictureBox2.Show()
    End Sub

    Private Sub PictureBox1_SizeChanged(sender As Object, e As EventArgs) Handles PictureBox1.SizeChanged
        cam.ResizeWindow(0, 0, PictureBox1.ClientSize.Width, PictureBox1.ClientSize.Height)
    End Sub

    Dim appPath As String = My.Application.Info.DirectoryPath

    Private Sub cam_FrameSaved(capImage As Bitmap, imgPath As String) Handles cam.FrameSaved
        PictureBox2.Image = New Bitmap(capImage)
        FormEvidenceNozzle.PictureBox1.Image = New Bitmap(capImage)
        Label2.Text = "Saved As - " & IO.Path.GetFileName(imgPath)
        Label3.Text = "Image Size - " & PictureBox2.Image.Size.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Show()
        PictureBox2.Image = Nothing
        PictureBox2.Hide()
        Label2.Text = ""
        Label3.Text = ""
        Call bersih()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        rd.Close()
        conn.Close()
        conn.Dispose()

        PictureBox2.Image = Nothing
        Label7.Text = Button_OK.Text
        If Not IO.Directory.Exists(MyPicturesFolder) Then IO.Directory.CreateDirectory(MyPicturesFolder)
        Dim fName As String = Now.ToString.Replace("/", "-").Replace(":", "-").Replace(" ", "_") & ".jpg"
        Dim SaveAs As String = IO.Path.Combine(MyPicturesFolder, fName)
        cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)
        PictureBox1.Hide()
        PictureBox2.Show()

        If Not PictureBox2.Image Is Nothing Then
            MsgBox("No Image Captured", vbInformation)
            PictureBox1.Show()
            PictureBox2.Image = Nothing
            PictureBox2.Hide()
            Label2.Text = ""
            Label3.Text = ""
            Call bersih()
        ElseIf ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please complete data", vbInformation)
            PictureBox1.Show()
            PictureBox2.Image = Nothing
            PictureBox2.Hide()
            Label2.Text = ""
            Label3.Text = ""
            Call bersih()
        Else
            conn.ConnectionString = Myconnection
            conn.Open()

            sql = "INSERT INTO `prodsys2_nozzle_mgt_log_tbl`(`pic`, `line`, `machine`, `tbl`, `nozzle_type`, `result`, `evidence`, `inspection_date`) 
VALUES (@pic, @line, @machine, @tbl, @nozzle_type, @result, @evidence, @inspection_date)"
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@pic", FormMain.LabelNama.Text)
            cmd.Parameters.AddWithValue("@line", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@machine", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@tbl", TextBox2.Text)
            cmd.Parameters.AddWithValue("@nozzle_type", ComboBox3.Text)
            cmd.Parameters.AddWithValue("@result", Button_OK.Text)
            cmd.Parameters.AddWithValue("@evidence", SaveAs)
            cmd.Parameters.AddWithValue("@inspection_date", System.DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"))
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            conn.Close()
            conn.Dispose()
            PictureBox1.Show()
            PictureBox2.Hide()
            Label2.Text = ""
            Label3.Text = ""
            FormEvidenceNozzle.Label1.Parent = FormEvidenceNozzle.PictureBox1
            FormEvidenceNozzle.Label1.BringToFront()
            FormEvidenceNozzle.Label1.BackColor = System.Drawing.Color.Transparent
            FormEvidenceNozzle.Label2.Text = "OK"
            FormEvidenceNozzle.Label2.ForeColor = Color.White
            FormEvidenceNozzle.Label2.BackColor = Color.LimeGreen
            FormEvidenceNozzle.ShowDialog()
        End If
    End Sub

    Private Sub Button_NG_Click(sender As Object, e As EventArgs) Handles Button_NG.Click
        rd.Close()
        conn.Close()
        conn.Dispose()

        PictureBox2.Image = Nothing
        Label7.Text = Button_NG.Text
        If Not IO.Directory.Exists(MyPicturesFolder) Then IO.Directory.CreateDirectory(MyPicturesFolder)
        Dim fName As String = Now.ToString.Replace("/", "-").Replace(":", "-").Replace(" ", "_") & ".jpg"
        Dim SaveAs As String = IO.Path.Combine(MyPicturesFolder, fName)
        cam.SaveCurrentFrame(SaveAs, Imaging.ImageFormat.Jpeg)
        PictureBox1.Hide()
        PictureBox2.Show()

        If Not PictureBox2.Image Is Nothing Then
            MsgBox("No Image Captured", vbInformation)
            PictureBox1.Show()
            PictureBox2.Image = Nothing
            PictureBox2.Hide()
            Label2.Text = ""
            Label3.Text = ""
            Call bersih()
        ElseIf ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please complete data", vbInformation)
            PictureBox1.Show()
            PictureBox2.Image = Nothing
            PictureBox2.Hide()
            Label2.Text = ""
            Label3.Text = ""
            Call bersih()
        Else
            conn.ConnectionString = Myconnection
            conn.Open()

            sql = "INSERT INTO `prodsys2_nozzle_mgt_log_tbl`(`pic`, `line`, `machine`, `tbl`, `nozzle_type`, `result`, `evidence`, `inspection_date`) 
VALUES (@pic, @line, @machine, @tbl, @nozzle_type, @result, @evidence, @inspection_date)"
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@pic", FormMain.LabelNama.Text)
            cmd.Parameters.AddWithValue("@line", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@machine", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@tbl", TextBox2.Text)
            cmd.Parameters.AddWithValue("@nozzle_type", ComboBox3.Text)
            cmd.Parameters.AddWithValue("@result", Button_NG.Text)
            cmd.Parameters.AddWithValue("@evidence", SaveAs)
            cmd.Parameters.AddWithValue("@inspection_date", System.DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"))
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            conn.Close()
            conn.Dispose()
            PictureBox1.Show()
            PictureBox2.Hide()
            Label2.Text = ""
            Label3.Text = ""
            FormEvidenceNozzle.Label1.Parent = FormEvidenceNozzle.PictureBox1
            FormEvidenceNozzle.Label1.BringToFront()
            FormEvidenceNozzle.Label1.BackColor = System.Drawing.Color.Transparent
            FormEvidenceNozzle.Label2.Text = "NG"
            FormEvidenceNozzle.Label2.ForeColor = Color.White
            FormEvidenceNozzle.Label2.BackColor = Color.Red
            FormEvidenceNozzle.ShowDialog()
        End If
    End Sub
End Class