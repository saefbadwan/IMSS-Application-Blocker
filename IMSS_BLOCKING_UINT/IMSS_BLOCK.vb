Public Class IMSS_BLOCK
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_Password_TextBox.Focus()
    End Sub
    Private _IMSS_TARGET As String = String.Empty
    Public WriteOnly Property _IMSS_SET_TARGET As String
        Set(ByVal _IMSS_STATUS As String)
            _IMSS_TARGET = _IMSS_STATUS
        End Set
    End Property
    Private Sub _IMSS_SET_PASSWORD(ByVal _IMSS_TARGET_NAME As String, ByVal _IMSS_TARGET_PASSWORD As String)
        If Not IMSS_REGEDIT._IMSS_CheckIfRegistryValueExsits("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun-", _IMSS_TARGET_NAME) Then
            IMSS_REGEDIT._IMSS_CreateRegistrValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun-", _IMSS_TARGET_NAME, _IMSS_TARGET_PASSWORD)
        End If
    End Sub
    Private Sub _IMSS_SET_TARGET_VAR(ByVal _IMSS_TARGET_NAME As String, ByVal _IMSS_TARGET_FILENAME As String)
        If IMSS_REGEDIT._IMSS_CheckIfRegistryValueExsits("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", _IMSS_TARGET_NAME) Then


        Else
            _IMSS_SET_PASSWORD(_IMSS_ENCRYPTION._IMSS_Encrypt(_IMSS_TARGET, _IMSS_Password_TextBox.Text), _IMSS_ENCRYPTION._IMSS_Encrypt(_IMSS_Password_TextBox.Text, _IMSS_Password_TextBox.Text))
            IMSS_REGEDIT._IMSS_CreateRegistrValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", _IMSS_TARGET_NAME, _IMSS_TARGET_FILENAME)
        End If
    End Sub
    Private Sub _IMSS_Block_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Block_Button.Click
        If Not String.IsNullOrEmpty(_IMSS_Password_TextBox.Text) And Not String.IsNullOrEmpty(_IMSS_Confrim_TextBox.Text) _
            And _IMSS_Password_TextBox.Text.Equals(_IMSS_Confrim_TextBox.Text) Then
            If Not String.IsNullOrEmpty(_IMSS_TARGET) Then
                If IO.File.Exists(_IMSS_TARGET) Then
                    _IMSS_SET_TARGET_VAR(_IMSS_TARGET, IO.Path.GetFileName(_IMSS_TARGET))
                    MainWindow._IMSS_AddFromList(_IMSS_TARGET)
                    Me.ControlBox = False
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    Me.MinimumSize = Nothing : Me.MaximumSize = Nothing
                    Me.Size = New Size(0, 0)
                    MessageBox.Show("Application has been blocked successfully , application block will be effective after the first restart process !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Close()
                Else
                    MessageBox.Show("File could not be found !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Else
                Me.Close()
            End If
        Else
            MessageBox.Show("Check your inserted password !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            _IMSS_Password_TextBox.Clear()
            _IMSS_Confrim_TextBox.Clear()
        End If
    End Sub

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub
End Class