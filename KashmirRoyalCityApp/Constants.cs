using System;
using System.Collections.Generic;
using System.Text;

namespace KashmirRoyalCityApp
{
    static class Constants
    {
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
            static string installment_ammount = "installment_amount";
            static string remaining_ammount = "remaining_ammount";
            static string total_ammount = "total_ammount";
            static string customer_id = "customer_id";
            static string plot_reg_no = "plot_reg_no";
            static string installment_date = "installment_date";
        }
    }
}
