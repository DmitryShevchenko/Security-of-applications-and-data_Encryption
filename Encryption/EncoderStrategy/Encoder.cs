using System;
using System.Collections.Generic;

namespace Encryption
{
    public class Encoder
    {
        private IEncoder _encoder;

        public void SetEncoder(IEncoder encoder)
        {
            if (encoder == null)
                throw new ArgumentNullException();
            _encoder = encoder;
        }

        public void Run(string str)
        {
            Console.WriteLine(String.Join(" ", "Encrypt", _encoder.GetType().FullName, _encoder.Encrypt(str)));
        }
    }
}