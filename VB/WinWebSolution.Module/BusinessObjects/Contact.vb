Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
    <DefaultClassOptions>
    Public Class Contact
        Inherits Person

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class
End Namespace
