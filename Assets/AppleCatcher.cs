using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcher : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {
		var gameObject = collision.gameObject;

		if (gameObject.name == "Apple(Clone)") {
			Destroy (gameObject);
			ScoreCounter.Score += 10;
			ScoreCounter.PrintScore ();
		}
	}
}
