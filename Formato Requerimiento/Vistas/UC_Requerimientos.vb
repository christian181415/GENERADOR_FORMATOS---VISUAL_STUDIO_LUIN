Public Class UC_Requerimientos
    Dim Requeriment As New Entity_Requeriment
    Private Sub UC_Requerimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBoxMedida.DataSource = Requeriment.LoadMedidas()
        CBoxMedida.DisplayMember = "Abreviatura"
        LFolio.Text = Requeriment.GetFolio()

        Requeriment.ToolTip("Clic para añadir un requerimiento a la tabla lateral.", BtnAdd, 5, ToolTipIcon.Info)
        MCFechaRequerida.SelectionStart = DateAdd(DateInterval.Day, 15, Now)
        TimerNotify.Start()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Requeriment.Add(txtProducto, NDCantidad, CBoxMedida, txtJustificacion, MCFechaRequerida, DTGRequerimientos, LContador, LNotify, PNotify)
    End Sub
    Private Sub TimerNotify_Tick(sender As Object, e As EventArgs) Handles TimerNotify.Tick
        Requeriment.Notify_Restart(PNotify, LNotify, TimerNotify)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Limite As Integer = DTGRequerimientos.Rows.Count - 1
        Dim Folio As Integer = Requeriment.GetFolio
        For Fila As Integer = 0 To Limite
            Dim Producto As String = DTGRequerimientos.Rows(Fila).Cells(0).Value
            Dim Cantidad As Integer = DTGRequerimientos.Rows(Fila).Cells(1).Value
            Dim Medida As String = DTGRequerimientos.Rows(Fila).Cells(2).Value
            Dim Justificacion As String = DTGRequerimientos.Rows(Fila).Cells(3).Value
            Dim FechaRequerida As Date = DTGRequerimientos.Rows(Fila).Cells(4).Value
            Requeriment.Save(Limite, Folio, Producto, Cantidad, Medida, Justificacion, FechaRequerida, LNotify, PNotify)
        Next
        DTGRequerimientos.DataSource = Nothing
        DTGRequerimientos.Rows.Clear()
        LFolio.Text = Requeriment.GetFolio
    End Sub
End Class
