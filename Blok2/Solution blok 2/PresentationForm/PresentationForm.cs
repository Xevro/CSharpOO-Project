using Globals;
using Logic;
using System.Globalization;
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
            var f = new NumberFormatInfo { NumberGroupSeparator = " " };
            foreach (var caseData in data.Data)
            {
                this.datagridCases.Rows.Insert(0, caseData.Location, caseData.Confirmed, caseData.Deaths, caseData.Recovered, caseData.Active);
            }
            del = logic.ShowTotalConfirmed;
            this.lblTotalconfirmed.Text = del(data).ToString("n", f);
            del = logic.ShowTotaldeaths;
            this.lblTotalDeaths.Text = del(data).ToString("n", f);
            del = logic.ShowTotalrecovered;
            this.lblTotalRecovered.Text = del(data).ToString("n", f);
            del = logic.ShowTotalActive;
            this.lblTotalActive.Text = del(data).ToString("n", f);
        }
    }
}