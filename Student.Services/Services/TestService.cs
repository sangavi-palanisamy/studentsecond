using StudentCore.Core.IRepository;
using StudentCore.Core.IServices;
using StudentCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Services.Services
{
    public class TestService : ITestServices
    {
        ITestRepository _testRepository;
        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }


       
        public int CreateDetails(Studententry StudentValues)
        {
            var value = _testRepository.CreateDetails(StudentValues);
            return value;

        }

        public int StudentDelete(int id)
        {
            var DeleteValue = _testRepository.StudentDelete(id);
            return DeleteValue;
        }

        public List<Studententry> GetDetails()
        {
            var getvalue = _testRepository.GetDetails();
            return getvalue;
        }

        public StudentLogin Login(StudentLogin login)
        {
           var value= _testRepository.Login(login);
            return value;
        }

        public Studententry EditDetails(int id)
        {
         var values=_testRepository.EditDetails(id);
            return values;
        }
    }
}
