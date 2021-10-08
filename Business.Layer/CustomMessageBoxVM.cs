using Common;
using System.Windows.Input;

namespace Business.Layer
{
    /// <summary>
    /// This is the class which shows the popup confirmation type
    /// </summary>
    public class CustomMessageBoxVM : BaseDialog<bool>
    {
        #region Constructor
        public CustomMessageBoxVM(string message,MessageType messageType = MessageType.Success)
        {
            Message = message;
            if (messageType == MessageType.Success)
            {
                TitleColor = "#00c853";
                Title = MessageType.Success.ToString();
            }
            else if (messageType == MessageType.Success)
            {
                TitleColor = "#c30000";
                Title = MessageType.Error.ToString();
            }

            OkCommand = new RelayCommand((p)=>Close(true));
        }

        #endregion

        #region Private variables & Public property

        private string _Message;
        public string Message
        {
            get { return _Message; }
            set { _Message = value; OnPropertyChanged(); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(); }
        }

        private string titleColor;

        public string TitleColor
        {
            get { return titleColor; }
            set { titleColor = value; OnPropertyChanged(); }
        }

        #endregion

        #region Public method
        public ICommand OkCommand { get; set; }

        #endregion

    }
}
