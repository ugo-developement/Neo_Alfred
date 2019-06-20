using Neo_Alfred.BusinessLayer;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
namespace Neo_Alfred.VisualControls.PageHome_Ctrls
{
    /// <summary>
    /// Interaction logic for SalePriceRangeChart.xaml
    /// </summary>
    public partial class SalePriceRangeChart : UserControl
    {
        public SalePriceRangeChart()
        {
            InitializeComponent();

            List<int> countList = new List<int>();
            countList = SalesData_Business.OrderRanges();

            Values = new ChartValues<int> { countList[0], countList[1],
            countList[2], countList[3], countList[4]};

            Labels = new[] { "$0 - $10", "$10 - $15", "$15 - $20", "$20 - $25", "$25 - $30", "over $30" };

            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public ChartValues<int> Values { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
