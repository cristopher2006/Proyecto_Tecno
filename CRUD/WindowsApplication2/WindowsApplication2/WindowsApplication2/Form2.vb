Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class crud
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String

    Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New SqlDataAdapter("select *from administrador where id= '" + txtID.Text + " ' ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sentencia = "delete administrador where id = '" + txtID.Text + "'"
        mensaje = "dato eliminado correctamente "
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM administrador", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtID.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sentencia = "update administrador set nombre ='" + txtNombre.Text + "', correo ='" + txtCorreo.Text + "' , pais ='" + txtPais.Text + "', ocupacion ='" + txtOcupacion.Text + "' where id ='" + txtID.Text + "' "
        mensaje = "Dato actualizado correctamente"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM administrador", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtID.Text = ""
        txtNombre.Text = ""
        txtCorreo.Text = ""
        txtPais.Text = ""
        txtOcupacion.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM administrador", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtID.Text = ""
    End Sub

    Private Sub crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentencia = "insert into administrador VALUES('" + txtID.Text + "','" + txtNombre.Text + "','" + txtCorreo.Text + "','" + txtPais.Text + "','" + txtOcupacion.Text + "')"
        mensaje = "Datos insertados correctamente"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM administrador", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        txtID.Text = ""
        txtNombre.Text = ""
        txtCorreo.Text = ""
        txtPais.Text = ""
        txtOcupacion.Text = ""
    End Sub
End Class