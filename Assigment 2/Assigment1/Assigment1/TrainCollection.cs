﻿//******************************************************
// File: TrainCollection.cs
//
// Purpose: Contains the class definition for TrainCollection.cs
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
    public class TrainCollection
    {
        //****************************************************
        // Function: Private 
        //
        // Purpose: To hide implementation for the class
        //
        //****************************************************
        private List<Train> m_trains;

        //****************************************************************************
        // Function: Constructor
        //
        // Purpose: Set default Values
        //
        //****************************************************************************
        public TrainCollection()
        {
            m_trains = new List<Train>();
        }

        [DataMember(Name = "trains")]
      
        public List <Train> trains //Returns and sets data to the list
        {
            get
            {
                return m_trains;
            }
            set
            {
                m_trains = value;
            }
        }

        //Custom toString for TrainCollection class
        public override string ToString()
        {
            String s = "";
         
            foreach (Train n in m_trains)
            {
                s += "Trains: " + n.ToString();
             
            }
            s += "\n";
            return s;
        }

        //****************************************************************************
        // Function: FindTrain
        //
        // Purpose: Checking if the Train Id is in the list
        //
        //****************************************************************************
        public Train FindTrain(int trainId)
        {
            foreach (Train n in m_trains)
            {
                if (trainId == n.trainId)
                {
                    return n;
                }
            }
            return null;
        }
    }




    }

