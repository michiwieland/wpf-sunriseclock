using MahApps.Metro.Controls;
using SunriseClock.ViewModel;

namespace SunriseClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
       
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new AlarmViewModel();
        }        
    }
}
