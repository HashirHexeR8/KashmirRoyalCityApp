using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace KashmirRoyalCityApp
{
    class DBRunner
    {
        private static SQLiteConnection dbConnection;
        public DBRunner()
        {
            dbConnection = createConnection();
            createTable();
        }
        private static SQLiteConnection createConnection()
        {

            // Create a new database connection:
            string directory =  Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (!System.IO.File.Exists(directory + $"\\{Constants.DBName}"))
            {
                SQLiteConnection.CreateFile(directory + $"\\{Constants.DBName}");        // Create the file which will be hosting our database
            }
            string dbConnectionString = $"Data Source= {directory}\\{Constants.DBName}; Version = 3; New = True; Compress = True;";
            dbConnection = new SQLiteConnection(dbConnectionString);
            // Open the connection:
            try
            {
                dbConnection.Open();
            }
            catch (Exception ex)
            {
            }
            return dbConnection;
        }

        public static SQLiteConnection getDBConnection()
        {
            return dbConnection;
        }

        public static void executeQuery(string queryText)
        {

            SQLiteCommand sqlite_cmd;

            sqlite_cmd = dbConnection.CreateCommand();
            sqlite_cmd.CommandText = queryText;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static SQLiteDataReader executeReadQuery(string queryText)
        {

            SQLiteCommand sqlite_cmd;

            sqlite_cmd = dbConnection.CreateCommand();
            sqlite_cmd.CommandText = queryText;
            return sqlite_cmd.ExecuteReader();
        }

        private static void createTable()
        {

            string createUserInfoTable = $"CREATE TABLE IF NOT EXISTS {Constants.userInfoTable.table_name} ({Constants.userInfoTable.user_id} INTEGER PRIMARY KEY AUTOINCREMENT, {Constants.userInfoTable.user_full_name} VARCHAR, {Constants.userInfoTable.user_name} VARCHAR, {Constants.userInfoTable.user_password} VARCHAR )";
            SQLiteCommand createUserInfoTableCommand = dbConnection.CreateCommand();
            createUserInfoTableCommand.CommandText = createUserInfoTable;
            createUserInfoTableCommand.ExecuteNonQuery();

            string createCustomerInfoTable = $"CREATE TABLE IF NOT EXISTS customer_info ({Constants.CustomerInfoTable.customer_id} INTEGER PRIMARY KEY AUTOINCREMENT, {Constants.CustomerInfoTable.customer_name} TEXT, {Constants.CustomerInfoTable.customer_father_name} TEXT, {Constants.CustomerInfoTable.customer_cnic} TEXT, {Constants.CustomerInfoTable.customer_current_address} TEXT, {Constants.CustomerInfoTable.customer_permenant_address} TEXT, {Constants.CustomerInfoTable.customer_profession} TEXT, {Constants.CustomerInfoTable.customer_contact_number_mobile} TEXT, {Constants.CustomerInfoTable.customer_contact_number_home} TEXT, {Constants.CustomerInfoTable.customer_contact_number_office} TEXT, {Constants.CustomerInfoTable.customer_email} TEXT, {Constants.CustomerInfoTable.customer_successor_name} TEXT, {Constants.CustomerInfoTable.customer_successor_father_name} TEXT, {Constants.CustomerInfoTable.customer_successor_relation} TEXT, {Constants.CustomerInfoTable.customer_successor_address} TEXT , {Constants.CustomerInfoTable.customer_plot_reg_no} TEXT NOT NULL)";

            SQLiteCommand createCustomerInfoTableCommand = dbConnection.CreateCommand();
            createCustomerInfoTableCommand.CommandText = createCustomerInfoTable;
            createCustomerInfoTableCommand.ExecuteNonQuery();

            string createPlotInfoTable = $"CREATE TABLE IF NOT EXISTS plot_info ({Constants.PlotInfoTable.plot_reg_id} INTEGER PRIMARY KEY NOT NULL DEFAULT 0, {Constants.PlotInfoTable.plot_size} TEXT, {Constants.PlotInfoTable.plot_number} TEXT, {Constants.PlotInfoTable.plot_block} TEXT, {Constants.PlotInfoTable.plot_price} TEXT, {Constants.PlotInfoTable.plot_registration_date} TEXT, {Constants.PlotInfoTable.plot_is_normal} INTEGER DEFAULT 0, {Constants.PlotInfoTable.plot_is_corner} INTEGER DEFAULT 0, {Constants.PlotInfoTable.plot_is_commercial} INTEGER DEFAULT 0)";

            SQLiteCommand createPlotInfoTableCommand = dbConnection.CreateCommand();
            createPlotInfoTableCommand.CommandText = createPlotInfoTable;
            createPlotInfoTableCommand.ExecuteNonQuery();

            string createInstallmentRecordTable = $"CREATE TABLE IF NOT EXISTS installment_record ( {Constants.InstallmentRecordTable.installment_ammount} INTEGER NOT NULL DEFAULT 0, {Constants.InstallmentRecordTable.remaining_ammount} INTEGER NOT NULL DEFAULT 0, {Constants.InstallmentRecordTable.total_ammount} INTEGER NOT NULL DEFAULT 0, {Constants.InstallmentRecordTable.customer_id} INTEGER NOT NULL DEFAULT 0, {Constants.InstallmentRecordTable.plot_reg_no} INTEGER NOT NULL DEFAULT 0, {Constants.InstallmentRecordTable.installment_date} TEXT)";

            SQLiteCommand createInstallmentRecordTableCommand = dbConnection.CreateCommand();
            createInstallmentRecordTableCommand.CommandText = createInstallmentRecordTable;
            createInstallmentRecordTableCommand.ExecuteNonQuery();


            String loginQuery = $"Select user_id FROM user_info where user_name = 'test' AND user_password = 'test128'";
            using (SQLiteDataReader reader = DBRunner.executeReadQuery(loginQuery))
            {
                if (reader.Read())
                {
                    
                }
                else
                {
                    string insertTestUserQuery = $"INSERT INTO user_info (user_name, user_password, user_full_name) VALUES('test', 'test128', 'TEST USER')";

                    SQLiteCommand insertTestUserCommand = dbConnection.CreateCommand();
                    createInstallmentRecordTableCommand.CommandText = insertTestUserQuery;
                    createInstallmentRecordTableCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
