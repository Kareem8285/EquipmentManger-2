using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbSparePart
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ItemName { get; set; }
        public string ItemPartNo { get; set; }
        public decimal ItemPurchasePrice { get; set; }
        public decimal ItemSalesPrice { get; set; }

        public virtual Tbcategory Category { get; set; }
    }
}
