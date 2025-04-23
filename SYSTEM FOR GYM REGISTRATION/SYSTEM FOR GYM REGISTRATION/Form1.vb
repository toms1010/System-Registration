Public Class Form1


    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click


        Dim age As Integer


        If Not Integer.TryParse(txtbox_age.Text, age) OrElse age < 18 Then
            MessageBox.Show("Users under 18 are not eligible for gym membership.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return

        End If


        If ListBox1.SelectedItem Is Nothing Then

            MessageBox.Show("Please select a membership option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        End If


        Dim selectedOption As String = ListBox1.SelectedItem.ToString().Trim().Replace(vbCrLf, "")
        Dim membershipFee As Integer = 0


        Select Case selectedOption

            Case "Basic (1000/month)"
                membershipFee = 1000
            Case "Premium (2000/month)"
                membershipFee = 2000
            Case "VIP (2500/month)"
                membershipFee = 2500
            Case Else
                MessageBox.Show("Invalid membership option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

        End Select



        Dim extrasFee As Integer = 0
        If chkTrainer.Checked Then extrasFee += 750
        If chkSauna.Checked Then extrasFee += 500
        If chkDiet.Checked Then extrasFee += 250



        Dim totalFee As Integer = membershipFee + extrasFee



        txtbox_result.Text = $"PHP {totalFee:N2}"
    End Sub





    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)


    End Sub


    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub chkSauna_CheckedChanged(sender As Object, e As EventArgs) Handles chkSauna.CheckedChanged

    End Sub









End Class


