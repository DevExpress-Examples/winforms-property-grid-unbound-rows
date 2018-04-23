# How to implement unbound rows in PropertyGridControl


<p>By default, unbound rows are not supported by PropertyGridControl. So, you can use VGridControl to display them.<br />
However, PropertyGridControl allows you to provide custom property descriptors via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraVerticalGridPropertyGridControl_CustomPropertyDescriptorstopic">CustomDescriptors Event</a>. So, you can implement the same functionality by creating a custom property descriptor that will store values for properties that do not present in the selected object.</p><p>This example demonstrates how this solution can be implemented.</p>

<br/>


