using UnityEngine;
[System.Serializable]
public class EnemySpawn
{
    public Gate gate;
    public Transform transform;
    public Transform getSpawnPoint()
    {
        return transform;
    }
}
