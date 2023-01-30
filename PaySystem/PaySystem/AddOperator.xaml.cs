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
    /// Логика взаимодействия для AddOperator.xaml
    /// </summary>
    public partial class AddOperator : Page
    {
        public AddOperator(Operators operators)
        {
            InitializeComponent();
            if (operators == null)
            {
                btnAdd.Content = "Add";
            }
               
            else
            {
                btnAdd.Content = "Edit";
                tbxName.Text = operators.Name;
                tbxLogo.Text = operators.Logo;
                tbxPhone.Text = operators.Phone;
                tbxPrecent.Text = operators.Percent.ToString();
                tbxId.Text = operators.Id.ToString();
            }
              
                
        }
       
    }
}
