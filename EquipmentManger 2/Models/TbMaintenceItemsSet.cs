using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbMaintenceItemsSet
    {
        public int EquipmentItemsId { get; set; }
        public int EquipmentId { get; set; }
        public int ItemId { get; set; }
        public int MaintenceInterval { get; set; }
        public int? LastMinH { get; set; }
        public int? CurrentMinH { get; set; }
    }
}
