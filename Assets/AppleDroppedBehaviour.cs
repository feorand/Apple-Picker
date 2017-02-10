using UnityEngine;
using UnityEngine.Events;

public class AppleDroppedBehaviour : MonoBehaviour {
	public UnityEvent AppleDropped = new UnityEvent();

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Apple(Clone)") {
			AppleDropped.Invoke ();
		}
	}
}
