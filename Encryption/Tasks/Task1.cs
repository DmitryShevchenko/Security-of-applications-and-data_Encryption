using System;
using System.Collections.Generic;
using System.Linq;
using Encryption.Model;

namespace Encryption.Tasks
{
    public class Task1 : IEncoder
    {
        public string Encrypt(string str)
        {
            var alphabets = DataSingleton.GetInstance().GetAlphabets();
            var surName = str.ToCharArray().ToList();
            
            var encryptionPositionList = new List<Alphabet>();
            
            surName.ForEach(letter =>
            {
                encryptionPositionList.Add(alphabets.Find(x => x.Letter.Equals(letter)));
            });
            
            var wordList = new List<char>();
            
            encryptionPositionList.ForEach(alp =>
            {
                wordList.Add(alphabets.Find(x => x.PositionInAlphabet.Equals(alp.EncryptionPosition)).Letter);
            });

            return String.Join("", wordList);

        }

        public string Decrypt(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}