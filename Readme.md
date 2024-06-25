<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638833/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3004)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [UnboundRow.cs](./CS/DXApplication3/CustomDescriptor/UnboundRow.cs)
* [UnboundRowHelper.cs](./CS/DXApplication3/CustomDescriptor/UnboundRowHelper.cs)
* [Form1.cs](./CS/DXApplication3/Form1.cs)
* [Program.cs](./CS/DXApplication3/Program.cs)
<!-- default file list end -->
# How to implement unbound rows in PropertyGridControl


<p>By default, unbound rows are not supported by PropertyGridControl. So, you can use VGridControl to display them.<br />
However, PropertyGridControl allows you to provide custom property descriptors via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraVerticalGridPropertyGridControl_CustomPropertyDescriptorstopic">CustomDescriptors Event</a>. So, you can implement the same functionality by creating a custom property descriptor that will store values for properties that do not present in the selected object.</p><p>This example demonstrates how this solution can be implemented.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-property-grid-unbound-rows&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-property-grid-unbound-rows&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
