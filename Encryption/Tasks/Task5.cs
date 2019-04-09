using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Encryption.Model;

namespace Encryption.Tasks
{
    public class Task5 : IEncoder
    {
        public string Encrypt(string str) => string.Join(" ", GetBigrams(str));

        private IEnumerable<string> GetBigrams(string word)
            => Regex.Matches(word.Replace(" ", string.Empty).ToUpper(), @"\w{1,2}").Select(x => x.ToString())
                .Select(FindEncrypted);


        private string FindEncrypted(string code)
        {
            if (code.Length == 1)
            {
                return code;
            }

            var matrix = DataSingleton.GetInstance().GetMatrix();

            var list = new List<MatrixElement>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (code.Contains(matrix[i, j]))
                    {
                        list.Add(new MatrixElement() {Row = i, Column = j});
                    }
                }
            }

            var row1 = list[1].Row;
            list[1].Row = list[0].Row;
            list[0].Row = row1;

            return string.Join("",
                matrix[list[0].Row, list[0].Column].ToString() + matrix[list[1].Row, list[1].Column].ToString());
        }

       

        public string Decrypt(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}