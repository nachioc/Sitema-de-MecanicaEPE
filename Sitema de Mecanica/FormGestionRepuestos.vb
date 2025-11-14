Imports MySql.Data.MySqlClient

Public Class FormGestionRepuestos

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FormGestionRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        MostrarPanel(pnlBuscar)

        MostrarRepuestos()
    End Sub

    Private Sub MostrarPanel(panelActivo As Panel)

        pnlBuscar.Visible = False
        pnlAgregar.Visible = False
        pnlModificarEliminar.Visible = False


        panelActivo.Visible = True
        panelActivo.BringToFront()
    End Sub

    Private Sub btnBuscarPanel_Click(sender As Object, e As EventArgs) Handles btnBuscarPanel.Click
        MostrarPanel(pnlBuscar)
    End Sub

    Private Sub btnAgregarPanel_Click(sender As Object, e As EventArgs) Handles btnAgregarPanel.Click
        MostrarPanel(pnlAgregar)
    End Sub

    Private Sub btnModificarPanel_Click(sender As Object, e As EventArgs) Handles btnModificarPanel.Click
        MostrarPanel(pnlModificarEliminar)
    End Sub

    Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscarPanel.MouseEnter, btnAgregarPanel.MouseEnter, btnModificarPanel.MouseEnter
        CType(sender, Button).BackColor = Color.Orange
    End Sub
    Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscarPanel.MouseLeave, btnAgregarPanel.MouseLeave, btnModificarPanel.MouseLeave
        CType(sender, Button).BackColor = Color.Black
    End Sub

    Private Sub MostrarRepuestos()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim sql As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvBuscar.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar repuestos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        MostrarRepuestos()
        MostrarPanel(pnlBuscar)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim sql As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos WHERE RepuestoID = @id OR NombreRepuesto LIKE @nombre"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim idVal As Integer
                If Integer.TryParse(txtBuscar.Text.Trim(), idVal) Then
                    cmd.Parameters.AddWithValue("@id", idVal)
                Else
                    cmd.Parameters.AddWithValue("@id", DBNull.Value)
                End If
                cmd.Parameters.AddWithValue("@nombre", "%" & txtBuscar.Text.Trim() & "%")

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvBuscar.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error en búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvBuscar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscar.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvBuscar.Rows(e.RowIndex)
        txtIDModificar.Text = row.Cells("RepuestoID").Value.ToString()
        txtNombreModificar.Text = row.Cells("NombreRepuesto").Value.ToString()
        txtCantidadModificar.Text = row.Cells("CantidadStock").Value.ToString()
        txtPrecioModificar.Text = row.Cells("PrecioUnitario").Value.ToString()
        txtProveedorModificar.Text = row.Cells("Proveedor").Value.ToString()
        MostrarPanel(pnlModificarEliminar)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If String.IsNullOrWhiteSpace(txtNombreAgregar.Text) OrElse String.IsNullOrWhiteSpace(txtCantidadAgregar.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioAgregar.Text) OrElse String.IsNullOrWhiteSpace(txtProveedorAgregar.Text) Then
            MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cantidad As Integer
        Dim precio As Decimal
        If Not Integer.TryParse(txtCantidadAgregar.Text.Trim(), cantidad) Then
            MessageBox.Show("Cantidad debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Decimal.TryParse(txtPrecioAgregar.Text.Trim(), precio) Then
            MessageBox.Show("Precio debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                Dim sql As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@nombre, @cantidad, @precio, @proveedor)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nombre", txtNombreAgregar.Text.Trim())
                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@proveedor", txtProveedorAgregar.Text.Trim())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Repuesto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarAgregar()
                MostrarRepuestos()
                MostrarPanel(pnlBuscar)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarAgregar()
        txtNombreAgregar.Clear()
        txtCantidadAgregar.Clear()
        txtPrecioAgregar.Clear()
        txtProveedorAgregar.Clear()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrWhiteSpace(txtIDModificar.Text) Then
            MessageBox.Show("Ingrese ID a modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer
        If Not Integer.TryParse(txtIDModificar.Text.Trim(), id) Then
            MessageBox.Show("ID inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                Dim sel As New MySqlCommand("SELECT NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos WHERE RepuestoID=@id", conn)
                sel.Parameters.AddWithValue("@id", id)
                Dim reader As MySqlDataReader = sel.ExecuteReader()
                If Not reader.Read() Then
                    MessageBox.Show("No se encontró el repuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reader.Close()
                    Return
                End If
                Dim nombreActual = reader("NombreRepuesto").ToString()
                Dim cantidadActual = Convert.ToInt32(reader("CantidadStock"))
                Dim precioActual = Convert.ToDecimal(reader("PrecioUnitario"))
                Dim proveedorActual = reader("Proveedor").ToString()
                reader.Close()

                Dim nuevoNombre = If(String.IsNullOrWhiteSpace(txtNombreModificar.Text), nombreActual, txtNombreModificar.Text.Trim())
                Dim nuevoCantidad As Integer = cantidadActual
                Dim nuevoPrecio As Decimal = precioActual
                Dim nuevoProveedor = If(String.IsNullOrWhiteSpace(txtProveedorModificar.Text), proveedorActual, txtProveedorModificar.Text.Trim())

                If Not String.IsNullOrWhiteSpace(txtCantidadModificar.Text) Then
                    Integer.TryParse(txtCantidadModificar.Text.Trim(), nuevoCantidad)
                End If
                If Not String.IsNullOrWhiteSpace(txtPrecioModificar.Text) Then
                    Decimal.TryParse(txtPrecioModificar.Text.Trim(), nuevoPrecio)
                End If

                Dim upd As New MySqlCommand("UPDATE repuestos SET NombreRepuesto=@nombre, CantidadStock=@cantidad, PrecioUnitario=@precio, Proveedor=@proveedor WHERE RepuestoID=@id", conn)
                upd.Parameters.AddWithValue("@nombre", nuevoNombre)
                upd.Parameters.AddWithValue("@cantidad", nuevoCantidad)
                upd.Parameters.AddWithValue("@precio", nuevoPrecio)
                upd.Parameters.AddWithValue("@proveedor", nuevoProveedor)
                upd.Parameters.AddWithValue("@id", id)

                upd.ExecuteNonQuery()
                MessageBox.Show("Repuesto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarRepuestos()
                MostrarPanel(pnlBuscar)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIDModificar.Text) Then
            MessageBox.Show("Ingrese ID a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer
        If Not Integer.TryParse(txtIDModificar.Text.Trim(), id) Then
            MessageBox.Show("ID inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nombre As String = ""
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                Dim q As New MySqlCommand("SELECT NombreRepuesto FROM repuestos WHERE RepuestoID=@id", conn)
                q.Parameters.AddWithValue("@id", id)
                Dim r As MySqlDataReader = q.ExecuteReader()
                If r.Read() Then
                    nombre = r("NombreRepuesto").ToString()
                End If
                r.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error buscando repuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim confirmForm As New Form With {
            .Text = "Confirmar eliminación",
            .Size = New Size(420, 180),
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .StartPosition = FormStartPosition.CenterScreen,
            .BackColor = Color.Black
        }

        Dim lbl As New Label With {
            .Text = $"¿Eliminar repuesto: {nombre} (ID {id})?",
            .ForeColor = Color.White,
            .AutoSize = False,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Top,
            .Height = 60
        }

        Dim btnOk As New Button With {
            .Text = "Eliminar",
            .BackColor = Color.Orange,
            .ForeColor = Color.Black,
            .DialogResult = DialogResult.OK,
            .Width = 120,
            .Height = 32,
            .Top = 80,
            .Left = 80
        }

        Dim btnCancel As New Button With {
            .Text = "Cancelar",
            .BackColor = Color.Orange,
            .ForeColor = Color.Black,
            .DialogResult = DialogResult.Cancel,
            .Width = 120,
            .Height = 32,
            .Top = 80,
            .Left = 220
        }

        confirmForm.Controls.Add(lbl)
        confirmForm.Controls.Add(btnOk)
        confirmForm.Controls.Add(btnCancel)

        If confirmForm.ShowDialog() = DialogResult.OK Then
            Try
                Using conn As MySqlConnection = ObtenerConexion()
                    conn.Open()
                    Dim del As New MySqlCommand("DELETE FROM repuestos WHERE RepuestoID=@id", conn)
                    del.Parameters.AddWithValue("@id", id)
                    del.ExecuteNonQuery()
                    MessageBox.Show("Repuesto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarRepuestos()
                    MostrarPanel(pnlBuscar)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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

    Private Sub Boton_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscar.MouseEnter, btnVisualizar.MouseEnter, btnAgregar.MouseEnter, btnModificar.MouseEnter, btnEliminar.MouseEnter, btnVolver.MouseEnter
        CType(sender, Button).BackColor = Color.Orange
    End Sub
    Private Sub Boton_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave, btnVisualizar.MouseLeave, btnAgregar.MouseLeave, btnModificar.MouseLeave, btnEliminar.MouseLeave, btnVolver.MouseLeave
        CType(sender, Button).BackColor = Color.Black
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class