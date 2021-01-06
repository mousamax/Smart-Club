using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIPROJECT
{
    class Employee
    {
        /*
           SSN INT ,
  Fname VARCHAR (55) NOT NULL,
  Minit VARCHAR (10) ,
  Lname VARCHAR (55) ,
  Salary INT NOT NULL,
  Sex char NOT NULL,
  Super_SSN INT ,
  Username VARCHAR (50),
  PRIMARY KEY (SSN),
  DNO int,
         */
        public int SSN { get; set; }
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        public int Salary { get; set; }
        public string Sex { get; set; }
        public int Super_SSN { get; set; }
        public string Username { get; set; }
        public int DNO { get; set; }

        public static Employee CurrentEmployee { get; set; }


    }
}
