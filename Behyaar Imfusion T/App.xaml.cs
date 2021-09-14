using Behyaar_Imfusion_T.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Behyaar_Imfusion_T
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
           this.InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow view = new MainWindow();
            view.DataContext = new MainWindowVM();
            view.ShowDialog();
        }
    }
}
