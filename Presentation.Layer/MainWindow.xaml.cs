using Business.Layer;
using System.Windows;

namespace Presentation.Layer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new VM_Main();
        }
    }
}
