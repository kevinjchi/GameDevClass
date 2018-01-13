using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyParticles : MonoBehaviour {
    public float lifetime = 1.3f; // lifetime of particles

	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
