using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exc4student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc4student.Tests
{
    [TestClass()]
    public class Service1Tests
    {
    //    [TestMethod()]
    //    public void AddstudentTest()
    //    {
    //        Student st = new Student() {Name = "shiv ", No = "1234"};
    //        IService1 test = new Service1();
    //        test.Addstudent(st);
    //    }

    //    [TestMethod()]
    //    public void findstudentTest()
    //    {
    //        Student stt = new Student();
    //       IService1 test1 = new Service1();
    //     Student s =    test1.findstudent("shiv");
    //        Assert.AreEqual( "harman" , s.Name);
           
    //    }

    //    [TestMethod()]
    //    public void removestudentTest()
    //    {
    //        Student st = new Student() { Name = "shiv ", No = "1234" };
    //        IService1 test = new Service1();
    //        test.Addstudent(st);
    //    }
        [TestMethod()]
        public void addfindTest()
        {
            Student st = new Student() { Name = "shiv ", No = "1234" };
            IService1 test = new Service1();
            test.Addstudent(st);
           var sttt = test.getstudent();
            Assert.AreEqual(1 , sttt.Count);
            //  Student stt = new Student();
            // IService1 test1 = new Service1();
            //Student s = test.findstudent("shiv");
            //Assert.IsNotNull(s);
            //Assert.AreEqual("shiv", s.Name);
        }
    }
}