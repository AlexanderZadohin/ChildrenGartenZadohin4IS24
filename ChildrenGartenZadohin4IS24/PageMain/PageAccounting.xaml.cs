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
    /// Логика взаимодействия для PageAccounting.xaml
    /// </summary>
    public partial class PageAccounting : Page
    {
        public PageAccounting()
        {
            InitializeComponent();


            ChooseTypeEventCmb.SelectedValuePath = "id";
            ChooseTypeEventCmb.DisplayMemberPath = "OrientationName";
            ChooseTypeEventCmb.ItemsSource = App.context.Orientation.ToList();

            ChooseTypeGroupCmb.SelectedValuePath = "id";
            ChooseTypeGroupCmb.DisplayMemberPath = "TypeName";
            ChooseTypeGroupCmb.ItemsSource = App.context.TypeGroup.ToList();

            ChooseEventCmb.SelectedValue = "id";
            ChooseEventCmb.DisplayMemberPath = "NameEvent";
            ChooseEventCmb.ItemsSource = App.context.Event.ToList();

            ChooseGroupCmb.SelectedValue = "id";
            ChooseGroupCmb.DisplayMemberPath = "GroupName";
            ChooseGroupCmb.ItemsSource = App.context.Group.ToList();

            MarkCmb.SelectedValue = "id";
            MarkCmb.DisplayMemberPath = "Name";
            MarkCmb.ItemsSource = App.context.Mark.ToList();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }

        private void ChooseTypeGroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedTG=Convert.ToInt32(ChooseTypeGroupCmb.SelectedValue);
            ChooseGroupCmb.ItemsSource=App.context.Group.Where(x=>x.TypeId == SelectedTG).ToList();
        }

        private void ChooseTypeEventCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedTE=Convert.ToInt32(ChooseTypeEventCmb.SelectedValue);
            ChooseEventCmb.ItemsSource=App.context.Event.Where(x=>x.OrientationId == SelectedTE).ToList();
        }

        private void AddAcountingBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(DTPick.Text))
                mes += "Выберите дату!\n";

            if (string.IsNullOrWhiteSpace(ChooseEventCmb.Text))
                mes += "Выберите мероприятие!\n";

            if (string.IsNullOrWhiteSpace(ChooseGroupCmb.Text))
                mes += "Выберите группу!\n";

            if (string.IsNullOrWhiteSpace(ChooseTypeEventCmb.Text))
                mes += "Выберите тип мероприятия!\n";

            if (string.IsNullOrWhiteSpace(ChooseTypeGroupCmb.Text))
                mes += "Выберите тип группы!\n";
            if (string.IsNullOrWhiteSpace(MarkCmb.Text))
                mes += "Выберите оценку!\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            RegistrationVisit registrationVisit = new RegistrationVisit()
            {
                Group = ChooseGroupCmb.SelectedItem as Group,
                DateEvent = (DateTime)DTPick.SelectedDate,
                Mark = MarkCmb.SelectedItem as Mark,
                Event = ChooseEventCmb.SelectedItem as Event
            };
            App.context.RegistrationVisit.Add(registrationVisit);
            App.context.SaveChanges();
            MessageBox.Show("Оценка добавлена");

            DTPick.Text = "";
            ChooseEventCmb.Text = "";
            ChooseGroupCmb.Text = "";
            ChooseTypeEventCmb.Text = "";
            ChooseTypeGroupCmb.Text = "";
            MarkCmb.Text = "";
        }
    }
}
