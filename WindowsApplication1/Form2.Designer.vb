<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSelectQuery = New System.Windows.Forms.Button()
        Me.btnBuiltQuery = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.cboField = New System.Windows.Forms.ComboBox()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnFilms = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(615, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(875, 495)
        Me.DataGridView1.TabIndex = 0
        '
        'btnSelectQuery
        '
        Me.btnSelectQuery.BackgroundImage = CType(resources.GetObject("btnSelectQuery.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectQuery.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSelectQuery.ForeColor = System.Drawing.Color.White
        Me.btnSelectQuery.Location = New System.Drawing.Point(387, 12)
        Me.btnSelectQuery.Name = "btnSelectQuery"
        Me.btnSelectQuery.Size = New System.Drawing.Size(122, 59)
        Me.btnSelectQuery.TabIndex = 1
        Me.btnSelectQuery.Text = "Select All Query"
        Me.btnSelectQuery.UseVisualStyleBackColor = True
        '
        'btnBuiltQuery
        '
        Me.btnBuiltQuery.BackgroundImage = CType(resources.GetObject("btnBuiltQuery.BackgroundImage"), System.Drawing.Image)
        Me.btnBuiltQuery.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnBuiltQuery.ForeColor = System.Drawing.Color.White
        Me.btnBuiltQuery.Location = New System.Drawing.Point(36, 52)
        Me.btnBuiltQuery.Name = "btnBuiltQuery"
        Me.btnBuiltQuery.Size = New System.Drawing.Size(119, 51)
        Me.btnBuiltQuery.TabIndex = 2
        Me.btnBuiltQuery.Text = "Build Query"
        Me.btnBuiltQuery.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.BackgroundImage = CType(resources.GetObject("btnRun.BackgroundImage"), System.Drawing.Image)
        Me.btnRun.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnRun.ForeColor = System.Drawing.Color.White
        Me.btnRun.Location = New System.Drawing.Point(201, 321)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(176, 45)
        Me.btnRun.TabIndex = 3
        Me.btnRun.Text = "Run Custom Query"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtValue.Location = New System.Drawing.Point(270, 135)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(227, 29)
        Me.txtValue.TabIndex = 4
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(201, 372)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(408, 28)
        Me.txtSQL.TabIndex = 5
        '
        'cboField
        '
        Me.cboField.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cboField.FormattingEnabled = True
        Me.cboField.Location = New System.Drawing.Point(33, 134)
        Me.cboField.Name = "cboField"
        Me.cboField.Size = New System.Drawing.Size(147, 30)
        Me.cboField.TabIndex = 6
        '
        'cboOperator
        '
        Me.cboOperator.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Location = New System.Drawing.Point(195, 134)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(59, 30)
        Me.cboOperator.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1327, 519)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'btnFilms
        '
        Me.btnFilms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFilms.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnFilms.ForeColor = System.Drawing.Color.Black
        Me.btnFilms.Image = CType(resources.GetObject("btnFilms.Image"), System.Drawing.Image)
        Me.btnFilms.Location = New System.Drawing.Point(33, 503)
        Me.btnFilms.Name = "btnFilms"
        Me.btnFilms.Size = New System.Drawing.Size(155, 85)
        Me.btnFilms.TabIndex = 41
        Me.btnFilms.Text = "Films Screen"
        Me.btnFilms.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Font = New System.Drawing.Font("Perpetua", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(1171, 519)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(95, 93)
        Me.btnHelp.TabIndex = 44
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1151, 605)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 29)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "Go to Help Screen."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Font = New System.Drawing.Font("Perpetua", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(245, 415)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 29)
        Me.TextBox2.TabIndex = 46
        Me.TextBox2.Text = "Build your onw Query into the textbox above"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1502, 646)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnFilms)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cboOperator)
        Me.Controls.Add(Me.cboField)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnBuiltQuery)
        Me.Controls.Add(Me.btnSelectQuery)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Queries Screen"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelectQuery As System.Windows.Forms.Button
    Friend WithEvents btnBuiltQuery As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents cboField As System.Windows.Forms.ComboBox
    Friend WithEvents cboOperator As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btnFilms As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
