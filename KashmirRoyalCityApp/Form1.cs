using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = tbUserName.Text;
            String userPassword = tbUserPasswoed.Text;
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.Show();
        }
    }
}
