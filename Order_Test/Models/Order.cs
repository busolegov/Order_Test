using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [DisplayName("Total price")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid value")]
        public decimal TotalPrice { get; set; }

        [DisplayName("Payment type")]
        [Required]
        public string Type
        {
            get { return _type.ToString(); }
            set { _type = (Payment.PaymentType)Enum.Parse(typeof(Payment.PaymentType), value); }
        }
        private Payment.PaymentType _type;

        [DisplayName("Payment period")]
        public int? Period
        {
            get { return (int?)_period; }
            set
            {
                if (value == null)
                {
                    _period = null;
                }
                else
                {
                    _period = (Payment.PaymentPeriod)value;
                }
            }
        }
        private Payment.PaymentPeriod? _period;

        public virtual Client Client { get; set; }





    }
}
