using System.Collections.Generic;
using UnityEngine;

public class WaveRunner : MonoBehaviour
{
    public MobFactory mobFactory;
    public static WaveRunner instance;
    public List<EnemySpawn> spawnPoints;
    public List<Wave> waves;
    public float timeBetweenWaves;
    int waveCount;
    int maxSpawnPoints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waveCount = 0;
        maxSpawnPoints = spawnPoints.Count;
        instance = this;
        mobFactory.create(spawnPoints);
        for(int i = 0; i<waves.Count; i++)
        {
            Invoke("spawnWave", (timeBetweenWaves*(i+1)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnWave()
    {
        Wave wave = waves[waveCount];   
        int smallEnemiesNum = wave.smallEnemyCount;
        int mediumEnemiesNum = wave.mediumEnemyCount;
        int strongEnemiesNum = wave.largeEnemyCount;
        for (int i = 0; i < smallEnemiesNum; i++)
        {
            int rand = Random.Range(0, maxSpawnPoints);
            mobFactory.SpawnWeak(rand);
        }
        for (int i = 0; i < mediumEnemiesNum; i++)
        {
            int rand = Random.Range(0, maxSpawnPoints);
            mobFactory.SpawnMedium(rand);
        }
        for (int i = 0; i < strongEnemiesNum; i++)
        {
            int rand = Random.Range(0, maxSpawnPoints);
            mobFactory.SpawnStrong(rand);
        }
        waveCount++;
    }
}
