using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject item;
    public float spawnTime = 3f;
    private void Start()
    {
        InvokeRepeating("SpawnItem", 1f, spawnTime);
    }
    void SpawnItem()
    {
        if (enemyManager._maxEnemyCount > 0)
        {
            Instantiate(item, transform.position, Quaternion.identity);
            enemyManager._maxEnemyCount --;
        }
        
    }
}
