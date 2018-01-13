using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
    public Transform[] patrolPoints; // Transform array
    public float moveSpeed = 3.0f; 
    private int currentPoint;

	// Use this for initialization
	void Start () {
        transform.position = patrolPoints[0].position; // Enemy movement to position in the patrol points
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update() {

        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint = currentPoint + 1; // currentPoint++

        }

        if (currentPoint >= (patrolPoints.Length)) // Looping back to waypoint 1
        {
            currentPoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);
	}
}
