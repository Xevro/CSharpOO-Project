
namespace PresentationForm
{
    partial class PresentationForm
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
            this.datagridCases = new System.Windows.Forms.DataGridView();
            this.CaseLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseConfirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseDeaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseRecovered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalconfirmed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDeaths = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRecovered = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalActive = new System.Windows.Forms.Label();
            this.BtnShowDetailsCase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSelectedLocation = new System.Windows.Forms.Label();
            this.lblSelectedConfirmed = new System.Windows.Forms.Label();
            this.lblSelectedDeaths = new System.Windows.Forms.Label();
            this.lblSelectedRecovered = new System.Windows.Forms.Label();
            this.lblSelectedActive = new System.Windows.Forms.Label();
            this.dataGridSearchResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSearchField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtConfirmed = new System.Windows.Forms.TextBox();
            this.TxtDeaths = new System.Windows.Forms.TextBox();
            this.TxtRecovered = new System.Windows.Forms.TextBox();
            this.TxtActive = new System.Windows.Forms.TextBox();
            this.BtnUpdateCase = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.LblCountry = new System.Windows.Forms.Label();
            this.BtnReloadData = new System.Windows.Forms.Button();
            this.dataGridCountryCases = new System.Windows.Forms.DataGridView();
            this.dataGridCountryCaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitleCaseInfo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCountryCases)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridCases
            // 
            this.datagridCases.AllowUserToAddRows = false;
            this.datagridCases.AllowUserToDeleteRows = false;
            this.datagridCases.AllowUserToOrderColumns = true;
            this.datagridCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseLocation,
            this.CaseConfirmed,
            this.CaseDeaths,
            this.CaseRecovered,
            this.CaseActive});
            this.datagridCases.Location = new System.Drawing.Point(45, 134);
            this.datagridCases.MultiSelect = false;
            this.datagridCases.Name = "datagridCases";
            this.datagridCases.ReadOnly = true;
            this.datagridCases.RowHeadersWidth = 82;
            this.datagridCases.RowTemplate.Height = 41;
            this.datagridCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCases.Size = new System.Drawing.Size(1122, 436);
            this.datagridCases.TabIndex = 0;
            this.datagridCases.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_CellMouseClick);
            // 
            // CaseLocation
            // 
            this.CaseLocation.HeaderText = "Location";
            this.CaseLocation.MinimumWidth = 10;
            this.CaseLocation.Name = "CaseLocation";
            this.CaseLocation.ReadOnly = true;
            this.CaseLocation.Width = 200;
            // 
            // CaseConfirmed
            // 
            this.CaseConfirmed.HeaderText = "Confirmed";
            this.CaseConfirmed.MinimumWidth = 10;
            this.CaseConfirmed.Name = "CaseConfirmed";
            this.CaseConfirmed.ReadOnly = true;
            this.CaseConfirmed.Width = 200;
            // 
            // CaseDeaths
            // 
            this.CaseDeaths.HeaderText = "Deaths";
            this.CaseDeaths.MinimumWidth = 10;
            this.CaseDeaths.Name = "CaseDeaths";
            this.CaseDeaths.ReadOnly = true;
            this.CaseDeaths.Width = 200;
            // 
            // CaseRecovered
            // 
            this.CaseRecovered.HeaderText = "Recovered";
            this.CaseRecovered.MinimumWidth = 10;
            this.CaseRecovered.Name = "CaseRecovered";
            this.CaseRecovered.ReadOnly = true;
            this.CaseRecovered.Width = 200;
            // 
            // CaseActive
            // 
            this.CaseActive.HeaderText = "Active";
            this.CaseActive.MinimumWidth = 10;
            this.CaseActive.Name = "CaseActive";
            this.CaseActive.ReadOnly = true;
            this.CaseActive.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1681, 726);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total confirmed:";
            // 
            // lblTotalconfirmed
            // 
            this.lblTotalconfirmed.AutoSize = true;
            this.lblTotalconfirmed.Location = new System.Drawing.Point(1895, 726);
            this.lblTotalconfirmed.Name = "lblTotalconfirmed";
            this.lblTotalconfirmed.Size = new System.Drawing.Size(78, 32);
            this.lblTotalconfirmed.TabIndex = 2;
            this.lblTotalconfirmed.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1719, 778);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total deaths:";
            // 
            // lblTotalDeaths
            // 
            this.lblTotalDeaths.AutoSize = true;
            this.lblTotalDeaths.Location = new System.Drawing.Point(1895, 778);
            this.lblTotalDeaths.Name = "lblTotalDeaths";
            this.lblTotalDeaths.Size = new System.Drawing.Size(78, 32);
            this.lblTotalDeaths.TabIndex = 4;
            this.lblTotalDeaths.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1684, 834);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total recovered:";
            // 
            // lblTotalRecovered
            // 
            this.lblTotalRecovered.AutoSize = true;
            this.lblTotalRecovered.Location = new System.Drawing.Point(1895, 834);
            this.lblTotalRecovered.Name = "lblTotalRecovered";
            this.lblTotalRecovered.Size = new System.Drawing.Size(78, 32);
            this.lblTotalRecovered.TabIndex = 6;
            this.lblTotalRecovered.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1665, 890);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total active cases:";
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(1895, 890);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(78, 32);
            this.lblTotalActive.TabIndex = 8;
            this.lblTotalActive.Text = "label5";
            // 
            // BtnShowDetailsCase
            // 
            this.BtnShowDetailsCase.Location = new System.Drawing.Point(2050, 996);
            this.BtnShowDetailsCase.Name = "BtnShowDetailsCase";
            this.BtnShowDetailsCase.Size = new System.Drawing.Size(263, 46);
            this.BtnShowDetailsCase.TabIndex = 9;
            this.BtnShowDetailsCase.Text = "Show selected info";
            this.BtnShowDetailsCase.UseVisualStyleBackColor = true;
            this.BtnShowDetailsCase.Click += new System.EventHandler(this.BtnShowCaseDetails_ClickAsync);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2015, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selected information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2073, 774);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total confirmed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2111, 824);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total deaths:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2079, 874);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total recovered:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2050, 930);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total  active cases:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2155, 724);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Country:";
            // 
            // lblSelectedLocation
            // 
            this.lblSelectedLocation.AutoSize = true;
            this.lblSelectedLocation.Location = new System.Drawing.Point(2290, 724);
            this.lblSelectedLocation.Name = "lblSelectedLocation";
            this.lblSelectedLocation.Size = new System.Drawing.Size(23, 32);
            this.lblSelectedLocation.TabIndex = 16;
            this.lblSelectedLocation.Text = "/";
            // 
            // lblSelectedConfirmed
            // 
            this.lblSelectedConfirmed.AutoSize = true;
            this.lblSelectedConfirmed.Location = new System.Drawing.Point(2290, 774);
            this.lblSelectedConfirmed.Name = "lblSelectedConfirmed";
            this.lblSelectedConfirmed.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedConfirmed.TabIndex = 17;
            this.lblSelectedConfirmed.Text = "0";
            // 
            // lblSelectedDeaths
            // 
            this.lblSelectedDeaths.AutoSize = true;
            this.lblSelectedDeaths.Location = new System.Drawing.Point(2290, 824);
            this.lblSelectedDeaths.Name = "lblSelectedDeaths";
            this.lblSelectedDeaths.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedDeaths.TabIndex = 18;
            this.lblSelectedDeaths.Text = "0";
            // 
            // lblSelectedRecovered
            // 
            this.lblSelectedRecovered.AutoSize = true;
            this.lblSelectedRecovered.Location = new System.Drawing.Point(2290, 874);
            this.lblSelectedRecovered.Name = "lblSelectedRecovered";
            this.lblSelectedRecovered.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedRecovered.TabIndex = 19;
            this.lblSelectedRecovered.Text = "0";
            // 
            // lblSelectedActive
            // 
            this.lblSelectedActive.AutoSize = true;
            this.lblSelectedActive.Location = new System.Drawing.Point(2290, 930);
            this.lblSelectedActive.Name = "lblSelectedActive";
            this.lblSelectedActive.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedActive.TabIndex = 20;
            this.lblSelectedActive.Text = "0";
            // 
            // dataGridSearchResults
            // 
            this.dataGridSearchResults.AllowUserToAddRows = false;
            this.dataGridSearchResults.AllowUserToDeleteRows = false;
            this.dataGridSearchResults.AllowUserToOrderColumns = true;
            this.dataGridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridSearchResults.Location = new System.Drawing.Point(45, 800);
            this.dataGridSearchResults.MultiSelect = false;
            this.dataGridSearchResults.Name = "dataGridSearchResults";
            this.dataGridSearchResults.ReadOnly = true;
            this.dataGridSearchResults.RowHeadersWidth = 82;
            this.dataGridSearchResults.RowTemplate.Height = 41;
            this.dataGridSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSearchResults.Size = new System.Drawing.Size(1104, 436);
            this.dataGridSearchResults.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Location";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Confirmed";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Deaths";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Recovered";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Active";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // TxtSearchField
            // 
            this.TxtSearchField.Location = new System.Drawing.Point(317, 730);
            this.TxtSearchField.Name = "TxtSearchField";
            this.TxtSearchField.Size = new System.Drawing.Size(230, 39);
            this.TxtSearchField.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 733);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "Search term (Country):";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(593, 726);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 46);
            this.BtnSearch.TabIndex = 24;
            this.BtnSearch.Text = "Search data";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1251, 633);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 45);
            this.label14.TabIndex = 26;
            this.label14.Text = "Update item";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1293, 765);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Confirmed:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1332, 819);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 32);
            this.label13.TabIndex = 28;
            this.label13.Text = "Deaths:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1293, 871);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 32);
            this.label15.TabIndex = 29;
            this.label15.Text = "Recovered:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1339, 933);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 32);
            this.label16.TabIndex = 30;
            this.label16.Text = "Active:";
            // 
            // TxtConfirmed
            // 
            this.TxtConfirmed.Location = new System.Drawing.Point(1459, 765);
            this.TxtConfirmed.Name = "TxtConfirmed";
            this.TxtConfirmed.Size = new System.Drawing.Size(157, 39);
            this.TxtConfirmed.TabIndex = 31;
            // 
            // TxtDeaths
            // 
            this.TxtDeaths.Location = new System.Drawing.Point(1459, 819);
            this.TxtDeaths.Name = "TxtDeaths";
            this.TxtDeaths.Size = new System.Drawing.Size(157, 39);
            this.TxtDeaths.TabIndex = 32;
            // 
            // TxtRecovered
            // 
            this.TxtRecovered.Location = new System.Drawing.Point(1459, 871);
            this.TxtRecovered.Name = "TxtRecovered";
            this.TxtRecovered.Size = new System.Drawing.Size(157, 39);
            this.TxtRecovered.TabIndex = 33;
            // 
            // TxtActive
            // 
            this.TxtActive.Location = new System.Drawing.Point(1459, 930);
            this.TxtActive.Name = "TxtActive";
            this.TxtActive.Size = new System.Drawing.Size(157, 39);
            this.TxtActive.TabIndex = 34;
            // 
            // BtnUpdateCase
            // 
            this.BtnUpdateCase.Location = new System.Drawing.Point(1251, 1005);
            this.BtnUpdateCase.Name = "BtnUpdateCase";
            this.BtnUpdateCase.Size = new System.Drawing.Size(195, 46);
            this.BtnUpdateCase.TabIndex = 35;
            this.BtnUpdateCase.Text = "Update case";
            this.BtnUpdateCase.UseVisualStyleBackColor = true;
            this.BtnUpdateCase.Click += new System.EventHandler(this.BtnUpdateCase_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1319, 707);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 32);
            this.label17.TabIndex = 36;
            this.label17.Text = "Country:";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(1459, 707);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(23, 32);
            this.LblCountry.TabIndex = 37;
            this.LblCountry.Text = "/";
            // 
            // BtnReloadData
            // 
            this.BtnReloadData.Location = new System.Drawing.Point(45, 598);
            this.BtnReloadData.Name = "BtnReloadData";
            this.BtnReloadData.Size = new System.Drawing.Size(150, 46);
            this.BtnReloadData.TabIndex = 39;
            this.BtnReloadData.Text = "Reload data";
            this.BtnReloadData.UseVisualStyleBackColor = true;
            this.BtnReloadData.Click += new System.EventHandler(this.BtnReloadData_Click);
            // 
            // dataGridCountryCases
            // 
            this.dataGridCountryCases.AllowUserToAddRows = false;
            this.dataGridCountryCases.AllowUserToDeleteRows = false;
            this.dataGridCountryCases.AllowUserToOrderColumns = true;
            this.dataGridCountryCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCountryCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridCountryCaseDate,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridCountryCases.Location = new System.Drawing.Point(1255, 134);
            this.dataGridCountryCases.MultiSelect = false;
            this.dataGridCountryCases.Name = "dataGridCountryCases";
            this.dataGridCountryCases.ReadOnly = true;
            this.dataGridCountryCases.RowHeadersWidth = 82;
            this.dataGridCountryCases.RowTemplate.Height = 41;
            this.dataGridCountryCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCountryCases.Size = new System.Drawing.Size(1126, 436);
            this.dataGridCountryCases.TabIndex = 41;
            // 
            // dataGridCountryCaseDate
            // 
            this.dataGridCountryCaseDate.HeaderText = "Date";
            this.dataGridCountryCaseDate.MinimumWidth = 10;
            this.dataGridCountryCaseDate.Name = "dataGridCountryCaseDate";
            this.dataGridCountryCaseDate.ReadOnly = true;
            this.dataGridCountryCaseDate.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Confirmed";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Deaths";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Recovered";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Active";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // LblTitleCaseInfo
            // 
            this.LblTitleCaseInfo.AutoSize = true;
            this.LblTitleCaseInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitleCaseInfo.Location = new System.Drawing.Point(1255, 52);
            this.LblTitleCaseInfo.Name = "LblTitleCaseInfo";
            this.LblTitleCaseInfo.Size = new System.Drawing.Size(442, 45);
            this.LblTitleCaseInfo.TabIndex = 42;
            this.LblTitleCaseInfo.Text = "All info sinds begin about ...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(45, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(544, 45);
            this.label18.TabIndex = 43;
            this.label18.Text = "Covid 19 worldwide data for today";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(1665, 633);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(196, 45);
            this.label19.TabIndex = 44;
            this.label19.Text = "Total values";
            // 
            // PresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2530, 1390);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LblTitleCaseInfo);
            this.Controls.Add(this.dataGridCountryCases);
            this.Controls.Add(this.BtnReloadData);
            this.Controls.Add(this.LblCountry);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BtnUpdateCase);
            this.Controls.Add(this.TxtActive);
            this.Controls.Add(this.TxtRecovered);
            this.Controls.Add(this.TxtDeaths);
            this.Controls.Add(this.TxtConfirmed);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtSearchField);
            this.Controls.Add(this.dataGridSearchResults);
            this.Controls.Add(this.lblSelectedActive);
            this.Controls.Add(this.lblSelectedRecovered);
            this.Controls.Add(this.lblSelectedDeaths);
            this.Controls.Add(this.lblSelectedConfirmed);
            this.Controls.Add(this.lblSelectedLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnShowDetailsCase);
            this.Controls.Add(this.lblTotalActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRecovered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalDeaths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalconfirmed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridCases);
            this.Name = "PresentationForm";
            this.Text = "Corona viewer";
            ((System.ComponentModel.ISupportInitialize)(this.datagridCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCountryCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseConfirmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseDeaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseRecovered;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalconfirmed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalDeaths;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRecovered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalActive;
        private System.Windows.Forms.Button BtnShowDetailsCase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSelectedLocation;
        private System.Windows.Forms.Label lblSelectedConfirmed;
        private System.Windows.Forms.Label lblSelectedDeaths;
        private System.Windows.Forms.Label lblSelectedRecovered;
        private System.Windows.Forms.Label lblSelectedActive;
        private System.Windows.Forms.DataGridView dataGridSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox TxtSearchField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtConfirmed;
        private System.Windows.Forms.TextBox TxtDeaths;
        private System.Windows.Forms.TextBox TxtRecovered;
        private System.Windows.Forms.TextBox TxtActive;
        private System.Windows.Forms.Button BtnUpdateCase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Button BtnReloadData;
        private System.Windows.Forms.DataGridView dataGridCountryCases;
        private System.Windows.Forms.Label LblTitleCaseInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridCountryCaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

