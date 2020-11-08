using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace KashmirRoyalCityApp
{
    static class Constants
    {
        public static string ConnectionString = ("Data Source=DESKTOP-KQQ01QD\\SQLEXPRESS;Initial Catalog=C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\KASHMIRROYALCITYDB.MDF;Integrated Security=True");
        public interface PlotInfoTable
        {
            static string table_name = "plot_info";

            //Plot Info Column Name
            static string plot_reg_id = "plot_reg_id";
            static string plot_size = "plot_size";
            static string plot_number = "plot_number";
            static string plot_block = "plot_block";
            static string plot_price = "plot_price";
            static string plot_registration_date = "plot_registration_date";
            static string plot_is_normal = "plot_is_normal";
            static string plot_is_commercial = "plot_is_commercial";
            static string plot_is_corner = "plot_is_corner";

            static string plot_info_query = $"select plot_number AS 'Plot Number', plot_block AS 'Plot Block', plot_size AS 'Plot Size', plot_price AS 'Plot Price', plot_registration_date AS 'Registration Date', customer_name AS 'Customer Name', customer_cnic AS 'CNIC', customer_current_address AS 'Current Address', customer_permanent_address AS 'Permenant Address', customer_contact_mobile AS 'Mobile #', customer_contact_home AS 'Home #', customer_email AS 'Email', customer_successor_name AS 'Nominee Name', customer_successor_relation AS 'Relation with Nominee', customer_successor_address AS 'Nominee Address' from plot_info left join customer_info cs ON cs.customer_plot_reg_no = plot_reg_id WHERE plot_number LIKE @{plot_number} OR plot_block LIKE @{plot_block}";
        }

        public interface CustomerInfoTable
        {
            static string table_name = "customer_info";

            //Plot Info Column Name
            static string customer_name = "customer_name";
            static string customer_father_name = "customer_father_name";
            static string customer_cnic = "customer_cnic";
            static string customer_current_address = "customer_current_address";
            static string customer_permenant_address = "customer_permenat_address";
            static string customer_profession = "customer_profession";
            static string customer_contact_number_mobile = "customer_contact_number_mobile";
            static string customer_contact_number_home = "customer_contact_number_home";
            static string customer_contact_number_office = "customer_contact_number_office";
            static string customer_email = "customer_email";
            static string customer_successor_name = "customer_successor_name";
            static string customer_successor_father_name = "customer_successor_father_name";
            static string customer_successor_relation = "customer_successor_relation";
            static string customer_successor_address = "customer_successor_address";
            static string customer_plot_reg_no = "customer_plot_reg_no";

        }

        public interface InstallmentRecordTable
        {
            static string table_name = "installment_record";

            //Plot Info Column Name
            static string installment_ammount = "installment_ammount";
            static string remaining_ammount = "remaining_ammount";
            static string total_ammount = "total_ammount";
            static string customer_id = "customer_id";
            static string plot_reg_no = "plot_reg_no";
            static string installment_date = "installment_date";

            static string installment_data_from_registration_number_query = $"SELECT install.{plot_reg_no}, plot.{PlotInfoTable.plot_number}, plot.{PlotInfoTable.plot_block}, install.{installment_ammount}, install.{total_ammount}, install.{remaining_ammount}, install.{installment_date} FROM {table_name} AS install " +
                $"LEFT JOIN plot_info as plot ON install.{plot_reg_no} = plot.{PlotInfoTable.plot_reg_id} WHERE {plot_reg_no} = @{plot_reg_no}";

            static string installment_single_item_data_query = $"SELECT TOP 1 {plot_reg_no}, {installment_ammount}, {total_ammount}, {customer_id}, {remaining_ammount}  FROM {table_name} WHERE {plot_reg_no} = @{plot_reg_no} ORDER BY {remaining_ammount} ASC";
        }
    }
}
