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

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для BookMainWindow.xaml
    /// </summary>
    public partial class BookMainWindow : Window
    {
        public BookMainWindow()
        {
            InitializeComponent();
            this.bookPage.Navigate(new Uri("Pages/_pageBook.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
