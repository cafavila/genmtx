Imports Cimagroup.Generador2012.GeneradorBussinesObject
Imports Cimagroup.Generador2012.AnalizadorLexico
Namespace Cimagroup.Generador2012.GeneradorBussinesLogic
    Public Class EstructurarEspecificacionMtx
        Private mEstructura As EstructuraMtx
        Private mLexemas As Collection
        Private Indice As Integer = 0
        Private lex As Simbolo
        Dim bEsCabecera As Boolean = True
        Dim bEsFrm As Boolean = False
        Dim bEsHost As Boolean = False
        Dim bEsSrv As Boolean = False
        Dim bEsReq As Boolean = False
        Dim mFrm As Form
        Dim vHost As Host
        Dim vServer As Server
        Dim vReq As ServiciosRequerimiento
        Dim vTran As Transaccional
        Dim IndiceOcurrencias As Integer = 0
        Public Property Estructura
            Get
                Return mEstructura
            End Get
            Set(value)
                mEstructura = value
            End Set
        End Property
        Public Sub New(lex As Collection)
            mEstructura = New EstructuraMtx
            mLexemas = lex
        End Sub
        Public Sub AnalisisSintactico()
            While Indice < mLexemas.Count
                If bEsCabecera Then
                    bEsCabecera = AnalizarCabecera()
                End If
                If bEsFrm Then
                    bEsFrm = AnalizarHost()
                End If
                If bEsReq Then
                    AnalizarReq()
                End If
            End While
        End Sub
        Private Function getLexema(index As Integer) As Simbolo
            If index < mLexemas.Count Then
                index += 1
                lex = mLexemas.Item(index)
                Indice = index
                Return lex
            Else
                Return Nothing
            End If
        End Function
        Private Function AnalizarCabecera() As Boolean
            Select Case getLexema(Indice).TipoIdentificador
                Case TipoSimbolo.mtxSistemaMTX
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.Sistema = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxTimestamp
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.Timestamp = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxIndicadorPrimerArchivo
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.IndicadorPrimerArchivo = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxMove
                    mEstructura.CabeceraMtx.PIMove = True
                Case TipoSimbolo.mtxLargoHeader
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.LargoHeader = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxLargoRecive
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.LargoReceive = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxLargoSend
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.LargoSend = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxAtributo
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.Atributos = CType(getLexema(Indice).Identificador, Boolean)
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxTagVersion
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.Tag = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxTagDescription
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.DescripcionTag = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxValidaNumerica
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.ValidacionNumerica = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxPrefTrans
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.PrefijoTrans = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxIndicadorNombreCopy
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        mEstructura.CabeceraMtx.NemotecnicoFile = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxInicioFRM
                    bEsFrm = True
                    Indice -= 1
                    Return False
            End Select
            Return True
        End Function
        Private Function AnalizarHost() As Boolean
            Select Case getLexema(Indice).TipoIdentificador
                Case TipoSimbolo.mtxInicioFRM
                    mFrm = New Form()
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxInicioHST Then
                        vHost = New Host()
                        bEsHost = True
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxNombreFRM Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                vHost.Nombre = getLexema(Indice).Identificador.ToString.Substring(1, 3)
                                If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxComentario Then
                                    vHost.Descripcion = mLexemas.Item(Indice).Identificador
                                End If
                            End If
                        End If
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxSistemaFRM
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        vHost.Sistema = getLexema(Indice).Identificador
                    End If
                Case TipoSimbolo.mtxInicioIDX
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        IndiceOcurrencias = getLexema(Indice).Identificador
                        Debug.Print("Ocurrencias {0}{1}", vHost.Nombre, IndiceOcurrencias)
                    End If
                Case TipoSimbolo.mtxFinIDX
                    IndiceOcurrencias = 0
                Case TipoSimbolo.mtxInicioFLD
                    Dim vCampo As New Campo
                    If bEsHost And Not bEsSrv Then
                        While lex.TipoIdentificador <> TipoSimbolo.mtxFinFLD
                            If getLexema(Indice).TipoIdentificador <> TipoSimbolo.mtxComentario Then
                                If lex.Identificador.ToString.First <> Chr(34) And lex.Identificador.ToString.IndexOf("-") > 0 Then
                                    If Not vCampo.NombreCobol Is Nothing AndAlso vCampo.NombreCobol <> lex.Identificador Then
                                        vHost.Campos.Add(vCampo)
                                    End If
                                    vCampo = New Campo
                                    vCampo.NombreCobol = lex.Identificador
                                    vCampo.Indice = IndiceOcurrencias
                                ElseIf lex.Identificador = "IKY" Or lex.Identificador = "FLD" Or lex.Identificador = "AKY" Or lex.Identificador = "MKY" Then
                                    vCampo.TipoAcceso = lex.Identificador
                                ElseIf lex.Identificador.ToString.Contains("9(") Then
                                    vCampo.DescripcionNumerica = lex.Identificador
                                ElseIf lex.Identificador.ToString.First = "(" And lex.Identificador.ToString.Last = ")" Then
                                    vCampo.Tamaño = lex.Identificador.ToString.Substring(1, lex.Identificador.ToString.LastIndexOf(")") - 1)
                                ElseIf lex.Identificador.ToString.First = Chr(34) And lex.Identificador.ToString.Last = Chr(34) Then
                                    vCampo.Etiqueta = lex.Identificador
                                ElseIf lex.Identificador.ToString.First = "[" And lex.Identificador.ToString.Last = "]" Then
                                    vCampo.NombreFML = lex.Identificador
                                ElseIf lex.Identificador.ToString.First = "{" And lex.Identificador.ToString.Last = "}" Then
                                    vCampo.NombreJava = lex.Identificador
                                ElseIf lex.Identificador.ToString.First = "!" Then
                                    vCampo.Javadoc = lex.Identificador
                                ElseIf lex.TipoIdentificador = TipoSimbolo.mtxInicioIDX Then
                                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                        IndiceOcurrencias = getLexema(Indice).Identificador
                                    End If
                                ElseIf lex.TipoIdentificador = TipoSimbolo.mtxFinIDX Then
                                    IndiceOcurrencias = 0
                                End If
                            End If
                        End While
                        If Not vCampo.NombreCobol Is Nothing Then
                            vHost.Campos.Add(vCampo)
                        End If
                    End If
                    If bEsSrv Then
                        While lex.TipoIdentificador <> TipoSimbolo.mtxFinFLD
                            If getLexema(Indice).TipoIdentificador <> TipoSimbolo.mtxFinFLD Then
                                If lex.TipoIdentificador = TipoSimbolo.mtxInicioIDX Then
                                    'If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                    '    vServer.Indice = getLexema(Indice).Identificador
                                    'End If
                                ElseIf lex.TipoIdentificador = TipoSimbolo.mtxFinIDX Then
                                    IndiceOcurrencias = 0
                                ElseIf lex.TipoIdentificador <> TipoSimbolo.mtxComentario Then
                                    vServer.Campos.Add(lex.Identificador)
                                End If
                            End If
                        End While
                        mFrm.Server.Add(vServer)
                    End If
                Case TipoSimbolo.mtxFinHST
                    bEsHost = False
                    If Not vHost Is Nothing Then
                        mFrm.Host = vHost
                    End If
                Case TipoSimbolo.mtxInicioSRV
                    vServer = New Server
                    bEsSrv = True
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxNombreFRM Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vServer.Nombre = getLexema(Indice).Identificador.ToString.Substring(1, 3)
                        End If
                    End If
                Case TipoSimbolo.mtxFinSRV
                    bEsSrv = False
                    For Each item In mFrm.Server
                        Debug.Print("SRV - {0}, {1}, {2}", mFrm.Host.Nombre, item.Nombre, item.Campos.Count)
                    Next
                Case TipoSimbolo.mtxFinFRM
                    mEstructura.PantallasFrm.Add(mFrm)
                Case TipoSimbolo.mtxInicioREQ
                    bEsReq = True
                    Indice -= 1
                    Return False
            End Select
            Return True
        End Function
        Private Function AnalizarReq() As Boolean
            Select Case getLexema(Indice).TipoIdentificador
                Case TipoSimbolo.mtxInicioREQ
                    vReq = New ServiciosRequerimiento
                    vReq.Atributos = mEstructura.CabeceraMtx.Atributos
                Case TipoSimbolo.mtxDEF
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        vReq.Descripcion = getLexema(Indice).Identificador
                        vReq.MetodoJava = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxNombreFRM
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        vReq.Nombre = getLexema(Indice).Identificador
                        vReq.PantallaComando = getLexema(Indice).Identificador
                    Else
                        Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                    End If
                Case TipoSimbolo.mtxAtributosReq
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        vReq.Atributos = getLexema(Indice).Identificador
                    End If
                Case TipoSimbolo.mtxInicioPT
                    Dim pt As StructureReq
                    Dim idx As Integer
                    While lex.TipoIdentificador <> TipoSimbolo.mtxFinPT
                        If lex.TipoIdentificador = TipoSimbolo.mtxInicioIDX Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                idx = getLexema(Indice).Identificador
                            End If
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFinIDX Then
                            idx = 0
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFRM Then
                            pt = New StructureReq
                            pt.Index = idx
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    pt.Pantalla = ""
                                Else
                                    pt.Pantalla = lex.Identificador.ToString.Substring(1, 3)
                                End If
                            End If
                            getLexema(Indice)
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFMT Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    pt.Server = ""
                                Else
                                    pt.Server = lex.Identificador.ToString.Substring(1, 3)
                                End If
                                vReq.PT.Add(pt)
                            End If
                        End If
                        getLexema(Indice)
                    End While
                Case TipoSimbolo.mtxInicioTP
                    Dim tp As StructureReq
                    Dim idx As Integer
                    While lex.TipoIdentificador <> TipoSimbolo.mtxFinTP
                        If lex.TipoIdentificador = TipoSimbolo.mtxInicioIDX Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                idx = getLexema(Indice).Identificador
                            End If
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFinIDX Then
                            idx = 0
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFRM Then
                            tp = New StructureReq
                            tp.Index = idx
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    tp.Pantalla = ""
                                Else
                                    tp.Pantalla = lex.Identificador.ToString.Substring(1, 3)
                                End If
                            End If
                            getLexema(Indice)
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFMT Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    tp.Server = ""
                                Else
                                    tp.Server = lex.Identificador.ToString.Substring(1, 3)
                                End If
                                vReq.TP.Add(tp)
                            End If
                        End If
                        getLexema(Indice)
                    End While
                Case TipoSimbolo.mtxInicioTX
                    Dim tx As StructureReq
                    Dim idx As Integer
                    While lex.TipoIdentificador <> TipoSimbolo.mtxFinTX
                        If lex.TipoIdentificador = TipoSimbolo.mtxInicioIDX Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                idx = getLexema(Indice).Identificador
                            End If
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFinIDX Then
                            idx = 0
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFRM Then
                            tx = New StructureReq
                            tx.Index = idx
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    tx.Pantalla = ""
                                Else
                                    tx.Pantalla = lex.Identificador.ToString.Substring(1, 3)
                                End If
                            End If
                            getLexema(Indice)
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFMT Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    tx.Server = ""
                                Else
                                    tx.Server = lex.Identificador.ToString.Substring(1, 3)
                                End If
                                vReq.TX.Add(tx)
                            End If
                        End If
                        getLexema(Indice)
                    End While
                Case TipoSimbolo.mtxInicioXT
                    Dim xt As StructureReq
                    Dim idx As Integer
                    While lex.TipoIdentificador <> TipoSimbolo.mtxFinXT
                        If lex.TipoIdentificador = TipoSimbolo.mtxInicioIDX Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                idx = getLexema(Indice).Identificador
                            End If
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFinIDX Then
                            idx = 0
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFRM Then
                            xt = New StructureReq
                            xt.Index = idx
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    xt.Pantalla = ""
                                Else
                                    xt.Pantalla = lex.Identificador.ToString.Substring(1, 3)
                                End If
                            End If
                            getLexema(Indice)
                        End If
                        If lex.TipoIdentificador = TipoSimbolo.mtxFMT Then
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                If getLexema(Indice).Identificador.ToString.Count < 3 Then
                                    xt.Server = ""
                                Else
                                    xt.Server = lex.Identificador.ToString.Substring(1, 3)
                                End If
                                vReq.XT.Add(xt)
                            End If
                        End If
                        getLexema(Indice)
                    End While
                Case TipoSimbolo.mtxFinREQ
                    If Not vReq Is Nothing Then
                        Debug.Print("{0} - {1}", vReq.Nombre, vReq.Descripcion)
                        mEstructura.ServiciosReq.Add(vReq)
                    End If
                    '  Return False
                Case TipoSimbolo.mtxInicioTRN
                    vTran = New Transaccional
                    Dim first As TipoSimbolo = getLexema(Indice).TipoIdentificador
                    If first = TipoSimbolo.mtxINM Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Inmando = getLexema(Indice).Identificador
                            If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxFRM Then
                                If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                                    vTran.Pantalla = getLexema(Indice).Identificador
                                Else
                                    Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                                End If
                            End If
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    ElseIf first = TipoSimbolo.mtxFRM Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Pantalla = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxCMN Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Comando = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxCPP Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.CPP = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSPP Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.SPP = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxPGM Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Programa = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSUB Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Subprograma = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxINS Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Instancia = getLexema(Indice).Identificador.ToString.Substring(1, 3)
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxFIN Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.FormIn = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxFOU Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.FormOut = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxCMT Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.Comentario = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    End If
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxIDD Then
                        If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                            vTran.IDD = getLexema(Indice).Identificador
                        Else
                            Debug.Print("Simbolo N° {1} - '{0}', no es el simbolo esperado", lex.Identificador, Indice)
                        End If
                    Else
                        Indice -= 1
                    End If
                Case TipoSimbolo.mtxCNF
                    If getLexema(Indice).TipoIdentificador = TipoSimbolo.mtxSignoIgual Then
                        vTran.Confirmacion = getLexema(Indice).Identificador
                    End If
                Case TipoSimbolo.mtxFinTRN
                    If Not vTran Is Nothing Then
                        vReq.Transaccional.Add(vTran)
                    End If
            End Select
            Return True
        End Function
    End Class
End Namespace