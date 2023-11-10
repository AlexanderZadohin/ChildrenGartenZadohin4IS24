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
using Orientation = ChildrenGartenZadohin4IS24.Model.Orientation;

namespace ChildrenGartenZadohin4IS24.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageAddAktiviti.xaml
    /// </summary>
    public partial class PageAddAktiviti : Page
    {
        public PageAddAktiviti()
        {
            InitializeComponent();

            TypeActivityCMB.SelectedValuePath = "id";
            TypeActivityCMB.DisplayMemberPath = "OrientationName";
            TypeActivityCMB.ItemsSource = App.context.Orientation.ToList();
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {

            string mes = "";
            if (string.IsNullOrWhiteSpace(ActivityNameTB.Text))
                mes += "Введите название мероприятия\n";
            if (string.IsNullOrWhiteSpace(TypeActivityCMB.Text))
                mes += "Выберите тип мероприятия\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Event addevent = new Event()
            {
                NameEvent = ActivityNameTB.Text,
                Orientation = TypeActivityCMB.SelectedItem as Orientation
            };
            App.context.Event.Add(addevent);
            App.context.SaveChanges();
            MessageBox.Show("Активность добавлена!");

            ActivityNameTB.Text = "";
            TypeActivityCMB.Text = "";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }
    }
}
