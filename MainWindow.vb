' بسم الله الرحمن الرحيم

Imports Microsoft.Win32
Imports ComponentOwl.BetterListView
Imports System.Runtime.InteropServices

Public Class MainWindow
#Region "IMSS ResizeImage "
    Private Function _IMSS_ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)
        Return _IMSS_ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Private Function _IMSS_ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver
                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using
        Return bmDest
    End Function
#End Region
#Region "IMSS File Size Type"
    Private Function _IMSS_FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function
#End Region
#Region "IMSS File Properties Show Dialog Var"
    <DllImport("Shell32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function
    Private Const SEE_MASK_INVOKEIDLIST = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS = &H40
    Private Const SEE_MASK_FLAG_NO_UI = &H400
    Public Const SW_SHOW As Short = 5
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_SetupOnLoadVar()
        _IMSS_SetupRegistryEditorVar()
        _IMSS_SETUP_PASSWD_SECTION()

    End Sub
    Private Sub _IMSS_SetupOnLoadVar()
        _IMSS_AddApplications_OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        _IMSS_AddApplications_OpenFile.Filter = "All Applications (*.*)|*.exe;*.bat;*.com;*.scr;*.pif;*.cmd"
    End Sub
#Region "IMSS REGISTRY FUNCTIONS UINT"
    Private Sub _IMSS_SETUP_PASSWD_SECTION()
        If Not IMSS_REGEDIT._IMSS_CheckIfRegeditKeyExsits("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun-") Then
            IMSS_REGEDIT._IMSS_CREATE_REGISTRY_KEY("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "DisallowRun-")
        End If
    End Sub
    Private Sub _IMSS_SetupRegistryEditorVar()
        On Error GoTo _IMSS_ONERROR
        If IMSS_REGEDIT._IMSS_CheckIfRegeditKeyExsits("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer") Then
            If IMSS_REGEDIT._IMSS_CheckIfRegistryValueExsits("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "DisallowRun") Then
                If IMSS_REGEDIT._IMSS_CheckIfRegeditKeyExsits("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun") Then
                    _IMSS_LoadBlockedApplicationsAndProcesses()
                Else
                    IMSS_REGEDIT._IMSS_CREATE_REGISTRY_KEY("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "DisallowRun")
                    _IMSS_SetupRegistryEditorVar()
                End If
            Else
                IMSS_REGEDIT._IMSS_SetDWORDValue("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "DisallowRun", 1)
                _IMSS_SetupRegistryEditorVar()
            End If
        Else
            IMSS_REGEDIT._IMSS_CREATE_REGISTRY_KEY("Software\Microsoft\Windows\CurrentVersion\Policies", "Explorer")
            _IMSS_SetupRegistryEditorVar()
        End If
_IMSS_ONERROR:
        Exit Sub
    End Sub
#End Region
#Region "IMSS ADD TO LISTS"
    Private Function _IMSS_CheckIfItemsIsExsits(ByRef _IMSS_TARGET As String) As Boolean
        Dim _IMSS_STATUS As Boolean = False
        For i As Integer = 0 To _IMSS_APPLICATIONS_LISTVIEW.Items.Count - 1 Step 1
            If _IMSS_APPLICATIONS_LISTVIEW.Items(i).Text = IO.Path.GetFileNameWithoutExtension(_IMSS_TARGET) Then
                If _IMSS_APPLICATIONS_LISTVIEW.Items(i).SubItems(3).Text = _IMSS_TARGET Then
                    _IMSS_STATUS = True
                End If
            End If
        Next : Return _IMSS_STATUS
    End Function
    Public Sub _IMSS_RemoveFromList(ByVal _IMSS_TARGET As String)
        _IMSS_APPLICATIONS_LISTVIEW.BeginEdit()
        If _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(3).Text = _IMSS_TARGET Then
            _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).Key = "_IMSS_UNBLOCKED"
            With _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(1)
                .Text = "Application Allowed"
                .Image = My.Resources._IMSS_GreenCheckMark_Icon_16x16
                .ForeColor = Color.Green
            End With
        End If
        _IMSS_APPLICATIONS_LISTVIEW.EndEdit()
    End Sub
    Public Sub _IMSS_AddFromList(ByVal _IMSS_TARGET As String)
        _IMSS_APPLICATIONS_LISTVIEW.BeginEdit()
        If _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(3).Text = _IMSS_TARGET Then
            _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).Key = "_IMSS_BLOCKED"
            With _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(1)
                .Text = "Application Blocked"
                .Image = My.Resources._IMSS_ApplicationBlocked_Icon_16x16
                .ForeColor = Color.Red
            End With
        End If
        _IMSS_APPLICATIONS_LISTVIEW.EndEdit()
    End Sub
    Public Sub _IMSS_ADD_TO_APPLICATION_LIST(ByVal _IMSS_TARGET As String, ByVal _IMSS_STATUS As Boolean)
        If Not _IMSS_CheckIfItemsIsExsits(_IMSS_TARGET) Then
            With _IMSS_APPLICATIONS_LISTVIEW.Items.Add(IO.Path.GetFileNameWithoutExtension(_IMSS_TARGET))
                .UseItemStyleForSubItems = False
                .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_TARGET).ToBitmap(), 16, 16)
                If _IMSS_STATUS = True Then
                    .Key = "_IMSS_BLOCKED"
                    With .SubItems.Add("Application Blocked")
                        .Image = My.Resources._IMSS_ApplicationBlocked_Icon_16x16
                        .ForeColor = Color.Red
                    End With
                Else
                    .Key = "_IMSS_UNBLOCKED"
                    With .SubItems.Add("Application Allowed")
                        .Image = My.Resources._IMSS_GreenCheckMark_Icon_16x16
                        .ForeColor = Color.Green
                    End With
                End If
                .SubItems.Add(_IMSS_GetFileDescription(_IMSS_TARGET))
                .SubItems.Add(_IMSS_TARGET)
                .SubItems.Add(_IMSS_FormatFileSize(New IO.FileInfo(_IMSS_TARGET).Length))
            End With : _IMSS_CheckListViewItemsStatus()
        End If
    End Sub
    Private Sub _IMSS_ADD_TO_APPLICATION_LIST_ON_ERROR(ByVal _IMSS_TARGET As String, ByVal _IMSS_TARGET_PATH As String)
        With _IMSS_APPLICATIONS_LISTVIEW.Items.Add(IO.Path.GetFileNameWithoutExtension(_IMSS_TARGET))
            .UseItemStyleForSubItems = False
            .Image = My.Resources._IMSS_EmergencyTap_Icon_16x16
            .Key = "_IMSS_BLOCKED"
            With .SubItems.Add("Application Blocked")
                .Image = My.Resources._IMSS_ApplicationBlocked_Icon_16x16
                .ForeColor = Color.Red
            End With
            .SubItems.Add("file description could not be found !")
            .SubItems.Add(_IMSS_TARGET_PATH)
            .SubItems.Add("0.00")
        End With : _IMSS_CheckListViewItemsStatus()
    End Sub
#End Region
    Private Sub _IMSS_CheckListViewItemsStatus()
        If Not _IMSS_APPLICATIONS_LISTVIEW.Items.Count = 0 Then _IMSS_AddHere_Label.Visible = False Else _IMSS_AddHere_Label.Visible = True
    End Sub
    Private _IMSS_FOUNDED_VALUE As Integer = 0
    Private Sub _IMSS_LoadBlockedApplicationsAndProcesses()
        _IMSS_APPLICATIONS_LISTVIEW.BeginUpdate()
        Dim _IMSS_CurrentUser_RegeditKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun")
        For Each _IMSS_Programs As String In _IMSS_CurrentUser_RegeditKey.GetValueNames()
            _IMSS_FOUNDED_VALUE += 1
            If IO.File.Exists(_IMSS_Programs) Then
                _IMSS_ADD_TO_APPLICATION_LIST(_IMSS_Programs, True)
            Else
                _IMSS_ADD_TO_APPLICATION_LIST_ON_ERROR(_IMSS_Programs, _IMSS_CurrentUser_RegeditKey.GetValue(_IMSS_Programs).ToString())
            End If
        Next
        _IMSS_CheckListViewItemsStatus()
        _IMSS_APPLICATIONS_LISTVIEW.EndUpdate()
        Me.Refresh()
    End Sub
    Private Sub _IMSS_ApplicationList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ApplicationList.Click
        _IMSS_AddApplications.Visible = True
        _IMSS_AddProcesses.Visible = False
        _IMSS_CheckListViewItemsStatus()
    End Sub

    Private Sub _IMSS_ProcessesList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ProcessesList.Click
        _IMSS_AddApplications.Visible = False
        _IMSS_AddProcesses.Visible = True
        _IMSS_AddProcesses.Location = _IMSS_AddApplications.Location
        _IMSS_LoadingImage_Label.Visible = True
        Dim _IMSS_LoadProcesses As New Threading.Thread(AddressOf _IMSS_LoadProcessList)
        _IMSS_LoadProcesses.IsBackground = True
        _IMSS_LoadProcesses.Start()
    End Sub

    Private Sub _IMSS_LoadProcessList()
        If _IMSS_PROCESSES_LISTVIEW.InvokeRequired = True Then
            _IMSS_PROCESSES_LISTVIEW.Invoke(New MethodInvoker(AddressOf _IMSS_LoadProcessList))
        Else
            _IMSS_PROCESSES_LISTVIEW.Items.Clear()
            _IMSS_PROCESSES_LISTVIEW.BeginUpdate()
            For Each _IMSS_Process In Process.GetProcesses()
                If Not _IMSS_Process.ProcessName.Contains("System") And Not _IMSS_Process.ProcessName.Contains("Idle") Then
                    With _IMSS_PROCESSES_LISTVIEW.Items.Add(_IMSS_Process.ProcessName)
                        Try : With .SubItems.Add(IO.Path.GetFileName(_IMSS_Process.Modules(0).FileName))
                                .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_Process.Modules(0).FileName).ToBitmap(), 16, 16)
                            End With : Catch : End Try
                        Try : .SubItems.Add(_IMSS_Process.Modules(0).FileName) : Catch : End Try
                        Try : .SubItems.Add(_IMSS_Process.Modules(0).FileVersionInfo.FileDescription) : Catch : End Try
                    End With
                End If
            Next _IMSS_Process : _IMSS_LoadingImage_Label.Visible = False
            _IMSS_PROCESSES_LISTVIEW.EndUpdate()
        End If
    End Sub

    Private Function _IMSS_GetFileDescription(ByVal _IMSS_TARGET As String) As String
        Try
            Dim _IMSS_GetFileInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(_IMSS_TARGET)
            If String.IsNullOrEmpty(_IMSS_GetFileInfo.FileDescription) Then
                Return "Application has no description"
            Else
                Return _IMSS_GetFileInfo.FileDescription
            End If
        Catch : Return "Error while geting file description" : End Try
    End Function
    Private Sub _IMSS_AddApplications_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddApplications.Click
        If _IMSS_AddApplications_OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IO.File.Exists(_IMSS_AddApplications_OpenFile.FileName) Then
                If IMSS_REGEDIT._IMSS_CheckIfRegistryValueExsits("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", _IMSS_AddApplications_OpenFile.FileName) Then
                    _IMSS_ADD_TO_APPLICATION_LIST(_IMSS_AddApplications_OpenFile.FileName, True)
                Else
                    _IMSS_ADD_TO_APPLICATION_LIST(_IMSS_AddApplications_OpenFile.FileName, False)
                End If
                If Not _IMSS_APPLICATIONS_LISTVIEW.Items.Count = 0 Then _IMSS_AddHere_Label.Visible = False Else _IMSS_AddHere_Label.Visible = True
            Else
                MessageBox.Show("File could not be found !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub _IMSS_APPLICATION_LIST_ContextMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IMSS_APPLICATION_LIST_ContextMenu.Opening
        If Not _IMSS_APPLICATIONS_LISTVIEW.SelectedItems.Count = 0 Then
            If _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).Key = "_IMSS_BLOCKED" Then
                BlockApplicationToolStripMenuItem.Visible = False
                UnblockApplicationToolStripMenuItem.Visible = True
            Else
                BlockApplicationToolStripMenuItem.Visible = True
                UnblockApplicationToolStripMenuItem.Visible = False
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ApplicationLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationLocationToolStripMenuItem.Click
        Try
            Process.Start(IO.Path.GetDirectoryName(_IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(3).Text))
        Catch : End Try
    End Sub

    Private Sub BlockApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockApplicationToolStripMenuItem.Click
        Dim _IMSS_Block As New IMSS_BLOCK
        With _IMSS_Block
            ._IMSS_SET_TARGET = _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(3).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub UnblockApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnblockApplicationToolStripMenuItem.Click
        Dim _IMSS_UnBlock As New IMSS_UNBLOCK
        With _IMSS_UnBlock
            ._IMSS_SET_TARGET = _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(3).Text
            .ShowDialog()
        End With
    End Sub

    Private Sub _IMSS_AddProcesses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddProcesses.Click
        If Not _IMSS_PROCESSES_LISTVIEW.Items.Count = 0 Then
            If Not _IMSS_PROCESSES_LISTVIEW.SelectedItems.Count = 0 Then
                If IO.File.Exists(_IMSS_PROCESSES_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                    _IMSS_ADD_TO_APPLICATION_LIST(_IMSS_PROCESSES_LISTVIEW.SelectedItems(0).SubItems(2).Text, False)
                    _IMSS_ApplicationList_Click(Nothing, Nothing)
                    _IMSS_MainTap.SelectedTab = _IMSS_ApplicationList
                Else
                    _IMSS_PROCESSES_LISTVIEW.SelectedItems(0).Remove()
                End If
            End If
        End If
    End Sub

    Private Sub _IMSS_PROCESSES_LISTVIEW_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _IMSS_PROCESSES_LISTVIEW.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            _IMSS_AddProcesses_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListToolStripMenuItem.Click
        Try
            _IMSS_APPLICATIONS_LISTVIEW.Items.Clear()
            _IMSS_CheckListViewItemsStatus()
        Catch : End Try
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        If Not _IMSS_APPLICATIONS_LISTVIEW.SelectedItems.Count = 0 Then
            Try : _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).Remove() : _IMSS_CheckListViewItemsStatus() : Catch : End Try
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        If Not _IMSS_APPLICATIONS_LISTVIEW.Items.Count = 0 Then
            If Not _IMSS_APPLICATIONS_LISTVIEW.SelectedItems.Count = 0 Then
                On Error GoTo _IMSS_ON_ERROR
                Dim sei As New SHELLEXECUTEINFO
                sei.cbSize = Marshal.SizeOf(sei)
                sei.lpVerb = "properties"
                sei.lpFile = _IMSS_APPLICATIONS_LISTVIEW.SelectedItems(0).SubItems(3).Text
                sei.nShow = SW_SHOW
                sei.fMask = SEE_MASK_INVOKEIDLIST
                If Not ShellExecuteEx(sei) Then
                    Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
_IMSS_ON_ERROR:
                ' MessageBox.Show("Pleas select item to show it's propertis !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub
End Class
