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
    [XmlInclude(typeof(Platoon))]
    [XmlInclude(typeof(Battalion))]
    [XmlInclude(typeof(Company))]
    [XmlInclude(typeof(Regiment))]

    public class Detachment
    {

        protected int numberOfUnits;

        protected string postOfCommander;
 
        protected HashSet<string> validPosts;

        protected int minNumberOfUnits;

        protected int maxNumberOfUnits;

        public  Detachment(int _numberOfUnits, string _postOfCommander,int  minNumberOfUnits=3, int maxNumberOfUnits = 15) 
            {
     
        //    setValidPosts();
            MinNumberOfUnits = minNumberOfUnits;
            MaxNumberOfUnits = maxNumberOfUnits;
            NumberOfUnits = _numberOfUnits;
            PostOfCommander = _postOfCommander;
          
            }
        public Detachment()
        {

        }
        protected virtual string setValidPosts(string post)
        {
            validPosts = new HashSet<string>();
            validPosts.Add("Commander");
            validPosts.Add("Lance sergant");
            validPosts.Add("Sergant");
            if (validPosts.Contains(post)) return post;
            else return "Commander";
        }
        public string PostOfCommander
        {
            get
            {
                return postOfCommander;
            }
            set
            {
                postOfCommander= setValidPosts(value);
    
            }       

        }
        public int MinNumberOfUnits
        {
            get
            {
                return minNumberOfUnits;
            }
            set
            {
                minNumberOfUnits =value;
            }
        }
        public int MaxNumberOfUnits
        {
            get
            {
                return maxNumberOfUnits;
            }
            set
            {
                maxNumberOfUnits = value;
            }
        }


        public int NumberOfUnits
        {
            get
            {
                return numberOfUnits;
            }
            set
            {
                if ((value >= minNumberOfUnits) && (value <= maxNumberOfUnits))
                    numberOfUnits = value;
                else numberOfUnits = (minNumberOfUnits+ maxNumberOfUnits)/2;
            }

        }
        public virtual string getAccessTo()
        {
            return "Number of units:" + this.numberOfUnits + "\n  Post of commander:" + this.postOfCommander;
        }
        public virtual void changeFields(string _typeOfArmy="", string _task="", string _staff="")
        {

        }
        



    }
}
