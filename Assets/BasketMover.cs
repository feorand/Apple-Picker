using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMover : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		var screenMousePosition = Input.mousePosition;
		screenMousePosition.z = Camera.main.transform.position.z;
		var mousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);
		var basketPosition = transform.position;
		basketPosition.x = mousePosition.x;
		transform.position = basketPosition;
	}
}
