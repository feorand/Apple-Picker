using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppleDroppedBehaviour : MonoBehaviour {
	public Initializer initializer;

	void OnCollisionEnter(Collision collision) {
		Destroy (collision.gameObject);

		if (Initializer.baskets.Count > 0) {
			var basket = Initializer.baskets [0];
			Destroy (basket);
			Initializer.baskets.Remove (basket);
		}

		if (Initializer.baskets.Count == 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
