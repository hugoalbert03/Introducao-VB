Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Aluno
        a.Aluno("Juliana", "11.111-1", "111.111.111-11")
        txtNomeProf.Text = a.pnome
        txtTitulo.Text = a.prgm
    End Sub

    Private Sub btnProf_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Professor
        p.Professor("222.222.222-22", "Pedro", "Mestre")
        txtNomeAluno.Text = a.pnome
        txtRgm.Text = a.prgm
    End Sub
End Class
