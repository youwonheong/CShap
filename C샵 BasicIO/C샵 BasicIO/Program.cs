using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x12345678ABCDEF0;
            Console.WriteLine("{0, -1} : 0x{1:X16}", "Original Data", someValue);
            Stream outStream = new FileStream("a.dat", FileMode.Create); // a.dat 파일 생성
            byte[] wBytes = BitConverter.GetBytes(someValue);

            Console.WriteLine("{0, -13 } : ", "Byte array");
            foreach (byte b in wBytes)
                Console.Write("{0:X2} ", b);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
                rbytes[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rbytes, 0);
            Console.WriteLine("{0, -13} : {1:X16}", "Read Data", readValue);
            inStream.Close();

        }
    }
}
