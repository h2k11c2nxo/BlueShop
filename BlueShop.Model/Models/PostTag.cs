using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlueShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order =1)]
        public int PostId { get; set; }
        [Key]
        [Column(Order =2)]
        public string TagId { get; set; }
        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
