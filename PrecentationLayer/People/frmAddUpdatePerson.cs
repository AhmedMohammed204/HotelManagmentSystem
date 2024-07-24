using PrecentationLayer.Screens;
using System.Threading.Tasks;

namespace PrecentationLayer.People
{
    public partial class frmAddUpdatePerson : SubTitledScreen
    {
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
             ctrlUpdatePersonInfo1.LoadInfo(PersonID);
        }

        private void ctrlUpdatePersonInfo1_OnModeChanged(string obj)
        {
            Title = obj;
        }
    }
}
