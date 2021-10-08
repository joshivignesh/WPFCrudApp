using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Common
{
    /// <summary>
    /// Base class for ViewModel
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;
        public Action<string> action = null;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            action?.Invoke(propertyName);
        }
    }

    /// <summary>
    /// Enum for various Message type in UI
    /// </summary>
    public enum MessageType
    {
        Info,
        Confirmation,
        Success,
        Warning,
        Error,
    }


}
