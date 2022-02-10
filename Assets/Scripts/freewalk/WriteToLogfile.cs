using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System;
using TMPro;

public class WriteToLogfile : MonoBehaviour
{
    private int count = 0;
    public Transform vrCamera;
    public TextMeshProUGUI roundInfo;

    private string path;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.persistentDataPath + "/userdata" + System.DateTime.Now.ToString("HH-mm-ss") + ".txt";
        // WriteStringToLocal("start log: \n");
        WriteLogToFile(roundInfo.text);
    }

    // Update is called once per frame
    void Update()
    {
        
        count++;
        if (count == 50)
        {
            count = 0;
            // WriteStringToLocal(vrCamera.position.ToString());
            WriteLogToFile(vrCamera.position.ToString());
        }
    }

    //[MenuItem("Tools/Write file")]
    static void WriteStringToLocal(string message)
    {
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(message);
        writer.Close();

    }


    //[MenuItem("Tools/Read file")]
    static void ReadString()
    {
        string path = "Assets/Resources/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    private void WriteLogToFile(string message)
    {
        print("~~~~~~~~~~" + path);
        StreamWriter file = new StreamWriter(path, true);
        file.WriteLine(message);
        file.Close();
    }
}
