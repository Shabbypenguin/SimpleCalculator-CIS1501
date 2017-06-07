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
        For i As Long = 1 To 5
            Controls.Item("inputBox" & i).Text = ""
        Next
        outputBox.Text = ""
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim i As Integer
        i = 1
        MsgBox("This program will close in a few seconds.", MsgBoxStyle.OkOnly)
        Do Until i = 10
            Threading.Thread.Sleep(500)
            i += 1
        Loop
        Application.Exit()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim i As Integer
        Dim subTotal As Integer
        i = 1
        If additionRadioButton.Checked Then
            Do While i < 6
                subTotal += (Controls("inputBox" & i).Text)
                i += 1
            Loop
        ElseIf multiplcationRadioButton.Checked Then
            subTotal = 1
            Do While i < 6
                subTotal *= (Controls("inputBox" & i).Text)
                i += 1
            Loop
        End If
        outputBox.Text = subTotal.ToString
    End Sub
End Class
