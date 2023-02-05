using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Identity.Client;
using Repository;
using ServicesLayer;
using System.Net;

namespace API_OnionStracture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserInterface _t;
       public readonly   UserContext  _usertest;


     
        public UserController(IUserInterface t,UserContext _u)
        {
           _usertest=_u;


            _t = t;
        }
        [HttpGet]
        public IActionResult post()
        {
          
          //  List<User> users = new List<User>();
            

            var Alluser = _t.GetAll();
            return Ok(Alluser);
        }
        [HttpGet("/id")]
        public IActionResult Get(long Id)
        {
            // var user = _usertest.user.Where(n=>n.Id== Id).FirstOrDefault();

            var user = _t.Getsingle(Id);

            return Ok(user);


        }




      
        [HttpPost]
        public IActionResult Post(User user)
        {
            var newy= _t.AddUser(user);

            return Ok(newy);
        
         }

        [HttpDelete("{id}")] //روش 2
        public string Del(long id)
        {


           var dd= Get(id);
           

            //======================== روش 1
            //var objToDelete = _usertest.user. Where(oi => oi.Id== id).FirstOrDefault();
            //_usertest.user.Remove(objToDelete);
            //_usertest.SaveChanges();


            //==============================

           var po= _t.DeleteUser(id);

            return po;

        }
        //[HttpDelete("{id}")] //روش3
        //public async Task<IActionResult> DeleteTodoItem(long id)
        //{

        //    var t= _usertest.user.Where(x=>x.Id==id).FirstOrDefault();   

        //    var todoItem = await _usertest.user.FindAsync(id);
        //    if (todoItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _usertest.user.Remove(todoItem);
        //    await _usertest.SaveChangesAsync();

        //    return NoContent();
        //}



        //[HttpDelete("{id}")] //روش 4
        //public IActionResult Del(long id)
        //{


        //    var dd = Get(id);


        //    //======================== روش 1
        //    //var objToDelete = _usertest.user. Where(oi => oi.Id== id).FirstOrDefault();
        //    //_usertest.user.Remove(objToDelete);
        //    //_usertest.SaveChanges();


        //    //==============================

        //    var po = _t.DeleteUser(id);

        //    return Ok(po);

        //}

        //======================================


        [HttpPut()] 
        public IActionResult up(User u)
        {


          
           var per=    _t.UpdateUser(u);

            //if (per== null)
            //{

            //    return StatusCode(500);
            //}

            //else {



            /// var po = _t.UpdateUser(id);

            return Ok(per);

                      }
       
        }
    }

