using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    public class StationList {
        private List<Station> _listOfStations;

        public StationList() {
            _listOfStations = new List<Station>();
        }

        public StationList(bool load = false) {
            if (load == true) {
                _listOfStations = new List<Station>(LoadStationData());
            } else {
                _listOfStations = new List<Station>();
            }
        }
        
        public void AddStation(string x) {
            _listOfStations.Add(new Station(new DepartureList(), x));
        }

        public List<Station> LoadStationData() {
            var stations = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            return stations;
        }

        public void saveStationData() {
            WriteToBinaryFile(@"Accounts.txt", _listOfStations, false);
        }

        public Station GetStationByLocation(string x) {
            return _listOfStations.Where(y => y.GetLocation() == x).First();
        }

        /// <summary>
        /// This method takes the List of CustomerAccount object and binary serializes it, allowing the persistence of data.
        /// </summary>
        /// <param name="filePath">This is the file name/output directory.</param>
        /// <param name="objectToWrite">This is the object that gets serialized. Can be of any type.</param>
        /// <param name="append">This flags whether to append the object to the end of the file (if it exists already)</param>
        /// <typeparam name="T">This is the type of T</typeparam>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// This method reads in the object that has been serialized and returns it to the calling statement.
        /// </summary>
        /// <param name="filePath">A string containing the file path of which file to load.</param>
        /// <typeparam name="T">The return type which the object should be cast to, in order to be returned.</typeparam>
        /// <returns>(T)binaryFormatter.Deserialize(stream)</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
