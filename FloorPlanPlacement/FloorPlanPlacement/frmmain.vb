
Public Class frmmain


    Public Scales As Double = 50
    Public totalWidth As Double
    Public totalHeight As Double
    Public FirstimeRun As Boolean = True
    Public tArea As Double = 0
    Public InitialArea As Double = 0
    Private Function DesignRuleCheck(AtotalHeight As Double, AtotalWidth As Double) As Boolean
        Dim Pass As Boolean
        Pass = True

        If AtotalHeight = 0 Or AtotalWidth = 0 Then Return False : Exit Function
        If AtotalHeight / AtotalWidth > 1.2 Then Pass = False
        If AtotalWidth / AtotalHeight > 1.2 Then Pass = False
        DesignRuleCheck = Pass
    End Function
    Private Sub Placement(stopWidth As Double)
        FirstimeRun = False
        'make all longer to height
        'sort 
        'horzontal
        'check ratio
        'devide
        Dim i As Integer
        Dim Y As Integer
        Dim prevX As Integer = 0
        Dim prevY As Integer = 0
        Dim tempTotalX As Double

        'On Error Resume Next
        totalWidth = 0
        totalHeight = 0
        tempTotalX = 0
        prevY = 0

        Y = 0
        lstcordX.Items.Clear()
        lstcordY.Items.Clear()
        Logging("Possible total width =" + CStr(stopWidth))
        For i = 0 To lstNodeWidth.Items.Count - 1
            Application.DoEvents()
            If (tempTotalX + CDbl(lstNodeWidth.Items(i)) <= stopWidth Or tempTotalX + CDbl(lstNodeWidth.Items(i)) <= totalWidth) Then
                If i = 0 Then
                    prevY = i
                    'First Coordinate
                    lstcordX.Items.Add(0)
                    lstcordY.Items.Add(Y)
                    tempTotalX = tempTotalX + lstNodeWidth.Items(i) 'Use to calculate longest X
                    totalHeight = totalHeight + lstNodeHeight.Items(i)

                Else
                    prevX = i - 1
                    lstcordX.Items.Add(CStr(CInt(lstNodeWidth.Items(prevX)) + CInt(lstcordX.Items(prevX))))
                    lstcordY.Items.Add(Y)
                    tempTotalX = tempTotalX + lstNodeWidth.Items(i) 'Use to calculate longest X

                End If
            Else
                Y = Y + CInt(lstNodeHeight.Items(prevY))
                prevY = i
                totalHeight = totalHeight + lstNodeHeight.Items(prevY)
                If tempTotalX > totalWidth Then totalWidth = tempTotalX
                tempTotalX = 0
                lstcordX.Items.Add(0)
                lstcordY.Items.Add(Y)
                tempTotalX = tempTotalX + lstNodeWidth.Items(i) 'Use to calculate longest X
            End If
        Next

        RefreshFloorPlan()

        tArea = CDbl(totalHeight) * CDbl(totalWidth)
        tArea = tArea * Scales * Scales

        Logging("Total Width  : " & CStr(CLng(totalWidth * Scales)))
        Logging("Total Height : " & CStr(CLng(totalHeight * Scales)))
        Logging("Height/Width : " & CStr((totalHeight / totalWidth)))
        Logging("Width/Height : " & CStr((totalWidth / totalHeight)))
        Logging("Area        :  " & CLng(tArea))
        Logging("###############################")
    End Sub
    Public Sub RefreshFloorPlan()
        picFloorPlan.Image = Nothing
        picFloorPlan.Refresh()

        For i = 0 To lstNodeWidth.Items.Count - 1
            DrawRectangle(CInt(lstcordX.Items(i)), CInt(lstcordY.Items(i)), CInt(lstNodeWidth.Items(i)), CInt(lstNodeHeight.Items(i)))
        Next

    End Sub
    Private Sub SaveFile()

        Dim FileName As String
        Dim StrArray As New System.Text.StringBuilder()
        Dim StrHeader As String = IIf(Scales > 1, "Floorplan Scaled for " + CStr(Scales) + " smaller" + vbCr + vbLf, "") + "Node name" + vbTab + "Width" + vbTab + "Height" + vbTab + "X" + vbTab + "Y"

        Dim i As Integer

        FileName = ""
        cmOpendlg.FileName = ""
        cmOpendlg.ShowDialog()
        FileName = cmOpendlg.FileName

        If FileName = "" Then Exit Sub
        MsgBox(FileName)
        StrArray.Append(StrHeader)

        If lstcordX.Items.Count = 0 Then Exit Sub

        For i = 0 To lstNodeName.Items.Count - 1
            StrArray.Append(vbCr + vbLf + CStr(lstNodeName.Items(i)) + vbTab + CStr(CInt(lstNodeWidth.Items(i))) + vbTab + CStr(CInt(lstNodeHeight.Items(i))) + vbTab + CStr(lstcordX.Items(i)) + vbTab + CStr(lstcordY.Items(i)))
        Next
        System.IO.File.WriteAllText(FileName, StrArray.ToString())
    End Sub

    Private Sub Loadfile()
        Dim ReadSplit() As String
        Dim FileName As String
        Dim i As Integer
        FileName = ""
        InitialArea = 0
        cmdlg.FileName = ""
        cmdlg.ShowDialog()
        FileName = cmdlg.FileName

        If (FileName = "") Then Exit Sub
        'FileName = "C:\Users\boonkhai\Desktop\adaptec1\adaptec.txt"
        Logging("Load file : " & FileName)
        Dim lines() As String = IO.File.ReadAllLines(FileName)
        'On Error GoTo Err
        lstLoad.Items.AddRange(lines)
        lstLoad.Items.Remove("")
        For i = 0 To lstLoad.Items.Count - 1

            If (CStr(lstLoad.Items(i))).Substring(0, 1) = vbTab Then
                If CStr(lstLoad.Items(i)).Length > 20 Then
                    If CStr(lstLoad.Items(i)).Substring(CStr(lstLoad.Items(i)).Length - 8, 8) = "terminal" Then
                        ReadSplit = Split((CStr(lstLoad.Items(i))), vbTab)
                        lstNodeName.Items.Add(ReadSplit(1))
                        lstUnscaledNodeWidth.Items.Add(CInt(ReadSplit(2)))
                        lstUnscaledNodeHeight.Items.Add(CInt(ReadSplit(3)))
                        lstNodeWidth.Items.Add(CInt(ReadSplit(2)) / Scales)
                        lstNodeHeight.Items.Add(CInt(ReadSplit(3)) / Scales)
                        InitialArea = InitialArea + (CDbl(ReadSplit(2)) * CDbl(ReadSplit(3)))
                    End If
                End If
            End If
        Next
        Logging("Estimated Initial Area: " + CStr(InitialArea))
        Sort()
        MsgBox("Done Loading", vbYes + vbInformation, "Done")

        Exit Sub
