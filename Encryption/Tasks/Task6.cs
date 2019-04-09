using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Encryption.Model;

namespace Encryption.Tasks
{
    public class Task6 : IEncoder
    {
        public string Encrypt(string str)
        {
            var task6Key = DataSingleton.GetInstance().Task6Key.ToList()
                .Select(x => new ShifrantTask6() {Letter = x.ToString(), Values = new List<char>()})
                .ToList();

            Regex.Matches(str.Replace(" ", "").ToUpper(), @"\w{1," + task6Key.Count + "}", RegexOptions.Multiline)
                .Select(x => x.ToString()).ToList().ForEach(item =>
                {
                    var list = item.ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        task6Key[i].Values.Add(list[i]);
                    }
                });

            return string.Join("  ", task6Key.OrderBy(x => x.Letter).Select(x => string.Join("", x.Values)));
        }

        public string Decrypt(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}