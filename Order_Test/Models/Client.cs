using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("First name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required]
        public string LastName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
