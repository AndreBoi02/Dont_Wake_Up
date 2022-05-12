using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
     public int toyCounter = 0;

    public void Update()
    {
        if (toyCounter >= 3)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Toy")
        {
            toyCounter += 1;
        }
    }
}
