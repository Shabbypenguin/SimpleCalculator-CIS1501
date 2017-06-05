Public Class Form1
    Private Sub inputBox1_LostFocus(sender As Object, e As EventArgs) Handles inputBox1.LostFocus
        If Not IsNumeric(inputBox1.Text) Then
            MessageBox.Show("Please enter in a number")
            inputBox1.Text = ""
        Else
            inputBox1.Text = Int(inputBox1.Text)
        End If
    End Sub

    Private Sub inputBox2_LostFocus(sender As Object, e As EventArgs) Handles inputBox2.LostFocus
        If Not IsNumeric(inputBox2.Text) Then
            MessageBox.Show("Please enter in a number")
            inputBox2.Text = ""
        Else
            inputBox2.Text = Int(inputBox2.Text)
        End If
    End Sub

    Private Sub inputBox3_LostFocus(sender As Object, e As EventArgs) Handles inputBox3.LostFocus
        If Not IsNumeric(inputBox3.Text) Then
            MessageBox.Show("Please enter in a number")
            inputBox3.Text = ""
        Else
            inputBox3.Text = Int(inputBox3.Text)
        End If
    End Sub

    Private Sub inputBox4_LostFocus(sender As Object, e As EventArgs) Handles inputBox4.LostFocus
        If Not IsNumeric(inputBox4.Text) Then
            MessageBox.Show("Please enter in a number")
            inputBox4.Text = ""
        Else
            inputBox4.Text = Int(inputBox4.Text)
        End If
    End Sub

    Private Sub inputBox5_LostFocus(sender As Object, e As EventArgs) Handles inputBox5.LostFocus
        If Not IsNumeric(inputBox5.Text) Then
            MessageBox.Show("Please enter in a number")
            inputBox5.Text = ""
        Else
            inputBox5.Text = Int(inputBox5.Text)
        End If
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
