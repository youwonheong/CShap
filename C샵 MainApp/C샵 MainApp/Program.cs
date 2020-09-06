using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if(args.Length < 1) // 이름이 없으면
            {
                directory = ".";
            }
            else
            {
                directory = args[0];
            }
            Console.WriteLine($"{directory} directory Info");
            Console.Write("- Directories : ");
            var directories = (from dir in Directory.GetDirectories(directory) // 하위 디렉토리를 참조 
                               let info = new DirectoryInfo(dir) // 참조한 디렉토리들을 범위 변수 info에 저장
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes,
                                   //디렉토리들의 이름과 속성
                               }
                               ).ToList();
            foreach(var d in directories)
            {
                Console.WriteLine($"{d.Name} : {d.Attributes}");

            }
            Console.WriteLine("- Files : ");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attribute = info.Attributes
                         }
                         ).ToList();
            foreach(var f in files)
            {
                Console.WriteLine($"{f.Name} : {f.FileSize} : {f.Attribute}");
            }
        }
    }
}
