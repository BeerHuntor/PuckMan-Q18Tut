using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 3; // How many world-space "tiles" this unit moves in a second. 

    Vector2 direction;//the current direction we want to move in.

    // Update is called once per frame
    void Update()
    {
        //We have some kind of direction/velocity that we are moving in
        //So move in that direction
        //....IF WE CAN! What if there's a wall in the way? Then we stop.    
    }
}
