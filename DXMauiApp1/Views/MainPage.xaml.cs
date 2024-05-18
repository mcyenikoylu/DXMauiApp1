using DXMauiApp1.ViewModels;
using System.Runtime.CompilerServices;

namespace DXMauiApp1.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}