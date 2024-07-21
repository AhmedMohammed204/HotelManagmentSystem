using StegiHotel_databaseDataAccessLayer;
using System.Data;
using System.Threading.Tasks;
namespace IdentificationTypesBusinessLayer
{

    public class clsIdentificationType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int IdentificationTypeID { get; set; }
        public string Name { get; set; }


        public clsIdentificationType()
        {
            this.IdentificationTypeID = default;
            this.Name = default;


            Mode = enMode.AddNew;

        }

        private clsIdentificationType(int IdentificationTypeID, string Name)
        {
            this.IdentificationTypeID = IdentificationTypeID;
            this.Name = Name;


            Mode = enMode.Update;

        }

        private bool _AddNewIdentificationType()
        {
            //call DataAccess Layer 

            this.IdentificationTypeID = clsIdentificationTypesDataAccess.AddNewIdentificationType(this.Name);

            return (this.IdentificationTypeID != -1);

        }

        private bool _UpdateIdentificationType()
        {
            //call DataAccess Layer 

            return clsIdentificationTypesDataAccess.UpdateIdentificationType(this.IdentificationTypeID, this.Name);

        }

        public static clsIdentificationType Find(int IdentificationTypeID)
        {
            string Name = default;


            if (clsIdentificationTypesDataAccess.GetIdentificationTypeInfoByID(IdentificationTypeID, ref Name))
                return new clsIdentificationType(IdentificationTypeID, Name);
            else
                return null;

        }

        public static clsIdentificationType Find(string Name)
        {
            int IdentificationTypeID = default;


            if (clsIdentificationTypesDataAccess.GetIdentificationTypeInfoByName(ref IdentificationTypeID, ref Name))
                return new clsIdentificationType(IdentificationTypeID, Name);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewIdentificationType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateIdentificationType();

            }




            return false;
        }

        public static async Task<DataTable> GetAllIdentificationTypesAsync() { return await clsIdentificationTypesDataAccess.GetAllIdentificationTypesAsync(); }

        public static bool DeleteIdentificationType(int IdentificationTypeID) { return clsIdentificationTypesDataAccess.DeleteIdentificationType(IdentificationTypeID); }

        public static bool isIdentificationTypeExist(int IdentificationTypeID) { return clsIdentificationTypesDataAccess.IsIdentificationTypeExist(IdentificationTypeID); }


    }

}