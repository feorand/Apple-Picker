using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRules : MonoBehaviour {
	public int numberOfBaskets;
	static public int BasketsLeft;
	public GameObject basketPrefab;
	public float lowestBasketY;
	public float spaceBetweenBaskets;

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

	public void OnAppleCatch() {
		ScoreCounter.Score += 10;
	}

	public void OnAppleDrop() {
		var apples = GameObject.FindGameObjectsWithTag ("Apple");
		foreach (var apple in apples) {
			Destroy (apple);
		}

		if (BasketsLeft > 0) {
			var basket = GameObject.Find ("Basket(Clone)");
			Destroy (basket);
			BasketsLeft -= 1;
		}

		if (BasketsLeft == 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
