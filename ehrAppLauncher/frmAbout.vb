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
Public Class frmAbout

    Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtGPL.Text = System.IO.File.ReadAllText("c:\ehrAppLauncher\gpl.txt")
        txtGPL.Focus()
        txtGPL.SelectionStart = txtGPL.Text.Length

    End Sub
End Class