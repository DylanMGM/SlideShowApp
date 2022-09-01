Class MainWindow

    Dim index As Integer = 0
    Dim slideImages As New SlideImages

    Dim txt1 As String = "Come to the Flizims Resort on Mars. New rocket technologies allow for faster travel then ever. Current transit is only 3 days from Earth."
    Dim txt2 As String = "Our resorts allow you to escape the hustle and bustle of universal life. Especially if you live in a planet infested by Protogen carrying cats."
    Dim txt3 As String = "Newly terraformed areas have plenty of retaurants so you don't have to cook. These areas also offer facillities such as skateparks and are totally free of protogen infected zombies."

    Sub New()

        InitializeComponent()
        slideImages.AddImage("Mars_Landing.jpg")
        slideImages.AddImage("Mars_Resort.jpg")
        slideImages.AddImage("Terraformed_Mars.jpg")

        imgSlide.Source = New BitmapImage(New Uri(slideImages.imgList(0), UriKind.Relative))

        txtInfo.Text = txt1

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As RoutedEventArgs) Handles btnLeft.Click

        If index > 0 Then
            index -= 1
            imgSlide.Source = New BitmapImage(New Uri(slideImages.imgList(index), UriKind.Relative))

        End If

        If index = 0 Then
            txtInfo.Text = txt1
        End If

        If index = 1 Then
            txtInfo.Text = txt2
        End If

        If index = 2 Then
            txtInfo.Text = txt3
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As RoutedEventArgs) Handles btnRight.Click

        If index < slideImages.imgList.Count - 1 Then
            index += 1
            imgSlide.Source = New BitmapImage(New Uri(slideImages.imgList(index), UriKind.Relative))
        End If

        If index = 0 Then
            txtInfo.Text = txt1
        End If

        If index = 1 Then
            txtInfo.Text = txt2
        End If

        If index = 2 Then
            txtInfo.Text = txt3
        End If

    End Sub
End Class

Class SlideImages

    Private url As String
    Public imgList As New List(Of String)

    Public Sub AddImage(imgName As String)

        url = "images/" + imgName
        imgList.Add(url)

    End Sub

End Class
