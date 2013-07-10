using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CountingInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileReader();
            file.ReadToArray("numbers.txt");
            file.ListArray();
        }
    }



    public class Inversion
    {
        public int GetSplitPLace(int size)
        {
            return (int)(size / 2);
        }

        public int CountInversion(IList<int> source,int from, int to)
        {
            var split = GetSplitPLace(to-from);
            var left = CountInversion(source, 0, split);
            var right = CountInversion(source, split, to);
            var splited = CountSplited();
            return left+right+splited;
        }

        private int CountSplited()
        {
            throw new NotImplementedException();
        }


    }


    public class FileReader
    {
        List<int> array = new List<int>();


        public void ReadToArray(string fileName)
        {
            var fileDesc = File.OpenText(fileName);
            string line;
            while ((line = fileDesc.ReadLine()) != null)
            {
                array.Add(int.Parse(line));
            }

            fileDesc.Close();
        }

        public void ListArray()
        {
            foreach (var i in array)
                System.Console.WriteLine(i);
        }
    }
}
