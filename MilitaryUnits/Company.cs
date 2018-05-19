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
    public class Company:Platoon
    {
     //   [XmlElement("task")]
        protected string task;
        public Company(int _numberOfUnits, string _postOfCommander, string _typeOfArmy,string _task, int minNumberOfUnits=18, int maxNumberOfUnits=200) : base(_numberOfUnits, _postOfCommander, _typeOfArmy, minNumberOfUnits, maxNumberOfUnits) 
            {
            task = _task;

        }
        public Company()
        {

        }
        public string Task
        {
            set
            {
                task = value;
            }
            get
            {
                return task;
            }
        }
        protected override string setValidPosts(string post)
        {
            validPosts = new HashSet<string>();
            validPosts.Add("Captain");
            if (validPosts.Contains(post)) return post;
            else return "Captain";
        }
        public override string getAccessTo()
        {
            return "Number of units:" + this.numberOfUnits + "\n  Post of commander:" + this.postOfCommander + "\n  Type of army:" + this.typeOfArmy + "\n  Task:" + this.task;
        }

        public override void changeFields(string _typeOfArmy = "", string _task = "", string _staff = "")
        {
            TypeOfArmy = _typeOfArmy;
            task = _task;
        }
    }
}
