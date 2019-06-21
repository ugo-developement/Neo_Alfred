using System;
using Neo_Alfred.Properties;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Neo_Alfred.DataLayer;
using System.Globalization;

namespace Neo_Alfred.BusinessLayer
{
    class SalesDataTable_Business : Base_Business
    {
        private static double tmp = 0.0;

        private static double _avgBasketToday = 0.0;

        private static double _avgBasketWeek = 0.0;

        public static void GetSalesDataToday()
        {
            using (Data_AllTablesDataContext db = new Data_AllTablesDataContext("Data Source=10.1.10.114,1434;Initial Catalog=benDover;Persist Security Info=True;User ID=ugoadmin;Password=ugo-2019"))
            {
                CultureInfo ci = new CultureInfo("en-us");

                // Set the number of orders for today (12:00:00 am - 11:59:59 pm)
                var q = from theORDERs in db.theORDERs
                        where theORDERs.oTimeStamp.Date.CompareTo(DateTime.Now.Date) >= 0
                        select theORDERs;
                Properties.Settings.Default.Orders_Today = q.Count();

                // Set the average basket size for today
                foreach (var y in q)
                {
                    _avgBasketToday += double.Parse(y.BasketSize.ToString("N"));
                }
                Properties.Settings.Default.BAVG_Today = Math.Round(_avgBasketToday / q.Count(), 1);

                // Set the average price for today
                tmp = 0.0;
                foreach (var z in q)
                {
                    tmp += double.Parse(z.Total.ToString("N"));
                }
                Properties.Settings.Default.PAVG_Today = Math.Round(tmp / q.Count(), 2).ToString("C", ci);

                // Set the number of orders for the trailing week
                var qw = from theORDERs in db.theORDERs
                         where theORDERs.oTimeStamp.Date.CompareTo(DateTime.Now.AddDays(-7).Date) >= 0
                         select theORDERs;
                Properties.Settings.Default.Orders_Week = qw.Count();

                // Set the average basket size for the trailing week
                foreach (var yw in qw)
                {
                    _avgBasketWeek += double.Parse(yw.BasketSize.ToString("N"));
                }
                _avgBasketWeek = Math.Round(_avgBasketToday / qw.Count(), 1);
                Properties.Settings.Default.BAVG_Week = _avgBasketWeek;

                // Set the average price for the trailing week
                tmp = 0.0;
                foreach (var zw in qw)
                {
                    tmp += double.Parse(zw.Total.ToString("N"));
                }
                Properties.Settings.Default.PAVG_Week = Math.Round(tmp / qw.Count(), 2).ToString("C", ci);

                // Set the number of orders for the trailing month
                var qm = from theORDERs in db.theORDERs
                         where theORDERs.oTimeStamp.Date.CompareTo(DateTime.Now.AddDays(-31).Date) >= 0
                         select theORDERs;
                Properties.Settings.Default.Orders_Month = qm.Count();

                // Set the average basket size for the trailing month
                tmp = 0.0;
                foreach (var ym in qm)
                {
                    tmp += double.Parse(ym.BasketSize.ToString("N"));
                }
                Properties.Settings.Default.BAVG_Month = Math.Round(tmp / qm.Count(), 1);

                // Set the average price for the trailing month
                tmp = 0.0;
                foreach (var tm in qm)
                {
                    tmp += double.Parse(tm.Total.ToString("N"));
                }
                Properties.Settings.Default.PAVG_Month = Math.Round(tmp / qm.Count(), 2).ToString("C", ci);

                Properties.Settings.Default.Save();
            }
        }
    }
}
