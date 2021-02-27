using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras--inheritance
    class CorporateCustomer:Customer //tüzel müşteri
    {
       
        public string CompanyName { get; set; }

        public string TaxNumber { get; set; }
    }
}
