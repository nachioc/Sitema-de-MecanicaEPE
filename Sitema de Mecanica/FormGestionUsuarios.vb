Imports MySql.Data.MySqlClient

Public Class FormGestionUsuarios
    Private usuarioCorreo As String
    Private usuarioTipo As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormGestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        If UsuarioTipoActual <> "Administrador" AndAlso UsuarioTipoActual <> "Gerente" Then
            MessageBox.Show("No tiene permisos para acceder a esta sección.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            If MainMenuInstance Is Nothing OrElse MainMenuInstance.IsDisposed Then
                MainMenuInstance = New MainMenu()
            End If
            MainMenuInstance.Show()
            Return
        End If

        cboTipo.Items.Clear()
        cboTipo.Items.AddRange(New String() {"Vendedor", "Administrador", "Mecánico", "Aseguradora", "Analista", "Gerente"})

        MostrarUsuarios()

        OcultarCampos()
    End Sub

    Private Sub OcultarCampos()
        txtRut.Visible = False
        txtCorreo.Visible = False
        txtContrasena.Visible = False
        cboTipo.Visible = False

        lblRut.Visible = False
        lblCorreo.Visible = False
        lblContrasena.Visible = False
        lblTipo.Visible = False

        btnGuardar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub MostrarCamposIngreso()
        OcultarCampos()
        lblRut.Visible = True
        txtRut.Visible = True
        lblCorreo.Visible = True
        txtCorreo.Visible = True
        lblContrasena.Visible = True
        txtContrasena.Visible = True
        lblTipo.Visible = True
        cboTipo.Visible = True
        btnGuardar.Visible = True
    End Sub

    Private Sub MostrarCamposModificacion()
        OcultarCampos()

        lblRut.Visible = True
        txtRut.Visible = True
        txtRut.ReadOnly = False

        lblCorreo.Visible = True
        txtCorreo.Visible = True

        lblContrasena.Visible = True
        txtContrasena.Visible = True

        lblTipo.Visible = True
        cboTipo.Visible = True

        btnModificar.Visible = True
    End Sub


    Private Sub MostrarCamposEliminacion()
        OcultarCampos()
        lblRut.Visible = True
        txtRut.Visible = True
        btnEliminar.Visible = True
    End Sub
    Private Sub rdbIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIngresarUsuario.CheckedChanged
        If rbtnIngresarUsuario.Checked Then
            MostrarCamposIngreso()
        End If
    End Sub

    Private Sub rdbModificar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnModificarUsuario.CheckedChanged
        If rbtnModificarUsuario.Checked Then
            MostrarCamposModificacion()
        End If
    End Sub

    Private Sub rdbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEliminarUsuario.CheckedChanged
        If rbtnEliminarUsuario.Checked Then
            MostrarCamposEliminacion()
        End If
    End Sub

    Private Sub MostrarUsuarios()
        Using conn As MySqlConnection = ObtenerConexion()
            Dim sql As String = "SELECT Rut, Correo, `Contraseña`, Tipo FROM usuarios"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvUsuarios.DataSource = dt
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Using conn As MySqlConnection = ObtenerConexion()
            Dim sql As String = "SELECT * FROM usuarios WHERE Rut = @rut"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@rut", txtBuscarRut.Text.Trim())

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvUsuarios.DataSource = dt
        End Using
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        MostrarUsuarios()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtRut.Text) OrElse String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse String.IsNullOrWhiteSpace(txtContrasena.Text) OrElse cboTipo.SelectedIndex = -1 Then
            MessageBox.Show("Complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()
            Dim sql As String = "INSERT INTO usuarios (Rut, Correo, `Contraseña`, Tipo) VALUES (@rut, @correo, @pass, @tipo)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@rut", txtRut.Text)
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
            cmd.Parameters.AddWithValue("@pass", txtContrasena.Text)
            cmd.Parameters.AddWithValue("@tipo", cboTipo.SelectedItem.ToString())

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario ingresado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al ingresar usuario: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Debe seleccionar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()

            Dim sql As String =
            "UPDATE usuarios SET 
                Correo=@correo, 
                `Contraseña`=@pass, 
                Tipo=@tipo 
             WHERE Rut=@rut"

            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@rut", txtRut.Text.Trim())
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim())
            cmd.Parameters.AddWithValue("@pass", txtContrasena.Text.Trim())
            cmd.Parameters.AddWithValue("@tipo", cboTipo.SelectedItem.ToString())

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
                LimpiarCampos()

            Catch ex As Exception
                MessageBox.Show("Error al modificar usuario: " & ex.Message)
            End Try

        End Using

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Ingrese el RUT del usuario a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim correoUsuario As String = ""
        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()
            Dim sqlBuscar As String = "SELECT Correo FROM usuarios WHERE Rut=@rut"
            Dim cmdBuscar As New MySqlCommand(sqlBuscar, conn)
            cmdBuscar.Parameters.AddWithValue("@rut", txtRut.Text.Trim())
            Dim reader = cmdBuscar.ExecuteReader()
            If reader.Read() Then
                correoUsuario = reader("Correo").ToString()
            Else
                MessageBox.Show("No se encontró ningún usuario con ese RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                Return
            End If
            reader.Close()
        End Using

        Dim confirmForm As New Form With {
            .Text = "Confirmar eliminación",
            .Size = New Size(400, 200),
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .StartPosition = FormStartPosition.CenterScreen,
            .BackColor = Color.Black,
            .ForeColor = Color.White
        }

        Dim lblMensaje As New Label With {
            .Text = "¿Seguro que desea eliminar al usuario: " & correoUsuario & "?",
            .AutoSize = False,
            .Dock = DockStyle.Top,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Height = 80,
            .ForeColor = Color.White
        }

        Dim btnConfirmar As New Button With {
            .Text = "Eliminar",
            .BackColor = Color.Orange,
            .ForeColor = Color.Black,
            .Width = 100,
            .Height = 30,
            .DialogResult = DialogResult.OK,
            .Top = 100,
            .Left = 90
        }

        Dim btnCancelar As New Button With {
            .Text = "Cancelar",
            .BackColor = Color.Orange,
            .ForeColor = Color.Black,
            .Width = 100,
            .Height = 30,
            .DialogResult = DialogResult.Cancel,
            .Top = 100,
            .Left = 210
        }

        confirmForm.Controls.Add(lblMensaje)
        confirmForm.Controls.Add(btnConfirmar)
        confirmForm.Controls.Add(btnCancelar)

        Dim result = confirmForm.ShowDialog()

        If result = DialogResult.OK Then
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                Dim sql As String = "DELETE FROM usuarios WHERE Rut=@rut"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@rut", txtRut.Text.Trim())
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarUsuarios()
                    LimpiarCampos()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar usuario: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtRut.Clear()
        txtCorreo.Clear()
        txtContrasena.Clear()
        cboTipo.SelectedIndex = -1
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If MainMenuInstance IsNot Nothing AndAlso Not MainMenuInstance.IsDisposed Then
            MainMenuInstance.Show()
        Else
            MainMenuInstance = New MainMenu()
            MainMenuInstance.Show()
        End If
        Me.Close()
    End Sub


    Private Sub Boton_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscar.MouseEnter, btnEliminar.MouseEnter, btnGuardar.MouseEnter, btnModificar.MouseEnter, btnVisualizar.MouseEnter, btnVolver.MouseEnter
        CType(sender, Button).BackColor = Color.Orange
    End Sub

    Private Sub Boton_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave, btnEliminar.MouseLeave, btnGuardar.MouseLeave, btnModificar.MouseLeave, btnVisualizar.MouseLeave, btnVolver.MouseLeave
        CType(sender, Button).BackColor = Color.Black
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)

            txtRut.Text = fila.Cells("Rut").Value.ToString()
            txtCorreo.Text = fila.Cells("Correo").Value.ToString()
            txtContrasena.Text = fila.Cells("Contraseña").Value.ToString()
            cboTipo.Text = fila.Cells("Tipo").Value.ToString()
        End If
    End Sub


End Class
