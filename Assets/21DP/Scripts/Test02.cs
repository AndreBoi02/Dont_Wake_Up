using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    //Test1
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Light>().enabled = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Light>().enabled = false;
        }
    }

    //Click+Ctrl+r+r    Cambiar una variable y que se refleje en el c�digo
    //Alt+Pressedclick  Escribir al mismo tiempo en m�s de una l�nea de c�digo
    //Canvas, 2D, Escale w screan size
}
