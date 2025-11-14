Public Class MainMenu

    Public Shared Instance As MainMenu

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Instance = Me

        ' Mostrar mensaje de bienvenida con los datos del usuario logueado
        If Not String.IsNullOrEmpty(UsuarioCorreoActual) AndAlso Not String.IsNullOrEmpty(UsuarioTipoActual) Then
            lblBienvenida.Text = "Bienvenido: " & UsuarioCorreoActual & " (" & UsuarioTipoActual & ")"
        Else
            lblBienvenida.Text = "Bienvenido"
        End If
    End Sub

    ' Efecto hover en los botones
    Private Sub Boton_MouseEnter(sender As Object, e As EventArgs) Handles btnClientes.MouseEnter, btnEmpleados.MouseEnter, btnRepuestos.MouseEnter, btnSalir.MouseEnter, btnVentas.MouseEnter, btnSiniestros.MouseEnter, btnUsuarios.MouseEnter
        CType(sender, Button).BackColor = Color.Orange
    End Sub

    Private Sub Boton_MouseLeave(sender As Object, e As EventArgs) Handles btnClientes.MouseLeave, btnEmpleados.MouseLeave, btnRepuestos.MouseLeave, btnSalir.MouseLeave, btnVentas.MouseLeave, btnSiniestros.MouseLeave, btnUsuarios.MouseLeave
        CType(sender, Button).BackColor = Color.Black
    End Sub

    ' Botón SALIR → cerrar sesión y volver al login
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        CerrarSesion()
        Me.Hide()
        LoginForm.Show()
    End Sub

    ' Botón USUARIOS → abre FormGestionUsuarios solo si el tipo de usuario lo permite
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        If UsuarioTipoActual = "Administrador" Or UsuarioTipoActual = "Gerente" Then
            If FormGestionUsuariosInstance Is Nothing OrElse FormGestionUsuariosInstance.IsDisposed Then
                FormGestionUsuariosInstance = New FormGestionUsuarios()
            End If
            FormGestionUsuariosInstance.Show()
            Me.Hide()
        Else
            MessageBox.Show("No tiene permisos para acceder a la gestión de usuarios.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click
        ' Abrir el formulario de Repuestos
        Dim frm As New FormGestionRepuestos()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim formVentas As New FormVentasRepuestos()
        formVentas.Show()
        Me.Hide()
    End Sub

End Class