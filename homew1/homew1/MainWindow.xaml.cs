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
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace homew1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string xmlPath = "https://habrahabr.ru/rss/interesting/";
            //var count = 0;
            //try
            //{
            //    XmlDocument xmlDocument = new XmlDocument();
            //    xmlDocument.Load(xmlPath);
            //    XmlElement xmlElement = xmlDocument.DocumentElement;
            //    foreach (XmlNode xnode in xmlElement)
            //    {
            //        foreach (XmlNode xmlNode in xnode.ChildNodes)
            //        {
            //            if (xmlNode.Name == "title")
            //                labelTitle.Content += xmlNode.InnerText;
            //            else if (xmlNode.Name == "description")
            //                labelDescription.Content += xmlNode.InnerText;
            //            else if (xmlNode.Name == "managingEditor")
            //                labelManagingEditor.Content += xmlNode.InnerText;
            //            else if (xmlNode.Name == "pubDate")
            //                labelPubdate.Content += xmlNode.InnerText;
            //            else if (xmlNode.Name == "generator")
            //                labelGenerator.Content += xmlNode.InnerText;
            //            else if (xmlNode.Name == "item")
            //                count++;
            //                txtBox.Text = count.ToString();

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                var count = 0;
                List<Item> items = new List<Item>();
                XmlDocument xml = new XmlDocument();
                xml.Load("https://habr.com/ru/rss/interesting/");
                XmlElement xmlElement = xml.DocumentElement;
                foreach (XmlElement xnode in xmlElement)
                {
                    Item item = new Item();

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "title")
                            item.Title = childnode.InnerText;
                        if (childnode.Name == "description")
                            item.Description = childnode.InnerText;
                        if (childnode.Name == "pubDate")
                            item.PubDate = childnode.InnerText;
                        if (childnode.Name == "link")
                            item.Link = childnode.InnerText;
                        if (childnode.Name == "item")
                            count++;
                        txtBox.Text = count.ToString();
                    }
                    items.Add(item);

                }
                foreach (var data in items)
                {
                    labelTitle.Content = data.Title;
                    labelPubdate.Content = data.PubDate;
                    labelDescription.Content = data.Description;
                    labelGenerator.Content = data.Link;
                    try
                    {
                        Item item = new Item();
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Item));

                        using (FileStream fs = new FileStream("examples.xml", FileMode.Create))
                        {
                            xmlSerializer.Serialize(fs, item);
                        }

                    }
                    catch (Exception ex)
                    {
                        labelEx.Content = ex.Message;

                    }
                }
              


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    XmlDocument xml = new XmlDocument();
            //    xml.Load("https://habrahabr.ru/rss/interesting/");
            //    XmlElement xRoot = xml.DocumentElement;

            //    XmlElement itemElement = xml.CreateElement("item"); // внутри айтема userelem
            //    XmlElement titelElement = xml.CreateElement("title");
            //    XmlElement descElement = xml.CreateElement("description");

            //    XmlText titleText = xml.CreateTextNode(labelTitle.Content.ToString());

            //    itemElement.AppendChild(titleText);

            //    xRoot.AppendChild(itemElement);
            //    string Path = @"C:\Users\bezve\Desktop";
            //    xml.Save(Path);
            //}
            //catch (Exception ex)
            //{
            //    labelEx.Content = ex.Message;

            //}
         



        }
    }
}
