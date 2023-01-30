

Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form1
    Public conexion As SqlConnection = New SqlConnection(My.Settings.conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Function verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fn = crud
        Dim verificar As String = "update Lolin set roll=roll where usuario = '" + nombre_txt.Text + "' and contraseña = '" + contraseño_txt.Text + "' and roll = 'Administrador'"
        Dim verificar1 As String = "update Lolin set roll=roll where usuario = '" + nombre_txt.Text + "' and contraseña = '" + contraseño_txt.Text + "' and roll = 'Cliente'"
        Dim verificar2 As String = "update Lolin set roll=roll where usuario = '" + nombre_txt.Text + "' and contraseña = '" + contraseño_txt.Text + "' and roll = 'secretaria'"
        If verificacion(verificar) Then
            MessageBox.Show("usuario correcto ")
            MessageBox.Show("Bienvenido Administrador ")
            crud.Show()
            Me.Hide()
        Else

        End If
        If verificacion(verificar1) Then
            MessageBox.Show("usuario correcto ")
            MessageBox.Show("Bienvenido Cliente ")
            crud.Show()
            Me.Hide()
            fn.Button1.Visible = False
            fn.Button3.Visible = False
            fn.Button4.Visible = False

        Else

        End If
        If verificacion(verificar2) Then
            MessageBox.Show("usuario correcto ")
            MessageBox.Show("Bienvenido Secretaria ")
            crud.Show()
            Me.Hide()
            fn.Button4.Visible = False
            fn.Button3.Visible = False
        Else

        End If
        nombre_txt.Text = ""
        contraseño_txt.Text = ""
    End Sub
End Class
