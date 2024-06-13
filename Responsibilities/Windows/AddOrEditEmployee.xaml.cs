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
using System.Windows.Shapes;
using Responsibilities.Entities;

namespace Responsibilities.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditEmployee.xaml
    /// </summary>
    public partial class AddOrEditEmployee : Window
    {
        public AddOrEditEmployee()
        {
            InitializeComponent();
            ComboBoxTypesOfWork.ItemsSource = Responsibilities.GetContext().TypesOfWork.ToList();
        }

        private void ComboBoxTypesOfWork_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
