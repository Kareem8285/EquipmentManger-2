using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbEquipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int CategoryId { get; set; }
        public string EquipmentSerialno { get; set; }
        public string EquipmentModel { get; set; }
        public string EquipmentEngineType { get; set; }
        public string EquipmentEngineNo { get; set; }
        public int? EquipmentYearOfManuf { get; set; }
        public DateTime EquipmentFirstDate { get; set; }
        public int OperatorId { get; set; }
        public string Eqlocation { get; set; }
        public string Eqcapacity { get; set; }

        public virtual Tbcategory Category { get; set; }
        public virtual TbOperator Operator { get; set; }
    }
}
