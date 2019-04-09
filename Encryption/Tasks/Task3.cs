using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Encryption.Tasks
{
    class Task3 : IEncoder
    {
        public string Encrypt(string str)
        {
            var shifrants = DataSingleton.GetInstance().GetShifrantSequence()
                .Where(x => x.Letter.Any(str.Contains)).ToList();

            var resultList = new List<int>();
            str.ToUpper().ToList().ForEach(item =>
            {
                resultList.Add(shifrants.Where(x => x.Letter == item.ToString())
                    .Select(x => x.Values.ElementAt(new Random().Next(x.Values.Count))).First());
            });

            return string.Join(" ", resultList.ToArray());
        }

        public string Decrypt(string str)
        {
            var intList = str.Split(" ").ToList().Select(int.Parse).ToList();
            return string.Join("", intList.Select(x =>
                    DataSingleton.GetInstance().GetShifrantSequence().First(f => f.Values.Contains(x)).Letter)
                .ToList());
        }
    }
}
