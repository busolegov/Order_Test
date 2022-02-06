using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.Models
{
    public class Payment
    {
        public enum PaymentType
        {
            Cash,
            Installment
        }
        public enum PaymentPeriod
        {
            OneYear = 12,
            TwoYears = 24,
            ThreeYears = 36
        }
    }
}
