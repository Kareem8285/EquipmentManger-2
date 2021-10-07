using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbHomepageList
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentSerialno { get; set; }
        public string Eqlocation { get; set; }
        public string Eqcapacity { get; set; }
        public string CategoryName { get; set; }
    }
}
