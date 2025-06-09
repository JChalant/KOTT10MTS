using System.Collections.Generic;
using UnityEngine;

public class MobFactory : MonoBehaviour
{
    public float difficultyScalerUnity;
    public static float difficultyScaler;
    public static int difficulty =1;
    public List<string> smallEnemies;
    public List<string> mediumEnemies;
    public List<string> largeEnemies;
    List<EnemySpawn> spawnPoints;
    public void create(List<EnemySpawn> enemySpawns)
    {
        spawnPoints = enemySpawns;
        difficultyScaler = difficultyScalerUnity;
    }
    public static void incrememntDifficulty()
    {
        difficulty++;
        Debug.Log("difficulty: " + difficulty);
    }
    public void SpawnWeak(int i) 
    {
        int rand = Random.Range(1, smallEnemies.Count);
        string enemyName = smallEnemies[rand-1];
        //Debug.Log("enemyName: " + enemyName);
        spawnMob(enemyName, spawnPoints[i].getSpawnPoint(), spawnPoints[i].gate);

    }
    public void SpawnMedium(int i) 
    {
        int rand = Random.Range(1, mediumEnemies.Count);
        string enemyName = mediumEnemies[rand - 1];
        //Debug.Log("enemyName: " + enemyName);
        spawnMob(enemyName, spawnPoints[i].getSpawnPoint(), spawnPoints[i].gate);
    }
    public void SpawnStrong(int i)
    {
        int rand = Random.Range(1, largeEnemies.Count);
        string enemyName = largeEnemies[rand - 1];
        //Debug.Log("enemyName: " + enemyName);
        spawnMob(enemyName, spawnPoints[i].getSpawnPoint(), spawnPoints[i].gate);
    }
    public GameObject getMobPrefab(string mobName)
    {
        //Debug.Log("Mob coming in: " + mobName);
        string filePath = "EnemyPrefabs/" + mobName;
        //Debug.Log("FilePath: " + filePath);
        GameObject enemy = Resources.Load(filePath) as GameObject;
        //Debug.Log("EnemyPrefab:" + enemy);
        return enemy;
    }
    public void spawnMob(string enemyName, Transform spawnPoint, Gate gate)
    {
        GameObject prefab = getMobPrefab(enemyName);
        //Debug.Log("prefab:" +prefab);
        GameObject enemy = Instantiate(prefab, spawnPoint);
        Enemy enemyScript = enemy.GetComponent<Enemy>();
        enemyScript.onSpawn(difficulty, gate);
    }
    
}
