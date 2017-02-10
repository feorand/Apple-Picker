using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class AppleDroppedBehaviour : MonoBehaviour {
	public Initializer initializer;

	void OnCollisionEnter(Collision collision) {
		var apples = GameObject.FindGameObjectsWithTag ("Apple");
		foreach (var apple in apples) {
			Destroy (apple);
		}
		
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
