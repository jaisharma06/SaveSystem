using System;
using System.Collections.Generic;

[Serializable]
public class SaveData
{
    public int starsCollected = 0;
    public int level = 0;
}

[Serializable]
public class AllLevelsData
{
    public List<SaveData> levelsData;

    public void AddSampleData(int totalLevels)
    {
        levelsData = new List<SaveData>();
        for (int i = 0; i < totalLevels; i++)
        {
            SaveData saveData = new SaveData();
            saveData.starsCollected = UnityEngine.Random.Range(1, 4);
            saveData.level = i + 1;
            levelsData.Add(saveData);
        }
    }

    public SaveData Add(SaveData data)
    {
        levelsData.Add(data);
        return data;
    }
}
