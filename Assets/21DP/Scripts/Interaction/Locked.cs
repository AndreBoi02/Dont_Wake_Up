using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locked : Interactable
{
    public int ID;

    public override void OnInteraction()
    {
        Debug.Log("Trying to access...");
        if (Inventory.HasKey(ID))
            OpenLock();
        else
            Debug.Log("Can't open");
    }

    void OpenLock()
    {
        Debug.Log("Open");
        GetComponent<Animator>().enabled = true;
    }
}