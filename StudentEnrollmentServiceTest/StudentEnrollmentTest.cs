using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StudentEnrollmentService;

namespace StudentEnrollmentServiceTest
{
    [TestFixture]
    public class StudentEnrollmentTest
    {
        [TestCase(100, ExpectedResult = true)]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(70, ExpectedResult = true)]
        public bool Enrollstudent(double Fees)
        {
            Student s1 = new Student();
            s1.RollNo = 1;
            s1.Name = "Siva";
            s1.coursename = Coursename.Atml;
            Enrollment e1 = new Enrollment();
            e1.Enrollno = 1;
            e1.fees = Fees;
            bool ans = e1.IsEnrolled();
            return ans;

        }
    }
}
