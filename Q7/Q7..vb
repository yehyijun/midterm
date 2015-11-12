Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = ""
    End Sub
    Dim guess As Integer
    Sub checkans(ans As Integer)
        If guess = 1 And ans = 1 Then
            MessageBox.Show("Peer")
            Label3.Text = "剪刀"
        End If
        If guess = 2 And ans = 2 Then
            MessageBox.Show("Peer")
            Label3.Text = "石頭"
        End If
        If guess = 3 And ans = 3 Then
            MessageBox.Show("Peer")
            Label3.Text = "布"
        End If

        If guess = 1 And ans = 2 Then
            MessageBox.Show("win")
            Label3.Text = "剪刀"
        End If
        If guess = 2 And ans = 3 Then
            MessageBox.Show("win")
            Label3.Text = "石頭"
        End If
        If guess = 3 And ans = 1 Then
            MessageBox.Show("win")
            Label3.Text = "布"
        End If

        If guess = 3 And ans = 2 Then
            MessageBox.Show("Lose")
            Label3.Text = "布"
        End If
        If guess = 2 And ans = 1 Then
            MessageBox.Show("Lose")
            Label3.Text = "石頭"
        End If
        If guess = 1 And ans = 3 Then
            MessageBox.Show("Lose")
            Label3.Text = "剪刀"
        End If


    End Sub


    Private Sub B1_Click(sender As Object, e As EventArgs) _
        Handles B1.Click
        checkans(1)
        Dim R As New Random()
        guess = R.Next(1, 4)
        Label3.Text = guess
        If guess = 1 Then
            Label3.Text = "剪刀"
        End If
        If guess = 2 Then
        End If
        Label3.Text = "石頭"
        If guess = 3 Then
            Label3.Text = "布"

        End If

    End Sub



    Private Sub B2_Click(sender As Object, e As EventArgs) _
        Handles B2.Click
        checkans(2)
        Dim R As New Random()
        guess = R.Next(1, 4)
        Label3.Text = guess
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) _
        Handles B3.Click
        checkans(3)
        Dim R As New Random()
        guess = R.Next(1, 4)
        Label3.Text = guess
    End Sub
End Class


