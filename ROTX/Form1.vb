Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Function includez(ByVal chrx, ByVal charset) As Boolean
        Dim j As Integer = 0
        While j < Len(charset)
            If chrx = charset(j) Then Return True
            j += 1
        End While
        Return False
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'directly change textbox characters
        Dim rot_charset As String = TextBox2.Text
        Dim tekst As String = TextBox1.Text
        Dim tekst2 As String = ""
        Dim i As Integer = 0
        For i = 0 To Len(tekst) - 1
            'resize
            'save file
            'exit
            'checkmark validation
            'length of strings
            If includez(tekst(i), rot_charset) Then
                tekst2 += rot_charset((rot_charset.IndexOf(tekst(i)) + Len(rot_charset) / 2) Mod Len(rot_charset))
            Else
                tekst2 += tekst(i)
            End If
        Next
        TextBox1.Text = tekst2
        'set cursor to current
        'real time encoding 
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'StatusStrip1.Text = "Size: " & CStr(Me.Width) & "x" & CStr(Me.Height)
        Me.TextBox1.Height = Me.Height - 198
        'statusbar
        Me.TextBox1.Width = Me.Width - 40
        Me.TextBox2.Width = Me.Width - 40
        Me.Button1.Width = Me.Width - 40
        'Me.TextBox1.Width = Me.Height - 40
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class
