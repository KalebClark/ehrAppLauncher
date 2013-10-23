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
Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                If My.Application.CommandLineArgs.Count >= 1 Then
                    'Running in command line mode.
                    e.Cancel = True
                    Dim appAlias As String = e.CommandLine(0).ToString
                    Dim argCnt As Integer = e.CommandLine.Count
                    Dim args As String = ""
                    For i As Integer = 1 To argCnt - 1

                        args = args + """" + e.CommandLine(i).ToString + """" + " "
                    Next

                    archFire.fireApp(appAlias, args)

                Else
                    'Running in interactive Mode.
                End If
            Catch ex As Exception

            End Try

        End Sub
    End Class


End Namespace

