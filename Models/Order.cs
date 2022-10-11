using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DFA_CORE.Models
{
    public partial class Order
    {
        [Key]
        public int OId { get; set; }
        [Required(ErrorMessage="Enter the orderer name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? OName { get; set; }
        [Required(ErrorMessage = "Enter the Item name")]
        public string? OItem { get; set; }
        [Range(1,6, ErrorMessage = "You can add up to 6 quantity")]
        public int? OQuantity { get; set; }
    }
}
