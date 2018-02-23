//******************************************************
// File: StationCollection.cs
//
// Purpose: Contains the class definition for StationCollection.cs
//
// Written By: Juan Moreno
//
// Compiler: Visual Studio 2015
//
//******************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace Assigment1
{
    [DataContract]
    public class StationCollection 
    {

        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        private List<station> m_stations;

        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public StationCollection()
        {
            m_stations = new List<station>();
        }

        [DataMember(Name = "stations")]
        public List <station> stationList //Returns and sets data to the list
        {
            get
            {
                return m_stations;
            }
            set
            {
                m_stations = value;
            }
            
        }

        //Custom toString for StationCollection class
        public override string ToString()
        {
            String s = "";
            foreach (station n in m_stations)
            {
                s += "Station: " + n.ToString();
                s += "\n";
            }
            return s;
        }


        //****************************************************************************
        // Function: FindStation
        //
        // Purpose: Checking if the StationID is in the list
        //
        //****************************************************************************
        public station FindStation(int stationid)
        {
            foreach(station n in m_stations)
            {
                if (stationid == n.Id)
                {
                    return n;
                }
            }
            return null;
        }

        //****************************************************************************
        // Function: FindStation
        //
        // Purpose: Checking if the Station name is in the list
        //
        //****************************************************************************
        public station FindStation(string name)
        {
            foreach (station n in m_stations)
            {
                if (name == n.Name)
                {
                    return n;
                }
            }
            return null;
        }
    }
}
