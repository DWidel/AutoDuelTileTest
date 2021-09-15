Public Class Form1

    Dim BoxSize As Integer = 32

    Dim Scrn As New Dictionary(Of Point, PictureBox)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Integer = 0 To 32
            For y As Integer = 0 To 20
                Dim p As New Point(x, y)
                Dim pb As New PictureBox
                Me.Controls.Add(pb)
                pb.Left = x * BoxSize
                pb.Top = y * BoxSize
                pb.BackColor = Color.Black
                pb.SizeMode = PictureBoxSizeMode.StretchImage
                pb.Height = BoxSize
                pb.Width = BoxSize
                Scrn.Add(p, pb)
            Next
        Next


        For i As Integer = 0 To 15
            Dim p As New Point(12, i)
            Scrn(p).Image = My.Resources.FenceNS
        Next
        For i As Integer = 0 To 9
            Dim p As New Point(15, i)
            Scrn(p).Image = My.Resources.FenceNS
        Next

        Scrn(New Point(12, 12)).Image = My.Resources.FenceNSW

        If True Then
            'draw tree
            Dim pb As PictureBox = Scrn(New Point(11, 11))
            pb.Image = My.Resources.Tree2
            'pb.BringToFront()
            'pb.Width = 2 * BoxSize
            'pb.Height = 2 * BoxSize
        End If

        For i As Integer = 0 To 11
            Dim p As New Point(i, 12)
            Scrn(p).Image = My.Resources.FenceEW
        Next

        Scrn(New Point(12, 18)).Image = My.Resources.FenceSW
        Scrn(New Point(12, 19)).Image = My.Resources.FenceNS
        Scrn(New Point(11, 18)).Image = My.Resources.FenceEW


        Scrn(New Point(15, 15)).Image = My.Resources.Boulders2
        Scrn(New Point(15, 16)).Image = My.Resources.Boulders2
        Scrn(New Point(15, 17)).Image = My.Resources.Boulders1
        Scrn(New Point(15, 18)).Image = My.Resources.Boulders1
        Scrn(New Point(15, 19)).Image = My.Resources.Boulders1
        Scrn(New Point(17, 15)).Image = My.Resources.House1
        Scrn(New Point(18, 15)).Image = My.Resources.Gas
        Scrn(New Point(19, 18)).Image = My.Resources.Bush1
        Scrn(New Point(8, 11)).Image = My.Resources.Bush1
        Scrn(New Point(11, 3)).Image = My.Resources.Bush1
        Scrn(New Point(8, 4)).Image = My.Resources.Bush1
        Scrn(New Point(8, 8)).Image = My.Resources.Cow1
        Scrn(New Point(11, 6)).Image = My.Resources.Cow1
        Scrn(New Point(11, 4)).Image = My.Resources.Cow1
        Scrn(New Point(11, 4)).Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        Scrn(New Point(9, 7)).Image = My.Resources.Cow1



    End Sub
End Class
