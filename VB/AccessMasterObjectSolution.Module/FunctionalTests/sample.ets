;#DropDB AccessMasterObjectSolutionEasyTest

#Application AccessMasterObjectSolution.Win
#Application AccessMasterObjectSolution.Web
#IfDef AccessMasterObjectSolution.Win

*Action About...
 
*Action OK

#EndIf

#IfDef AccessMasterObjectSolution.Web
!Action Navigation(My Details)
#EndIf
