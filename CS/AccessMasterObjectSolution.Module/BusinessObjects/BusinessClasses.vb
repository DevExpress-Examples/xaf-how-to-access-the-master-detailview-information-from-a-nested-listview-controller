Imports System

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace AccessMasterObjectSolution.Module
    <DefaultClassOptions>
    Public Class MyPerson
        Inherits Person

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <Association("Person-Tasks", GetType(MyTask))>
        Public ReadOnly Property Tasks() As XPCollection
            Get
                Return GetCollection("Tasks")
            End Get
        End Property
    End Class
    <DefaultClassOptions>
    Public Class MyTask
        Inherits Task

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
'INSTANT VB NOTE: The field myPerson was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private _myPerson As MyPerson
        <Association("Person-Tasks", GetType(MyPerson))>
        Public Property MyPerson() As MyPerson
            Get
                Return _myPerson
            End Get
            Set(ByVal value As MyPerson)
                SetPropertyValue("MyPerson", _myPerson, value)
            End Set
        End Property
    End Class
End Namespace
