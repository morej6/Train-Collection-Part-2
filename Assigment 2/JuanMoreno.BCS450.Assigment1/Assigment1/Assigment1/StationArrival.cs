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
  public class StationArrival
    {

        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        private int m_stationID;
        private DateTime m_Time;
        private bool m_TransferRequire;

        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public StationArrival()
        {
            m_stationID = 0;
            m_Time = new DateTime(2017, 01, 01);
            m_TransferRequire = false;
           
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "Station_ID")]
        public int StationID // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_stationID;
            }
            set
            {
                if (value >= 0)
                {
                    m_stationID = value;
                }
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "Time")]
        public DateTime Time // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_Time;
            }
            set
            {
                m_Time = value;
            }
        }

        //DataMember is used to spefy what variable to serialize/deserialize
        [DataMember(Name = "Transfer_Required")]
        public bool TransferRequired // C# property to set a value to a member variable and to retrive it
        {
            get
            {
                return m_TransferRequire;
            }
            set
            {
                m_TransferRequire = value;
            }
        }

        //Custom toString for stationArrival class
        public String toString()
        {
            String s = "";
            s +="Station ID: " +m_stationID;
            s += ", ";
            s +="Time: "+ m_Time;
            s += ", ";
            s +="Transfer Require: "+ m_TransferRequire;
            s += "\n";
            return s;
        }


    }
}
