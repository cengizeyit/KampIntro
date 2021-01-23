using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Taşıt Kredi Servisi
    class TransportCreditService : ICreditService
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı...");
        }
    }
}
