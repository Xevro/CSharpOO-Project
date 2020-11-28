using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Presentation : Form
    {

        public Presentation()
        {
            InitializeComponent();
            //cbxStatus.DataSource = Enum.GetValues(typeof(status));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dataGrid.Rows.Insert(0, txtCode.Text, txtName.Text, txtQuantity.Text, cbxStatus.SelectedItem);
        }

    }
}
