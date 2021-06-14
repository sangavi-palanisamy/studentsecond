using Student.Entity;
using StudentCore.Core.IRepository;
using StudentCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository.Repositories
{
    public class TestRepository: ITestRepository
    {
        public int CreateDetails(Studententry StudentValues)
        {



            using (CurdContext student = new CurdContext())
            {
                if (StudentValues != null)
                {
                    if (StudentValues.Studid == 0)
                    {

                        StudentRecords stud = new StudentRecords();

                        stud.FirstName = StudentValues.FirstName;
                        stud.SecondName = StudentValues.SecondName;
                        stud.DateOfBirth = StudentValues.Dateofbirth;
                        stud.Age = StudentValues.Studage;
                        stud.FavoriteSubject = StudentValues.Favouritesub;
                        stud.InterestedCourse = StudentValues.Interestescourse;
                        stud.MathsMark = StudentValues.Mathsmark;
                        stud.ChemistryMark = StudentValues.Chemistrymark;
                        stud.ComputerMark = StudentValues.Computermark;

                        student.StudentRecords.Add(stud);
                        student.SaveChanges();
                        int value= StudentValues.Studid;
                        return value;

                    }
                    else
                    {
                        

                            var data = student.StudentRecords.Where(x => x.StudentId == StudentValues.Studid && x.IsDelete == false).SingleOrDefault();
                            data.FirstName = StudentValues.FirstName;
                            data.SecondName = StudentValues.SecondName;
                            data.DateOfBirth = StudentValues.Dateofbirth;
                            data.Age = StudentValues.Studage;
                            data.FavoriteSubject = StudentValues.Favouritesub;
                            data.InterestedCourse = StudentValues.Interestescourse;
                            data.MathsMark = StudentValues.Mathsmark;
                            data.ChemistryMark = StudentValues.Chemistrymark;
                            data.ComputerMark = StudentValues.Computermark;
                            data.UpdateTimeStamp = DateTime.Now;

                            student.SaveChanges();


                        int value = StudentValues.Studid;
                        return value;
                    }
                }
            }



            return 0;
               
           
        }

       
        public List<Studententry> GetDetails()
        {
            using (CurdContext student = new CurdContext())
            {


                var displayrecords = student.StudentRecords.Where(x => x.IsDelete == false).ToList();
                List<Studententry> StudentList = new List<Studententry>();


                if (displayrecords != null)
                {
                    foreach (var value in displayrecords)
                    {
                        Studententry studentclass = new Studententry();
                        studentclass.Studid = value.StudentId;
                        studentclass.FirstName = value.FirstName;
                        studentclass.SecondName = value.SecondName;
                        studentclass.Dateofbirth = value.DateOfBirth;
                        studentclass.Studage = value.Age;
                        studentclass.Favouritesub = value.FavoriteSubject;
                        studentclass.Interestescourse = value.InterestedCourse;
                        studentclass.Mathsmark = value.MathsMark;
                        studentclass.Chemistrymark = value.ChemistryMark;
                        studentclass.Computermark = value.ComputerMark;
                        StudentList.Add(studentclass);
                    }
                }

                var model = StudentList;
                return model;
            }
        }

        public StudentLogin Login(StudentLogin login)
        {
            using (CurdContext studententity = new CurdContext())
            {
                var logindetails = studententity.Login.Where(x => x.LoginName == login.Loginname && x.Password == login.Password).SingleOrDefault();
                if (logindetails != null)
                {
                    return login;
                }
                else
                {

                   
                    return null;
                }
            }
        }



        public int StudentDelete(int id)
        {
            using (CurdContext DeleteEntities = new CurdContext())
            {
                var deletevalue = DeleteEntities.StudentRecords.Where(x => x.StudentId == id && x.IsDelete == false).SingleOrDefault();
                if (deletevalue != null)
                {
                    deletevalue.IsDelete = true;
                    deletevalue.UpdateTimeStamp = DateTime.Now;
                    DeleteEntities.SaveChanges();
                    return id;
                }


                int a = 0;
                
                return a;


            }
        }



   
        public Studententry EditDetails(int id)
        {
            using (CurdContext EditEntities = new CurdContext())
            {
                Studententry model = new Studententry();

                var table = EditEntities.StudentRecords.Where(x => x.StudentId == id && x.IsDelete == false).SingleOrDefault();
                if (table != null)
                {
                    model.Studid = table.StudentId;
                    model.FirstName = table.FirstName;
                    model.SecondName = table.SecondName;
                    model.Dateofbirth = table.DateOfBirth;
                    model.Studage = table.Age;
                    model.Favouritesub = table.FavoriteSubject;
                    model.Interestescourse = table.InterestedCourse;
                    model.Mathsmark = table.MathsMark;
                    model.Chemistrymark = table.ChemistryMark;
                    model.Computermark = table.ComputerMark;
                }

                return model;
            }
        }

       

    }
}
