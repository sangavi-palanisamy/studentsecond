using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentCore.Core.IServices;
using StudentCore.Core.Models;

namespace studentsecond.Controllers
{
    public class StudentController : Controller
    {
       private readonly ITestServices _testService;

        public StudentController(ITestServices testService)
        {
            _testService = testService;
        }




       
        public IActionResult Loginpage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Loginpage(StudentLogin login)
        {
           var logins= _testService.Login(login);
            if (logins != null)
            { 
                return RedirectToAction("create");
            }
            else

            {
                ViewBag.Message = "PLEASE ENTER THE CORRECT USERNAME AND PASSWORD";
            }
                return View();
        }
       
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateDetails(Studententry StudentValues)
        {
          int value= _testService.CreateDetails(StudentValues);
            if(value==0)
            { 
            ViewBag.Message = "Student Details Entered Sucessfully";
            }
            else
            {
                ViewBag.Message = "Student Details Edited Sucessfully";
            }
            return View("Create");
        }
        public IActionResult StudentDisplay()
        {
            var values = _testService.GetDetails();
            return View(values);
        }
        public ActionResult Delete(int id)
        {
             _testService.StudentDelete(id);
            TempData["Message"] = "Student Details Deleted Sucessfully";
            return RedirectToAction("StudentDisplay");
        }


        #region Edit
        public ActionResult  Edit(int id)
        {
           var Editvalues=_testService.EditDetails(id);

            return View("Create",Editvalues);
        }
        #endregion
    }
}
