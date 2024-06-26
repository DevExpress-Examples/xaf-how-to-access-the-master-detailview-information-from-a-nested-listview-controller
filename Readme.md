<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128586932/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1012)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to access the master DetailView information from a nested ListView Controller


<p>This example shows how retrieve master detail view information from the controller for the nested list view. In particular, here we need to know the ID of the parent detail view to adjust our logic in the controller respectively.<br> There are MasterDetailViewControllerBase and NestedListViewControllerBase controllers that allow you to achieve this task. Your should inherit your controllers for nested list views from the last base controller, if you want to have a MasterDetailViewId for them.<br> In this instance, the MasterDetailViewControllerBase will provide the required parent view ID for it.<br><br><strong>See Also:</strong></p>
<p>
<a href="https://github.com/DevExpress-Examples/how-to-access-the-master-object-from-the-nested-list-view-e950">E950</a><br>
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument3161">How to: Access the Master Object from the Nested List View</a><br> <a href="https://www.devexpress.com/Support/Center/p/Q138613">Platform Independent way to determine Parent DetailView</a><br>
<a href="https://www.devexpress.com/Support/Center/p/KA18895">FAQ: How to traverse and customize XAF View items and their underlying controls</a> (describes an alternative approach with a Controller for the master DetailView that accesses its nested ListPropertyEditor)</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-access-the-master-detailview-information-from-a-nested-listview-controller&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-access-the-master-detailview-information-from-a-nested-listview-controller&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
