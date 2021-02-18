using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples";

            string[] allDirectories = Directory.GetDirectories(rootpath);
            ReadArray(allDirectories);

            string[] includeNestDirectories = Directory.GetDirectories(rootpath,"*", SearchOption.AllDirectories);
            ReadArray(includeNestDirectories);

            string[] files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);
        }

        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
