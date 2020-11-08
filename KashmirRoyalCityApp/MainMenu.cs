using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewPlot_Click(object sender, EventArgs e)
        {
            NewPlotRecordForm newPlotRecordForm = new NewPlotRecordForm();
            newPlotRecordForm.Show();
        }

        private void btnNewPlotMouse_Hover(object sender, EventArgs e)
        {
            lblInfoTip.Text = "Add Record for a new Plot sold to a customer.";
        }

        private void btnNewPlotMouse_Exit(object sender, EventArgs e)
        {
            lblInfoTip.Text = "Please Select an option to continue";
        }

        private void btnPlotRecord_Click(object sender, EventArgs e)
        {
            PlotRecordViewer plotRecordForm = new PlotRecordViewer();
            plotRecordForm.Show();
        }

        private void btnPlotRecord_Hover(object sender, EventArgs e)
        {
            lblInfoTip.Text = "View record of a plot by searching for plot number or plot block.";
        }

        private void btnPlotRecord_Exit(object sender, EventArgs e)
        {
            lblInfoTip.Text = "Please Select an option to continue";
        }

        private void btnInstallment_Click(object sender, EventArgs e)
        {
            InstallmentForm installmentRecordForm = new InstallmentForm();
            installmentRecordForm.Show();
        }

        private void btnInstallment_Hover(object sender, EventArgs e)
        {
            lblInfoTip.Text = "Add or view record of an installment collected from a customer.";
        }

        private void btnInstallment_Exit(object sender, EventArgs e)
        {
            lblInfoTip.Text = "Please Select an option to continue";
        }
    }
}
