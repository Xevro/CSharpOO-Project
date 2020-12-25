using Globals;
using Globals.ErrorMessages;
using Globals.Exceptions;
using Logic;
using System;
using System.Windows.Forms;
using static Logic.ILogic;

namespace PresentationForm
{
    public partial class PresentationForm : Form
    {
        private readonly ILogic logic;
        private ShowValues del;

        public PresentationForm(ILogic logicCovid)
        {
            this.logic = logicCovid;
            InitializeComponent();
            var data = logic.GetJsonData();
            ShowData(data);
        }

        private void ShowData(JsonData data)
        {
            foreach (var caseData in data.Data)
            {
                this.datagridCases.Rows.Insert(0, caseData.Location, caseData.Confirmed, caseData.Deaths, caseData.Recovered, caseData.Active);
            }
            del = logic.ShowTotalConfirmed;

            this.lblTotalconfirmed.Text = Convert.ToDecimal(del(data)).ToString("#,##0");
            del = logic.ShowTotaldeaths;
            this.lblTotalDeaths.Text = Convert.ToDecimal(del(data)).ToString("#,##0");
            del = logic.ShowTotalrecovered;
            this.lblTotalRecovered.Text = Convert.ToDecimal(del(data)).ToString("#,##0");
            del = logic.ShowTotalActive;
            this.lblTotalActive.Text = Convert.ToDecimal(del(data)).ToString("#,##0");
        }

        private void ShowError(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
        }

        private void BtnShowCaseDetails_Click(object sender, System.EventArgs e)
        {
            if (datagridCases.SelectedCells.Count > 0)
            {
                var selectedRow = datagridCases.Rows[datagridCases.SelectedCells[0].RowIndex];

                foreach (var caseData in logic.GetJsonData().Data)
                {
                    if (caseData.Location == (string)selectedRow.Cells[0].Value)
                    {
                        ShowDetails(caseData.DeepCopy());
                    }
                }
            }
            else
            {
                ShowError(new FindingItemExeption(Messages.ErrorMessage("There was a problem while searching for the data")));
            }
        }

        private void ShowDetails(Case caseData)
        {
            this.lblSelectedLocation.Text = caseData.Location;

            this.lblSelectedConfirmed.Text = Convert.ToDecimal(caseData.Confirmed).ToString("#,##0");
            this.lblSelectedDeaths.Text = Convert.ToDecimal(caseData.Deaths).ToString("#,##0");
            this.lblSelectedRecovered.Text = Convert.ToDecimal(caseData.Recovered).ToString("#,##0");
            this.lblSelectedActive.Text = Convert.ToDecimal(caseData.Active).ToString("#,##0");
        }
    }
}