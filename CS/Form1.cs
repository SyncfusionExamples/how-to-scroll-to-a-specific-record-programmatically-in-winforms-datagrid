using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Linq;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Data;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        OrderInfoCollection data;
        public Form1()
        {
            InitializeComponent();
            data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;

            this.sfDataGrid.IndentColumnWidth = 0;


        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (sfDataGrid.View.TopLevelGroup == null)
            {
                var record = this.sfDataGrid.View.Records.FirstOrDefault(item => (item.Data as OrderInfo).OrderID == 10680);

                if (record != null)
                {
                    this.sfDataGrid.TableControl.ScrollRows.ScrollInView(this.sfDataGrid.TableControl.ResolveToRowIndex(record));
                    this.sfDataGrid.TableControl.UpdateScrollBars();
                }
            }
        }
    }
}
