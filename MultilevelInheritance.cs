using System;
using System.Collections.Generic;
using System.Text;

namespace Prjsecondapplication
{
    enum Feedback
    {
        Poor=1,Fair,Good=4,Excellent
    };
    class Department
    {
        //protected is used with in the class and only in derived class
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }
        internal Department(int Did,string Dname, string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }

        protected internal void DisplayDepartmentinfo()
        {
            Console.WriteLine("Did:{0} || Dname:{0}", Did, Dname);
        }
        ~Department()
        {
            Console.WriteLine("Department Destructor");
        }
    }
    //single Inheritance
    //child or derived class employee
    class Employee : Department
    {
        internal static string Companyname = "LTI";
        internal int Eid { get; set; }
        internal string Name { get; set; }
        internal string City = "Pune";

        internal Employee(int Eid, string Name, int Did, string Dname, string City) : base(Did, Dname, City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name;
        }
        internal void DisplayEmployeeinfo()
        {
            DisplayDepartmentinfo();
            Console.WriteLine("Department city is : {0}", base.City);
            Console.WriteLine("EID : {0} || Ename:{1} || Feedback: {2}", Eid,Name,(int)Feedback.Excellent);
            Console.WriteLine("Employee city is : {0}",City);
        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }

    }
    class Parttimeemployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }
        internal Parttimeemployee(int Eid, string Name, int Did, string Dname, string City,int hoursofwork,int salary):base(Eid,Name,Did,Dname,City)
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
        }
        internal int Monthlysalary()
        {
            int Payment = hoursofwork * salary;
            return Payment;
        }
        ~Parttimeemployee()
        {
            Console.WriteLine("Part time employee Destructor");
        }
    }

    class MultilevelInheritance
    {
        static void Main()
        {
            //single inheritance
            /* Employee employee = new Employee(1001,"sai",101,"hr","madurai");
             * employee.DisplayEmployeeinfo();*/
            //error since protected
            //employee.Displaydepartmentinfo();

            //multilevel inheritance
            Parttimeemployee pt = new Parttimeemployee(1001, "sai", 101, "hr", "madurai",50,200);
            pt.DisplayEmployeeinfo();
            Console.WriteLine("Monthly Salary: {0}",pt.Monthlysalary());
            GC.Collect();
        }
    }
}
