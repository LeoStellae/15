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

namespace _15.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Page
    {
        public Model1 DB { get; set; } = new Model1();
        public MainForm()
        {
            InitializeComponent();
            try
            {
               // ICPosts.ItemsSource = Model1.products.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Loaded += MainForm_Loaded;

        }

        private void MainForm_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
               // ICPosts.ItemsSource = Model1.products.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            var Login = new Login();
            NavigationService.Navigate(Login);
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
