Public Class Form1
    Private Sub total1stSem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total1stSem.Click
        Dim total As Decimal = 0
        Dim subjects As TextBox() = {subj1, subj2, subj3, subj4, subj5, subj6, subj7, subj8}
        Dim totalPossibleScore As Decimal = 100 * subjects.Length

        For Each subj In subjects
            Dim value As Decimal
            If Decimal.TryParse(subj.Text, value) Then
                total += value
            Else
                MessageBox.Show("Invalid input in " & subj.Name & ". Please enter a valid number.")
                Return
            End If
        Next

        Dim percentage As Decimal = (total / totalPossibleScore) * 100
        firstTotal.Text = percentage.ToString("F2")
    End Sub

    Private Sub total2ndSem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total2ndSem.Click
        Dim total As Decimal = 0
        Dim subjects As TextBox() = {subj9, subj10, subj11, subj12, subj13, subj14, subj15, subj16}
        Dim totalPossibleScore As Decimal = 100 * subjects.Length

        For Each subj In subjects
            Dim value As Decimal
            If Decimal.TryParse(subj.Text, value) Then
                total += value
            Else
                MessageBox.Show("Invalid input in " & subj.Name & ". Please enter a valid number.")
                Return
            End If
        Next

        Dim percentage As Decimal = (total / totalPossibleScore) * 100
        secondTotal.Text = percentage.ToString("F2")
    End Sub

    Private Sub finalGradeTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finalGradeTotal.Click
        If String.IsNullOrEmpty(firstTotal.Text) Or String.IsNullOrEmpty(secondTotal.Text) Then
            MessageBox.Show("Make sure fill calculate 1st sem and 2nd sem first.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim firstTotalValue As Decimal = Decimal.Parse(firstTotal.Text)
        Dim secondTotalValue As Decimal = Decimal.Parse(secondTotal.Text)

        Dim finalgrade As Decimal = (firstTotalValue + secondTotalValue) / 2
        finalTotal.Text = finalgrade.ToString("F2")

        If finalgrade >= 97.5 Then
            remarksDisplay.Text &= " WITH HIGHEST HONORS"
        ElseIf finalgrade >= 94.5 Then
            remarksDisplay.Text &= " WITH HIGH HONORS"
        ElseIf finalgrade >= 89.5 Then
            remarksDisplay.Text &= " WITH HONORS"
        End If
    End Sub
End Class
