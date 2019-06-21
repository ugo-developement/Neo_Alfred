using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Neo_Alfred.BusinessLayer;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Neo_Alfred.VisualControls.PageHome_Ctrls
{
    /// <summary>
    /// Interaction logic for SalesToday_Table.xaml
    /// </summary>
    public partial class SalesToday_Table : UserControl
    {
        public SalesToday_Table()
        {
            
            //SalesDataTable_Business.GetSalesDataToday();
           
            InitializeComponent();
            DataContext = new SalesDataTable_Business();
            NumOrders.Content = Properties.Settings.Default.Orders_Today;
            AvgBasket.Content = Properties.Settings.Default.BAVG_Today;
            AvgPrice.Content = Properties.Settings.Default.PAVG_Today;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SalesDataTable_Business.GetSalesDataToday();
            NumOrders.Content = Properties.Settings.Default.Orders_Today;
            AvgBasket.Content = Properties.Settings.Default.BAVG_Today;
            AvgPrice.Content = Properties.Settings.Default.PAVG_Today;
        }
    }
}
