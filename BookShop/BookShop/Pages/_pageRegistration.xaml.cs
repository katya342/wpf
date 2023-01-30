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
using System.Xml.Linq;

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для _pageRegistration.xaml
    /// </summary>
    public partial class _pageRegistration : Page
    {
        public _pageRegistration()  
        {
            InitializeComponent();
            EntityModel entity = new EntityModel();
            var data = entity.Users.ToList();
            foreach (var item in data)
            {
                CityList.ItemsSource = item.City;
            }
            //CityList.ItemsSource = data;

        }
    }
    

}
