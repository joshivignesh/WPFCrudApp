using Common;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Data.Access.Layer
{
    /// <summary>
    /// User Model class to map user API details
    /// </summary>
    public class User 
    {
        #region Class level properties
        public int Id { get; set; }               
        public string Name { get; set; }               
        public string Email { get; set; }       
        public string Gender { get; set; }
        public string Status { get; set; }

        #endregion
    }

    public class UserServiceIns
    {
        #region Class level properties
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }

        #endregion
    }

    /// <summary>
    /// UserModel as a ViewModel deriving from BaseViewMdel -->INotifyPropertyChanged and IdataErrorInfo interface
    /// </summary>
    public class UserModel : BaseViewModel, IDataErrorInfo
    {
        #region Private variables

        private int _Id;

        private string _Name;

        private string _Email;

        private string _Gender;

        private string _Status;

        #endregion

        #region Public Property
        public int Id { get => _Id; set { _Id = value; OnPropertyChanged(); } }
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }
        public string Gender { get => _Gender; set { _Gender = value; OnPropertyChanged(); } }
        public string Status { get => _Status; set { _Status = value; OnPropertyChanged(); } }
        public string Error => throw new NotImplementedException();
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        #endregion

        #region Public method 
        public string this[string columnName]
        {
            get
            {
                string result = null;

                switch (columnName)
                {
                    case "Name":
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            result = "This field is required";
                        }
                        else if (Name.Length < 5)
                        {
                            result = "Name should contaian atleast 5 character";
                        }
                        break;

                    case "Email":
                        if (string.IsNullOrWhiteSpace(Email))
                        {
                            result = "This field is required";
                        }
                        else if (!regex.IsMatch(Email))
                        {
                            result = "Please enter valid email";
                        }
                        break;

                    case "Gender":
                        if (string.IsNullOrWhiteSpace(Gender))
                        {
                            result = "This field is required";
                        }
                        break;
                    case "Status":
                        if (string.IsNullOrWhiteSpace(Status))
                        {
                            result = "This field is required";
                        }
                        break;
                    default:
                        break;
                }

                return result;
            }
        }

        #endregion
    }
}
