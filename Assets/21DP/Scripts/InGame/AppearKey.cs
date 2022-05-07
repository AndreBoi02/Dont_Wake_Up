using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearKey : MonoBehaviour
{
    public Transform KeySP;
    public GameObject Key;
    public bool O1, O2 = false;

    private void Update()
    {
        if (O1 == true && O2 == true)
        {
            KeyOn();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "o1")
        {
            O1 = true;
            Debug.Log("First One Pressed");
        }
        if (other.name == "o2")
        {
            O2 = true;
            Debug.Log("Second One Pressed");
        }
    }
    void KeyOn()
    {
        Key.gameObject.transform.position = KeySP.position;
        Key.gameObject.SetActive(true);
    }
}
