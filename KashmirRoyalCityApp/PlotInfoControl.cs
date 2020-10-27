using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace KashmirRoyalCityApp
{
    public partial class PlotInfoControl : UserControl
    {
        public PlotInfoControl()
        {
            InitializeComponent();
        }

        public string plotRegNo
        {
            get { return tbPlotRegNo.Text == null ? "" : tbPlotRegNo.Text;  }
        }

        public string plotNumber
        {
            get { return tbPlotNo.Text == null ? "" : tbPlotNo.Text; }
        }

        public string plotSize
        {
            get { return tbPlotSize.Text == null ? "" : tbPlotSize.Text; }
        }

        public string plotBlock
        {
            get { return tbPlotBlockName.Text == null ? "" : tbPlotBlockName.Text; }
        }

        public string plotInstallmentAmmount
        {
            get { return tbPlotInstallmentAmmount.Text == null ? "" : tbPlotInstallmentAmmount.Text; }
        }

        public string cashReceived
        {
            get { return tbCashReceived.Text == null ? "" : tbCashReceived.Text; }
        }

        public string remainingAmmount
        {
            get { return tbPlotRemainingAmmount.Text == null ? "" : tbPlotRemainingAmmount.Text; }
        }

        public string plotIssueDate
        {
            get { return dpPlotIssueDate.Text == null ? "" : dpPlotIssueDate.Text; }
        }

        public int isPlotCorner
        {
            get { return cbPlotTypeCorner.Checked == true ? 1 : 0; }
        }
        public int isPlotNormal
        {
            get { return cbPlotTypeNormal.Checked == true ? 1 : 0; }
        }
        public int isPlotCommercial
        {
            get { return cbPlotTypeCommercial.Checked == true ? 1 : 0; }
        }

        public string validateFields()
        {
            var validationMessageList = new List<string>();
            try
            {
                bool areAllFieldsValid = false;
                if (String.IsNullOrEmpty(tbPlotRegNo.Text))
                {
                    validationMessageList.Add(lbRegNo.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbPlotInstallmentAmmount.Text))
                {
                    validationMessageList.Add(lblInstallmentAmmount.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbPlotNo.Text))
                {
                    validationMessageList.Add(lblPlotNumber.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCashReceived.Text))
                {
                    validationMessageList.Add(lblCashReceived.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbPlotSize.Text))
                {
                    validationMessageList.Add(lblPlotSize.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbPlotRemainingAmmount.Text))
                {
                    validationMessageList.Add(lblRemainingAmmount.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbPlotBlockName.Text))
                {
                    validationMessageList.Add(lblPlotBlockName.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (areAllFieldsValid)
                {
                    return "";
                }
                else
                {
                    return string.Join("\n", validationMessageList);
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
