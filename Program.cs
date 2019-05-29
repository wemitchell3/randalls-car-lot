using System;
using System.Collections.Generic;

namespace randalls_car_lot
{
    class Program
    {
        static void Main()
        {
            List<Dictionary<string, Dictionary<string, string>>> listOfAllCarSales = new List<Dictionary<string, Dictionary<string, string>>>();

            Dictionary<string, Dictionary<string, string>> carSale1 = new Dictionary<string, Dictionary<string, string>>() {

            };

            Dictionary<string, Dictionary<string, string>> carSale2 = new Dictionary<string, Dictionary<string, string>>() {

            };

            carSale1.Add("vehicle", new Dictionary<string, string>() {
            {"year", "2010"},
            {"model", "Damfresh"},
            {"make", "Biotraxquote"},
            {"color", "sky magenta"} 
            });

            carSale1.Add("sales_id", new Dictionary<string, string>() {
            {"value", "ecb1c841-1a43-4a7c-896e-712d2ec39c71"}
            });

            carSale1.Add("sales_agent", new Dictionary<string, string>() {
            {"mobile", "(896) 478-6975"},
            {"last_name", "Botsford"},
            {"first_name", "Shaina"},
            {"emails", "beatae_sonny@hotmail.com, shaina@aol.com"}
            });

            carSale1.Add("purchase_date", new Dictionary<string, string>() {
            {"value", "2017-11-15"}
            });

            carSale1.Add("gross_profit", new Dictionary<string, string>() {
            {"value", "871.26"}
            });

            carSale1.Add("credit", new Dictionary<string, string>() {
            {"credit_provider", "J.P.Morgan Chase & Co"},
            {"account", "601109582720302"}
            });


            carSale2.Add("vehicle", new Dictionary<string, string>() {
            {"year", "2008"},
            {"model", "Hotquadtrax"},
            {"make", "Transtintechno"},
            {"color", "robin egg blue"} 
            });

            carSale2.Add("sales_id", new Dictionary<string, string>() {
            {"sales_id", "a2f80554-bd9d-4ea1-8229-01fd4cf220a8"}
            });

            carSale2.Add("sales_agent", new Dictionary<string, string>() {
            {"mobile", "562.300.2912"},
            {"last_name", "Davis"},
            {"first_name", "Gerardo"},
            {"emails", "girl70@hotmail.com, jova43@gmail.com"}
            });

            carSale2.Add("purchase_date", new Dictionary<string, string>() {
            {"purchase_date", "2017-04-28"}
            });

            carSale2.Add("gross_profit", new Dictionary<string, string>() {
            {"gross_profit", "156.02"}
            });

            carSale2.Add("credit", new Dictionary<string, string>() {
            {"credit_provider", "PNC Financial Services"},
            {"account", "34578280562836"}
            });

            listOfAllCarSales.Add(carSale1);
            listOfAllCarSales.Add(carSale2);

            
            // Refactor option 2
            
            Dictionary<string, string> vehicle1 = new Dictionary<string, string>() {
            {"year", "2010"},
            {"model", "Damfresh"},
            {"make", "Biotraxquote"},
            {"color", "sky magenta"} 
            };

            Dictionary<string, string> salesId1 = new Dictionary<string, string>() {
            {"sales_id", "ecb1c841-1a43-4a7c-896e-712d2ec39c71"}
            };

            Dictionary<string, string> salesAgent1 = new Dictionary<string, string>() {
            {"mobile", "(896) 478-6975"},
            {"last_name", "Botsford"},
            {"first_name", "Shaina"},
            {"emails", "beatae_sonny@hotmail.com, shaina@aol.com"}
            };

            Dictionary<string, string> purchaseDate1 = new Dictionary<string, string>() {
            {"purchase_date", "2017-11-15"}
            };

            Dictionary<string, string> grossProfit1 = new Dictionary<string, string>() {
            {"gross_profit", "871.26"}
            };

            Dictionary<string, string> credit1 = new Dictionary<string, string>() {
            {"credit_provider", "J.P.Morgan Chase & Co"},
            {"account", "601109582720302"}
            };

            Dictionary<string, string> vehicle2 = new Dictionary<string, string>() {
            {"year", "2008"},
            {"model", "Hotquadtrax"},
            {"make", "Transtintechno"},
            {"color", "robin egg blue"} 
            };

            Dictionary<string, string> salesId2 = new Dictionary<string, string>() {
            {"sales_id", "a2f80554-bd9d-4ea1-8229-01fd4cf220a8"}
            };

            Dictionary<string, string> salesAgent2 = new Dictionary<string, string>() {
            {"mobile", "562.300.2912"},
            {"last_name", "Davis"},
            {"first_name", "Gerardo"},
            {"emails", "girl70@hotmail.com, jova43@gmail.com"}
            };

            Dictionary<string, string> purchaseDate2 = new Dictionary<string, string>() {
            {"purchase_date", "2017-04-28"}
            };

            Dictionary<string, string> grossProfit2 = new Dictionary<string, string>() {
            {"gross_profit", "156.02"}
            };

            Dictionary<string, string> credit2 = new Dictionary<string, string>() {
            {"credit_provider", "PNC Financial Services"},
            {"account", "34578280562836"}
            };

            carSale1.Add("vehicle", vehicle1);
            carSale1.Add("sales_id", salesId1);
            carSale1.Add("sales_agent", salesAgent1);
            carSale1.Add("purchase_date", purchaseDate1);
            carSale1.Add("gross_profit", grossProfit1);
            carSale1.Add("credit", credit1);

            listOfAllCarSales.Add(carSale1);

            carSale2.Add("vehicle", vehicle2);
            carSale2.Add("sales_id", salesId2);
            carSale2.Add("sales_agent", salesAgent2);
            carSale2.Add("purchase_date", purchaseDate2);
            carSale2.Add("gross_profit", grossProfit2);
            carSale2.Add("credit", credit2);

            listOfAllCarSales.Add(carSale2);
        }
    }
}
