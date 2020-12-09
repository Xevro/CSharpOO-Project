using Globals;
using Globals.Exceptions;
using Logic;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Presentation : Form
    {
        private readonly Inventory inv;

        public Presentation(Inventory inventory)
        {
            InitializeComponent();
            inv = inventory;
            txtMessage.Text = "";
            foreach (var orderStatus in Enum.GetNames(typeof(OrderStatus)))
            {
                CbxOrderStatus.Items.Add(orderStatus);
            }
            try
            {
                inv.ImportData();
                LoadDataToView();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void AddProduct(int code, string name, int quantity)
        {
            var item = new Product(code, name, quantity);
            inv.AddProduct(item);
            LoadDataToView();
        }

        private void LoadDataToView()
        {
            this.dataGridProducts.Rows.Clear();
            foreach (var product in inv.GetSortedProducts)
            {
                this.dataGridProducts.Rows.Insert(0, product.ProductCode, product.ProductName, product.ProductQuantity, product.ProductStatus);
            }
            TxtCode.Text = "";
            TxtName.Text = "";
            TxtQuantity.Text = "";
        }
        private void LoadOrdersDataToView()
        {
            this.dataGridOrders.Rows.Clear();
            foreach (var order in inv.GetSortedOrders)
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
                AddProduct(int.Parse(TxtCode.Text), TxtName.Text, quantity);
            }
            catch (Exception ex) when (ex is ProductOutOfstockException || ex is ProductRunningLowOnStockException
            || ex is ProductsDataIsEmptyException || ex is ArgumentOutOfRangeException)
            {
                ShowError(ex);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                inv.ImportData();
                LoadDataToView();
            }
            catch (ImportDataException ex)
            {
                ShowError(ex);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                inv.ExportData();
            }
            catch (ExportDataException ex)
            {
                ShowError(ex);
            }
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.dataGridProducts.Rows[e.RowIndex];
                TxtCode.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();
                TxtQuantity.Text = row.Cells[2].Value.ToString();
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                PlaceOrder();
            }
            catch (Exception ex) when (ex is AddingOrderException || ex is ProductRunningLowOnStockException)
            {
                ShowError(ex);
            }
        }

        private void PlaceOrder()
        {
            if (dataGridProducts.SelectedCells.Count > 0 && CbxOrderStatus.SelectedItem != null)
            {
                AddOrder();
                LoadOrdersDataToView();
                LoadDataToView();
            }
            else
            {
                throw new AddingOrderException("Please select an item and/or an order status!");
            }
        }

        private void AddOrder()
        {
            var selectedRow = dataGridProducts.Rows[dataGridProducts.SelectedCells[0].RowIndex];
            foreach (var product in inv.GetSortedProducts)
            {
                if (product.ProductCode == (int)selectedRow.Cells[0].Value)
                {
                    if (product.ProductQuantity - (int)NmrOrderQuantity.Value >= 0)
                    {
                        var order = new Order(product.ProductCode, product.ProductName, (int)NmrOrderQuantity.Value, (OrderStatus)Enum.Parse(typeof(OrderStatus), CbxOrderStatus.Text));
                        inv.AddOrder(order, product, (int)NmrOrderQuantity.Value);
                    }
                    else
                    {
                        throw new AddingOrderException("Can't add the order");
                    }
                }
            }

        }

        private void BtnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedCells.Count > 0)
            {
                var selectedRow = dataGridProducts.Rows[dataGridProducts.SelectedCells[0].RowIndex];

                foreach (var product in inv.GetSortedProducts)
                {
                    if (product.ProductCode == (int)selectedRow.Cells[0].Value)
                    {
                        inv.RemoveProduct(product);
                    }
                }
                LoadDataToView();
            }
            else
            {
                ShowError(new RemovingProductException("Please select a product!"));
            }
        }

        private void BtnRemoveOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.SelectedCells.Count > 0)
            {
                var selectedRow = dataGridOrders.Rows[dataGridOrders.SelectedCells[0].RowIndex];

                foreach (var order in inv.GetSortedOrders)
                {
                    if (order.OrderCode == (int)selectedRow.Cells[0].Value)
                    {
                        inv.RemoveOrder(order);
                    }
                }
                LoadOrdersDataToView();
            }
            else
            {
                ShowError(new RemovingOrderException("Please select an order!"));
            }
        }
    }
}
