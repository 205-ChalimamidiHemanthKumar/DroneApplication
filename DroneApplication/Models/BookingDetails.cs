using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DroneApplication.Models
{
    public class BookingDetails
    {
        [Key]
        public int Id { get; set; }
        public int BookingId { get; set; }
        public string Location { get; set; }
        public string DroneShotType { get; set; }
        public DateTime From { get; set; }
        public DateTime UpTo { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
