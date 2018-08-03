Imports System
Imports System.Reflection
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
    Public Class PhoneNumberNestedListViewController
        Inherits NestedListViewControllerBase

        Private saMasterDetailViewInfoAction As SimpleAction = Nothing
        Public Sub New()
            TargetObjectType = GetType(PhoneNumber)
            saMasterDetailViewInfoAction = New SimpleAction(Me, "MasterDetailViewInfoAction", DevExpress.Persistent.Base.PredefinedCategory.View)
            AddHandler saMasterDetailViewInfoAction.Execute, AddressOf saMasterDetailViewInfoAction_Execute
        End Sub
        Private Sub saMasterDetailViewInfoAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs)
            MasterDetailViewInfo()
        End Sub
        Private Sub MasterDetailViewInfo()
            Console.WriteLine(String.Format("MasterViewId = '{0}'", Me.MasterDetailViewId))
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler View.ControlsCreated, AddressOf View_ControlsCreated
        End Sub
        Private Sub View_ControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
            MasterDetailViewInfo()
        End Sub
    End Class
End Namespace
