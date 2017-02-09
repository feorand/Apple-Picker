using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppleDroppedBehaviour : MonoBehaviour {
	public Initializer initializer;

	void OnCollisionEnter(Collision collision) {
		Destroy (collision.gameObject);

		if (Initializer.BasketsLeft > 0) {
			var basket = GameObject.Find ("Basket(Clone)");
			Destroy (basket);
			Initializer.BasketsLeft -= 1;
		}

		if (Initializer.BasketsLeft == 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
