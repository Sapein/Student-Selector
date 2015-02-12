Public Class frmMain
    'This program is to allow teachers to Select Students Randomly
    Dim studentNames(20) As String 'This Array holds the names of the students, I have it as 20 by default.
    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        End 'Ends the Program
    End Sub

    Private Sub mnuModeTextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModeTextFile.Click
        'Checks to see what mode is active In this case Text Mode
        mnuModeDirectInput.Checked = False
        mnuModeTextFile.Checked = True
        btnInputNames.Hide()
        btnSelectFile.Show()
    End Sub

    Private Sub mnuModeDirectInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModeDirectInput.Click
        'Checks to see what mode is active In this case Text Mode
        mnuModeDirectInput.Checked = True
        mnuModeTextFile.Checked = False
        btnSelectFile.Hide()
        btnInputNames.Show()
        btnInputNames.Location = New Point(205, 31)
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        If mnuModeTextFile.Checked = True Then
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog1.FileName)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        Dim currentField As String
                        Dim i As Integer = 0
                        For Each currentField In currentRow
                            If i = studentNames.GetLength(0) Then
                                Exit For
                            End If
                            studentNames(i) = currentField
                            i = i + 1
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    End Try
                End While
            End Using
            Dim y As Integer
            y = randomizee()
            MessageBox.Show(studentNames(y))
            lblOutput.Text = studentNames(y)
        Else
            Dim y As Integer
            y = randomizee()
            MessageBox.Show(studentNames(y))
            lblOutput.Text = studentNames(y)
        End If
    End Sub

    Private Sub btnSelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFile.Click
        OpenFileDialog1.ShowDialog()
        Dim studentAmount As Integer
        studentAmount = CInt(InputBox("Please Enter the Student Amount Below"))
        ReDim studentNames(studentAmount)
    End Sub

    Private Function randomizee()
        Randomize()
        Dim randomSelection
        randomSelection = CInt(Int(((studentNames.GetLength(0)) * Rnd()) + 0))
        Return randomSelection
    End Function

    Private Sub btnInputNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputNames.Click
        Dim studentAmount As Integer
        studentAmount = CInt(InputBox("Please Enter the Student Amount Below"))
        ReDim studentNames(studentAmount)
        Dim i As Integer = 0
        While i < studentNames.GetLength(0)
            Dim names As String
            names = InputBox("Please enter a Student Name Below")
            studentNames(i) = names
            i = i + 1
        End While
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim NewAbout As New About
        NewAbout.Show()
    End Sub

End Class
