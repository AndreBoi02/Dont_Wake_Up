using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps_Shooter : MonoBehaviour
{
    public GameObject proyectile;
    public Transform spawnPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject instance = Instantiate(proyectile, spawnPoint.position, Quaternion.identity);
            instance.transform.localEulerAngles = transform.eulerAngles;
        }
            
    }

}
