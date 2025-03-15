Public Class Form1
    Public Property From2 As Object

    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DatabaseDataSet.Login)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String

        Username = TextBox1.Text
        Password = TextBox2.Text

        If Me.LoginTableAdapter.LoginQuery(Username, Password) Then
            MsgBox("LOGIN OK")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("INCRECT USERNAME & PASSWORD")
            Me.Close()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
