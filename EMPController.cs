using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace GUIPROJECT
{
    public class EMPController
    {
        Employee Emp;
        DBManager dbMan;
        public EMPController()
        {
            dbMan = new DBManager();
        }
        public DataTable ShowAllEvents()
        {
            string StoredProcedure = StoredProcedures.ShowAllEvents;
            return dbMan.ExecuteReader(StoredProcedure);
        }

        public DataTable ShowAllActivities()
        {
            string Query = "Select * from Activites";
            return dbMan.ExecuteReader(Query);
        }
        public int AddActivity(string Name,string place)
        {
            string storedProcedure = StoredProcedures.AddActivity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@ID", ID);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Place", place);
            return dbMan.ExecuteNonQuery(storedProcedure, Parameters);

        }
        public int InsertEmployee(int SSN, string FName, string Minit, string LName, string Sex, int Salary, int Super_SSN, int Dno,string username)
        {
            string Storedprocedure = StoredProcedures.InsertEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            Parameters.Add("@FName", FName);
            Parameters.Add("@Minit", Minit);
            Parameters.Add("@LName", LName);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Sex", Sex);
            Parameters.Add("@Super_SSN", Super_SSN);
            Parameters.Add("@DNO", Dno);
            Parameters.Add("@Username", username);
            //Employee.CurrentEmployee =Emp ;
            //Emp.DNO = Dno;
            //Emp.Lname = LName;
            //Emp.SSN = SSN;
            //Emp.Super_SSN = Super_SSN;
            //Emp.Sex = Sex;
            //Emp.Username = username;
            //Emp.Salary = Salary;
            //Emp.Fname = FName;
            //Emp.Minit = Minit;
            return dbMan.ExecuteNonQuery(Storedprocedure, Parameters);
        }

        public int RemoveEmployee(int ssn)
        {
            string storedprocedure = StoredProcedures.RemoveEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", ssn);
            return dbMan.ExecuteNonQuery(storedprocedure, Parameters);

        }
        public int AddEvent(  int Event_id,string name,string Place, string Date, int Likes,int fees, int member_id)
        {
                        /*
                         @Event_id INT  ,
              @Name VARCHAR (55) ,
              @Place VARCHAR (70),
              @Date DATE ,
              @Likes INT ,
              @Fees INT ,
              @Member_ID INT 
                         */
            string StoredProcedure = StoredProcedures.AddEvents;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Event_id", Event_id);
            Parameters.Add("@Name", name);
            Parameters.Add("@Place", Place);
            Parameters.Add("@Date", Date);
            Parameters.Add("@Likes", Likes);
            Parameters.Add("@Fees", fees);
            Parameters.Add("@Member_ID", member_id);


            return dbMan.ExecuteNonQuery(StoredProcedure, Parameters);



        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
      
    }
}
