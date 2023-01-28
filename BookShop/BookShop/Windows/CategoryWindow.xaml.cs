using BookStore.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        public CategoryWindow()
        {
            InitializeComponent();
            
            EntityModel entityModel = new EntityModel();
            var data = entityModel.Category.ToList();
            //cmbBox.Items.Add(data);
            //cmbBoxDel.Items.Add(data);
            //cmbBoxDelSub.Items.Add(data);
            // операция не допустима, когда itemsourcre используется
            cmbBox.ItemsSource = data;
            cmbBoxDel.ItemsSource = data;
            cmbBoxDelSub.ItemsSource = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EntityModel model1 = new EntityModel();
                List<string> CategoryNames = new List<string>();
                model1.Category.Add(new Category()
                {
                    Name = tbxcatAdd.Text
                });
                model1.SaveChanges();
                cmbBoxDel.ItemsSource = model1.Category.ToList();
                MessageBox.Show("Category successfully added");
    
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
               
            
        }
        private void Deleting_Category(object sender, RoutedEventArgs e)
        {

            try
            {
                EntityModel entityModel = new EntityModel();
                string info = cmbBoxDel.Text;
                entityModel.Category.Remove(entityModel.Category.Single(w => w.Name == info));
                entityModel.SaveChanges();
                //cmbBoxDel.ItemsSource = "";
               cmbBoxDel.Items.Remove(cmbBoxDel.SelectedItem);
                MessageBox.Show("Successfully deleted category");
               // cmbBoxDel.EndUpdate();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
        private void Deleting_Sub_Category(object sender, RoutedEventArgs e)
        {
            try
            {
                EntityModel entityModel = new EntityModel();
                string info = cmbBoxDelSub.Text;
                entityModel.Category.Remove(entityModel.Category.Single(w => w.Name == info));
                entityModel.SaveChanges();
                cmbBoxDel.ItemsSource = "";
                MessageBox.Show("Successfully deleted sub category");
              //  cmbBoxDel.UpdateLayout();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Sub_Category_Add(object sender, RoutedEventArgs e)
        {
            EntityModel entityModel = new EntityModel();
            entityModel.Category.Add(new Category()
            {
                Name = txtBoxAdd.Text,
            });
            entityModel.SaveChanges();
            MessageBox.Show("Sub category successfully added");
            
        }
    }
    }

