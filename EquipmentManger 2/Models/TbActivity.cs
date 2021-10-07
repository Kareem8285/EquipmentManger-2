using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbActivity
    {
        public int Activityid { get; set; }
        public int EquipmentId { get; set; }
        public string ActivityDesc { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
