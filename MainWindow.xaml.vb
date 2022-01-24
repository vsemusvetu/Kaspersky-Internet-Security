Class MainWindow
    Private Sub btn_Click(sender As Object, e As RoutedEventArgs) Handles btn.Click
        MessageBox.Show("Button 1 is Clicked")
    End Sub

    Private Sub btn1_Click(sender As Object, e As RoutedEventArgs) Handles btn1.Click
        MessageBox.Show("Button 2 is Clicked")
    End Sub

    Private Sub btn2_Click(sender As Object, e As RoutedEventArgs) Handles btn2.Click
        MessageBox.Show("Button 3 is Clicked")
    End Sub

    Private Sub btn3_Click(sender As Object, e As RoutedEventArgs) Handles btn3.Click
        MessageBox.Show("Button 4 is Clicked")
    End Sub

    Private Sub ListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As TextChangedEventArgs)

    End Sub

    Private Sub ComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub

    Private Sub RichTextBox_TextChanged_1(sender As Object, e As TextChangedEventArgs)

    End Sub

    Private Sub RichTextBox_TextChanged_2(sender As Object, e As TextChangedEventArgs)

    End Sub
End Class
