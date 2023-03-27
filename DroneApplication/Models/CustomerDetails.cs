using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DroneApplication.Models
{
    public class CustomerDetails
    {
        [Key]
        public int Id { get; set; }
        public int Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
    }
}
