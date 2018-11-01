using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_of_Nations
{
    class World
    {
        //Declare and create on static World object
        //that can be accessed from any other class
        //Note: static objects are not in our textbooks
        public static World theWorld = new World();

        //Declare field
        List<Nation> _nationList;

        //Contructor
        public World()
        {
            //Create empty list of nations
            _nationList = new List<Nation>();
        }

        //Note: No properties

        //Method to add a nation to the list
        public void AddNation(Nation nat)
        {
            _nationList.Add(nat);
        }

        //Method to get information on all nations
        public List<string> GetInfo()
        {
            //Create list of nation paragraphs
            List<string> infoList = new List<string>();
            //Add each nations info to the list
            foreach(Nation nat in _nationList)
            {
                infoList.Add(nat.GetInfo());
            }
            //Return list to caller
            return infoList;
        }
    }
}
