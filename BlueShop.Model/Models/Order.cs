using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlueShop.Model.Models
{
    [Table("Orders")]
    public class Order :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public string PaymentMothod { get; set; }
        public string PaymentStatus { get; set; }
    }
}
