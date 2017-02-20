Imports System.Data.SqlClient
Public Class Form2
    Dim cn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\bryan\documents\visual studio 2012\Projects\WindowsApplication3\WindowsApplication3\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFirstName.Text <> "" And txtMiddleName.Text <> "" And txtLastName.Text <> "" And txtEmployeeNumber.Text <> "" And CbDepartment.Text <> "" And txtTelephone.Text <> "" And txtExtension.Text <> "" And txtEmailAddress.Text <> "" Then
            cn.Open()
            cmd.CommandText = "insert into info (FirstName,MiddleName,LastName,EmployeeNumber,Department,Telephone,Extension,EmailAddress) values (" & txtFirstName.Text & " , " & txtMiddleName.Text & " , " & txtLastName.Text & " , " & txtEmployeeNumber.Text & " , " & CbDepartment.Text & " , " & txtTelephone.Text & " , " & txtExtension.Text & " , " & txtEmailAddress.Text & " , )"
            cmd.ExecuteNonQuery()
            cn.Close()
            txtFirstName.Text = ""
            txtMiddleName.Text = ""
            txtLastName.Text = ""
            txtEmployeeNumber.Text = ""
            CbDepartment.Text = ""
            txtTelephone.Text = ""
            txtExtension.Text = ""
            txtEmailAddress.Text = ""

        End If

    End Sub
End Class