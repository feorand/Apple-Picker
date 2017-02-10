using UnityEngine;
using UnityEngine.Events;
using System;

public class AppleCatchNotifier : MonoBehaviour {
	public UnityEvent appleCaught = new UnityEvent();

	void OnCollisionEnter(Collision collision) {
		var collisionObject = collision.gameObject;
		if (collisionObject.tag == "Apple") {
			Destroy (collisionObject);
			appleCaught.Invoke ();
		}
	}
}
