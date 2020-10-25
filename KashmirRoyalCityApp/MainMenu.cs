using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class MainMenu : Form
    {
        PlotInfoControl mPlotInfoControl = new PlotInfoControl();
        CustomerInfoControl mCustomerInfoControl = new CustomerInfoControl();
        NomineeInfoControl mNomineeInfoControl = new NomineeInfoControl();
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(IContainer components)
        {
            this.components = components;
        }

        private void btnPlotInfo_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(mPlotInfoControl))
            {
                panelMain.Controls.Add(mPlotInfoControl);
                mPlotInfoControl.BringToFront();
            }
            else
            {
                mPlotInfoControl.BringToFront();
            }
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(mCustomerInfoControl))
            {
                panelMain.Controls.Add(mCustomerInfoControl);
                mCustomerInfoControl.BringToFront();
            }
            else
            {
                mCustomerInfoControl.BringToFront();
            }
        }

        private void btnNomineeInfo_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(mNomineeInfoControl))
            {
                panelMain.Controls.Add(mNomineeInfoControl);
                mNomineeInfoControl.BringToFront();
            }
            else
            {
                mNomineeInfoControl.BringToFront();
            }
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelNomineeInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
