Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Data.Filtering

Namespace DXSample.Module
	Partial Public Class FilterByUserController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewType = ViewType.ListView
			TargetObjectType = GetType(IOwnedObject)
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			If Not(CType(SecuritySystem.CurrentUser, BasicUser)).IsAdministrator Then
				CType(View, ListView).CollectionSource.Criteria("ByUser") = CriteriaOperator.Parse("OwnerID = ?", SecuritySystem.CurrentUserId)
			End If
		End Sub
	End Class
End Namespace
