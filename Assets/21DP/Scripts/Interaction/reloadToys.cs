using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadToys : Interactable
{
    public HeathSystem heathSystem;
    public override void OnInteraction()
    {
        heathSystem.Invoke("ReloadToys", .5f);
    }
}
