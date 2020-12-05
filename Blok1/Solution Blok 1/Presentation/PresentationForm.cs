using Globals;
using Logic;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Presentation : Form
    {
        Inventory inv = new Inventory();
        public Presentation()
        {
            InitializeComponent();

            foreach (var item in Enum.GetNames(typeof(Status)))
            {
                cbxStatus.Items.Add(item);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.dataGrid.Rows.Clear();
            var item = new Product(txtCode.Text, txtName.Text, int.Parse(txtQuantity.Text), (Status)Enum.Parse(typeof(Status), cbxStatus.Text));
            inv.AddProduct(item);
            foreach (var product in inv.Products)
            {
                this.dataGrid.Rows.Insert(0, product.ProductCode, product.ProductName, product.ProductQuantity, product.ProductStatus);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            inv.ExportData();
        }
    }
}
