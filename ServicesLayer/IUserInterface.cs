using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public interface IUserInterface
    {
        public List<User> GetAll();
        public User Getsingle(long id);

        public string AddUser(User userNew);

        public string UpdateUser(User id);

        public string DeleteUser(long id);


    }
}
