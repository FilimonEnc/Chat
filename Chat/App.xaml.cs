using Chat.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Chat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Mutex mut = null!;
        private static bool createdNew = true;

        protected override void OnStartup(StartupEventArgs e)
        {
            mut = new Mutex(true, "Chat",out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("Приложение уже запущено");
                mut = null!;
                Current.Shutdown();
                return;
            }

            base.OnStartup(e);
            MainWindow = new MainWindow();
            MainWindow.Show();

        }
    }
}
