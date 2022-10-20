using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentService
{
    public class Enrollment
    {
        public int Enrollno { get; set; }
        public double fees { get; set; }
        public bool IsEnrolled()
        {
            return fees > 0;
        }
    }
}
