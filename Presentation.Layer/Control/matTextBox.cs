using Common;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Presentation.Layer.Control
{
    public class matTextBox : System.Windows.Controls.TextBox
    {
        public ICommand IconCommand { get; set; }

        public matTextBox()
        {
            IconCommand = new RelayCommand((p) => { Text = null; });
        }

        #region Enums
        public enum TextBoxModes { Numeric, AlphaNumeric }
        public enum TextBoxCurrencyModes { NO, C2, C3, AlphaNumeric }
        public enum TextBoxDefult_ValueTypes { STRING, C1, C2, C3 }
        #endregion

        #region DependencyProperty

        public bool HideClearButton
        {
            get { return (bool)GetValue(HideClearButtonProperty); }
            set { SetValue(HideClearButtonProperty, value); }
        }

        public static readonly DependencyProperty HideClearButtonProperty =
            DependencyProperty.Register("HideClearButton", typeof(bool), typeof(matTextBox), new PropertyMetadata(false));



        public bool IsNotValid
        {
            get { return (bool)GetValue(IsNotValidProperty); }
            set { SetValue(IsNotValidProperty, value); }
        }

        public static readonly DependencyProperty IsNotValidProperty =
            DependencyProperty.Register("IsNotValid", typeof(bool), typeof(matTextBox), new PropertyMetadata(false));


        public TextBoxCurrencyModes CurrencyMode
        {
            get { return (TextBoxCurrencyModes)GetValue(CurrencyModeProperty); }
            set { SetValue(CurrencyModeProperty, value); }
        }
        public static readonly DependencyProperty CurrencyModeProperty =
            DependencyProperty.Register("CurrencyMode", typeof(TextBoxCurrencyModes), typeof(matTextBox), new PropertyMetadata(TextBoxCurrencyModes.AlphaNumeric));

        public TextBoxModes Mode
        {
            get { return (TextBoxModes)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }
        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(TextBoxModes), typeof(matTextBox), new PropertyMetadata(TextBoxModes.AlphaNumeric));

        public string AssistiveText
        {
            get { return (string)GetValue(AssistiveTextProperty); }
            set { SetValue(AssistiveTextProperty, value); }
        }

        public static readonly DependencyProperty AssistiveTextProperty =
            DependencyProperty.Register("AssistiveText", typeof(string), typeof(matTextBox), new PropertyMetadata(""));

        public string TextHeader
        {
            get { return (string)GetValue(TextHeaderProperty); }
            set { SetValue(TextHeaderProperty, value); }
        }
        public static readonly DependencyProperty TextHeaderProperty =
            DependencyProperty.Register("TextHeader", typeof(string), typeof(matTextBox), new PropertyMetadata("matTextBox"));

        public string ErrorMessage
        {
            get { return (string)GetValue(ErrorMessageProperty); }
            set { SetValue(ErrorMessageProperty, value); }
        }

        public static readonly DependencyProperty ErrorMessageProperty =
            DependencyProperty.Register("ErrorMessage", typeof(string), typeof(matTextBox), new PropertyMetadata(""));

        private void UcTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            matTextBox tb = (matTextBox)sender;
            tb.Select(tb.Text.Length, 0);

        }

        public bool SliedUp
        {
            get { return (bool)GetValue(SliedUpProperty); }
            set { SetValue(SliedUpProperty, value); }
        }

        public static readonly DependencyProperty SliedUpProperty =
            DependencyProperty.Register("SliedUp", typeof(bool), typeof(matTextBox), new PropertyMetadata(true));

        public TextBoxDefult_ValueTypes MyDefault_Val
        {
            get { return (TextBoxDefult_ValueTypes)GetValue(MyDefault_ValProperty); }
            set { SetValue(MyDefault_ValProperty, value); }
        }

        public static readonly DependencyProperty MyDefault_ValProperty =
            DependencyProperty.Register("MyDefault_Val", typeof(TextBoxDefult_ValueTypes), typeof(matTextBox), new PropertyMetadata(TextBoxDefult_ValueTypes.C2));




        public bool IsLastTextBox
        {
            get { return (bool)GetValue(IsLastTextBoxProperty); }
            set { SetValue(IsLastTextBoxProperty, value); }
        }
        public static readonly DependencyProperty IsLastTextBoxProperty =
            DependencyProperty.Register("IsLastTextBox", typeof(bool), typeof(matTextBox), new PropertyMetadata(false));


        #endregion
    }
}
