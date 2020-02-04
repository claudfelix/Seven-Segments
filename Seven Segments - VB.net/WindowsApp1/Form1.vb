Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 500
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text += 1

        If TextBox1.Text = 1 Then
            Label1.BackColor = Color.Red
            Label2.BackColor = Color.White
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.Red
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 2 Then
            Label1.BackColor = Color.White
            Label2.BackColor = Color.White
            Label3.BackColor = Color.White
            Label4.BackColor = Color.White
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.White
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 3 Then
            Label1.BackColor = Color.White
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.Red
            Label7.BackColor = Color.White
        End If
        If TextBox1.Text = 4 Then
            Label1.BackColor = Color.White
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.White
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 5 Then
            Label1.BackColor = Color.Red
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.White
            Label4.BackColor = Color.White
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.White
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 6 Then
            Label1.BackColor = Color.Red
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.White
            Label6.BackColor = Color.White
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 7 Then
            Label1.BackColor = Color.Red
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.White
            Label6.BackColor = Color.Red
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 8 Then
            Label1.BackColor = Color.White
            Label2.BackColor = Color.White
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.White
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.White
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 9 Then
            Label1.BackColor = Color.Red
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.Red
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text = 10 Then
            Label1.BackColor = Color.Red
            Label2.BackColor = Color.Red
            Label3.BackColor = Color.Red
            Label4.BackColor = Color.Red
            Label5.BackColor = Color.Red
            Label6.BackColor = Color.White
            Label7.BackColor = Color.Red
        End If
        If TextBox1.Text > 10 Then
            TextBox1.Text = 0
        End If
    End Sub
End Class
