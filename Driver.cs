using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation     //DO NOT change the namespace name
{
    public class Program          //DO NOT change the class name
    {
        static void Main(string[] args)         //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            SalesDetails obj = new SalesDetails();

            Console.WriteLine("Enter sales id: ");
            obj.SalesId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer name: ");
            obj.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the number of units sold: ");
            obj.NoOfUnits = int.Parse(Console.ReadLine());

            Metalapps app = new Metalapps();
            app.CalculateNetAmount(obj);
            app.AddSalesDetails(obj);

            Console.WriteLine("Sales Bill\n*********");
            Console.WriteLine("Sales Id: " + obj.SalesId);
            Console.WriteLine("Customer Name: " + obj.CustomerName);
            Console.WriteLine("Number of units sold: " + obj.NoOfUnits);
            Console.WriteLine("Net Amount: " + obj.NetAmount);
        }
    }

}
	 	  	 	 	   	  	    	 	
