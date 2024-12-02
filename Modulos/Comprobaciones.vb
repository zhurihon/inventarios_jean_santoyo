
Imports System.Text.RegularExpressions

Module Comprobaciones

    Public Function txtmaxymin(txt As String, maxlong As Integer, minlong As Integer) As Boolean
        If txt.Length <= maxlong And txt.Length >= minlong Then
            Return 1
        Else
            Return 0
        End If
    End Function




    Public Function txtmax(txt As String, maxlong As Integer) As Boolean
        If txt.Length <= maxlong Then
            Return 1
        Else
            Return 0
        End If
    End Function


    Public Function txtmin(txt As String, minlong As Integer) As Boolean
        If txt.Length >= minlong Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function txtmail(mail As String) As Boolean
        If Regex.IsMatch(mail, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Or mail = "" Then
            ' El string tiene formato de correo electrónico
            Return 1
        Else
            ' El string no tiene formato de correo electrónico
            Return 0
        End If
    End Function

    Public Function txtnumero(numero As String) As Boolean
        Return IsNumeric(numero)
    End Function

    Public Function txtvacio(s As String) As Boolean
        Return IsNothing(s) Or s.Length = 0
    End Function



    Public Class comprobacion
        Public telefono As Boolean = 0
        Public mail As Boolean = 0
        Public nombre As Boolean = 0
        Public id As Boolean = 0
        Public descripcion As Boolean = 0
        Public direccion As Boolean = 0
        Public Function comprobar() As Boolean
            Return telefono And mail And nombre And id And descripcion And direccion
        End Function
    End Class

    Public control_proveedor As New comprobacion

End Module
