using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BookShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для _AdminWindow.xaml
    /// </summary>
    public partial class _AdminWindow : Window
    {
        public _AdminWindow()
        {
            InitializeComponent();
        }

        private void DoubleClick_Category(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
                this.Close();
     
                CategoryWindow categoryWindow = new CategoryWindow();
                categoryWindow.Topmost = true;
                categoryWindow.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void DoubleClick_Books(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
                this.Close();

                BookMainWindow bookMainWindow = new BookMainWindow();
                bookMainWindow.Topmost = true;
                bookMainWindow.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
