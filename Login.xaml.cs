using MaterialDesignThemes;
using System.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace Neo_Alfred
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        /*
         * 
         * Get username and password
         * on submit button click
         * and (securely) transfer 
         * this info to the connection
         * layer. Store connection
         * string in encrypted config
         * upon successful connection.
         * 
         */

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            ProgressBar pb = new ProgressBar();
            Style style = FindResource("MaterialDesignCircularProgressBar") as Style;
            pb.Style = style;
            pb.Width = 40;
            pb.Height = 40;
            pb.IsIndeterminate = true;
            login_btn.Content = pb;

            if (username.Text.Length != 0 && password.SecurePassword.Length != 0)
            {
                try
                {
                    ConnectionStringSettings settings =
                    ConfigurationManager.ConnectionStrings["connection"];
                    string connect = settings.ConnectionString;

                    SqlConnection connection = new SqlConnection(connect);

                    connection.Open();

                    //bool user_exists = false;

                    using (SqlCommand login_user = new SqlCommand(
                        "SELECT Count(1) FROM login WHERE Username=@username AND Password=@password",
                        connection))
                    {
                        login_user.CommandType = System.Data.CommandType.Text;
                        login_user.Parameters.AddWithValue("@username", username.Text);
                        login_user.Parameters.AddWithValue("@password", password.Password);
                        int count = Convert.ToInt32(login_user.ExecuteScalar());
                        if (connection.State == System.Data.ConnectionState.Open && count > 0)
                        {
                            connection.Close();
                            MainWindow main = new MainWindow();
                            main.InitializeComponent();
                            main.Show();
                            this.Close();
                        } 
                        else
                        {
                            MessageBox.Show("Username or Password is incorrect.");
                        }
                    }
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                }
                catch (InvalidCastException y)
                {
                    MessageBox.Show(y.Message);
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
            }
       
            else
            {
                MessageBox.Show("The Username or Password fields cannot be left empty.");
            }


    login_btn.Content = "Submit";
        }

        private void Login_btn_TouchDown(object sender, TouchEventArgs e)
        {
            Button_Click_Login(sender, e);
        }
    }
}
