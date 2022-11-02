Imports System.IO
Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim history As String = "history.txt"
        Dim input, output, cmVal As Double
        Dim historyLine As String
        If IsNumeric(txtInput.Text) Then
            input = txtInput.Text
        Else
            MsgBox("please input numbers only!")
            Exit Sub
        End If
        If rbFromCm.Checked Then
            cmVal = input
            historyLine = "Value of " & input & " cm converted to "
        ElseIf rbFromMeters.checked Then
            cmVal = input * 100
            historyLine = "Value of " & input & " m converted to "
        ElseIf rbFromKm.Checked Then
            cmVal = input * 100000
            historyLine = "Value of " & input & " km converted to "
        ElseIf rbFromInches.Checked Then
            cmVal = input * 2.54
            historyLine = "Value of " & input & " inch converted to "
        ElseIf rbFromFeet.Checked Then
            cmVal = input * 30.48
            historyLine = "Value of " & input & " ft converted to "
        ElseIf rbFromYards.Checked Then
            cmVal = input * 91.44
            historyLine = "Value of " & input & " yd converted to "
        Else
            MsgBox("please select input unit of measure")
            Exit Sub
        End If
        If rbToCm.Checked Then
            output = cmVal
            historyLine = historyLine & output & " cm"
        ElseIf rbToM.Checked Then
            output = cmVal / 100
            historyLine = historyLine & output & " m"
        ElseIf rbToKm.Checked Then
            output = cmVal / 100000
            historyLine = historyLine & output & " km"
        ElseIf rbToInches.Checked Then
            output = cmVal / 2.54
            historyLine = historyLine & output & " in"
        ElseIf rbToFeet.Checked Then
            output = cmVal / 30.48
            historyLine = historyLine & output & " ft"
        ElseIf rbToYards.Checked Then
            output = cmVal / 91.44
            historyLine = historyLine & output & " yd"
        Else
            MsgBox("Please select output unit of measure")
            Exit Sub
        End If
        File.AppendAllText("history.txt", historyLine & vbCrLf)
        txtOutput.Text = output
    End Sub
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        listHistory.Items.Clear()
        Dim historyList As String()
        If File.Exists("history.txt") Then
            historyList = File.ReadAllLines("history.txt")
            For Each item In historyList
                If item <> Nothing Then
                    listHistory.Items.Add(item)
                End If
            Next
        End If
    End Sub
End Class
