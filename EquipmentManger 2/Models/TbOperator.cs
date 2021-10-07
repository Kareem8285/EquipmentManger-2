using System;
using System.Collections.Generic;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class TbOperator
    {
        public TbOperator()
        {
            TbEquipments = new HashSet<TbEquipment>();
        }

        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public DateTime OperatorFirstworkDate { get; set; }

        public virtual ICollection<TbEquipment> TbEquipments { get; set; }
    }
}
