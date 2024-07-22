using CountriesBusinessLayer;
using PrecentationLayer.Screens;
using RoomsBusinessLayer;

namespace PrecentationLayer
{
    public partial class frmTest : SubTitledScreen
    {
        public frmTest()
        {
            Title = "Hi";
            InitializeComponent();

            ctrlDataGridWithSearch1.LoadData(clsRoom.GetAvailableRooms());
        }
    }
}
