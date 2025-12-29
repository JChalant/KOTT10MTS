using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class DoorController : MonoBehaviour
{
    private GameObject player;  // the player
    public GameObject pairedDoor;  // door object linked to this object, as this links to that
    public bool trapDoor;  // Does door object have a tilemap, meaning a trap door 


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void UseObject()
    {
        if (trapDoor)
        {
            Debug.Log("In trapDoor is true");
            // set canMove to false for player
            //turn on tilemap component of this.Object (see roberts spawn runner "GATE" objects for reference potential)
            // play stairs down music
            // set player behind background layer
            // CLOSE TRAP DOOR (turn off tilemap)
            player.transform.position = new Vector2(pairedDoor.transform.position.x, pairedDoor.transform.position.y); // move player to pairedDoor
            // play stairs up music
            // OPEN TRAP DOOR pairedDoor
            // return player to layer 5
            // set door object to false (for non visible)
            // set canMove to true for player
        }
        else
        {
            Debug.Log("In trapDoor is false");
            // set canMove to false for player
            // set player behind background layer to slow move over, ot ignore for snap teleport
            player.transform.position = new Vector2(pairedDoor.transform.position.x, pairedDoor.transform.position.y); // move player to pairedDoor
            // return player to layer 5
            // set canMove to true for player
        }
    }
}
