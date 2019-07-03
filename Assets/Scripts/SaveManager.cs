using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private static SaveManager _instance;
    public static SaveManager instance { get { return _instance; } }


    private void Awake()
    {
        if (!_instance)
        {
            _instance = this;
        }

        if (_instance != this)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        InitializeSaveData();
    }

    public void InitializeSaveData()
    {
        FileManager.CreateSaveDirectory("SaveManager");
        FileManager.CreateSaveFile("save.dat");
    }

    public T GetSavedData<T>()
    {
        T result;
        result = FileManager.GetData<T>();
        return result;
    }

    public void SaveGame<T>(T gameData)
    {
        FileManager.SaveData(gameData);
    }
}
