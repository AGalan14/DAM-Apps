Module Functions
    Public Function FormatTelefon(tel As Integer) As String
        If tel.ToString.Length < 9 Then
            Return ""
        Else Return $"{tel.ToString("## ## ## ##")}".TrimStart()
        End If
    End Function

    Public Function GetNifFromComboBoxDisplay(comboBoxDisplay As String) As String
        Dim startIndex As Integer = comboBoxDisplay.IndexOf("(") + 1
        Dim endIndex As Integer = comboBoxDisplay.IndexOf(")")
        If startIndex > 0 And endIndex > startIndex Then
            Return comboBoxDisplay.Substring(startIndex, endIndex - startIndex)
        Else
            Return ""
        End If
    End Function

    Public Function GetProjecteFromComboBox(projecteComboBoxString As String) As String
        If String.IsNullOrEmpty(projecteComboBoxString) Then
            Return Nothing
        End If

        Dim openParenIndex As Integer = projecteComboBoxString.IndexOf("(")
        If openParenIndex = -1 Then
            Return projecteComboBoxString.Trim()
        End If

        Return projecteComboBoxString.Substring(0, openParenIndex).Trim()
    End Function
End Module
