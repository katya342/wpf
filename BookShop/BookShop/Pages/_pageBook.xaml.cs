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

namespace BookShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для _pageBook.xaml
    /// </summary>
    public partial class _pageBook : Page
    {
        public _pageBook()
        {
            InitializeComponent();
            EntityModel entity = new EntityModel();
            Book books = new Book();
            var data = entity.Book.ToList();
            this.DataContext = data;
            //lblBookName.DataContext = data;
            
            if(books.Name == null)
            {
                MessageBox.Show("Name property not filled");
            }
            else
            {
                //
            }
            
        }
    }
}
