using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class Tbcategory
    {
        public Tbcategory()
        {
            TbEquipments = new HashSet<TbEquipment>();
            TbSpareParts = new HashSet<TbSparePart>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<TbEquipment> TbEquipments { get; set; }
        public virtual ICollection<TbSparePart> TbSpareParts { get; set; }
    }
}
