using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MilitaryUnits
{
    [Serializable]
    [XmlRoot(ElementName ="Customer",Namespace ="")]
    public class Battalion:Company
    {
      //  [XmlElement("staff")]
        private string staff;
        public Battalion(int _numberOfUnits, string _postOfCommander, string _typeOfArmy, string _task,string _staff) : base(_numberOfUnits, _postOfCommander, _typeOfArmy,_task,100,900)
        {
            staff = _staff;
          //  setValidPosts();
            minNumberOfUnits = 100;
            maxNumberOfUnits = 900;
        }
        public Battalion()
        {

        }
        public string Staff
        {
            set
            {
                staff = value;
            }
            get
            {
                return staff;
            }
        }

        protected override string setValidPosts(string post)
        {
            validPosts = new HashSet<string>();
            validPosts.Add("Lieutenant colonel");
            if (validPosts.Contains(post)) return post;
            else return "Lieutenant colonel";
        }
        public override string getAccessTo()
        {
            return "Number of units:" + this.numberOfUnits + "\n  Post of commander:" + this.postOfCommander + "\n  Type of army:" + this.typeOfArmy + "\n  Task:" + this.task + "\n  Staff:" + this.staff;
        }
        public override void changeFields(string _typeOfArmy = "", string _task = "", string _staff = "")
        {
            TypeOfArmy = _typeOfArmy;
            task = _task;
            staff = _staff;
        }
    }
}
