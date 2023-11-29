<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128586932/22.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1012)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# XAF - How to access the master Detail View information from a nested List View controller

This example shows how retrieve a master Detail View Frame from the controller for a nested List View. The following controllers show how to accomplish this task:

* [MasterDetailViewController](./CS/EFCore/GetMasterFrameEF/GetMasterFrameEF.Module/Controllers/MasterDetailViewController.cs)
* [NestedListViewFrameController](./CS/EFCore/GetMasterFrameEF/GetMasterFrameEF.Module/Controllers/NestedListViewFrameController.cs)

For demostration purposes, we created [ContactController](./CS/EFCore/GetMasterFrameEF/GetMasterFrameEF.Module/Controllers/NestedListViewFrameController.cs) (inherited from `MasterDetailViewController`) and [MyTaskController](./CS/EFCore/GetMasterFrameEF/GetMasterFrameEF.Module/Controllers/MyTaskController.cs) (inherited from `NestedListViewFrameController`) that show how to change a value of a master detail view Action's caption according to the object selected in the nested list view.

<kbd>![chrome_6sfQlAxVjx](https://user-images.githubusercontent.com/14300209/232497611-742c1cb4-6b9e-4a7c-9236-15fa4f20de0b.gif)</kbd>

## Files to Review

* [ContactController](./CS/EFCore/GetMasterFrameEF/GetMasterFrameEF.Module/Controllers/NestedListViewFrameController.cs)
* [MyTaskController](./CS/EFCore/GetMasterFrameEF/GetMasterFrameEF.Module/Controllers/MyTaskController.cs)

## Documentation

* [How to: Access a Master Detail View and Nested List View Environment](https://docs.devexpress.com/eXpressAppFramework/113161/ui-construction/ways-to-access-ui-elements-and-their-controls/how-to-access-master-detail-view-and-nested-list-view-environment)
* [Ways to Access UI Elements and Their Controls](https://docs.devexpress.com/eXpressAppFramework/120092/ui-construction/ways-to-access-ui-elements-and-their-controls/ways-to-access-ui-elements-and-their-controls)

