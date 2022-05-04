using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
   public Text nameText;
   public Text classText;
   public Text levelText;

    private void Update()
    {
        /*if (Selector._selectedObject != null)
        {
            CharSelec selectedCharacter = Selector._selectedObject.GetComponent<CharSelec>();
            nameText.text = selectedCharacter.getName();
            classText.text = selectedCharacter.getClass();
            levelText.text = selectedCharacter.getLevel().ToString();
        }*/
    }
}
