﻿
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
            this.label3.Location = new System.Drawing.Point(1242, 190);
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
            this.label4.Location = new System.Drawing.Point(1223, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total active cases:";
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
            // BtnShowDetailsCase
            // 
            this.BtnShowDetailsCase.Location = new System.Drawing.Point(1303, 740);
            this.BtnShowDetailsCase.Name = "BtnShowDetailsCase";
            this.BtnShowDetailsCase.Size = new System.Drawing.Size(263, 46);
            this.BtnShowDetailsCase.TabIndex = 9;
            this.BtnShowDetailsCase.Text = "Show selected info";
            this.BtnShowDetailsCase.UseVisualStyleBackColor = true;
            this.BtnShowDetailsCase.Click += new System.EventHandler(this.BtnShowCaseDetails_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1239, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selected information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1262, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total confirmed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1300, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total deaths:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1268, 618);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total recovered:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1239, 674);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total  active cases:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1344, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Country:";
            // 
            // lblSelectedLocation
            // 
            this.lblSelectedLocation.AutoSize = true;
            this.lblSelectedLocation.Location = new System.Drawing.Point(1467, 468);
            this.lblSelectedLocation.Name = "lblSelectedLocation";
            this.lblSelectedLocation.Size = new System.Drawing.Size(23, 32);
            this.lblSelectedLocation.TabIndex = 16;
            this.lblSelectedLocation.Text = "/";
            // 
            // lblSelectedConfirmed
            // 
            this.lblSelectedConfirmed.AutoSize = true;
            this.lblSelectedConfirmed.Location = new System.Drawing.Point(1467, 518);
            this.lblSelectedConfirmed.Name = "lblSelectedConfirmed";
            this.lblSelectedConfirmed.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedConfirmed.TabIndex = 17;
            this.lblSelectedConfirmed.Text = "0";
            // 
            // lblSelectedDeaths
            // 
            this.lblSelectedDeaths.AutoSize = true;
            this.lblSelectedDeaths.Location = new System.Drawing.Point(1467, 568);
            this.lblSelectedDeaths.Name = "lblSelectedDeaths";
            this.lblSelectedDeaths.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedDeaths.TabIndex = 18;
            this.lblSelectedDeaths.Text = "0";
            // 
            // lblSelectedRecovered
            // 
            this.lblSelectedRecovered.AutoSize = true;
            this.lblSelectedRecovered.Location = new System.Drawing.Point(1467, 618);
            this.lblSelectedRecovered.Name = "lblSelectedRecovered";
            this.lblSelectedRecovered.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedRecovered.TabIndex = 19;
            this.lblSelectedRecovered.Text = "0";
            // 
            // lblSelectedActive
            // 
            this.lblSelectedActive.AutoSize = true;
            this.lblSelectedActive.Location = new System.Drawing.Point(1467, 674);
            this.lblSelectedActive.Name = "lblSelectedActive";
            this.lblSelectedActive.Size = new System.Drawing.Size(27, 32);
            this.lblSelectedActive.TabIndex = 20;
            this.lblSelectedActive.Text = "0";
            // 
            // PresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 840);
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
    }
}

