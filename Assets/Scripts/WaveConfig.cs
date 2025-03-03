using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 6.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject GetEnemyPrefab() {return enemyPrefab;}

    public List<Transform> GetWayPoints()
    {
        var waveWayPoints = new List<Transform>();

        foreach (Transform child in pathPrefab.transform)
        {
            waveWayPoints.Add(child);
        }

        return waveWayPoints;
    }

    public float GetTimeBetweenSpawns() {return timeBetweenSpawns;}

    public float GetSpawnRandomFactor() {return spawnRandomFactor;}

    public int GetNumberOfEnemies() {return numberOfEnemies;}

    public float GetMoveSpeed() {return moveSpeed;}
}

