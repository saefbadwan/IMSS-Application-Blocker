<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_LoadingImage_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_AddProcesses = New System.Windows.Forms.Button()
        Me._IMSS_AddApplications = New System.Windows.Forms.Button()
        Me._IMSS_BuutonPanel = New System.Windows.Forms.Panel()
        Me._IMSS_MainTap = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_AddHere_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_APPLICATIONS_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ApplicationName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ApplicationStatus = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ApplicationDescriptor = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ApplicationPath = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ApplicationSize = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_APPLICATION_LIST_ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BlockApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnblockApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_ApplicationList = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_PROCESSES_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ProcessName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMS_ProcessApplication = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ProcessPath = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ProcessApplicationDescription = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ProcessesList = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_AddApplications_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_BuutonPanel.SuspendLayout()
        CType(Me._IMSS_MainTap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainTap.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me._IMSS_APPLICATIONS_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_APPLICATION_LIST_ContextMenu.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me._IMSS_PROCESSES_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_LoadingImage_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_AddProcesses)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_AddApplications)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_BuutonPanel)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(475, 457)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_LoadingImage_Label
        '
        Me._IMSS_LoadingImage_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LoadingImage_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LoadingImage_Label.Location = New System.Drawing.Point(8, 433)
        Me._IMSS_LoadingImage_Label.Name = "_IMSS_LoadingImage_Label"
        Me._IMSS_LoadingImage_Label.Size = New System.Drawing.Size(124, 15)
        Me._IMSS_LoadingImage_Label.TabIndex = 3
        Me._IMSS_LoadingImage_Label.Text = "Loading processes liast ..."
        Me._IMSS_LoadingImage_Label.Visible = False
        '
        '_IMSS_AddProcesses
        '
        Me._IMSS_AddProcesses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_AddProcesses.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_AddProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_AddProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_AddProcesses.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_AddProcesses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_AddProcesses.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_Add_Icon_16x16
        Me._IMSS_AddProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_AddProcesses.Location = New System.Drawing.Point(223, 425)
        Me._IMSS_AddProcesses.Name = "_IMSS_AddProcesses"
        Me._IMSS_AddProcesses.Size = New System.Drawing.Size(122, 29)
        Me._IMSS_AddProcesses.TabIndex = 2
        Me._IMSS_AddProcesses.Text = "Add Processes"
        Me._IMSS_AddProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_AddProcesses.UseVisualStyleBackColor = True
        Me._IMSS_AddProcesses.Visible = False
        '
        '_IMSS_AddApplications
        '
        Me._IMSS_AddApplications.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_AddApplications.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me._IMSS_AddApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me._IMSS_AddApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_AddApplications.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_AddApplications.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._IMSS_AddApplications.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_RegeditAdd_MainIcon_16x16
        Me._IMSS_AddApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_AddApplications.Location = New System.Drawing.Point(351, 425)
        Me._IMSS_AddApplications.Name = "_IMSS_AddApplications"
        Me._IMSS_AddApplications.Size = New System.Drawing.Size(122, 29)
        Me._IMSS_AddApplications.TabIndex = 1
        Me._IMSS_AddApplications.Text = "Add Apllications"
        Me._IMSS_AddApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._IMSS_AddApplications.UseVisualStyleBackColor = True
        '
        '_IMSS_BuutonPanel
        '
        Me._IMSS_BuutonPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_BuutonPanel.Controls.Add(Me._IMSS_MainTap)
        Me._IMSS_BuutonPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_BuutonPanel.Name = "_IMSS_BuutonPanel"
        Me._IMSS_BuutonPanel.Size = New System.Drawing.Size(475, 423)
        Me._IMSS_BuutonPanel.TabIndex = 1
        '
        '_IMSS_MainTap
        '
        '
        '
        '
        '
        '
        '
        Me._IMSS_MainTap.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me._IMSS_MainTap.ControlBox.MenuBox.Name = ""
        Me._IMSS_MainTap.ControlBox.Name = ""
        Me._IMSS_MainTap.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_MainTap.ControlBox.MenuBox, Me._IMSS_MainTap.ControlBox.CloseBox})
        Me._IMSS_MainTap.Controls.Add(Me.SuperTabControlPanel1)
        Me._IMSS_MainTap.Controls.Add(Me.SuperTabControlPanel2)
        Me._IMSS_MainTap.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainTap.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainTap.Name = "_IMSS_MainTap"
        Me._IMSS_MainTap.ReorderTabsEnabled = True
        Me._IMSS_MainTap.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me._IMSS_MainTap.SelectedTabIndex = 0
        Me._IMSS_MainTap.Size = New System.Drawing.Size(475, 423)
        Me._IMSS_MainTap.TabFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me._IMSS_MainTap.TabIndex = 0
        Me._IMSS_MainTap.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_ApplicationList, Me._IMSS_ProcessesList})
        Me._IMSS_MainTap.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me._IMSS_AddHere_Label)
        Me.SuperTabControlPanel1.Controls.Add(Me._IMSS_APPLICATIONS_LISTVIEW)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(475, 393)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me._IMSS_ApplicationList
        '
        '_IMSS_AddHere_Label
        '
        Me._IMSS_AddHere_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me._IMSS_AddHere_Label.AutoSize = True
        Me._IMSS_AddHere_Label.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me._IMSS_AddHere_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_AddHere_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_AddHere_Label.Location = New System.Drawing.Point(120, 203)
        Me._IMSS_AddHere_Label.Name = "_IMSS_AddHere_Label"
        Me._IMSS_AddHere_Label.Size = New System.Drawing.Size(225, 18)
        Me._IMSS_AddHere_Label.TabIndex = 1
        Me._IMSS_AddHere_Label.Text = "Add application here to block it ..."
        '
        '_IMSS_APPLICATIONS_LISTVIEW
        '
        Me._IMSS_APPLICATIONS_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_APPLICATIONS_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_ApplicationName, Me._IMSS_ApplicationStatus, Me._IMSS_ApplicationDescriptor, Me._IMSS_ApplicationPath, Me._IMSS_ApplicationSize})
        Me._IMSS_APPLICATIONS_LISTVIEW.ContextMenuStrip = Me._IMSS_APPLICATION_LIST_ContextMenu
        Me._IMSS_APPLICATIONS_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_APPLICATIONS_LISTVIEW.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_APPLICATIONS_LISTVIEW.MultiSelect = False
        Me._IMSS_APPLICATIONS_LISTVIEW.Name = "_IMSS_APPLICATIONS_LISTVIEW"
        Me._IMSS_APPLICATIONS_LISTVIEW.Size = New System.Drawing.Size(475, 393)
        Me._IMSS_APPLICATIONS_LISTVIEW.TabIndex = 0
        '
        '_IMSS_ApplicationName
        '
        Me._IMSS_ApplicationName.Name = "_IMSS_ApplicationName"
        Me._IMSS_ApplicationName.Text = "Application Name"
        '
        '_IMSS_ApplicationStatus
        '
        Me._IMSS_ApplicationStatus.Name = "_IMSS_ApplicationStatus"
        Me._IMSS_ApplicationStatus.Text = "Application Status"
        Me._IMSS_ApplicationStatus.Width = 132
        '
        '_IMSS_ApplicationDescriptor
        '
        Me._IMSS_ApplicationDescriptor.Name = "_IMSS_ApplicationDescriptor"
        Me._IMSS_ApplicationDescriptor.Text = "Application Descriptor"
        '
        '_IMSS_ApplicationPath
        '
        Me._IMSS_ApplicationPath.Name = "_IMSS_ApplicationPath"
        Me._IMSS_ApplicationPath.Text = "Application Path"
        '
        '_IMSS_ApplicationSize
        '
        Me._IMSS_ApplicationSize.Name = "_IMSS_ApplicationSize"
        Me._IMSS_ApplicationSize.Text = "Application Size"
        '
        '_IMSS_APPLICATION_LIST_ContextMenu
        '
        Me._IMSS_APPLICATION_LIST_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlockApplicationToolStripMenuItem, Me.UnblockApplicationToolStripMenuItem, Me.ApplicationLocationToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveSelectedToolStripMenuItem, Me.ClearListToolStripMenuItem, Me.ToolStripSeparator2, Me.PropertiesToolStripMenuItem})
        Me._IMSS_APPLICATION_LIST_ContextMenu.Name = "_IMSS_APPLICATION_LIST_ContextMenu"
        Me._IMSS_APPLICATION_LIST_ContextMenu.Size = New System.Drawing.Size(185, 170)
        '
        'BlockApplicationToolStripMenuItem
        '
        Me.BlockApplicationToolStripMenuItem.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_ApplicationBlocked_Icon_16x16
        Me.BlockApplicationToolStripMenuItem.Name = "BlockApplicationToolStripMenuItem"
        Me.BlockApplicationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BlockApplicationToolStripMenuItem.Text = "Block Application"
        '
        'UnblockApplicationToolStripMenuItem
        '
        Me.UnblockApplicationToolStripMenuItem.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_GreenCheckMark_Icon_16x16
        Me.UnblockApplicationToolStripMenuItem.Name = "UnblockApplicationToolStripMenuItem"
        Me.UnblockApplicationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UnblockApplicationToolStripMenuItem.Text = "Unblock Application"
        '
        'ApplicationLocationToolStripMenuItem
        '
        Me.ApplicationLocationToolStripMenuItem.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_OpenFileLocation_Icon_16x16
        Me.ApplicationLocationToolStripMenuItem.Name = "ApplicationLocationToolStripMenuItem"
        Me.ApplicationLocationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ApplicationLocationToolStripMenuItem.Text = "Application Location"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_DeleteButton_Icon_16x16
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ClearListToolStripMenuItem.Text = "Clear List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_SystemProcesses_Icon_16x16
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        '_IMSS_ApplicationList
        '
        Me._IMSS_ApplicationList.AttachedControl = Me.SuperTabControlPanel1
        Me._IMSS_ApplicationList.GlobalItem = False
        Me._IMSS_ApplicationList.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_WindowTap_Icon_16x16
        Me._IMSS_ApplicationList.ImageAlignment = DevComponents.DotNetBar.ImageAlignment.MiddleLeft
        Me._IMSS_ApplicationList.Name = "_IMSS_ApplicationList"
        Me._IMSS_ApplicationList.Text = "Application List"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_PROCESSES_LISTVIEW)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(475, 423)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me._IMSS_ProcessesList
        '
        '_IMSS_PROCESSES_LISTVIEW
        '
        Me._IMSS_PROCESSES_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_PROCESSES_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_ProcessName, Me._IMS_ProcessApplication, Me._IMSS_ProcessPath, Me._IMSS_ProcessApplicationDescription})
        Me._IMSS_PROCESSES_LISTVIEW.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_PROCESSES_LISTVIEW.Name = "_IMSS_PROCESSES_LISTVIEW"
        Me._IMSS_PROCESSES_LISTVIEW.Size = New System.Drawing.Size(475, 423)
        Me._IMSS_PROCESSES_LISTVIEW.TabIndex = 1
        '
        '_IMSS_ProcessName
        '
        Me._IMSS_ProcessName.Name = "_IMSS_ProcessName"
        Me._IMSS_ProcessName.Text = "Process Name"
        Me._IMSS_ProcessName.Width = 134
        '
        '_IMS_ProcessApplication
        '
        Me._IMS_ProcessApplication.Name = "_IMS_ProcessApplication"
        Me._IMS_ProcessApplication.Text = "Process Application"
        Me._IMS_ProcessApplication.Width = 125
        '
        '_IMSS_ProcessPath
        '
        Me._IMSS_ProcessPath.Name = "_IMSS_ProcessPath"
        Me._IMSS_ProcessPath.Text = "Process Application Path"
        Me._IMSS_ProcessPath.Width = 139
        '
        '_IMSS_ProcessApplicationDescription
        '
        Me._IMSS_ProcessApplicationDescription.Name = "_IMSS_ProcessApplicationDescription"
        Me._IMSS_ProcessApplicationDescription.Text = "Process Application Description"
        '
        '_IMSS_ProcessesList
        '
        Me._IMSS_ProcessesList.AttachedControl = Me.SuperTabControlPanel2
        Me._IMSS_ProcessesList.GlobalItem = False
        Me._IMSS_ProcessesList.Image = Global.IMSS_Application_Blocker.My.Resources.Resources._IMSS_FindProcess_Icon_16x16
        Me._IMSS_ProcessesList.Name = "_IMSS_ProcessesList"
        Me._IMSS_ProcessesList.Text = "Processes List"
        '
        '_IMSS_AddApplications_OpenFile
        '
        Me._IMSS_AddApplications_OpenFile.FileName = "All Applications ..."
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 457)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Aplication Blocker"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_BuutonPanel.ResumeLayout(False)
        CType(Me._IMSS_MainTap, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainTap.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        CType(Me._IMSS_APPLICATIONS_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_APPLICATION_LIST_ContextMenu.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me._IMSS_PROCESSES_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_MainTap As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_ApplicationList As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_ProcessesList As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_APPLICATIONS_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_AddApplications As System.Windows.Forms.Button
    Friend WithEvents _IMSS_AddProcesses As System.Windows.Forms.Button
    Friend WithEvents _IMSS_BuutonPanel As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_PROCESSES_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_ApplicationName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ApplicationStatus As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ApplicationDescriptor As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ApplicationPath As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ApplicationSize As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_AddHere_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_AddApplications_OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents _IMSS_APPLICATION_LIST_ContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BlockApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnblockApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_ProcessName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMS_ProcessApplication As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ProcessPath As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ProcessApplicationDescription As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LoadingImage_Label As DevComponents.DotNetBar.LabelX

End Class
