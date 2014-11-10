Public Class Form1

    Private Sub btnApproach_Click(sender As Object, e As EventArgs) Handles btnApproach.Click
        Dim strName As String = InputBox("What is your Name?", "Name")
        Dim strQuest As String = InputBox("What is your Quest?", "Quest")
        Dim strRandomQAnswer As String
        Dim intRandomQNumber As Integer

        Dim strRandomQ1 As String = "What is your Favorite Color?"
        Dim strRandomQ2 As String = "What is the flight speed of an Unladen Swallow?"
        Dim strRandomQ3 As String = "What is the Capital of Assyeria?"
        Dim strRandomQ4 As String = "What is the depth of the polar ice cap?"

        Dim strNameAnswer As String = "Caleb Rank"
        Dim strQuestAnswer As String = "I seek the Holy Grail"
        Dim strQuestion1 As String = "Forest Green"
        Dim strQuestion2 As String = "Which Swallow? Afrian or European?"
        Dim strQuestion3 As String = "Nineveh"
        Dim strQuestion4 As String = "3-4 Meters"

        'Typical Random number sequence
        Randomize()
        intRandomQNumber = Int((4 - 1 + 1) * Rnd() + 1)

        If intRandomQNumber = 1 Then
            strRandomQAnswer = InputBox(strRandomQ1, "Random")
        ElseIf intRandomQNumber = 2 Then
            strRandomQAnswer = InputBox(strRandomQ2, "Random")
        ElseIf intRandomQNumber = 3 Then
            strRandomQAnswer = InputBox(strRandomQ3, "Random")
        ElseIf intRandomQNumber = 4 Then
            strRandomQAnswer = InputBox(strRandomQ4, "Random")
        End If

        If intRandomQNumber = 1 Then
            strQuestion1 = InputBox(strRandomQ1, "Random")
        ElseIf intRandomQNumber = 2 Then
            strQuestion2 = InputBox(strRandomQ2, "Random")
        ElseIf intRandomQNumber = 3 Then
            strQuestion3 = InputBox(strRandomQ3, "Random")
        ElseIf intRandomQNumber = 4 Then
            strQuestion4 = InputBox(strRandomQ4, "Random")
        End If

        If (strName = strNameAnswer) And (strQuest = strQuestAnswer) And ((strRandomQ1 = strQuestion1) Or (strRandomQ2 = strQuestion2) Or (strRandomQ3 = strQuestion3) Or (strRandomQ4 = strQuestion4)) Then
            Me.lblFate.Text = "Correct, You May Pass."
        Else
            Me.lblFate.Text = "Incorrect, You Die!!!"
        End If
    End Sub
End Class
