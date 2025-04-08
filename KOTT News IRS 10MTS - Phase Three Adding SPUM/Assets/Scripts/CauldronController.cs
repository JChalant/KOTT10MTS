using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CauldronController : MonoBehaviour
{
    public bool isInUse;
    public int leftOrRight; // set manually to (-1/1)
    public float secondsToReload;   // entered through inspector for adjustable value. (I dont remember if its 10,12, or 15s)
    private float remainingTime; // time until cauldron can be used again 
    public Sprite fullCauldronPNG; // image to use for full cauldron. should be identical to cauldron object!
    public Sprite emptyCauldronPNG; // Image to use for empty cauldron
    
    public void UseObject()
    {
        
        if (!isInUse)
        {
            isInUse = true;
            Debug.Log("Cauldron used");

            remainingTime = secondsToReload;

            //play audio

            if (leftOrRight >= 0)    // 1 represents "left" / counter clockwise rotation 
            {

                //rotate game object?
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 110f);

            }
            else if (leftOrRight < 0)   // -1 represents "right" / clockwise rotation 
            {
                //rotate game object?
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -110f);
            }

            // set cauldron png to empty image
            this.gameObject.GetComponent<SpriteRenderer>().sprite = emptyCauldronPNG; 

            // start 15s timer and create variable for 'else' call below/
            // Should be happening during Update already

        }
        else
        {
            // output message; time remaining in sec. (until the cauldron resets)
            Debug.Log(remainingTime);
        }
    }

    void Update()
    {

        if (remainingTime > 0)                      // countdown
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)                  // stop countdown, and do end of timer things. 
        {
            //play audio

            //rotate game object back?
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);

            // set cauldron png to full image
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fullCauldronPNG; // the image set as default 

            isInUse = false;
            remainingTime = 0;

        }

    }
}
