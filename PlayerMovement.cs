using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Movement speed of playerObject
    public float moveSpeed = 10.0f;
    public float speedModifier = 20.0f;
    public Rigidbody rb;
    public GameObject deathParticles;

    private float maxSpeed = 8.0f;
    private Vector3 UserInput;
    private Vector3 spawn; //Spawn

	// Use this for initialization
	void Start () { 
        rb = GetComponent<Rigidbody>();

        spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () { // Use fixedUpdate?
        UserInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")); // Nothing to the y-axis, since gravity determines this
        // Can use GetAxis for gradual movement
        if (rb.velocity.magnitude < maxSpeed)
        {
            // Make the rigidBody from unity move
            rb.AddForce(UserInput * speedModifier);
        }
        if (transform.position.y < -2)
        {
            Die();
        }
	}
    void OnCollisionEnter(Collision other) //Store the information in other
     
    {
        if (other.transform.tag == "Enemy")    // Remember to add Enemy Tag in Unity
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            transform.position = spawn; // If collision, spawn back to square 1
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy") // Use enemy tag for Traps-objekts as well
        {
            Die();
        }
        if (other.transform.tag == "Goal")
        {
            GameMng.CompleteLevel();
        }
    }

    void Die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        transform.position = spawn; // If collision, spawn back to square 1
    }
}
