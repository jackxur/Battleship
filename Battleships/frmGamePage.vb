Public Class frmGamePage
    Dim total As Integer = 0
    Private Sub frmGamePage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            PictureBox5.Top = PictureBox5.Top - 3
        End If

        If e.KeyCode = Keys.A Then
            PictureBox5.Left = PictureBox5.Left - 3
        End If

        If e.KeyCode = Keys.S Then
            PictureBox5.Top = PictureBox5.Top + 3
        End If

        If e.KeyCode = Keys.D Then
            PictureBox5.Left = PictureBox5.Left - 3
        End If
    End Sub



    Private Sub frmGamePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rndDeleteShip.Parent = picSeaBackground
        rndVertical.Parent = picSeaBackground
        rndHorizontal.Parent = picSeaBackground
        btnReady.Parent = picSeaBackground
        Me.WindowState = FormWindowState.Maximized

        MsgBox("Welcome to Battleship! You are playing head to head on a coordinate grid with the computer; whoever sinks all the opponent's ships is the champion.
You will set up your ships on an empty grid, and once the game starts, you will take turns guessing the locations of your opponent’s ships. 
There are 5 types of ships involved. Begin by selecting 5 consecutive grids.", MsgBoxStyle.OkOnly, "Instructions")

    End Sub

    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        If chkbxA1.Checked Then
            total += 1
        ElseIf chkbxA1.Checked = False Then
            total = total - 1
        End If

        'If chkbxA1.Checked And chkbxB1.Checked And chkbxD1.Checked And chkbxC1.Checked And chkbxE1.Checked Then
        'chkbxA1.Visible = True
        'chkbxB1.Visible = True
        'chkbxC1.Visible = True
        'chkbxD1.Visible = True
        'chkbxE1.Visible = True
        'chkbxF1.Visible = False
        'chkbxG1.Visible = False
        'chkbxH1.Visible = False
        'chkbxI1.Visible = False
        'chkbxJ1.Visible = False
        'else
        'chkbxA1.Visible = False
        'chkbxB1.Visible = False
        'chkbxC1.Visible = False
        'chkbxD1.Visible = False
        'chkbxE1.Visible = False
        'chkbxF1.Visible = False
        'chkbxG1.Visible = False
        'chkbxH1.Visible = False
        'chkbxI1.Visible = False
        '    chkbxJ1.Visible = False
        'End If

        ' If PictureBox1 And rndHorizontal.selected Then
        'PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        ' ElseIf PictureBox1 And rndVertical.selected Then
        'PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        'End If

    End Sub

    Private Sub btnOpponent_Click(sender As Object, e As EventArgs) Handles btnOpponent.Click
        frmOpponentsPage.Show()
    End Sub





    'If radDeleteShip.Selected = True Then
    'radDeleteShip.Visible = False
    'End If




End Class