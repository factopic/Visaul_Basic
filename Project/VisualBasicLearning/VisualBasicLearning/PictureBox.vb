Public Class PictureBo

  
    Private Sub ADDButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDButton.Click
        'Apperance :  BackgroundImageLayout  Behaviour : SizeMode
        PictureBox1.Image = Image.FromFile("C:\Users\Dee\Desktop\github\img\logo.jpg")

    End Sub

    Private Sub PictureBo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 400
        Me.Width = 800
        BackColor = Color.Aqua

    End Sub
End Class