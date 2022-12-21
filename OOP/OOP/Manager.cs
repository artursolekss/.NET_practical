using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Manager : Employee
    {

        public Manager(string name,string lastname):base("Manager",name,
            lastname)
        {
        }

        //public override void Sleep()//can't override sealed method
        public void Sleep()//can't override sealed method
        {
            {
            base.Sleep();
        }

    }
}
