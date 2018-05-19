Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace DXSample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			CreateUser("Sam", "", True)
			CreateUser("John", "", False)
			CreateUser("Paul", "", False)
		End Sub
		Private Sub CreateUser(ByVal name As String, ByVal password As String, ByVal isAdministrator As Boolean)
			Dim BasicUser As BasicUser = Session.FindObject(Of BasicUser)(New BinaryOperator("UserName", name))
			If BasicUser Is Nothing Then
				BasicUser = New BasicUser(Session)
				BasicUser.UserName = name
				BasicUser.FullName = name
			End If
			BasicUser.IsAdministrator = isAdministrator
			BasicUser.SetPassword(password)
			BasicUser.Save()
		End Sub
	End Class
End Namespace
