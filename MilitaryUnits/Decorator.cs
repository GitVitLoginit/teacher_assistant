using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnits
{

    public  abstract class MainCommands   
    {
        public MainCommands(int n)
        {
            this.amountOfUnits = n;
        }
        protected int amountOfUnits;
        public abstract string Settle(); //рассчитаться
        public abstract string PlaceInOrder();//

    }

    public class MainCommandsRealization: MainCommands
    {
        public MainCommandsRealization(int n):base (n)
        {

        }
        public override string Settle()
        {
            return amountOfUnits + ". Рассчет окончен ****!";
        }
        public override string PlaceInOrder()
        {
            return  "Отделение построено! ";
        }
    }



    public abstract class Decorator: MainCommands//основной декор реализуют весь инт
    {
        protected MainCommands mainCom;
        public Decorator(MainCommands mainCom, int n):base (n)
        {
            this.mainCom = mainCom;
        }
        public override string Settle()
        {
            string s;
            s=this.mainCom.Settle();
            return s;
        }
        public override string PlaceInOrder()
        {
            string s;
            s = this.mainCom.PlaceInOrder();
            return s;
        }
    }


    public  class DecoratorBig : Decorator 
    {

        public DecoratorBig(MainCommands mainCom, int n) : base(mainCom,n)
        {

        }
        public override string Settle()
        {
            string s;
            s = this.mainCom.Settle() + BigPower();
            return s;
        }

        public  string BigPower()
        {
            return "We have big power!";
        }

        public override string PlaceInOrder()   //добавили доп метод к существующим
        {
            string s;
            s = this.mainCom.PlaceInOrder()+ BigPower();
            return s;
        }
    }

    public class DecoratorWeapon : Decorator
    {

        public DecoratorWeapon(MainCommands mainCom, int n) : base(mainCom, n)
        {

        }

        public override string Settle()
        {
            string s;
            s = this.mainCom.Settle() + GoodWeapon();
            return s;
        }

        public string GoodWeapon()
        {
            return "We have good weapon!";
        }

        public override string PlaceInOrder()   //добавили доп метод к существующим
        {
            string s;
            s = this.mainCom.PlaceInOrder() + GoodWeapon();
            return s;
        }


    }

}
