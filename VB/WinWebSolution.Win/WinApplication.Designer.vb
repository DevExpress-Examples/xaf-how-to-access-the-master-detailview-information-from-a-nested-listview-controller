Namespace WinWebSolution.Win
    Partial Public Class WinWebSolutionWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New WinWebSolution.Module.WinWebSolutionModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.fileAttachmentsWindowsFormsModule1 = New DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=WinWebSolution;Integrated Security=SSPI;Pooli" & "ng=false"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' WinWebSolutionWindowsFormsApplication
            ' 
            Me.ApplicationName = "WinWebSolution"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.fileAttachmentsWindowsFormsModule1)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As WinWebSolution.Module.WinWebSolutionModule
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private fileAttachmentsWindowsFormsModule1 As DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule
    End Class
End Namespace
