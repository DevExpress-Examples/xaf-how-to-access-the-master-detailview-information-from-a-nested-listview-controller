Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace WinWebSolution.Module
    Public Interface IMasterDetailViewInfo
        ReadOnly Property MasterDetailViewId() As String
        Sub AssignMasterDetailViewId(ByVal id As String)
    End Interface
End Namespace
