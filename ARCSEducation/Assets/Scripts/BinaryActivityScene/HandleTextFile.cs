using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HandleTextFile {

    static void WriteString() {
        string path = "Assets/Resources/TextFiles/BinaryActivity/test.txt";

        // Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = Resource.Load("test");

        // Print the text from the file
        Debug.Log(asset.text);
    }

    static void ReadString(){
        string path = "Assets/Resources/TextFiles/BinaryActivity/test.txt";

        // Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

}
