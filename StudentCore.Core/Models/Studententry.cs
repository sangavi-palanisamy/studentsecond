using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCore.Core.Models
{
    public class Studententry
    {
        public int Studid { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int Studage { get; set; }
        public string Favouritesub { get; set; }
        public string Interestescourse { get; set; }
        public int Mathsmark { get; set; }
        public int Chemistrymark { get; set; }
        public int Computermark { get; set; }

    }
}
