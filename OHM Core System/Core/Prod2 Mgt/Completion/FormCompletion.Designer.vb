﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompletion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompletion))
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label26
        '
        Me.Label26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(532, 6)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(381, 51)
        Me.Label26.TabIndex = 147
        Me.Label26.Text = "Label Completion"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.Size = New System.Drawing.Size(924, 578)
        Me.DataGridView1.TabIndex = 128
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.Image = Global.OHM_Core_System.My.Resources.Resources.icons8_unavailable_24
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(405, 13)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 38)
        Me.Button8.TabIndex = 145
        Me.Button8.Text = "Cancel"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(844, 11)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "Label25"
        Me.Label25.Visible = False
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(110, 73)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(72, 21)
        Me.cmbBaud.TabIndex = 107
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbPort)
        Me.GroupBox2.Controls.Add(Me.cmbBaud)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Location = New System.Drawing.Point(598, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 138)
        Me.GroupBox2.TabIndex = 146
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Com Serial Port"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Baud Rate:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Com Port:"
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(110, 46)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(72, 21)
        Me.cmbPort.TabIndex = 106
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Image = Global.OHM_Core_System.My.Resources.Resources.connect
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(197, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 26)
        Me.Button6.TabIndex = 103
        Me.Button6.Text = "Connect"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Image = Global.OHM_Core_System.My.Resources.Resources.connect
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(197, 71)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 25)
        Me.Button7.TabIndex = 109
        Me.Button7.Text = "Disconnect"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(843, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "label_berat_pcb"
        Me.Label20.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(843, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 142
        Me.Label19.Text = "label_berat_box"
        Me.Label19.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(167, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 132)
        Me.Label14.TabIndex = 138
        Me.Label14.Text = "/"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Arial", 56.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(212, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(727, 132)
        Me.Label13.TabIndex = 137
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Arial", 56.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(15, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(201, 132)
        Me.Label11.TabIndex = 136
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialPort1
        '
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(908, 947)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "0000"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(838, 947)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Showing data:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 725)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(924, 23)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "History Print Label Box"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(15, 748)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.Size = New System.Drawing.Size(924, 196)
        Me.DataGridView2.TabIndex = 132
        Me.DataGridView2.Visible = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(85, 948)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 13)
        Me.Label22.TabIndex = 130
        Me.Label22.Text = "0000"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 947)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 13)
        Me.Label23.TabIndex = 129
        Me.Label23.Text = "Showing data:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(489, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 38)
        Me.Button5.TabIndex = 127
        Me.Button5.Text = "Excel"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(319, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "PCBA ID"
        Me.Label16.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Shift 1", "Shift 2"})
        Me.ComboBox2.Location = New System.Drawing.Point(398, 51)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Location = New System.Drawing.Point(398, 78)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(155, 20)
        Me.TextBox4.TabIndex = 18
        Me.TextBox4.Visible = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(15, 343)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(924, 23)
        Me.Label21.TabIndex = 131
        Me.Label21.Text = "Scanned Barcode"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 138)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Input Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(319, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Line"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DMS Offline", "DMS Inline 1", "DMS Inline 2", "DMS Inline 3", "DMS Inline 4", "DMS Inline 5", "DMS Inline 6"})
        Me.ComboBox1.Location = New System.Drawing.Point(398, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Shift"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Txn ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Part Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Work Order"
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(105, 73)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(155, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(105, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(105, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Image = Global.OHM_Core_System.My.Resources.Resources.refresh1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(287, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 38)
        Me.Button4.TabIndex = 126
        Me.Button4.Text = "Change Model"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(119, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 38)
        Me.Button2.TabIndex = 124
        Me.Button2.Text = "Add"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(203, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 38)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "Print"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.OHM_Core_System.My.Resources.Resources.master
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(14, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 38)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Prod. Plan"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormCompletion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(952, 964)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCompletion"
        Me.Text = "Completion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label26 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents cmbBaud As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbPort As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
