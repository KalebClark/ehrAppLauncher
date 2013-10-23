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
Public Class Form1
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (btnAdd.Text = "Add") Then
            Dim lvi As ListViewItem
            For Each lvi In lvApps.Items
                If txtAlias.Text = lvi.SubItems(1).Text Then
                    MsgBox("Alias already Exists. Please use unique alias")
                    Return
                End If
            Next
            Dim newAppItem As ListViewItem = lvApps.Items.Add(txtAppName.Text)
            newAppItem.SubItems.Add(txtAlias.Text)
            newAppItem.SubItems.Add(txt32BitPath.Text)
            newAppItem.SubItems.Add(txt64BitPath.Text)
            txtAppName.Clear()
            txtAlias.Clear()
            txt32BitPath.Clear()
            txt64BitPath.Clear()

            'xmlConfig.writeConfig()
        ElseIf (btnAdd.Text = "Update") Then

            lvApps.SelectedItems(0).SubItems(0).Text = txtAppName.Text
            lvApps.SelectedItems(0).SubItems(1).Text = txtAlias.Text
            lvApps.SelectedItems(0).SubItems(2).Text = txt32BitPath.Text
            lvApps.SelectedItems(0).SubItems(3).Text = txt64BitPath.Text

            txtAppName.Clear()
            txtAlias.Clear()
            txt32BitPath.Clear()
            txt64BitPath.Clear()
            btnAdd.Text = "Add"
            lvApps.Enabled = True
            'xmlConfig.writeConfig()
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Set Properties for listview
        lvApps.FullRowSelect = True

        'check for saved config file
        If (My.Settings.configFile = "") Then
            MsgBox("No Default config. Find the xml file on the server.")
        Else
            xmlConfig.xmlConfigFile = My.Settings.configFile
            txtConfFile.Text = My.Settings.configFile
            xmlConfig.loadConfig()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Load settings into edit fields as long as an app is selected.
        If (lvApps.SelectedItems.Count > 0) Then
            txtAppName.Text = lvApps.SelectedItems(0).SubItems(0).Text
            txtAlias.Text = lvApps.SelectedItems(0).SubItems(1).Text
            txt32BitPath.Text = lvApps.SelectedItems(0).SubItems(2).Text
            txt64BitPath.Text = lvApps.SelectedItems(0).SubItems(3).Text
        End If

        btnAdd.Text = "Update"
        lvApps.Enabled = False


    End Sub

    Private Sub btn32BitDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn32BitDialog.Click
        OpenFileDialog1.ShowDialog()
        txt32BitPath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn64BitDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn64BitDialog.Click
        OpenFileDialog1.ShowDialog()
        txt64BitPath.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lvApps.SelectedItems(0).Remove()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        My.Settings.configFile = xmlConfig.xmlConfigFile
        xmlConfig.writeConfig()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        txtConfFile.Text = OpenFileDialog1.FileName
        xmlConfig.xmlConfigFile = OpenFileDialog1.FileName
        xmlConfig.loadConfig()
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        If (lvApps.SelectedItems.Count = 0) Then
            MsgBox("Select an application...")
            Return
        End If
        Dim arch As String = archFire.getArch()
        Dim appAlias = lvApps.SelectedItems(0).SubItems(1).Text
        archFire.fireApp(appAlias, "")
    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub
End Class
