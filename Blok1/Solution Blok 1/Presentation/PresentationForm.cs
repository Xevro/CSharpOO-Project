using Logic;
using System;
using System.Windows.Forms;
using Globals;

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


        private void btnAdd_Click(object sender, EventArgs e)
        {

            var test = new Globals.Item(txtCode.Text, txtName.Text, Int32.Parse(txtQuantity.Text), cbxStatus.Text);

            this.dataGrid.Rows.Insert(0, test.ProductCode, test.ProductName, test.Quantity, test.Status);
        }

    }
}
