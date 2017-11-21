using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;

public class HandleTextFile {


    public List<string> Load(string fileName) {
        
        List<string> targets = new List<string>();
        try
        {
            string line;
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            using (theReader)
            {
                do
                {
                    line = theReader.ReadLine();
                    if (line != null)
                    {
                        targets.Add(line);
                    }
                } while (line != null);
                theReader.Close();
                return targets;
            }
        }
        catch (Exception e)
        {
            
            Console.WriteLine("{0}\n", e.Message);
            return new List<string>();
        }
    }

}
