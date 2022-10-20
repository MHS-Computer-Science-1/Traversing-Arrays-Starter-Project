Public Class Form1
    'Students
    Dim names = {"Molly", "Micah", "Noah", "Carrie", "Bob", "Thomas", "Claire", "PJ", "Elvis", "Jaxson", "Blair", "Addeline", "Faith", "Hannah", "Michael", "Patty", "Jared", "Hunter", "Tibor", "Bart"}
    'Test 1 Scores
    Dim test1Scores = {86, 90, 89, 72, 43, 99, 85, 96, 87, 93, 83, 84, 50, 79, 88, 97, 90, 80, 82, 91}
    'Test 2 Scores
    Dim test2Scores = {82, 97, 88, 85, 56, 90, 87, 89, 80, 99, 100, 86, 82, 71, 65, 81, 98, 97, 59, 79}

    'These arrays represent students and their scores on 2 tests
    'FOR EXAMPLE: Molly earned 86 on test 1 and 82 on test 2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        'Displays all the scores for Test 1 and Test 2
        'Shorten this traversal with a loop
        ListBox1.Items.Add(names(0) & " scored " & test1Scores(0) & " and " & test2Scores(0))
        ListBox1.Items.Add(names(1) & " scored " & test1Scores(1) & " and " & test2Scores(1))
        ListBox1.Items.Add(names(2) & " scored " & test1Scores(2) & " and " & test2Scores(2))
        ListBox1.Items.Add(names(3) & " scored " & test1Scores(3) & " and " & test2Scores(3))
        ListBox1.Items.Add(names(4) & " scored " & test1Scores(4) & " and " & test2Scores(4))
        ListBox1.Items.Add(names(5) & " scored " & test1Scores(5) & " and " & test2Scores(5))
        ListBox1.Items.Add(names(6) & " scored " & test1Scores(6) & " and " & test2Scores(6))
        ListBox1.Items.Add(names(7) & " scored " & test1Scores(7) & " and " & test2Scores(7))
        ListBox1.Items.Add(names(8) & " scored " & test1Scores(8) & " and " & test2Scores(8))
        ListBox1.Items.Add(names(9) & " scored " & test1Scores(9) & " and " & test2Scores(9))
        ListBox1.Items.Add(names(10) & " scored " & test1Scores(10) & " and " & test2Scores(10))
        ListBox1.Items.Add(names(11) & " scored " & test1Scores(11) & " and " & test2Scores(11))
        ListBox1.Items.Add(names(12) & " scored " & test1Scores(12) & " and " & test2Scores(12))
        ListBox1.Items.Add(names(13) & " scored " & test1Scores(13) & " and " & test2Scores(13))
        ListBox1.Items.Add(names(14) & " scored " & test1Scores(14) & " and " & test2Scores(14))
        ListBox1.Items.Add(names(15) & " scored " & test1Scores(15) & " and " & test2Scores(15))
        ListBox1.Items.Add(names(16) & " scored " & test1Scores(16) & " and " & test2Scores(16))
        ListBox1.Items.Add(names(17) & " scored " & test1Scores(17) & " and " & test2Scores(17))
        ListBox1.Items.Add(names(18) & " scored " & test1Scores(18) & " and " & test2Scores(18))
        ListBox1.Items.Add(names(19) & " scored " & test1Scores(19) & " and " & test2Scores(19))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

        'Test average for the first student. 
        'Modify to display all the averages.
        Dim average As Double
        average = (test1Scores(0) + test2Scores(0)) / 2
        ListBox1.Items.Add(names(0) & " averaged " & average)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

        'Display the averages that are C (70) or lower



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Display the student names in reverse order (Bart, Tibor, Hunter, and so on)


    End Sub
End Class
