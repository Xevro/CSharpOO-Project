
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridCases)).BeginInit();
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
            this.datagridCases.Location = new System.Drawing.Point(45, 64);
            this.datagridCases.MultiSelect = false;
            this.datagridCases.Name = "datagridCases";
            this.datagridCases.ReadOnly = true;
            this.datagridCases.RowHeadersWidth = 82;
            this.datagridCases.RowTemplate.Height = 41;
            this.datagridCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCases.Size = new System.Drawing.Size(1104, 436);
            this.datagridCases.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(1239, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total confirmed:";
            // 
            // lblTotalconfirmed
            // 
            this.lblTotalconfirmed.AutoSize = true;
            this.lblTotalconfirmed.Location = new System.Drawing.Point(1453, 82);
            this.lblTotalconfirmed.Name = "lblTotalconfirmed";
            this.lblTotalconfirmed.Size = new System.Drawing.Size(78, 32);
            this.lblTotalconfirmed.TabIndex = 2;
            this.lblTotalconfirmed.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1277, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total deaths:";
            // 
            // lblTotalDeaths
            // 
            this.lblTotalDeaths.AutoSize = true;
            this.lblTotalDeaths.Location = new System.Drawing.Point(1453, 134);
            this.lblTotalDeaths.Name = "lblTotalDeaths";
            this.lblTotalDeaths.Size = new System.Drawing.Size(78, 32);
            this.lblTotalDeaths.TabIndex = 4;
            this.lblTotalDeaths.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1237, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total recovered:";
            // 
            // lblTotalRecovered
            // 
            this.lblTotalRecovered.AutoSize = true;
            this.lblTotalRecovered.Location = new System.Drawing.Point(1453, 190);
            this.lblTotalRecovered.Name = "lblTotalRecovered";
            this.lblTotalRecovered.Size = new System.Drawing.Size(78, 32);
            this.lblTotalRecovered.TabIndex = 6;
            this.lblTotalRecovered.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1286, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total active:";
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(1453, 246);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(78, 32);
            this.lblTotalActive.TabIndex = 8;
            this.lblTotalActive.Text = "label5";
            // 
            // PresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 840);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridCases)).EndInit();
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
    }
}

