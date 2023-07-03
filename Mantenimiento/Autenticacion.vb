Public Class Autenticacion
    Private Sub Login()
        Dim Val_Contr As String
        Dim Val_Usr As String
        Val_Contr = "12345"
        Val_Usr = "admin"
        If TextBox1.Text = Val_Usr And TextBox2.Text = Val_Contr Then
            Inicio.Show()
            Me.Hide()
        Else
            MsgBox("Contraseña y/o usuario incorrecto")
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        'Caracteres en minúsculas.
        TextBox1.CharacterCasing = CharacterCasing.Lower
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        'Caracteres en minúsculas.
        TextBox2.CharacterCasing = CharacterCasing.Lower
        'Esconder contraseña
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Call Login()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("Ayuda.docx")
    End Sub
End Class
