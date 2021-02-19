using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueShop.Model.Models
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public string UpdatedBY { set; get; }
        [MaxLength(256)]
        public string MetaKeyWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
