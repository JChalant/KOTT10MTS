using UnityEngine;

public class WaveRunner : MonoBehaviour
{
    public MobFactory mobFactory;
    public static WaveRunner instance;
    public GameObject spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        spawnWave(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnWave(int smallEnemiesNum, int mediumEnemiesNum, int strongEnemiesNum)
    {
        for (int i = 0; i < smallEnemiesNum; i++)
        {
            mobFactory.SpawnWeak(spawnPoint.transform);
        }
        for (int i = 0; i < mediumEnemiesNum; i++)
        {
            mobFactory.SpawnMedium(spawnPoint.transform);
        }
        for (int i = 0; i < strongEnemiesNum; i++)
        {
            mobFactory.SpawnStrong(spawnPoint.transform);
        }

    }
}
