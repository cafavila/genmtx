Namespace Cimagroup.Generador2012.AnalizadorLexico
    Public Enum TipoSimbolo
        Indefinido
        mtxMove
        mtxTagVersion
        mtxTagDescription
        mtxComentario
        mtxComillas
        mtxSignoIgual
        mtxSistemaMTX
        mtxTimestamp
        mtxLargoSend
        mtxLargoRecive
        mtxLargoHeader
        mtxComplementoNumericoInicio
        mtxAtributo
        mtxIndicadorPrimerArchivo
        mtxIndicadorNombreCopy
        mtxInicioFRM
        mtxFinFRM
        mtxInicioHST
        mtxFinHST
        mtxNombreFRM
        mtxSistemaFRM
        mtxInicioFLD
        mtxFinFLD
        mtxInicioSRV
        mtxFinSRV
        mtxAKY
        mtxIKY
        mtxMKY
        mtxInicioREQ
        mtxFinREQ
        mtxDEF
        mtxInicioPT
        mtxFinPT
        mtxFRM
        mtxFMT
        mtxInicioTX
        mtxFinTX
        mtxInicioXT
        mtxFinXT
        mtxInicioTP
        mtxFinTP
        mtxInicioIDX
        mtxFinIDX
        mtxInicioTRN
        mtxFinTRN
        mtxINM
        mtxCMN
        mtxCPP
        mtxSPP
        mtxPGM
        mtxSUB
        mtxINS
        mtxFIN
        mtxFOU
        mtxCMT
        mtxIDD
        mtxCNF
        mtxText
        mtxAtributosReq
        mtxPrefTrans
    End Enum
    Public Class Simbolos
        Private mSimbolos As Hashtable
        Private mMasLargo As Integer = 0
        Public ReadOnly Property MasLargo As Integer
            Get
                If mMasLargo > 0 Then
                    For Each s As String In mSimbolos.Keys
                        If s.Length > mMasLargo Then
                            mMasLargo = s.Length
                        End If
                    Next
                End If
                Return mMasLargo
            End Get
        End Property
        Public Sub New()
            mSimbolos = New Hashtable()
            ' Ordenados del mas largo al mas corto
            mSimbolos.Add("$_IND_ARCH_FST", TipoSimbolo.mtxIndicadorPrimerArchivo)
            mSimbolos.Add("$_CPL_NUM_INI", TipoSimbolo.mtxComplementoNumericoInicio)
            mSimbolos.Add("$_ATR_PRT_REQ", TipoSimbolo.mtxAtributosReq)
            mSimbolos.Add("$_PREF_TRAN", TipoSimbolo.mtxPrefTrans)
            mSimbolos.Add("$_TIME_STP", TipoSimbolo.mtxTimestamp)
            mSimbolos.Add("$_TAG_DESC", TipoSimbolo.mtxTagDescription)
            mSimbolos.Add("$_TAG_VRS", TipoSimbolo.mtxTagVersion)
            mSimbolos.Add("$_SIS_FIL", TipoSimbolo.mtxSistemaMTX)
            mSimbolos.Add("$_PI_MOVE", TipoSimbolo.mtxMove)
            mSimbolos.Add("$_LRG_HDR", TipoSimbolo.mtxLargoHeader)
            mSimbolos.Add("$_ATR_PRT", TipoSimbolo.mtxAtributo)
            mSimbolos.Add("$_LRG_SND", TipoSimbolo.mtxLargoSend)
            mSimbolos.Add("$_LRG_RCV", TipoSimbolo.mtxLargoRecive)
            mSimbolos.Add("$_IDN_TFL", TipoSimbolo.mtxIndicadorNombreCopy)
            mSimbolos.Add("$_FRM_INI", TipoSimbolo.mtxInicioFRM)
            mSimbolos.Add("$_FRM_FIN", TipoSimbolo.mtxFinFRM)
            mSimbolos.Add("$_HST_INI", TipoSimbolo.mtxInicioHST)
            mSimbolos.Add("$_HST_FIN", TipoSimbolo.mtxFinHST)
            mSimbolos.Add("$_FLD_INI", TipoSimbolo.mtxInicioFLD)
            mSimbolos.Add("$_FLD_FIN", TipoSimbolo.mtxFinFLD)
            mSimbolos.Add("$_SRV_INI", TipoSimbolo.mtxInicioSRV)
            mSimbolos.Add("$_SRV_FIN", TipoSimbolo.mtxFinSRV)
            mSimbolos.Add("$_REQ_INI", TipoSimbolo.mtxInicioREQ)
            mSimbolos.Add("$_REQ_FIN", TipoSimbolo.mtxFinREQ)
            mSimbolos.Add("$_TRN_INI", TipoSimbolo.mtxInicioTRN)
            mSimbolos.Add("$_TRN_FIN", TipoSimbolo.mtxFinTRN)
            mSimbolos.Add("$_IDX_INI", TipoSimbolo.mtxInicioIDX)
            mSimbolos.Add("$_IDX_FIN", TipoSimbolo.mtxFinIDX)
            mSimbolos.Add("$_PT_INI", TipoSimbolo.mtxInicioPT)
            mSimbolos.Add("$_PT_FIN", TipoSimbolo.mtxFinPT)
            mSimbolos.Add("$_TX_INI", TipoSimbolo.mtxInicioTX)
            mSimbolos.Add("$_TX_FIN", TipoSimbolo.mtxFinTX)
            mSimbolos.Add("$_XT_INI", TipoSimbolo.mtxInicioXT)
            mSimbolos.Add("$_XT_FIN", TipoSimbolo.mtxFinXT)
            mSimbolos.Add("$_TP_INI", TipoSimbolo.mtxInicioTP)
            mSimbolos.Add("$_TP_FIN", TipoSimbolo.mtxFinTP)
            mSimbolos.Add("$_NOM", TipoSimbolo.mtxNombreFRM)
            mSimbolos.Add("$_SIS", TipoSimbolo.mtxSistemaFRM)
            mSimbolos.Add("$_DEF", TipoSimbolo.mtxDEF)
            mSimbolos.Add("$_FRM", TipoSimbolo.mtxFRM)
            mSimbolos.Add("$_FMT", TipoSimbolo.mtxFMT)
            mSimbolos.Add("$_INM", TipoSimbolo.mtxINM)
            mSimbolos.Add("$_CMN", TipoSimbolo.mtxCMN)
            mSimbolos.Add("$_CPP", TipoSimbolo.mtxCPP)
            mSimbolos.Add("$_SPP", TipoSimbolo.mtxSPP)
            mSimbolos.Add("$_PGM", TipoSimbolo.mtxPGM)
            mSimbolos.Add("$_SUB", TipoSimbolo.mtxSUB)
            mSimbolos.Add("$_INS", TipoSimbolo.mtxINS)
            mSimbolos.Add("$_FIN", TipoSimbolo.mtxFIN)
            mSimbolos.Add("$_FOU", TipoSimbolo.mtxFOU)
            mSimbolos.Add("$_CMT", TipoSimbolo.mtxCMT)
            mSimbolos.Add("$_IDD", TipoSimbolo.mtxIDD)
            mSimbolos.Add("$_CNF", TipoSimbolo.mtxCNF)
            mSimbolos.Add("=", TipoSimbolo.mtxSignoIgual)
        End Sub
        Public Function Find(ByVal _sub As String) As TipoSimbolo
            _sub = _sub.ToUpper()
            If mSimbolos.Contains(_sub) Then
                Return mSimbolos(_sub)
            Else
                Return TipoSimbolo.Indefinido
            End If
        End Function
    End Class
    Public Class Simbolo
        Private mType As TipoSimbolo
        Private mIdent As String
        Public ReadOnly Property TipoIdentificador
            Get
                Return mType
            End Get
        End Property
        Public ReadOnly Property Identificador
            Get
                Return mIdent
            End Get
        End Property
        Public Sub New()
            mType = TipoSimbolo.Indefinido
        End Sub
        Public Sub New(ByVal ident As String, ByVal type As TipoSimbolo)
            MyBase.New()
            mIdent = ident
            mType = type
        End Sub
    End Class
End Namespace
