using IdentificationTypesBusinessLayer;
using PeopleBusinessLayer;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilLibrary;

namespace PrecentationLayer.People
{
    public partial class ctrlAddUpdatePersonInfo : UserControl
    {
        #region Class Init
        public event Action<string> OnModeChanged;
        public enum enMode { AddNew, Update };
        public enMode Mode { get; set; }
        public ctrlAddUpdatePersonInfo()
        {
            InitializeComponent();
        }
        public clsPerson PersonInfo { get; set; }
        public async Task LoadInfo(int PersonID)
        {
            dtpDateOfBirth.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
            Task loadType = LoadIdTypeAsync();
            if (PersonID == -1)
            {
                PersonInfo = new clsPerson();
                Mode = enMode.AddNew;
                OnModeChanged?.Invoke("Add New Person");
                return;
            }
            PersonInfo = clsPerson.Find(PersonID);
            if (PersonInfo == null)
            {
                clsMessageBox.ErrorMessage("There's No Person With this ID");
                return;
            }
            Mode = enMode.Update;
            OnModeChanged?.Invoke("Update Person");
            await loadType;
            FillPersonDetails();

        }

        async Task LoadIdTypeAsync()
        {
            cbIdType.Items.Clear();
            DataTable IdTypes = await clsIdentificationType.GetAllIdentificationTypesAsync();

            foreach (DataRow Type in IdTypes.Rows)
            {
                cbIdType.Items.Add(Type["Name"]);

            }

        }
        void FillPersonDetails()
        {
            InfoPersonID.Details = PersonInfo.PersonID.ToString();
            txtFirstName.Details = PersonInfo.FirstName;
            txtLastName.Details = PersonInfo.LastName;
            txtEmail.Details = PersonInfo.Email;
            txtPhone.Details = PersonInfo.Phone;
            txtIdNum.Details = PersonInfo.IdentificationNum;
            dtpDateOfBirth.Value = PersonInfo.DateOfBirth;
            cbIdType.SelectedItem = PersonInfo.IdInfo.Name;


        }
        #endregion

        #region Handling close event


        #endregion

        #region Save 

        bool IsValidToSave()
        {
            if (
                string.IsNullOrEmpty(txtFirstName.Details) ||
                string.IsNullOrEmpty(txtLastName.Details) ||
                string.IsNullOrEmpty(txtEmail.Details) ||
                string.IsNullOrEmpty(cbIdType.Text)
                )
            {
                return false;
            }
            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidToSave())
            {
                clsMessageBox.ErrorMessage("Fill All gabs");
                return;
            }
            PersonInfo.IdentificationTypeID = clsIdentificationType.Find(cbIdType.Text).IdentificationTypeID;
            PersonInfo.FirstName = txtFirstName.Details;
            PersonInfo.LastName = txtLastName.Details;
            PersonInfo.Email = txtEmail.Details;
            PersonInfo.Phone = txtPhone.Details;
            PersonInfo.DateOfBirth = dtpDateOfBirth.Value;
            PersonInfo.IdentificationNum = txtIdNum.Details;
            if (!PersonInfo.Save())
            {
                clsMessageBox.ErrorMessage("There was an error");
                return;
            }
            clsMessageBox.DoneMessage($"Person {(Mode == enMode.AddNew ? "Added" : "Updated")} Successfully!");
            LoadInfo(PersonInfo.PersonID);
        }
        #endregion
    }
}
