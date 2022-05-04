using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    float resistence = 100f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            TakeDamege(collision.gameObject.GetComponent<Projectile>().GetDamegeAmount());
        }
    }
    void TakeDamege(float damage)
    {
        resistence -= damage;
        if (resistence <= 0)
        {
            GetComponent<Dropper>().Drop(transform.position);
            Destroy(gameObject);
        }
            
    }
}
