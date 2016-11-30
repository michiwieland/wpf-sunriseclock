using MahApps.Metro.Controls;
using SunriseClock.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SunriseClock.Model;
using SunriseClock.Service;

namespace SunriseClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        ClockApi api;
        Configuration conf;

        public MainWindow()
        {
            InitializeComponent();

            initData();
            saveData();
        }

        public void initData()
        {
            // TODO: Error Handling
            api = new ClockApi();
            conf = api.GetConfiguration();
        }

        public void saveData()
        {
            // TODO: Error Handling
            api.SetConfiguration(conf);
        }
    }
}
