using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class EMPController
    {
        DBManager dbMan;
        public EMPController()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int Insert(int SSN, string FName, string Minit, string LName,string Sex, int Salary, int Super_SSN, int Dno)
        {
            string query = "INSERT INTO Employee (SSN, FName,Minit,LName,Sex,Salary,Super_SSN,Dno) " +
                            "Values (" + SSN + ",'" + FName + "','" + Minit + "','" + LName + "','" + Sex + "'," + Salary + "," + Super_SSN + "," + Dno + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }
        public int Delete(int SSN)
        {
            string query = "Delete from Employee where SSN = "+ SSN +";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_Salary(int SSN, int salary)
        {
            string query = "Update Employee set Salary="+ salary +" where SSN = " + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectDepNum()
        {
            string query= "SELECT Dnumber, Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }

        //TODO:
        //Get SSN and address for all employees with salary less than 40000.
        //FunctionName "returnType" SelectAllEmployeesWithSalaryLessThan(?)
        //Make Sure to show only SSN and Address Not all columns
        public DataTable SelectAllEmployeesWithSalaryLessThan(int salary)
        {
            string query = $"SELECT SSN,Address FROM Employee where Salary < {salary};";
            return dbMan.ExecuteReader(query);
        }


        //TODO:
        //Get all female employees who work in "Administration" department
        //FunctionName "returnType" GetAllGenderWorkingInDepartment(?,?)
        //Make sure to get their Names and maybe SSN only
        public DataTable GetAllGenderWorkingInDepartment(string sex,int Dno)
        {
            string query = $"SELECT [Fname],[Minit],[Lname],[SSN] FROM Employee where Dno = {Dno} AND Sex='{sex}';";
            return dbMan.ExecuteReader(query);
        }

        //TODO:
        //Get departments names for all departments located at "Houston" (1 mark)
        //FunctionName: "returnType" GetDepartmentNamesAtLocation(?)
        //Just Get the Names
        public DataTable GetDepartmentNamesAtLocation(string location)
        {
            string query = $"SELECT Dname FROM Department D,Dept_Locations L where L.Dnumber=D.Dnumber and L.Dlocation='{location}';";
            return dbMan.ExecuteReader(query);
        }


        //TODO:
        //Insert a new department. (1 mark)
        //Make sure all the required fields are given and if any important Field missing, give the user appropriate message
        public int InsertDepartment(string Dname, int Dnumber, int Mgr_SSN, string Mgr_Start_Date)
        {
            string query = "INSERT INTO Department (Dname, Dnumber, Mgr_SSN, Mgr_Start_Date)" +
                            "Values ('" + Dname + "'," + Dnumber + ",'" + Mgr_SSN + "','" + Mgr_Start_Date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        //(To be delivered next lab)
        //
        //TODO:
        //5-Get employees names and salaries for all employees 
        //who work in a project located at "Stafford" or in "Houston" 
        //and work less than 35 hours. (1 marks)
        public DataTable AllEmployeeswhoworkinaprojectlocatedatStaffordorinHoustonandworklessthan35hours()
        {
            string query = "SELECT distinct [Fname],[Minit],[Lname],Salary FROM Employee E,Works_On W, Project P where E.SSN = W.Essn AND P.Pnumber = W.Pno AND P.Plocation = 'Houston' OR P.Plocation = 'Stafford' AND W.Hours < 35; ";
            return dbMan.ExecuteReader(query);
        }

        //6- Allow user to update salary of an employee of a certain SSN. (1 mark)
        public int UpdateEMPSalary(int ssn, int salary)
        {
            string query = $"update Employee set Salary={salary} where SSN = {ssn};";
            return dbMan.ExecuteNonQuery(query);
        }
        //7-Get the last names of department managers and their salaries. (1 mark)
        public DataTable Get_thelastnames_of_department_managers_and_salaries()
        {
            string query = "select distinct Lname,Salary from Employee E, Department D where E.SSN=D.Mgr_SSN;";
            return dbMan.ExecuteReader(query);
        }
        //8-Get Name and SSN for all employees working in "Research" department or working on projects controlled by "Research" department. (2 marks)
        public DataTable Get_Name_and_SSN_forallemployees_working_in_Research_department_or_working_on_projects()
        {
            string query = "select distinct [Fname],[Minit],[Lname],SSN"
                           +" from Employee E,Department D, Project P,Works_On W"
                           +" where E.Dno = D.Dnumber AND D.Dname = 'Research' AND P.Dnum = D.Dnumber AND W.Essn = E.SSN AND W.Pno = P.Pnumber;";
            return dbMan.ExecuteReader(query);
        }
        //9-Get maximum, minimum and average salary for employees(1 mark)
        public object Get_Max_Salary()
        {
            string query = "select MAX(Salary) from Employee;";
            return dbMan.ExecuteScalar(query);
        }
        public object Get_Min_Salary()
        {
            string query = "select MIN(Salary) from Employee;";
            return dbMan.ExecuteScalar(query);
        }
        public object Get_AVG_Salary()
        {
            string query = "select AVG(Salary) from Employee;";
            return dbMan.ExecuteScalar(query);
        }

    }
}
