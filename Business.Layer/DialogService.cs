using Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Business.Layer
{
    public class DialogService : BaseViewModel, IDialogService
    {
        private BaseViewModel _dialogContent;
        private Visibility _dialogVisibility = Visibility.Collapsed;
        private bool _isOpen = false;
        private TaskCompletionSource<bool> _taskCompletionSource = null;

        public string Test { get; set; } = "test";
        public BaseViewModel DialogContent
        {
            get => _dialogContent;
            set { _dialogContent = value; OnPropertyChanged(); }
        }

        public Visibility DialogVisibility
        {
            get => _dialogVisibility;
            set
            {
                _dialogVisibility = value;
                OnPropertyChanged();
            }
        }

        public bool IsOpen
        {
            get => _isOpen;
            set 
            { 
                _isOpen = value; 
                OnPropertyChanged(); 
            }
        }

        Visibility IDialogService.DialogVisibility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<T> ShowDialog<TViewModel, T>(TViewModel viewModel) where TViewModel : BaseViewModel, IDialogRequestClose<T>
        {
            EventHandler<DialogCloseRequestedEventArgs<T>> handler = null;

            _taskCompletionSource = new TaskCompletionSource<bool>();

            handler = (sender, e) =>
            {
                viewModel.CloseRequested -= handler;

                //if (e.DialogResult.HasValue)
                {
                    viewModel.DialogResult = e.DialogResult;
                }

                IsOpen = false;

                _taskCompletionSource?.TrySetResult(true);
            };

            viewModel.CloseRequested += handler;

            DialogContent = viewModel;
            DialogVisibility = Visibility.Visible;

            IsOpen = true;

            await _taskCompletionSource.Task;

            return viewModel.DialogResult;
        }
    }


    public class BaseViewModel<T> : BaseViewModel
    {
        private T _SelectedItem;
        private IEnumerable<T> _Source;//todo

        public T SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                {
                    OnSelectedItemChange(value);
                }
            }
        }

        //Extra
        public IEnumerable<T> Source
        {
            get { return _Source; }
            set
            {
                if (_Source != value)
                {
                    _Source = OnSourceChanged(value);
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnSelectedItemChange(T value)
        {
            _SelectedItem = value;//todo
            OnPropertyChanged(nameof(SelectedItem));
        }

        public virtual IEnumerable<T> OnSourceChanged(IEnumerable<T> psource)
        {
            return psource;
        }
    }

    public class BaseDialog<T> : BaseViewModel, IDialogRequestClose<T>
    {
        public T DialogResult { get; set; }

        public event EventHandler<DialogCloseRequestedEventArgs<T>> CloseRequested;

        protected void Close(T obj)
        {
            CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs<T>(obj));

        }

    }

}
