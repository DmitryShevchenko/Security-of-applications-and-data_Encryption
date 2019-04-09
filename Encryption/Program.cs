using Encryption.Tasks;

namespace Encryption
{
    class Program
    {
        private const string SurName = "SHEVCHENKO";

        private const string FullName = "SHEVCHENKO DMITRY ALEKSANDROVICH";

        static void Main(string[] args)
        {
            var encoder = new Encoder();
            encoder.SetEncoder(new Task1());
            encoder.Run(SurName);
            
            
            encoder.SetEncoder(new Task2());
            encoder.Run(SurName);
            
            encoder.SetEncoder(new Task3());
            encoder.Run(SurName);
            
            encoder.SetEncoder(new Task4());
            encoder.Run(SurName);
            
            encoder.SetEncoder(new Task5());
            encoder.Run(SurName);
            
            encoder.SetEncoder(new Task6());
            encoder.Run(FullName);
        }
    }
}