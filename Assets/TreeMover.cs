using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMover : MonoBehaviour {
	public float minX;
	public float maxX;
	public float speed;
	public bool moveToRight;
	public float chanceToChangeDirection;

	float timeBetweenChanges = 1;
	float timeUntilNextChange = 1;

	// Update is called once per frame
	void Update () {
		moveTree (speed * Time.deltaTime, moveToRight);

		if (transform.position.x > maxX || transform.position.x < minX) {
			moveToRight = !moveToRight;
		}

		if (timeUntilNextChange <= 0) { 
			var changeDirection = Random.value;
			if (changeDirection < chanceToChangeDirection)
				moveToRight = !moveToRight;

			timeUntilNextChange = timeBetweenChanges;
		}

		timeUntilNextChange -= Time.deltaTime;

	}

	void moveTree(float distance, bool toRight) {
		var position = transform.position;

		if (toRight)
			position.x += distance;
		else
			position.x -= distance;

		transform.position = position;
	}
}
