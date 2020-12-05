using Globals;
using Logic;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Presentation : Form
    {
        private readonly Inventory inv = new Inventory();
        public Presentation()
        {
            InitializeComponent();
            txtMessage.Text = "";

            foreach (var item in Enum.GetNames(typeof(Status)))
            {
                cbxStatus.Items.Add(item);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            try
            {
                var quantity = int.Parse(txtQuantity.Text);
                Status status = (Status)Enum.Parse(typeof(Status), cbxStatus.Text);
                AddData(txtCode.Text, txtName.Text, quantity, status);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void AddData(string code, string name, int quantity, Status status)
        {
            var item = new Product(code, name, quantity, status);
            inv.AddProduct(item);
            LoadData();
        }

        private void LoadData()
        {
            this.dataGrid.Rows.Clear();
            foreach (var product in inv.Products)
            {
                this.dataGrid.Rows.Insert(0, product.ProductCode, product.ProductName, product.ProductQuantity, product.ProductStatus);
            }
            txtCode.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            cbxStatus.SelectedIndex = 0;
        }

        private void ShowError(Exception ex)
        {
            txtMessage.Text = ex.Message;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            inv.ImportData();
            LoadData();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            inv.ExportData();
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                txtCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                cbxStatus.SelectedItem = row.Cells[3].Value.ToString();
            }
        }
    }
}
