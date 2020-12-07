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

            foreach (var item in Enum.GetNames(typeof(ProductStatus)))
            {
                cbxStatus.Items.Add(item);
            }
            inv.ImportData();
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            try
            {
                var quantity = int.Parse(txtQuantity.Text);
                ProductStatus status = (ProductStatus)Enum.Parse(typeof(ProductStatus), cbxStatus.Text);
                AddData(txtCode.Text, txtName.Text, quantity, status);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void AddData(string code, string name, int quantity, ProductStatus status)
        {
            var item = new Product(code, name, quantity, status);
            inv.AddProduct(item);
            LoadData();
        }

        private void LoadData()
        {
            this.dataGridProducts.Rows.Clear();
            foreach (Product product in inv.Products)
            {
                this.dataGridProducts.Rows.Insert(0, product.ProductCode, product.ProductName, product.ProductQuantity, product.ProductStatus);
            }
            txtCode.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            cbxStatus.SelectedIndex = 0;
        }

        private void ShowError(Exception ex)
        {
            
            System.Windows.Forms.MessageBox.Show(ex.InnerException.Message);  //txtMessage.Tex
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
                DataGridViewRow row = this.dataGridProducts.Rows[e.RowIndex];
                txtCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                cbxStatus.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

    }
}
