Public Class Form1
    'Array of test scores
    Dim testScores = {56, 90, 89, 72, 43, 99, 85, 96, 87, 93, 83, 84, 70, 79, 88, 97, 90, 80, 82, 91}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Shorten this traversal with a loop
        ListBox1.Items.Add(testScores(0))
        ListBox1.Items.Add(testScores(1))
        ListBox1.Items.Add(testScores(2))
        ListBox1.Items.Add(testScores(3))
        ListBox1.Items.Add(testScores(4))
        ListBox1.Items.Add(testScores(5))
        ListBox1.Items.Add(testScores(6))
        ListBox1.Items.Add(testScores(7))
        ListBox1.Items.Add(testScores(8))
        ListBox1.Items.Add(testScores(9))
        ListBox1.Items.Add(testScores(10))
        ListBox1.Items.Add(testScores(11))
        ListBox1.Items.Add(testScores(12))
        ListBox1.Items.Add(testScores(13))
        ListBox1.Items.Add(testScores(14))
        ListBox1.Items.Add(testScores(15))
        ListBox1.Items.Add(testScores(16))
        ListBox1.Items.Add(testScores(17))
        ListBox1.Items.Add(testScores(18))
        ListBox1.Items.Add(testScores(19))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Display only the scores between 80 and 89


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Display the elements located at even indexs (0, 2, 4, etc.)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Display the elements in reverse order (91, 82, 80... and so on)


    End Sub
End Class
