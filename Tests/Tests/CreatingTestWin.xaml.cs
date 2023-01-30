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

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для CreatingTestWin.xaml
    /// </summary>
    public partial class CreatingTestWin : Window
    {
        public CreatingTestWin()
        {
            InitializeComponent();
            if (cmbBox_1.IsSelected == true)
            {
                sectionPage.Source = new Uri("_Sectionpage.xaml", UriKind.RelativeOrAbsolute);
            }
            else
            {
                MessageBox.Show("Select Section please");
            }
          
        }
    }
}
