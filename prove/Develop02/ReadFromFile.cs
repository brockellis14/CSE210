using System;

class ReadFile
{
    string _fileName;
    string _filePath;

    public ReadFile(string fileName_)
    {
        _fileName = fileName_;
        _filePath = _fileName + ".txt";
    }

    public void LoadEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(_filePath);
        foreach (string line in lines)
        {
            Console.WriteLine($"{line}");
        }
    }
}