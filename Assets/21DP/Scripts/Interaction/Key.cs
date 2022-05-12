using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
    public int ID = 0;
    public override void OnPickUp()
    {
        Inventory.SaveItem(this);
        LevelManager.Send2Pool(this.gameObject);
        gameObject.SetActive(false);
    }
}
