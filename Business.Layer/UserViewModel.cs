using Common;
using Data.Access.Layer;
using Service.Layer;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Business.Layer
{
    public class UserViewModel : BaseDialog<bool>
    {
        /// <summary>
        /// UserView Model constructor
        /// </summary>
        /// <param name="userModel"></param>
        public UserViewModel(UserModel userModel = null)
        {
            Service = new UserService();
            Service.Init();
            CloceCommand = new RelayCommand((p) => Close(false));

            if (userModel!=null)
            {
                User = userModel;
                IsUpdate = true;
            }
            else
            {
                User = new UserModel();
                IsUpdate = false;
            }
           
        }



        #region Prop
        public IUserService Service;
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private UserModel user;

        public UserModel User
        {
            get { return user; }
            set { user = value; }
        }

        #endregion

        #region Error Prop
        private string name = null;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string email = null;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }

        private string gender = null;

        public string Gender
        {
            get { return gender; }
            set { gender = value; OnPropertyChanged(); }
        }

        private string status = null;

        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(); }
        }

        private bool _IsUpdate;

        public bool IsUpdate
        {
            get { return _IsUpdate; }
            set { _IsUpdate = value; OnPropertyChanged(); }
        }


        #endregion

        #region Command 
        public ICommand CloceCommand { get; set; }
        private ICommand _SaveCommand;

        public ICommand SaveCommand
        {
            get { return new RelayCommand((p) => onCreate()); }
            set { _SaveCommand = value; }
        }

        private ICommand _UpdateCommand;

        public ICommand UpdateCommand
        {
            get { return new RelayCommand((p) => onUpdate(), (p) => onvalid()); }
            set { _UpdateCommand = value; }
        }

        #endregion

        #region Functions
        private void onCreate()
        {
            if (onFieldValid())
            {
                Task.Run(async () =>
                {
                    var responseMessage = await Service.onCreate(this.User);

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        Close(responseMessage.IsSuccessStatusCode);
                    }
                    else
                    {
                        Close(responseMessage.IsSuccessStatusCode);
                    }
                   
                }).Wait();
            }
            

        }


        private void onUpdate()
        {

            if (onFieldValid())
            {
                Task.Run(async () =>
                {
                    var responseMessage = await Service.onUpdate(this.User);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        Close(responseMessage.IsSuccessStatusCode);
                    }
                    else
                    {
                        Close(responseMessage.IsSuccessStatusCode);
                    }
                   
                }).Wait();
            }
        }

        private bool onvalid()
        {
            return !string.IsNullOrWhiteSpace(this.User.Name) && !string.IsNullOrWhiteSpace(User.Email) && regex.IsMatch(User.Email) && !string.IsNullOrWhiteSpace(User.Gender) && !string.IsNullOrWhiteSpace(User.Status);
        }

        private bool onFieldValid()
        {
            
            if (string.IsNullOrWhiteSpace(User.Name))
            {
                Name = "This field is required";
            }
            else if (User.Name.Length < 5)
            {
                Name = "Name should contaian atleast 5 character";
            }
            else
            {
                Name = null;
            }


            if (string.IsNullOrWhiteSpace(User.Email))
            {
                Email = "This field is required";
            }
            else if (!regex.IsMatch(User.Email))
            {
                Email = "Please enter valid email";
            }
            else
            {
                Email = null;
            }

            if (string.IsNullOrWhiteSpace(User.Gender))
            {
                Gender = "This field is required";
            }
            else
            {
                Gender = null;
            }

            if (string.IsNullOrWhiteSpace(User.Status))
            {
                Status = "This field is required";
            }
            else
            {
                Status = null;
            }

            if(Name==null && Gender ==null && Email == null && Status == null)
            {
                return true;
            }
            return false;
        }
    }
    #endregion
}

