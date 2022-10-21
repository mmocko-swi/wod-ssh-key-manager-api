using System;
using System.Runtime.InteropServices;

namespace WeOnlyDo.Security.Cryptography
{
    public class KeyManager : IDisposable
    {
        public KeyManager()
        {
            throw new NotImplementedException();
        }

        public SSHKeyTypes Load(string fileName)
        {
            throw new NotImplementedException();
        }

        public SSHKeyTypes Load(string fileName, string password)
        {
            throw new NotImplementedException();
        }

        public void Save(string fileName)
        {
            throw new NotImplementedException();
        }

        public void Save(string fileName, string password)
        {
            throw new NotImplementedException();
        }

        public void Save(SSHKeyTypes type, string fileName)
        {
            throw new NotImplementedException();
        }

        public void Save(SSHKeyTypes type, string fileName, string password)
        {
            throw new NotImplementedException();
        }

        public void Generate(SSHKeyTypes type, int bitCount)
        {
            throw new NotImplementedException();
        }

        public void Generate(SSHKeyTypes type)
        {
            throw new NotImplementedException();
        }

        public void PrivateKey(SSHKeyTypes type, byte[] newVal)
        {
            throw new NotImplementedException();
        }

        public byte[] PrivateKey(SSHKeyTypes type)
        {
            throw new NotImplementedException();
        }

        public byte[] PublicKey(SSHKeyTypes type)
        {
            throw new NotImplementedException();
        }

        public string PublicKeyOpenSSH(SSHKeyTypes type)
        {
            throw new NotImplementedException();
        }

        public string PublicKeySSH(SSHKeyTypes type)
        {
            throw new NotImplementedException();
        }

        public static string Version()
        {
            throw new NotImplementedException();
        }

        public void FromXmlString(string xmlKey)
        {
            throw new NotImplementedException();
        }

        public string ToXmlString(SSHKeyTypes keyType, [MarshalAs(UnmanagedType.U1)] bool whatever)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool whatever)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
