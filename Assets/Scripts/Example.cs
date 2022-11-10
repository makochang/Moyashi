using System;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = Application.persistentDataPath + "/saveData.txt";
        Debug.Log(path);
        string readData=FileManager.ReadString(path);
        long readBin;
        long.TryParse(readData, out readBin);
        Debug.Log(DateTime.FromBinary(readBin));
        DateTime dateTime = DateTime.Now;
        string data = dateTime.ToBinary().ToString();
        FileManager.WriteString(path, data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
