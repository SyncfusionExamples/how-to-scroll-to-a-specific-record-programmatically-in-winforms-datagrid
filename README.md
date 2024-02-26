# How to scroll to a specific record programmatically in WinForms DataGrid (SfDataGrid)
 
## Scroll to a specific record in datagrid

You can programmatically scroll to a specific record in DataGrid using the [SfDataGrid.TableControl.ScrollRows.ScrollInView](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.GridCommon.ScrollAxis.ScrollAxisBase.html?_ga=2.171674912.1225195101.1667794112-766490130.1650530957&_gl=1*uj6anu*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2NzgwMjI0NS4yODYuMS4xNjY3ODAyMzAwLjAuMC4w#Syncfusion_WinForms_GridCommon_ScrollAxis_ScrollAxisBase_ScrollInView_System_Int32_) method. You can get the row index of any record using the [SfDataGrid.TableControl.ResolveToRowIndex](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.DataGridIndexResolver.html?_gl=1*18kqejq*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2NzgwMjI0NS4yODYuMS4xNjY3ODAyNTg0LjAuMC4w&_ga=2.243985541.1225195101.1667794112-766490130.1650530957#Syncfusion_WinForms_DataGrid_DataGridIndexResolver_ResolveToRowIndex_Syncfusion_WinForms_DataGrid_TableControl_Syncfusion_Data_NodeEntry_) method.

In the following example, data grid is scrolled to a record with OrderID value: 10680

## C#

```C#
var record = this.sfDataGrid.View.Records.FirstOrDefault(item => (item.Data as OrderInfo).OrderID == 10680);
 
if (record != null)
{
    this.sfDataGrid.TableControl.ScrollRows.ScrollInView(this.sfDataGrid.TableControl.ResolveToRowIndex(record));
    this.sfDataGrid.TableControl.UpdateScrollBars();
}
```

## VB

``` VB
Dim record = Me.sfDataGrid.View.Records.FirstOrDefault(Function(item) (TryCast(item.Data, OrderInfo)).OrderID = 10680)
 
If record IsNot Nothing Then
 Me.sfDataGrid.TableControl.ScrollRows.ScrollInView(Me.sfDataGrid.TableControl.ResolveToRowIndex(record))
 Me.sfDataGrid.TableControl.UpdateScrollBars()
End If
```