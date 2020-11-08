using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class InstallmentForm : Form
    {
        public InstallmentForm()
        {
            InitializeComponent();
            AddInstallmentControl addInstallmentControl = new AddInstallmentControl();
            installmentMainPanel.Controls.Add(addInstallmentControl);
            addInstallmentControl.BringToFront();
        }
    }
}
