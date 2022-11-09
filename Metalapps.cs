using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation //DO NOT change the namespace name
{
    public class Metalapps            //DO NOT change the class name
    {
        //Implement the property as per the description
        //Implement the methods as per the description
        public void AddSalesDetails(SalesDetails sd)
        {
            List<SalesDetails> sales = new List<SalesDetails>();
            sales.Add(new SalesDetails(sd.SalesId,sd.CustomerName,sd.NoOfUnits,sd.NetAmount));
        }
        public void CalculateNetAmount(SalesDetails details)
        {
            int units = details.NoOfUnits;


            if (units <= 5)
                details.NetAmount = 75350 * units;
            else if (units > 5 && units <= 10)
                details.NetAmount = 75350 * units * 0.98;
            else if (units > 10 && units <= 15)
                details.NetAmount = 75350 * units * 0.95;
            else if (units > 15 && units <= 20)
                details.NetAmount = 75350 * units * 0.92;
            else if (units > 20)
                details.NetAmount = 75350 * units * 0.90;
        }
    }
}
