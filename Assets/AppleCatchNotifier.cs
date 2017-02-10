using UnityEngine;
using UnityEngine.Events;
using System;

public class AppleCatchNotifier : MonoBehaviour {
	[Serializable]
	public class AppleCaught: UnityEvent<GameObject> {}

	public AppleCaught appleCaught = new AppleCaught();

	void OnCollisionEnter(Collision collision) {
		var collisionObject = collision.gameObject;
		if (collisionObject.tag == "Basket") {
			appleCaught.Invoke (gameObject);
		}
	}
}