Err:
        MsgBox("Error Readig file", vbExclamation, "Error")

    End Sub
    Public Function RoundUp(input As Double) As Integer
        RoundUp = IIf(input > CInt(input), CInt(input) + 1, CInt(input))
    End Function
    Private Sub Sort()
        'Sort Height
        Logging("Sorting the height")
        Dim i As Integer
        Dim j As Integer
        Dim MaxLoc As Integer
        Dim maxCount As Integer
        Dim Max As Integer = 0
        maxCount = lstNodeHeight.Items.Count - 1
        For j = 0 To maxCount
            For i = 0 To lstNodeHeight.Items.Count - 1
                If Max < CInt(lstNodeHeight.Items(i)) Then Max = CInt(lstNodeHeight.Items(i)) : MaxLoc = i
            Next i

            lstNodeNameSort.Items.Add(lstNodeName.Items(MaxLoc))
            lstNodeWidthSort.Items.Add(lstNodeWidth.Items(MaxLoc))
            lstNodeHeightSort.Items.Add(lstNodeHeight.Items(MaxLoc))

            lstNodeHeight.Items.RemoveAt(MaxLoc)
            lstNodeWidth.Items.RemoveAt(MaxLoc)
            lstNodeName.Items.RemoveAt(MaxLoc)
            Max = 0
            MaxLoc = 0
        Next j

        For i = 0 To lstNodeNameSort.Items.Count - 1
            lstNodeName.Items.Add(lstNodeNameSort.Items(i))
            lstNodeWidth.Items.Add(lstNodeWidthSort.Items(i))
            lstNodeHeight.Items.Add(lstNodeHeightSort.Items(i))
        Next
        lstNodeHeightSort.Items.Clear()
        lstNodeWidthSort.Items.Clear()
        lstNodeNameSort.Items.Clear()
        Logging("Sorted")
    End Sub
    Private Sub DrawRectangle(posX As Integer, posY As Integer, tWidth As Integer, tHeight As Integer)
        Dim myGraphic As Graphics
        Dim myRectangle As Rectangle
        Dim myFrame As Rectangle
        Dim myBorder As Rectangle
        Dim myFloorPlan As Rectangle


        Dim myPen As New Pen(Color.Black)
        Dim myBrush As New SolidBrush(Color.Blue)
        Dim myFloorPlanColor As New Pen(Color.Green)

        posY = picFloorPlan.Height - posY - tHeight  'Calibrate left bottom as origin

        myGraphic = Graphics.FromHwnd(picFloorPlan.Handle)

        myFrame = New Rectangle(x:=0, y:=0, width:=picFloorPlan.Width - 1, height:=picFloorPlan.Height - 1)
        myRectangle = New Rectangle(x:=posX, y:=posY, width:=tWidth, height:=tHeight)
        myBorder = New Rectangle(x:=posX, y:=posY, width:=tWidth, height:=tHeight)
        myFloorPlan = New Rectangle(x:=0, y:=picFloorPlan.Height - RoundUp(totalHeight), width:=RoundUp(totalWidth), height:=RoundUp(totalHeight))

        myGraphic.FillRectangle(myBrush, myRectangle)
        myGraphic.DrawRectangle(pen:=myPen, rect:=myBorder)
        myGraphic.DrawRectangle(pen:=myPen, rect:=myFrame)
        myGraphic.DrawRectangle(pen:=myFloorPlanColor, rect:=myFloorPlan)
    End Sub
    Private Sub cmdPlacement_Click(sender As Object, e As EventArgs) Handles cmdPlacement.Click
        Logging("Start Placing...")
        Dim PossibleArea As Double
        Dim PossibletotalWidth As Double

        'Get estimated Posible Area'
        PossibleArea = InitialArea * 10 / (Scales * Scales)
        PossibletotalWidth = PossibleArea ^ (1 / 2)

        While (DesignRuleCheck(totalHeight, totalWidth) = False And PossibletotalWidth > 10)
            PossibletotalWidth = PossibletotalWidth / 1.2
            Placement(PossibletotalWidth)
        End While

        Logging("Done Placing...")

        MsgBox("Total Width  : " & CStr(CLng(totalWidth * Scales)) & vbCr + vbLf &
               "Total Height : " & CStr(CLng(totalHeight * Scales)) & vbCr + vbLf &
               "Height/Width : " & CStr((totalHeight / totalWidth)) & vbCr + vbLf &
               "Width/Height : " & CStr((totalWidth / totalHeight)) & vbCr + vbLf &
               "Area        :  " & CStr(CLng(tArea)), vbInformation, "Result")

    End Sub
    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        Dim msgAns As MessageBoxOptions
        If FirstimeRun = False Then
            msgAns = MsgBox("Are you sure? All result will be cleared", vbYesNo + vbInformation, "Load File?")
        End If

        If msgAns = vbNo Then Exit Sub
        Scales = CInt(cboScale.Text)
        If Scales <= 0 Then MsgBox("Scales must be positive integer") : Exit Sub
        lstlog.Items.Clear()
        txtLog.Text = ""
        Initialize()

            Loadfile()

    End Sub
    Private Sub Logging(tdata As String)
        lstlog.Items.Add(tdata)
        lstlog.SelectedIndex = lstlog.Items.Count - 1
        txtLog.AppendText(tdata + vbCr + vbLf)

    End Sub
    Public Sub Initialize()
        totalWidth = 0
        totalHeight = 0

        lstNodeHeight.Items.Clear()
        lstNodeHeightSort.Items.Clear()
        lstNodeWidth.Items.Clear()
        lstNodeWidthSort.Items.Clear()
        lstNodeName.Items.Clear()
        lstNodeName.Items.Clear()
        lstcordX.Items.Clear()
        lstcordY.Items.Clear()
        lstLoad.Items.Clear()

        picFloorPlan.Image = Nothing

    End Sub
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        cboScale.Text = "30"
        For i = 1 To 10
            cboScale.Items.Add(i * 10)
        Next

    End Sub

    Private Sub cmdRerun_Click(sender As Object, e As EventArgs) Handles cmdRerun.Click
        Dim stopWidth As Double
        stopWidth = CDbl(InputBox("Please insert width"))
        Placement(stopWidth)

        MsgBox("Total Width  : " & CStr(CLng(totalWidth * Scales)) & vbCr + vbLf &
               "Total Height : " & CStr(CLng(totalHeight * Scales)) & vbCr + vbLf &
               "Height/Width : " & CStr((totalHeight / totalWidth)) & vbCr + vbLf &
               "Width/Height : " & CStr((totalWidth / totalHeight)) & vbCr + vbLf &
               "Area        :  " & CStr(CLng(tArea)), vbInformation, "Result")
    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        SaveFile()
    End Sub
End Class
