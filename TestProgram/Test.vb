Public Class Test

    Public Shared Function HowManyEs(input As String) As Integer

        ' Assumes letter e's mean any e regardless of case.

        Dim count As Integer = 0

        For Each item As Char In input.ToLower

            If item = "e" Then

                count += 1

            End If

        Next

        Return count

    End Function ' HowManyEs

    Public Shared Function HowMany1s(input As String) As Integer

        ' Put number in as string to prevent overflow.

        Dim count As Integer = 0

        For Each item As Char In input.ToLower

            If item = "1" Then

                count += 1

            End If

        Next

        Return count

    End Function ' HowMany1s

    Public Shared Function Add(num1 As Integer, num2 As Integer) As Integer

        Return num1 + num2

    End Function ' Add
End Class ' 
