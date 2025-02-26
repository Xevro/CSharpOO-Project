﻿using Globals;
using Globals.ErrorMessages;
using Globals.Exceptions;
using Logic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationForm
{
    public partial class PresentationForm : Form
    {
        private readonly ILogics logic;
        private Dictionary<string, int> caseTotal;
        private JsonData jsonData;
        private readonly SynchronizationContext context;

        public PresentationForm(ILogics logicCovid)
        {
            InitializeComponent();
            logic = logicCovid;
            context = SynchronizationContext.Current;
            logic.DataEvent += OnWorkerGetApiData;
            logic.GetJsonData();
        }

        private void OnWorkerGetApiData(JsonData result)
        {
            context.Post((data) =>
            {
                BtnReloadData.Enabled = true;
                jsonData = result;
                ShowData(result);
            }, result);
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
            foreach (var caseData in jsonData.Data)
            {
                datagridCases.Rows.Insert(0, caseData.Location, caseData.Confirmed, caseData.Deaths, caseData.Recovered, caseData.Active);
            }
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private async void BtnShowCaseDetails_ClickAsync(object sender, System.EventArgs e)
        {
            if (datagridCases.SelectedCells.Count > 0)
            {
                var selectedRow = datagridCases.Rows[datagridCases.SelectedCells[0].RowIndex];
                foreach (var caseData in jsonData.Data)
                {
                    if (caseData.Location == (string)selectedRow.Cells[0].Value)
                    {
                        ShowDetails(caseData);
                        await ShowDetailsOfCountryAsync(caseData.Location);
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

        private async Task ShowDetailsOfCountryAsync(string country)
        {
            try
            {
                dataGridCountryCases.Rows.Clear();
                LblTitleCaseInfo.Text = "All info sinds begin about " + country;
                var returnedTaskTResult = await logic.GetDataByCountry(country.Replace(" ", "-"));
                foreach (var caseData in returnedTaskTResult)
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
            var results = logic.GetSearchResults(TxtSearchField.Text);
            foreach (var item in results)
            {
                dataGridSearchResults.Rows.Insert(0, item.Location, item.Confirmed, item.Deaths, item.Recovered, item.Active);
            }
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = datagridCases.Rows[e.RowIndex];
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
            BtnReloadData.Enabled = false;
            logic.GetJsonData();
            LoadCaseData();
        }
    }
}