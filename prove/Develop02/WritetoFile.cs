using System;
using System.Collections.Generic;
using System.IO;

class WriteToFile
{

    private string _fileName;

    public WriteToFile(string fileName)
    {
        _fileName = fileName + ".txt";
    }

    public void SaveEntries(List<Entry> entries)
    {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                outputFile.WriteLine("Journal Entries:");
                
                
                foreach (var entry in entries)
                {
                    outputFile.WriteLine(entry.GetFormattedEntry());
                }
            }

            
            Console.WriteLine($"Journal successfully saved to {_fileName}");
        }
}

