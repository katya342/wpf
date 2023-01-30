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

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для _SectionPage.xaml
    /// </summary>
    public partial class _SectionPage : Page
    {
        public _SectionPage()
        {
            InitializeComponent();
            List<TestinProgramm> list = new List<TestinProgramm>();
            TestinProgramm section = new TestinProgramm()
            {
                Text = "Основополагающими принципами деятельности Республики являются:\r\nобщественное согласие и политическая стабильность, экономическое\r\nразвитие на благо всего народа, казахстанский патриотизм, решение\r\nнаиболее важных вопросов государственной жизни демократическими\r\nметодами, включая голосование на республиканском референдуме или\r\nв Парламенте",
                Section = "Раздел 1. Общие положения.\r\nРеспублика Казахстан утверждает себя демократическим, светским,\r\nправовым и социальным государством, высшими ценностями которого\r\nявляются человек, его жизнь, права и свободы.",
                Question = "ccc"
            };
            list.Add(section);
            txtblckTestInfo.DataContext = list;

        }
    }
}
