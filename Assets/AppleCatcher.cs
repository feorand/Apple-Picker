using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcher : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(collision.gameObject);
	}
}
