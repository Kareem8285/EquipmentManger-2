using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EquipmentManger_2.Models;
using EquipmentManger_2.Pl;

namespace EquipmentManger_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionStateApiController : ControllerBase
    {
        // GET: api/<ActionStateApiController>
        [HttpGet]
        public IEnumerable<VeActivityState> Get()
        {
            EquipmentMangerContext ctx = new EquipmentMangerContext();
            List<VeActivityState> aslst = ctx.VeActivityStates.ToList();              
            return aslst;          
        }

        // POST api/<ActionStateApiController>
        [HttpPost]
        public void Post([FromBody] SetMintenance value)
        {
            Equipments_functions ctx = new Equipments_functions();
            ctx.Update_Mintenance_Activity(value);
        }
    }
}
