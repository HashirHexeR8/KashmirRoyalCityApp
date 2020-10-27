using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace KashmirRoyalCityApp
{
    public partial class NomineeInfoControl : UserControl
    {
        public NomineeInfoControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNomineeReq.Checked)
            {
                tbNomineeAddress.Enabled = false;
                tbNomineeName.Enabled = false;
                tbNomineeFatherName.Enabled = false;
                tbNomineeRelation.Enabled = false;
            }
            else
            {
                tbNomineeAddress.Enabled = true;
                tbNomineeName.Enabled = true;
                tbNomineeFatherName.Enabled = true;
                tbNomineeRelation.Enabled = true;
            }
        }

        public string nomineeName
        {
            get { return tbNomineeName.Text == null ? "" : tbNomineeName.Text; }
        }

        public string nomineeFatherName
        {
            get { return tbNomineeFatherName.Text == null ? "" : tbNomineeFatherName.Text; }
        }

        public string nomineeRelationWithNominee
        {
            get { return tbNomineeRelation.Text == null ? "" : tbNomineeRelation.Text; }
        }

        public string nomineeAddress
        {
            get { return tbNomineeAddress.Text == null ? "" : tbNomineeAddress.Text; }
        }

        public string validateFields()
        {
            if (cbNomineeReq.Checked)
            {
                return "";
            }
            var validationMessageList = new List<string>();
            try
            {
                bool areAllFieldsValid = false;
                if (String.IsNullOrEmpty(tbNomineeName.Text))
                {
                    validationMessageList.Add(lblNomineeName.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbNomineeFatherName.Text))
                {
                    validationMessageList.Add(lblNomineeFatherName.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbNomineeRelation.Text))
                {
                    validationMessageList.Add(lblNomineeRelation.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbNomineeAddress.Text))
                {
                    validationMessageList.Add(lblNomineeAddress.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                return string.Join("\n", validationMessageList);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the information?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PlotInfoControl plotInfoControl = CommunicatorClass.mPlotInfoControl;
                CustomerInfoControl customerInfoControl = CommunicatorClass.mCustomerInfoControl;
                string validationMessage = "\n" + plotInfoControl.validateFields() + "\n" + customerInfoControl.validateFields() + "\n" + validateFields();
                if (!String.IsNullOrEmpty(plotInfoControl.validateFields()) || !String.IsNullOrEmpty(customerInfoControl.validateFields()) || !String.IsNullOrEmpty(this.validateFields()))
                { 
                    MessageBox.Show($"Following fields cannot be empty: {validationMessage}", "Error"); 
                }
                else
                {
                    NomineeInfoDTO nomineeInfoDTO = new NomineeInfoDTO(this, customerInfoControl, plotInfoControl.plotRegNo);
                    PlotInfoDTO plotInfoDTO = new PlotInfoDTO(plotInfoControl);
                    SqlConnection sqlConnection = new SqlConnection();
                    int customerId = 0;
                    sqlConnection.ConnectionString = ("Data Source=DESKTOP-KQQ01QD\\SQLEXPRESS;Initial Catalog=C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\KASHMIRROYALCITYDB.MDF;Integrated Security=True");
                    try
                    {
                        sqlConnection.Open();
                        using (SqlCommand insertPlotInfocommand = plotInfoDTO.insertQuery(sqlConnection))
                        {
                            insertPlotInfocommand.ExecuteNonQuery();
                        }
                        using (SqlCommand insertCustomerInfoCommand = nomineeInfoDTO.insertQuery(sqlConnection))
                        {
                            customerId = (int)insertCustomerInfoCommand.ExecuteNonQuery();
                        }
                        InstallmentDTO installmentInfoDTO = new InstallmentDTO(int.Parse(plotInfoControl.plotInstallmentAmmount), int.Parse(plotInfoControl.cashReceived) + int.Parse(plotInfoControl.remainingAmmount), customerId, plotInfoControl.plotRegNo, plotInfoControl.plotIssueDate);
                        using (SqlCommand insertInstallmentInfoCommand = installmentInfoDTO.insertQuery(sqlConnection))
                        {
                            insertInstallmentInfoCommand.ExecuteNonQuery();
                        }
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
            else
            {

            }
        }
    }
}
