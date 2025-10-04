Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonTampilkan.Click
        Dim nama As String = TextNama.Text
        Dim prodi As String = TextProdi.Text
        Dim kampus As String = TextNamaKampus.Text
        Dim hobi As String = TextHobi.Text

        Dim hasil As String = "Halo, nama saya adalah " & nama & vbCrLf &
                              "Saya kuliah pada jurusan " & prodi & " di " & kampus & vbCrLf &
                              "Saya memiliki hobi " & hobi

        LabelHasil.Text = hasil
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
