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
    /// Логика взаимодействия для PageJournal.xaml
    /// </summary>
    public partial class PageJournal : Page
    {
        public PageJournal()
        {
            InitializeComponent();
            DataGr.ItemsSource = App.context.RegistrationVisit.ToList();

            TypeEvent.SelectedValuePath = "id";
            TypeEvent.DisplayMemberPath = "OrientationName";
            TypeEvent.ItemsSource = App.context.Orientation.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }

        private void TypeEvent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedTE = Convert.ToInt32(TypeEvent.SelectedValue);
            DataGr.ItemsSource = App.context.RegistrationVisit.Where(x => x.Event.OrientationId == SelectedTE).ToList();
        }
    }
}
