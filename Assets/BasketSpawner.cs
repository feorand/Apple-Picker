using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketSpawner : MonoBehaviour {
	public GameObject basketPrefab;
	public float lowestBasketY;
	public float spaceBetweenBaskets;

	void Start () {
		Cursor.visible = false;
		var numberOfBaskets = GetComponent<GameRules> ().numberOfBaskets;

		var nextY = lowestBasketY;
		for (var i = 0; i < numberOfBaskets; i++) {
			var basket = Instantiate (basketPrefab);
			basket.transform.Translate (new Vector3 (0, nextY - basket.transform.position.y, 0));
			nextY += spaceBetweenBaskets;
		}
	}
}
