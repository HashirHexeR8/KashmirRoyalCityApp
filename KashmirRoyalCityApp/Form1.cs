﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection = new SqlConnection();
        
        public Form1()
        {
            InitializeComponent();
            sqlConnection.ConnectionString = ("Data Source=DESKTOP-KQQ01QD\\SQLEXPRESS;Initial Catalog=C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\KASHMIRROYALCITYDB.MDF;Integrated Security=True");
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
                    sqlConnection.Open();
                    String loginQuery = $"Select Id FROM user_login where user_name = '{userName}' AND password = '{userPassword}'";
                    SqlCommand sqlCommand = new SqlCommand(loginQuery, sqlConnection);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine($"User Id Returned From DB: {reader["Id"]}");
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
                    sqlConnection.Close();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error while logging into system please contact admin for support.", "Error");
                }
            }
        }
    }
}
