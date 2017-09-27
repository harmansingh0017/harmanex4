using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Exc4student
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static  List<Student> stt = new List<Student>();

        public void Addstudent(Student st)
        {
            stt.Add(st);
        }

        public Student findstudent(string st)
        {
            return stt.Find(Student => st == Student.Name);

        }


        public void removestudent(int st)
        {
            stt.RemoveAt(st);

        }

        public List<Student> getstudent()
        {
            //Student ss = new Student();
            //foreach (var VARIABLE in stt)
            //{
            //   ss =    VARIABLE;
            //}

            return stt;
        }
    }
}
