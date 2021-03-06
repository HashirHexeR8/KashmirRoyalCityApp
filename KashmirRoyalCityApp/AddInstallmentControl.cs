using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KashmirRoyalCityApp
{
    public partial class AddInstallmentControl : UserControl
    {
        int mRemainingAmmount = 0;
        string mCustomerId = "";
        int mTotalAmmount = 0;
        public AddInstallmentControl()
        {
            InitializeComponent();
            string value = "";
            if (InputBox("Customer Installment", "Enter Registration No:", ref value) == DialogResult.OK)
            {
                searchPlotInfo(value);
            }
        }

        private bool searchPlotInfo(string plotRegNo)
        {
            SQLiteCommand selectCommand = new SQLiteCommand(Constants.InstallmentRecordTable.installment_data_from_registration_number_query, DBRunner.getDBConnection());
            selectCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.plot_reg_no}", plotRegNo);
            try
            {
                SQLiteDataReader resultSet = selectCommand.ExecuteReader();
                DataTable installmentDataTable = new DataTable();
                installmentDataTable.Load(resultSet);
                installmentDataGridView.DataSource = installmentDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLiteCommand selectLatestInstallmentRecordCommand = new SQLiteCommand(Constants.InstallmentRecordTable.installment_single_item_data_query, DBRunner.getDBConnection());
            selectLatestInstallmentRecordCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.plot_reg_no}", plotRegNo);
            try
            {
                SQLiteDataReader resultSet = selectLatestInstallmentRecordCommand.ExecuteReader();
                while(resultSet.Read())
                {
                    mCustomerId = resultSet.GetString(Constants.InstallmentRecordTable.customer_id);
                    mRemainingAmmount = resultSet.GetInt32(Constants.InstallmentRecordTable.remaining_ammount);
                    mTotalAmmount = resultSet.GetInt32(Constants.InstallmentRecordTable.total_ammount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnAddInstallment_Click(object sender, EventArgs e)
        {
            string registrationNumber = tbRegistrationNumber.Text;
            string installmentAmmount = tbInstallmentAmmount.Text;
            int installmentAmmountValue = 0;
            if (String.IsNullOrEmpty(registrationNumber) || String.IsNullOrEmpty(installmentAmmount))
            {
                MessageBox.Show("Fields cannot be empty", "Error");
            }
            else
            {
                try
                {
                    installmentAmmountValue = int.Parse(installmentAmmount);
                    if (installmentAmmountValue > mRemainingAmmount && mRemainingAmmount == 0)
                    {
                        MessageBox.Show("The customer is already paid up.", "Alert");
                        return;
                    }
                    else if (installmentAmmountValue > mRemainingAmmount)
                    {
                        MessageBox.Show($"Installment ammount cannot be more then remaining ammount. ", "Alert");
                        return;
                    }
                    else
                    {
                        persistInstallmentData(installmentAmmountValue, registrationNumber, dateTimePicker1.Text.ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("Installment Ammount is incorrect", "Error");
                }
            }
        }

        private void persistInstallmentData(int installmentAmmountValue, string plotRegNo, string installmentDate)
        {
            try
            {
                InstallmentDTO installmentInfoDTO = new InstallmentDTO(installmentAmmountValue, mTotalAmmount, mRemainingAmmount, installmentAmmountValue, int.Parse(mCustomerId), plotRegNo, installmentDate);
                using (SQLiteCommand insertInstallmentInfoCommand = installmentInfoDTO.insertQuery())
                {
                    insertInstallmentInfoCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Installment Ammount Received Successfully.", "Success.");
                searchPlotInfo(plotRegNo);
                tbRegistrationNumber.Text = "";
                tbInstallmentAmmount.Text = "";
                dateTimePicker1.Value = DateTime.Today.AddDays(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

    public static DialogResult InputBox(string title, string promptText, ref string value)
    {
            SearchDialogControl searchDialogControl = new SearchDialogControl();
     
        Form form = new Form();
        Label label = searchDialogControl.getSearchLable();
        TextBox textBox = searchDialogControl.getSearchBox();
        Button buttonOk = searchDialogControl.getSearchButton();
        Button buttonCancel = searchDialogControl.getCancelButton();

        form.Text = title;
        label.Text = promptText;
        textBox.Text = value;

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.AutoSize = true;

        form.ClientSize = new Size(549, 250);
        form.Controls.Add(searchDialogControl);
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.MinimizeBox = false;
        form.MaximizeBox = false;
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;

        DialogResult dialogResult = form.ShowDialog();
        value = textBox.Text;
        return dialogResult;
    }

}
}
