using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour {
	public int numberOfBaskets;
	static public int BasketsLeft;
	public GameObject basketPrefab;
	public float lowestBasketY;
	public float spaceBetweenBaskets;

	// Use this for initialization
	void Start () {
		BasketsLeft = numberOfBaskets;
		SpawnBaskets (numberOfBaskets, lowestBasketY, spaceBetweenBaskets);
		ScoreCounter.Score = 0;
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
