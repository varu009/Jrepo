using System;
using System.Collections.Generic;
using System.Text;

namespace Prjsecondapplication
{
    interface Inormalcal
    {
        //public and abstract
        int Add(int x, int y);
        int Sub(int x, int y);
    }
    class Calculator : Inormalcal,Iscical
    {
        int Inormalcal.Add(int x, int y)
        {
            return x + y;
        }
        int Inormalcal.Sub(int x, int y)
        {
            return x - y;
        }
        int Iscical.Add(int x, int y)
        {
            return x + y;
        }
        int Iscical.Mul(int x, int y)
        {
            return x * y;
        }
    }
    class InterfaceEg
    {
        static void Main()
        {
            Inormalcal ncal = new Calculator();
            Console.WriteLine("Addition of normal calculator:{0}", ncal.Add(4, 6));
            Console.WriteLine("Addition of normal calculator:{0}", ncal.Add(4, 6));
            Iscical scical = new Calculator();
            Console.WriteLine("Addition of Scientific calculator:{0}", ncal.Add(4, 6));
            Console.WriteLine("Addition of Scientific calculator:{0}", ncal.Add(4, 6));
        }
    }
}
