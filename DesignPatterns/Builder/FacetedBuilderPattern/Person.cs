using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.FacetedBuilderPattern
{
    public class Person
    {
        //address
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        //employment
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int AnnualIncome { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
