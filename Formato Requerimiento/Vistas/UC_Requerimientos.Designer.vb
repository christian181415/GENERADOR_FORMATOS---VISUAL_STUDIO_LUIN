<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Requerimientos
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtJustificacion = New System.Windows.Forms.TextBox()
        Me.CBoxMedida = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NDCantidad = New System.Windows.Forms.NumericUpDown()
        Me.MCFechaRequerida = New System.Windows.Forms.MonthCalendar()
        Me.DTGRequerimientos = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Justificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRequerimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGenerarFormato = New System.Windows.Forms.Button()
        Me.PNotify = New System.Windows.Forms.Panel()
        Me.LNotify = New System.Windows.Forms.Label()
        Me.LContador = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBProgreso = New System.Windows.Forms.ProgressBar()
        CType(Me.NDCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNotify.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.SystemColors.Control
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(15, 47)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProducto.Multiline = True
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProducto.Size = New System.Drawing.Size(248, 63)
        Me.txtProducto.TabIndex = 1
        '
        'txtJustificacion
        '
        Me.txtJustificacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtJustificacion.BackColor = System.Drawing.SystemColors.Control
        Me.txtJustificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJustificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJustificacion.Location = New System.Drawing.Point(15, 199)
        Me.txtJustificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.Size = New System.Drawing.Size(248, 15)
        Me.txtJustificacion.TabIndex = 2
        '
        'CBoxMedida
        '
        Me.CBoxMedida.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CBoxMedida.BackColor = System.Drawing.SystemColors.Control
        Me.CBoxMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBoxMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxMedida.FormattingEnabled = True
        Me.CBoxMedida.Items.AddRange(New Object() {"PZA."})
        Me.CBoxMedida.Location = New System.Drawing.Point(131, 144)
        Me.CBoxMedida.Margin = New System.Windows.Forms.Padding(4)
        Me.CBoxMedida.Name = "CBoxMedida"
        Me.CBoxMedida.Size = New System.Drawing.Size(132, 24)
        Me.CBoxMedida.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Unidad de medida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Producto"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha que lo requiere"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 179)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Justificación / Area de aplicación"
        '
        'NDCantidad
        '
        Me.NDCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NDCantidad.BackColor = System.Drawing.SystemColors.Control
        Me.NDCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NDCantidad.Location = New System.Drawing.Point(15, 146)
        Me.NDCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NDCantidad.Name = "NDCantidad"
        Me.NDCantidad.Size = New System.Drawing.Size(69, 18)
        Me.NDCantidad.TabIndex = 10
        Me.NDCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NDCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MCFechaRequerida
        '
        Me.MCFechaRequerida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MCFechaRequerida.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MCFechaRequerida.Location = New System.Drawing.Point(15, 235)
        Me.MCFechaRequerida.MaxSelectionCount = 1
        Me.MCFechaRequerida.Name = "MCFechaRequerida"
        Me.MCFechaRequerida.ShowToday = False
        Me.MCFechaRequerida.ShowTodayCircle = False
        Me.MCFechaRequerida.TabIndex = 11
        '
        'DTGRequerimientos
        '
        Me.DTGRequerimientos.AllowUserToAddRows = False
        Me.DTGRequerimientos.AllowUserToDeleteRows = False
        Me.DTGRequerimientos.AllowUserToResizeColumns = False
        Me.DTGRequerimientos.AllowUserToResizeRows = False
        Me.DTGRequerimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGRequerimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTGRequerimientos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DTGRequerimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGRequerimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DTGRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGRequerimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Unidad, Me.Justificacion, Me.FechaRequerimiento})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGRequerimientos.DefaultCellStyle = DataGridViewCellStyle5
        Me.DTGRequerimientos.Location = New System.Drawing.Point(275, 27)
        Me.DTGRequerimientos.Name = "DTGRequerimientos"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGRequerimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DTGRequerimientos.RowHeadersVisible = False
        Me.DTGRequerimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DTGRequerimientos.Size = New System.Drawing.Size(625, 446)
        Me.DTGRequerimientos.TabIndex = 12
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Medida"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'Justificacion
        '
        Me.Justificacion.HeaderText = "Justificacion"
        Me.Justificacion.Name = "Justificacion"
        Me.Justificacion.ReadOnly = True
        '
        'FechaRequerimiento
        '
        Me.FechaRequerimiento.HeaderText = "Fecha"
        Me.FechaRequerimiento.Name = "FechaRequerimiento"
        Me.FechaRequerimiento.ReadOnly = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Location = New System.Drawing.Point(15, 409)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(248, 29)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "AGREGAR PRODUCTO"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnGenerarFormato
        '
        Me.BtnGenerarFormato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGenerarFormato.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerarFormato.FlatAppearance.BorderSize = 0
        Me.BtnGenerarFormato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.BtnGenerarFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerarFormato.Location = New System.Drawing.Point(15, 444)
        Me.BtnGenerarFormato.Name = "BtnGenerarFormato"
        Me.BtnGenerarFormato.Size = New System.Drawing.Size(248, 29)
        Me.BtnGenerarFormato.TabIndex = 14
        Me.BtnGenerarFormato.Text = "GENERAR REQUERIMIENTO"
        Me.BtnGenerarFormato.UseVisualStyleBackColor = False
        '
        'PNotify
        '
        Me.PNotify.BackColor = System.Drawing.SystemColors.Control
        Me.PNotify.Controls.Add(Me.PBProgreso)
        Me.PNotify.Controls.Add(Me.LNotify)
        Me.PNotify.Controls.Add(Me.LContador)
        Me.PNotify.Controls.Add(Me.Label6)
        Me.PNotify.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNotify.Location = New System.Drawing.Point(0, 496)
        Me.PNotify.Name = "PNotify"
        Me.PNotify.Size = New System.Drawing.Size(915, 32)
        Me.PNotify.TabIndex = 15
        '
        'LNotify
        '
        Me.LNotify.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LNotify.ForeColor = System.Drawing.Color.Black
        Me.LNotify.Location = New System.Drawing.Point(12, 8)
        Me.LNotify.Name = "LNotify"
        Me.LNotify.Size = New System.Drawing.Size(506, 16)
        Me.LNotify.TabIndex = 10
        '
        'LContador
        '
        Me.LContador.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LContador.AutoSize = True
        Me.LContador.Location = New System.Drawing.Point(889, 8)
        Me.LContador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContador.Name = "LContador"
        Me.LContador.Size = New System.Drawing.Size(15, 16)
        Me.LContador.TabIndex = 9
        Me.LContador.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(809, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Productos:"
        '
        'PBProgreso
        '
        Me.PBProgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PBProgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PBProgreso.Location = New System.Drawing.Point(524, 11)
        Me.PBProgreso.Name = "PBProgreso"
        Me.PBProgreso.Size = New System.Drawing.Size(278, 10)
        Me.PBProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PBProgreso.TabIndex = 11
        Me.PBProgreso.Value = 100
        '
        'UC_Requerimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PNotify)
        Me.Controls.Add(Me.BtnGenerarFormato)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DTGRequerimientos)
        Me.Controls.Add(Me.MCFechaRequerida)
        Me.Controls.Add(Me.NDCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBoxMedida)
        Me.Controls.Add(Me.txtJustificacion)
        Me.Controls.Add(Me.txtProducto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(772, 528)
        Me.Name = "UC_Requerimientos"
        Me.Size = New System.Drawing.Size(915, 528)
        CType(Me.NDCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNotify.ResumeLayout(False)
        Me.PNotify.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtJustificacion As TextBox
    Friend WithEvents CBoxMedida As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NDCantidad As NumericUpDown
    Friend WithEvents MCFechaRequerida As MonthCalendar
    Friend WithEvents DTGRequerimientos As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnGenerarFormato As Button
    Friend WithEvents PNotify As Panel
    Friend WithEvents LContador As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Justificacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaRequerimiento As DataGridViewTextBoxColumn
    Friend WithEvents LNotify As Label
    Friend WithEvents PBProgreso As ProgressBar
End Class
