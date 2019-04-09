using System;
using System.Collections.Generic;
using System.Linq;

namespace Encryption.Tasks
{
    public class Task4 : IEncoder
    {
        public string Encrypt(string str)
        {
            var singleton = DataSingleton.GetInstance();
            var alphabet = singleton.GetAlphabets();
            
            var strValues = str.ToUpper().ToCharArray().ToList()
                .Select(x => alphabet.First(f => f.Letter == x).PositionInAlphabet).ToList();
            
            var keyValues = singleton.Task4Key.ToUpper().DoubleStrings(str.Length)
                .Select(x => alphabet.First(f => f.Letter == x).PositionInAlphabet).ToList();

            return string.Join("",
                strValues.Zip(keyValues, (x, y) => x + y >= alphabet.Count ? x + y - alphabet.Count : x + y).ToList()
                    .Select(x => alphabet.First(f => f.PositionInAlphabet == x).Letter).ToList());
        }

        public string Decrypt(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}