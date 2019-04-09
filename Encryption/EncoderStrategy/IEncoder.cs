namespace Encryption
{
    public interface IEncoder
    {
        string Encrypt(string str);
        string Decrypt(string str);
    }
}