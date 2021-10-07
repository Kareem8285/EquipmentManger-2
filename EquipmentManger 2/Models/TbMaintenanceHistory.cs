using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbMaintenanceHistory
    {
        public int MaintenanceHostoryid { get; set; }
        public int EquipmentId { get; set; }
        public int ItemId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Notes { get; set; }
        public int Reading { get; set; }
    }
}
