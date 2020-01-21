using QuizletCheatCards.View;
using QuizletCheatCards.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QuizletCheatCards
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainView view = new MainView();
            view.DataContext = new MainViewModel();
            view.Show();
        }
    }
}
