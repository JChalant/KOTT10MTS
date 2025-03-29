using UnityEngine;

public class PsuedoCode : MonoBehaviour
{
    // To Do: find main in UNITY and incorporate
    //******************************************

    // start screen
    //************

    // runtime
    //********
    // 2:00 countdown timer to start of Invasion during which time player01 can investigate inside keep. meeting NPCs to accomplish 'tasks', // and gathering items maybe?
    // talking to certain NPCs (cptns Invasion Response Squad) will increment #of cptns (toggle 'spoke with' to create item specific notes final final report output at game conclusion?)
    // certain trap doors in the keep give access to a secret 'sign', should they be locked prior to go time?
    // seret signs are interacted with, in order to gain +X points, and increment difficulty of training simulator. (discussed more during wave handling section)
    //
    // during this time, the 49 NPC_prefabs should be; captns in position, some others walking around, but many in 'the line' incrementring through, then proceeding to first/last stand position inside the keep
    // (the 'last stand' position will only come into play if I build it so things can get in, and the NPCs for THAT GATE only, fall back inside.)




    // enemy waves, 5 locations, every 20 seconds, for ten minutes (60 spawns)
    // monsters included: trash mobs(have with SPUM), brute (could scale SPUM), commander (scale w/SPUM), priest(Scale w/SPUM), Spriggin (need tree sprite?), bear (dont want necessarily), giant head (need)
    //
    // 1 = trash hoard
    // 2 = trash hoard
    // 3 = brute
    // 4 = bombers
    // 5 = brute again
    // 6 = priest
    // 7 = Spriggan
    // 8 = Commander
    // 9 = Adiana Theron!
    // no number = the giant head
    //
    // at start of 10:00 countdown timer
    // remove collison detection of invisible wall containing player01
    // send the 49 NPC_prefabs to their designated positions
    // *********************
    // spawn wave loop here:
    //**********************
    // initiate red_obelisk
    // go through spawner locations , check spawn table, spawn(int), next spawner location
    //**********************
    // base Spawn table:
    // minute 1(1,1,1)
    // minute 2(1,1,2)
    // minute 3(1,2,2)
    // minute 4(1,2,3)
    // minute 5(1,3,3)
    // minute 6(2,3,4)
    // minute 7(2,4,4)
    // minute 8(2,4,5)
    // minute 9(2,5,5)
    // minute 10(2,5,6)
    //***********************
    // 1:00 contdown timer in 20 secend increments
    // start a 0:20s internal 1/3 segment so we do three spawn per minute/wave)
    // this_increment = 1
    // do
    //  // send out one level 1 mob everywhere
    //  // get the base spawn, add any bumps from sign_interaction difficulty adjustments. check for caps to this number, then pass it to the mob spawning method
    // //this...every 20 seconds
    //
    // this_increment+=
    // while this_increment < 3
    //
    //*************************


}
