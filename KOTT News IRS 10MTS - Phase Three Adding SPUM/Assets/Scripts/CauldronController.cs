using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronController : MonoBehaviour
{
    public bool isInUse;
    public string currentString = "Available to use!";
    [SerializeField] public float remainingTime; // time until cauldron can be used again 

    private int thisRotation;

    public void UseObject()
    {
        thisRotation = (int)transform.rotation.z;    // this object's transform rotation z axis, which MUST be set to either 1 or -1
        if (!isInUse)
        {
            isInUse = true;
            Debug.Log("Cauldron used. rotation value is: " + thisRotation);

            for (int i = 1; i < 110; i++)
            {
                transform.rotation.z += thisRotation;  // incrementing the rotation by 1/-1
            }
            // set cauldron png to empty image

            // start 15s timer and create variable for 'else' call below
            if (remainingTime > 0)                      // countdown
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime < 0)                  // stop countdown, and do end of timer things. Like; StartInvasion(); &/o GameOver();
            {
                for (int i = 1; i < 110; i++)
                {
                    transform.rotation.z -= thisRotation;  // incrementing the rotation by 1/-1
                }
                // set cauldron png to full image
                remainingTime = 0;
                                           
            }

                        // isInUse = false; // final reset for use again
        }
        else
        {
            // output message; time remaining in sec. (until the cauldron resets)
        }
    }
}
