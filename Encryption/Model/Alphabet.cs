using System;
using System.Collections.Generic;
using System.IO;

namespace Encryption.Model
{
    public class Alphabet
    {
        public char Letter { get; set; }
        public int PositionInAlphabet { get; set; }
        public int EncryptionPosition { get; set; }               
    }
}