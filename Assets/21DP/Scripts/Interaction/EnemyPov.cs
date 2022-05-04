using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPov : MonoBehaviour
{
    public Transform player;
    public GameObject[] enemySprites;
    Vector3 dpf;
    Vector3 dpb;
    public float back;
    public float front;
    public void Start()
    {
        //player = enemyManager._player;
    }
    void Update()
    {
        back = Vector3.Distance(player.position, enemySprites[0].transform.position);
        front = Vector3.Distance(player.position, enemySprites[1].transform.position);
        if (front < back)
        {
            enemySprites[0].gameObject.SetActive(true);
            enemySprites[1].gameObject.SetActive(false);
        }
        else if (back < front)
        {
            enemySprites[0].gameObject.SetActive(false);
            enemySprites[1].gameObject.SetActive(true);
        }
    }
}
