using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlueShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        public string IPAddress { get; set; }

    }
}
