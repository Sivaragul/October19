using NUnit.Framework;
using StudentEnrollmentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentServiceTest
{
    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }
    }
