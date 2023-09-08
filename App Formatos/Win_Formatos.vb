Imports Formato_Requerimiento
Public Class Win_Formatos
    Dim Requeriment As New Entity_Requeriment
    Dim UC_Requeriment As New UC_Requerimientos

#Region "CONFIGURACIONES PARA ANIMACIONES"
    Dim Animation As Boolean = False
    Dim Accesos As Integer = Nothing
    Private Sub Win_Formatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Accesos = PAccesos.Size.Width
        TimerAnimations.Start()
    End Sub
    Private Sub TimerAnimations_Tick(sender As Object, e As EventArgs) Handles TimerAnimations.Tick
        If Animation = True Then
            If PAccesos.Size.Width < 206 Then
                PVentanas.Visible = False
                BtnRequerimientos.Visible = False
                For Abrir As Integer = 63 To 206
                    PAccesos.Size = New Size(Abrir, 536)
                Next
                PVentanas.Visible = True
                PVentanas.Refresh()
                BtnRequerimientos.Visible = True
                BtnRequerimientos.Text = "Requerimientos"
            End If
        ElseIf Animation = False Then
            If 63 < PAccesos.Size.Width Then
                Dim Limite As Integer = PAccesos.Size.Width
                Dim Regresa As Integer = 1

                PVentanas.Visible = False
                BtnRequerimientos.Visible = False
                For Cerrar As Integer = 63 To 206
                    Limite = Limite - Regresa
                    PAccesos.Size = New Size(Limite, 536)
                Next
                PVentanas.Visible = True
                PVentanas.Refresh()
                BtnRequerimientos.Visible = True
                BtnRequerimientos.Text = Nothing
            End If
        End If
    End Sub
    Private Sub BtnAccess_Click(sender As Object, e As EventArgs) Handles BtnAccess.Click
        If Animation = True Then
            BtnAccess.Text = "»"
            Animation = False
        Else
            BtnAccess.Text = "«"
            Animation = True
        End If
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
        Me.Dispose()
    End Sub
#End Region


    Private Sub BtnRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnRequerimientos.Click
        Requeriment.Show(UC_Requeriment, PVentanas)
    End Sub
End Class
