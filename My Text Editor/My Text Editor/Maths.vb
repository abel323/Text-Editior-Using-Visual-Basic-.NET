Public Class frmMaths
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim n As Single
        n = Val(InputBox("Enter number: "))
        lstNumber.Items.Add(n)
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim i, sum As Single
        sum = 0
        For i = 0 To lstNumber.Items.Count - 1
            sum = sum + lstNumber.Items(i)
        Next
        MsgBox("Sum=" & sum)
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim i, sum, average As Single
        sum = 0
        For i = 0 To lstNumber.Items.Count - 1
            sum = sum + lstNumber.Items(i)
        Next
        average = sum / lstNumber.Items.Count
        MsgBox("Average=" & average)
    End Sub

    Private Sub btnSmallest_Click(sender As Object, e As EventArgs) Handles btnSmallest.Click
        Dim i, min As Single
        min = lstNumber.Items(0)
        For i = 1 To lstNumber.Items.Count - 1
            If min > lstNumber.Items(i) Then
                min = lstNumber.Items(i)
            End If
        Next
        MsgBox("Smallest=" & min)
    End Sub

    Private Sub btnLargest_Click(sender As Object, e As EventArgs) Handles btnLargest.Click
        Dim i, max As Single
        max = lstNumber.Items(0)
        For i = 1 To lstNumber.Items.Count - 1
            If max < lstNumber.Items(i) Then
                max = lstNumber.Items(i)
            End If
        Next
        MsgBox("Smallest=" & max)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class