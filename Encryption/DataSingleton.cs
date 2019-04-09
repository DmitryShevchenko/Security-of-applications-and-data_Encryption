using System.Collections.Generic;
using System.IO;
using Encryption.Model;
using Newtonsoft.Json;

namespace Encryption
{
    public class DataSingleton
    {
        private DataSingleton(){}
        public string Gaslo => "SCRUM_";
        public string Task4Key => "ZLOTY";
        public string Task6Key => "ADMIRAL";

        private List<Alphabet> _alphabets;

        private List<Shifrant> _shifrantSequence;

        private static DataSingleton _instance;

        public static DataSingleton GetInstance() 
            => _instance ?? (_instance = new DataSingleton());

        public List<Alphabet> GetAlphabets()
            => _alphabets ?? (_alphabets =
                   JsonConvert.DeserializeObject<List<Alphabet>>(
                       File.ReadAllText(
                           "F:/Безпека програм та даних/Encryption/Encryption/JsonData/alphabet.json")));


        public List<Shifrant> GetShifrantSequence()
            => _shifrantSequence ?? (_shifrantSequence =
                   JsonConvert.DeserializeObject<List<Shifrant>>(
                       File.ReadAllText(
                           "F:/Безпека програм та даних/Encryption/Encryption/JsonData/Shifrant.json")));


        public char[,] GetMatrix()
            => new[,]
            {
                {'K', 'W', 'R', 'H', ','},
                {'P', 'T', 'B', 'N', 'U'},
                {'_', 'D', 'O', 'Z', 'E'},
                {'J', 'F', '.', 'C', 'Y'},
                {'V', 'G', 'A', 'I', 'X'},
                {'M', '-', 'Q', 'L', 'S'}
            };
    }
}