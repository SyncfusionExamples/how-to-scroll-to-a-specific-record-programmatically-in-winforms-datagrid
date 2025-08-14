# How to scroll to a specific record programmatically in datagrid?

## About the example 

This example illustrate how to scroll programmatically to a specific record which is outside of grid in DataGrid.

You can programmatically scroll to a specific record in [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) using the [SfDataGrid.TableControl.ScrollRows.ScrollInView](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.GridCommon.ScrollAxis.ScrollAxisBase.html#Syncfusion_WinForms_GridCommon_ScrollAxis_ScrollAxisBase_ScrollInView_System_Int32_) method. You can get the row index of any record using the [SfDataGrid.TableControl.ResolveToRowIndex](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.DataGridIndexResolver.html#Syncfusion_WinForms_DataGrid_DataGridIndexResolver_ResolveToRowIndex_Syncfusion_WinForms_DataGrid_TableControl_Syncfusion_Data_NodeEntry_) method.

KB article: https://support.syncfusion.com/kb/article/8531/how-to-scroll-to-a-specific-record-programmatically-in-winforms-datagrid-sfdatagrid