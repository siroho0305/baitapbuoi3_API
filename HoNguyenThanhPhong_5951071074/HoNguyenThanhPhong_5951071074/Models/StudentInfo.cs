using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HoNguyenThanhPhong_5951071074.Models
{
        [DataContract]
        public class StudentInfo
        {
            [DataMember(Name = "Ten")]
            public string tenSV { get; set; }
            [DataMember(Name = "Lop")]
            public string lopSV { get; set; }
            [DataMember(Name = "MSSV")]
            public string maSV { get; set; }
        }
    
}