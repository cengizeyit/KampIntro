using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //İhtiyaç kredisi Servisi
    class ConsumerLoanService : ICreditService
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı...");
        }
    }
}
