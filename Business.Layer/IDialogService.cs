using System;
using System.Threading.Tasks;
using System.Windows;
using Common;

namespace Business.Layer
{
    public interface IDialogService
    {
         BaseViewModel DialogContent { get; set; }//todo

         Visibility DialogVisibility { get; set; }
         Task<T> ShowDialog<TViewModel, T>(TViewModel viewModel) where TViewModel : BaseViewModel, IDialogRequestClose<T>;
    }

    public interface IDialogRequestClose<T>
    {
         event EventHandler<DialogCloseRequestedEventArgs<T>> CloseRequested;

         T DialogResult { get; set; }
    }

    public class DialogCloseRequestedEventArgs<T> : EventArgs
    {
        public DialogCloseRequestedEventArgs(T dialogResult)
        {
            DialogResult = dialogResult;
        }

        public T DialogResult { get; }
    }
}
