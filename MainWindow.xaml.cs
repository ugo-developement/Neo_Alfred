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
using Neo_Alfred.BusinessLayer;

namespace Neo_Alfred
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Refresh all of the stored data
            // on start up of the program.
            try
            {
                SalesDataTable_Business.GetSalesDataToday();
            }
            catch (Exception) { }
        }

        private void Btn_Home_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("Pages/Page_Home.xaml", UriKind.Relative);
        }

        private void Btn_Balances_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("Pages/Page_Balances.xaml", UriKind.Relative);
        }
    }
}
