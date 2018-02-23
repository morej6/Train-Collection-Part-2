using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment1;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace JuanMoreno.BCS450.Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {



        
            //Variables that hold the data
            StationCollection ReadStationCollection = new StationCollection();
            BranchCollection ReadBranchCollecton = new BranchCollection();
            TrainCollection ReadTrainCollection = new TrainCollection();

            //File that have been created
            //*******************************************
            // TC = TranCollection, SC =StationCollection, BC = BranchCollection
            //
            //**********************************************
     

            int count =0;
           //Loop that keeps shpowing menu unless 13 is passed.
            while (count != 13)
            {
                Console.WriteLine("Train Schedule Menu");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 – Read StationCollection from JSON file");
                Console.WriteLine("2 – Read StationCollection from XML file");
                Console.WriteLine("3 – Write StationCollection to JSON file");
                Console.WriteLine("4 – Write StationCollection to XML filen");
                Console.WriteLine("5 – Display StationCollection data on screen");
                Console.WriteLine("6 – Show station data by name");
                Console.WriteLine("7 – Read BranchCollection from JSON file");
                Console.WriteLine("8 – Write BranchCollection to JSON file");
                Console.WriteLine("9 – Display BranchCollection data on screen");
                Console.WriteLine("10 – Read TrainCollection from JSON file");
                Console.WriteLine("11 – Write TrainCollection to JSON file");
                Console.WriteLine("12 – Display TrainCollection data on screen");
                Console.WriteLine("13 – Exit");
                Console.WriteLine("Enter Choice:");
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                }catch (Exception e)
                {
                }

                if (count == 1)
                {
                    Console.Write("Enter filename (.json): ");
                    String  tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();
                        //Deserialize data and adding it to a variable

                        FileStream reader = new FileStream(tempFileName, FileMode.Open, FileAccess.Read);

                        DataContractJsonSerializer inputSerializer;
                        inputSerializer = new DataContractJsonSerializer(typeof(StationCollection));

                        ReadStationCollection = (StationCollection)inputSerializer.ReadObject(reader);
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                    }
                   

           
                   

                }
                else if(count == 2)
                {
                    Console.Write("Enter filename (.xml): ");
                    String tempFileName;

                    try
                    {
                        tempFileName = Console.ReadLine();

                        //Deserialize data and adding it to a variable

                        FileStream reader = new FileStream(tempFileName, FileMode.Open, FileAccess.Read);

                        DataContractSerializer inputSerializer;
                        inputSerializer = new DataContractSerializer(typeof(StationCollection));

                        ReadStationCollection = (StationCollection)inputSerializer.ReadObject(reader);
                        reader.Close();

                    }
                    catch (Exception e) { }
          
                   
                }
                else if(count == 3)
                {

                    Console.Write("Enter filename (.json): ");
                    String tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();

                        //Serialize Data in json form and printing it to a file
                        FileStream writer = new FileStream(tempFileName, FileMode.Create,
                           FileAccess.Write);

                        DataContractJsonSerializer ser;
                        ser = new DataContractJsonSerializer(typeof(StationCollection));

                        ser.WriteObject(writer, ReadStationCollection);
                        writer.Close();
                    }
                    catch (Exception e) { }
            

       
                }
                else if(count == 4)
                {
                    Console.Write("Enter filename (.xml): ");
                    String tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();


                        //Serialize Data in xml form and printing it to a file
                        FileStream writer = new FileStream(tempFileName, FileMode.Create,
                           FileAccess.Write);

                        DataContractSerializer ser;
                        ser = new DataContractSerializer(typeof(StationCollection));

                        ser.WriteObject(writer, ReadStationCollection);
                        writer.Close();
                    }
                    catch (Exception e) { }
                

                }
                else if(count == 5)
                {
                    //Prnting data to the screen using tostring
                    Console.WriteLine(ReadStationCollection.ToString());
                }
                else if(count == 6)
                {
                    //Prnting data to the screen using tostring
                    Console.WriteLine(ReadStationCollection.ToString());
                  
                }
                else if(count == 7)
                {
                    Console.Write("Enter filename (.json): ");
                    String tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();

                        //Deserialize data and adding it to a variable

                        FileStream reader = new FileStream(tempFileName, FileMode.Open, FileAccess.Read);

                        DataContractJsonSerializer inputSerializer;
                        inputSerializer = new DataContractJsonSerializer(typeof(BranchCollection));

                        ReadBranchCollecton = (BranchCollection)inputSerializer.ReadObject(reader);
                        reader.Close();
                    }
                    catch (Exception e) { }
       
          
                }
                else if(count == 8)
                {

                    Console.Write("Enter filename (.json): ");
                    String tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();


                        //Serialize Data in json form and printing it to a file
                        FileStream writer = new FileStream(tempFileName, FileMode.Create,
                           FileAccess.Write);

                        DataContractJsonSerializer ser;
                        ser = new DataContractJsonSerializer(typeof(BranchCollection));

                        ser.WriteObject(writer, ReadBranchCollecton);
                        writer.Close();
                    }
                    catch (Exception e) { }
         

                }
                else if(count == 9)
                {
                    //Prnting data to the screen using tostring
                    Console.WriteLine(ReadBranchCollecton.ToString());
                }
                else if (count == 10)
                {
                    Console.Write("Enter filename (.json): ");
                    String tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();

                        //Deserialize data and adding it to a variable

                        FileStream reader = new FileStream(tempFileName, FileMode.Open, FileAccess.Read);

                        DataContractJsonSerializer inputSerializer;
                        inputSerializer = new DataContractJsonSerializer(typeof(TrainCollection));

                        ReadTrainCollection = (TrainCollection)inputSerializer.ReadObject(reader);
                        reader.Close();

                    }
                    catch (Exception e) { }
          
                }
                else if (count == 11)
                {
                    Console.Write("Enter filename (.json): ");
                    String tempFileName;
                    try
                    {
                        tempFileName = Console.ReadLine();


                        //Serialize Data in json form and printing it to a file
                        FileStream writer = new FileStream(tempFileName, FileMode.Create,
                           FileAccess.Write);

                        DataContractJsonSerializer ser;
                        ser = new DataContractJsonSerializer(typeof(TrainCollection));

                        ser.WriteObject(writer, ReadTrainCollection);
                        writer.Close();
                    }
                    catch (Exception e) { }
          
                }
                else if (count == 12)
                {
                    //Prnting data to the screen using tostring
                    Console.WriteLine(ReadTrainCollection.ToString());

                }
                else if (count == 13)
                {
                    break;
                }
                
            }



            /*
                 station stationVariable = new station();
            String filename = "Station.json";
           

            FileStream writer = new FileStream(filename, FileMode.Create,
               FileAccess.Write);

            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(station));

            ser.WriteObject(writer, stationVariable);
            writer.Close();

            station stationVariable2;
            //the file that is being pass here has already been created up
            String filename22 = "Station.json";
            FileStream reader = new FileStream(filename22, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(station));

            stationVariable2 = (station)inputSerializer.ReadObject(reader);

           // Console.WriteLine(stationVariable2.toString());

            
          
    reader.Close();
    */
            /*
            TrainScheduleUnitTesting randomVarianleName = new TrainScheduleUnitTesting();
           
            randomVarianleName.UnitTestStationArrival(); //calling function that test the methods in the stationArrival class
             randomVarianleName.UnitTestStation(); //calling function that test the methods in the station class
            //Serialize station
            station stationVariable = new station();
            String filename = "Station.json";
           

            FileStream writer = new FileStream(filename, FileMode.Create,
               FileAccess.Write);

            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(station));

            ser.WriteObject(writer, stationVariable);
            writer.Close();


            //Deserialize station
            station stationVariable2;
            //the file that is being pass here has already been created up
            String filename22 = "Station.json";
            FileStream reader = new FileStream(filename22, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(station));
            
            stationVariable2 = (station)inputSerializer.ReadObject(reader);
            reader.Close();



            //Serialize stationArrival
            StationArrival StationArrivalVariable = new StationArrival();
            String filename2 = "StationArrival.json";


            FileStream writer2 = new FileStream(filename2, FileMode.Create,
               FileAccess.Write);

            DataContractJsonSerializer ser2;
            ser2 = new DataContractJsonSerializer(typeof(StationArrival));

            ser2.WriteObject(writer2, StationArrivalVariable);
            writer2.Close();



            //Deserialize stationArrival
            StationArrival StationArrivalVariable2;
            //the file that is being pass here has already been created up
            String filename222 = "StationArrival.json";
            FileStream reader2 = new FileStream(filename222, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer2;
            inputSerializer2 = new DataContractJsonSerializer(typeof(StationArrival));

            StationArrivalVariable2 = (StationArrival)inputSerializer2.ReadObject(reader2);
            reader2.Close();



                    Console.Write("Enter filename (.json): ");
                    String tempFileName;
                    tempFileName = Console.ReadLine();
                    String fff = File.ReadAllText(tempFileName);
                    Console.WriteLine(fff);

            
            station m_station = new station();
            station m_station2 = new station();

            m_station.Id = 100;
            m_station2.Id = 888;

            m_station.Name =  "juan";
            m_station2.Name = "boi";

            m_station.location = "Main St"; 
            m_station2.location = "Croley";
  
            m_station.FareZone = 100;
            m_station2.FareZone = 999;

            m_station.MilageToPenn =100; 
            m_station2.MilageToPenn = 789;
           
            m_station.PicFileName = "dog.jpg"; 
            m_station2.PicFileName = "cat.jpd";

            StationCollection collect = new StationCollection();

            collect.stationList.Add(m_station);
            collect.stationList.Add(m_station2);
            Console.WriteLine(collect.ToString());



            */

        }
    }
}
