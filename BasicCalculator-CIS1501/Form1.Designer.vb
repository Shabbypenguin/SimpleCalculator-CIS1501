<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inputBox1 = New System.Windows.Forms.TextBox()
        Me.inputBox2 = New System.Windows.Forms.TextBox()
        Me.inputBox3 = New System.Windows.Forms.TextBox()
        Me.inputBox4 = New System.Windows.Forms.TextBox()
        Me.inputBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.outputBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inputBox1
        '
        Me.inputBox1.Location = New System.Drawing.Point(12, 18)
        Me.inputBox1.Name = "inputBox1"
        Me.inputBox1.Size = New System.Drawing.Size(78, 20)
        Me.inputBox1.TabIndex = 0
        '
        'inputBox2
        '
        Me.inputBox2.Location = New System.Drawing.Point(12, 44)
        Me.inputBox2.Name = "inputBox2"
        Me.inputBox2.Size = New System.Drawing.Size(78, 20)
        Me.inputBox2.TabIndex = 1
        '
        'inputBox3
        '
        Me.inputBox3.Location = New System.Drawing.Point(12, 96)
        Me.inputBox3.Name = "inputBox3"
        Me.inputBox3.Size = New System.Drawing.Size(78, 20)
        Me.inputBox3.TabIndex = 3
        '
        'inputBox4
        '
        Me.inputBox4.Location = New System.Drawing.Point(12, 70)
        Me.inputBox4.Name = "inputBox4"
        Me.inputBox4.Size = New System.Drawing.Size(78, 20)
        Me.inputBox4.TabIndex = 2
        '
        'inputBox5
        '
        Me.inputBox5.Location = New System.Drawing.Point(12, 122)
        Me.inputBox5.Name = "inputBox5"
        Me.inputBox5.Size = New System.Drawing.Size(78, 20)
        Me.inputBox5.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input #1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Input #2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Input #3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Input #5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Input #4"
        '
        'outputBox
        '
        Me.outputBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.outputBox.Location = New System.Drawing.Point(163, 21)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.ReadOnly = True
        Me.outputBox.Size = New System.Drawing.Size(77, 20)
        Me.outputBox.TabIndex = 10
        Me.outputBox.TabStop = False
        Me.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Output"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(12, 156)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(228, 39)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(14, 203)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(110, 35)
        Me.resetButton.TabIndex = 6
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(130, 203)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 35)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(250, 256)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputBox5)
        Me.Controls.Add(Me.inputBox3)
        Me.Controls.Add(Me.inputBox4)
        Me.Controls.Add(Me.inputBox2)
        Me.Controls.Add(Me.inputBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputBox1 As TextBox
    Friend WithEvents inputBox2 As TextBox
    Friend WithEvents inputBox3 As TextBox
    Friend WithEvents inputBox4 As TextBox
    Friend WithEvents inputBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents outputBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
End Class
