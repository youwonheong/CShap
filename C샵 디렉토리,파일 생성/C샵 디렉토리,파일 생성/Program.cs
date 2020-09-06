using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_디렉토리_파일_생성
{
    class Program
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
        }
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Usage : Touch.exe <path> [Type : File/Directory]");
                return;
            }
            string path = args[0];
            string type = "File";
            if(args.Length > 1)
            {
                type = args[1];
            }
            if(File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now); 
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated {path} {type}"); 
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
            }
            Console.WriteLine($"Created {path} {type}");
        }
    }
}
