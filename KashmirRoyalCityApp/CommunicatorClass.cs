using System;
using System.Collections.Generic;
using System.Text;

namespace KashmirRoyalCityApp
{
    static class CommunicatorClass
    {
        public static PlotInfoControl mPlotInfoControl;
        public static CustomerInfoControl mCustomerInfoControl;
        public static NomineeInfoControl mNomineeInfoControl;
        public static void initializeCommunicatorClass(PlotInfoControl plotInfoControl, CustomerInfoControl customerInfoControl, NomineeInfoControl nomineeInfoControl)
        {
            mPlotInfoControl = plotInfoControl;
            mCustomerInfoControl = customerInfoControl;
            mNomineeInfoControl = nomineeInfoControl;
        }
    }
}
