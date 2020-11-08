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
    public partial class NewPlotRecordForm : Form
    {
        PlotInfoControl mPlotInfoControl = new PlotInfoControl();
        CustomerInfoControl mCustomerInfoControl = new CustomerInfoControl();
        NomineeInfoControl mNomineeInfoControl = new NomineeInfoControl();
        public NewPlotRecordForm()
        {
            InitializeComponent();
            CommunicatorClass.initializeCommunicatorClass(mPlotInfoControl, mCustomerInfoControl, mNomineeInfoControl);
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

        public NewPlotRecordForm(IContainer components)
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
    }
}
