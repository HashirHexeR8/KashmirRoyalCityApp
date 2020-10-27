﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KashmirRoyalCityApp
{
    class InstallmentDTO
    {
        private int installmentAmmount;
        private int totalAmmount;
        private int remainingAmmount;
        private string installmentDate;
        private int customerId;
        private string plotRegNo;

        InstallmentDTO()
        {

        }
        public InstallmentDTO(int installmentAmmount, int totalAmmount, int customerId, string plotRegNo, string installmentDate)
        {
            this.installmentAmmount = installmentAmmount;
            this.remainingAmmount = totalAmmount - installmentAmmount;
            this.totalAmmount = totalAmmount;
            this.installmentDate = installmentDate;
            this.customerId = customerId;
            this.plotRegNo = plotRegNo;
        }

        public SqlCommand insertQuery(SqlConnection dbConnection)
        {
            string insertQuery = $"INSERT INTO installment_record VALUES ( @{Constants.InstallmentRecordTable.installment_ammount}, @{Constants.InstallmentRecordTable.remaining_ammount}, @{Constants.InstallmentRecordTable.total_ammount}, @{Constants.InstallmentRecordTable.customer_id}, @{Constants.InstallmentRecordTable.plot_reg_no}, @{Constants.InstallmentRecordTable.installment_date})";
            SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnection);
            insertCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.installment_ammount}", installmentAmmount);
            insertCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.remaining_ammount}", remainingAmmount);
            insertCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.total_ammount}", totalAmmount);
            insertCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.customer_id}", customerId);
            insertCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.plot_reg_no}", plotRegNo);
            insertCommand.Parameters.AddWithValue($"@{Constants.InstallmentRecordTable.installment_date}", installmentDate);
            return insertCommand;
        }
    }
}
