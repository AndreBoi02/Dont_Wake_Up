using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearWall : MonoBehaviour
{
    public Transform wall;
    public int ID;

    private void OnTriggerEnter(Collider other)
    {
        if (Inventory.HasKey(ID))
            escapeOpen();
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
