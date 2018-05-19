using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MilitaryUnits
{ 
    [Serializable]
    [XmlRoot(ElementName = "Customer", Namespace = "")]
    public class Regiment:Company
    {
     //   [XmlElement("staff")]
        private string staff;
        public Regiment(int _numberOfUnits, string _postOfCommander, string _typeOfArmy, string _task, string _staff) : base(_numberOfUnits, _postOfCommander, _typeOfArmy,_task,900,2000)
        {
            staff = _staff;
           
        }
        public Regiment()
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
            validPosts.Add("Colonel");
            if (validPosts.Contains(post)) return post;
            else return "Colonel";
        }
        public override string getAccessTo()
        {
            return "Number of units:" + this.numberOfUnits + "\n  Post of commander:" + this.postOfCommander+ "\n  Type of army:" + this.typeOfArmy+ "\n  Task:" + this.task + "\n  Staff:" + this.staff;
        }
        public override void changeFields(string _typeOfArmy = "", string _task = "", string _staff = "")
        {
            TypeOfArmy = _typeOfArmy;
            task = _task;
            staff = _staff;
        }
    }
}
