using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMover : MonoBehaviour {
	void Update () {
		var screenMousePosition = Input.mousePosition;
		screenMousePosition.z = Camera.main.transform.position.z;

		var mousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);
		var transition = new Vector3 (mousePosition.x - transform.position.x, 0, 0);

		transform.Translate (transition);
	}
}
