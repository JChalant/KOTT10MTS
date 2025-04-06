using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignController : MonoBehaviour
{
    public bool isRead;
    public string currentString = "Did not read sign!";

    public void UseObject()
    {
        if(!isRead)
        {
            isRead = true;
            currentString = "Sign is read!";
            Debug.Log(currentString);       //for now. at implementation this will be THIS sign's string
            Debug.Log("Item used");

        }
    }
}
