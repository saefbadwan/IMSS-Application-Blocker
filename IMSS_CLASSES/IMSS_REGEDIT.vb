Imports Microsoft.Win32

Public Class IMSS_REGEDIT
    Public Shared Sub _IMSS_CreateRegistrValue(ByVal _IMSS_TARGET As String, ByVal _IMSS_TARGET_NAME As String, ByVal _IMSS_TARGET_VALUE As String)
        Try : My.Computer.Registry.SetValue(_IMSS_TARGET, _IMSS_TARGET_NAME, _IMSS_TARGET_VALUE) : Catch : End Try
    End Sub
    Public Shared Function _IMSS_CheckIfRegeditKeyExsits(ByVal _IMSS_TARGET As String) As Boolean
        Dim regKey As Object = My.Computer.Registry.CurrentUser.OpenSubKey(_IMSS_TARGET)
        If Not regKey Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function _IMSS_CheckIfRegistryValueExsits(ByVal _IMSS_TARGET As String, ByVal _IMSS_TARGET_VALUE As String)
        If Not My.Computer.Registry.GetValue(_IMSS_TARGET, _IMSS_TARGET_VALUE, Nothing) Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub _IMSS_CREATE_REGISTRY_KEY(ByVal _IMSS_TARGET As String, ByVal _IMSS_KeyName As String)
        Try
            Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey(_IMSS_TARGET, True)
            regKey.CreateSubKey(_IMSS_KeyName) : regKey.Close()
        Catch : End Try
    End Sub
    Public Shared Sub _IMSS_SetDWORDValue(ByVal _IMSS_TARGET As String, ByVal _IMSS_KeyName As String, ByVal _IMSS_KeyValue As Integer)
        Try
            Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey(_IMSS_TARGET, True)
            If IsNumeric(_IMSS_KeyValue) Then
                regKey.SetValue(_IMSS_KeyName, CDbl(_IMSS_KeyValue), RegistryValueKind.DWord)
            End If
        Catch : End Try
    End Sub
End Class
