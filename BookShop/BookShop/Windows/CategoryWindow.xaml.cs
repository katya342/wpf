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
            var dataSub = entityModel.SubCategory.ToList();
            //cmbBox.Items.Add(data);
            foreach (var item in data)
            {
                cmbBoxDel.Items.Add(item);
            }
            foreach (var item in dataSub)
            {
                cmbBoxDelSub.Items.Add(item);
                cmbBox.Items.Add(item);
            }

            
        }



        // Add simple category (button)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EntityModel model1 = new EntityModel();
                
                    model1.Category.Add(new Category()
                    {
                        Name = tbxcatAdd.Text
                    });
                    model1.SaveChanges();
                    var info = model1.Category.ToList();
                    cmbBoxDel.Items.Add(info.Last());
                    MessageBox.Show("Category successfully added");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        // Deleting simple category
        private void Deleting_Category(object sender, RoutedEventArgs e)
        {

            try
            {
                EntityModel entityModel = new EntityModel();
                var data = entityModel.Category.Single(w => w.Name == cmbBoxDel.Text);
                cmbBoxDel.DataContext = data;
                entityModel.Category.Remove(data);
                entityModel.SaveChanges();
                //cmbBoxDel.ItemsSource = "";
               cmbBoxDel.Items.Remove(cmbBoxDel.SelectedItem);
                MessageBox.Show("Successfully deleted category");
          
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
                var data = entityModel.SubCategory.Single(w => w.SubName == cmbBoxDelSub.Text);
                cmbBoxDelSub.DataContext = data;
                entityModel.SubCategory.Remove(data);
                entityModel.SaveChanges();
                cmbBoxDelSub.Items.Remove(cmbBoxDelSub.SelectedItem);
                MessageBox.Show("Successfully deleted sub - category");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Add sub-category (button)
        private void Sub_Category_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                EntityModel entityModel = new EntityModel();
                Random rand = new Random();
                entityModel.SubCategory.Add(new SubCategory()
                {
                    SubName = txtBoxAdd.Text,
                    Parent_Id = rand.Next(1, 10)
                });
                entityModel.SaveChanges();
                var temp = entityModel.SubCategory.ToList();
                cmbBoxDelSub.Items.Add(temp.Last());
                MessageBox.Show("Sub - category successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

