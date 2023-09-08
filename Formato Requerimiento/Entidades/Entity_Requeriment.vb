Public Class Entity_Requeriment
    Public Function Show(Window As UserControl, ByRef AddPanel As Panel)
        Window.Location = New Point(0, 0)
        AddPanel.Controls.Add(Window)
        Window.Dock = DockStyle.Fill
    End Function

    Public Function Add(ByRef Producto As TextBox, ByRef Cantidad As NumericUpDown, ByRef Medida As ComboBox, ByRef Justificacion As TextBox, ByRef FechaRequerida As MonthCalendar, ByRef Tabla As DataGridView, ByRef LContador As Label, LNotify As Label, PNotify As Panel)
        Try
            If Producto.Text <> Nothing And Cantidad.Value <> Nothing And Medida.Text <> Nothing And Justificacion.Text <> Nothing Then
                Tabla.Rows.Add(New Object() {Producto.Text, Cantidad.Value, Medida.Text, Justificacion.Text, FechaRequerida.SelectionStart})
                LContador.Text = Tabla.Rows.Count
                Producto.Text = Nothing
                Cantidad.Value = 1
                Medida.SelectedIndex = -1
                Justificacion.Text = Nothing
                FechaRequerida.SelectionStart = DateAdd(DateInterval.Day, 15, Now)
                Notify("Success", "✔️ | Producto agregado", LNotify, PNotify)
            Else
                Notify("Information", "ⓘ | Campos por rellenar", LNotify, PNotify)
            End If
        Catch ex As Exception
            Notify("Error", "❌ | Verifique su información", LNotify, PNotify)
        End Try
    End Function

    Public Function Notify(Estado As String, ByRef Mensaje As String, LNotify As Label, PNotify As Panel)
        Try
            Dim ColorP As Color = Nothing
            If Estado = "Success" Then
                LNotify.Text = Mensaje
                LNotify.ForeColor = Color.Black
                PNotify.BackColor = Color.LightGreen

            ElseIf Estado = "Information" Then
                LNotify.Text = Mensaje
                LNotify.ForeColor = Color.Black
                PNotify.BackColor = Color.SkyBlue

            ElseIf Estado = "Error" Then
                LNotify.Text = Mensaje
                LNotify.ForeColor = Color.White
                PNotify.BackColor = Color.FromArgb(250, 114, 104)
            End If
        Catch ex As Exception

        End Try
    End Function
End Class
