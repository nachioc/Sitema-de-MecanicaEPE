Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' 🔹 Cadena de conexión a tu base de datos local de XAMPP
    Private connectionString As String = "server=localhost; user id=root; password=; database=taller;"


    Public Sub New()
        ' Esta llamada es obligatoria para el diseñador
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validar campos
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Debe ingresar correo y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = ObtenerConexion()
            Try
                conn.Open()

                ' Buscar usuario y tipo
                Dim sql As String = "SELECT Correo, `Contraseña`, Tipo FROM usuarios WHERE Correo=@email AND `Contraseña`=@password"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Guardar datos globales
                    UsuarioCorreoActual = reader("Correo").ToString()
                    UsuarioTipoActual = reader("Tipo").ToString()

                    ' Crear o reutilizar menú
                    If MainMenuInstance Is Nothing OrElse MainMenuInstance.IsDisposed Then
                        MainMenuInstance = New MainMenu()
                    End If

                    ' Mostrar menú
                    MainMenuInstance.Show()
                    Me.Hide()

                    ' ✅ Mostrar bienvenida ahora que el formulario ya está cargado
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

End Class
