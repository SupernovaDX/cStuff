Imports System.Threading
Public Class Form1
    Dim prss As Boolean
    Dim Clash As Integer
    Dim isRunning As Boolean
    Dim go As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        prss = False
        isRunning = False
        go = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (isRunning = False) Then
            PictureBox2.Visible = True
            prss = True
            Clash = 1
            Run()
        End If
    End Sub
    Private Function Sead(number As Integer) As String
        Dim txt As String
        If (number = 1) Then
            txt = "Rock"
            Return txt
        ElseIf (number = 2) Then
            txt = "Paper"
            Return txt
        ElseIf (number = 3) Then
            txt = "Scissors"
            Return txt
        End If
    End Function
    Private Sub Display(number As Integer)
        If (number = 1) Then
            PictureBox6.Visible = True
        ElseIf (number = 2) Then
            PictureBox4.Visible = True
        ElseIf (number = 3) Then
            PictureBox5.Visible = True
        End If
    End Sub

    Private Function Ref(Opponent As Integer, Player As Integer) As String
        If (Opponent = Player) Then
            Return "Tie"
        End If
        Return "#NULL"
    End Function

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Sub Run()
        If (prss = True) Then
            isRunning = True
            Label1.Text = Sead(Clash)
            wait(500)
            PictureBox7.Visible = True
            Dim audio As New AudioFile("C:\Users\Nick\Documents\GitHub\cStuff\Visual Studio 2013\Projects\SPRGame\resources\Big_Bomb.mp3")
            audio.Play()
            Dim rnd As New Random
            Dim comp As Integer
            comp = rnd.Next(3) + 1
            Label2.Text = Sead(comp)
            Display(comp)
            Label9.Text = Ref(comp, Clash)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (isRunning = False) Then
            PictureBox1.Visible = True
            prss = True
            Clash = 2
            Run()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (isRunning = False) Then
            PictureBox3.Visible = True
            prss = True
            Clash = 3
            Run()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Restart()
    End Sub
    Sub Restart()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        prss = False
        isRunning = False
        go = False
    End Sub
End Class
