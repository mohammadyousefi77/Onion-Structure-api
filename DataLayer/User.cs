using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class User
    {
        [Key]
        public long  Id { get; set; }   
        public string Name { get; set; }
        public string Email { get; set; }


    }
}