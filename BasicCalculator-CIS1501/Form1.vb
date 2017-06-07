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
            'we use a variable to condense the code of emptying each text box
            Controls.Item("inputBox" & i).Text = ""
        Next
        outputBox.Text = ""
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim i As Integer
        i = 1
        'I prompt the user the program will close
        MsgBox("This program will close in a few seconds.", MsgBoxStyle.OkOnly)
        Do Until i = 10
            ' I start a loop for 10 "loops" that sleeps for 500 milliseconds
            Threading.Thread.Sleep(500)
            i += 1
        Loop
        'After it finishes looping I exit the program
        Application.Exit()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim i As Integer
        Dim subTotal As Long
        i = 1
        'I check to see if its going addition or multiplication
        If additionRadioButton.Checked Then
            'I start my loop to cycle through the input boxes
            Do While i < 6
                'I check if the input box is empty, if it is then add 1 to the loop counter so it gets skipped
                If (Controls("inputBox" & i).Text) = String.Empty Then
                    'If we try to add/multiply the empty box it causes a crash so we skip it
                    i += 1
                Else
                    'this adds inputbox# to the subtotal. by using a variable we can condense the code instead of having 5 lines of each textbox being added
                    subTotal += (Controls("inputBox" & i).Text)
                    i += 1
                End If
            Loop
        ElseIf multiplcationRadioButton.Checked Then
            subTotal = 1
            Do While i < 6
                If (Controls("inputBox" & i).Text) = String.Empty Then
                    i += 1
                Else
                    subTotal *= (Controls("inputBox" & i).Text)
                    i += 1
                End If
            Loop
        End If
        'now that the loop has run we output the total to the output box
        outputBox.Text = subTotal.ToString
    End Sub
End Class
