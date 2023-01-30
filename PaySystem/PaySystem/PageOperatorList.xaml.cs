using PaySystem.lib;
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

namespace PaySystem
{
    /// <summary>
    /// Логика взаимодействия для PageOperatorList.xaml
    /// </summary>
    public partial class PageOperatorList : Page
    {
        public PageOperatorList()
        {
            InitializeComponent();
            OperatorService operatorService = new OperatorService();
            lvOperatorList.ItemsSource = operatorService.GetOperators();
        }

        private void btnEditData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Operators data = (Operators)lvOperatorList.SelectedItem;
                AddOperator add = new AddOperator(data);
                Administrator._frameMain.Navigate(add);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
                


        }
    }
}
