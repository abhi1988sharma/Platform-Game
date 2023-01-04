using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    public GameObject[] waypoints; // declared the gameobject in array, it allows to add as many object(waypoints neeeded)
    private int currentWaypointIndex = 0;
    public float speed = 1f;
   
    void Update()
    {
        // Distance method calculates distance between two ngame objects
        // checks how far is from currently active waypoints
        // used .1 as it might be possible that 0 could not be detecded
        if(Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            // if touchs it, switch to the next one
            currentWaypointIndex++;

         // waypoint.length is the length
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        // MoveTowards method calculates the new positions between two game objects
        //takes object(platform / enemy) position and starts moving towards waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
        
    }

    
}
