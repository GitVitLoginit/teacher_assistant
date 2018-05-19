using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnits
{
    interface IMilitaryActivities
    {
        string Attack();
        string Defend();
    }
    class DoSomeActivity : IMilitaryActivities
    {
        public virtual string Attack()
        {
            return "We go to the hide attack";   
        }
        public virtual string Defend()
        {
            return "We will defend ourselves. Because we have a little ammount of units";
        }
    }

    class DoSomeSpecialActivity : IMilitaryActivities
    {
        public string Attack()
        {
            return "We go to the  attack!!! We will kill them all!!!";
        }
        public string Defend()
        {
            return "We will defend ourselves. They have no chance to break through!";
        }
    }

   
    class Adapter: DoSomeActivity //адаптируем DoSomeActivity под другой класс вызывая в нем методы другого
    {
        DoSomeSpecialActivity specAct = new DoSomeSpecialActivity();
        public override string Attack()
        {
            string slang;
            slang=specAct.Attack();
            return slang;
        }
        public override string Defend()
        {
            string slang;
            slang = specAct.Defend();
            return slang;
        }
    }


}
