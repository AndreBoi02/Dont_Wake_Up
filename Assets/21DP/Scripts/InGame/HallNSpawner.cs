using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallNSpawner : MonoBehaviour
{
    public Transform wall1;
    public Transform wall2;
    public Transform spawnPoint;
    public GameObject enemy;
    int oneEnemyOnly = 1;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemySpawn();
            escapeOpen();
        }
    }

    void escapeOpen()
    {
        wall1.gameObject.SetActive(false);
        wall2.gameObject.SetActive(false);
    }

    void enemySpawn()
    {
        if (oneEnemyOnly >= 1)
        {
            Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity);
            oneEnemyOnly -= 1;
        }
        
    }
}
