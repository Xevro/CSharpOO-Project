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

        private void AddData(int code, string name, int quantity, ProductStatus status)
        {
            Product item = new Product(code, name, quantity, status);
            inv.AddProduct(item);
            LoadDataToView();
        }

        private void LoadDataToView()
        {
            this.dataGridProducts.Rows.Clear();
            foreach (Product product in inv.GetProducts())
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
            foreach (Order order in inv.GetOrders())
            {
                this.dataGridOrders.Rows.Insert(0, order.OrderCode, order.OrderProductCode, order.OrderName, order.OrderQuantity, order.OrderStatus);
            }
        }

        private void ShowError(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            LoadOrdersDataToView();
            LoadDataToView();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            try
            {
                int quantity = int.Parse(TxtQuantity.Text);
                ProductStatus status = (ProductStatus)Enum.Parse(typeof(ProductStatus), CbxStatus.Text);
                AddData(int.Parse(TxtCode.Text), TxtName.Text, quantity, status);
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
            try
            {
                PlaceOrder();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void PlaceOrder()
        {
            if (dataGridProducts.SelectedCells.Count > 0 && CbxOrderStatus.SelectedItem != null)
            {
                DataGridViewRow selectedRow = dataGridProducts.Rows[dataGridProducts.SelectedCells[0].RowIndex];

                foreach (Product product in inv.GetProducts())
                {
                    if (product.ProductCode == (int)selectedRow.Cells[0].Value)
                    {
                        Order order = new Order(product.ProductCode, product.ProductName, (int)NmrOrderQuantity.Value, (OrderStatus)Enum.Parse(typeof(OrderStatus), CbxOrderStatus.Text));
                        inv.AddOrder(order, product, (int)NmrOrderQuantity.Value);
                    }
                }
                LoadOrdersDataToView();
                LoadDataToView();
            }
            else
            {
                throw new Exception("Please select an item and/or an order status!");
            }
        }
    }
}
