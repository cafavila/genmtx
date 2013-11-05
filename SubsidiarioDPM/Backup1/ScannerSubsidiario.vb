Imports System.IO
Imports System.Text.RegularExpressions
Public Class ScannerSubsidiario
    Private mStream As StreamReader
    Private mRegSubsidiario As Subsidiario
    Private mSubsidiario As List(Of Subsidiario)
    Public ReadOnly Property Subsidiarios() As List(Of Subsidiario)
        Get
            Return mSubsidiario
        End Get
    End Property
    Public Sub New(ByVal streamFile As StreamReader)
        mStream = streamFile
        mSubsidiario = New List(Of Subsidiario)
        Me.Scanner()
    End Sub
    Private Sub Scanner()
        Dim Fecha As String = ""
        Dim Oficina As String = ""
        Dim CtaCtbl As String = ""
        While Not mStream.EndOfStream
            Dim linea As String = mStream.ReadLine()
            If linea.Substring(0, 1) = "1" Then
                Fecha = linea.Substring(linea.IndexOf("/") - 2, 10)
            ElseIf linea.Contains("OFICINA") Then
                Oficina = linea.Substring(11, 20)
            ElseIf linea.Contains("CTA CONTABLE") Then
                CtaCtbl = linea.Substring(16, 10)
            ElseIf EvaluaLinea(linea) Then
                mRegSubsidiario = New Subsidiario()
                mRegSubsidiario.Fecha = Fecha
                mRegSubsidiario.Oficina = Oficina
                mRegSubsidiario.CtaCtble = CtaCtbl
                mRegSubsidiario.Nombre = linea.Substring(1, 23)
                mRegSubsidiario.Rut = linea.Substring(24, 12)
                mRegSubsidiario.NumeroOperacion = linea.Substring(40, 12)
                mRegSubsidiario.NumeroSerial = linea.Substring(53, 12)
                mRegSubsidiario.Tasa = linea.Substring(67, 6)
                mRegSubsidiario.Debe = linea.Substring(74, 18)
                mRegSubsidiario.Haber = linea.Substring(94, 18)
                mRegSubsidiario.Algoritmo = linea.Substring(112, 1)
                mRegSubsidiario.Saldo = linea.Substring(116, 17)
                mSubsidiario.Add(mRegSubsidiario)
            Else
                Debug.Print(linea)
            End If
        End While
    End Sub
    Private Function EvaluaLinea(ByVal linea As String) As Boolean
        If (linea.Contains("-") And linea.Contains(",")) Or (linea.Contains("MULTIPLES CLIENTES")) Then
            Return True
        End If
        Return False
        ' Return Regex.IsMatch(linea, "^[A-Z]\w*\d*-\d{1}")
    End Function
End Class
