'This file is part of EHR App Launcher

'EHR App Launcher is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'EHR App Launcher is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with EHR App Launcher.  If not, see <http://www.gnu.org/licenses/>.
Imports System.Xml
Module archFire
    Public Function getArch()
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Hardware\Description\System\CentralProcessor\0").GetValue("Identifier").ToString.Contains("x86") Then : Return "32"
        Else : Return "64" : End If
    End Function
    Public Sub fireApp(ByVal appAlias As String, ByVal args As String)
        Dim document As XmlReader = checkFile()
        Dim arch As String = getArch()
        Dim thePath As String = "x" + arch + "Path"
        While (document.Read())
            Dim type = document.NodeType
            Dim ali As String
            If (type = XmlNodeType.Element) Then
                Dim elName As String = document.Name
                If (elName = "app") Then
                    ali = document.GetAttribute("alias")
                End If
                If (elName = thePath) Then
                    If (ali = appAlias) Then

                        Dim firePath As String = document.ReadString
                        Dim startInfo As New ProcessStartInfo
                        startInfo.FileName = firePath
                        startInfo.Arguments = args

                        Process.Start(startInfo)
                    End If
                End If
            End If
        End While
    End Sub
End Module
