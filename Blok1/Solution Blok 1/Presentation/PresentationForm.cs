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

            foreach (var productStatus in Enum.GetNames(typeof(ProductStatus)))
            {
                CbxStatus.Items.Add(productStatus);
            }
            foreach (var orderStatus in Enum.GetNames(typeof(OrderStatus)))
            {
                CbxOrderStatus.Items.Add(orderStatus);
            }
            inv.ImportData();
            LoadDataToView();
        }

        private void AddData(string code, string name, int quantity, ProductStatus status)
        {
            Product item = new Product(code, name, quantity, status);
            inv.AddProduct(item);
            LoadDataToView();
        }

        private void LoadDataToView()
        {
            this.dataGridProducts.Rows.Clear();
            foreach (Product product in inv.Products)
            {
                this.dataGridProducts.Rows.Insert(0, product.ProductCode, product.ProductName, product.ProductQuantity, product.ProductStatus);
            }
            TxtCode.Text = "";
            TxtName.Text = "";
            TxtQuantity.Text = "";
            CbxStatus.SelectedIndex = 0;
        }
        private void LoadOrdersDataToView()
        {
            this.dataGridOrders.Rows.Clear();
            foreach (Order order in inv.Orders)
            {
                this.dataGridOrders.Rows.Insert(0, order.OrderCode, order.OrderName, order.OrderQuantity, order.OrderStatus);
            }
        }

        private void ShowError(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            //txtMessage.Text
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            try
            {
                var quantity = int.Parse(TxtQuantity.Text);
                ProductStatus status = (ProductStatus)Enum.Parse(typeof(ProductStatus), CbxStatus.Text);
                AddData(TxtCode.Text, TxtName.Text, quantity, status);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            inv.ImportData();
            LoadDataToView();
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
                TxtCode.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();
                TxtQuantity.Text = row.Cells[2].Value.ToString();
                CbxStatus.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridProducts.Rows[selectedrowindex];

                foreach (Product product in inv.Products)
                {
                    if (product.ProductName == Convert.ToString(selectedRow.Cells["Name"].Value))
                    {
                        //- (int) NmrOrderQuantity.Value
                        Order item = new Order(product.ProductCode, product.ProductName, product.ProductQuantity, (OrderStatus)Enum.Parse(typeof(OrderStatus), CbxOrderStatus.Text));
                        inv.AddOrder(item);
                        LoadOrdersDataToView();
                    }
                }
            }
        }
    }
}
