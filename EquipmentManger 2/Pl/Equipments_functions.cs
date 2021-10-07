using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EquipmentManger_2.Models;
namespace EquipmentManger_2.Pl
{
    public class Equipments_functions
    {

        public void Update_location_reading(Edit_Page_info update_info)
        {
            using (var db = new EquipmentMangerContext())
            {
                var new_reading = db.TbMaintenceItemsSets.Where(u => u.EquipmentId == update_info.equipmentId).ToList();
                var new_location = db.TbEquipments.Where(a => a.EquipmentId == update_info.equipmentId).FirstOrDefault();
                new_location.Eqlocation = update_info.nlocation;
                new_reading.ForEach(a => a.CurrentMinH = update_info.record_reading);
                db.SaveChanges();
            }
        }
        public void Update_Mintenance_Activity(SetMintenance Update_info)
        {
            using (var db=new EquipmentMangerContext())
            {
                var newinfo = db.TbMaintenceItemsSets.Where(u => u.EquipmentItemsId == Update_info.equipmentItemsId).FirstOrDefault();
                newinfo.LastMinH = Update_info.record_reading;
                newinfo.CurrentMinH= Update_info.record_reading;
                db.SaveChanges();
            }
        }
    }
}
