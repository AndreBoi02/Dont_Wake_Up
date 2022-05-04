using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulable : Interactable
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void OnGrab(Transform parent)
    {
        base.OnGrab(parent);
        rb.useGravity = false;

        transform.SetParent(parent);
    }
}
