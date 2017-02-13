using UnityEngine;
using UnityEngine.Events;

public class AppleCatchNotifier : MonoBehaviour {
	public UnityEvent appleCaught;

	void OnCollisionEnter(Collision collision) {
		var collisionObject = collision.gameObject;
		if (collisionObject.tag == "Apple") {
			Destroy (collisionObject);
			appleCaught.Invoke ();
		}
	}
}
