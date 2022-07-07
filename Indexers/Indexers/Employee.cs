using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {
        int Eno;
        double salary;
        string Ename, Job, Dname, Location;

        public Employee(int Eno, double salary, string Ename, string Job, string Dname, string Location)
        {
            this.Eno = Eno;
            this.salary = salary;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;

        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return Eno;
                else if (index == 2)
                    return salary;
                else if (index == 3)
                    return Ename;
                else if (index == 4)
                    return Job;
                else if (index == 5)
                    return Dname;
                else if (index == 6)
                    return Location;
                return null;
            }
            set
            {
                if (index == 1)
                    Eno = (int)value;
                else if (index == 2)
                    salary = (double)value;
                else if (index == 3)
                    Ename=(string)value;
                else if (index == 4)
                    Job = (string)value;
                else if (index == 5)
                    Dname = (string)value;
                else if (index == 6)
                    Location = (string)value;                
            }
        }
    }
}
