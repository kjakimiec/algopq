using System.Collections;
using System.IO;

public class FileReader
{
    ArrayList array = new ArrayList();


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

    public ArrayList GetArray()
    {
        return array;
    }

    public void ListArray()
    {
        foreach (var i in array)
            System.Console.WriteLine(i);
    }
}
