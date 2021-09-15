Public Class frmMain
    Dim bsize As Integer = 32
    Dim CountySize = 20
    Dim ScreenWidth = 42

    Dim County As UInt32
    Dim CurrentCounty As UInt32
    Dim MileMarker As UInt32
    Dim CurrentMileMarker As UInt32


    Dim Mile As UInt32
    Dim CurrentMile As UInt32 = 0

    Dim BMP As Bitmap

    Dim lst As New List(Of UInt32)

    Dim BeachDir As eBeachDir = eBeachDir.East


    'TODO: LINKS
    ' County,MileMarker,MileData, Beach, Special.
    'Special.  Beach,Desert,Rocky,swamp.field


    Public Enum eBeachDir
        None
        East
        West
        North
        South
    End Enum
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BMP = New Bitmap(Me.Width, Me.Height)
        Me.BackgroundImage = BMP
        CurrentMile = &H7ACE1343
        Mile = CurrentMile
        CurrentCounty = &H11111111
        County = CurrentCounty
        CurrentMileMarker = 0
        MileMarker = CurrentMileMarker



        DrawScreenSouth(CurrentMileMarker, CurrentCounty, CurrentMile)



    End Sub
    Public Enum eCountyType
        town = 0
        farm = 1
        forest = 2
        bridge = 3
        beach = 4
        desert = 5
        rocky = 6
        field = 7
    End Enum

    'currently 8
    Private Function GetObjectImage(CountyType As Int16, objectNumber As Integer) As Image
        Select Case CountyType
            Case eCountyType.town
                'TOWN
                Select Case objectNumber
                    Case 0 : Return My.Resources.House1
                    Case 1 : Return My.Resources.House1
                    Case 2 : Return My.Resources.House1
                    Case 3 : Return My.Resources.House2
                    Case 4 : Return My.Resources.House2
                    Case 5 : Return My.Resources.House2
                    Case 6 : Return My.Resources.House2
                    Case 7 : Return My.Resources.House2
                    Case 8 : Return My.Resources.House3
                    Case 9 : Return My.Resources.House3
                    Case 10 : Return My.Resources.House3
                    Case 11 : Return My.Resources.House3
                    Case 12 : Return My.Resources.Tree1
                    Case 13 : Return My.Resources.Cemetary1
                    Case 14 : Return My.Resources.House1
                    Case 15 : Return My.Resources.House1
                    Case 16 : Return My.Resources.Tree2
                    Case 17 : Return My.Resources.Tree3
                    Case 18 : Return My.Resources.House1
                    Case 19 : Return My.Resources.House1
                    Case 20 : Return My.Resources.House1
                    Case 21 : Return My.Resources.House1
                    Case 22 : Return My.Resources.House1
                    Case 23 : Return My.Resources.House1
                    Case 24 : Return My.Resources.House1
                    Case 25 : Return My.Resources.House1
                    Case 26 : Return My.Resources.House1
                    Case 27 : Return My.Resources.House1
                    Case 28 : Return My.Resources.House1
                    Case 29 : Return My.Resources.House1
                    Case 30 : Return My.Resources.Barn
                    Case 31 : Return My.Resources.Pond

                    Case Else
                        Return My.Resources.Blank


                End Select
            Case eCountyType.farm
                'Farm
                Select Case objectNumber
                    Case 0 : Return My.Resources.Cow1
                    Case 1 : Return My.Resources.Cow1
                    Case 2 : Return My.Resources.Cow1
                    Case 3 : Return My.Resources.Bush1
                    Case 4 : Return My.Resources.Tree1
                    Case 5 : Return My.Resources.Tree2
                    Case 6 : Return My.Resources.Tree3
                    Case 7 : Return My.Resources.Pond
                    Case 8 : Return My.Resources.Windmill
                    Case 9 : Return My.Resources.House1
                    Case 10 : Return My.Resources.Bush1
                    Case 11 : Return My.Resources.House1
                    Case 12 : Return My.Resources.Boulders1
                    Case 13 : Return My.Resources.Cow1
                    Case 14 : Return My.Resources.Cow1
                    Case 15 : Return My.Resources.Pond
                    Case 16 : Return My.Resources.Barn
                    Case 17 : Return My.Resources.Silo
                    Case Else
                        Return My.Resources.Blank

                End Select
            Case eCountyType.forest
                'Forest
                Select Case objectNumber
                    Case 0 : Return My.Resources.Tree1
                    Case 1 : Return My.Resources.Tree1
                    Case 2 : Return My.Resources.Tree1
                    Case 3 : Return My.Resources.Tree1
                    Case 4 : Return My.Resources.Tree1
                    Case 5 : Return My.Resources.Tree1
                    Case 6 : Return My.Resources.Tree1
                    Case 7 : Return My.Resources.Tree1
                    Case 8 : Return My.Resources.Tree1
                    Case 9 : Return My.Resources.Tree1
                    Case 10 : Return My.Resources.Tree1
                    Case 11 : Return My.Resources.Tree1
                    Case 12 : Return My.Resources.Tree1
                    Case 13 : Return My.Resources.Tree2
                    Case 14 : Return My.Resources.Tree2
                    Case 15 : Return My.Resources.Tree2
                    Case 16 : Return My.Resources.Tree2
                    Case 17 : Return My.Resources.Tree3
                    Case 18 : Return My.Resources.Tree2
                    Case 19 : Return My.Resources.Tree2
                    Case 20 : Return My.Resources.Tree2
                    Case 21 : Return My.Resources.Tree2
                    Case 22 : Return My.Resources.Tree2
                    Case 23 : Return My.Resources.Tree3
                    Case 24 : Return My.Resources.Tree3
                    Case 25 : Return My.Resources.Tree3
                    Case 26 : Return My.Resources.Tree3
                    Case 27 : Return My.Resources.Tree3
                    Case 28 : Return My.Resources.Tree3
                    Case 29 : Return My.Resources.Tree3
                    Case 30 : Return My.Resources.Tree3
                    Case 31 : Return My.Resources.Pond
                    Case Else
                        Return My.Resources.Blank
                End Select

            Case eCountyType.desert
                Select Case objectNumber
                    Case 0 : Return My.Resources.Cactus
                    Case 1 : Return My.Resources.Bush1
                    Case 2 : Return My.Resources.Cactus
                    Case 3 : Return My.Resources.Bush1
                    Case Else
                        Return My.Resources.Blank

                End Select

            Case eCountyType.rocky
                Select Case objectNumber
                    Case 0 : Return My.Resources.Boulders1
                    Case 1 : Return My.Resources.Boulders2
                    Case 2 : Return My.Resources.Bush1
                    Case 3 : Return My.Resources.Tree1
                    Case 4 : Return My.Resources.Tree2
                    Case 5 : Return My.Resources.Boulders1
                    Case 6 : Return My.Resources.Boulders1
                    Case 7 : Return My.Resources.Pond
                    Case 8 : Return My.Resources.Boulders2
                    Case 9 : Return My.Resources.Boulders2
                    Case 10 : Return My.Resources.Boulders2
                    Case 11 : Return My.Resources.Boulders2
                    Case 12 : Return My.Resources.Boulders2
                    Case 13 : Return My.Resources.Boulders2
                    Case 14 : Return My.Resources.Boulders1
                    Case 15 : Return My.Resources.Pond
                    Case 16 : Return My.Resources.Boulders1
                    Case 17 : Return My.Resources.Boulders1
                    Case 18 : Return My.Resources.Boulders1
                    Case 19 : Return My.Resources.Boulders1
                    Case 20 : Return My.Resources.Boulders1
                    Case 21 : Return My.Resources.Boulders1
                    Case 22 : Return My.Resources.Boulders1
                    Case 23 : Return My.Resources.Boulders1
                    Case 24 : Return My.Resources.Boulders2
                    Case 25 : Return My.Resources.Boulders2
                    Case 26 : Return My.Resources.Boulders2
                    Case 27 : Return My.Resources.Boulders2
                    Case 28 : Return My.Resources.Boulders2
                    Case 29 : Return My.Resources.Boulders2
                    Case 30 : Return My.Resources.Boulders2
                    Case 31 : Return My.Resources.Boulders2
                    Case Else
                        Return My.Resources.Blank

                End Select
            Case eCountyType.field
                Select Case objectNumber
                    Case 0 : Return My.Resources.Tree1
                    Case 1 : Return My.Resources.Pond
                    Case 2 : Return My.Resources.Barn
                    Case 3 : Return My.Resources.Silo
                    Case 4 : Return My.Resources.Bush1
                    Case Else
                        Return My.Resources.Blank

                End Select




                'TODO FUTURE TYPES
            Case Else

                Select Case objectNumber
                    Case 0 : Return My.Resources.Cow1
                    Case 1 : Return My.Resources.Cow1
                    Case 2 : Return My.Resources.Cow1
                    Case 3 : Return My.Resources.Bush1
                    Case 4 : Return My.Resources.Tree1
                    Case 7 : Return My.Resources.Pond
                    Case 8 : Return My.Resources.Windmill
                    Case Else
                        Return My.Resources.Blank

                End Select
        End Select

        Return My.Resources.Blank
    End Function

    Private Sub DrawTile(r As Integer, c As Integer, b As Bitmap)
        Using g As Graphics = Graphics.FromImage(BMP)
            Dim Rect As New Rectangle(r * bsize, c * bsize, bsize, bsize)
            g.DrawImage(b, Rect)
        End Using

    End Sub


    Private Sub Next32b(ByRef N As UInt32)
        Console.WriteLine(Hex(N))
        N = N Xor ((N And &H7FFF) << 17)
        N = N Xor (N >> 15)
        N = N Xor ((N And &H3F) << 26)
        ' Console.WriteLine(Hex(N))

    End Sub
    Private Sub Prev32b(ByRef N As UInt32)
        N = N Xor ((N And &H3F) << 26)
        N = N Xor (N >> 15)
        N = N Xor (N >> 30)
        N = N Xor ((N And &H7FFF) << 17)
    End Sub


    Private Sub DrawScreenSouth(MileMarker As Int32, StartCounty As UInt32, StartMile As UInt32)
        Mile = StartMile

        'clear screen
        BMP.Dispose()
        BMP = New Bitmap(Me.Width, Me.Height)
        Using g As Graphics = Graphics.FromImage(BMP)
            Dim Rect As New Rectangle(0, 0, Me.Width, Me.Height)
            g.FillRectangle(New SolidBrush(Color.Black), Rect)
        End Using


        For i As Integer = 0 To 26

            'left and right edge 
            DrawTile(0, i, My.Resources.FenceNS)
            DrawTile(ScreenWidth, i, My.Resources.FenceNS)


            Dim CountyMile As Integer = (MileMarker + i) Mod CountySize

            Select Case CountyMile
                Case 0, CountySize - 1
                    'blank 
                Case Else
                    DrawRow(i, Mile, County, CountyMile)
            End Select

            MoveSouth()
        Next

        Me.BackgroundImage = BMP



    End Sub

    Private Sub DrawRow(ByVal row As Integer, ByVal Miledata As UInt64, CountyData As UInt64, CountyMile As Int32)



        Dim Road As UInt32 = CountyData And &H3
        Dim CountyType As UInt32 = (CountyData >> 2) And &HF
        If CountyType = eCountyType.beach AndAlso BeachDir = eBeachDir.None Then CountyType = eCountyType.bridge

        Dim MainType As UInt32 = Miledata And &H3F
        Dim r16b As UInt32 = (Miledata >> 4) And &HF
        Dim r16c As UInt32 = (Miledata >> 8) And &HF
        Dim r16d As UInt32 = (Miledata >> 12) And &HF
        Dim r4a As UInt32 = (Miledata >> 2) And &H3

        Dim RoadLt As Integer = 0
        Dim RoadRt As Integer = 0

        Select Case Road
            Case 0, 3
                RoadLt = 4
            Case 1
                RoadLt = 18
            Case 2
                RoadLt = 32
        End Select
        RoadRt = RoadLt + 3

        '''''''''Draw top and bottom edges
        If CountyMile = 1 Then
            'Top edge of county
            'horz fence left of road.
            For i As Integer = 1 To RoadLt - 1
                DrawTile(i, row, My.Resources.FenceEW)
            Next
            DrawTile(RoadLt, row, My.Resources.FenceSW)
            DrawTile(0, row, My.Resources.FenceNSE)
            'horz fence right of road.
            For i As Integer = RoadRt + 1 To ScreenWidth - 1
                DrawTile(i, row, My.Resources.FenceEW)
            Next
            DrawTile(RoadRt, row, My.Resources.FenceSE)
            DrawTile(ScreenWidth, row, My.Resources.FenceNSW)
            Exit Sub
        End If
        If CountyMile = CountySize - 2 Then
            'bottom edge of county
            'horz fence left of road.
            For i As Integer = 1 To RoadLt - 1
                DrawTile(i, row, My.Resources.FenceEW)
            Next
            DrawTile(RoadLt, row, My.Resources.FenceNW)
            DrawTile(0, row, My.Resources.FenceNSE)
            'horz fence right of road.
            For i As Integer = RoadRt + 1 To ScreenWidth - 1
                DrawTile(i, row, My.Resources.FenceEW)
            Next
            DrawTile(RoadRt, row, My.Resources.FenceNE)
            DrawTile(ScreenWidth, row, My.Resources.FenceNSW)
            Exit Sub
        End If

        'Special county types '''''''''''''''''''''''''''''''''''''''''''''''''
        If CountyType = eCountyType.bridge Then
            For i As Integer = 0 To RoadLt - 2
                DrawTile(i, row, My.Resources.water2)
            Next
            For i As Integer = RoadRt + 2 To ScreenWidth
                DrawTile(i, row, My.Resources.water2)
            Next
            'Fence on both sides of road
            DrawTile(RoadLt, row, My.Resources.FenceNS)
            DrawTile(RoadRt, row, My.Resources.FenceNS)
            Exit Sub
        End If

        Select Case MainType
            Case 0
                'horz fence left of road.
                For i As Integer = 1 To RoadLt - 1
                    DrawTile(i, row, My.Resources.FenceEW)
                Next
                DrawTile(RoadLt, row, My.Resources.FenceNSW)
                DrawTile(RoadRt, row, My.Resources.FenceNS)
                DrawTile(0, row, My.Resources.FenceNSE)
            Case 1
                'horz fence right of road.
                For i As Integer = RoadRt To ScreenWidth - 1
                    DrawTile(i, row, My.Resources.FenceEW)
                Next
                DrawTile(RoadRt, row, My.Resources.FenceNSE)
                DrawTile(RoadLt, row, My.Resources.FenceNS)
                DrawTile(ScreenWidth, row, My.Resources.FenceNSW)


            Case 2
                'horz fence left of road.
                For i As Integer = 1 To RoadLt - 1
                    DrawTile(i, row, My.Resources.FenceEW)
                Next
                DrawTile(RoadLt, row, My.Resources.FenceNSW)
                DrawTile(0, row, My.Resources.FenceNSE)
                'horz fence right of road.
                For i As Integer = RoadRt + 1 To ScreenWidth - 1
                    DrawTile(i, row, My.Resources.FenceEW)
                Next
                DrawTile(RoadRt, row, My.Resources.FenceNSE)
                DrawTile(ScreenWidth, row, My.Resources.FenceNSW)

            Case 3
                'River
                DrawTile(RoadLt, row, My.Resources.FenceNS)
                DrawTile(RoadRt, row, My.Resources.FenceNS)

                Dim img As Image = My.Resources.water2
                If CountyType = eCountyType.desert Then
                    img = My.Resources.sand2
                End If

                For i As Integer = 1 To RoadLt - 1
                    DrawTile(i, row, img)
                Next
                For i As Integer = RoadRt + 1 To ScreenWidth - 1
                    DrawTile(i, row, img)
                Next
                'following get random objects
            Case 5, 6, 7
                DrawTile(RoadLt, row, My.Resources.FenceNS)
            Case 4, 8, 9
                DrawTile(RoadRt, row, My.Resources.FenceNS)
            Case 10 ' no fence

            Case Else
                'Fence on both sides of road
                DrawTile(RoadLt, row, My.Resources.FenceNS)
                DrawTile(RoadRt, row, My.Resources.FenceNS)

        End Select

        If MainType > 3 Then
            Select Case r16b
                Case 0
                    'partial fence left
                    For i As Integer = 4 To RoadLt - 1
                        DrawTile(i, row, My.Resources.FenceEW)
                    Next
                    DrawTile(RoadLt, row, My.Resources.FenceNSW)

                Case 1
                    'partial fence right
                    For i As Integer = RoadRt To ScreenWidth - 4
                        DrawTile(i, row, My.Resources.FenceEW)
                    Next
                    DrawTile(RoadRt, row, My.Resources.FenceNSE)
                Case Else

                    Dim u As UInt32 = MileMarker Xor Miledata
                    Next32b(u)
                    Dim ctr = u And &H7
                    For i As Integer = 0 To Miledata And (&H1F)
                        If ctr = 0 Then ctr += 1
                        Next32b(u)
                        If ctr >= RoadLt AndAlso ctr <= RoadRt Then
                            ctr += 6
                        End If

                        DrawTile(ctr, row, GetObjectImage(CountyType, (u >> 3) And &H1F))
                        ctr += u And &H7
                        If ctr >= ScreenWidth Then ctr -= ScreenWidth
                    Next

            End Select
        End If


        If CountyType = eCountyType.beach Then
            If BeachDir = eBeachDir.East Then
                DrawTile(RoadRt, row, My.Resources.sand2)
                DrawTile(RoadRt + 1, row, My.Resources.sand2)
                For i As Integer = RoadRt + 2 To ScreenWidth
                    DrawTile(i, row, My.Resources.water2)
                Next
                Exit Sub
            End If

            If BeachDir = eBeachDir.West Then

                DrawTile(RoadLt, row, My.Resources.sand2)
                DrawTile(RoadLt - 1, row, My.Resources.sand2)
                For i As Integer = 0 To RoadLt - 2
                    DrawTile(i, row, My.Resources.water2)
                Next
                Exit Sub
            End If
        End If


    End Sub


    Private Sub MoveSouth()
        Next32b(Mile)
        MileMarker += 1
        If MileMarker Mod CountySize = 0 Then
            Next32b(County)
        End If
    End Sub
    Private Sub MoveNorth()
        Prev32b(Mile)
        MileMarker -= 1
        If MileMarker Mod CountySize = CountySize - 1 Then
            Prev32b(County)
        End If
    End Sub


    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Down
                'copy start to temp vars
                MileMarker = CurrentMileMarker
                Mile = CurrentMile
                County = CurrentCounty
                MoveSouth()
                MoveSouth()
                MoveSouth()
                MoveSouth()
                MoveSouth()
                MoveSouth()
                'Copy temp to current.
                CurrentMile = Mile
                CurrentCounty = County
                CurrentMileMarker = MileMarker
                DrawScreenSouth(MileMarker, CurrentCounty, CurrentMile)
            Case Keys.Up
                'copy start to temp vars
                MileMarker = CurrentMileMarker
                Mile = CurrentMile
                County = CurrentCounty
                MoveNorth()
                MoveNorth()
                MoveNorth()
                MoveNorth()
                MoveNorth()
                MoveNorth()
                'Copy temp to current.
                CurrentMile = Mile
                CurrentCounty = County
                CurrentMileMarker = MileMarker
                DrawScreenSouth(MileMarker, CurrentCounty, CurrentMile)

        End Select
    End Sub
End Class