using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KashmirRoyalCityApp 
{
    public partial class PlotRecordViewer : Form
    {
        SqlConnection mSqlConnection = new SqlConnection();
        public PlotRecordViewer()
        {
            InitializeComponent();
            mSqlConnection.ConnectionString = Constants.ConnectionString;
            string value = "";
            if (InputBox("Plot Information", "Enter Plot No or Plot Block:", ref value) == DialogResult.OK)
            {
                searchPlotInfo(value);
            }
        }

        public void searchPlotInfo(string value)
        {
            mSqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(Constants.PlotInfoTable.plot_info_query, mSqlConnection);
            selectCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_number}", value);
            selectCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_block}", value);
            try
            {
                SqlDataReader resultSet = selectCommand.ExecuteReader();
                DataTable installmentDataTable = new DataTable();
                installmentDataTable.Load(resultSet);
                dataGridView1.DataSource = installmentDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mSqlConnection.Close();
            }
            mSqlConnection.Close();
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
