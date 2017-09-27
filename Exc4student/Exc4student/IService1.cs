using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Exc4student
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        void Addstudent(Student st);

        [OperationContract]
        Student findstudent(string st);

        [OperationContract]
        void removestudent(int st);

        [OperationContract]
        List<Student> getstudent();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
        //[DataMember]
        //public int index { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string No { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, No);
        }
    }
}
