﻿using System;
using Microsoft.Office.Interop.Excel;

namespace Reports.PennDotBridge
{
    internal class Bridge5To4Nhs:PennDotBaseReport, IReportActions
    {
        public Bridge5To4Nhs(string networkId, string simulationId, _Worksheet oSheet) 
            : base(networkId, simulationId,oSheet)
        {

        }

        public void CreateReport()
        {
            Report.SheetPageSetup(Sheet, "Bridge 5 to 4 NHS", 50d, 20d, 10d, "", DateTime.Now.ToLongDateString(), "Page &P", 11);
        }
    }
}
