using HoNguyenThanhPhong_5951071074.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoNguyenThanhPhong_5951071074.Controllers
{
    public class StudentsController : ApiController
    {
        // GET: api/Students
        public IEnumerable<StudentInfo> Get()
        {
            List<StudentInfo> studentInfList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var StudentInfo = new StudentInfo
                {
                    tenSV = $"Sinh Vien {i}",
                    lopSV = $"CNTT",
                    maSV = $"SV{i}"
                };
                studentInfList.Add(StudentInfo);
            }
            return studentInfList;
        }

        // GET: api/Students/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                tenSV = $"Sinh Vien {id}",
                lopSV = $"CNTT",
                maSV = $"SV{id}"
            };
        }

        // POST: api/Students
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
        }
    }
}
