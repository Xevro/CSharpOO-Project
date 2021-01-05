using Globals;
using Globals.ErrorMessages;
using Globals.Exceptions;
using Logic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace PresentationForm
{
    public partial class PresentationForm : Form
    {
        private readonly ILogics logic;
        private Dictionary<string, int> caseTotal;
        private readonly JsonData data;

        public PresentationForm(ILogics logicCovid)
        {
            this.logic = logicCovid;
            InitializeComponent();
            data = logic.GetJsonData();
            ShowData(data);
        }

        private void ShowData(JsonData data)
        {
            LoadCaseData();
            logic.DataDelegate = logic.GetTotalsFromData;
            caseTotal = logic.DataDelegate.Invoke(data);
            if (caseTotal.Count == 4)
            {
                lblTotalconfirmed.Text = caseTotal["totalConfirmed"].RemoveDecimalPoint();
                lblTotalDeaths.Text = caseTotal["totalDeaths"].RemoveDecimalPoint();
                lblTotalRecovered.Text = caseTotal["totalRecovered"].RemoveDecimalPoint();
                lblTotalActive.Text = caseTotal["totalActive"].RemoveDecimalPoint();
            }
        }

        private void LoadCaseData()
        {
            datagridCases.Rows.Clear();
            foreach (var caseData in logic.GetJsonData().Data)
            {
                datagridCases.Rows.Insert(0, caseData.Location, caseData.Confirmed, caseData.Deaths, caseData.Recovered, caseData.Active);
            }
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void BtnShowCaseDetails_Click(object sender, System.EventArgs e)
        {
            if (datagridCases.SelectedCells.Count > 0)
            {
                var selectedRow = datagridCases.Rows[datagridCases.SelectedCells[0].RowIndex];
                foreach (var caseData in data.Data)
                {
                    if (caseData.Location == (string)selectedRow.Cells[0].Value)
                    {
                        ShowDetails(caseData);
                        ShowDetailsOfCountry(caseData.Location);
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
            lblSelectedLocation.Text = caseData.Location;
            lblSelectedConfirmed.Text = caseData.Confirmed.RemoveDecimalPoint();
            lblSelectedDeaths.Text = caseData.Deaths.RemoveDecimalPoint();
            lblSelectedRecovered.Text = caseData.Recovered.RemoveDecimalPoint();
            lblSelectedActive.Text = caseData.Active.RemoveDecimalPoint();
        }

        private void ShowDetailsOfCountry(string country)
        {
            try
            {
                this.LblTitleCaseInfo.Text = "All info sinds begin about " + country;
                var countryData = logic.GetDataByCountry(country.Replace(" ", "-"));
                foreach (var caseData in countryData)
                {
                    dataGridCountryCases.Rows.Insert(0, caseData.Date, caseData.Confirmed, caseData.Deaths, caseData.Recovered, caseData.Active);
                }
            }
            catch (WebException)
            {
                ShowError(new CanNotLoadDataFromAPIException(Messages.CanNotLoadDataForCountryError));
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dataGridSearchResults.Rows.Clear();
            var results = logic.GetSearchResults(this.TxtSearchField.Text);
            foreach (var item in results)
            {
                dataGridSearchResults.Rows.Insert(0, item.Location, item.Confirmed, item.Deaths, item.Recovered, item.Active);
            }
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.datagridCases.Rows[e.RowIndex];
                LblCountry.Text = row.Cells[0].Value.ToString();
                TxtConfirmed.Text = row.Cells[1].Value.ToString();
                TxtDeaths.Text = row.Cells[2].Value.ToString();
                TxtRecovered.Text = row.Cells[3].Value.ToString();
                TxtActive.Text = row.Cells[4].Value.ToString();
            }
        }

        private void BtnUpdateCase_Click(object sender, EventArgs e)
        {
            if (TxtConfirmed.Text != "")
            {
                UpdateInformation();
            }
            else
            {
                ShowError(new FindingItemExeption(Messages.ErrorMessage(" Please select an item in the list")));
            }
        }

        private void UpdateInformation()
        {
            if (int.TryParse(TxtConfirmed.Text, out _) && int.TryParse(TxtConfirmed.Text, out _) &&
                        int.TryParse(TxtConfirmed.Text, out _) && int.TryParse(TxtConfirmed.Text, out _))
            {
                var selectedCase = new Case(LblCountry.Text, int.Parse(TxtConfirmed.Text), int.Parse(TxtDeaths.Text), int.Parse(TxtRecovered.Text), int.Parse(TxtActive.Text));
                logic.UpdateCase(selectedCase);
                LoadCaseData();
            }
            else
            {
                ShowError(new InputNotANumberExeption(Messages.ErrorMessage(" Please type in a valid number")));
            }
        }

        private void BtnReloadData_Click(object sender, EventArgs e)
        {
            LoadCaseData();
        }

        private void PresentationForm_Load(object sender, EventArgs e)
        {

        }
    }
}