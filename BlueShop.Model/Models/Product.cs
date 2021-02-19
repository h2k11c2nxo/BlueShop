using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace BlueShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }

        public int CategoryId { get; set; }
        public string Image { get; set; }
        public XElement MoreImages { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }

        public decimal? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }

    }
}
