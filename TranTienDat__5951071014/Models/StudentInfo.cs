using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranTienDat__5951071014.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "name")]
        public string MyName { get; set; }
        [DataMember(Name = "major")]
        public string MyMajor { get; set; }
        [DataMember(Name ="id")]
        public int MyID { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
    }
}