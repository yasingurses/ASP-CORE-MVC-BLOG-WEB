using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int teammate_ID { get; set; }
        public string teammate_Name { get; set; }
        public string teammate_Surname { get; set; }
        public string teammate_Department{ get; set; }
        public int teammate_Salary { get; set; }
        public string teammate_Password { get; set; }
        public string teammate_Role { get; set; }
    }
}
