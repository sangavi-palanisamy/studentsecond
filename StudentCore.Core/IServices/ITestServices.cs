using StudentCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCore.Core.IServices
{
    public interface ITestServices
    {
        public StudentLogin Login(StudentLogin login);
        public int CreateDetails(Studententry StudentValues);
        public List<Studententry> GetDetails();
        public int StudentDelete(int id);
        public Studententry EditDetails(int id);
    }
}
