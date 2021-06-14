using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCore.Core.Models
{
   public  class StudentLogin
    {
        public int Id { get; set; }
        public string Loginname { get; set; }
        public string Password { get; set; }
    }
}
