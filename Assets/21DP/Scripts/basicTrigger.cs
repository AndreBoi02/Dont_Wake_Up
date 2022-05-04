using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //other.gameObject.SetActive(false);
        other.transform.position = Vector3.up * 5;
    }
}
