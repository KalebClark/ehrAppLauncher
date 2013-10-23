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
Imports System
Imports System.Xml

Module xmlConfig
    Public xmlConfigFile As String = My.Settings.configFile
    Public Function checkFile()
        If (IO.File.Exists(xmlConfigFile)) Then
            Dim Document As XmlReader = New XmlTextReader(xmlConfigFile)
            Return Document
        Else
            MsgBox("Cant find Config File: " + xmlConfigFile + vbCrLf + "Using Default")
            'xmlConfigFile = "y:\it\ealConfig.xml"
            Form1.Close()
            Return False
        End If
    End Function
    Public Sub loadConfig()
        Dim document As XmlReader = checkFile()
        Dim retList As New List(Of String)
        While (document.Read())
            Dim appItem As ListViewItem
            Dim type = document.NodeType
            'if node type was element
            If (type = XmlNodeType.Element) Then
                'if the loop found a <FirstName> tag
                Dim elName As String = document.Name
                If (elName = "app") Then
                    appItem = Form1.lvApps.Items.Add(document.GetAttribute("name"))
                    appItem.SubItems.Add(document.GetAttribute("alias"))
                End If

                If (elName = "x32Path") Then
                    appItem.SubItems.Add(document.ReadElementString)
                End If
                If (elName = "x64Path") Then
                    appItem.SubItems.Add(document.ReadElementString)
                End If
            End If
        End While
        document.Close()
    End Sub
    Public Sub writeConfig()
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True

        ' Create XmlWriter.
        Using writer As XmlWriter = XmlWriter.Create(xmlConfigFile, settings)
            writer.WriteStartDocument()
            writer.WriteStartElement("apps") ' Root.
            
            For Each lvItem In Form1.lvApps.Items
                writer.WriteStartElement("app")
                writer.WriteAttributeString("name", lvItem.subitems(0).text)
                writer.WriteAttributeString("alias", lvItem.subitems(1).text)
                writer.WriteElementString("x32Path", lvItem.subitems(2).text)
                writer.WriteElementString("x64Path", lvItem.subitems(3).text)
                writer.WriteEndElement()
            Next

        End Using

    End Sub

End Module
