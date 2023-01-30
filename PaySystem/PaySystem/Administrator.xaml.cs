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

namespace PaySystem
{
    /// <summary>
    /// Логика взаимодействия для Administrator.xaml
    /// </summary>
    public partial class Administrator : Window
    {
        public static Frame _frameMain;
        public Administrator()
        {
            InitializeComponent();
            _frameMain = frameMain;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               // frameMain = new Frame();
                PageOperatorList pageOperatorList = new PageOperatorList();
                frameMain.Source = new Uri("PageOperatorList.xaml", UriKind.RelativeOrAbsolute);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
