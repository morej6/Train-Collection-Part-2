//******************************************************
// File: BranchSchedule.cs
//
// Purpose: Contains the class definition for BranchSchedule.cs
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
    public class BranchSchedule
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        private int m_branchId;
        private List<int> m_trainIds;

        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public BranchSchedule()
        {
            m_branchId = 0;
            m_trainIds = new List<int>();
        }

        public int branchId { get; set; } // sets and gets data from branchid
        public List <int> trainId
        {
            get
            {
                return m_trainIds;
            }
            set
            {
                m_trainIds = value;
            }
        }

        //Custom BranchSchedule for Station class
        public override string ToString()
        {
            String s = "";
            s += " m_branchId: " + m_branchId;
            s += ", ";
            foreach (int n in m_trainIds)
            {

                s += "m_trainIds: " + m_trainIds;
            }
            s += "\n";
            return s;
        }

    }
}
