using System;
using System.Collections.Generic;
using System.Text;

namespace Prjsecondapplication
{
    abstract class RBI
    {
        internal string rule = "Customer should have aadhar card";
        //abstract method
        abstract public int Homeloan();
        abstract public int Eduloan();
        //non abstract
        internal void Rules()
        {
            Console.WriteLine("Rules to be followed by all bank:{0}", rule);
        }
    }
    abstract class SBI : RBI
    {
        //SBI ABSTRACT METHOD
        abstract public void SBICustomer();
        public override int Homeloan()
        {
            return 8;
        }
        public override int Eduloan()
        {
            return 10;
        }

    }
    class SBIBranch : SBI
    {
        
         public override void SBICustomer()
        {
            Console.WriteLine("It has 1 lakh customer");
        }

    }
    class Abstracteg
    {
        static void Main()
        {
            //object cant be created for the abstract class
            //RBI r = new RBI();

            /* SBI sbiobj = new SBI();
            Console.WriteLine("SbiHomeLoan:{0}",sbiobj.HomeLoan());
            Console.WriteLine("SbiEDULoan:{0}", sbiobj.EduLoan());
             sbiobj.Rules();

               SBIBranch sBIBranchobj = new SBIBranch();
               Console.WriteLine("SbiHomeLoan:{0}",sBIBranchobj.EduLoan());
               Console.WriteLine("SbiEDULoan:{0}",sBIBranchobj.HomeLoan()); 
               sBIBranchobj.SBICustomer();
               sBIBranchobj.Rules();*/

            //run time Polymorphism
            //reference of parent class

            RBI rbiobj = new SBIBranch();

            //Object of child class 

            Console.WriteLine("SbiHomeLoan:{0}", rbiobj.Eduloan());
            Console.WriteLine("SbiEDULoan:{0}", rbiobj.Homeloan());

            SBI sbiobj = new SBIBranch();
            sbiobj.SBICustomer();
            sbiobj.Rules();

            rbiobj.Rules();
        }
    }
}
