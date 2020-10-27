using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KashmirRoyalCityApp
{
    class PlotInfoDTO
    {
        private string plotRegNo;
        private string plotSize;
        private string plotNumber;
        private string plotBlock;
        private string plotPrice;
        private string plotRegistrationDate;
        private int plotIsNormal;
        private int plotIsCorner;
        private int plotIsCommercial;
        PlotInfoDTO()
        {

        }
        public PlotInfoDTO(PlotInfoControl plotInfoControl)
        {
            plotRegNo = plotInfoControl.plotRegNo;
            plotNumber = plotInfoControl.plotNumber;
            plotSize = plotInfoControl.plotSize;
            plotBlock = plotInfoControl.plotBlock;
            plotPrice = (int.Parse(plotInfoControl.cashReceived) + int.Parse(plotInfoControl.remainingAmmount)).ToString();
            plotRegistrationDate = plotInfoControl.plotIssueDate;
            plotIsCommercial = plotInfoControl.isPlotCommercial;
            plotIsNormal = plotInfoControl.isPlotNormal;
            plotIsCorner = plotInfoControl.isPlotCorner;
        }

        public SqlCommand insertQuery(SqlConnection dbConnection)
        {
            string insertQuery = $"INSERT INTO plot_info (plot_reg_id, plot_size, plot_number, plot_block, plot_price, plot_registration_date, plot_is_normal, plot_is_corner, plot_is_commercial) VALUES(@{Constants.PlotInfoTable.plot_reg_id}, @{Constants.PlotInfoTable.plot_size}, @{Constants.PlotInfoTable.plot_number}, @{Constants.PlotInfoTable.plot_block}, @{Constants.PlotInfoTable.plot_price}, @{Constants.PlotInfoTable.plot_registration_date}, @{Constants.PlotInfoTable.plot_is_normal}, @{Constants.PlotInfoTable.plot_is_corner}, @{Constants.PlotInfoTable.plot_is_commercial})";
            SqlCommand insertCommand = new SqlCommand(insertQuery, dbConnection);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_reg_id}", plotRegNo);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_size}", plotSize);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_number}", plotNumber);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_block}", plotBlock);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_price}", plotPrice);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_registration_date}", plotRegistrationDate);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_is_normal}", plotIsNormal);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_is_corner}", plotIsCorner);
            insertCommand.Parameters.AddWithValue($"@{Constants.PlotInfoTable.plot_is_commercial}", plotIsCommercial);
            return insertCommand;
        }
    }
}
