using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public Transform player;
    public static Transform _player;

    public int availableEnemy;
    public static int _maxEnemyCount;
    private void Start()
    {
        _player = player;
        _maxEnemyCount = availableEnemy;
;
    }
}
