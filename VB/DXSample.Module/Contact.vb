Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace DXSample.Module
	<DefaultClassOptions> _
	Public Class Contact
		Inherits Person
		Implements IOwnedObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _OwnerID As Integer
		<MemberDesignTimeVisibility(False)> _
		Public Property OwnerID() As Integer Implements IOwnedObject.OwnerID
			Get
				Return _OwnerID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("OwnerID", _OwnerID, value)
			End Set
		End Property

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			OwnerID = CInt(Fix(SecuritySystem.CurrentUserId))
		End Sub
	End Class
End Namespace
