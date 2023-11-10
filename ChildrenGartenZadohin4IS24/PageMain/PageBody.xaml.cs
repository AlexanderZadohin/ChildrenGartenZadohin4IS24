using ChildrenGartenZadohin4IS24.Model;
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

namespace ChildrenGartenZadohin4IS24.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageBody.xaml
    /// </summary>
    public partial class PageBody : Page
    {
        public PageBody()
        {
            InitializeComponent();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.PageAddGroup());
        }

        private void AddEventBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.PageAddAktiviti());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.PageJournal());
        }

        private void Journal_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.PageAccounting());
        }
    }
}
