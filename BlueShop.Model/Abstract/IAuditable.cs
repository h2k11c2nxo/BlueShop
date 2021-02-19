using System;
using System.Collections.Generic;
using System.Text;

namespace BlueShop.Model.Models
{
   public interface IAuditable
    {
         DateTime? CreatedDate { get; set; }
         string CreatedBy { get; set; }
         DateTime? UpdatedDate { get; set; }
         string UpdatedBY { get; set; }

        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
        bool Status { set; get; }
    }
}
