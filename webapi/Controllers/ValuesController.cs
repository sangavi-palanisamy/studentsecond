using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentCore.Core.Models;
using StudentCore.Core.IServices;

namespace webapi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITestServices _testService;

        public ValuesController(ITestServices testService)
        {
            _testService = testService;
        }
       
        [HttpGet]
        public ActionResult Displaydetails()
        {
            var empl = _testService.GetDetails();
            return Ok(empl);
        }
        [HttpPost]
        public ActionResult Adddetails(Studententry StudentValues)
        {
            var empl = _testService.CreateDetails(StudentValues);
            return Ok("inserted sucessfully");
        }

        [HttpGet]
        public ActionResult Editstudent(int id)
        {
            var empl = _testService.EditDetails(id);
            return Ok(empl);
        }
        [HttpPut]
        public ActionResult Edit(Studententry studentvalues)
        {
            var empl = _testService.CreateDetails(studentvalues);
            return Ok(empl);
        }


    }
}
