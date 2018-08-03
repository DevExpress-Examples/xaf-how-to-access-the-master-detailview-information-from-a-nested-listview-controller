;#DropDB WinWebSolutionEasyTest

#Application WinWebSolution.Win
#Application WinWebSolution.Web
#IfDef WinWebSolution.Win

*Action About...
 
*Action OK

#EndIf

#IfDef WinWebSolution.Web
!Action Navigation(My Details)
#EndIf
