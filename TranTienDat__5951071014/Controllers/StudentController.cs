using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranTienDat__5951071014.Models;

namespace TranTienDat__5951071014.Controllers
{
    public class StudentController : ApiController
    {
        StudentInfo[] students = new StudentInfo[] { };

        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {

            var studentInList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var StudentInfo = new StudentInfo
                {
                    MyID = i + 1 ,
                    MyName = "Tran Tien Dat",
                    MyMajor = "App develop",
                    Age = 20
                    
                };
                studentInList.Add(StudentInfo);
            }
            return studentInList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {

            return new StudentInfo
            {
                MyName = "Unknow",
                MyMajor = "'Unknow",
                MyID = id +1 ,
                Age = 0
            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
