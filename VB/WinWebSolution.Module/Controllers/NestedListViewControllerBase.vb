Imports System
Imports System.Reflection
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions

Namespace WinWebSolution.Module
    Public MustInherit Class NestedListViewControllerBase
        Inherits ViewController
        Implements IMasterDetailViewInfo

        Public Sub New()
            TargetViewNesting = Nesting.Nested
            TargetViewType = ViewType.ListView
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
        End Sub
        Private masterDetailViewIdCore As String = String.Empty
        #Region "IMasterDetailViewInfo Members"
        Public ReadOnly Property MasterDetailViewId() As String Implements IMasterDetailViewInfo.MasterDetailViewId
            Get
                Return masterDetailViewIdCore
            End Get
        End Property
        Public Sub AssignMasterDetailViewId(ByVal id As String) Implements IMasterDetailViewInfo.AssignMasterDetailViewId
            masterDetailViewIdCore = id
        End Sub
        #End Region
    End Class
End Namespace
