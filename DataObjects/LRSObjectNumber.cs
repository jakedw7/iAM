﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataObjects
{
	public class LRSObjectNumber : LRSObject, INumericObject
    {
        private double m_dData;

        /// <summary>
        /// LRS Data for NUMBER Attributes
        /// </summary>
        public double Data
        {
            set { m_dData = value; }
            get { return m_dData; }
        }

        /// <summary>
        ///  LRS Attribute data obects (input as proper data types)
        /// </summary>
        /// <param name="strRoute"></param>
        /// <param name="dBeginStation"></param>
        /// <param name="dEndStation"></param>
        /// <param name="strDirection"></param>
        /// <param name="dateTime"></param>
        /// <param name="dData"></param>
        public LRSObjectNumber(String strRoute, double dBeginStation, double dEndStation, String strDirection, DateTime dateTime, double dData)
        {
            this.Route = strRoute;
            this.BeginStation = dBeginStation;
            this.EndStation = dEndStation;
            this.Direction = strDirection;
            this.Date = dateTime;
            this.Data = dData;
        }

        /// <summary>
        /// LRS Data Object created with return from Raw Attribute table
        /// </summary>
        /// <param name="row">Raw Attribute SELECT * datarow</param>
        public LRSObjectNumber(DataRow row)
        {
            this.Route = row["ROUTES"].ToString();
            this.BeginStation = double.Parse(row["BEGIN_STATION"].ToString());
            this.EndStation = double.Parse(row["END_STATION"].ToString());
            this.Direction = row["DIRECTION"].ToString();
            this.Date = DateTime.Parse(row["DATE"].ToString());
            this.Data = double.Parse(row["DATA"].ToString());
        }

		//public override bool IsNumeric
		//{
		//    get
		//    {
		//        return true;
		//    }
		//}


	}
}
