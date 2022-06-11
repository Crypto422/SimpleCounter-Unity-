// Add System.IO to work with files!
using System.IO;
// Add System.Runtime.Serialization.Formatters.Binary to work with BinaryFormatter!
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{

    private int count;
    private static string savename;
    private static GameDataManager _instance;
    public static GameDataManager Instance { get { return _instance; } }

    // Create a field of this class for the file to write
    string saveFile;

    void Awake()
    {
        _instance = this;

        DontDestroyOnLoad(gameObject);


        try
        {
            if (!Directory.Exists(Path.Combine("Save", "")))
            {
                Directory.CreateDirectory(Path.Combine("Save", ""));
            }

        }
        catch (IOException ex)
        {
            Debug.Log(ex);
        }
    }

    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            count = value;
        }
    }

   
    public static string SaveName
    {
        get
        {
            return savename;
        }
        set
        {
            savename = value;
        }
    }

    public void WriteData(string extension)
    {
        string filename = SaveName + extension;
        saveFile = Path.Combine("Save", filename);
        Write();
    }

    public void ReadData(string extension)
    {
        string filename = SaveName + extension;
        saveFile = Path.Combine("Save", filename);
        Read();
    }

 

 
    public  void Write()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(saveFile, FileMode.Create)))
        {
            writer.Write(Count);
        }
    }

    public  void Read()
    {
        if (File.Exists(saveFile))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(saveFile, FileMode.Open)))
            {
                Count = reader.ReadInt32();
            }

        }
    }
}