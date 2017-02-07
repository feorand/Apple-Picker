using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour {
	public int numberOfBaskets;
	static List<GameObject> baskets;
	public GameObject basketPrefab;
	public float lowestBasketY;
	public float spaceBetweenBaskets;

	// Use this for initialization
	void Start () {
		SpawnBaskets (numberOfBaskets, lowestBasketY, spaceBetweenBaskets);

		//Cursor.visible = false;
	}

	void MovePrefab(GameObject prefab, float y) {
		var position = prefab.transform.position;
		position.y = y;
		prefab.transform.position = position;
	}

	void SpawnBaskets(int number, float lowestPos, float spaceBetween) {
		var nextY = lowestPos;
		baskets = new List<GameObject>();
		for (var i = 0; i < number; i++) {
			MovePrefab(basketPrefab, nextY);
			baskets.Add(Instantiate(basketPrefab));
			nextY += spaceBetween;
		}
	}
}
