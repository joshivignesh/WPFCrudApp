using Common;
using Data.Access.Layer;
using Service.Layer;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Business.Layer
{
    /// <summary>
    /// Main View class where code execution gets triggered from View (XAML file)
    /// </summary>
    public class VM_Main : BaseViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VM_Main()
        {
            Service = new UserService();
            Service.Init();
            onload();
            DialogHost = new DialogService();
            CreateCommand = new RelayCommand((p) => onCreate());
            EditCommand = new RelayCommand((p) => onEdit(p));
            RemoveCommand = new RelayCommand((p) => ondelete(p));
            FilterCommand = new RelayCommand((p) => onFilter());
            ClearFilterCommand = new RelayCommand((p) => onload());
        }

        #region Prop
        public DialogService DialogHost { get; set; }
        public IUserService Service;

        private ObservableCollection<User> items;

        public ObservableCollection<User> Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged(); }
        }

        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; OnPropertyChanged(); }
        }

        private int searchwithNumber;

        public int SearchwithNumber 
        {   get { return searchwithNumber; }
            set { searchwithNumber = value; OnPropertyChanged(); } 
        }

        #endregion

        #region Command 
        public ICommand CreateCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand FilterCommand { get; set; }
        public ICommand ClearFilterCommand { get; set; }
        #endregion

        #region Functions
        async void onCreate()
        {
            var response = await DialogHost.ShowDialog<UserViewModel, bool>(new UserViewModel());

            if (response)
            {
                bool? Result = await DialogHost.ShowDialog<CustomMessageBoxVM, bool>(new CustomMessageBoxVM("Insert successfully", MessageType.Success));
                if (Result.HasValue)
                {
                    onload();
                }
            }
        }

        private async void onEdit(object p)
        {
            User para = (User)p;
            UserModel userModel = new UserModel
            {
                Id = para.Id,
                Name = para.Name,
                Gender = para.Gender,
                Email = para.Email,
                Status = para.Status
            };

            var response = await DialogHost.ShowDialog<UserViewModel, bool>(new UserViewModel(userModel));

            if (response)
            {
                // bool? Result = new CustomMessageBox("Update successfully  ", MessageType.Success, MessageButtons.Ok).ShowDialog();
                bool? Result = await DialogHost.ShowDialog<CustomMessageBoxVM, bool>(new CustomMessageBoxVM("Update successfully", MessageType.Success));
                Items = new ObservableCollection<User>();
                //Task.Run(async () =>
                //{
                    var data = await Service.onGetUsers();
                    foreach (var item in data)
                    {
                        Items.Add(item);
                    }
                //}).Wait();
            }
        }

        async void ondelete(object p)
        {
            User para = (User)p;
            UserModel userModel = new UserModel
            {
                Id = para.Id,
                Name = para.Name,
                Gender = para.Gender,
                Email = para.Email,
                Status = para.Status
            };
            HttpResponseMessage responseMessage = await Service.onDelete(para.Id);

            if (responseMessage.IsSuccessStatusCode)
            {
                bool? Result = await DialogHost.ShowDialog<CustomMessageBoxVM, bool>(new CustomMessageBoxVM("Record deleted successfully", MessageType.Success));
                onload();
            }
        }

        void onload()
        {
            //Items = new ObservableCollection<User>();
            //Task.Run(async () =>
            //{

            //    var data = await Service.onGetUsers();
            //    foreach (var item in data)
            //    {
            //        Items.Add(item);
            //    }
            //}).Wait();

            Task.Factory.StartNew(async () =>
            {
                var data = await Service.onGetUsers();
                Items = new ObservableCollection<User>(data);

            });
        }

        void onFilter()
        {
            if (string.IsNullOrWhiteSpace(Search))
            {
                onload();
            }
            else
            {
                Task.Factory.StartNew(async() =>
                {
                    var data = await Service.onGetUserByName(search);
                    Items = new ObservableCollection<User>(data);                    
                });               
            }
        }
        #endregion
    }
}
