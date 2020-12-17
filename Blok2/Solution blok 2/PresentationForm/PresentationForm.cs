using Logic;
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
            logic.load();
        }

    }
}