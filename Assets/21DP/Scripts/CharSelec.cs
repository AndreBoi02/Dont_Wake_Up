using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelec : MonoBehaviour
{
    [SerializeField]
    private string hisName;
    [SerializeField]
    private string hisClass;
    [SerializeField]
    private int level;

    public string getName(){ return hisName; }
    public string getClass() { return hisClass; }
    public int getLevel() { return level; }

}
