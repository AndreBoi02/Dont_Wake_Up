using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearWall : MonoBehaviour
{
    public Transform wall;
    public GameObject enemy;
    public int ID;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy")
        {
            enemy = other.gameObject;
        }
        if (Inventory.HasKey(ID))
        {
            escapeOpen();
            Destroy(enemy);
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("escapeClose", 1);
        }
    }

    private void escapeOpen()
    {
        wall.gameObject.SetActive(false);
    }

    private void escapeClose()
    {
        wall.gameObject.SetActive(true);
    }
}
