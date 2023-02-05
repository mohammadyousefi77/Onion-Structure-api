using DataLayer;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class UserServices : IUserInterface
    {

        public  UserContext _usertest;
        public UserServices(UserContext usertest) {
            _usertest = usertest;
        }

        public string AddUser(User addNew)
        {
          var newu= _usertest.user.Add(addNew).ToString();
            save();
            return newu ;
        }

        public string DeleteUser(long id)
        {
            var del = _usertest.user.Where(n=>n.Id==id).FirstOrDefault();
            if (del == null)
            {

                return "user not found";
            }
            else
            {

                _usertest.user.Remove(del);
               save();
                return "@@ yes baby: delete opration is ok";
            }

        }

        public List<User> GetAll()
        {
            return _usertest.user.ToList(); 
        }

        public User Getsingle(long id)
        {
         
            var user = _usertest.user.Where(n=>n.Id==id).FirstOrDefault();
            return user;
        }

        public string UpdateUser(User user)
        {
             

            _usertest.user.Update(user);  
            save();
            return "yes babe";
            
        }

        public void save()
        {
            _usertest.SaveChanges();
        }
    }
}
