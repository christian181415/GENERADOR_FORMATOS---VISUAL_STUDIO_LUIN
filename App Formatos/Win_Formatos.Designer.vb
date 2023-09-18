<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Win_Formatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Win_Formatos))
        Me.PAccesos = New System.Windows.Forms.Panel()
        Me.BtnRequerimientos = New System.Windows.Forms.Button()
        Me.PVentanas = New System.Windows.Forms.Panel()
        Me.TimerAnimations = New System.Windows.Forms.Timer(Me.components)
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAccess = New System.Windows.Forms.Button()
        Me.PAccesos.SuspendLayout()
        Me.PMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PAccesos
        '
        Me.PAccesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PAccesos.Controls.Add(Me.BtnRequerimientos)
        Me.PAccesos.Dock = System.Windows.Forms.DockStyle.Left
        Me.PAccesos.Location = New System.Drawing.Point(0, 43)
        Me.PAccesos.MaximumSize = New System.Drawing.Size(206, 536)
        Me.PAccesos.MinimumSize = New System.Drawing.Size(63, 536)
        Me.PAccesos.Name = "PAccesos"
        Me.PAccesos.Size = New System.Drawing.Size(63, 536)
        Me.PAccesos.TabIndex = 2
        '
        'BtnRequerimientos
        '
        Me.BtnRequerimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRequerimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRequerimientos.FlatAppearance.BorderSize = 0
        Me.BtnRequerimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRequerimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRequerimientos.ForeColor = System.Drawing.Color.White
        Me.BtnRequerimientos.Image = Global.App_Formatos.My.Resources.Resources.requerimiento
        Me.BtnRequerimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRequerimientos.Location = New System.Drawing.Point(0, 0)
        Me.BtnRequerimientos.Name = "BtnRequerimientos"
        Me.BtnRequerimientos.Padding = New System.Windows.Forms.Padding(8, 0, 20, 0)
        Me.BtnRequerimientos.Size = New System.Drawing.Size(63, 42)
        Me.BtnRequerimientos.TabIndex = 1
        Me.BtnRequerimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRequerimientos.UseVisualStyleBackColor = True
        '
        'PVentanas
        '
        Me.PVentanas.BackColor = System.Drawing.Color.White
        Me.PVentanas.BackgroundImage = Global.App_Formatos.My.Resources.Resources.LCorpOpacity
        Me.PVentanas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PVentanas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PVentanas.Location = New System.Drawing.Point(63, 43)
        Me.PVentanas.Name = "PVentanas"
        Me.PVentanas.Size = New System.Drawing.Size(915, 528)
        Me.PVentanas.TabIndex = 3
        '
        'TimerAnimations
        '
        Me.TimerAnimations.Interval = 75
        '
        'PMenu
        '
        Me.PMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PMenu.Controls.Add(Me.Button2)
        Me.PMenu.Controls.Add(Me.Button1)
        Me.PMenu.Controls.Add(Me.BtnClose)
        Me.PMenu.Controls.Add(Me.BtnAccess)
        Me.PMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PMenu.Location = New System.Drawing.Point(0, 0)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(978, 43)
        Me.PMenu.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(789, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "‒"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(852, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "❐"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(915, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(63, 43)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnAccess
        '
        Me.BtnAccess.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAccess.FlatAppearance.BorderSize = 0
        Me.BtnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccess.ForeColor = System.Drawing.Color.White
        Me.BtnAccess.Location = New System.Drawing.Point(0, 0)
        Me.BtnAccess.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAccess.Name = "BtnAccess"
        Me.BtnAccess.Size = New System.Drawing.Size(63, 43)
        Me.BtnAccess.TabIndex = 0
        Me.BtnAccess.Text = "≡"
        Me.BtnAccess.UseVisualStyleBackColor = True
        '
        'Win_Formatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 571)
        Me.Controls.Add(Me.PVentanas)
        Me.Controls.Add(Me.PAccesos)
        Me.Controls.Add(Me.PMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Win_Formatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Win_Formatos"
        Me.PAccesos.ResumeLayout(False)
        Me.PMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PAccesos As Panel
    Friend WithEvents PVentanas As Panel
    Friend WithEvents TimerAnimations As Timer
    Friend WithEvents PMenu As Panel
    Friend WithEvents BtnAccess As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnRequerimientos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
