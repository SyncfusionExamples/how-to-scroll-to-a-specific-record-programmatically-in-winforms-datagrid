Imports Microsoft.VisualBasic
Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.DataGrid.Styles
Imports System.Windows.Forms
Imports Syncfusion.WinForms.DataGrid.Enums
Imports System.Linq
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.Data

Namespace GettingStarted
	Partial Public Class Form1
		Inherits Form
		Private data As OrderInfoCollection
		Public Sub New()
			InitializeComponent()
			data = New OrderInfoCollection()
			sfDataGrid.DataSource = data.OrdersListDetails
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim record = Me.sfDataGrid.View.Records.FirstOrDefault(Function(item) (TryCast(item.Data, OrderInfo)).OrderID = 10680)

			If record IsNot Nothing Then
				Me.sfDataGrid.TableControl.ScrollRows.ScrollInView(Me.sfDataGrid.TableControl.ResolveToRowIndex(record))
				Me.sfDataGrid.TableControl.UpdateScrollBars()
			End If
		End Sub
	End Class
End Namespace
