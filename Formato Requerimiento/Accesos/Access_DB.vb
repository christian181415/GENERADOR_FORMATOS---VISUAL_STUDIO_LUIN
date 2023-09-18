Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Access_DB
    '░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    '░░░░░░░░░░░░░░░░░░░░FUNCION PARA OBTENER LA CADENA DE CONEXION A LA BASE DE DATOS QUE SE LE DETERMINE
    '░░░░░░░░░░░░░░░░░░░░SOLO SE MODIFICAN LAS VARIABLES PRIMARIAS PARA FORMAR LA CADENA DE CONEXION COMPLETA
    Dim TipoDB As String = "MySQL"
    Dim Security As Boolean = True
    '░░░░░░░░░░░░░░░░░░░░VARIABLES PARA UNA CONEXION ACCESS | SQL | MySQL (RELLENAR LO NECESARIO)
    Dim Servidor As String = "localhost"
    Dim Source As String = "db_requeriment"
    Dim Usuario As String = "SSIT"
    Dim PasswordDB As String = "SSITDBLuin*"





    '░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    '░░░░░░░░░░░░░░░░░░░░CADENA DE CONEXION PARA SABER SI EXISTE UN ENLACE A LA BASE DE DATOS
    ''' <summary>
    ''' • Funcion para unir un conjunto de variables y formar una cadena de accesso a una base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function ConexionString() As String
        Dim Proveedor, CadenaConexion As String
        If TipoDB = "Access" Then
            '░░░░░░░░░░░░░░░░░░░░VALIDACION DE CONEXION ACCESS CON O SIN CONTRASEÑA
            Proveedor = "Microsoft.ACE.OLEDB.12.0"
            If Security = False Then
                CadenaConexion = "Provider =" & Proveedor & "; Data Source =|DataDirectory|\Assets\DB\" & Source & ";Persist Security Info =" & Security
            ElseIf Security = True Then
                CadenaConexion = "Provider =" & Proveedor & "; Data Source =|DataDirectory|\Assets\DB\" & Source & ";Jet OLEDB:Database Password =" & PasswordDB
            Else
                MsgBox("Error en los datos de su cadena de conexión.")
                CadenaConexion = Nothing
            End If
            Return CadenaConexion
        ElseIf TipoDB = "SQLServer" Then
            '░░░░░░░░░░░░░░░░░░░░VALIDACION DE CONEXION SQL CON O SIN CONTRASEÑA
            Proveedor = "System.Data.ProviderName"
            If Security = False Then
                CadenaConexion = "ProviderName=" & Proveedor & ";Data Source=" & Servidor & ";Initial Catalog=" & Source & "Integrated Security=" & Security & ";"
            ElseIf Security = True Then
                CadenaConexion = "ProviderName=" & Proveedor & ";Data Source=" & Servidor & ";Initial Catalog=" & Source & ";Integrated Security=" & Security & ";User=" & Usuario & ";Pwd=" & PasswordDB
            Else
                MsgBox("Error en los datos de su cadena de conexión.")
                CadenaConexion = Nothing
            End If
            Return CadenaConexion
        ElseIf TipoDB = "MySQL" Then
            '░░░░░░░░░░░░░░░░░░░░VALIDACION DE CONEXION MySQL CON O SIN CONTRASEÑA
            If Security = False Then
                CadenaConexion = "Server=" & Servidor & ";UserID=" & Usuario & ";Database=" & Source
            ElseIf Security = True Then
                CadenaConexion = "Server=" & Servidor & ";UserID=" & Usuario & ";Password=" & PasswordDB & ";Database=" & Source
            Else
                MsgBox("Error en los datos de su cadena de conexión.")
                CadenaConexion = Nothing
            End If
            Return CadenaConexion
        Else
            MsgBox("Su base de datos no corresponde a las registradas por el sistema." & Chr(10) & "Favor de revisar.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN")
        End If
    End Function





    '░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    '░░░░░░░░░░░░░░░░░░░░FUNCION PARA SELECCIONAR TODA LA INFORMACION EXISTENTE DE UNA TABLA DE BASE DE DATOS
    '░░░░░░░░░░░░░░░░░░░░ESTAS FUNCIONES NO SE DEBEN MODIFICAR YA QUE ES UNA ESTRUCTURA Y SE MANDA A OTRA CLASE DONDE
    '░░░░░░░░░░░░░░░░░░░░SE PASAN TODOS LOS COMPONENTES NECESARIOS PARA LA CONSULTA A LA BASE DE DATOS.
    '░░░░░░░░░░░░░░░░░░░░FUNCION OBTENER *TODA* LA INFORMACION DE DB DE MANERA *AUTOMATICA*
    ''' <summary>
    ''' • Funcion para obtener toda la informacion, mientras la conexion este abierta. (NO SE GUARDA EN CACHE)
    ''' </summary>
    Public Function SELECT_DATAREADER(Consulta As String)
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim DTReader As OleDbDataReader = Nothing
            Dim Comando As OleDbCommand = Nothing
            Try
                Comando = New OleDbCommand(Consulta, ConexionDB)
                ConexionDB.Open()
                DTReader = Comando.ExecuteReader
                ConexionDB.Close()
                ConexionDB.Dispose()
                Return DTReader
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATAREADER")
            End Try
        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim DTReader As MySqlDataReader = Nothing
            Dim Comando As MySqlCommand = Nothing
            Try
                Comando = New MySqlCommand(Consulta, ConexionDB)
                ConexionDB.Open()
                DTReader = Comando.ExecuteReader
                ConexionDB.Close()
                ConexionDB.Dispose()
                Return DTReader
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATAREADER")
            End Try
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░FUNCION OBTENER *TODA* LA INFORMACION DE DB MEDIANTE PARAMETROS
    ''' <summary>
    ''' • Funcion para obtener toda la informacion, mientras la conexion este abierta. (NO SE GUARDA EN CACHE)
    ''' </summary>
    Public Function SELECT_DATAREADER_PARAMS(Consulta As String, Parametros As IEnumerable(Of MySqlParameter))
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim DTReader As OleDbDataReader = Nothing
            Dim Comando As OleDbCommand = Nothing
            Try
                Comando = New OleDbCommand(Consulta, ConexionDB)
                ConexionDB.Open()
                DTReader = Comando.ExecuteReader
                ConexionDB.Close()
                ConexionDB.Dispose()
                Return DTReader
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATAREADER")
            End Try
        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim DTReader As MySqlDataReader = Nothing
            Dim Comando As MySqlCommand = Nothing
            Try
                Comando = New MySqlCommand(Consulta, ConexionDB)
                ConexionDB.Open()
                For Each Param As MySqlParameter In Parametros
                    Comando.Parameters.Add(Param)
                Next
                DTReader = Comando.ExecuteReader
                ConexionDB.Close()
                ConexionDB.Dispose()
                Return DTReader
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATAREADER")
            End Try
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░FUNCION OBTENER LA INFORMACION DE DB MEDIANTE *PARAMETROS*
    ''' <summary>
    ''' • Funcion para obtener la informacion de base de datos mediante parametros. (SE GUARDA EN CACHE)
    ''' </summary>
    Public Function SELECT_DATASET_PARAMS(Consulta As String, Parametros As IEnumerable(Of MySqlParameter)) As DataSet
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim DTSet As DataSet = Nothing
            Dim DTAdapter As OleDbDataAdapter = Nothing
            Dim Comando As OleDbCommand = Nothing
            If ConexionDB Is Nothing Then
                DTSet = Nothing
                MsgBox("Sin conexion a la base de datos", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATASET_PARAMS")
            Else
                Try
                    Comando = New OleDbCommand(Consulta, ConexionDB)
                    DTAdapter = New OleDbDataAdapter()
                    DTSet = New DataSet
                    DTAdapter.SelectCommand = Comando
                    ConexionDB.Open()
                    'For Each Param As OleDbParameter In Parametros
                    '    Comando.Parameters.Add(Param)
                    'Next
                    DTAdapter.Fill(DTSet)
                    ConexionDB.Close()
                    ConexionDB.Dispose()
                    Return DTSet
                Catch ex As Exception
                    MsgBox("Error al procesar la información." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATASET_PARAMS")
                End Try
            End If
        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim DTSet As DataSet = Nothing
            Dim DTAdapter As MySqlDataAdapter = Nothing
            Dim Comando As MySqlCommand = Nothing
            If ConexionDB Is Nothing Then
                DTSet = Nothing
                MsgBox("Sin conexion a la base de datos", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATASET_PARAMS")
            Else
                Try
                    Comando = New MySqlCommand(Consulta, ConexionDB)
                    DTAdapter = New MySqlDataAdapter()
                    DTSet = New DataSet
                    DTAdapter.SelectCommand = Comando
                    ConexionDB.Open()
                    For Each Param As MySqlParameter In Parametros
                        Comando.Parameters.Add(Param)
                    Next
                    DTAdapter.Fill(DTSet)
                    ConexionDB.Close()
                    ConexionDB.Dispose()
                    Return DTSet
                Catch ex As Exception
                    MsgBox("Error al procesar la información." & Chr(10) & ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATASET_PARAMS")
                End Try
            End If
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░FUNCION OBTENER LA INFORMACION DE DB DE MANERA *SIMPLE*
    ''' <summary>
    ''' • Funcion para obtener la informacion de base de datos, aunque la conexion este cerrada. (SE GUARDA EN CACHE)
    ''' </summary>
    Public Function SELECT_DATASET(Consulta As String) As DataSet
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim DTSet As DataSet = Nothing
            Dim DTAdapter As OleDbDataAdapter = Nothing
            Dim Comando As OleDbCommand = Nothing
            Try
                Comando = New OleDbCommand(Consulta, ConexionDB)
                DTAdapter = New OleDbDataAdapter()
                DTSet = New DataSet
                DTAdapter.SelectCommand = Comando
                ConexionDB.Open()
                DTAdapter.Fill(DTSet)
                ConexionDB.Close()
                ConexionDB.Dispose()
                Return DTSet
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATASET")
            End Try
        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim DTSet As DataSet = Nothing
            Dim DTAdapter As MySqlDataAdapter = Nothing
            Dim Comando As MySqlCommand = Nothing
            Try
                Comando = New MySqlCommand(Consulta, ConexionDB)
                DTAdapter = New MySqlDataAdapter()
                DTSet = New DataSet
                DTAdapter.SelectCommand = Comando
                ConexionDB.Open()
                DTAdapter.Fill(DTSet)
                ConexionDB.Close()
                ConexionDB.Dispose()
                Return DTSet
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | SELECT_DATASET")
            End Try
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░FUNCION *INSERTAR* LA INFORMACION EN LA DB
    ''' <summary>
    ''' • Funcion para insertar información en la base de datos.
    ''' </summary>
    Public Function INSERTDB(Consulta As String, Parametros As IEnumerable(Of MySqlParameter))
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim Comando As OleDbCommand = Nothing
            If ConexionDB IsNot Nothing Then
                Try
                    Comando = New OleDbCommand(Consulta, ConexionDB)
                    ConexionDB.Open()
                    For Each Param As MySqlParameter In Parametros
                        Comando.Parameters.Add(Param)
                    Next
                    Comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | INSERTDB")
                End Try
                ConexionDB.Close()
                ConexionDB.Dispose()
            Else
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | INSERTDB")
            End If


        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim Comando As MySqlCommand = Nothing
            If ConexionDB IsNot Nothing Then
                Try
                    Comando = New MySqlCommand(Consulta, ConexionDB)
                    ConexionDB.Open()
                    For Each Param As MySqlParameter In Parametros
                        Comando.Parameters.Add(Param)
                    Next
                    Comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | INSERTDB")
                End Try
                ConexionDB.Close()
                ConexionDB.Dispose()
            Else
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | INSERTDB")
            End If
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░FUNCION *ACTUALIZAR* LA INFORMACION EN LA DB
    ''' <summary>
    ''' • Funcion para actualizar información en la base de datos.
    ''' </summary>
    Public Function UPDATEDB(Consulta As String)
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim Comando As OleDbCommand = Nothing
            If ConexionDB IsNot Nothing Then
                Try
                    Comando = New OleDbCommand(Consulta, ConexionDB)
                    Comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | UPDATEDB")
                End Try
                ConexionDB.Close()
                ConexionDB.Dispose()
            Else
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | UPDATEDB")
            End If
        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim Comando As MySqlCommand = Nothing
            If ConexionDB IsNot Nothing Then
                Try
                    Comando = New MySqlCommand(Consulta, ConexionDB)
                    Comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | UPDATEDB")
                End Try
                ConexionDB.Close()
                ConexionDB.Dispose()
            Else
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | UPDATEDB")
            End If
        End If
    End Function
    '░░░░░░░░░░░░░░░░░░░░FUNCION *ELIMINAR TODA* LA INFORMACION DE UNA TABLA
    ''' <summary>
    ''' • Funcion para eliminar información en la base de datos.
    ''' </summary>
    Public Function DELETEDB(Consulta As String)
        If TipoDB = "Access" Then
            Dim ConexionDB As New OleDbConnection(ConexionString)
            Dim Comando As OleDbCommand = Nothing
            If ConexionDB IsNot Nothing Then
                Try
                    Comando = New OleDbCommand(Consulta, ConexionDB)
                    Comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | DELETEDB")
                End Try
                ConexionDB.Close()
                ConexionDB.Dispose()
            Else
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | DELETEDB")
            End If
        ElseIf TipoDB = "MySQL" Then
            Dim ConexionDB As New MySqlConnection(ConexionString)
            Dim Comando As MySqlCommand = Nothing
            If ConexionDB IsNot Nothing Then
                Try
                    Comando = New MySqlCommand(Consulta, ConexionDB)
                    Comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | DELETEDB")
                End Try
                ConexionDB.Close()
                ConexionDB.Dispose()
            Else
                MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "ERROR | CORPORATIVO LUIN | DELETEDB")
            End If
        End If
    End Function
End Class
