using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCurrencyConverterAPI
{
    public class Rate
    {
        // Caution: It is neccesray to use exactly the same names as the API Return Value Names
        public double INR { get; set; }     // Indian Rupee
        public double JPY { get; set; }     // Japanese Yen
        public double USD { get; set; }     // US Dollar
        public double NZD { get; set; }     // New Zealand Dollar 
        public double EUR { get; set; }     // Euro
        public double CAD { get; set; }     // Canadian Dollar
        public double ISK { get; set; }     // Icelandic Króna
        public double PHP { get; set; }     // Philippine Peso
        public double DKK { get; set; }     // Danish Kroner
        public double CZK { get; set; }     // Czech Koruna
    }
}
