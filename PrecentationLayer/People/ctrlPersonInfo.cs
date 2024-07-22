using PeopleBusinessLayer;
using System;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.Lib
{
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();
            UpdateButton = btnUpdate;
        }
        public Button UpdateButton { get; set; }
        public clsPerson PersonInfo { get; set; }
        public void LoadInfo(int PersonID)
        {
            PersonInfo = clsPerson.Find(PersonID);
            if (PersonInfo == null)
            {
                clsMessageBox.ErrorMessage("Person not found");
                return;
            }
            _FillPersonDetails();

        }
        void _FillPersonDetails()
        {
            IPersonID.Details = PersonInfo.PersonID.ToString();
            IFirstName.Details = PersonInfo.FirstName;
            ILastName.Details = PersonInfo.LastName;
            IEmail.Details = PersonInfo.Email;
            IPhone.Details = string.IsNullOrEmpty(PersonInfo.Phone) ? "There's not phone number" : PersonInfo.Phone;
            IIdNum.Details = PersonInfo.IdentificationNum;
            IIdType.Details = PersonInfo.IdInfo.Name;
            IDateOfBirht.Details = PersonInfo.DateOfBirth.ToShortDateString();
        }
        public event Action<int> OnClickUpdate;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnClickUpdate?.Invoke(PersonInfo.PersonID);
        }
    }
}
