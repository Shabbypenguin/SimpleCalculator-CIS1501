Public Class Form1
    Private Sub inputBox1_TextChanged(sender As Object, e As EventArgs) Handles inputBox1.TextChanged

    End Sub

    Private Sub inputBox2_TextChanged(sender As Object, e As EventArgs) Handles inputBox2.TextChanged

    End Sub

    Private Sub inputBox4_TextChanged(sender As Object, e As EventArgs) Handles inputBox4.TextChanged

    End Sub

    Private Sub inputBox3_TextChanged(sender As Object, e As EventArgs) Handles inputBox3.TextChanged

    End Sub

    Private Sub inputBox5_TextChanged(sender As Object, e As EventArgs) Handles inputBox5.TextChanged

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        inputBox1.Text = ""
        inputBox2.Text = ""
        inputBox3.Text = ""
        inputBox4.Text = ""
        inputBox5.Text = ""
        outputBox.Text = ""
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

    End Sub
End Class
