using Logic;
using System.Diagnostics;
using System.Windows.Forms;

namespace PresentationForm
{
    public partial class PresentationForm : Form
    {
        private readonly ILogic logic;

        public PresentationForm(ILogic logicCovid)
        {
            this.logic = logicCovid;
            InitializeComponent();
            var data = logic.GetJsonData();

            foreach (var caseData in data.Data)
            {
                Debug.WriteLine(caseData.Active);
            }
        }
    }
}