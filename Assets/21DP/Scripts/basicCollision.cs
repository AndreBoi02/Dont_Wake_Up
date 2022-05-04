using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        collision.gameObject.transform.localScale *= 2;
    }
}
