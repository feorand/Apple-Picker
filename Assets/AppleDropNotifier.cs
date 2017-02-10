using UnityEngine;
using UnityEngine.Events;

public class AppleDropNotifier : MonoBehaviour {
	public UnityEvent AppleDropped = new UnityEvent();

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Apple(Clone)") {
			AppleDropped.Invoke ();
		}
	}
}
