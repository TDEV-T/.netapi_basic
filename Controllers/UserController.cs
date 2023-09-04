using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapiMySQL.Data.Entities;
using webapiMySQL.Data;

namespace webapiMySQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MyWorldDBContext _myWorldDBContext;

        public UserController(MyWorldDBContext myWorldDBContext)
        {
            _myWorldDBContext = myWorldDBContext;
        }

        //https://localhost:post/Users/all
        [HttpGet]
        [Route("all")]
        public IActionResult GetAllUsers(){
            var allUser = _myWorldDBContext.Users.ToList();

            return Ok(allUser);
        }


        //https://localhost:post/Users/add 

        [HttpPost]
        [Route("register")]

        public IActionResult Register(Users usr){

            var CheckUsername = _myWorldDBContext.Users.Where(_ => _.Username == usr.Username).FirstOrDefault();

            if(CheckUsername == null){
                _myWorldDBContext.Users.Add(usr);
                _myWorldDBContext.SaveChanges();
                return Ok(usr.Id);
            }else{
                return BadRequest("Error Username already to use !");
            }
            
        }


        //https://localhost:post/Users/update

        [HttpPut]
        [Route("updateUser")]

        public IActionResult UpdateUser(Users usr){
            _myWorldDBContext.Users.Update(usr);
            _myWorldDBContext.SaveChanges();
            return Ok(usr.Id);
        }

        [HttpDelete]
        [Route("userdel/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var UserDelete = _myWorldDBContext.Users.Where(_ => _.Id == id).FirstOrDefault();

            if(UserDelete == null){
                return NotFound();
            }

            _myWorldDBContext.Users.Remove(UserDelete);
            _myWorldDBContext.SaveChanges();

            return NoContent();
        }

    }
}
