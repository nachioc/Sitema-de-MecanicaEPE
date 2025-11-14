Imports MySql.Data.MySqlClient

Public Class FormHistorialVentas

    Private Sub FormHistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        dtpDesde.Format = DateTimePickerFormat.Short
        dtpHasta.Format = DateTimePickerFormat.Short
        dtpHasta.Value = DateTime.Now.Date
        dtpDesde.Value = DateTime.Now.Date.AddMonths(-1)

        chkFiltrarFecha.Checked = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False

        CargarHistorialCompleto()
    End Sub

    Private Sub CargarHistorialCompleto()
        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()
            Dim sql As String = "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total 
                                 FROM ventasrepuestos 
                                 ORDER BY FechaVenta DESC"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvHistorial.DataSource = dt
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                Dim sql As String = "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total FROM ventasrepuestos WHERE 1=1"
                Dim cmd As New MySqlCommand()
                cmd.Connection = conn

                If txtRut.Text.Trim() <> "" Then
                    sql &= " AND Cliente LIKE @rut"
                    cmd.Parameters.AddWithValue("@rut", "%" & txtRut.Text.Trim() & "%")
                End If

                If chkFiltrarFecha.Checked Then
                    sql &= " AND FechaVenta BETWEEN @desde AND @hasta"

                    cmd.Parameters.Add("@desde", MySqlDbType.Date).Value = dtpDesde.Value.Date
                    cmd.Parameters.Add("@hasta", MySqlDbType.Date).Value = dtpHasta.Value.Date
                End If

                sql &= " ORDER BY FechaVenta DESC"
                cmd.CommandText = sql

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvHistorial.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al filtrar historial: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        txtRut.Clear()
        chkFiltrarFecha.Checked = False
        CargarHistorialCompleto()
    End Sub

    Private Sub chkFiltrarFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrarFecha.CheckedChanged
        dtpDesde.Enabled = chkFiltrarFecha.Checked
        dtpHasta.Enabled = chkFiltrarFecha.Checked
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If FormVentasRepuestos.Instance IsNot Nothing AndAlso Not FormVentasRepuestos.Instance.IsDisposed Then
            FormVentasRepuestos.Instance.Show()
        Else
            Dim nuevoForm As New FormVentasRepuestos()
            nuevoForm.Show()
        End If

        Me.Close()
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

    End Sub
End Class
