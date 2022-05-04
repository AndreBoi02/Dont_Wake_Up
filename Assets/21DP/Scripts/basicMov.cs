using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMov : MonoBehaviour
{
    public float speedt = 1f;
    public float frecuency = 1f;
    public float lenght = 1f;
   
    public enum platType { H, V, C }
    public platType type;
    void Update()
    {
        float step = speedt * Time.deltaTime;
        //transform.position = new Vector3(transform.position.x + step, transform.position.y, transform.position.z); //position
        //transform.eulerAngles = new Vector3(transform.position.x, transform.position.y + step, transform.position.z); //rotation
        //transform.localScale = new Vector3(transform.position.x, transform.position.y, transform.position.z + step); //scale
        //transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frecuency) * lenght, transform.position.y, transform.position.z); //mov tipo sin se multiplica el sin es el alcance se multiplica x es la velocidad

        if (type == platType.H)
        {
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frecuency) * lenght, transform.position.y, transform.position.z);
        }
        else if (type == platType.V)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * frecuency) * lenght, transform.position.z);
        }
        else if (type == platType.C)
        {
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime * frecuency) * lenght, Mathf.Cos(Time.fixedTime * frecuency) *lenght, transform.position.z);
        }
    }
}
