using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomConsole : MonoBehaviour
{
    public GameObject button;
    public GameObject button2;
    public Transform [] spawnPoints;
    int occupiedPoint;
    int newPoint;

    private void Start()
    {
        occupiedPoint = Random.Range(0, 5);
        Debug.Log(occupiedPoint);
        button.transform.position = spawnPoints[occupiedPoint].position;
        newPoint = Random.Range(0, 5);
        Debug.Log(newPoint);
    }

    private void Update()
    {
        if (newPoint == occupiedPoint)
        {
            newPoint = Random.Range(0, 5);
            Debug.Log(newPoint);
            button2.transform.position = spawnPoints[newPoint].position;
        }
        else if (newPoint != occupiedPoint)
        {
            button2.transform.position = spawnPoints[newPoint].position;
        }
    }
}
