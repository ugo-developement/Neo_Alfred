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

namespace Neo_Alfred.VisualControls.PageHome_Ctrls
{
    /// <summary>
    /// Interaction logic for SalesWeek_Table.xaml
    /// </summary>
    public partial class SalesWeek_Table : UserControl
    {
        public SalesWeek_Table()
        {
            InitializeComponent();
            NumOrders.Content = Properties.Settings.Default.Orders_Week;
            AvgBasket.Content = Properties.Settings.Default.BAVG_Week;
            AvgPrice.Content = Properties.Settings.Default.PAVG_Week;
        }
    }
}
