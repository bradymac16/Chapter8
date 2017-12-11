Public Class Seating_Chart

    Private Sub btnDisplayPrice_Click(sender As Object, e As EventArgs) Handles btnDisplayPrice.Click
        Dim intRow, intCol As Integer

        Const intMAX_ROW As Integer = 5
        Const intMAX_COL As Integer = 3

        Dim decPrice(,) = {{450D, 450D, 450D, 450D},
                            {425D, 425D, 425D, 425D},
                            {400D, 400D, 400D, 400D},
                            {375D, 375D, 375D, 375D},
                            {375D, 375D, 375D, 375D},
                            {350D, 350D, 350D, 350D}}
        Try
            intRow = CInt(txtRow.Text)
            intRow = CInt(txtCol.Text)

            If intRow >= 0 And intRow <= intMAX_ROW Then
                If intCol >= 0 And intCol <= intMAX_COL Then
                    lblPrice.Text = decPrice(intRow, intCol).Tostring("c")
                Else
                    MessageBox.Show("Row must be 0 through" & intMAX_COL.ToString)
                End If
            Else
                MessageBox.Show("Row must be 0 through " & intMAX_ROW.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show("Row and Column must be integers")
        End Try
    End Sub
End Class