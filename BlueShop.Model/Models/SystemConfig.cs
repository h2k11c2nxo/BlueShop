using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlueShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
    }
}
