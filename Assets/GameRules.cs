using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameRules : MonoBehaviour {
	public int numberOfBaskets;

	static int basketsLeft;
	static int highscore;
	static int score;

	void Start() {
		basketsLeft = numberOfBaskets;
		score = 0;
	}

	public void OnAppleCatch() {
		score += 10;
		if (score > highscore)
			highscore = score;

		GameObject.Find ("ScoreText")
			.GetComponent<ScoreTextUpdater> ()
			.OnScoreChanged (score, highscore);
	}

	public void OnAppleDrop() {
		var apples = GameObject.FindGameObjectsWithTag ("Apple");
		foreach (var apple in apples) {
			Destroy (apple);
		}

		if (basketsLeft > 0) {
			var basket = GameObject.Find ("Basket(Clone)");
			Destroy (basket);
			basketsLeft -= 1;
		}

		if (basketsLeft == 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
