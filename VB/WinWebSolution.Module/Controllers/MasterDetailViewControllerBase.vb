Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Editors

Namespace WinWebSolution.Module
    Public Class MasterDetailViewControllerBase
        Inherits ViewController

        Public Sub New()
            TargetViewType = ViewType.DetailView
            TargetViewNesting = Nesting.Root
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            For Each lpe As ListPropertyEditor In (CType(View, DetailView)).GetItems(Of ListPropertyEditor)()
                If lpe.Frame IsNot Nothing Then
                    CustomizeMasterDetailViewInfo(lpe.Frame)
                Else
                    AddHandler lpe.ControlCreated, AddressOf lpe_ControlCreated
                End If
            Next lpe
        End Sub
        Private Sub lpe_ControlCreated(ByVal sender As Object, ByVal e As EventArgs)
            CustomizeMasterDetailViewInfo(DirectCast(sender, ListPropertyEditor).Frame)
        End Sub
        Private Sub CustomizeMasterDetailViewInfo(ByVal frame As Frame)
            For Each c As Controller In frame.Controllers
                If TypeOf c Is IMasterDetailViewInfo Then
                    DirectCast(c, IMasterDetailViewInfo).AssignMasterDetailViewId(View.Id)
                End If
            Next c
        End Sub
    End Class
End Namespace