using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class AppleCatcher : MonoBehaviour {
	[Serializable]
	public class AppleCaught: UnityEvent<GameObject> {}

	public AppleCaught appleCaught = new AppleCaught();

	void OnCollisionEnter(Collision collision) {
		var collisionObject = collision.gameObject;
		if (collisionObject.name == "Basket(Clone)") {
			appleCaught.Invoke (gameObject);
		}
	}
}
