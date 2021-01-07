using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DBapplication;

namespace GUIPROJECT
{
    class MemberController
    {
        DBManager dbMan;
        public MemberController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        //--------------------- Mousa Functions ------------------------------------ //
        public int Accept_Membership(int membershipPrice, int memberid)
        {
            string query = "Update Members set MemberShip_Price=" + membershipPrice + " , Status='Active',Start_Date='"+ DateTime.Now.ToString("yyyy-MM-dd") + "',End_Date='"+DateTime.Now.AddDays(365).ToString("yyyy-MM-dd") + "' where ID ="+ memberid +";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectPendingMembers()
        {
            string query = "select ID,Fname,Lname,Age,Sex,Status from Members where Status='pending';";
            return dbMan.ExecuteReader(query);
        }
        public int Confirm_Event(int event_Id)
        {
            string query = "Update Events set Status='Active' where Event_id="+event_Id+";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectPendingEvents()
        {
            string query = "select Event_id, Name, Place, Date, Fees, Status, Member_ID from Events where Status = 'pending';";
            return dbMan.ExecuteReader(query);
        }
        //-------------------------------------------------------------------------- //
        //-------------------------------------------------------------------------- //
        public int Addevent(string name, string place, string date, int fees, int memberid)
        {
            string query = "Insert into Events values('" + name + "','" + place + "','" + date + "',null," + fees + "," + memberid + ")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ParkingSubscribe(string startdate, int fees, string enddate, int memberid)
        {
            string query = "Insert into Parking values('" + startdate + "'," + fees + ",'" + enddate + "'," + memberid + ")";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}