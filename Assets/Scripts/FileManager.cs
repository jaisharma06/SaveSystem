using System.IO;
using UnityEngine;

public class FileManager
{
    private static string directory;
    private static string filePath;

    public static void CreateSaveDirectory(string directoryName = "SaveSytem")
    {
        string path = Path.Combine(Application.persistentDataPath, directoryName);
        bool exists = Directory.Exists(path);
        if (!exists)
        {
            Directory.CreateDirectory(path);
        }

        directory = path;
    }

    public static void CreateSaveFile(string fileName = "save.dat")
    {
        string path = Path.Combine(directory, fileName);
        bool exists = File.Exists(path);
        if (!exists)
        {
            File.Create(path);
        }

        filePath = path;

        Debug.Log("File Path: " + filePath);
    }


    public static void SaveData<T>(T dataObj)
    {
        string data = JsonUtility.ToJson(dataObj);
        File.WriteAllText(filePath, data);
    }

    public static T GetData<T>()
    {
        T result;
        string data = File.ReadAllText(filePath);
        result = JsonUtility.FromJson<T>(data);
        return result;
    }
}
