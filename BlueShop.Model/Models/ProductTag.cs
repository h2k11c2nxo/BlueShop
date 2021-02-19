using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlueShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order =1)]
        public int ProductId { get; set; }
        [Key]
        [Column(Order =2)]  
        public string TagId { get; set; }

        [ForeignKey("ProductId")]
        public virtual  Product Product { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
