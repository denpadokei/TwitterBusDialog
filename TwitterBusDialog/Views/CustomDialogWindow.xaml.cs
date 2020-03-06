using Prism.Services.Dialogs;
using System.Windows;

namespace TwitterBusDialog.Views
{
    /// <summary>
    /// Interaction logic for CustomDialogWindow.xaml
    /// </summary>
    public partial class CustomDialogWindow : Window, IDialogWindow
    {
        public CustomDialogWindow()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }
    }
}
