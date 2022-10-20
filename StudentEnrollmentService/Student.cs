using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentService
{
    public enum Coursename
    {
        Atml,Dotnet,Java
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public Coursename coursename { get; set; }
    }
}
