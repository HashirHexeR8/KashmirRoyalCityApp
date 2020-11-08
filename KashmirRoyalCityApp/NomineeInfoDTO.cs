using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KashmirRoyalCityApp
{
    class NomineeInfoDTO
    {
        private string customerName;
        private string customerFatherName;
        private string customerCnic;
        private string customerCurrentAddress;
        private string customerPermanentAddress;
        private string customerProfession;
        private string customerContactMobile;
        private string customerContactHome;
        private string customerContactWork;
        private string customerEmail;
        private string nomineeName;
        private string nomineeFatherName;
        private string nomineeRelation;
        private string nomineeAddress;
        private string customerPlotRegNo;
        NomineeInfoDTO()
        {

        }
        public NomineeInfoDTO(NomineeInfoControl nomineeInfoControl, CustomerInfoControl customerInfoControl, string plotRegNo)
        {

            customerName = customerInfoControl.customerName;
            customerFatherName = customerInfoControl.customerFatherName;
            customerCnic = customerInfoControl.customerCNIC;
            customerProfession = customerInfoControl.customerProfession;
            customerEmail = customerInfoControl.customerEmail;
            customerContactMobile = customerInfoControl.customerContactMobile;
            customerContactHome = customerInfoControl.customerContactHome;
            customerContactWork = customerInfoControl.customerContactWork;
            customerCurrentAddress = customerInfoControl.customerCurrentAddress;
            customerPermanentAddress = customerInfoControl.customerPermanentAddress;
            nomineeName = nomineeInfoControl.nomineeName;
            nomineeFatherName = nomineeInfoControl.nomineeFatherName;
            nomineeRelation = nomineeInfoControl.nomineeRelationWithNominee;
            nomineeAddress = nomineeInfoControl.nomineeAddress;
            customerPlotRegNo = plotRegNo;
        }

        public SqlCommand insertQuery(SqlConnection dbConnection)
        {
            string insertQuery = $"INSERT INTO customer_info VALUES(@{Constants.CustomerInfoTable.customer_name}, @{Constants.CustomerInfoTable.customer_father_name}, @{Constants.CustomerInfoTable.customer_cnic}, @{Constants.CustomerInfoTable.customer_current_address}, @{Constants.CustomerInfoTable.customer_permenant_address}, @{Constants.CustomerInfoTable.customer_profession}, @{Constants.CustomerInfoTable.customer_contact_number_mobile}, @{Constants.CustomerInfoTable.customer_contact_number_home}, @{Constants.CustomerInfoTable.customer_contact_number_office}, @{Constants.CustomerInfoTable.customer_email}, @{Constants.CustomerInfoTable.customer_successor_name}, @{Constants.CustomerInfoTable.customer_successor_father_name}, @{Constants.CustomerInfoTable.customer_successor_relation}, @{Constants.CustomerInfoTable.customer_successor_address}, @{Constants.CustomerInfoTable.customer_plot_reg_no}); SELECT SCOPE_IDENTITY()";
            SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnection);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_name}", customerName);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_father_name}", customerFatherName);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_cnic}", customerCnic);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_profession}", customerProfession);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_current_address}", customerCurrentAddress);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_permenant_address}", customerPermanentAddress);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_contact_number_home}", customerContactHome);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_contact_number_mobile}", customerContactMobile);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_contact_number_office}", customerContactWork);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_email}", customerEmail);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_successor_name}", nomineeName);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_successor_father_name}", nomineeFatherName);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_successor_address}", nomineeAddress);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_successor_relation}", nomineeRelation);
            insertCommand.Parameters.AddWithValue($"@{Constants.CustomerInfoTable.customer_plot_reg_no}", customerPlotRegNo);
            return insertCommand;
        }
    }
}
