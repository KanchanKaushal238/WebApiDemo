using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class StudentController : ApiController
    {
        IList<Student> Students = new List<Student>()
        {
            new Student()
                {
                    StudentId = 1, StudentName = "Kanchan", Address = "Himachal", Course = "IT"
                },
                new Student()
                {
                    StudentId = 2, StudentName = "Amit", Address = "Delhi", Course = "HR"
                },
                new Student()
                {
                    StudentId = 3, StudentName = "Rahul", Address = "MP", Course = "IT"
                },
                new Student()
                {
                    StudentId = 4, StudentName = "Kritika", Address = "Punjab", Course = "Accounts"
                }
        };
        public IList<Student> Get()
        {  
            return Students;
        }
        public Student Get(int id)
        { 
            var Student = Students.FirstOrDefault(e => e.StudentId == id);
            if (Student == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Student;
        
        }
    }
}
