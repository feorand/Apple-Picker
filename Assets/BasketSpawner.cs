using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketSpawner : MonoBehaviour {
	public GameObject basketPrefab;
	public float lowestBasketY;
	public float spaceBetweenBaskets;

	void Start () {
		var numberOfBaskets = GetComponent<GameRules> ().numberOfBaskets;
		SpawnBaskets (numberOfBaskets, lowestBasketY, spaceBetweenBaskets);
		Cursor.visible = false;
	}

	void MovePrefab(GameObject prefab, float y) {
		var position = prefab.transform.position;
		position.y = y;
		prefab.transform.position = position;
	}

	void SpawnBaskets(int number, float lowestPos, float spaceBetween) {
		var nextY = lowestPos;
		for (var i = 0; i < number; i++) {
			MovePrefab(basketPrefab, nextY);
			Instantiate (basketPrefab);
			nextY += spaceBetween;
		}
	}
}
