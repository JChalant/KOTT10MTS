using System.Collections.Generic;
using UnityEngine;

public class MobFactory : MonoBehaviour
{
    public List<string> smallEnemies;
    public List<string> mediumEnemies;
    public List<string> largeEnemies;
    public void SpawnWeak(Transform spawnPoint) 
    {
        int rand = Random.Range(1, smallEnemies.Count);
        string enemyName = smallEnemies[rand-1];
        //Debug.Log("enemyName: " + enemyName);
        GameObject prefab = SpanwMob(enemyName);
        //Debug.Log("prefab:" +prefab);
        Instantiate(prefab, spawnPoint);

    }
    public void SpawnMedium(Transform spawnPoint) 
    {
        int rand = Random.Range(1, mediumEnemies.Count);
        string enemyName = mediumEnemies[rand - 1];
        //Debug.Log("enemyName: " + enemyName);
        GameObject prefab = SpanwMob(enemyName);
        //Debug.Log("prefab:" +prefab);
        Instantiate(prefab, spawnPoint);
    }
    public void SpawnStrong(Transform spawnPoint)
    {
        int rand = Random.Range(1, largeEnemies.Count);
        string enemyName = largeEnemies[rand - 1];
        //Debug.Log("enemyName: " + enemyName);
        GameObject prefab = SpanwMob(enemyName);
        //Debug.Log("prefab:" +prefab);
        Instantiate(prefab, spawnPoint);
    }
    public GameObject SpanwMob(string mobName)
    {
        //Debug.Log("Mob coming in: " + mobName);
        string filePath = "EnemyPrefabs/" + mobName;
        //Debug.Log("FilePath: " + filePath);
        GameObject enemy = Resources.Load(filePath) as GameObject;
        //Debug.Log("EnemyPrefab:" + enemy);
        return enemy;
    }
}
