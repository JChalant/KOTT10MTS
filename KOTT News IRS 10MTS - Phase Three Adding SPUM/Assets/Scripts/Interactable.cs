using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange)   // If in range to interact
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();    // fire off event ie. read sign, turn cauldron
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player now in range");
        }    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        Debug.Log("Player now OUT of range");
    }    
    
}
