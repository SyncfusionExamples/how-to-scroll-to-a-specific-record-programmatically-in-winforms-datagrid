# How to scroll to a specific record programmatically in WinForms DataGrid?

## About the example 

This example illustrate how to scroll programmatically to a specific record which is outside of grid in DataGrid.

You can programmatically scroll to a specific record in [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid) using the [ScrollInView](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.GridCommon.ScrollAxis.ScrollAxisBase.html#Syncfusion_WinForms_GridCommon_ScrollAxis_ScrollAxisBase_ScrollInView_System_Int32_) method. You can get the row index of any record using the [ResolveToRowIndex](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.DataGridIndexResolver.html#Syncfusion_WinForms_DataGrid_DataGridIndexResolver_ResolveToRowIndex_Syncfusion_WinForms_DataGrid_TableControl_Syncfusion_Data_NodeEntry_) method.

In the following example, data grid is scrolled to a record with OrderID value: 10680. 
### C#

```c#
var record = this.sfDataGrid.View.Records.FirstOrDefault(item => (item.Data as OrderInfo).OrderID == 10680);
 
if (record != null)
{
   this.sfDataGrid.TableControl.ScrollRows.ScrollInView(this.sfDataGrid.TableControl.ResolveToRowIndex(record));
   this.sfDataGrid.TableControl.UpdateScrollBars();
}
```
### VB
```vb
Dim record = Me.sfDataGrid.View.Records.FirstOrDefault(Function(item) (TryCast(item.Data, OrderInfo)).OrderID = 10680)
 
If record IsNot Nothing Then
 Me.sfDataGrid.TableControl.ScrollRows.ScrollInView(Me.sfDataGrid.TableControl.ResolveToRowIndex(record))
 Me.sfDataGrid.TableControl.UpdateScrollBars()
End If
```
