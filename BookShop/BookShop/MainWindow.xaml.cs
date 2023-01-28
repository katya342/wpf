using BookShop.Windows;
using BookStore.lib;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            framePage.Source = new Uri("Pages/_pageStart.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            framePage.Source = new Uri("Pages/_pageRegistration.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserService userService = new UserService();
            if(userService.UserCheckin(tbxUserName.Text, pbPassword.Password) == true)
            {
               _AdminWindow _AdminWindow = new _AdminWindow();
                this.Close();
              
             _AdminWindow.Topmost = true;
                 _AdminWindow.Show();
            }

        }
        private void Label_Contact_Mouse_Double_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
           
                ContactWindow contactWindow = new ContactWindow();
                this.Close();
                contactWindow.Topmost = true;
                contactWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
