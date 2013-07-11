using System;
using System.Collections;
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
            //var file = new FileReader();
            //file.ReadToArray("numbers.txt");
            //file.ListArray();
            var array = new ArrayList() {6,5,4,3,2,1};
            var inv = new Inversion();
            var sor = inv.CountInversion(array);
            int a = inv.inversionCount;
            Console.WriteLine(a);
        }
    }



    public class Inversion
    {
        public int inversionCount = 0;
        public int GetSplitPLace(int size)
        {
            return (int)(size / 2);
        }

        public ArrayList CountInversion(ArrayList source)
        {
            if (source.Count == 1)
            {
                return source;
            }
            var split = (int) (source.Count/2); //GetSplitPLace(to - from);
            ArrayList leftArray = source.GetRange(0, split);
            ArrayList rightArray = source.GetRange(split, source.Count - split);
            ArrayList arrSortedInt = new ArrayList();
            leftArray = CountInversion(leftArray);
            rightArray = CountInversion(rightArray);
            int leftptr = 0;
            int rightptr = 0;
            for (int i = 0; i < leftArray.Count + rightArray.Count; i++)
            {
                if (leftptr == leftArray.Count)
                {
                    arrSortedInt.Add(rightArray[rightptr]);
                    rightptr++;
                }
                else if (rightptr == rightArray.Count)
                {

                    inversionCount += 1;
                    arrSortedInt.Add(leftArray[leftptr]);
                    leftptr++;
                }
                else if ((int)leftArray[leftptr] < (int)rightArray[rightptr])
                {
                   
                    //need the cast above since arraylist returns Type object
                    arrSortedInt.Add(leftArray[leftptr]);
                    leftptr++;
                }
                else
                {
                    inversionCount += 1;
                    arrSortedInt.Add(rightArray[rightptr]);
                    rightptr++;
                }
            }
            //var splited = CountSplited(leftArray,rightArray);
            return arrSortedInt;
        }

        private int CountSplited(ArrayList left, ArrayList right)
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
