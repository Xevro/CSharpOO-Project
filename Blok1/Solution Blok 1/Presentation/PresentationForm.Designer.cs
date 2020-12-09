
namespace Presentation
{
    partial class Presentation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblproductcode = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.BtnImport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.CbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NmrOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRemoveProduct = new System.Windows.Forms.Button();
            this.OrdersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRemoveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrOrderQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(3218, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AllowUserToOrderColumns = true;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Name,
            this.Quantity,
            this.Status});
            this.dataGridProducts.Location = new System.Drawing.Point(525, 128);
            this.dataGridProducts.MultiSelect = false;
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersWidth = 82;
            this.dataGridProducts.RowTemplate.Height = 41;
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(1184, 610);
            this.dataGridProducts.TabIndex = 4;
            this.dataGridProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_CellMouseClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 10;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 250;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 350;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 250;
            // 
            // lblproductcode
            // 
            this.lblproductcode.AutoSize = true;
            this.lblproductcode.Location = new System.Drawing.Point(86, 131);
            this.lblproductcode.Name = "lblproductcode";
            this.lblproductcode.Size = new System.Drawing.Size(126, 32);
            this.lblproductcode.TabIndex = 5;
            this.lblproductcode.Text = "Product ID";
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(247, 128);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(200, 39);
            this.TxtCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantity";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(247, 203);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(200, 39);
            this.TxtName.TabIndex = 10;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(247, 279);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(200, 39);
            this.TxtQuantity.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 46);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 23);
            this.lblMessage.TabIndex = 0;
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(275, 594);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(200, 46);
            this.BtnImport.TabIndex = 14;
            this.BtnImport.Text = "Import Products";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Actions";
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(49, 594);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(200, 46);
            this.BtnExport.TabIndex = 16;
            this.BtnExport.Text = "Export Products";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(49, 46);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(136, 59);
            this.txtMessage.TabIndex = 17;
            this.txtMessage.Text = "Stock";
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToDeleteRows = false;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderProductID,
            this.OrderName,
            this.OrderQuantity,
            this.OrderStatus});
            this.dataGridOrders.Location = new System.Drawing.Point(525, 866);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowHeadersWidth = 82;
            this.dataGridOrders.RowTemplate.Height = 41;
            this.dataGridOrders.Size = new System.Drawing.Size(1184, 616);
            this.dataGridOrders.TabIndex = 18;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 10;
            this.OrderID.Name = "OrderID";
            this.OrderID.Width = 200;
            // 
            // OrderProductID
            // 
            this.OrderProductID.HeaderText = "Product ID";
            this.OrderProductID.MinimumWidth = 10;
            this.OrderProductID.Name = "OrderProductID";
            this.OrderProductID.Width = 200;
            // 
            // OrderName
            // 
            this.OrderName.HeaderText = "Name";
            this.OrderName.MinimumWidth = 10;
            this.OrderName.Name = "OrderName";
            this.OrderName.Width = 300;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "Quantity";
            this.OrderQuantity.MinimumWidth = 10;
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.Width = 200;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order status";
            this.OrderStatus.MinimumWidth = 10;
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 772);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 59);
            this.label5.TabIndex = 19;
            this.label5.Text = "Orders";
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.Location = new System.Drawing.Point(247, 1074);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(200, 48);
            this.BtnPlaceOrder.TabIndex = 20;
            this.BtnPlaceOrder.Text = "Place order";
            this.BtnPlaceOrder.UseVisualStyleBackColor = true;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // CbxOrderStatus
            // 
            this.CbxOrderStatus.FormattingEnabled = true;
            this.CbxOrderStatus.Location = new System.Drawing.Point(247, 900);
            this.CbxOrderStatus.Name = "CbxOrderStatus";
            this.CbxOrderStatus.Size = new System.Drawing.Size(200, 40);
            this.CbxOrderStatus.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 903);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Order status";
            // 
            // NmrOrderQuantity
            // 
            this.NmrOrderQuantity.Location = new System.Drawing.Point(247, 998);
            this.NmrOrderQuantity.Name = "NmrOrderQuantity";
            this.NmrOrderQuantity.Size = new System.Drawing.Size(200, 39);
            this.NmrOrderQuantity.TabIndex = 23;
            this.NmrOrderQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 1000);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantity";
            // 
            // BtnRemoveProduct
            // 
            this.BtnRemoveProduct.Location = new System.Drawing.Point(247, 430);
            this.BtnRemoveProduct.Name = "BtnRemoveProduct";
            this.BtnRemoveProduct.Size = new System.Drawing.Size(200, 46);
            this.BtnRemoveProduct.TabIndex = 25;
            this.BtnRemoveProduct.Text = "Remove Product";
            this.BtnRemoveProduct.UseVisualStyleBackColor = true;
            this.BtnRemoveProduct.Click += new System.EventHandler(this.BtnRemoveProduct_Click);
            // 
            // OrdersID
            // 
            this.OrdersID.HeaderText = "Order ID";
            this.OrdersID.MinimumWidth = 10;
            this.OrdersID.Name = "OrdersID";
            this.OrdersID.Width = 250;
            // 
            // BtnRemoveOrder
            // 
            this.BtnRemoveOrder.Location = new System.Drawing.Point(247, 1156);
            this.BtnRemoveOrder.Name = "BtnRemoveOrder";
            this.BtnRemoveOrder.Size = new System.Drawing.Size(200, 46);
            this.BtnRemoveOrder.TabIndex = 26;
            this.BtnRemoveOrder.Text = "Remove Order";
            this.BtnRemoveOrder.UseVisualStyleBackColor = true;
            this.BtnRemoveOrder.Click += new System.EventHandler(this.BtnRemoveOrder_Click);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3218, 1617);
            this.Controls.Add(this.BtnRemoveOrder);
            this.Controls.Add(this.BtnRemoveProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NmrOrderQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbxOrderStatus);
            this.Controls.Add(this.BtnPlaceOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.lblproductcode);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrOrderQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Label lblproductcode;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPlaceOrder;
        private System.Windows.Forms.ComboBox CbxOrderStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NmrOrderQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnRemoveProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.Button BtnRemoveOrder;
    }
}

