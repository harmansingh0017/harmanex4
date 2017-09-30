using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private const string connectionstring = "Server = tcp:harmanfirstdb.database.windows.net,1433;Initial Catalog = firstdb; Persist Security Info=False;User ID =   harmans  ; Password= Realmadridcr7 ; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
    public static  List<Student> stt = new List<Student>();

 

        public Student findstudent(string st)
        {
            return stt.Find(Student => st == Student.Name);

        }


        public void removestudent(Student st)
        {
 
                stt.Remove(st);
                 

        }

        public IList<Student> getstudent()
        {
            const string selectAllStudents = "select * from Student order by Name";

            using (SqlConnection databaseConnection = new SqlConnection(connectionstring))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectAllStudents, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        List<Student> studentList = new List<Student>();
                        while (reader.Read())
                        {
                            Student student = ReadStudent(reader);
                            studentList.Add(student);
                        }
                        return studentList;
                    }
                }
            }

            // return stt;
        }

        private static Student ReadStudent(IDataRecord reader)
        {
            int ph = reader.FieldCount;
            string name = reader.GetString(1);
         //   int semester = reader.GetInt32(2);
          //  DateTime timeStamp = reader.GetDateTime(3);
           // int num = reader.GetInt32(0)  ;   
            Student student = new Student
            {
              
                Name = name,
                 ph = ph
            };
            return student;
        }

        public int Addstudent(string name, int semester)
        {
            const string insertStudent = "insert into Student (Name, ph) values (@Name, @ph)";
            using (SqlConnection databaseConnection = new SqlConnection(connectionstring))
            {
                databaseConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStudent, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@ph", semester);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}
