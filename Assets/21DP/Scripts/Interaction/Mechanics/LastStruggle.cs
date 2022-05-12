using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastStruggle : MonoBehaviour
{
    public GameObject[] EnemySpawns;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Light")
        {
            EnemySpawns[0].SetActive(true);
            EnemySpawns[1].SetActive(true);
            EnemySpawns[2].SetActive(true);
            EnemySpawns[3].SetActive(true);
        }
    }
}
