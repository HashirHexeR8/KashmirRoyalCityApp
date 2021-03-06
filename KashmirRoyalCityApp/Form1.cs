using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KashmirRoyalCityApp
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            DBRunner dbRunner = new DBRunner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = tbUserName.Text;
            String userPassword = tbUserPasswoed.Text;
           
            if (userName.Length == 0 || userPassword.Length == 0)
            {
                MessageBox.Show("Both username and password are required", "Error");
            }
            else
            {
                try
                {
                    String loginQuery = $"Select user_id FROM user_info where user_name = '{userName}' AND user_password = '{userPassword}'";
                    using (SQLiteDataReader reader = DBRunner.executeReadQuery(loginQuery))
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine($"User Id Returned From DB: {reader["user_id"]}");
                            this.Hide();
                            MainMenu mainMenu = new MainMenu();
                            mainMenu.Closed += (s, args) => this.Close();
                            mainMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Inavlid Username or passowrd", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while logging into system please contact admin for support.", "Error");
                }
            }
        }
    }
}
