using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EquipmentManger_2.Models;
using EquipmentManger_2.Pl;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Equipment_Mnager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomepageApiController : ControllerBase
    {
        // GET: api/<HomepageApiController>
        [HttpGet]
        public IEnumerable<TbHomepageList> Get()
        {
            EquipmentMangerContext ctx = new EquipmentMangerContext();
            List<TbHomepageList> hplst = ctx.TbHomepageLists.ToList();            
            return hplst;

            //  return new string[] { "value1", "value2" };
        }

        // GET api/<HomepageApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HomepageApiController>
        [HttpPost]
        public void Post([FromBody] Edit_Page_info value)
        {
            Equipments_functions ctx = new Equipments_functions();
            ctx.Update_location_reading(value);            
        }

        // PUT api/<HomepageApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomepageApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }

   
}
