'Bri Ray 4/5/16

Public Class Form1

    'when the user presses "Input Numbers" button, user inputs value between 1 and 99
    Private Sub btnInputNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputNumbers.Click
        Dim inputArray(0) As String
        Dim end_compare As Boolean = False   'stops the loop that compares the current input value with prior input values


        For i As Integer = 0 To 99    'after 99 entries, there would have to be a duplicate between 1 and 99
            If end_compare = False Then
                inputArray(i) = InputBox("input a number between 1 and 99", "Duplicate Values")

                If i > 0 Then
                    For compare As Integer = 0 To i - 1 'this loop allows a comparison of current value with all prior values
                        If inputArray(i) = inputArray(compare) Then
                            Me.lblAnswer.Text = "Duplicate after " & inputArray.Length - 1 & " numbers."
                            end_compare = True
                            Exit For
                        End If
                    Next
                End If
                If end_compare = False Then 'if a duplicate value is found, then that duplicate wouldn't be added to the listbox
                    Me.listBox.Items.Add(inputArray(i))
                End If

                ReDim Preserve inputArray(i + 1)
            End If
        Next

    End Sub
End Class
