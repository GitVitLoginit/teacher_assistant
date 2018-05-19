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
    public class Platoon: Detachment
    {
       // [XmlElement("type")]
        public string typeOfArmy;
        public Platoon(int _numberOfUnits, string _postOfCommander,string _typeOfArmy, int minNumberOfUnits=9, int maxNumberOfUnits=45 ) :base ( _numberOfUnits,  _postOfCommander, minNumberOfUnits, maxNumberOfUnits)
        {
            TypeOfArmy = _typeOfArmy;

        }
        public Platoon()
        {

        }
        public string  TypeOfArmy
            {
            set
            {
                typeOfArmy = value;
            }
            get 
            {
                return typeOfArmy;
            }
            }

        protected override string setValidPosts(string post)
        {
            validPosts = new HashSet<string>();
            validPosts.Add("Ensign");
            validPosts.Add("Lieutenant");
            validPosts.Add("Senior lieutenant");
            if (validPosts.Contains(post)) return post;
            else return "Ensign";
        }
        public override string getAccessTo()
        {
            return "Number of units:" + this.numberOfUnits + "\n  Post of commander:" + this.postOfCommander + "\n  Type of army:" + this.typeOfArmy;
        }
        public override void changeFields(string _typeOfArmy = "", string _task = "", string _staff = "")
        {
             TypeOfArmy = _typeOfArmy;
        }
    }
}
