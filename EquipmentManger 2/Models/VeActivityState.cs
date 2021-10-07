using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class VeActivityState
    {
        public int EquipmentId { get; set; }
        public int ItemId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentSerialno { get; set; }
        public string ItemName { get; set; }
        public string ItemPartNo { get; set; }
        public int MintenanceState { get; set; }      
       public int EquipmentItemsId { get; set; }

    }
}
