using CountriesBusinessLayer;
using PrecentationLayer.Screens;

namespace PrecentationLayer
{
    public partial class frmTest : SubTitledScreen
    {
        public frmTest()
        {
            Title = "Hi";
            InitializeComponent();

            ctrlDataGridWithSearch1.LoadData(clsCountry.GetAllCountries());
        }
    }
}
