using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapiMySQL.Data.Entities;
using System.Linq;
using webapiMySQL.Data;

namespace webapiMySQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetController : ControllerBase
    {
        private readonly MyWorldDBContext _myWorldDBContext;

        public GadgetController (MyWorldDBContext myWorldDBContext){
            _myWorldDBContext = myWorldDBContext;
        }

        //การสร้าง method get
        //https://localhost:port/Gadget/all
        [HttpGet]
        [Route("all")]
        public IActionResult GetAllGadget(){
            var allGadget = _myWorldDBContext.Gadgets.ToList();

            return Ok(allGadget);
        } 

        //สร้าง method  Add gadget
        //https://localhost:port/Gadget/add

        [HttpPost]
        [Route("add")]

        public IActionResult CreateGadget(Gadget gadget){
            _myWorldDBContext.Gadgets.Add(gadget);
            _myWorldDBContext.SaveChanges();
            return Ok(gadget.Id);
        }


        //สร้าง method update gadget
        //https://localhost:port/Gadget/update

        [HttpPut]
        [Route("updateGad")]

        public IActionResult UpdateGadget(Gadget gadget){
            _myWorldDBContext.Gadgets.Update(gadget);
            _myWorldDBContext.SaveChanges();
            return Ok(gadget.Id);
        }


        //สร้าง method delete gadget
        //https://localhost:port/Gadget/delete/{id}

        [HttpDelete]
        [Route("delete/{id}")]

        public IActionResult DeleteGadget(int id){
            var gadgetToDelete = _myWorldDBContext.Gadgets.Where(_ => _.Id == id).FirstOrDefault();
            if(gadgetToDelete == null){
                return NotFound();
            }
            _myWorldDBContext.Gadgets.Remove(gadgetToDelete);
            _myWorldDBContext.SaveChanges();
            return NoContent();
        }

        
    }
}