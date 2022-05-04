using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private Image healthBar;

    [SerializeField]
    private float hp;

    private void OnTriggerEnter(Collider other)
    {
        HealthObject healthObject = other.gameObject.GetComponent<HealthObject>();

        if (healthObject != null)
        {
            ManageHealth(healthObject.healtModifier);
            if (healthObject.myType == HealthObject.Type.HealtPack)
                Destroy(healthObject.gameObject);
        }
    }

    void ManageHealth(float modifier)
    {
        hp += modifier;
        float fillAmount = hp * .01f;
        healthBar.fillAmount = fillAmount;
    }
    void Update()
    {
        if (hp <= 0)
        {
            Debug.Log("You're Dead");
        }
    }
}
