using System;
using System.Collections;

public class Inversion
{
    public Int64 inversionCount = 0;
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
        var split = (int)(source.Count / 2); //GetSplitPLace(to - from);
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
                inversionCount += (leftArray.Count - leftptr);
                arrSortedInt.Add(rightArray[rightptr]);
                rightptr++;
            }
        }
       
        return arrSortedInt;
    }
}