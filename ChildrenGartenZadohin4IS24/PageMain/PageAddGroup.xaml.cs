using ChildrenGartenZadohin4IS24.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для PageAddGroup.xaml
    /// </summary>
    public partial class PageAddGroup : Page
    {
        public PageAddGroup()
        {
            InitializeComponent();
            TypeGroupCMB.SelectedValuePath = "id";
            TypeGroupCMB.DisplayMemberPath = "TypeName";
            TypeGroupCMB.ItemsSource = App.context.TypeGroup.ToList();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(GroupNameTB.Text))
                mes += "Введите группу\n";
            if (string.IsNullOrWhiteSpace(TypeGroupCMB.Text))
                mes += "Выберите тип группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Group addgroup = new Group()
            {
                GroupName = GroupNameTB.Text,
                TypeGroup = TypeGroupCMB.SelectedItem as TypeGroup 
            };
            App.context.Group.Add(addgroup);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена!");

            GroupNameTB.Text = "";
            TypeGroupCMB.Text = "";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }
    }
}
