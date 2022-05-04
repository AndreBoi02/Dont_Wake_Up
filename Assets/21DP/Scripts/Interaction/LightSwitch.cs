using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{

    private Light myLight;
    private Material material;
    private Color emissionColor;
    private void Start()
    {
        myLight = GetComponent<Light>();
        material = GetComponent<Renderer>().material;
        emissionColor = material.GetColor("_EmissionColor");
    }
    public override void OnInteraction()
    {
        emissionColor *= -1;
        material.SetColor("_EmissionColor", emissionColor);
        myLight.enabled = !myLight.enabled;
    }   
}