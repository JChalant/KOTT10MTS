using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignController : MonoBehaviour
{
    public bool isRead;
    public string currentString;
    public int signNumber;
    

    public void UseObject()
    {
        if(!isRead)
        {
            isRead = true;
            Debug.Log("isRead set to true. need to icrement sign counter for difficulty.");
            MobFactory.incrememntDifficulty();
            // player.signCounter += 1;
        }
        Debug.Log(currentString);       //for now. at implementation this will output to speech/thought bubble.
        Debug.Log("regardless of isRead, sign is read.");
    }
}
