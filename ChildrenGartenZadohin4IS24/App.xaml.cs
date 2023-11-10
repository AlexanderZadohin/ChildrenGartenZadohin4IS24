using ChildrenGartenZadohin4IS24.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ChildrenGartenZadohin4IS24
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Zadohin4IS24IPSITEntities context = new Zadohin4IS24IPSITEntities();

    }
}
