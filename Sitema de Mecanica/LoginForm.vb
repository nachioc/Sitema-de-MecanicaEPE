Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private connectionString As String = "server=localhost; user id=root; password=; database=taller;"


    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Debe ingresar correo y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = ObtenerConexion()
            Try
                conn.Open()


                Dim sql As String = "SELECT Correo, `Contraseña`, Tipo FROM usuarios WHERE Correo=@email AND `Contraseña`=@password"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then

                    UsuarioCorreoActual = reader("Correo").ToString()
                    UsuarioTipoActual = reader("Tipo").ToString()

                    If MainMenuInstance Is Nothing OrElse MainMenuInstance.IsDisposed Then
                        MainMenuInstance = New MainMenu()
                    End If

                    MainMenuInstance.Show()
                    Me.Hide()

                    If MainMenuInstance.lblBienvenida IsNot Nothing Then
                        MainMenuInstance.lblBienvenida.Text = "Bienvenido: " & UsuarioCorreoActual & " (" & UsuarioTipoActual & ")"
                    End If
                Else
                    MessageBox.Show("Correo o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If



            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class
