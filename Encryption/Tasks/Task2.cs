using System.Linq;

namespace Encryption.Tasks
{
    public class Task2 : IEncoder
    {
        
        public string Encrypt(string str)
        {
            var alphabetsSingleton = DataSingleton.GetInstance();
            var alphabetsLettersList = alphabetsSingleton.GetAlphabets().Select(x => x.Letter).ToList();
            var list = alphabetsLettersList.Except(alphabetsSingleton.Gaslo.Select(x => x)).ToList();
            list.InsertRange(0, alphabetsSingleton.Gaslo);
            var dictionary = alphabetsLettersList.MapToDirectory(list);
            return string.Join("", str.Select(x => dictionary[x]));
        }

        public string Decrypt(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}