<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638833/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3004)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Property Grid - How to implement unbound rows

The WinForms Property Grid Control does not support unbound rows out of the box. This example demonstrates how to implement this functionality using custom property descriptors. See the implementation of the [CustomPropertyDescriptors](https://docs.devexpress.com/WindowsForms/DevExpress.XtraVerticalGrid.PropertyGridControl.CustomPropertyDescriptors) event handler:

```csharp
// Stores property values that are not present in the selected object.
void _PropertyGrid_CustomPropertyDescriptors(object sender, CustomPropertyDescriptorsEventArgs e) {
    if ((sender as PropertyGridControl).SelectedObject == e.Source) {
        PropertyDescriptorCollection properties = e.Properties;
        ArrayList list = new ArrayList(properties);
        list.AddRange(_UnboundRows);
        PropertyDescriptor[] result = new PropertyDescriptor[list.Count];
        list.ToArray().CopyTo(result, 0);
        e.Properties = new PropertyDescriptorCollection(result);
    }
}
```


## Files to Review

* [UnboundRow.cs](./CS/DXApplication3/CustomDescriptor/UnboundRow.cs) (VB: [UnboundRow.vb](./VB/DXApplication3/CustomDescriptor/UnboundRow.vb))
* [UnboundRowHelper.cs](./CS/DXApplication3/CustomDescriptor/UnboundRowHelper.cs) (VB: [UnboundRowHelper.vb](./VB/DXApplication3/CustomDescriptor/UnboundRowHelper.vb))
* [Form1.cs](./CS/DXApplication3/Form1.cs) (VB: [Form1.vb](./VB/DXApplication3/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-property-grid-unbound-rows&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-property-grid-unbound-rows&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
