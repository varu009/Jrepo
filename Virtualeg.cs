using System;
using System.Collections.Generic;
using System.Text;

namespace Prjsecondapplication
{
    class UGC
    {
        String[] rules = { "DRESS CODE", "ID card" };
        public virtual void RulesMethod()
        {
            foreach(var r in rules)
            {
                Console.WriteLine("Rule:{0}", rules);

            }
        }
    }
    class MIT : UGC
    {
        String mitrule = "No mobile ";
        public override void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("MIT Rule:{0}", mitrule);            
        }
    }
    class AnnaUniversity : UGC
    {
        String annarule = "only formal dress ";
        public new void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("Anna University Rule:{0}", annarule);
        }
    }
    class Virtualeg
    {
        static void Main()
        {
            UGC uGC = new UGC();
            Console.WriteLine("UGC RULES");
            uGC.RulesMethod();
            Console.WriteLine("MIT RULES");
            MIT mIT = new MIT();
            mIT.RulesMethod();

        }
    }
}
