using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }

        [DisplayName("Стоимость")]
        public decimal TotalPrice { get; set; }

        [DisplayName("Тип платежа")]
        public Payment.PaymentType Type { get; set; }

        [DisplayName("Период платежа")]
        public Payment.PaymentPeriod? Period { get; set; }
        public virtual Client Client { get; set; }
    }
}
