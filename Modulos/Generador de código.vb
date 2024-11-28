Module Generador_de_código



    Public Function get_code(cat As String, ncat As Integer) As String
        Select Case cat
            Case "Herramienta"
                Return "H" & ncat
            Case "Repuesto"
                Return "Rp" & ncat
            Case "Aceites"
                Return "Ac" & ncat
            Case "Otros"
                Return "O" & ncat
        End Select
    End Function







End Module
