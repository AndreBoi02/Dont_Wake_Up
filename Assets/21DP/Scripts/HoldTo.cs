using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldTo : MonoBehaviour
{
    public float progress;

    float maxed = 10;

    float chargeSpeed = 1;

    bool buttonHeldDown = false;
    bool interrupted = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            HoldButton();
        }
        else if(Input.GetKeyUp(KeyCode.F))
        {
            RealeasedButton();
        }

        if (buttonHeldDown)
        {
            progress += Time.deltaTime * chargeSpeed;
        }
        else if (interrupted)
        {
            progress = 0;
        }

        if (progress >= maxed)
        {
            
        }
    }

    public void HoldButton()
    {
        buttonHeldDown = true;
        interrupted = false;
    }
    public void RealeasedButton()
    {
        buttonHeldDown = false;
        interrupted = true;
    }
}
