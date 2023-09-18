Imports System.Timers
Imports MySql.Data.MySqlClient

Public Class Entity_Requeriment
    Dim NewAccessDB As New Access_DB
    Dim NotifyEvent As String = Nothing
    '░░░░░░░░░░░░░░░░░░░░MOSTRAR LAS UNIDADES DE MEDIDA
    Public Function LoadMedidas() As DataTable
        Dim Consulta As String = "SELECT Nombre, Abreviatura FROM Medidas WHERE Status = @Status;"
        Dim Datos As DataSet = Nothing
        Dim Resultado As DataTable = Nothing
        Dim Parametros As List(Of MySqlParameter) = New List(Of MySqlParameter) From {
            New MySqlParameter("@Status", 1)
        }
        Datos = NewAccessDB.SELECT_DATASET_PARAMS(Consulta, Parametros)
        If Datos IsNot Nothing Then
            Resultado = Datos.Tables(0)
            Return Resultado
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░OBTIENE EL ID DE LA MEDIDA INDICADA
    Public Function GetMedidaID(Medida As String) As Integer
        Dim Consulta As String = "SELECT IDMedida FROM Medidas " &
                                "WHERE Abreviatura = @Abreviatura " &
                                "AND Status = @Status;"
        Dim Datos As DataSet = Nothing
        Dim Resultado As Integer = Nothing
        Dim Parametros As List(Of MySqlParameter) = New List(Of MySqlParameter) From {
            New MySqlParameter("@Abreviatura", Medida),
            New MySqlParameter("@Status", 1)
        }
        Datos = NewAccessDB.SELECT_DATASET_PARAMS(Consulta, Parametros)
        If Datos IsNot Nothing Then
            Resultado = Datos.Tables(0).Rows(0).Item(0)
            Return Resultado
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░OBTIENE EL SIGUIENTE FOLIO A MOSTRAR
    Public Function GetFolio() As Integer
        Dim Consulta As String = "SELECT MAX(Folio)+1 FROM Bitacoras WHERE DATE_FORMAT(FechaRegistro, '%Y') = @YearNow;"
        Dim Datos As DataSet = Nothing
        Dim Resultado As Integer = Nothing
        Dim Parametros As List(Of MySqlParameter) = New List(Of MySqlParameter) From {
            New MySqlParameter("@YearNow", Format(Date.Now, "yyyy"))
        }
        Datos = NewAccessDB.SELECT_DATASET_PARAMS(Consulta, Parametros)
        If Datos IsNot Nothing Then
            If Datos.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
                Resultado = 1
            Else
                Resultado = Datos.Tables(0).Rows(0).Item(0)
            End If
            Return Resultado
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░INSERTAR LOS REQUERIMIENTOS AGREGADOS
    Public Function Save(TableIndex As Integer, Folio As Integer, Producto As String, Cantidad As Integer, Medida As String, Justificacion As String, FechaRequerida As Date, LNotify As Label, PNotify As Panel) As Boolean
        If TableIndex > -1 Then
            Dim Consulta As String = "INSERT INTO Bitacoras(Folio, Producto, Cantidad, Medida_ID, Justificacion, FechaRequerida, FechaRegistro)" &
                                "VALUES (@Folio, @Producto, @Cantidad, @Medida_ID, @Justificacion, @FechaRequerida, @FechaRegistro);"
            Dim Datos As Boolean = Nothing
            Dim Parametros As List(Of MySqlParameter) = New List(Of MySqlParameter) From {
                New MySqlParameter("@Folio", Folio),
                New MySqlParameter("@Producto", Producto),
                New MySqlParameter("@Cantidad", Cantidad),
                New MySqlParameter("@Medida_ID", GetMedidaID(Medida)),
                New MySqlParameter("@Justificacion", Justificacion),
                New MySqlParameter("@FechaRequerida", FechaRequerida),
                New MySqlParameter("@FechaRegistro", DateTime.Now)
            }
            Datos = NewAccessDB.INSERTDB(Consulta, Parametros)
            Return Datos
        Else
            Notify("Information", "➤ | No hay registros en su tabla", LNotify, PNotify)
            NotifyEvent = "Information"
        End If
    End Function













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
                Medida.SelectedIndex = 0
                Justificacion.Text = Nothing
                FechaRequerida.SelectionStart = DateAdd(DateInterval.Day, 15, Now)
                Notify("Success", "✔️ | Producto agregado", LNotify, PNotify)
                NotifyEvent = "Success"
            Else
                Notify("Information", "➤ | Campos por rellenar", LNotify, PNotify)
                NotifyEvent = "Information"
            End If
        Catch ex As Exception
            Notify("Error", "❌ | Verifique su información", LNotify, PNotify)
            NotifyEvent = "Error"
        End Try
    End Function

    Public Function Notify(ByRef Estado As String, ByRef Mensaje As String, LNotify As Label, PNotify As Panel)
        Try
            If Estado = "Success" Then
                LNotify.Text = Mensaje
                LNotify.ForeColor = Color.Black
                PNotify.BackColor = Color.FromArgb(135, 229, 135)

            ElseIf Estado = "Information" Then
                LNotify.Text = Mensaje
                LNotify.ForeColor = Color.Black
                PNotify.BackColor = Color.FromArgb(135, 206, 235, 255)

            ElseIf Estado = "Error" Then
                LNotify.Text = Mensaje
                LNotify.ForeColor = Color.White
                PNotify.BackColor = Color.FromArgb(240, 240, 240, 255)
            End If
            NotifyEvent = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN")
        End Try
    End Function
    Public Function Notify_Restart(PNotify As Panel, LNotify As Label, TimerNotify As Object)
        Try
            Dim A As Integer = Nothing
            Dim R As Integer = Nothing
            Dim G As Integer = Nothing
            Dim B As Integer = Nothing

            If NotifyEvent = "Success" Then
                TimerNotify.Interval = 5000
                PNotify.BackColor = Color.FromArgb(242, 242, 242)
                LNotify.Text = Nothing
            ElseIf NotifyEvent = "Information" Then
                TimerNotify.Interval = 5000
                PNotify.BackColor = Color.FromArgb(242, 242, 242)
                LNotify.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN")
        End Try
    End Function
    Public Function ToolTip(ByRef Mensaje As String, ShowIn As Object, Time As Integer, Icon As ToolTipIcon)
        Dim Tip As New ToolTip
        Tip.IsBalloon = True
        Tip.SetToolTip(ShowIn, Mensaje)
        Tip.AutoPopDelay = Time
        Tip.ToolTipIcon = Icon
    End Function






End Class
