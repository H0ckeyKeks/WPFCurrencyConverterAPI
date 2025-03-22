using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCurrencyConverterAPI
{
    // Root class is a Main class. API Return rates in a class rates returns all currency names with value
    public class Root
    {
        // Getting all Record in rates and set in rate class as currency name wise
        public Rate rates { get; set; }  // Needs to have the same name as the Return Value of the API
       
        public long timestamp;

        public string license;

    }
}
