using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject outlineMesh;

    private void Start()
    {
        outlineMesh = gameObject.transform.GetChild(0).gameObject;
    }
    public void OnLookingAt(bool state)
    {
        if (outlineMesh != null)
        {
            outlineMesh.SetActive(state);
        }

    }
    public virtual void OnInteraction()
    {

    }
    public virtual void OnGrab(Transform parent) { }
}
