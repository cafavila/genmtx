Imports System
Imports System.IO
Imports System.Data
Imports System.Object
'Imports System.Windows.Forms
Imports System.Drawing.Color
Imports Microsoft.Office.Interop
Imports Office = Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports BeeMTXTools
Imports CAFBeeTeam
Namespace Cimagroup.Generador2012.ConvertidorTablas
    Public Class OfficeCodeBehind
        Friend WithEvents ThisWorkbook As Excel.Workbook
        Friend WithEvents ThisAplication As Excel.Application
        Private m_Excel As Excel.Application
        Public Shared sError As String = "Inicial"
        Public Shared logFile As String = ""
        Public Shared logConsole As New Microsoft.VisualBasic.Collection()
        Public Shared ftLog As New FileTools()
        Public Shared filename As String = ""
        Public Shared Register As New Microsoft.VisualBasic.Collection()
        Public Shared conf As AppConfig = New AppConfig()
        Public Columna() As String = {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U"}
        Public Shared Sub Main()
            Try
                sError = "Main"
                logConsole.Add("==========================================================================")
                logConsole.Add("  Template Excel                                                          ")
                logConsole.Add("  Producto desarrollado por (CAF - Cesar Avila Frias) BeeTeam             ")
                logConsole.Add("  Mayo 2005 Santiago Chile                                                ")
                logConsole.Add("  Compilacion : " & Date.Now())
                logConsole.Add("==========================================================================")
                Dim fw As New OfficeCodeBehind
                Dim param As String() = {"config.xml"}
                conf.Main(param)
                logConsole.Add("  Entrada  : " & conf.LeerConfig("Entrada"))
                logConsole.Add("  Salida   : " & conf.LeerConfig("Salida"))
                logFile = conf.LeerConfig("Salida") & conf.LeerConfig("logFile")
                sError = "Seteo"
                fw.m_Excel = New Excel.Application
                fw.ThisWorkbook_Open()
                fw.m_Excel.Quit()
                sError = "Final"
                logConsole.Add("==========================================================================")
                ftLog.CrearLog(logFile, logConsole)
                MsgBox("Archivo Procesado")
            Catch ex As Exception
                MsgBox(ex.Message & " " & sError)
            End Try
        End Sub
        Private Sub ThisWorkbook_Open() Handles ThisWorkbook.Open
            Try
                sError = "Apertura de Archivo"
                m_Excel.Workbooks.Open(conf.LeerConfig("Entrada"))
                logConsole.Add("  Libro - " & m_Excel.ActiveWorkbook.Name)
                Dim i As Integer
                For i = 1 To m_Excel.ActiveWorkbook.Sheets.Count
                    Register = New Collection
                    Register.Add("      *    BEETEAM " & Date.Now())
                    Register.Add("      *    " & conf.LeerConfig("Archivo"))
                    Register.Add("      *    USUARIO = " & Environment.UserName)
                    Register.Add("      *")
                    Register.Add("      *    " & m_Excel.ActiveWorkbook.Sheets(i).name & ".BCI") 'm_Excel.ActiveWorkbook.Sheets(i).name.subString(0,3) & "PMC0" & i.toString & ".SAL")
                    Register.Add("      *")
                    If conf.LeerConfig("Destino") = "BEE" Then
                        Register.Add(Space(11) & "MOVE")
                        Register.Add(Space(10) & "'      *    SIS = " & m_Excel.ActiveWorkbook.Sheets(i).name.subString(0, 3) & "'")
                        Register.Add(Space(11) & "TO WSS-COD-REGI.")
                        Register.Add(Space(11) & "PERFORM SET-REGI.")
                        Register.Add(Space(11) & "MOVE")
                        Register.Add(Space(10) & "'      *    OPC = C '")
                        Register.Add(Space(11) & "TO WSS-COD-REGI.")
                        Register.Add(Space(11) & "PERFORM SET-REGI.")
                        Register.Add(Space(11) & "MOVE")
                        Register.Add(Space(10) & "'      *    SI OPC = C ==> CARGA DE PARAMETROS'")
                        Register.Add(Space(11) & "TO WSS-COD-REGI.")
                        Register.Add(Space(11) & "PERFORM SET-REGI.")
                        Register.Add(Space(11) & "MOVE")
                        Register.Add(Space(10) & "'      *    SI OPC = D ==> DESCARGA DE PARAMETROS'")
                        Register.Add(Space(11) & "TO WSS-COD-REGI.")
                        Register.Add(Space(11) & "PERFORM SET-REGI.")
                    End If
                    If conf.LeerConfig("Destino") = "IBM" Then
                        Register.Add("      *    SIS = " & m_Excel.ActiveWorkbook.Sheets(i).name.subString(0, 3))
                        Register.Add("      *    OPC = C ")
                        Register.Add("      *    SI OPC = C ==> CARGA DE PARAMETROS")
                        Register.Add("      *    SI OPC = D ==> DESCARGA DE PARAMETROS")
                    End If
                    m_Excel.ActiveWorkbook.Sheets(i).Select()
                    logConsole.Add("  Hoja - " & m_Excel.ActiveWorkbook.Sheets(i).name)
                    filename = conf.LeerConfig("Salida") & m_Excel.ActiveWorkbook.Sheets(i).name & ".BCI" 'm_Excel.ActiveWorkbook.Sheets(i).name.subString(0,3) & "PMC0" & i.toString & ".BCI"
                    Dim j As Integer
                    Dim rng As Excel.Range
                    Dim Valor As Excel.Range
                    Dim l As Integer = 7
                    While Not (Trim(m_Excel.Range("C" & l).Value) = "")
                        Dim str(193) As Char
                        Dim Index As Integer = 0
                        'logConsole.add(m_Excel.Range("C" & l).bound)
                        For j = 0 To Columna.Length - 1
                            rng = m_Excel.Range(Columna(j) & "5")
                            Valor = m_Excel.Range(Columna(j) & l)
                            Dim Largo As Integer = CInt(rng.Value)
                            Dim aux(Largo) As Char
                            aux = CStr(Valor.Value)
                            Dim k As Integer
                            '     logConsole.add(str)
                            For k = 0 To Largo - 1
                                If k < Len(aux) Then
                                    str(Index) = aux(k)
                                Else
                                    str(Index) = Space(1)
                                End If
                                Index += 1
                            Next k
                            'logConsole.add()
                            'logConsole.add(str)
                        Next j
                        If conf.LeerConfig("Destino") = "BEE" Then
                            Register.Add(Space(11) & "MOVE")
                            Register.Add(Space(10) & "'REGTAB" & m_Excel.ActiveWorkbook.Sheets(i).name.subString(0, 3) & "'")
                            Register.Add(Space(11) & "TO WSS-COD-REGI.")
                            Register.Add(Space(11) & "PERFORM SET-REGI.")
                            Dim paso As String = str
                            Register.Add(Space(11) & "MOVE")
                            Register.Add(Space(10) & "'" & paso.Substring(0, 60) & "'")
                            Register.Add(Space(11) & "TO WSS-COD-REGI.")
                            Register.Add(Space(11) & "PERFORM SET-REGI.")
                            Register.Add(Space(11) & "MOVE")
                            Register.Add(Space(10) & "'" & paso.Substring(60, 60) & "'")
                            Register.Add(Space(11) & "TO WSS-COD-REGI.")
                            Register.Add(Space(11) & "PERFORM SET-REGI.")
                            Register.Add(Space(11) & "MOVE")
                            Register.Add(Space(10) & "'" & paso.Substring(120, 60) & "'")
                            Register.Add(Space(11) & "TO WSS-COD-REGI.")
                            Register.Add(Space(11) & "PERFORM SET-REGI.")
                            Register.Add(Space(11) & "MOVE")
                            Register.Add(Space(10) & "'" & paso.Substring(180, 14) & "'")
                            Register.Add(Space(11) & "TO WSS-COD-REGI.")
                            Register.Add(Space(11) & "PERFORM SET-REGI.")
                        End If
                        If conf.LeerConfig("Destino") = "IBM" Then
                            Register.Add("REGTAB" & m_Excel.ActiveWorkbook.Sheets(i).name.subString(0, 3))
                            'Register.add(str)
                            Dim paso As String = str
                            Register.Add(paso.Substring(0, 60))
                            Register.Add(paso.Substring(60, 60))
                            Register.Add(paso.Substring(120, 60))
                            Register.Add(paso.Substring(180, 14))
                        End If
                        l += 1
                    End While
                    If conf.LeerConfig("Destino") = "BEE" Then
                        Register.Add(Space(11) & "MOVE")
                        Register.Add(Space(10) & "'FINPI1'")
                        Register.Add(Space(11) & "TO WSS-COD-REGI.")
                        Register.Add(Space(11) & "PERFORM SET-REGI.")
                    End If
                    If conf.LeerConfig("Destino") = "IBM" Then
                        Register.Add("FINPI1")
                    End If
                    ftLog.CrearLog(filename, Register)
                    logConsole.Add(Space(2) & filename & " Cuenta con " & (l - 7).ToString & " registros")
                Next i
            Catch ex As Exception
                sError = "Con errores"
                logConsole.Add("  Error : " & ex.Message)
            End Try
        End Sub
    End Class
End Namespace