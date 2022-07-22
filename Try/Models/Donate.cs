using System;
using System.ComponentModel.DataAnnotations;

namespace TRY.Models
{
    public class Donate
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime TrnDate { get; set; }
        public string TrnId { get; set; } = string.Empty;
        public string Donation_Reason { get; set; } = string.Empty;
        public string Donation_Medium { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}


