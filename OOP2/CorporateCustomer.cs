using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri

    // xxx : Customer diyerek miras (inheritance) almasını sağlıyoruz
    class CorporateCustomer : Customer
    {
        public string companyName { get; set; }
        public string vergiNo { get; set; }

    }
}
