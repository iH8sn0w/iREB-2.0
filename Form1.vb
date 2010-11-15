Imports System.Management
Public Class Form1
    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Private WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Public OnlineMode = False
    Public OfflineMode = False
    Public iDevice As String
    Public DFUConnected As Boolean
    Public UploadediBSS As Boolean = False
    Public UploadediBEC As Boolean = False
    Public InRecovery As Boolean = False
    Public UploadedWTF As Boolean = False
    Public IrLooking4DFUPreparingtoUploadiBSS As Boolean = False
    Public Downloaded As Boolean = False
    Public IPSWPath As String
    Public temppath As String
    Public cmdline As String
    Public Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        DFUConnected = False
        Do Until DFUConnected = True
            'Searching for DFU...
            console.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (DFU) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()

                console.Text += (queryObj("Description"))
            Next
            If console.Text.Contains("DFU") Then
                DFUConnected = True
                If IrLooking4DFUPreparingtoUploadiBSS = True Then
                    IrLooking4DFUPreparingtoUploadiBSS = False
                    If iDevice = "iPhone 3G" Then
                        Label4.Invoke(CType(AddressOf Run_iphone3G_ibss, MethodInvoker))
                    ElseIf iDevice = "iPhone 2G" Then
                        Label4.Invoke(CType(AddressOf Run_iphone2G_ibss, MethodInvoker))
                    ElseIf iDevice = "iPod Touch 1G" Then
                        Label4.Invoke(CType(AddressOf Run_ipod1g_ibss, MethodInvoker))
                    End If
                End If
            End If
        Loop
    End Sub
    Public Sub Increase()
        If ProgressBar1.Value = 100 Then
            Exit Sub
        End If
        ProgressBar1.Value = ProgressBar1.Value + 3
    End Sub
    Public Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Do Until ProgressBar1.Value = 99
            ProgressBar1.Invoke(CType(AddressOf Increase, MethodInvoker))
            Sleep(75)
        Loop
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Process.Start("http://ih8sn0w.com")
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start("http://twitter.com/iH8sn0w")
    End Sub
    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Cyan
    End Sub
    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Blue
    End Sub
    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.Cyan
    End Sub
    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Blue
    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Process.Start("http://twitter.com/iC_J")
    End Sub
    Private Sub Label14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.MouseEnter
        Label14.ForeColor = Color.Cyan
    End Sub
    Private Sub Label14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.MouseLeave
        Label14.ForeColor = Color.Blue
    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Process.Start("http://twitter.com/p0sixninja")
    End Sub
    Private Sub Label15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.MouseEnter
        Label15.ForeColor = Color.Cyan
    End Sub
    Private Sub Label15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.MouseLeave
        Label15.ForeColor = Color.Blue
    End Sub
    Private Sub Label5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Cyan
    End Sub
    Private Sub Label5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Blue
    End Sub
    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Cyan
    End Sub
    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Blue
    End Sub
    Private Sub Label12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseEnter
        Label12.ForeColor = Color.Cyan
    End Sub
    Private Sub Label12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseLeave
        Label12.ForeColor = Color.Blue
    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Process.Start("http://msftguy.blogspot.com/")
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Cyan
    End Sub
    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Blue
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Process.Start("http://twitter.com/LiLBush81")
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Process.Start("http://twitter.com/w3st05")
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start("http://twitter.com/planetbeing")
    End Sub
    Function HighlightWords(ByVal rtb As RichTextBox, ByVal sFindString As String, ByVal lColor As System.Drawing.Color) As Integer

        Dim iFoundPos As Integer 'Position of first character of match
        Dim iFindLength As Integer       'Length of string to find
        Dim iOriginalSelStart As Integer
        Dim iOriginalSelLength As Integer
        Dim iMatchCount As Integer      'Number of matches

        'Save the insertion points current location and length
        iOriginalSelStart = rtb.SelectionStart
        iOriginalSelLength = rtb.SelectionLength

        'Cache the length of the string to find
        iFindLength = Len(sFindString)

        'Attempt to find the first match
        iFoundPos = rtb.Find(sFindString, 0, RichTextBoxFinds.NoHighlight)
        While iFoundPos > 0
            iMatchCount = iMatchCount + 1
            iFoundPos = rtb.Find("THIS SHOULD NOT RETURN ANYTHIN---3$#@$#%@$#@!$@#$#@$@!#$!@#$!@$234-AND I MEAN IT!!!#@!$!%&*()(*&^%$#@!", iFoundPos + iFindLength, RichTextBoxFinds.NoHighlight)
        End While

        'Restore the insertion point to its original location and length
        rtb.SelectionStart = iOriginalSelStart
        rtb.SelectionLength = iOriginalSelLength

        'Return the number of matches
        HighlightWords = iMatchCount
    End Function
    Public Sub GoGoGadgetiREB3GPatcher()
        Label11.Text = "Extracting Resources..."
        ProgressBar1.Value = 15
        SaveToDisk("unzip.exe", "unzip.exe")
        SaveToDisk("wait.img3", "wait.img3")
        SaveToDisk("itunnel.exe", "itunnel.exe")
        SaveToDisk("Resources.zip", "Resources.zip")
        cmdline = "unzip.exe -o Resources.zip -d Resources"
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 20
        Label11.Text = "Creating Payload..."
        cmdline = Quote.Text & "Resources/bspatch.exe" & Quote.Text & " " & Quote.Text & "iBSS.n82ap.RELEASE-312.dfu" & Quote.Text & " " & Quote.Text & "iBSS.n82ap.RELEASE.payload" & Quote.Text & " " & Quote.Text & "Resources/iPhone3G.patch" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 26
        Label11.Text = "Patching iBSS..."
        cmdline = Quote.Text & "Resources/bspatch.exe" & Quote.Text & " " & Quote.Text & "iBSS.n82ap.RELEASE.dfu" & Quote.Text & " " & Quote.Text & "iBSS.n82ap.RELEASE.pwned" & Quote.Text & " " & Quote.Text & "Resources/iPhone3G-iBSS.patch" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 30
        Label11.Invoke(CType(AddressOf Run_iphone3G, MethodInvoker))
    End Sub
    Public Sub GoGoGadgetiREB2GPatcher()
        Label11.Text = "Extracting Resources..."
        ProgressBar1.Value = 15
        SaveToDisk("unzip.exe", "unzip.exe")
        SaveToDisk("wait.img3", "wait.img3")
        SaveToDisk("itunnel.exe", "itunnel.exe")
        SaveToDisk("Resources.zip", "Resources.zip")
        cmdline = "unzip.exe -o Resources.zip -d Resources"
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 20
        Label11.Text = "Creating Payload..."
        cmdline = Quote.Text & "Resources/bspatch.exe" & Quote.Text & " " & Quote.Text & "iBSS.m68ap.RELEASE.dfu" & Quote.Text & " " & Quote.Text & "iBSS.m68ap.RELEASE.payload" & Quote.Text & " " & Quote.Text & "Resources/iPhone2G.patch" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 30
        Label11.Invoke(CType(AddressOf Run_iphone2G, MethodInvoker))
    End Sub
    Public Sub GoGoGadgetiREBiPod1GPatcher()
        Label11.Text = "Extracting Resources..."
        ProgressBar1.Value = 15
        SaveToDisk("unzip.exe", "unzip.exe")
        SaveToDisk("wait.img3", "wait.img3")
        SaveToDisk("itunnel.exe", "itunnel.exe")
        SaveToDisk("Resources.zip", "Resources.zip")
        cmdline = "unzip.exe -o Resources.zip -d Resources"
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 20
        Label11.Text = "Patching iBSS..."
        cmdline = Quote.Text & "Resources/bspatch.exe" & Quote.Text & " " & Quote.Text & "iBSS.n45ap.RELEASE.dfu" & Quote.Text & " " & Quote.Text & "iBSS.n45ap.RELEASE-312.dfu" & Quote.Text & " " & Quote.Text & "Resources/SendiPod1G.patch" & Quote.Text
        ExecCmd(cmdline, True)
        Label11.Text = "Creating Payload..."
        cmdline = Quote.Text & "Resources/bspatch.exe" & Quote.Text & " " & Quote.Text & "iBSS.n45ap.RELEASE-312.dfu" & Quote.Text & " " & Quote.Text & "iBSS.n45ap.RELEASE.payload" & Quote.Text & " " & Quote.Text & "Resources/iPodTouch1G.patch" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 30
        Label11.Invoke(CType(AddressOf Run_ipod1g, MethodInvoker))
    End Sub
    Public Sub GoGoGadgetiREB()
        temppath = System.Environment.CurrentDirectory
        'Decide if I should run online or offline.
        PictureBox6.Visible = True
        If iDevice = "iPhone 3GS" Or iDevice = "iPhone 4" Or iDevice = "iPod Touch 3G" Or iDevice = "iPod Touch 4" Or iDevice = "iPad" Or iDevice = "Apple TV 2" Then
            Call run_limera1n()
            Exit Sub
        ElseIf iDevice = "iPod Touch 2G" Then
            Call run_steaks4uce()
            Exit Sub
        End If
        If OnlineMode = True Then
            'Do online stuff
            If iDevice = "iPhone 3G" Then
                SaveToDisk("dl.exe", "dl.exe")
                SaveToDisk("msvcr100d.dll", "msvcr100d.dll")
                Label11.Text = "Downloading Essentials..."
                ProgressBar1.Value = 10
                Delay(1)
                cmdline = Quote.Text & "dl.exe" & Quote.Text & " iphone3g"
                ExecCmd(cmdline, True)
                cmdline = "cmd /c RENAME " & Quote.Text & "iBSS.n82ap.RELEASE.dfu" & Quote.Text & " " & Quote.Text & "iBSS.n82ap.RELEASE-312.dfu" & Quote.Text
                ExecCmd(cmdline, True)
                Label11.Text = "Downloading more Essentials..."
                ProgressBar1.Value = 10
                cmdline = Quote.Text & "dl.exe" & Quote.Text & " iphone3g-2"
                ExecCmd(cmdline, True)
                Delay(1)
                If File_Exists("iBSS.n82ap.RELEASE.dfu") And File_Exists("iBSS.n82ap.RELEASE-312.dfu") And File_Exists("WTF.s5l8900xall.RELEASE.dfu") = True Then
                    Label11.Text = "Download completed!"
                    Call GoGoGadgetiREB3GPatcher()
                Else
                    Label11.Text = "Download FAILED!"
                End If
            ElseIf iDevice = "iPhone 2G" Then
                SaveToDisk("dl.exe", "dl.exe")
                SaveToDisk("msvcr100d.dll", "msvcr100d.dll")
                Label11.Text = "Downloading Essentials..."
                ProgressBar1.Value = 10
                Delay(1)
                cmdline = Quote.Text & "dl.exe" & Quote.Text & " iphone2g"
                ExecCmd(cmdline, True)
                Delay(1)
                If File_Exists("iBSS.m68ap.RELEASE.dfu") And File_Exists("WTF.s5l8900xall.RELEASE.dfu") = True Then
                    Label11.Text = "Download completed!"
                    Call GoGoGadgetiREB2GPatcher()
                Else
                    Label11.Text = "Download FAILED!"
                End If
            ElseIf iDevice = "iPod Touch 1G" Then
                SaveToDisk("dl.exe", "dl.exe")
                SaveToDisk("msvcr100d.dll", "msvcr100d.dll")
                Label11.Text = "Downloading Essentials..."
                ProgressBar1.Value = 10
                Delay(1)
                cmdline = Quote.Text & "dl.exe" & Quote.Text & " ipod1g"
                ExecCmd(cmdline, True)
                Delay(1)
                If File_Exists("iBSS.n45ap.RELEASE.dfu") And File_Exists("WTF.s5l8900xall.RELEASE.dfu") = True Then
                    Label11.Text = "Download completed!"
                    Call GoGoGadgetiREBiPod1GPatcher()
                Else
                    Label11.Text = "Download FAILED!"
                End If
            End If

        End If
    End Sub
    Public Sub Run_iphone3G()
        Label11.Text = "Uploading WTF..."
        UploadedWTF = True
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -dfufile " & Quote.Text & "WTF.s5l8900xall.RELEASE.dfu" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 40
        IrLooking4DFUPreparingtoUploadiBSS = True
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        'Label4.Invoke(CType(AddressOf Run_iphone3G_ibss, MethodInvoker))
        Exit Sub
    End Sub
    Public Sub Run_iphone2G()
        Label11.Text = "Uploading WTF..."
        UploadedWTF = True
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -dfufile " & Quote.Text & "WTF.s5l8900xall.RELEASE.dfu" & Quote.Text
        ExecCmd(cmdline, True)
        IrLooking4DFUPreparingtoUploadiBSS = True
        ProgressBar1.Value = 40
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        'Label4.Invoke(CType(AddressOf Run_iphone2G_ibss, MethodInvoker))
        Exit Sub
    End Sub
    Public Sub Run_ipod1g()
        Label11.Text = "Uploading WTF..."
        UploadedWTF = True
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -dfufile " & Quote.Text & "WTF.s5l8900xall.RELEASE.dfu" & Quote.Text
        ExecCmd(cmdline, True)
        IrLooking4DFUPreparingtoUploadiBSS = True
        ProgressBar1.Value = 40
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        'Label4.Invoke(CType(AddressOf Run_iphone2G_ibss, MethodInvoker))
        Exit Sub
    End Sub
    Public Sub Run_iphone3G_ibss()
        Label11.Text = "Uploading iBSS..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -dfufile " & Quote.Text & "iBSS.n82ap.RELEASE-312.dfu" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 45
        Label11.Text = "Waiting for iBSS..."
        UploadediBSS = True
        BackgroundWorker3 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker3.RunWorkerAsync()
        BackgroundWorker3.WorkerReportsProgress = True
        BackgroundWorker3.WorkerSupportsCancellation = True
        Exit Sub
    End Sub
    Public Sub Run_iphone2G_ibss()
        Label11.Text = "Uploading iBSS..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -dfufile " & Quote.Text & "iBSS.m68ap.RELEASE.dfu" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 45
        Label11.Text = "Waiting for iBSS..."
        UploadediBSS = True
        BackgroundWorker3 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker3.RunWorkerAsync()
        BackgroundWorker3.WorkerReportsProgress = True
        BackgroundWorker3.WorkerSupportsCancellation = True
        Exit Sub
    End Sub
    Public Sub Run_ipod1g_ibss()
        Label11.Text = "Uploading iBSS..."
        ProgressBar1.Value = 45
        Label11.Text = "Waiting for iBSS..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -dfufile " & Quote.Text & "iBSS.n45ap.RELEASE-312.dfu" & Quote.Text
        ExecCmd(cmdline, True)
        UploadediBSS = True
        BackgroundWorker3 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker3.RunWorkerAsync()
        BackgroundWorker3.WorkerReportsProgress = True
        BackgroundWorker3.WorkerSupportsCancellation = True
        Exit Sub
    End Sub
    Public Sub Run_iphone3G_exec()
        Label11.Text = "Pwning iBSS..."
        Delay(1)
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -exploit " & Quote.Text & "iBSS.n82ap.RELEASE.payload" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 60
        Label11.Text = "Uploading PWNED iBSS..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -recfile " & Quote.Text & "iBSS.n82ap.RELEASE.pwned" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 70
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -c " & Quote.Text & "go" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 80
        Label11.Text = "Waiting for iBSS (again)..."
        Delay(1)
        UploadediBEC = True
        BackgroundWorker3 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker3.RunWorkerAsync()
        BackgroundWorker3.WorkerReportsProgress = True
        BackgroundWorker3.WorkerSupportsCancellation = True
        Exit Sub
    End Sub
    Public Sub Run_iphone2G_exec()
        Label11.Text = "Pwning iBSS..."
        Delay(1)
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -exploit " & Quote.Text & "iBSS.m68ap.RELEASE.payload" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 60
        SaveToDisk("wait.img3", "wait.img3")
        Delay(1)
        Label11.Text = "Setting Up iBSS..."
        ProgressBar1.Value = 90
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -setpic " & Quote.Text & "wait.img3" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        MsgBox("If you have the " & Quote.Text & "Waiting for Custom Firmware" & Quote.Text & " on your device." & Chr(13) & "You may restore to custom firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."
        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
        Exit Sub
    End Sub
    Public Sub Run_ipod1g_exec()
        Label11.Text = "Pwning iBSS..."
        Delay(1)
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -exploit " & Quote.Text & "iBSS.n45ap.RELEASE.payload" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 60
        SaveToDisk("wait.img3", "wait.img3")
        Delay(1)
        Label11.Text = "Setting Up iBSS..."
        ProgressBar1.Value = 90
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -setpic " & Quote.Text & "wait.img3" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        MsgBox("If you have the " & Quote.Text & "Waiting for Custom Firmware" & Quote.Text & " on your device." & Chr(13) & "You may restore to custom firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."
        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
        Exit Sub
    End Sub
    Public Sub GoGoGadget_iBEC()
        SaveToDisk("wait.img3", "wait.img3")
        Delay(6)
        Label11.Text = "Setting Up iBSS..."
        ProgressBar1.Value = 90
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -c " & Quote.Text & "bgcolor 0 255 0" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        MsgBox("If you have the green screen on your device." & Chr(13) & "You may restore to custom firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."
        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
    End Sub
    Public Sub GoGoGadgetCleanup()
        PictureBox5.Visible = True
        PictureBox6.Visible = False
        OfflineMode = False
        OnlineMode = False
        Label9.Visible = True
        Label10.Visible = False
        Label10.Text = "DFU Helper"
        Label11.Visible = False
        ProgressBar1.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        IrLooking4DFUPreparingtoUploadiBSS = False
        DFUConnected = False
        InRecovery = False
    End Sub
    Public Sub CleanupDFU()
        Label11.Text = "Preparing..."
        Prepare.Visible = False
        dfuinstructions.Visible = False
        Label10.Text = iDevice
        Label10.Left = (TabControl1.Width / 2) - (Label10.Width / 2)
        ProgressBar1.Style = ProgressBarStyle.Blocks
        Call GoGoGadgetiREB()
    End Sub
    Public Sub PrepDFU()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        Label9.Visible = False
        PictureBox5.Visible = False
    End Sub
    Public Sub DFUHelper()
        Label4.Invoke(CType(AddressOf PrepDFU, MethodInvoker))
        ProgressBar1.Value = 0
        Label11.Text = "Searching for DFU..."
        Label11.Visible = True
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee

        Label10.Left = (TabControl1.Width / 2) - (Label10.Width / 2)
        Label10.Visible = True
        Prepare.Visible = True
        Prepare.Text = "Prepare to press Power + Home (5)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to press Power + Home (4)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Text = "Prepare to press Power + Home (3)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Text = "Prepare to press Power + Home (2)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to press Power + Home (1)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Visible = False
        dfuinstructions.Visible = True
        dfuinstructions.Text = "Press the Power + Home Button! (10)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (9)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Press the Power + Home Button! (8)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (7)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Press the Power + Home Button! (6)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Visible = True
        Prepare.Text = "Prepare to release the Power but keep holding Home. (5)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (5)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        Prepare.Text = "Prepare to release the Power but keep holding Home. (4)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (4)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release the Power but keep holding Home. (3)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (3)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        Prepare.Text = "Prepare to release the Power but keep holding Home. (2)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (2)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (1)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Prepare.Text = "Prepare to release the Power but keep holding Home. (1)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Visible = False
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (30)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (29)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (28)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (27)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (26)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (25)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (24)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (23)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (22)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (21)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (20)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (19)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (18)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (17)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (16)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (15)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (14)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (13)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (12)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (11)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (10)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (9)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (8)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (7)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (6)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (5)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (4)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (3)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (2)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (1)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        Call GoGoGadgetCleanup()
        dfuinstructions.Visible = False
        MsgBox("You failed to Enter DFU. Please Try again.", MsgBoxStyle.Critical)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("http://thefirmwareumbrella.blogspot.com")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        SaveToDisk("itunnel.exe", "itunnel.exe")
        Button1.Text = "Restoring Boot-args..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -c " & Quote.Text & "setenv auto-boot true" & Quote.Text
        ExecCmd(cmdline, True)
        Button1.Text = "Saving Environment..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -c " & Quote.Text & "saveenv" & Quote.Text
        ExecCmd(cmdline, True)
        Button1.Text = "Rebooting..."
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -c " & Quote.Text & "reset" & Quote.Text
        ExecCmd(cmdline, True)
        Button1.Text = "Set Auto-Boot True (Fixes 1015 Errors / Recovery Loops)"
        Button1.Enabled = True
    End Sub
    Public Sub run_steaks4uce()
        SaveToDisk("pois0n.exe", "pois0n.exe")
        Label11.Text = "Exploiting with steaks4uce..."
        BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker2.RunWorkerAsync()
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Blocks
        cmdline = Quote.Text & "pois0n.exe" & Quote.Text & " run"
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        Sleep(100)
        MsgBox("Your device is now in a PWNED DFU state (black screen)." & Chr(13) & Chr(13) & "You may now launch iTunes and do SHIFT + Restore" & Chr(13) & "to restore to Custom Firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."
        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
    End Sub
    Public Sub run_limera1n()
        SaveToDisk("pois0n.exe", "pois0n.exe")
        Label11.Text = "Exploiting with limera1n..."
        BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker2.RunWorkerAsync()
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Blocks
        cmdline = Quote.Text & "pois0n.exe" & Quote.Text & " run"
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        Sleep(100)
        MsgBox("Your device is now in a PWNED DFU state (black screen)." & Chr(13) & Chr(13) & "You may now launch iTunes and do SHIFT + Restore" & Chr(13) & "to restore to Custom Firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."
        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
    End Sub
    Public Sub AskforMode()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub
    Private Sub iPhone2Gbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPhone2Gbttn.Click
        iDevice = "iPhone 2G"
        PictureBox5.Visible = False
        Label9.Visible = False
        TabControl1.Visible = True
        OnlineMode = True
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPhone3Gbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPhone3Gbttn.Click
        iDevice = "iPhone 3G"
        PictureBox5.Visible = False
        Label9.Visible = False
        TabControl1.Visible = True
        OnlineMode = True
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPod1Gbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPod1Gbtn.Click
        iDevice = "iPod Touch 1G"
        PictureBox5.Visible = False
        Label9.Visible = False
        TabControl1.Visible = True
        OnlineMode = True
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPhone3GSbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPhone3GSbttn.Click
        iDevice = "iPhone 3GS"
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPhone4btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPhone4btn.Click
        iDevice = "iPhone 4"
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPod2Gbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPod2Gbtn.Click
        iDevice = "iPod Touch 2G"
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPod3Gbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPod3Gbtn.Click
        iDevice = "iPod Touch 3G"
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPod4btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPod4btn.Click
        iDevice = "iPod Touch 4"
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub iPadbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPadbtn.Click
        iDevice = "iPad"
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))
    End Sub
    Private Sub atv2btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atv2btn.Click
        iDevice = "Apple TV 2"
        Label4.Invoke(CType(AddressOf AppleTVDFUHelper, MethodInvoker))
    End Sub
    Public Sub AppleTVDFUHelper()
        Label4.Invoke(CType(AddressOf PrepDFU, MethodInvoker))
        ProgressBar1.Value = 0
        Label11.Text = "Searching for DFU..."
        Label11.Visible = True
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee

        Label10.Left = (TabControl1.Width / 2) - (Label10.Width / 2)
        Label10.Visible = True
        Prepare.Visible = True
        Prepare.Text = "Prepare to hold Menu + Play/Pause (5)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to hold Menu + Play/Pause (4)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Text = "Prepare to hold Menu + Play/Pause (3)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Text = "Prepare to hold Menu + Play/Pause (2)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to hold Menu + Play/Pause (1)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        Prepare.Visible = False
        dfuinstructions.Visible = True
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (10)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (9)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (8)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (7)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (6)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release Menu + Play/Pause! (5)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Prepare.Visible = True
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (5)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release Menu + Play/Pause! (4)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (4)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release Menu + Play/Pause! (3)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (3)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release Menu + Play/Pause! (2)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (2)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release Menu + Play/Pause! (1)"
        Prepare.Left = (TabControl1.Width / 2) - (Prepare.Width / 2)
        Prepare.Visible = False
        dfuinstructions.Text = "Hold the Menu + Play/Pause Buttons! (1)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Prepare.Visible = False
        dfuinstructions.Text = "Release the Menu + Play/Pause Buttons! (Waiting 5s)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Menu + Play/Pause Buttons! (Waiting 4s)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Menu + Play/Pause Buttons! (Waiting 3s)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Menu + Play/Pause Buttons! (Waiting 2s)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Menu + Play/Pause Buttons! (Waiting 1s)"
        dfuinstructions.Left = (TabControl1.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Call GoGoGadgetCleanup()
        dfuinstructions.Visible = False
        MsgBox("You failed to Enter DFU. Please Try again.", MsgBoxStyle.Critical)
    End Sub
    Private Sub BackgroundWorker3_DoWork1(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Do Until InRecovery = True
            'Searching for Recovery...
            console.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (iBoot) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()

                console.Text += (queryObj("Description"))
            Next
            If console.Text.Contains("iBoot") Then
                InRecovery = True
            End If
        Loop
        If UploadediBSS = True Then
            UploadediBSS = False
            If iDevice = "iPhone 3G" Then
                Label4.Invoke(CType(AddressOf Run_iphone3G_exec, MethodInvoker))
            ElseIf iDevice = "iPhone 2G" Then
                Label4.Invoke(CType(AddressOf Run_iphone2G_exec, MethodInvoker))
            ElseIf iDevice = "iPod Touch 1G" Then
                Label4.Invoke(CType(AddressOf Run_ipod1g_exec, MethodInvoker))
            End If
        ElseIf UploadediBEC = True Then
            UploadediBEC = False
            Label4.Invoke(CType(AddressOf GoGoGadget_iBEC, MethodInvoker))
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
