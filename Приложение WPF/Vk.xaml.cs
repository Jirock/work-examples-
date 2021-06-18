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

namespace LitDisto
{
    /// <summary>
    /// Логика взаимодействия для Vk.xaml
    /// </summary>
    public partial class Vk : Window
    {
        public Vk()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lorem ipsum dolor sit amet");
        }
    }
}
