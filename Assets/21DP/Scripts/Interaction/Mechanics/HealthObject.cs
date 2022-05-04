using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    public enum Type {Damage, HealtPack }
    public Type myType;

    public float healtModifier = 25;
}
