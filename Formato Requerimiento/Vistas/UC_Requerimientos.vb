Public Class UC_Requerimientos
    Dim Requeriment As New Entity_Requeriment
    Private Sub UC_Requerimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MCFechaRequerida.SelectionStart = DateAdd(DateInterval.Day, 15, Now)
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Requeriment.Add(txtProducto, NDCantidad, CBoxMedida, txtJustificacion, MCFechaRequerida, DTGRequerimientos, LContador, LNotify, PNotify)
    End Sub
End Class
