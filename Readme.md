<!-- default file list -->
*Files to look at*:

* [UnboundRow.cs](./CS/DXApplication3/CustomDescriptor/UnboundRow.cs) (VB: [UnboundRow.vb](./VB/DXApplication3/CustomDescriptor/UnboundRow.vb))
* [UnboundRowHelper.cs](./CS/DXApplication3/CustomDescriptor/UnboundRowHelper.cs) (VB: [UnboundRowHelper.vb](./VB/DXApplication3/CustomDescriptor/UnboundRowHelper.vb))
* [Form1.cs](./CS/DXApplication3/Form1.cs) (VB: [Form1.vb](./VB/DXApplication3/Form1.vb))
* [Program.cs](./CS/DXApplication3/Program.cs) (VB: [Program.vb](./VB/DXApplication3/Program.vb))
<!-- default file list end -->
# How to implement unbound rows in PropertyGridControl


<p>By default, unbound rows are not supported by PropertyGridControl. So, you can use <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraVerticalGrid.VGridControl">VGridControl</a> to display them.<br />
However, PropertyGridControl allows you to provide custom property descriptors via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraVerticalGridPropertyGridControl_CustomPropertyDescriptorstopic">CustomDescriptors Event</a>. So, you can implement the same functionality by creating a custom property descriptor that will store values for properties that do not present in the selected object.</p><p>This example demonstrates how this solution can be implemented.</p>

<br/>


