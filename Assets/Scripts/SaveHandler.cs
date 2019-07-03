using UnityEngine;

public class SaveHandler : MonoBehaviour
{
    public AllLevelsData gameData;
    private SaveManager saveManager;

    // Start is called before the first frame update
    void Start()
    {
        saveManager = SaveManager.instance;
        gameData = saveManager.GetSavedData<AllLevelsData>();
    }


    public void AddNewLevelData(int level, int starsCollected)
    {
        SaveData levelData = new SaveData();
        levelData.level = level;
        levelData.starsCollected = starsCollected;
        gameData.Add(levelData);
    }

    public void UpdateLevelData(int level, int starsCollected)
    {

    }

    public void DeleteLevelData(int level)
    {

    }
}
