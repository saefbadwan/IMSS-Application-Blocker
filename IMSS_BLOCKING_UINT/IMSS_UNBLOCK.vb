Imports Microsoft.Win32

Public Class IMSS_UNBLOCK
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
    Private Sub _IMSS_Block_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UnBlock_Button.Click
        If Not String.IsNullOrEmpty(_IMSS_Password_TextBox.Text) Then
            Dim _IMSS_CurrentUser_RegeditKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun-")
            For Each _IMSS_Programs As String In _IMSS_CurrentUser_RegeditKey.GetValueNames()
                If _IMSS_ENCRYPTION._IMSS_Encrypt(_IMSS_TARGET, _IMSS_Password_TextBox.Text).ToString().Equals(_IMSS_Programs) Then
                    If _IMSS_ENCRYPTION._IMSS_Encrypt(_IMSS_Password_TextBox.Text, _IMSS_Password_TextBox.Text).ToString().Equals(_IMSS_CurrentUser_RegeditKey.GetValue(_IMSS_Programs).ToString()) Then
                        MainWindow._IMSS_RemoveFromList(_IMSS_ENCRYPTION._IMSS_Decrypt(_IMSS_Programs, _IMSS_Password_TextBox.Text))
                        My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", True).DeleteValue(_IMSS_ENCRYPTION._IMSS_Decrypt(_IMSS_Programs, _IMSS_Password_TextBox.Text))
                        My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun-", True).DeleteValue(_IMSS_Programs)
                        Me.Close()
                    Else
                        MessageBox.Show("Incorect Password !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        _IMSS_Password_TextBox.Clear()
                    End If
                Else
                    'MessageBox.Show("Incorect Password !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    _IMSS_Password_TextBox.Clear()
                End If
            Next
        Else
            MessageBox.Show("Check your inserted password !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            _IMSS_Password_TextBox.Clear()
        End If
    End Sub

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub
End Class