Public Class Professor
    Inherits Pessoa
    Sub professor(ByVal cpf As String, ByVal nome As String, ByVal titulo As String)
        Me.pcpf = cpf
        Me.pnome = nome
        Me.titulo = titulo

    End Sub

    Property titulo As String
        Get
            Return titulo
        End Get
        Set(ByVal valor As String)
            Me.titulo = valor
        End Set
    End Property
End Class
