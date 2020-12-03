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
            var test = new Item(txtCode.Text, txtName.Text, int.Parse(txtQuantity.Text), cbxStatus.Text);
            this.dataGrid.Rows.Insert(0, test.ProductCode, test.ProductName, test.ProductQuantity, test.ProductStatus);
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
